namespace DesignPatterns.CreationalPattern.Prototype
{
    public class AdvancedUserForm : IUserForm
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }


        public AdvancedUserForm()
        {

        }

        public AdvancedUserForm(AdvancedUserForm source)
        {
            if (source != null)
            {
                UserName = source.UserName;
                Email = source.Email;
                Address = source.Address;
                PhoneNumber = source.PhoneNumber;
            }
        }


        public object Clone()
        {
            return new AdvancedUserForm(this);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Advanced User Form: Username: {UserName}, Email: {Email}, Address: {Address}, Phone: {PhoneNumber}");
        }
    }
}
