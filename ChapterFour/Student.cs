namespace VisualCsharpHowToProgram.ChapterFour;

public class Student
{
    public string StudentId { get; set; }
    public string StudentName { get; set; }
    private decimal _scoreOne;
    private decimal _scoreTwo;
    private decimal _scoreThree;
    private const decimal MaxScore = 50.0m;

    public Student(string studentId, string studentName, decimal scoreOne, decimal scoreTwo, decimal scoreThree)
    {
        StudentId = studentId;
        StudentName = studentName;
        ScoreOne = scoreOne;
        ScoreTwo = scoreTwo;
        ScoreThree = scoreThree;
    }

    public decimal ScoreOne
    {
        get => _scoreOne;
        private set
        {
            if (value is > 0.0m and <= MaxScore)
            {
                _scoreOne = value;
            }
        }
    }
    public decimal ScoreTwo
    {
        get => _scoreTwo;
        private set
        {
            if (value is > 0.0m and <= MaxScore)
            {
                _scoreTwo = value;
            }
        }
    }
    public decimal ScoreThree
    {
        get => _scoreThree;
        private set
        {
            if (value is > 0.0m and <= MaxScore)
            {
                _scoreThree = value;
            }
        }
    }

    public void ChangeScore(decimal newScore, int exam)
    {
        switch (exam)
        {
            case 1:
                ScoreOne = newScore;
                break;
            case 2:
                ScoreTwo = newScore;
                break;
            case 3:
                ScoreThree = newScore;
                break;
            default:
                Console.WriteLine("Out of range of exams");
                break;
        }
    }

    public decimal GetAggregate() => (ScoreOne + ScoreTwo + ScoreThree);

    public decimal GetPercentage() => (GetAggregate() / (MaxScore * 3)) * 100;
}