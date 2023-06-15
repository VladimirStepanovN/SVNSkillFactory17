namespace SVNSkillFactory17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obj a = new Obj {Value =  5};
            Obj b = new Obj { Value = 6};
            Obj c = a + b;
            Obj d = b - a;
            Console.WriteLine(c.Value);
            Console.WriteLine(d.Value);
        }
        class Obj
        {
            public int Value;
            public static Obj operator + (Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value + b.Value
                };
            }
            public static Obj operator -(Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value - b.Value
                };
            }
        }
    }
}