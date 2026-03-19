namespace lesson10_函数重载_练习题
{
    internal class Program
    {
        static int Max(int a,int b)
        {
            return a > b ? a : b;
        }
        static float Max(float a, float b)
        {
            return a > b ? a : b;
        }
        static double Max(double a, int b)
        {
            return a > b ? a : b;
        }




        static int MaxbiJiao(params int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        static float MaxbiJiao(params float[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            float max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static double MaxbiJiao(params double[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            #region 问题1
            //请重载一个函数
            //让其可以比较两个int或两个float或两个double的大小
            //并返回较大的那个值

            #endregion
            #region 问题2
            //请重载一个函数
            //让其可以比较n个int或n个float或n个double的大小
            //并返回最大的那个值。（用params可变参数来完成）

            Console.WriteLine(MaxbiJiao(1, 2, 3, 4));
            Console.WriteLine(MaxbiJiao(1.2f, 1.3f));
            Console.WriteLine(MaxbiJiao(1.25d, 1.25d, 1.222d, 1.1d));

            #endregion
        }
    }
}
