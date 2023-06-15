namespace SVNSkillFactory17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Processor processor = new Processor();
            processor.Work();
            MotherBoard motherBoard = new MotherBoard();
            motherBoard.Work();
            GraphicCard graphicCard = new GraphicCard();
            graphicCard.Work();
        }
        abstract class ComputerPart
        {
            public abstract void Work();
        }
        class Processor : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("This Processor");
            }
        }
        class MotherBoard : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("This MotherBoard");
            }
        }
        class GraphicCard : ComputerPart
        {
            public override void Work()
            {
                Console.WriteLine("This GraphicCard");
            }
        }
    }
}