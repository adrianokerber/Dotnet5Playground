namespace TestProject.Models
{
    public static class BoolExtension
    {
        public static string AsText(this bool value) => value ? "True" : "False";
    }
}
