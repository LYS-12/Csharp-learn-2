using System.Diagnostics.CodeAnalysis;

namespace lesson9_变长参数和参数默认值_练习题
{
    internal class Program
    {
        static int[] Array(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return new int[] { sum, numbers.Length > 0 ? sum / numbers.Length : 0 };
        }

        static int[] OuShuJshu(params int[] num)
        {
            int oushu=0;
            int jishu=0;
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i]%2==0)
                {
                    oushu+= num[i];
                }
                else
                {
                    jishu+= num[i];
                }
            }

            return new int[] { oushu, jishu };
        }
            static void Main(string[] args)
        {

            #region 问题1
            //使用param参数，求多个数字的和以及平均数
            int[] arr= Array(1,2,3,4,5,6,7,8,9);
            Console.WriteLine("和：" + arr[0]);
            Console.WriteLine("平均数：" + arr[1]);
            #endregion


            #region 问题2
            //使用param参数，求多个数字的偶数和奇数和

            int[] array = OuShuJshu(0,1,2,3,45,4);
            Console.WriteLine("偶数和：" + array[0]);
            Console.WriteLine("奇数和：" + array[1]);


            #endregion


        }
    }
}
