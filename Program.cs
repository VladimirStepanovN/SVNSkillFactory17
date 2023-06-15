namespace SVNSkillFactory17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A ab = new B();
            A ac = new C();
            A ad = new D();
            A ae = new E();
            a.Display();
            ab.Display();
            ac.Display();
            ad.Display();
            ae.Display();
        }
        class A
        {
            public virtual void Display()
            {
                Console.WriteLine("A");
            }
        }
        class B : A
        {
            public new void Display()
            {
                Console.WriteLine("B");
            }
        }
        class C : A
        {
            public override void Display()
            {
                Console.WriteLine("C");
            }
        }
        class D : B
        {
            public new void Display()
            {
                Console.WriteLine("D");
            }
        }
        class E : C
        {
            public new void Display()
            {
                Console.WriteLine("E");
            }
        }
    }
}