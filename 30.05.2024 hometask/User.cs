namespace _30._05._2024_task
{
    public class User: IAccount
    {
        private static int Count;
        private  int _id;
        private string _fullname;
        private string _email;
        private string _password;
        

        public User()
        {
            Count++;
            ID = Count;
        }

      
        //public User(string email, string password) :this()
        //{
        //    Email = email;
        //    Password = password;
        //}
        public User(string email, string password, string fullname) :this() 
        {
            Email = email;
            Password = password;
            Fullname = fullname;
        }

        public int ID
        {
            get { return _id; }

           private set { _id = value; }
        }

        public string Fullname { get { return _fullname; } set { _fullname = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }

        public bool PasswordChecker(string password)
        {
            if (!string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
                if (password.Length>=8)
                    if (password.Any(char.IsDigit))
                        if (password.Any(char.IsPunctuation))
                            if (password.Any(char.IsLetter))
                                if (password.Any(char.IsUpper))                       
                                     return true;
            
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {ID},  Fullname: {Fullname}, Email: {Email}, Password: {Password}");
        }
        
        
    }
}
