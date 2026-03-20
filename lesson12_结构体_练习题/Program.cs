using System;
using System.Threading;

namespace lesson12_结构体_练习题
{





    #region 问题1
    //使用结构体描述学员的信息，姓名，性别，年龄，班级，专业，创建两
    //个学员对象，并对其基本信息进行初始化并打印



    struct Student
    {
        public string Name;
        public bool Sex;
        public int Age;
        public int Class;
        public string Major;


        public Student(string Name, bool Sex, int Age, int Class, string Major)
        {
            this.Name = Name;
            this.Sex = Sex;
            this.Age = Age;
            this.Class = Class;
            this.Major = Major;
        }
        public void Speak()
        {
            Console.WriteLine("学生姓名：{0}，性别：{1}，年龄：{2}，班级：{3}，专业：{4}", Name, Sex ? "女" : "男", Age, Class, Major);
        }
    }
    #endregion

    #region 问题2
    //请简要描述private和public两个关键字的区别
    //private 私有的 只能在内容使用
    //public 公共的 可以被外部访问
    #endregion

    #region 问题3
    //使用结构体描述矩形的信息，长，宽；创建一个矩形，对其长宽进行初
    //始化，并打印矩形的长、宽、面积、周长等信息。

    struct Rectangle
    {
        public int Length;
        public int Width;

        public Rectangle(int Length, int Width)
        {
            this.Length = Length;
            this.Width = Width;
        }

        public void Speak()
        {
            Console.WriteLine("矩形的长：{0}，宽：{1}，面积：{2}，周长：{3}", Length, Width, Length * Width, 2 * (Length + Width));
        }




    }






    #endregion

    #region 问题4
    //使用结构体描述玩家信息，玩家名字，玩家职业
    //请用户输入玩家姓名，选择玩家职业，最后打印玩家的攻击信息
    //职业：
    //战士（技能：冲锋）
    //猎人（技能：假死）
    //法师（技能：奥术冲击）
    //打印结果：猎人唐老狮释放了假死

    struct Player
    {
        public string Name;

        public void Speak()
        {

            Console.WriteLine("请输入玩家姓名：");

            Name = Console.ReadLine();


            Console.WriteLine("请输入玩家职业：(0战士)  (1猎人)  (2法师)");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());


                switch (input)
                {

                    case 0:
                        Console.WriteLine(
                            "战士{0}释放了冲锋", Name);
                        break;
                    case 1:
                        Console.WriteLine(
                            "猎人{0}释放了假死", Name);
                        break;
                    case 2:
                        Console.WriteLine(
                        "法师{0}释放了奥术冲击", Name);
                        break;
                    default:
                        Console.WriteLine(
                            "请输入正确的职业编号");
                        break;

                }


            }
            catch
            {

                Console.WriteLine("请输入数字");


            }


        }







    }


    #endregion

    #region 问题5
    //使用结构体描述小怪兽

    struct Monster
    {
        public string Name;
        public int Attack;
        public Monster(string Name, int Attack)
        {
            this.Name = Name;
            this.Attack = Attack;
        }

        public void Speak()
        {
            Console.WriteLine("小怪兽名字：{0}，攻击力：{1}", Name, Attack);
        }
    }












    #endregion


    #region 问题6

    //定义一个数组存储10个上面描述的小怪兽，每个小怪兽的名字为（小怪
    //兽+数组下标）
    //举例：小怪兽0，最后打印10个小怪兽的名字+攻击力数值
    #endregion

    #region 问题7
    //应用已学过的知识，实现奥特曼打小怪兽
    //提示：
    //结构体描述奥特曼与小怪兽
    //定义一个方法实现奥特曼攻击小怪兽
    //定义一个方法实现小怪兽攻击奥特曼

    struct OutMan
    {
        public string name;
        public int hp;
        public int atk;
        public int def;

        public OutMan(string name,int hp, int atk, int def)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
        }
        public void Atk(ref Boss monster)
        {
            monster.hp = monster.hp + monster.def - atk;
            Console.WriteLine("{0}奥特曼攻击了怪兽{1}，怪兽的剩余血量为{2}", name, monster.name, monster.hp);
        }
    }
    struct Boss
    {
        public string name;
        public int hp;
        public int atk;
        public int def;

        public Boss(string name,int hp, int atk, int def)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
        }
        public void Atk(ref OutMan Outman)
        {
            Outman.hp = Outman.hp + Outman.def - atk;
            Console.WriteLine("怪兽{0}攻击了{1}奥特曼，奥特曼的剩余血量为{2}", name, Outman.name, Outman.hp);
        }
    }




    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            OutMan outMan = new OutMan("杰克",100,10,5);
            Boss monster= new Boss("巴尔坦",100, 8, 5);
            while (true)
            {
                outMan.Atk(ref monster);
                if (monster.hp <= 0)
                {
                    Console.WriteLine("{0}奥特曼战胜了{1}获得了胜利", outMan.name, monster.name);
                    break;
                }
                monster.Atk(ref outMan);
                Console.WriteLine("按下任意键开始攻击");
                Console.ReadKey(true);


            }




            Console.WriteLine("Hello, World!");

            Student s1 = new Student("张三", true, 20, 1, "计算机科学");
            Student s2 = new Student("李四", false, 22, 2, "软件工程");
            s1.Speak();
            s2.Speak();



            Rectangle r1 = new Rectangle(5, 3);
            Rectangle r2 = new Rectangle(10, 4);
            r1.Speak();
            r2.Speak();


            Player p1 = new Player();
            //p1.Speak();



            Monster[] monsters = new Monster[10];
            for (int i = 0; i < monsters.Length; i++)
            {
                try
                {
                    Console.WriteLine("请输入小怪兽{0}的攻击力：", i);
                    int m = int.Parse(Console.ReadLine());
                    monsters[i] = new Monster("小怪兽" + i, m);
                }
                catch
                {
                    Console.WriteLine("请输入数字");
                    i--;
                }
            }
            for (int i = 0; i < monsters.Length; i++)
            {

                monsters[i].Speak();

            }

        }
    }
}
