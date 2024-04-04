namespace Assignment_02.Entities
{
    public class Professor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string[] Classes { get; set; } = { "Math", "Web", "OOP", "Linux", "Databases" }; // Assigning default classes for every professor created

        public Professor()
        {
        }

        public Professor(int id, string fName, string lName)
        {
            this.Id = id;
            this.FirstName = fName;
            this.LastName = lName;
        }

        // Tam: I need to this MenuItem - option 7: View Professor Teaching Classe
        public Professor(int id, string fName, string lName, string[] aClass)
        {
            this.Id = id;
            this.FirstName = fName;
            this.LastName = lName;
            this.Classes = aClass;
        }

    }
}
