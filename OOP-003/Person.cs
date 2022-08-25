namespace OOP_003
{
    internal class Person
    {
        // Private fields, that contain the data/values.
        private string name;
        private int age;
        private string email;
        private string password;
        private DateTime? dob;

        // Public properties that gets (return field) and sets (from value) the datavalues of our private fields.
        public string Name { get { return name; } 
            set 
            {
                if (value == "")
                {
                    Console.WriteLine("Try again...");
                    name = null;
                }
                else name = value;
            } }
        public DateTime? DoB { get; set; }
        public int Age { get; set; }
        public string Email 
        {   
            get { return email; }
            set 
            {
                if (value.Contains("@") && value.Contains(".")) email = value;
                else Console.WriteLine("Email must contain @ and .");
            }
        } 
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length > 6 && value.Any(char.IsUpper) && value.Any(char.IsLower) && value.Any(char.IsDigit) && !value.Contains(" ")) password = value;

                else Console.WriteLine("Password has to be longer than 6 characters and must contain lower and upper case letters and atleast one number");
            }
        }
    }
}
