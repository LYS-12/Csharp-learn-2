using System.Numerics;

namespace 实践小项目__飞行棋
{
    internal class Program
    {
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
                        BeginOrEndScene(w, h, ref e_GameScene);
                        break;
                    case E_GameScene.GameScene:
                        //游戏场景逻辑
                        Console.Clear();
                        GameScene(w, h, ref e_GameScene);
                        break;
                    case E_GameScene.EndScene:
                        //结束场景逻辑
                        Console.Clear();
                        BeginOrEndScene(w, h, ref e_GameScene);
                        break;
                }


            }
            #endregion
        }
        #region 1.控制台初始化
        static void ConsoleInit(int w, int h)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
        }
        #endregion
        #region 3.开始场景逻辑+8结束场景逻辑
        static void BeginOrEndScene(int w, int h, ref E_GameScene e_GameScene)
        {
            Console.ForegroundColor = ConsoleColor.White;
            bool isQuit = false;
            int fc = 1;

            Console.SetCursorPosition(e_GameScene == E_GameScene.StartScene ? w / 2 - 3 : w / 2 - 4, 8);
            Console.Write(e_GameScene == E_GameScene.StartScene ? "飞行棋" : "游戏结束");
            while (true)
            {
                Console.SetCursorPosition(e_GameScene == E_GameScene.StartScene ? w / 2 - 4 : w / 2 - 5, 13);
                Console.ForegroundColor = fc == 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write(e_GameScene == E_GameScene.StartScene ? "开始游戏" : "回到主菜单");
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
                            e_GameScene = e_GameScene == E_GameScene.StartScene ? E_GameScene.GameScene:E_GameScene.StartScene;
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
        #region 游戏场景逻辑
        static void GameScene(int w, int h, ref E_GameScene e_GameScene)
        {
            //绘制不变的基本信息
            DrawWall(w, h);
            //绘制地图
            Map map = new Map(14, 3, 80);
            map.Draw();
            //绘制玩家
            Player player = new Player(0, E_PlayerType.Player);
            Player computer = new Player(0, E_PlayerType.Computer);
            DrawPlayer(player, computer, map);

            bool isGameOver = false;
            //游戏场景循环
            while (true)
            {
               if( PlayerRandomMove(w,h,ref player,ref computer,map,ref e_GameScene))
                {
                    break;
                }
                if (PlayerRandomMove(w, h, ref computer, ref player, map, ref e_GameScene))
                {
                    break;
                }

            }
        }

        static bool PlayerRandomMove(int w, int h, ref Player player, ref Player computer, Map map,ref E_GameScene e_GameScene)
        {

            //之后的游戏逻辑
            //检测输入
            Console.ReadKey(true);
            //玩家扔骰子的逻辑
            bool isGameOver = RandomMove(w, h, ref player, ref computer, map);
            //绘制地图
            map.Draw();
            //绘制玩家
            DrawPlayer(player, computer, map);
            //判断是否结束游戏
            if (isGameOver)
            {
                //卡住程序，让玩家按任意键跳出循环
                Console.ReadKey(true);
                //改变场景标识 进入结束界面
                e_GameScene = E_GameScene.EndScene;
                //直接跳出循环
            }
            return isGameOver;
        }
        #endregion
        #region 4.绘制不变的内容（红墙 提示等等）
        static void DrawWall(int w, int h)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            //横着的
            for (int i = 0; i < w; i += 2)
            {
                //最上方的墙
                Console.SetCursorPosition(i, 0);
                Console.Write("■");

                //最下方的墙
                Console.SetCursorPosition(i, h - 1);
                Console.Write("■");

                //中间的墙
                Console.SetCursorPosition(i, h - 6);
                Console.Write("■");

                Console.SetCursorPosition(i, h - 11);
                Console.Write("■");

            }
            //竖着的墙

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

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(2, h - 9);
            Console.Write("‖：暂停，一回合不动    ●：炸弹，倒退5格");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(26, h - 9);
            Console.Write("●：炸弹，倒退5格");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(2, h - 8);
            Console.Write("¤：时空隧道，随机倒退，暂停，换位置");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(2, h - 7);
            Console.Write("★：玩家");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(12, h - 7);
            Console.Write("▲：电脑");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(22, h - 7);
            Console.Write("◎：玩家电脑重合");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, h - 5);
            Console.Write("按任意键开始扔色子");
            #endregion
        }
        #endregion

        #region 7.绘制玩家
        static void DrawPlayer(Player player, Player computer, Map map)
        {

            //重合
            if (player.nowIndex == computer.nowIndex)
            {
                //得到重合的位置
                Grid grid = map.grids[player.nowIndex];
                Console.SetCursorPosition(grid.pos.x, grid.pos.y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("◎");
            }
            //不重合
            else
            {
                player.Draw(map);
                computer.Draw(map);
            }

        }
        #endregion


        #region 8.扔骰子的逻辑
        static void ClearInfo(int h)
        {
            Console.SetCursorPosition(2, h - 5);
            Console.Write("                                 ");
            Console.SetCursorPosition(2, h - 4);
            Console.Write("                                 ");
            Console.SetCursorPosition(2, h - 3);
            Console.Write("                                 ");
            Console.SetCursorPosition(2, h - 2);
            Console.Write("                                 ");

        }
        /// <summary>
        /// 扔骰子的方法
        /// </summary>
        /// <param name="w">宽</param>
        /// <param name="h">高</param>
        /// <param name="p">扔骰子的对象</param>
        /// <param name="map">地图信息</param>
        /// <returns>默认返回False</returns>
        static bool RandomMove(int w, int h, ref Player p, ref Player other, Map map)
        {
            //清除提示信息
            ClearInfo(h);
            Console.ForegroundColor = p.type == E_PlayerType.Player ? ConsoleColor.Cyan : ConsoleColor.Magenta;

            if (p.isPause == true)
            {
                Console.SetCursorPosition(2, h - 5);
                Console.Write("处于暂停点，{0}需要暂停一回合", p.type == E_PlayerType.Player ? "你" : "电脑");
                Console.SetCursorPosition(2, h - 4);
                Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");

                p.isPause = false;//清除暂停状态
                return false;//直接返回 没有结束游戏
            }

            //扔骰子的目的是改变位置 计算位置的变化

            //扔骰子随机1到6的数
            Random random = new Random();
            int randomNum = random.Next(1, 7);
            p.nowIndex += randomNum;


            //打印扔骰子的结果
            Console.SetCursorPosition(2, h - 5);
            Console.Write("{0}扔出的点数为{1}", p.type == E_PlayerType.Player ? "你" : "电脑", randomNum);

            //首先判断是否超过了终点

            if (p.nowIndex >= map.grids.Length - 1)
            {
                p.nowIndex = map.grids.Length - 1;

                Console.SetCursorPosition(2, h - 4);
                if (p.type == E_PlayerType.Player)
                {
                    Console.Write("恭喜你，赢得了游戏胜利！");
                }
                else
                {
                    Console.Write("很遗憾，电脑赢得了游戏胜利！");
                }

                Console.SetCursorPosition(2, h - 3);
                Console.Write("请按任意键，进入结束界面");
                return true;
            }
            else
            {
                //没有到达终点 继续判断当前对象 到了什么格子类型

                Grid grid = map.grids[p.nowIndex];
                switch (grid.type)
                {
                    case E_GridType.Normal:
                        //普通格子 没有任何效果
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}到达了一个安全位置", p.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");


                        break;
                    case E_GridType.Stop:
                        //暂停格子 需要停一回合 但是这个回合已经走了 所以在外面进行判断
                        p.isPause = true;
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("处于暂停点，{0}需要暂停一回合", p.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");

                        break;
                    case E_GridType.Bomb:
                        //炸弹格子 需要倒退5格
                        p.nowIndex -= 5;
                        if (p.nowIndex < 0)
                        {
                            p.nowIndex = 0;
                        }
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}踩到了炸弹，退后五格", p.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");

                        break;
                    case E_GridType.TimeTunnel:
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}踩到了时空隧道", p.type == E_PlayerType.Player ? "你" : "电脑");

                        //时空隧道格子 需要随机一个效果
                        randomNum = random.Next(1, 91);
                        if (randomNum <= 30)
                        {
                            p.nowIndex -= 5;
                            if (p.nowIndex < 0)
                            {
                                p.nowIndex = 0;
                            }
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发倒退5格");

                        }
                        else if (randomNum <= 60)
                        {
                            p.isPause = true;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发暂停1回合");
                        }
                        else
                        {
                            int temp = p.nowIndex;
                            p.nowIndex = other.nowIndex;
                            other.nowIndex = temp;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("惊喜！惊喜！双方交换位置");
                        }
                        Console.SetCursorPosition(2, h - 2);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");

                        break;
                }
            }
            return false;
            //默认没有结束
        }

        #endregion
    }
    #region 2.场景选择相关
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

    #region 5.格子结构体和格子枚举
    enum E_GridType
    {
        /// <summary>
        /// 普通格子
        /// </summary>
        Normal,
        /// <summary>
        /// 暂停
        /// </summary>
        Stop,
        /// <summary>
        /// 炸弹
        /// </summary>
        Bomb,
        /// <summary>
        /// 时空隧道 
        /// </summary>
        TimeTunnel
    }

    struct Vector2
    {
        public int x;
        public int y;
        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    struct Grid
    {
        //格子类型
        public E_GridType type;
        //格子位置
        public Vector2 pos;
        //构造函数
        public Grid(int x, int y, E_GridType type)
        {
            pos.x = x;
            pos.y = y;
            this.type = type;
        }
        //绘制格子
        public void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            switch (type)
            {
                case E_GridType.Normal:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("□");
                    break;
                case E_GridType.Stop:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("‖");
                    break;
                case E_GridType.Bomb:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("●");
                    break;
                case E_GridType.TimeTunnel:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("¤");
                    break;
            }
        }
    }


    #endregion

    #region 6.地图结构体
    struct Map
    {
        public Grid[] grids;

        //构造函数 初始了格子类型 和位置
        public Map(int x, int y, int num)
        {
            grids = new Grid[num];
            //用于位置改变计数的变量
            int indexX = 0;//表示X变化的次数

            int indexY = 0;//表示Y变化的次数

            int stepNum = 2;//X的步长
            Random random = new Random();
            int randomNum;
            for (int i = 0; i < num; i++)
            {
                //应该初始化 格子类型
                randomNum = random.Next(0, 101);
                //首尾俩个格子必须是普通格子
                if (randomNum < 85 || i == 0 || i == num - 1)
                {
                    grids[i].type = E_GridType.Normal;
                }
                //炸弹的概率
                else if (randomNum >= 85 && randomNum < 90)
                {
                    grids[i].type = E_GridType.Bomb;
                }
                //暂停的概率
                else if (randomNum >= 90 && randomNum < 95)
                {
                    grids[i].type = E_GridType.Stop;
                }
                else
                {
                    grids[i].type = E_GridType.TimeTunnel;
                }

                //位置如何设置


                grids[i].pos = new Vector2(x, y);
                //每次循环都应该更换位置

                if (indexX == 10)
                {
                    y += 1;
                    ++indexY;//加一次Y计一次数
                    if (indexY == 2)
                    {
                        indexX = 0;//清零
                        indexY = 0;
                        stepNum = -stepNum;//改变步长方向
                    }
                }
                else
                {
                    x += stepNum;
                    ++indexX;//加一次X计一次数
                }


            }
        }

        public void Draw()
        {
            for (int i = 0; i < grids.Length; i++)
            {
                grids[i].Draw();
            }
        }
    }
    #endregion

    #region 7.玩家枚举和玩家结构体
    enum E_PlayerType
    {
        /// <summary>
        /// 玩家
        /// </summary>
        Player,
        /// <summary>
        /// 电脑
        /// </summary>
        Computer
    }

    struct Player
    {
        public E_PlayerType type;
        public int nowIndex;//玩家在地图上所在格子的索引
        public bool isPause;//是否需要暂停一回合
        public Player(int index, E_PlayerType type)
        {
            nowIndex = index;
            this.type = type;
            isPause = false;
        }

        public void Draw(Map mapInfo)
        {
            //必须要先得到地图 才能够得到我在地图的哪一个格子
            //从传入的地图中得到格子信息
            Grid grid = mapInfo.grids[nowIndex];
            //设置位置
            Console.SetCursorPosition(grid.pos.x, grid.pos.y);
            //画 设置颜色 设置图标

            switch (type)
            {
                case E_PlayerType.Player:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("★");
                    break;
                case E_PlayerType.Computer:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("▲");
                    break;
            }
        }

    }

    #endregion
}
