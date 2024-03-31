namespace Assignment_02.Entities
{
    public class Professor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string[]? Classes { get; set; }

        public Professor()
        {
        }

        public Professor(int id, string fName, string lName)
        {
            this.Id = id;
            this.FirstName = fName;
            this.LastName = lName;
        }
    }
}
