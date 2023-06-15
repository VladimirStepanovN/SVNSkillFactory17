namespace SVNSkillFactory17
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        class IndexingClass
        {
            private int[] array;

            public IndexingClass(int[] array)
            {
                this.array = array;
            }
            public int this[int i]
            {
                get
                {
                    return array[i];
                }
                set
                {
                    array[i] = value;
                }
            }
        }
    }
}