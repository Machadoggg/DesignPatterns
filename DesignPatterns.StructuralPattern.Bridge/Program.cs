using DesignPatterns.StructuralPattern.Bridge;

IAuthentication passwordAuth = new PasswordAuthentication();
IAuthentication tokenAuth = new TokenAuthentication();
IAuthentication biometricAuth = new BiometricAuthentication();


User adminWithPasswod = new AdminUser("admin1", passwordAuth);
User adminWithToken = new AdminUser("admin2", tokenAuth);
User adminWithBiometric = new AdminUser("admin3", biometricAuth);

User userWithPassword = new StandardUser("user1", passwordAuth);
User userWithToken = new StandardUser("user2", tokenAuth);
User userWithBiometric = new StandardUser("user2", biometricAuth);

User anotherUserWithPassword = new AnotherUser("anotherUser1", passwordAuth);
User anotherUserWithToken = new AnotherUser("anotherUser2", tokenAuth);
User anotherUserWithBiometric = new AnotherUser("anotherUser3", biometricAuth);


adminWithPasswod.Login("adminPassword");
adminWithToken.Login("adminToken");
adminWithBiometric.Login("adminBiometric");

userWithPassword.Login("userPassword");
userWithToken.Login("userToken");
userWithBiometric.Login("userBiometric");

anotherUserWithPassword.Login("anotherUserPassword");
anotherUserWithToken.Login("anotherUserToken");
anotherUserWithBiometric.Login("anotherUserBiometric");
