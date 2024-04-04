using Assignment_02.Entities;
using static Assignment_02.Display.Display;
using static Assignment_02.Validation.Validation;
using static Assignment_02.Utility.Utillity;

namespace Assignment_02
{
    // ----------------------------------------------------
    // COMP 1202 - Assignment 02: College Management System
    // 
    // ---------------- Members ----------------
    // Fellipe C.T De Camargo - 101497831
    // Tam Ha -
    // -----------------------------------------

    internal class Program
    {
        // Global int Ids to simulate an auto-increment.
        // In a real world scenario we would have a database for this type of application
        private static int studentId = 1; 
        private static int professorId = 1;
        //

        static void Main(string[] args)
        {
            // Arrays to store all students and professors
            Student[] students = new Student[10];
            Professor[] professors = new Professor[10];

            // Student Enrolled Classes
            string[,] enrolledClasses = new string[5, 4];
            CreateClasses(enrolledClasses);
            
            // Professor Taught Classes
            string[,] taughtClasses = new string[5, 4];
            CreateClasses(taughtClasses);

            bool start = true;

            while (start)
            {
                Console.Clear();

                var userInput = MenuItems();

                switch (userInput)
                {
                    // Add Student
                    case "1":
                        var student = CreateStudentMenu(studentId);

                        if(StudentExists(students, student))
                        {
                            break;
                        }
                        else
                        {
                            AddStudent(students, student);
                            studentId++;
                        }

                        break;

                    // Add Professor
                    case "2":
                        var professor = CreateProfessorMenu(professorId);

                        if (ProfessorExists(professors, professor))
                        {
                            break;
                        }
                        else
                        {
                            AddProfessor(professors, professor);
                            professorId++;
                        }

                        break;

                    // View all Students
                    case "3":
                        DisplayStudents(students);

                        break;

                    // View all Professors
                    case "4":
                        DisplayProfessors(professors);

                        break;

                    // Enroll Students
                    case "5":
                        EnrollStudentMenu(students, enrolledClasses);

                        break;

                    // View Students Enrolled
                    case "6":

                        break;

                    // Exit App
                    case "0":
                        ExitMsg();

                        break;
                }
            }

            
        }
    }
}