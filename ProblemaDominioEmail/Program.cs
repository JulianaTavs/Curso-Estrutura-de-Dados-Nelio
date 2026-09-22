using ProblemaDominioEmail;

EmailInfo email = new EmailInfo();
email.ExtractEmailInformation("joao.silva23@yahoo.com.br");
Console.WriteLine(email);

Console.WriteLine("");

EmailInfo email2 = new EmailInfo();
email2.ExtractEmailInformation("maria123@gmail.com");
Console.WriteLine(email2);