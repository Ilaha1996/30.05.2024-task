using _30._05._2024_task;

namespace _30._05._2024_hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Birinci hisse
            //Console.Write("Enter user fullname: ");
            //string fullname = Console.ReadLine();

            //Console.Write("Enter user email: ");
            //string email = Console.ReadLine();

            //Console.Write("Enter user password: ");
            //string password = Console.ReadLine();

            //User user = new User(fullname,email,password);

            //if (user.PasswordChecker(password))
            //{
            //    user.ShowInfo();
            //}
            //else 
            //{
            //    Console.WriteLine("Invalid password.");
            //}


            // Ikinci hisse


            User user = null;
            Group group = null;

            while (true) 
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Show user info");
                Console.WriteLine("2. Create a new group");
                Console.Write("Select an option (1 or 2): ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    if (user != null)
                    {
                        user.ShowInfo();
                    }
                    else
                    {
                        Console.WriteLine("No user created yet. Please create a user first.");
                        user = CreateUser();
                    }

                }

                else if (option == "2")
                {
                    group = CreateGroup();

                    if (group != null) 
                    {
                        while (true) 
                        {
                            Console.WriteLine("Group Menu:");
                            Console.WriteLine("1. Show all students");
                            Console.WriteLine("2. Go to student by id");
                            Console.WriteLine("3. Add student");
                            Console.WriteLine("0. Quit");
                            Console.Write("Select an option: ");
                            string groupOption = Console.ReadLine();

                            if (groupOption == "1")
                            {
                                group.ShowAllStudents();
                            }
                            else if (groupOption == "2")
                            {
                                Console.Write("Enter student ID: ");
                                if (int.TryParse(Console.ReadLine(), out int studentId)) 
                                {
                                    var student = group.GetStudent(studentId);
                                    if (student != null)
                                    {
                                        student.StudentInfo();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Student not found.");
                                    }
                                }
                                
                                else
                                {
                                    Console.WriteLine("Invalid ID format.");
                                }

                            }
                            else if (groupOption == "3") 
                            {
                                Console.Write("Enter student fullname: ");
                                string fullname = Console.ReadLine();

                                Console.Write("Enter student point: ");
                                if (int.TryParse(Console.ReadLine(), out int point)) 
                                {
                                    Student student = new Student(fullname, point);
                                    group.AddStudent(student);
                                    Console.WriteLine("Student added successfully.");

                                }
                                else
                                {
                                    Console.WriteLine("Invalid point format.");
                                }

                            }

                            else if (groupOption == "0")
                            {
                                Console.WriteLine("Exiting group menu...");
                                break;
                            }
                            else 
                            {
                                Console.WriteLine("Invalid option. Please select 1, 2, 3, or 0.");

                            }

                        }

                    }

                }
                else
                {
                    Console.WriteLine("Invalid option. Please select 1 or 2.");
                }

            }

        }
        private static User CreateUser() 
        {
            Console.Write("Enter user fullname: ");
            string fullname = Console.ReadLine();

            Console.Write("Enter user email: ");
            string email = Console.ReadLine();

            Console.Write("Enter user password: ");
            string password = Console.ReadLine();

            User user = new User(email, password, fullname);

            if (user.PasswordChecker(password)) 
            {
                Console.WriteLine("User created successfully.");
                return user;

            }
            else
            {
                Console.WriteLine("Invalid password. User creation failed.");
                return null;
            }
        }
        private static Group CreateGroup() 
        {
            Console.Write("Enter group name: ");
            string groupName = Console.ReadLine();

            Console.Write("Enter student limit: ");
            if (int.TryParse(Console.ReadLine(), out int studentLimit) && studentLimit >= 5 && studentLimit <= 18)
            {
                Group group = new Group(groupName, studentLimit);
                Console.WriteLine("Group created successfully.");
                return group;
            }
            else 
            {
                Console.WriteLine("Invalid student limit. It must be between 5 and 18.");
                return null;

            }

        }
    }
}
