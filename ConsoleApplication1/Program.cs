//string meeting = "Academy";
//meeting.AddNote("I will do homeworks");

//string date = "National park";
//date.AddNote("I will say: I love you");

//string examp = "Management";
//examp.AddNote("I will must pass examp!");

//date.Remove();
//meeting.Remove();
//AddToNoteApp.SeeNote();

//class Note
//{
//    public string Title { get; set; }
//    public string Content { get; set; }

//    public DateTime DateTime { get; set; }

//}

//static class AddToNoteApp
//{
//    static List<Note> notes = new List<Note>();

//    public static void AddNote(this string title, string content)
//    {
//        try
//        {
//            Note newNote = new Note { Title = title, Content = content, DateTime = DateTime.Now };
//            notes.Add(newNote);

//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }


//    public static void Remove(this string title)
//    {
//        Note note = notes.Find(x => x.Title == title);
//        notes.Remove(note);

//    }


//    public static void SeeNote()
//    {
//        foreach (var note in notes) Console.WriteLine($"Title:{note.Title} Content: {note.Content} DateTime: {note.DateTime}");
//    }
//}





//ATMApp app = new ATMApp();
//app.Register("Asadbek", "Shermatov", 1402);
//app.AddCashToCard(1402, 10000);
//app.GetCashFromCard(1402, 5000);
//app.AddCashToCard(1402, 100000);


//app.Register("Sarodor", "Muqimov", 0101);
//app.AddCashToCard(0101, 100000);

//app.Register("Nodirbek", "Shermatov", 0112);
//app.CheckBalance(1402);

//class User
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public Uzcard Uzcard { get; set; }
//}

//class ATMApp
//{

//    readonly List<Uzcard> uzcard = new List<Uzcard>();
//    readonly List<User> users = new List<User>();

//    public void Register(string name, string surname, int cardPinCode)
//    {
//        var newUser = new User { Id = 1, Name = name, Surname = surname };
//        users.Add(newUser);
//        Uzcard newPin = cardPinCode;
//        uzcard.Add(newPin);
//    }

//    public void AddCashToCard(int pinCode, int balance)
//    {
//        var user = GetUserByPinCode(pinCode);
//        if (user != null)
//        {
//            user.Balance += balance;
//        }
//    }

//    public void GetCashFromCard(int pinCode, int balance)
//    {
//        var user = GetUserByPinCode(pinCode);
//        if (user != null)
//        {
//            user.Balance -= balance;
//        }
//    }

//    public void CheckBalance(int cardPassword)
//    {
//        var user = GetUserByPinCode(cardPassword);
//        if (user != null)
//        {
//            Console.WriteLine(user.Balance);
//        }
//    }

//    public void CheckBalance()
//    {

//    }

//    private Uzcard GetUserByPinCode(int pincode)
//    {
//        Uzcard user = new Uzcard();
//        foreach (var code in uzcard)
//        {
//            if (code.PinCode == pincode)
//            {
//                user = code;
//            }
//        }
//        return user;
//    }
//}




//class Uzcard
//{
//    public int PinCode { get; set; }
//    public int Balance { get; set; }


//    public static implicit operator Uzcard(int v)
//    {
//        return new Uzcard { PinCode = v };
//    }
//}




// Leedcode
// 1-problem;

//List<int> nums = new List<int>() { 2, 7, 11, 15 };
//int target = 9;
//for (int i = 0; i < nums.Count; i++)
//{
//    for(int j = 1; j < nums.Count; j++)
//    {
//        if(nums[i] + nums[j] == target)
//        {
//            Console.WriteLine($"{i}, {j}");
//            break;
//        }
//    }
//}


//bool IsPalindrome(int x)
//{
//    if (x < 0)
//    {
//        return false; // Negative numbers are not palindromes
//    }

//    string str = x.ToString();
//    int left = 0;
//    int right = str.Length - 1;

//    while (left < right)
//    {
//        if (str[left] != str[right])
//        {
//            return false; // If characters don't match, it's not a palindrome
//        }

//        left++;
//        right--;
//    }

//    return true; // If loop completes, it's a palindrome
//}



//int num = 121;

//bool isPalindrome = IsPalindrome(num);
//Console.WriteLine($"Is {num} a palindrome? {isPalindrome}");


//using Microsoft.EntityFrameworkCore;
//static void Main(string[] args)
//{

//}



//class User
//{
//    public  int Id { get; set; }
//    public string Name { get; set; }

//    public Laptop Laptop { get; set; }
//}

//class Laptop
//{
//    public int Id { get; set; }
//    public string Brand { get; set; }
//}

//class AppDBContext : DbContext
//{


//    DbSet<User> Users { get; set; } 
//    DbSet<Laptop> Laptops { get; set;}
//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder.UseSqlServer("Server=WIN-G3SP2SRJPL7;Database=LaptopMarketDB;Trusted_Connection=True;TrustServerCertificate=True");
//    }

//}



//Console ilova yaratib u yerda uni ishga tushirganda savol sorashi kerak bazadan talabalr ro'yxati yoki bazaga talaba qo'shish: 
//1.Talabalar ro'yxatini korsatish (agar talabalar bo'lmasa yaratish metod ishga tushishi kerak)
//2. Yangi talaba qo'shish. (ism, familiya va hokazo malumotlar)
//Talablar: SOLID tamoyilarini ishlatish, Entity Framework ishlatib bazaga qo'shish va github ga joylab link manga yuborish

using ConsoleApplication1.User;

StudentApp app = new StudentApp();
app.Initialize();
