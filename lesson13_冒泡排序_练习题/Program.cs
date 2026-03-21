namespace lesson13_冒泡排序_练习题
{
    internal class Program
    {




        #region 问题2
        //写一个函数，实现一个数组的排序，并返回结果。可以根据参数决定是
        //升序还是降序


        static void PaiXu(bool num, int[] array)
        {
            if (num)
            {
                Console.WriteLine("升序");
            }
            else { Console.WriteLine("降序"); }


            int temp;
            bool order = false;
            bool isFalse = false;
            for (int m = 0; m < array.Length - 1; m++)
            {
                isFalse = false;
                for (int n = 0; n < array.Length - 1 - m; n++)
                {
                    isFalse = true;
                    order = num ? array[n] > array[n + 1] : array[n] < array[n + 1];

                    if (order)
                    {
                        temp = array[n];
                        array[n] = array[n + 1];
                        array[n + 1] = temp;
                    }


                }
                if (!isFalse)
                {
                    break;
                }
            }

        }






        #endregion


        static void Main(string[] args)
        {


            Random random = new Random();

            int[] array = new int[20];


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
                Console.Write(array[i] + " ");
            }





            Console.WriteLine();
            Console.WriteLine("**********问题2{**********");


            PaiXu(true, array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }



            Console.WriteLine();
            Console.WriteLine("**********问题2}**********");


            bool isFalse = false;
            //for (int m = 0;m<array.Length-1 ;m++)
            //{
            //    isFalse = false;
            //    for (int n = 0; n < array.Length - 1 - m; n++)
            //    {
            //        isFalse = true;
            //        if (array[n] > array[n + 1])
            //        {
            //            int temp = array[n];
            //            array[n] =   array[n+1];
            //            array[n + 1] = temp;
            //        }

            //    }
            //    if (!isFalse)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("**********升序排序**********");
            //for (int i = 0; i < array.Length; i++)
            //{

            //    Console.WriteLine(array[i]);
            //}

            for (int m = 0; m < array.Length - 1; m++)
            {
                isFalse = false;
                for (int n = 0; n < array.Length - 1 - m; n++)
                {
                    isFalse = true;
                    if (array[n] < array[n + 1])
                    {
                        int temp = array[n];
                        array[n] = array[n + 1];
                        array[n + 1] = temp;
                    }

                }
                if (!isFalse)
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("**********降序排序**********");
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]);
            }











        }
    }
}
