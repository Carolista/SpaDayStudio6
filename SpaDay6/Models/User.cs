namespace SpaDay6;

public class User
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime Date { get; set; } = DateTime.Now; // Bonus mission 1

    public User() {}

    public User(string username, string email, string password): this()
    {
        Username = username;
        Email = email;
        Password = password;
    }

}
