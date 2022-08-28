Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "денис")
{
    Console.WriteLine("Ура, это же Дениска-пиписка!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}