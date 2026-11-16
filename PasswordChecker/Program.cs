bool HasMinLength(string password, int minLength)
{
    return password.Length > minLength;
}
bool HasDigit(string password)
{
    bool flag = false;
    foreach (char symbol in password)
    {
        if (char.IsDigit(symbol))
        {
            flag = true;
            break;
        }
    }
    return flag;
}
bool HasUpperCase(string password)
{
    bool flag = false;
    foreach (char symbol in password)
    {
        if (char.IsUpper(symbol))
        {
            flag = true;
            break;
        }
    }
    return flag;
}
bool IsPasswordValid(string password)
{
    return HasMinLength(password, 8) && HasDigit(password) && HasUpperCase(password);
}
System.Console.Write("Введите ваш пароль: ");
string password = System.Console.ReadLine();
System.Console.WriteLine();
System.Console.WriteLine($"Проверка на подходящий пароль: {IsPasswordValid(password)}");
System.Console.WriteLine();
System.Console.WriteLine("Результат трёх проверок:");
System.Console.WriteLine($"HasMinLength - [{HasMinLength(password, 8)}]");
System.Console.WriteLine($"HasDigit - [{HasDigit(password)}]");
System.Console.WriteLine($"HasUpperCase - [{HasUpperCase(password)}]");