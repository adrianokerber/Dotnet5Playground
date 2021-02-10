using System.Text;

namespace TestProject.Models
{
    class PersonClass
    {
        public PersonClass(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; init; }
        public string MiddleName;
        public string LastName { get; init; }
        public string Gender;
        public float Height;

        public string WhoIAm()
        {
            return $"My name is {FirstName} {MiddleName} {LastName}, I'm beautiful {Gender} and {Height}cm tall!";
        }

        public override string ToString()
        {
            var builder = new StringBuilder()
                .Append($"{nameof(PersonClass)}")
                .Append(" { ")
                .Append($"FirstName: {FirstName}, ")
                .Append($"MiddleName: {MiddleName}, ")
                .Append($"LastName: {LastName}, ")
                .Append($"Gender: {Gender}, ")
                .Append($"Height: {Height}, ")
                .Append("}");

            return builder.ToString();
        }
    }
}
