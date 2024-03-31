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
    }

    
}
