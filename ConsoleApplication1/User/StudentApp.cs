using ConsoleApplication1.Data;

namespace ConsoleApplication1.User
{
    public class StudentApp
    {

        public void Initialize()
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Hello, welcome to our console application!");
            Console.WriteLine("1. If you want to add students, press number => 1");
            Console.WriteLine("2. If you want to show students, press number => 2");

            if (!int.TryParse(Console.ReadLine(), out int pressedNumber) || (pressedNumber != 1 && pressedNumber != 2))
            {
                Console.WriteLine("Invalid input! Please enter either 1 or 2.");
            }

             if(pressedNumber == 1)
            {
                List<Student> studentData = GetStudentData();
            List<Student> newStudents = AddStudentDataToList(studentData, students);
            AppDBContext appDBContext = new AppDBContext();
            appDBContext.Students.AddRange(newStudents);
            appDBContext.SaveChanges();
                
            }else if(pressedNumber == 2)
            {
                ShowStudentData();
            }
        }

        private List<Student> GetStudentData()
        {
            Console.Write("Enter your first name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string studentLastName = Console.ReadLine();
            Console.Write("Enter your age: ");
            if (!int.TryParse(Console.ReadLine(), out int studentAge))
            {
                Console.WriteLine("Invalid input! Please enter a valid age.");
                return null;
            }
            Console.Write("Enter your email: ");
            string studentEmail = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            string studentPhoneNumber = Console.ReadLine();

            return new List<Student> { new Student {
                 FirstName = studentName,
                 LastName = studentLastName,
                 Age = studentAge,
                 Email = studentEmail,
                 Phone = studentPhoneNumber
            } };
        }


        protected List<Student> AddStudentDataToList(List<Student> sourceList, List<Student> destinationList)
        {
            if (sourceList != null && destinationList != null)
            {
                destinationList.AddRange(sourceList);
                return destinationList;
            }
            else
            {
                Console.WriteLine("Error: Source or destination list is null.");
                return null;
            }
        }


        void ShowStudentData()
        {
            AppDBContext dbContext = new AppDBContext();
            foreach (var student in dbContext.Students)
            {
                Console.WriteLine($"First name: {student.FirstName}, Last Name:  {student.LastName}, Age: {student.Age}, Email: {student.Email}, Phone Number: {student.Phone}");
            }

        }

    }
}

