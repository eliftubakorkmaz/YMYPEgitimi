using _02.MarketDesktopApp.Constants;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace _02.MarketDesktopApp;

public partial class Form1 : Form
{
    int receiptId = 0;
    decimal total = 0;
    decimal remaing = 0;
    List<ReceiptDetail> ReceiptDetails = new();
    List<ReceiptPayment> ReceiptPayments = new();
    SqlConnection connection = new(Connection.ConnectionString);
    public Form1()
    {
        InitializeComponent();
    }

    private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            connection.Open();

            int id = 0;
            int.TryParse(txtBarcode.Text, out id);
            if (id == 0)
            {
                MessageBox.Show("Sadece numaratik değerler girebilirsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "Select TOP 1 * FROM Products where Id=" + Convert.ToInt32(txtBarcode.Text);
            SqlCommand command = new(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                var name = reader["Name"].ToString();
                var price = (decimal)reader["Price"];
                AddShoppingCart(id, name, price);
            }
            else
            {
                MessageBox.Show("Ürün Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }
    }

    private void AddShoppingCart(int id, string name, decimal price)
    {
        dgList.Rows.Add();
        int count = dgList.Rows.Count - 1;

        dgList.Rows[count].Cells[0].Value = count + 1;
        dgList.Rows[count].Cells[1].Value = name;
        dgList.Rows[count].Cells[2].Value = 1;
        dgList.Rows[count].Cells[3].Value = price;
        dgList.Rows[count].Cells[4].Value = (price * 1).ToString("#,##0.00") + " ₺ ";

        txtBarcode.Text = "";

        for (int i = 0; i < dgList.Rows.Count; i++)
        {
            total += Convert.ToDecimal(dgList.Rows[i].Cells[3].Value);
        }

        lbTotal.Text = total.ToString("#,##0.00") + " ₺ ";

        decimal totalPayment = 0;
        for (int i = 0; i < dgPayment.Rows.Count; i++)
        {
            totalPayment += (Convert.ToDecimal(dgPayment.Rows[i].Cells[i].Value) * Convert.ToDecimal(dgList.Rows[i].Cells[2].Value));
        }

        remaing = total - totalPayment;

        lbRemaing.Text = (remaing).ToString("#,##0.00") + " ₺ ";
        txtPayment.Text = (remaing).ToString();

        ReceiptDetail receiptDetail = new()
        {
            Price = price,
            Total = price * 1,
            ProductId = id,
            ReceiptId = 1,
            Quantity = 1
        };
        ReceiptDetails.Add(receiptDetail);
    }

    private void btnKK_Click(object sender, EventArgs e)
    {
        string payment = txtPayment.Text;
        dgPayment.Rows.Add("Credit Card", payment);
        txtPayment.Text = "0";

        remaing -= Convert.ToDecimal(payment);
        if (remaing <= 0) gbPayment.Enabled = false;
        lbRemaing.Text = remaing.ToString("#,##0.00") + " ₺ ";

        ReceiptPayment receiptPayment = new()
        {
            ReceiptId = 1,
            Amount = Convert.ToDecimal(payment),
            Type = "Credit Card"
        };
        ReceiptPayments.Add(receiptPayment);
    }

    private void btnCash_Click(object sender, EventArgs e)
    {
        string payment = txtPayment.Text;
        dgPayment.Rows.Add("Cash", payment);
        txtPayment.Text = "0";

        remaing -= Convert.ToDecimal(payment);
        if (remaing <= 0) gbPayment.Enabled = false;
        lbRemaing.Text = remaing.ToString("#,##0.00") + " ₺ ";

        ReceiptPayment receiptPayment = new()
        {
            ReceiptId = 1,
            Amount = Convert.ToDecimal(payment),
            Type = "Cash"
        };
        ReceiptPayments.Add(receiptPayment);
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        Clear();
    }


    private void Clear()
    {
        dgList.Rows.Clear();
        dgPayment.Rows.Clear();
        lbRemaing.Text = "0,00 ₺";
        lbTotal.Text = "0,00 ₺";
        txtPayment.Text = "0,00 ₺";
        total = 0;
        remaing = 0;
        gbPayment.Enabled = true;
        txtBarcode.Focus();
        ReceiptDetails = new();
        ReceiptPayments = new();
        receiptId = 0;
    }

    private void btnComplete_Click(object sender, EventArgs e)
    {
        if (remaing > 0)
        {
            MessageBox.Show("Tüm ödeme yapılmadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        connection.Open();

        SqlTransaction transaction = connection.BeginTransaction();

        try
        {
            Guid ReceiptNumber = Guid.NewGuid();
            string query = "Insert into Receipts(Date,Total,Payment,Remaing, ReceiptNumber) Values(@Date,@Total,@Payment,@Remaing,@ReceiptNumber)";
            SqlCommand command = new(query, connection, transaction);
            command.Parameters.AddWithValue("@Date", DateTime.Now);
            command.Parameters.AddWithValue("@Total", total);
            command.Parameters.AddWithValue("@Payment", total - remaing);
            command.Parameters.AddWithValue("@Remaing", remaing);
            command.Parameters.AddWithValue("@ReceiptNumber", ReceiptNumber);

            command.ExecuteNonQuery();

            SqlCommand getIdCommand = new($"Select TOP 1 Id From Receipts where ReceiptNumber=@ReceiptNumber", connection, transaction);
            getIdCommand.Parameters.AddWithValue("@ReceiptNumber", ReceiptNumber);
            SqlDataReader reader = getIdCommand.ExecuteReader();
            if (!reader.Read())
            {
                reader.Close();
                connection.Close();
                return;
            }

            receiptId = (int)reader["Id"];
            reader.Close();
            foreach (var detail in ReceiptDetails)
            {
                string detailQuery = $"Insert into ReceiptDetails Values(@ReceiptId,@ProductId,@Quantity,@Price,@Total)";
                SqlCommand detailCommand = new(detailQuery, connection, transaction);
                detailCommand.Parameters.AddWithValue("@ReceiptId", receiptId);
                detailCommand.Parameters.AddWithValue("@ProductId", detail.ProductId);
                detailCommand.Parameters.AddWithValue("@Quantity", detail.Quantity);
                detailCommand.Parameters.AddWithValue("@Price", detail.Price);
                detailCommand.Parameters.AddWithValue("@Total", detail.Total);

                detailCommand.ExecuteNonQuery();
            }

            foreach (var payment in ReceiptPayments)
            {
                string paymentQuery = $"Insert into ReceiptPayments Values(@ReceiptId, @Type, @Amount)";
                SqlCommand paymentCommand = new(paymentQuery, connection, transaction);
                paymentCommand.Parameters.AddWithValue("@ReceiptId", receiptId);
                paymentCommand.Parameters.AddWithValue("@Type", payment.Type);
                paymentCommand.Parameters.AddWithValue("@Amount", payment.Amount);

                paymentCommand.ExecuteNonQuery();
            }

            transaction.Commit();

            Clear();

            MessageBox.Show("Alışveriş başarı ile tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            MessageBox.Show($"Kayıt esnasında bir hatayla karşılaştık \n{ex.Message}", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }
    }

    private void receiptsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form2 form2 = new();
        form2.Show();
    }

    private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form3 form3 = new(this);
        form3.Show();
        this.Hide();
    }
}

public class ReceiptDetail
{
    public int ReceiptId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Total { get; set; }
}

public class ReceiptPayment
{
    public int ReceiptId { get; set; }
    public string Type { get; set; }
    public decimal Amount { get; set; }
}
