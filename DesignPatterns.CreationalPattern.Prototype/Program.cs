

// Create basic user form and clone
using DesignPatterns.CreationalPattern.Prototype;

BasicUserForm basicForm1 = new BasicUserForm
{
    UserName = "user1",
    Email = "user1@example.com",
    Password = "password1"
};

BasicUserForm basicForm2 = (BasicUserForm)basicForm1.Clone();

// Modificar el formulario clonado
basicForm2.UserName = "user2";
basicForm2.Email = "user2@example.com";
basicForm2.Password = "password2";

// Create form advanced user and clone
AdvancedUserForm advancedForm1 = new AdvancedUserForm
{
    UserName = "admin1",
    Email = "admin1@example.com",
    Address = "123 Main St",
    PhoneNumber = "555-1234"
};

AdvancedUserForm advancedForm2 = (AdvancedUserForm)advancedForm1.Clone();

// Modified clone form
advancedForm2.UserName = "admin2";
advancedForm2.Email = "admin2@example.com";
advancedForm2.Address = "456 Elm St";
advancedForm2.PhoneNumber = "555-5678";

// Show details original forms and clones
Console.WriteLine("Original and Cloned Basic User Forms:");
basicForm1.ShowDetails();
basicForm2.ShowDetails();

Console.WriteLine("\nOriginal and Cloned Advanced User Forms:");
advancedForm1.ShowDetails();
advancedForm2.ShowDetails();
