using System.ComponentModel.Design;
using System.Timers;

namespace lesson3_二维数组_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 问题1
            //将1到10000赋值给一个二维数组1（100行100列）
            //int m = 0;
            //int[,] array=new int[100,100];
            //for(int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = ++m;
            //    }
            //}
            #endregion

            #region 问题2
            //将二维数组（4行4列）的右上半部分置零（元素随机1~100）
            //Random random = new Random();
            //int[,] array = new int[4, 4];
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (i <= 1 && j > 1)
            //        {
            //            array[i, j] = 0;
            //        }
            //        else
            //        {
            //            array[i, j] = random.Next(1, 101);
            //        }
            //    }
            //}
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            #region 问题3
            //求二维数组（3行3列）的对角线元素的和（元素随机1~10）
            Random random = new Random();
            int[,] array = new int[3, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 11);
                }
            }
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j|| i + j == 2)
                    {
                        sum = sum + array[i, j];
                    }
                }
            }
            #endregion

            #region 问题4
            //求二维数组（5行5列）中最大元素值及其行列号（元素随机1~500）
            //Random random = new Random();
            //int[,] array = new int[5, 5];
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = random.Next(1, 501);
            //    }
            //}
            //int max = 0;
            //int maxRow = 0;
            //int maxCol = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.WriteLine(array[i,j]);
            //        if (i == 0 && j == 0)
            //        {
            //            max = array[i, j];
            //        }
            //        else
            //        {
            //            if (array[i, j] > max)
            //            {
            //                max = array[i, j];
            //                maxRow = i; maxCol = j;
            //            }
            //        }
            //    }

            //}

            //Console.WriteLine($"最大值是{max}，行号是{maxRow}，列号是{maxCol}");
            #endregion

            #region 问题5
            //给一个M*N的二维数组，数组元素的值为O或者1，要求转换数组，将含有1的行和列全部置1

            //int[,] array= new int[5, 5] {{ 0, 0, 0, 0, 0 },
            //                             { 0, 0, 0, 0, 0 }, 
            //                             { 0, 1, 0, 0, 0 }, 
            //                             { 0, 0, 1, 1, 0 }, 
            //                             { 0, 0, 0, 0, 0 } };
            //int[,] arrayb = new int[5, 5];
            //int row;
            //int col;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for(int j = 0; j < array.GetLength(1); j++)
            //    {
            //        arrayb[i,j] = array[i, j];
            //    }
            //}
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (array[i, j] == 1)
            //        {
            //            for (int k = 0; k < arrayb.GetLength(0); k++)
            //            {
            //                arrayb[k, j] = 1;
            //            }
            //            for (int k = 0; k < arrayb.GetLength(1); k++)
            //            {
            //                arrayb[i, k] = 1;
            //            }
            //        }
            //    }
            //}
            //array=arrayb;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (j % 5 == 0&&j==0)
            //        {
            //            Console.WriteLine();
            //        }
            //        Console.Write(array[i, j]);
            //    }
            //}
            #endregion

        }
    }
}
