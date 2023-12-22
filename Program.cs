class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Khai bao phan tu cua mang");
        Console.WriteLine("Nhap so hang cua hang");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so cot cua hang");
        int column = int.Parse(Console.ReadLine());
        int[,] array = new int[row, column];
        Console.WriteLine("Nhap thanh phan cua mang");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Mang la: ");
        for(int i = 0;i < row; i++)
        {
            for(int j = 0;j < column;j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine(" ");
        }
        // tim gia tri lon nhat
        int max = array[0, 0];
        for(int i = 0; i<row; i++)
        {
            for(int j=0; j<column;j++ )
            {
                if (array[i, j] > max )
                {
                    max = array[i, j];
                }
            }
        }
        Console.WriteLine("Gia tri lon nhat la: " + max);

    }
}