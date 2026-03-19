namespace lesson8_ref和out_练习题
{
    internal class Program
    {
        static bool LoginResult(string useName,string usePassword,ref string info)
        {
            if (useName == "admin")
            {

                if (usePassword == "123456")
                {
                    info = "登录成功";
                    return true;
                }
                else
                {
                    info = "密码错误";
                    return false;
                }
            }
            else
            {
                info = "用户名错误";
                return false;

            }
        }
        static void Main(string[] args)
        {
            #region 问题
            //让用户输入用户名和密码，返回给用户一个bool类型的登陆结果，并且
            //还要单独的返回给用户一个登陆信息。
            //如果用户名错误，除了返回登陆结果之外，登陆信息为“用户名错误”
            //如果密码错误，除了返回登陆结果之外，登陆信息为“密码错误”
            

            Console.WriteLine("请输入用户名：");
            string input=Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pinput= Console.ReadLine();
            string info ="";

            while (!LoginResult(input, pinput, ref info))
            {

                Console.WriteLine(info);
                Console.WriteLine("请输入用户名：");
                input = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                pinput = Console.ReadLine();
            }


            Console.WriteLine(info);





            #endregion
        }
    }
}
