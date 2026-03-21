namespace lesson14_选择排序_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");




            #region 问题
            //定义一个数组，长度为20，每个元素值随机0~100的数
            //使用选择排序进行升序排序并打印
            //使用选择排序进行降序排序并打印


            Random r = new Random();
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 101);
                Console.Write(arr[i] + " ");
            }


            for (int m = 0; m < arr.Length - 1; m++)
            {

                int index = 0;
                for (int n = 1; n < arr.Length - m; n++)
                {
                    if (arr[index] < arr[n])
                    {
                        index = n;
                    }
                }

                if (index != arr.Length - 1 - m)
                {
                    int temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - m];
                    arr[arr.Length - m - 1] = temp;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }



            #endregion
        }
    }
}
