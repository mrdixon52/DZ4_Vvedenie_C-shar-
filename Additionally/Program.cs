Console.Clear();
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(0, 11);  //делал для большей наглядности, в задаче условие должно быть array[i]=new Random().Next(0, 101)
Console.WriteLine($"Array: [{string.Join(", ", array)}]");

Console.Write("Enter K: ");
int[] arr = new int [n];
int k = Convert.ToInt32(Console.ReadLine());
int a = arr.Length;
if (k > 0)
{
    for (int i = 0; i < k; i++)
    arr[i] = array[a - k + i];
    for (int z = 0; z + k < a; z++)
    arr[z + k] = array[z];
}
else 
{
    for (int j = 0; j < Math.Abs(k); j++)
    arr[a - Math.Abs(k) + j] = array[j];
    for (int v = 0; v + Math.Abs(k) < a; v++)
    arr[v] = array[v + Math.Abs(k)];
}
Console.WriteLine($"Result [{string.Join(", ", arr)}]");