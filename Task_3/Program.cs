/* В двумерном массиве заменить элементы, у которых 
оба индекса четные, на их квадраты*/

void PrintMatrix (int[,]matr)
{
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(1);j++)
            Console.Write($"{matr[i,j]} ");
        Console.WriteLine();
    }
}

int [,] FillMatrix (int rows, int columns, int minValue, int maxValue)
{
    int[,]matrix=new int[rows,columns];
    var Random=new Random();
    for (int i=0;i<rows;i++)
        for (int j=0;j<columns;j++)
            matrix[i,j]=new Random().Next(minValue,maxValue);
    return matrix;
}

void EvIndSq (int[,]matr)
{
for (int i=0;i<matr.GetLength(0);i++)
{
    for (int j=0;j<matr.GetLength(1);j++)
        if(i%2==0&&j%2==0)
            Console.Write($"{matr[i,j]*matr[i,j]} ");
        else
            Console.Write($"{matr[i,j]} ");
        
    Console.WriteLine();
}
Console.WriteLine();
}

Console.Clear();
Console.Write("Enter amount of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter left side of matrix elements: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side of matrix elements: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = FillMatrix(rows,columns,start,finish);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
EvIndSq(matrix);
