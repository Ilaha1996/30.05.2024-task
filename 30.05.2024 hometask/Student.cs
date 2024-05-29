using System.Threading.Channels;

namespace _30._05._2024_task
{
    public class Student
    {
        private static int Count;
        private int _id;
        private string _fullname;
        private int _point;

        public Student()
        {
            Count++;
            ID = Count;
        }

        public Student(string fullname, int point):this()
        {
            Fullname = fullname;
            Point = point;
            
        }

        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Fullname { get; set; }
        public int Point { get; set; }

        public void StudentInfo()
        {
            Console.WriteLine($"ID: {ID}, Fullname: {Fullname}, Point: {Point}");
        }



    }
}




