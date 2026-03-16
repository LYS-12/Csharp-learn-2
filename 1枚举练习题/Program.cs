namespace _1枚举练习题
{

    /// <summary>
    /// QQ状态
    /// </summary>
    enum E_QQState
    {
        /// <summary>
        /// 在线
        /// </summary>
        Online,
        /// <summary>
        /// 离开
        /// </summary>
        Leave,
        /// <summary>
        /// 忙碌
        /// </summary>
        Busy,
        /// <summary>
        /// 隐身
        /// </summary>
        Invisible,
    }



    enum E_CoffeeType
    {
        /// <summary>
        /// 中杯
        /// </summary>
        Medium,
        /// <summary>
        /// 大杯
        /// </summary>
        Large,
        /// <summary>
        /// 超大杯
        /// </summary>
        SuperLarge,
    }

    enum E_Sex
    {
        男,
        女
    }
    enum E_Profession
    {
        战士,
        猎人,
        法师
    }




    internal class Program
    {
        static void Main(string[] args)
        {






            #region 1.定义QQ状态的枚举，并提示用户选择一个在线状态，我们接受输入的数字，并将其转换成枚举类型
            try
            {

                Console.WriteLine("请输入QQ的状态：（0在线，1离开，2忙，3隐身）");
                int type = int.Parse(Console.ReadLine());
                E_QQState qqState = (E_QQState)type;
                Console.WriteLine(qqState);
            }
            catch
            {

                Console.WriteLine("请输入数字");
            }












            #endregion




            #region 2.问题
            //用户去星巴克买咖啡，分为中杯（35元），大杯（40元），超大杯（43元），请用户选择要购买的类型，用户选择后，打印：您购买了Xxxx咖啡，花费了xx元例如：你购买了中杯咖啡，花费了35元
            try
            {
                Console.WriteLine("请输入要购买的咖啡类型：（0中杯，1大杯，2超大杯）");
                int type = int.Parse(Console.ReadLine());
                E_CoffeeType coffeeType = (E_CoffeeType)type;
                switch (coffeeType)
                {
                    case E_CoffeeType.Medium:
                        Console.WriteLine("您购买了中杯咖啡，花费了35元");
                        break;
                    case E_CoffeeType.Large:
                        Console.WriteLine("您购买了大杯咖啡，花费了40元");
                        break;
                    case E_CoffeeType.SuperLarge:
                        Console.WriteLine("您购买了超大杯咖啡，花费了43元");
                        break;
                }

            }
            catch
            {
                Console.WriteLine("请输入数字");
            }

            #endregion





            #region 3.题目
            //请用户选择英雄性别与英雄职业，最后打印英雄的基本属性（攻击力，防御力，技能）
            //性别：
            //男（攻击力 + 50，防御力 + 100）
            //女（攻击力 + 150，防御力 + 20)
            //职业：
            //战士（攻击力 + 20，防御力 + 100，技能：冲锋）
            //猎人（攻击力 + 120，防御力 + 30，技能：假死）
            //法师（攻击力 + 200，防御力 + 10，技能：奥术冲击）
            //举例打印：你选择了“女性法师”，攻击力：350，防御力：30，职业
            //技能：奥术冲击


            try
            {
                Console.WriteLine("请输入英雄的性别：（0男，1女）");
                E_Sex Sex = (E_Sex)int.Parse(Console.ReadLine());
                string herosex = "";
                int atk=0;
                int def=0;
                switch (Sex)
                {
                    case E_Sex.男:
                        herosex = "男";
                        atk += 50;
                        def += 100;
                        break;
                    case E_Sex.女:
                        herosex = "女";
                        atk += 150;
                        def += 20;
                        break;
                }
                Console.WriteLine("请输入英雄的职业：（0战士，1猎人，2法师）");
                E_Profession Profession=(E_Profession)int.Parse(Console.ReadLine());
                string heroProfession="";
                string skill="";
                switch (Profession) {
                    case E_Profession.战士:
                        heroProfession = "战士";
                        atk += 20;
                        def += 100;
                        skill = "冲锋";
                        break;
                    case E_Profession.猎人:
                        heroProfession = "猎人";
                        atk += 120;
                        def += 20;
                        skill = "假死";
                        break;
                    case E_Profession.法师:
                        heroProfession = "法师";
                        atk += 200;
                        def += 10;
                        skill = "奥术冲击";
                        break;
                    default:

                        Console.WriteLine("请输入有效范围");
                        break;

                }
                Console.WriteLine($"你选择了\"{herosex}{heroProfession}\"，攻击力：{atk}，防御力：{def}，技能：{skill}");


            }
            catch
            {

                Console.WriteLine("请输入数字");
            }










            #endregion







        }
    }
}
