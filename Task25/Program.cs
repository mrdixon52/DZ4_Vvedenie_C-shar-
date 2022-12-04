Console.Clear();
Console.Write("Enter first number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a;
int i = 1; 
while (i < b)
{
    c = c * a;
    i++;
}
Console.WriteLine($"A to the power of B = {c}");