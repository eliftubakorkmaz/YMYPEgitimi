

try
{
    int a = 0;
    int b = 0;
    int sonuc = a / b;
} 
catch (Exception ex)
{
    Console.WriteLine($"Hata : {ex.Message}");
}
finally
{
    Console.WriteLine("Ben halükarda çalışırım.");
}