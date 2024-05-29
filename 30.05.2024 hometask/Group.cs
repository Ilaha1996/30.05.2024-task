namespace _30._05._2024_task
{
    public class Group
    {
        private string _groupNo;
        private int _studentLimit;
        private Student[] students;
        private int _studentCount;

        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            students = new Student[0];
        }

        public string GroupNo { get; set; }
         
        public int StudentLimit
        {
            get { return _studentLimit; }

            private set
            {
                if (5 <= value && value <= 18)
                    _studentLimit = value;
            }

        }


        public bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrEmpty(groupNo) && !string.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 5)
                if (char.IsUpper(groupNo[0]))
                    if (char.IsUpper(groupNo[1]))
                        if (char.IsDigit(groupNo[2]))
                            if (char.IsDigit(groupNo[3]))
                                if (char.IsDigit(groupNo[4]))
                                    return true;

            return false;

        }
        public void AddStudent(Student student)
        {
            if (_studentCount < _studentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[_studentCount] = student;
                _studentCount++;
            }

        }
        public Student GetStudent(int ID)
        {
            
            foreach (var student in students) 
            { 
                if (student.ID == ID) 
                {
                    return student; 
                }

            }              
                return null;
        }

        public Student[] GetAllStudents()
        {
            return students;
        }
        public void ShowAllStudents()
        {
            foreach (var student in students)
            {
                student.StudentInfo();
            }
        }

    }
}
