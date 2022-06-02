// Показать двумерный массив размером m×n, заполненный вещественными числами
Console.Clear();
Console.Write("Enter your amount of matrix rows: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter your amount of matrix columns: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
double[,] a = new double[m,n];
Random random = new Random();
for (int i=0;i<m;i++)
{
    for (int j=0;j<n;j++)
    {
        a[i, j] = random.NextDouble()*10; 
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
