using TreeCollection.TestModels.Enums;

namespace TreeCollection.TestModels.Models
{
    public class ExamResult : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exams Exam { get; set; }
        public Score Score { get; set; }
        public DateTime Date { get; set; }

        public ExamResult(int id, string name, Exams exam, Score score, DateTime date)
        {
            Id = id;
            Name = name;
            Exam = exam;
            Score = score;
            Date = date;
        }

        public bool CompareExamResults(IComparable comparable)
        {
            if(this.Name.Equals(comparable.Name)){
                this.Date.date 
            }
        }

        private bool CompareValues(var value1, var value2)
        {
            return value1 == value2;
        }
    }
}
