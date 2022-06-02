// Задать двумерный массив следующим правилом: Amn=m+n
Console.Clear();
Console.Write("Enter your amount of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter your amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] a = new int[rows,columns];
for (int i=0;i<rows;i++)
{
    for (int j=0;j<columns;j++)
    {
        a[i, j] = i+j; 
        Console.Write($"{a[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
