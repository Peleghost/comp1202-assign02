using Assignment_02.Entities;

namespace Assignment_02.Validation
{
    public class Validation
    {
        public static bool StudentExists(Student[] students, Student student)
        {
            try
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] != null && students[i].FirstName == student.FirstName)
                    {
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("- Student Already Exists! -");
                        Console.WriteLine("------------------------------");
                        Thread.Sleep(1500);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static bool ProfessorExists(Professor[] professors, Professor professor)
        {
            try
            {
                for (int i = 0; i < professors.Length; i++)
                {
                    if (professors[i] != null && professors[i].FirstName == professor.FirstName)
                    {
                        Console.WriteLine("\n------------------------------");
                        Console.WriteLine("- Professor Already Exists! -");
                        Console.WriteLine("------------------------------");
                        Thread.Sleep(1000);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static bool StudentEnrolled(string[,] students, int classIndex, string studentDetails)
        {
            try
            {
                var cols = students.GetLength(1);
                for(int i = 0; i < cols; i++)
                {
                    if (students[classIndex, i] == studentDetails)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static bool NoStudentsToEnroll(Student[] students)
        {
            try
            {
                int count = 0;
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] == null)
                    {
                        count++;
                    }
                }
                if (count == 10)
                {
                    Console.WriteLine("\n----------------------");
                    Console.WriteLine("- No Students Exist! -");
                    Console.WriteLine("----------------------");
                    Thread.Sleep(2000);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
