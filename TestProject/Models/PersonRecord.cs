namespace TestProject.Models
{
    public record PersonRecord(string FirstName, string LastName)
    {
        public string MiddleName;
        public string Gender;
        public float Height;

        public string WhoIAm()
        {
            return $"My name is {FirstName} {MiddleName} {LastName}, I'm beautiful {Gender} and {Height}cm tall!";
        }
    }
}
