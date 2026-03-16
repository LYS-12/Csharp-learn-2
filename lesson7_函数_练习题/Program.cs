using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;

namespace lesson7_函数_练习题
{


    internal class Program
    {



        #region 问题1
        //写一个函数，比较两个数字的大小，返回最大值

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }



        #endregion

        #region 问题2
        //写一个函数，用于计算一个圆的面积和周长并返回打印
        static void GetCircleInfo(double r)
        {
            double area = Math.PI * r * r;
            double circumference = 2 * Math.PI * r;
            Console.WriteLine("圆的面积为：{0}, 圆的周长为：{1}", area, circumference);
        }



        #endregion

        #region 问题3
        //写一个函数，求一个数组的总合、最大值、最小值、平均值
        static void HanShu(int[] array)
        {
            int sum = 0;
            int max = array[0];
            int min = array[0];
            int avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            avg = sum / array.Length;
            Console.WriteLine("数组的总和为：{0}, 数组的最大值为：{1}, 数组的最小值为：{2}, 数组的平均值为：{3}", sum, max, min, avg);
        }

        #endregion

        #region 问题4
        //写一个函数，判断你传入的参数是不是质数
        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 问题5
        //写一个函数，判断你输入的年份是否是闺年
        //闰年判断条件：
        //年份能被400整除
        //（2000）
        //或者
        //年份能被4整除，但是不能被100整除
        //（2008）
        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        static void Main(string[] args)
        {
            
            Console.WriteLine(GetMax(5,7));
            GetCircleInfo(2);
            int[] array=new int[5] {1,2,3,4,5 };

            HanShu(array);
            Console.WriteLine(IsPrime(100));
            Console.WriteLine(IsLeapYear(2000));
            Console.WriteLine(IsLeapYear(2008));
            Console.WriteLine(IsLeapYear(1900));
        }
    }
}
