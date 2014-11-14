using System;

public class CSharpExam : Exam
{
    private const int MinGrade = 0;
    private const int MaxGrade = 100;

    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }
        private set
        {
            if (value < MinGrade || value > MaxGrade)
            {
                throw new ArgumentOutOfRangeException("score", string.Format("Exam score should be in range [{0}...{1}", MinGrade, MaxGrade));
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score < MinGrade || this.Score > MaxGrade)
        {
            throw new ArgumentOutOfRangeException("score", string.Format("Exam score should be in range [{0}...{1}", MinGrade, MaxGrade));
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
