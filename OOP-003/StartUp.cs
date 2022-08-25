namespace OOP_003
{
    internal class StartUp
    {
        public StartUp()
        {
            // Creates a new instance of a Person object.
            Person person = new();
            // We get input via our methods, that adds values to our Person's private fields, through Person's properties.
            GetName(person);
            GetDoB(person);
            GetEmail(person);
            GetPass(person);
            Console.Clear();
            Console.WriteLine($"Hi {person.Name}\nHere is some of your data\n");
            Console.WriteLine("Birthday: " + person.DoB);
            Console.WriteLine("Email: " + person.Email);
            Console.WriteLine("Password: " + person.Password);
        }

        private void GetName(Person person)
        {

            do 
            {
                Console.Write("Enter name: ");
                person.Name = Console.ReadLine();
            }
            while (person.Name == null);
        }
        private void GetDoB(Person person)
        {

            do
            {
                Console.WriteLine("DD/MM/YYYY");
                Console.Write("Enter birthday: ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime dt)) person.DoB = dt;
                
                else person.DoB = null;
            }
            while (person.DoB == null);
        }
        private void GetEmail(Person person)
        {

            do
            {
                Console.Write("Enter email: ");
                person.Email = Console.ReadLine();
            }
            while (person.Email == null);
        }
        private void GetPass(Person person)
        {

            do
            {
                Console.Write("Enter password: ");
                person.Password = Console.ReadLine();
            }
            while (person.Password == null);
        }
    }
}
