using System.Text;

namespace TestProject
{
    public struct PersonStruct
    {
        public string FirstName { get; init; }
        public string MiddleName { get; set; }
        public string LastName { get; init; }
        public string Gender { get; set; }
        public float Height { get; set; }

        public string WhoIAm()
        {
            return $"My name is {FirstName} {MiddleName} {LastName}, I'm beautiful {Gender} and {Height}cm tall!";
        }

        public override string ToString()
        {
            var builder = new StringBuilder()
                .Append($"{nameof(PersonStruct)}")
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
