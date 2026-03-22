namespace 实践小项目__飞行棋
{
    #region 2.游戏场景枚举类型相关
    enum E_GameScene
    {
        /// <summary>
        /// 开始界面
        /// </summary>
        StartScene,
        /// <summary>
        /// 游戏界面
        /// </summary>
        GameScene,
        /// <summary>
        /// 结束界面
        /// </summary>
        EndScene
    }
    #endregion
    //使用枚举类型来表示游戏的场景

    struct GeZi
    {
        public string putong;
        public string zanting;
        public string zhadan;
        public string shikong;
        public GeZi()
        {
            putong = "□";
            zanting = "‖";
            zhadan = "●";
            shikong = "？";
        }
        public void PutongShow()
        {
            putong = "★";

        }
    }
    internal class Program
    {
        #region 1.控制台初始化
        static void ConsoleInit(int w, int h)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
        }
        #endregion

        #region 3.开始场景逻辑
        static void GameScene(int w, int h, ref E_GameScene e_GameScene)
        {

            bool isQuit = false;
            int fc = 1;

            Console.SetCursorPosition(w / 2 - 3, 8);
            Console.Write("飞行棋");
            while (true)
            {
                Console.SetCursorPosition(w / 2 - 4, 13);
                Console.ForegroundColor = fc == 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("开始游戏");
                Console.SetCursorPosition(w / 2 - 4, 15);
                Console.ForegroundColor = fc == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("退出游戏");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        fc++;
                        if (fc > 1)
                        {
                            fc = 1;
                        }

                        break;
                    case ConsoleKey.S:
                        fc--;
                        if (fc < 1)
                        {
                            fc = 0;
                        }
                        break;
                    case ConsoleKey.J:
                        if (fc == 1)
                        {
                            e_GameScene = E_GameScene.GameScene;
                            isQuit = true;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;

                }
                if (isQuit)
                {
                    break;
                }

            }

        }

        #endregion
        static void Main(string[] args)
        {
            #region 1.控制台初始化
            int w = 50;
            int h = 30;
            ConsoleInit(w, h);
            #endregion




            #region 2.场景选择相关
            //声明一个 表示场景标识的 变量
            E_GameScene e_GameScene = E_GameScene.StartScene;
            while (true)
            {
                switch (e_GameScene)
                {
                    case E_GameScene.StartScene:
                        //开始场景逻辑
                        Console.Clear();
                        GameScene(w, h, ref e_GameScene);
                        break;
                    case E_GameScene.GameScene:
                        //游戏场景逻辑
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        //横着的
                        for (int i = 0; i < w; i += 2)
                        {
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");

                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("■");
                            Console.SetCursorPosition(i, h - 6);
                            Console.Write("■");

                            Console.SetCursorPosition(i, h - 11);
                            Console.Write("■");

                        }
                        //竖着的

                        for (int i = 0; i < h; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");

                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("■");

                        }


                        //操作说明
                        #region 操作显示
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(2, h - 10);
                        Console.Write("□：普通格子");
                        Console.SetCursorPosition(2, h - 9);
                        Console.Write("‖：暂停，一回合不动    ●：炸弹，倒退5格");
                        Console.SetCursorPosition(2, h - 8);
                        Console.Write("？：时空隧道，随机倒退，暂停，换位置");
                        Console.SetCursorPosition(2, h - 7);
                        Console.Write("★：玩家，▲：电脑，◎，玩家电脑重合");
                        Console.SetCursorPosition(2, h - 5);
                        Console.Write("按任意键开始扔色子");
                        #endregion

                        for (int i = 0; i < 80; i++)
                        {



                        }





                        //for (int i=3;i<18;i+=2)
                        //{
                        //    for (int j = 16; j <36; j+=2)
                        //    {

                        //        Console.SetCursorPosition(j, i);
                        //        Console.Write("□");
                        //    } 
                        //}
                        //Console.SetCursorPosition(16, 6);
                        //Console.Write("□");
                        //Console.SetCursorPosition(16, 10);
                        //Console.Write("□");
                        //Console.SetCursorPosition(16, 14);
                        //Console.Write("□");
                        //Console.SetCursorPosition(34, 4);
                        //Console.Write("□");
                        //Console.SetCursorPosition(34, 8);
                        //Console.Write("□");
                        //Console.SetCursorPosition(34, 12);
                        //Console.Write("□");
                        //Console.SetCursorPosition(34, 16);
                        //Console.Write("□");
                        //Console.SetCursorPosition(16, 17);
                        //Console.Write("               ");
                        //Console.SetCursorPosition(16, 3);
                        //Console.Write("□");
                        //Console.SetCursorPosition(18, 3);
                        //Console.Write("□");
                        //Console.SetCursorPosition(20, 3);
                        //Console.Write("□");
                        //Console.SetCursorPosition(22, 3);
                        //Console.Write("□");
                        //Console.SetCursorPosition(24, 3);
                        //Console.Write("□");
                        //Console.SetCursorPosition(26, 3);
                        //Console.Write("□");
                        //Console.SetCursorPosition(28, 3);
                        //Console.Write("□");
                        //Console.SetCursorPosition(30, 3);
                        //Console.Write("□");
                        //Console.SetCursorPosition(32, 3);
                        //Console.Write("□");
                        //Console.SetCursorPosition(34, 3);
                        //Console.Write("□");
                        //Console.SetCursorPosition(34, 4);
                        //Console.Write("□"); 
                        //Console.SetCursorPosition(34, 5);
                        //Console.Write("□");
                        //Console.SetCursorPosition(32, 5);
                        //Console.Write("□");
                        //Console.SetCursorPosition(30, 5);
                        //Console.Write("□");
                        //Console.SetCursorPosition(28, 5);
                        //Console.Write("□");
                        //Console.SetCursorPosition(26, 5);
                        //Console.Write("□");
                        //Console.SetCursorPosition(24, 5);
                        //Console.Write("□");
                        //Console.SetCursorPosition(22, 5);
                        //Console.Write("□");
                        //Console.SetCursorPosition(20, 5);
                        //Console.Write("□");
                        //Console.SetCursorPosition(18, 5);
                        //Console.Write("□");
                        //Console.SetCursorPosition(16, 5);
                        //Console.Write("□");
                        //Console.SetCursorPosition(16, 6);
                        //Console.Write("□");
                        //Console.SetCursorPosition(16, 7);
                        //Console.Write("□");

                        //Console.SetCursorPosition(18, 7);
                        //Console.Write("□");
                        while (true)
                        {

                        }



                        break;
                    case E_GameScene.EndScene:
                        //结束场景逻辑
                        Console.Clear();
                        Console.WriteLine("这是结束界面");
                        break;
                }


            }
            #endregion




        }
    }
}
