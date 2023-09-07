
/*class Program
{
    static void Main(string[] args)
    {
        var x = 5;
        var y = 3;

        int result = 0;

        while (x > 0)
        {
            if ((x & 1) > 0) result += y;

            y <<= 1;
            x >>= 1;
        }

        Console.WriteLine(result);
        Console.ReadKey();
    }
}*/
/*int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 0; i < Math.Abs(n); i++) result += m;
if(n < 0 || m < 0)
{
    Console.WriteLine( -result) ;
}
else
{ 
Console.WriteLine(result);
}*/
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int result = 0;
int sign1 = Math.Sign(a); 
int singn2 = Math.Sign(b);

a = Math.Abs(a);
b = Math.Abs(b);
for (var i = 0; i < a;i++) result += b;
if (sign1 == singn2)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine(-result);
}