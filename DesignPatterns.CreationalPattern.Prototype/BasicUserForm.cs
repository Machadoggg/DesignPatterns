namespace DesignPatterns.CreationalPattern.Prototype
{
    public class BasicUserForm : IUserForm
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }



        public BasicUserForm() { }

        public BasicUserForm(BasicUserForm source)
        {
            if (source != null)
            { 
                UserName = source.UserName;
                Email = source.Email;
                Password = source.Password;
            } 
        }


        public object Clone()
        {
            return new BasicUserForm(this);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Basic User Form: Username: {UserName}, Email: {Email}, Password: {Password}");
        }
    }
}
