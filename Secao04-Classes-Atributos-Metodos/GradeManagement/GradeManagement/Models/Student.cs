namespace GradeManagement.Models
{
    public class Student
    {
        public string Name { get; set; }
        public double NoteA { get; private set; }
        public double NoteB { get; private set; }
        public double NoteC { get; private set; }

        public double FinalGrade => NoteA + NoteB + NoteC;

        public string SetNoteA(double value)
        {
            if (value > 30 || value < 0)
                return "Nota A invalida. Deve estar entre 0 e 30.";

            NoteA = value;
            return string.Empty;
        }

        public string SetNoteB(double value)
        {
            if (value > 35 || value < 0)
                return "Nota B invalida. Deve estar entre 0 e 35.";

            NoteB = value;
            return string.Empty;
        }

        public string SetNoteC(double value)
        {
            if (value > 35 || value < 0)
                return "Nota C invalida. Deve estar entre 0 e 35.";

            NoteC = value;
            return string.Empty;
        }

        public bool IsApproved()
        {
            return FinalGrade >= 60;
        }

        public double RemainingPoints()
        {
            return IsApproved() ? 0 : 60 - FinalGrade;
        }
    }
}
