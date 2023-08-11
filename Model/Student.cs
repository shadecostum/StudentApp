using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Model
{
    internal class Student
    {
        public int studentRollNoId;
        public string studentName;
        public double cGPA;
        public string data;
        

        public Student(int studentRollNoId, string studentName, int cGPA)
        {
           
            
           //string erroe= ValidatingFunction(studentRollNoId, studentName, cGPA);
            this.studentRollNoId=ValidateRollNo(studentRollNoId);
            this.studentName = ValidateStudentName(studentName);
            this.cGPA = ValidateCGPAe(cGPA);

            
           
            
        }

        private double ValidateCGPAe(int cGPA)
        {
            if (cGPA > 10 || cGPA < 1)
            {
                Console.WriteLine("CGPA should be between 1 and 10.");
                return 0.0; 
            }
            return (cGPA / 10.0) * 100.0;
        }

        private string ValidateStudentName(string studentName)
        {
            if (studentName.Length < 5)
            {
                Console.WriteLine("student name will be minimum 5 letters"); 
                return "";
            }
            return studentName;
        }

        private int ValidateRollNo(int rollNo)
        {
           
            if (rollNo < 1)
            {
                Console.WriteLine("student number will be positive");
                return 0;
            }
            return  rollNo;
            
        }

      /*  private string ValidatingFunction(int studentRollNoId, string studentName, int cGPA)
        {
            if (studentRollNoId < 1)
            {
                return "student number will be positive";
            }
            else if (studentName.Length < 5)
            {
                return "student name will be minimum 5 letters";
            }
            else if (cGPA > 10)
            {
                return "cgpa between 10";
            }

            return "Validation successful"; // This line is added for cases where no conditions are met.
        }
*/
        public string ResultDetails()
        {
            return $" id : {studentRollNoId}, \n"+ $" Name : {studentName},\n" + $" percentage : {cGPA}";
        }
    }
}
