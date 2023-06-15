namespace SVNSkillFactory17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new();
            dc.Counter = 10;
            Console.WriteLine(dc.Counter);
            dc.Counter = 0;
            Console.WriteLine(dc.Counter);
            dc.Counter = -1;
            Console.WriteLine(dc.Counter);
        }
        class BaseClass
        {
            public virtual int Counter
            {
                get;
                set;
            }
        }
        class DerivedClass : BaseClass
        {
            private int counter;
            public override int Counter
            {
                get
                {
                    return counter;
                }
                set
                {
                    if (value >= 0) counter = value;
                }
            }
        }
    }
}