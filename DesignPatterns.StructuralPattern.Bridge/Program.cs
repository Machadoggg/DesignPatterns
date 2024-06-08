using DesignPatterns.StructuralPattern.Bridge;

IAuthentication passwordAuth = new PasswordAuthentication();
IAuthentication tokenAuth = new TokenAuthentication();


User adminWithPasswod = new AdminUser("admin1", passwordAuth);
User adminWithToken = new AdminUser("admin2", tokenAuth);

User userWithPassword = new StandardUser("user1", passwordAuth);
User userWithToken = new StandardUser("user2", tokenAuth);

User anotherUserWithPassword = new AnotherUser("anotherUser1", passwordAuth);
User anotherUserWithToken = new AnotherUser("anotherUser2", tokenAuth);


adminWithPasswod.Login("adminPassword");
adminWithToken.Login("adminToken");

userWithPassword.Login("userPassword");
userWithToken.Login("userToken");

anotherUserWithPassword.Login("anotherUserPassword");
anotherUserWithToken.Login("anotherUserToken");
