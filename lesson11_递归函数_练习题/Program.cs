namespace lesson11_递归函数_练习题
{
    internal class Program
    {
        static void Fun(int a)
        {
            if (a > 10)
            {
                return;
            }
            Console.WriteLine(a);
            ++a;
            Fun(a);
        }
        static int JieCheng(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a * JieCheng(a - 1);

        }


        static int fun3(int a)
        {

            if (a == 1)
            {
                return 1;
            }
            return JieCheng(a) + fun3(a - 1);

        }


        static float fun4(float a)
        {

            if (a==0)
            {
                return 0.5f*100;
            }
            return 0.5f* fun4(a - 1);
        }



        static bool fun5(int a=1)
        {

            Console.WriteLine(a);
            return a==200||fun5(a + 1); 
        }
        static void Main(string[] args)
        {
            #region 问题1
            //使用递归的方式打印0~10
            Fun(0);


            #endregion
            #region 问题2
            //传入一个值，递归求该值的阶乘并返回
            //5 != 1 * 2 * 3 * 4 * 5
            Console.WriteLine(JieCheng(7));
            #endregion
            #region 问题3
            //使用递归求1！+2! + 3! + 4！+...+10!
            Console.WriteLine(fun3(10));
            #endregion
            #region 问题4

            //一根竹竿长100m，每天砍掉一半，求第十天它的长度是多少（从第0天开始）

            Console.WriteLine(fun4(10));


            #endregion
            #region 问题5
            // 不允许使用循环语句、条件语句，在控制台中打印出1 - 200这200个数
            //（提示：递归 + 短路）



            fun5();

            #endregion
        }
    }
}
