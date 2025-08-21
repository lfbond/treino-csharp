//Exercício pratico do Módulo 2 Desafio Final - Melhorias no Programa anterior Inicio
using System.Diagnostics;
using System.Net.Http.Headers;

int examAssignments = 5;
int overallAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 }; 
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91 };

int[] sophiaScoresOverall = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScoresOverall = new int[] { 92, 89, 81, 96, 90, 89 }; 
int[] emmaScoresOverall = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScoresOverall = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScoresOverall = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScoresOverall = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScoresOverall = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScoresOverall = new int[] { 91, 91, 91, 91, 91, 91, 91 };

int extraCredit = 0;
decimal pontsExtras = 0;

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];
int[] studentOverall = new int[10];
string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tExame Score\tOverall\tGrade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    string currentOverall = name;

    if (currentOverall == "Sophia")
        studentOverall = sophiaScoresOverall;
    else if (currentOverall == "Andrew")
        studentOverall = andrewScoresOverall;
    else if (currentOverall == "Emma")
        studentOverall = emmaScoresOverall;
    else if (currentOverall == "Logan")
        studentOverall = loganScoresOverall;
    else if (currentOverall == "Becky")
        studentOverall = beckyScoresOverall;
    else if (currentOverall == "Chris")
        studentOverall = chrisScoresOverall;
    else if (currentOverall == "Eric")
        studentOverall = ericScoresOverall;
    else if (currentOverall == "Gregor")
        studentOverall = gregorScoresOverall;
    else
        continue;

    //CÓDIGO DO EXAME
    int sumAssigmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
            sumAssigmentScores += score;
        else
            sumAssigmentScores += score / 10;
    }
    currentStudentGrade = (decimal)sumAssigmentScores / examAssignments;

    //CÓDIGO DO OVERALL
    // initialize/reset the sum of scored assignments
    int sumAssignmentOverall = 0;
    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGradeOverall = 0;
    // initialize/reset a counter for the number of assignment 
    int gradedAssignmentsOverall = 0;
    // loop through the scores array and complete calculations for currentStudent
    foreach (int overall in studentOverall)
    {        
        // increment the assignment counter
        gradedAssignmentsOverall += 1;
        if (gradedAssignmentsOverall <= overallAssignments)
            // add the exam score to the sum
            sumAssignmentOverall += overall;
        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentOverall += overall / 10;
    }

    currentStudentGradeOverall = (decimal)sumAssignmentOverall / overallAssignments;

    extraCredit = sumAssigmentScores / examAssignments;
    pontsExtras = currentStudentGradeOverall - currentStudentGrade;
    
    if (currentStudentGradeOverall >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGradeOverall >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGradeOverall >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGradeOverall >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGradeOverall >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGradeOverall >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGradeOverall >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGradeOverall >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGradeOverall >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGradeOverall >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGradeOverall >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGradeOverall >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{currentStudentGradeOverall}\t{currentStudentLetterGrade}\t{extraCredit} ({pontsExtras} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();