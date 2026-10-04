class Program
{
    public static void Main()
    {
        Assignment assignment = new Assignment("""Samuel Bennett  """, """Multiplication""");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("""`Samuel Bennett  """, """Fractions""", """7.3""", """8-19""");
        Console.WriteLine(mathAssignment.GetSummary());

        WritingAssignment writingAssignment = new WritingAssignment("""`Samuel Bennett  """, """European History""", """The Causes of World War II""");
    }
}