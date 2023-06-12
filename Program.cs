namespace SVNSkillFactory17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }
    class ProjectManage : Employee
    {
        public string ProjectName;
    }
    class Developer : Employee
    {
        public string ProgrammingLanguage;
    }
}