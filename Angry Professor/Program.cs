using System;

namespace Angry_Professor
{
    class Program
    {
        static string AngryProfessor(int numberOfStudents,int requiredStudentsEarily, string[] ConsoleValue){
            int numberOfStudentCameInTime = 0;
            int studentTimeToCome = 0;
            
             for(int j = 0; j < numberOfStudents; j++)
                {
                    studentTimeToCome = Convert.ToInt32(ConsoleValue[j]);
                    if (studentTimeToCome <= 0 ) numberOfStudentCameInTime += 1;
                }
                
                Console.WriteLine(numberOfStudentCameInTime);
                Console.WriteLine(requiredStudentsEarily);
                if(numberOfStudentCameInTime >= requiredStudentsEarily) 
                    return("NO");
                else 
                    return("YES");
        }

        static void Main(string[] args)
        {
            int numberOfCases = 0;
            numberOfCases = Convert.ToInt32(Console.ReadLine());


            int numberOfStudents = 0;
            int requiredStudentsEarily = 0;
            
            
            
            string[] ConsoleValue;

            for(int i = 0 ; i < numberOfCases; i++){
                ConsoleValue = Console.ReadLine().Split(" ");
                numberOfStudents = Convert.ToInt32(ConsoleValue[0]);
                requiredStudentsEarily = Convert.ToInt32(ConsoleValue[1]);

                ConsoleValue = Console.ReadLine().Split(" ");
                
                string result = AngryProfessor(numberOfStudents,requiredStudentsEarily,ConsoleValue);
                Console.WriteLine(result);
            }
            
        }
    }
}
