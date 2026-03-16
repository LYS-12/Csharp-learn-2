namespace lesson2_一维数组_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lesson2_一维数组");



            #region 问题1
            Console.WriteLine("*******问题1*******");
            Console.WriteLine();
            //请创建一个一维数组并赋值，让其值与下标一样，长度为100
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;

            }
            #endregion


            #region 问题2
            //创建另一个数组B，让数组A中的每个元素的值乘以2存入到数组B中
            int[] array2 = new int[100];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = 2 * array[i];
            }


            #endregion

            #region 问题3
            //随机（0~100）生成1个长度为10的整数数组
            Random random = new Random();


            int[] array3 = new int[10];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = random.Next(0, 101);
                
            }



            #endregion

            #region 问题4
            //从一个整数数组中找出最大值、最小值、总合、平均值（可以使用随机数1~100）

            int array4Max = 0;
            int array4Min = 0;
            int array4Sum = 0;
            int array4Avg = 0;

            int[] array4 = new int[10];
            for (int i = 0; i < array4.Length; i++)
            {
                int num = random.Next(0, 101);
                array4[i] = num;
                Console.WriteLine(array4[i]);



            }
            array4Max = array4[0];
            array4Min = array4[0];
            for (int i = 0; i < array4.Length; i++)
            {

                if (array4Max > array4[i])
                {
                }
                else
                {
                    array4Max = array4[i];
                }


                if (array4Min < array4[i])
                {

                }
                else
                {
                    array4Min = array4[i];
                }
                array4Sum += array4[i];

            }
            array4Avg = array4Sum / array4.Length;
            Console.WriteLine("最大值{0}、最小值{1}、总合{2}、平均值{3}", array4Max, array4Min, array4Sum, array4Avg);

            #endregion


            #region 问题5
            //交换数组中的第一个和最后一个、第二个和倒数第二个，依次类推，把数组进行反转并打印
            int[] array5 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < array5.Length / 2; i++)
            {
                int hsum = array5[i];
                array5[i] = array5[array5.Length - 1 - i];
                array5[array5.Length - 1 - i] = hsum;


            }
            for (int i = 0; i < array5.Length; i++)
            {
                Console.WriteLine(array5[i]);
            }


            #endregion



            #region 问题6
            Console.WriteLine("*******问题6*******");
            //将一个整数数组的每一个元素进行如下的处理：
            //如果元素是正数则将这个位置的元素值加1；
            //如果元素是负数则将这个位置的元素值减1；
            //如果元素是0，则不变
            int[] array6 = new int[10] { -1, -2, -3, -4, 0, 1, 2, 3, 4, 5 };
            for (int i = 0; i < array6.Length; i++)
            {
                if (array6[i] > 0)
                {
                    array6[i] += 1;
                }
                else if (array6[i] < 0)
                {
                    array6[i] -= 1;
                }
                Console.WriteLine(array6[i]);

            }




            #endregion

            #region 问题7
            Console.WriteLine("*******问题7*******");
            //定义一个有10个元素的数组，使用for循环，输入10名同学的数学成
            //绩，将成绩依次存入数组，然后分别求出最高分和最低分，并且求出10
            //名同学的数学平均成绩
            int[] array7 = new int[10];
            int sum = 0;
            float avg;
            int max;
            int min;
            for (int i = 0; i < array7.Length; i++)
            {
                Console.WriteLine("请输入第{0}位同学的成绩", i + 1);

                array7[i] = Convert.ToInt32(Console.ReadLine());
                sum += array7[i];

            }
            max = array7[0];
            min = array7[0];
            for (int i = 0; i < array7.Length; i++)
            {

                if (max > array7[i])
                {

                }
                else
                {
                    max = array7[i];
                }
                if (min < array7[i])
                {

                }
                else
                {
                    min = array7[i];
                }
            }
            avg = (float)sum / array7.Length;
            Console.WriteLine("最高分是{0},最低分是{1},平均成绩是{2}", max, min, avg);
            #endregion



            #region 问题8


            Console.WriteLine("*******问题8*******");
            string[] array8 = new string[25];
            for (int i = 0; i < array8.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array8[i] = "■";
                }
                else if (i % 2 == 1)
                {
                    array8[i] = "□";
                }
            }
            int j = 0;
            for (int i = 0;i < array8.Length;)
            {
                
                j += 5;
                for (; i<j; i++)
                {

                    Console.Write(array8[i]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("****************");
            for (int i = 0; i < array8.Length; i++)
            {
                if ((i) % 5 == 0&&i!=0)
                {
                    Console.WriteLine();
                }
                Console.Write(array8[i]);
              
            }
            #endregion
        }
    }
}
