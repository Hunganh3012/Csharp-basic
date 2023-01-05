using System;

try
{
    int a = 10;
    float b = a / 0;
}
catch(Exception ex)
{
    Console.WriteLine("Chuong trinh loi");
}
finally
{
    Console.WriteLine("ook");    
}