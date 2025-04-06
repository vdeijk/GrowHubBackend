
namespace CourseAssignments
{
    public class Parser
    {
        public int Parse(string input)
        {
            return int.TryParse(input, out int result) ? result : 0;
        }
    }
}
