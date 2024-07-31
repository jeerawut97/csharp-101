namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce() {
            Console.WriteLine("My name is {0} {1}", FirstName, LastName);
        }
    }
    class ProgramClasses
    {
        static void _()
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Dare";
            john.Introduce();
        }
    }
}
