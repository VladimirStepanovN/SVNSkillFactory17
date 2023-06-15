namespace SVNSkillFactory17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Obj.Parent);
            Console.WriteLine(Obj.DaysInWeek);
            Console.WriteLine(Obj.MaxValue);
        }
        class Obj
        {
            public string Name;
            public string Description;
            public static string Parent;
            public static int DaysInWeek;
            public static int MaxValue;
            static Obj()
            {
                Parent = "System.Object";
                DaysInWeek = 7;
                MaxValue = 2000;
            }
        }
    }
}