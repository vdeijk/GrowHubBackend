namespace CourseAssignments
{
    public class CalculatorApp
    {
        Printer printer = new Printer();
        Parser parser = new Parser();
        Reader reader = new Reader();
        Calculator calculator = new Calculator();

        private string[] fieldNames = { "first", "second" };
        public List<int> storedNumbers { get; private set; } = new List<int>();

        public void CycleInput(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                printer.Print($" Please enter the {fieldNames[i]} number");
                storedNumbers.Add(parser.Parse(reader.ReadNumber()));
            }
        }

        public void CalculateInput()
        {
            printer.Print("What do you want to do with these numbers?");
            printer.Print("[A]dd");
            printer.Print("[S]ubtract");
            printer.Print("[M]ultiply");

            printer.Print(ProcessNumbers(reader.ReadString()));
        }

        private string ProcessNumbers(string? choice)
        {
            switch (choice)
            {
                case "A":
                    return calculator.Add(storedNumbers[0], storedNumbers[1]).ToString();
                case "S":
                    return calculator.Subtract(storedNumbers[0], storedNumbers[1]).ToString();
                case "M":
                    return calculator.Multiply(storedNumbers[0], storedNumbers[1]).ToString();
            }

            return "Invalid choice.";
        }
    }
}
