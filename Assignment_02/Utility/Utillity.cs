using Assignment_02.Entities;
using static Assignment_02.Validation.Validation;

namespace Assignment_02.Utility
{
    public static class Utillity
    {
        public static void CreateClasses(string[,] classes)
        {
            classes[0, 0] = "Math";
            classes[1, 0] = "Web";
            classes[2, 0] = "OOP";
            classes[3, 0] = "Linux";
            classes[4, 0] = "Databases";
        }

        public static Student[] AddStudent(Student[] students, Student student)
        {
            try
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] == null)
                    {
                        students[i] = student;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                return students;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static Professor[] AddProfessor(Professor[] professors, Professor professor)
        {
            try
            {
                for (int i = 0; i < professors.Length; i++)
                {
                    if (professors[i] == null)
                    {
                        professors[i] = professor;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                return professors;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static void EnrollStudent(string[,] enrolledClasses, string c, Student student)
        {
            try
            {
                // Subtracting 1 from selection as array is 0 indexed
                var classIndex = Convert.ToInt32(c) - 1;

                // var rows = enrolledClasses.GetLength(0);
                var cols = enrolledClasses.GetLength(1);

                string studentDetails = String.Format($"{student.FirstName}, {student.LastName} | {student.Id}");

                for (int i = 0; i < cols; i++)
                {
                    if (StudentEnrolled(enrolledClasses, classIndex, studentDetails))
                    {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("- Student Already Enrolled! -");
                        Console.WriteLine("-----------------------------");
                        break;
                    }
                    else if (enrolledClasses[classIndex, i] == null)
                    {
                        enrolledClasses[classIndex, i] = studentDetails;
                        break;                    }
                    else
                    {
                        continue;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        
    }
}
