namespace SVNSkillFactory17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new();
            dc.Display();
        }
    }
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
}