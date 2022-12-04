Console.Clear();
Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0; 
int i = 1;
while (i < n)
{
    sum = sum + ((n / i) % 10);
    i = i * 10;
}
Console.WriteLine($"The sum of the digits in a number: {sum}");