using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {




        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("firstName", "First name should NOT be null.");
            }

            this.firstName = null;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("lastName", "Last name should NOT be null.");
            }

            this.lastName = value;
        }
    }

    public IList<Exam> Exams { get; set; }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("exams", "Exams must be initialized before they can be checked.");
        }

        if (this.Exams.Count == 0)
        {
            throw new InvalidOperationException("Student has no exams to check.");
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("exams", "Exams must be initialized before they can be processed.");
        }

        if (this.Exams.Count == 0)
        {
            throw new InvalidOperationException("Student has no exams to process.");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
