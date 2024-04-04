namespace Assignment_02.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string[]? Classes { get; set; }

        public Student()
        {
        }

        public Student(int id, string fName, string lName)
        {
            this.Id = id;
            this.FirstName = fName;
            this.LastName = lName;
        }

        // Tam: I need this for MenuItem - option 6 View Students Enrolled In Classes
        public Student(int id, string fName, string lName, string[] aClass)
        {
            this.Id = id;
            this.FirstName = fName;
            this.LastName = lName;
            this.Classes = aClass;

        }

    }


}
