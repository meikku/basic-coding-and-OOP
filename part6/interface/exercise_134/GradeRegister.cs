using System.Collections.Generic;
using System;
public class GradeRegister
{
    private List<int> grades;
    private List<int> points;
    public GradeRegister()
    {
        this.grades = new List<int>(); // tehdään lista johon arvosanoja kerätään
        this.points = new List<int>();
    }

    public void AddGradeBasedOnPoints(int points) // metodin parametriksi annetaan pisteet
    {
        this.grades.Add(PointsToGrades(points)); // pisteet muutetaan arvosanoiksi ja lisätään listaan
        this.points.Add(points);
    }

    public int NumberOfGrades(int grade) // lasketaan montako arvosanaa on annettu
    {
        int count = 0;
        foreach (int received in this.grades) // jokainen listaan lisätty
        {
            if (received == grade) // jos se on arvosanaksi kelpaava
            {
                count++; // lisää lukua yhdellä
            }
        }
        return count; // palautetaan arvosanojen määrä
    }

    public static int PointsToGrades(int points) // tänne pisteet, jotka muutetaan arvosanoiksi
    {
        int grade = 0;
        if (points < 50) // jos alle 50, arvosana 0
        {
            grade = 0;
        }
        else if (points < 60) // alle 60, arvosana 1
        {
            grade = 1;
        }
        else if (points < 70) // alle 70, arvosana 2
        {
            grade = 2;
        }
        else if (points < 80)
        {
            grade = 3;
        }
        else if (points < 90)
        {
            grade = 4;
        }
        else
        {
            grade = 5;
        }
        return grade; // palautetaan arvosana
    }

    public double AverageOfGrades() // lasketaan arvosanojen keskiarvo
    {
        // Hint! You don't need to round the -1, but you do need it for all the other results...
        int i = 0;
        int sum = 0;


        while (i < grades.Count)
        {
            sum = sum + grades[i];
            i++;
        }
        if (grades.Count == 0)
        {
            return -1;
        }
        else
        {
            double average = 1.0 * sum / i;
            return Math.Round(average, 2);

        }

        // return Math.Round(-1.0, 2);
    }

    public double AverageOfPoints() // täällä lasketaan pisteiden keskiarvo
    {
        int sum = 0;
       for (int i = 0; i < points.Count; i++)
        {
            sum = sum + points[i];
            if (points.Count == 0)
            { return -1;
            }

        }
        double average = 1.0 * sum / points.Count;
        return Math.Round(average, 2);
    }
}
