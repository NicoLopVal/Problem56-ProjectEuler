using System.Numerics;
double maxDigitalSum = 0;

for(int a = 1; a <= 100; a++)
{
    for(int b = 1; b <= 100; b++)
    {
        if (DigitSum(BigPow(a, b).ToString()) > maxDigitalSum)
            maxDigitalSum = DigitSum(BigPow(a, b).ToString());
    }
}

Console.WriteLine("The maximum digital sum is: " + maxDigitalSum);

BigInteger BigPow(int a, int b)
{
    BigInteger sum = 1;
    for(int i = 1; i<=b; i++)
    {
        sum = sum * a;
    }
    return sum;
}

double DigitSum(string number)
{
    double sum = 0;
    foreach(char c in number)
    {
        sum += Convert.ToDouble(c.ToString());
    }
    return sum;
}