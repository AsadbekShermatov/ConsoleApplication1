namespace ConsoleApplication1.User
{
    public interface IPerson
    {

        string FirstName { get; }
        string LastName { get; }
        int Age { get; }
        string Email { get; }
        string Phone { get; }
    }
}
