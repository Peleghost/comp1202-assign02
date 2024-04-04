using Assignment_02.Entities;
using System.Text.RegularExpressions;
using static Assignment_02.Utility.Utillity;

namespace Assignment_02.Display
{
    public class Display
    {
        public static string MenuItems()
        {
            var regex = new Regex("[0-7]");

            try
            {
                Console.WriteLine("---------------- College Management System ----------------");
                Console.WriteLine("      ----- Menu -----");
                Console.WriteLine("----------------------------\n");
                Console.WriteLine("1) Add Student");
                Console.WriteLine("2) Add Professor");
                Console.WriteLine("3) View All Students");
                Console.WriteLine("4) View All Professors");
                Console.WriteLine("5) Enroll Student In Classes");
                Console.WriteLine("6) View Students Enrolled In Classes");
                // Tam: The assignment - requirement 5: Data Display... ask to professors and the class they teach
                Console.WriteLine("7) View Professor Teaching Classes\n");
                Console.WriteLine("----------------------------");
                Console.WriteLine("0) Exit");
                Console.WriteLine("----------------------------\n");
                Console.Write("> ");

                var input = Console.ReadLine();

                while (!regex.IsMatch(input!) || Convert.ToInt32(input) > 7)
                {
                    Console.WriteLine("Please enter a valid selection! ");
                    Console.Write("> ");
                    input = Console.ReadLine();
                }

                return input!;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static Student CreateStudentMenu(int id)
        {
            try
            {
                string fName, lName;

                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("- Please enter student First Name: ");
                Console.Write("> ");

                fName = Console.ReadLine().Trim();

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("- Please enter student Last Name: ");
                Console.Write("> ");

                lName = Console.ReadLine();

                var student = new Student()
                {
                    Id = id,
                    FirstName = fName,
                    LastName = lName
                };

                return student;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static Professor CreateProfessorMenu(int id)
        {
            try
            {
                string fName, lName;

                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("- Please enter professor First Name: ");
                Console.Write("> ");

                fName = Console.ReadLine().Trim();

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("- Please enter professor Last Name: ");
                Console.Write("> ");

                lName = Console.ReadLine().Trim();

                var professor = new Professor()
                {
                    Id = id,
                    FirstName = fName,
                    LastName = lName
                };

                return professor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static void DisplayStudents(Student[] students)
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"--------------------------------------");
                Console.WriteLine($"-------------- Students --------------");
                Console.WriteLine($"\n------- Name -------------- Id -------");

                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] == null)
                    {
                        break;
                    }

                    var student = students[i];

                    Console.WriteLine($"- {student.FirstName} {student.LastName} | {student.Id}");
                    Console.WriteLine($"------------------------------------");
                }
                Console.WriteLine("\n\n0) Exit");
                Console.Write("> ");
                while (Console.ReadLine() != "0")
                {
                    Thread.Sleep(10000);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static void DisplayProfessors(Professor[] professors)
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"--------------------------------------");
                Console.WriteLine($"-------------- Professors --------------");
                Console.WriteLine($"\n------- Name -------------- Id -------");

                for (int i = 0; i < professors.Length; i++)
                {
                    if (professors[i] == null)
                    {
                        break;
                    }

                    var professor = professors[i];

                    Console.WriteLine($"- {professor.FirstName} {professor.LastName} | {professor.Id}");
                    Console.WriteLine($"------------------------------------");
                }
                Console.WriteLine("\n\n0) Exit");
                Console.Write("> ");
                while (Console.ReadLine() != "0")
                {
                    Thread.Sleep(10000);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static Student SelectStudentMenu(Student[] students)
        {
            try
            {
                var regex = new Regex("[0-9]");

                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"----- Please select student to enroll -----");
                Console.WriteLine($"-------------------------------------------");

                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] == null)
                    {
                        break;
                    }

                    var student = students[i];

                    Console.WriteLine($"{i + 1}) {student.FirstName} {student.LastName}");
                    Console.WriteLine($"------------------------------------");
                }

                Console.Write("> ");
                var input = Console.ReadLine();

                while (!regex.IsMatch(input!) || Convert.ToInt32(input) > 10)
                {
                    Console.WriteLine("Please enter a valid selection! ");
                    Console.Write("> ");
                    input = Console.ReadLine();
                }

                var index = Convert.ToInt32(input) - 1;
                var result = students[index];

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static void EnrollStudentMenu(Student[] students, string[,] enrolledClasses)
        {// Tam: need to stop user choose the class which is fully enrolled here by using IndexOutOfRangeException ???
            try
            {
                //int studentCount = 0;

                Console.Clear();
                var regex = new Regex("[1-5]");

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Please select class to enroll student: ");
                Console.WriteLine("1) Math");
                Console.WriteLine("2) Web");
                Console.WriteLine("3) OOP");
                Console.WriteLine("4) Linux");
                Console.WriteLine("5) Databases");
                Console.Write("\n> ");

                var classInput = Console.ReadLine();

                while (!regex.IsMatch(classInput!) || Convert.ToInt32(classInput) > 5)
                {
                    Console.WriteLine("Please enter a valid selection! ");
                    Console.Write("> ");
                    classInput = Console.ReadLine();
                }

                var classIndex = Convert.ToInt32(classInput) - 1;

                if (enrolledClasses[classIndex, 3] != null)
                {
                    Console.WriteLine("CLASS FULL !!!");
                    Thread.Sleep(2000);

                }
                else
                {
                    var student = SelectStudentMenu(students);
                    EnrollStudent(enrolledClasses, classInput, student);
                }


            }
            catch (IndexOutOfRangeException iex)
            {
                Console.WriteLine(iex.Message);
                Thread.Sleep(2000);
                throw;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }


        //  Tam: I need this for MenuItem - option 6 View Students Enrolled In Classes
        public static void DisplayStudentsEnrolledClasses(string[,] classes)
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"--------------------------------------");
                Console.WriteLine($"-------------- Students --------------");
                Console.WriteLine($"\n------- Name -------------- Id ------- Class -------");

                int rows = classes.GetLength(0);
                int cols = classes.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    var temp = classes[i, 0];

                    for (int j = 0; j < cols; j++)
                    {

                        Console.WriteLine(classes[i, j]);
                    }

                }
                Console.WriteLine("\n\n0) Exit");
                Console.Write("> ");
                while (Console.ReadLine() != "0")
                {
                    Thread.Sleep(10000);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        // Tam: I need to this MenuItem - option 7: View Professor Teaching Classes
        public static void DisplayProfessorsTeachingClasses(Professor[] professors)
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"--------------------------------------");
                Console.WriteLine($"-------------- Professors --------------");
                Console.WriteLine($"\n------- Name -------------- Id ------- Class -------");

                for (int i = 0; i < professors.Length; i++)
                {
                    if (professors[i] == null)
                    {
                        break;
                    }

                    var professor = professors[i];

                    Console.WriteLine($"- {professor.FirstName} {professor.LastName} | {professor.Id} | ");
                    Console.WriteLine("Classes Taught:");
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine($"- {professor.Classes[j]}");
                    }
                    Console.WriteLine($"------------------------------------");

                }
                Console.WriteLine("\n\n0) Exit");
                Console.Write("> ");
                while (Console.ReadLine() != "0")
                {
                    Thread.Sleep(10000);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        // ---------- Exit Msg ----------
        public static void ExitMsg()
        {
            Console.Clear();
            Console.WriteLine("\n------- Goodbye! -------");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}













