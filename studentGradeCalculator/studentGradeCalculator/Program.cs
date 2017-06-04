using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentGradeCalculator
{
    class Program
    {

    
        static void Main(string[] args)
        {
            int studentCount = 0;
            int exam = 0;
            int examClass = 0;
            int answer = 0;
            int examAnswer = 0; 

            Console.WriteLine("Do you want to enter student marks? (1(yes) or 0(no)): ");
            answer = Convert.ToInt32(Console.ReadLine());

            while (answer == 1) // New Student counter 
            {
              
             
                  double[] testMark = new double[4];
                  float[] testAssignment = new float[5];

                   //Reading testMark 
                  for (int i = 0; i < 3; i++)
                  {
                      Console.WriteLine("Please enter mark for test: " + i);
                      testMark[i]= Convert.ToDouble(Console.ReadLine());
                  }

                  // Reading Assignment marks 
                  for(int i = 0; i<4; i++)
                  {
                      Console.WriteLine("Please enter mark for assignment: " + i);
                      testAssignment[i] = float.Parse(Console.ReadLine());
                  }

                  // Reading Exam mark 
                  Console.WriteLine("Enter exam mark: ");
                   examAnswer = Convert.ToInt32(Console.ReadLine());
                   
                  
                    //Instance of progaram
                  Program p = new Program();
                    
                    // Average of testMarks 
                   double averageTest = p.average(testMark);
                   double averageStandardT = p.standarddev(averageTest, testMark);

                    //Average of assignmentMark
                  float averageAssignment =  p.averageAssignments(testAssignment);
                  float averageStandardA = p.stardarddev1(averageAssignment, testAssignment);

                  double testScore = 0.40 * averageStandardT;
                  float assignmentScore = (float)0.15 * averageStandardA;
                  int examScore = Convert.ToInt32(0.45 * exam);

                  int finalGrade = Convert.ToInt32(testScore) + Convert.ToInt32(assignmentScore) + Convert.ToInt32(examScore);

                  Console.WriteLine("This students final grade is: " + finalGrade);
                 if(finalGrade > 80)
                 {
                     Console.WriteLine("Letter grade is: A - Excellent");
                 }
                 else if(finalGrade > 70 && finalGrade < 80)
                 {
                     Console.WriteLine("Letter grade is: B - Good");
                 }
                 else if (finalGrade > 60 && finalGrade < 69)
                 {
                     Console.WriteLine("Letter grade is: C - Fair");
                 }
                 else if (finalGrade > 50 && finalGrade < 59)
                 {
                     Console.WriteLine("Letter grade is: D - Poor");
                 }
                 else if (finalGrade < 49)
                 {
                     Console.WriteLine("Letter grade is: F - Fail");
                 }
                 Console.WriteLine("The stardDev for test is: " + averageStandardT);
                 Console.WriteLine("The stardDev for test is: " + averageStandardA);

                  examClass = examClass + examScore;
                  studentCount++;
       

                  answer = 0;
                  Console.WriteLine("Do you want to enter student marks? (1(yes) or 0(no)): ");
                  answer = Convert.ToInt32(Console.ReadLine());
            
            }
            int averageFinal = examAnswer / studentCount;
            

             


        }

        //Returns the average of Tests 
        double average(double[] inputTest)
        {
            double average1 = (inputTest[0] + inputTest[1] + inputTest[2] + inputTest[3]);
           average1 = average1 / 4;
           return average1; 
        }

        //
        double standarddev(double averageTS, double[] inputTest)
        {

            double testStandardDev = (1 / 4 - 1) * (inputTest[0] - averageTS) * (inputTest[0] - averageTS) + (inputTest[1] - averageTS) * (inputTest[1] - averageTS) + (inputTest[2] - averageTS) * (inputTest[2] - averageTS) + (inputTest[3] - averageTS) * (inputTest[3] - averageTS);
            testStandardDev = Math.Sqrt(testStandardDev);
            return testStandardDev;
        }

        //Returns the average of Assignments 
        float averageAssignments(float[] inputAssignment)
        {
            float average1 = (inputAssignment[0] + inputAssignment[1] + inputAssignment[2] + inputAssignment[3] + inputAssignment[4]);
            return average1;
        }

        float stardarddev1(float averageAS, float[] inputAssignment)
        {
            float assignmentStandardDev = (1 / 5 - 1) * (inputAssignment[0] - averageAS) * (inputAssignment[0] - averageAS) + (inputAssignment[1] - averageAS) * (inputAssignment[1] - averageAS) + (inputAssignment[2] - averageAS) * (inputAssignment[2] - averageAS) + (inputAssignment[3] - averageAS) * (inputAssignment[3] - averageAS) + (inputAssignment[4] - averageAS) * (inputAssignment[4] - averageAS);
            assignmentStandardDev = (float)(Math.Sqrt(assignmentStandardDev));
            return assignmentStandardDev;
        }
    }
}
