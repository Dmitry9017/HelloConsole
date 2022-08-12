Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();
    if(userName.ToLower() == "юля"){
        Console.WriteLine("Категорически приветствую Вас, " + userName);
    } else {
        Console.WriteLine("Привет, " + userName + "!");
    }

