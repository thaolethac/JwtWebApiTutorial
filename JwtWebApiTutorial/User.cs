    namespace JwtWebApiTutorial
{
    public class User
    {
        public string Username = string.Empty;

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
