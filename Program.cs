using System;

namespace СайтСистема
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Если у тебя уже есть аккаунт, то напиши ВОЙТИ, если нет - ЗАРЕГИСТРИРОВАТЬСЯ");
            string answerReg = Console.ReadLine();
            if (answerReg == "Войти" || answerReg == "войти")
            {
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                
                if (name != "Valera")
                {
                    Console.WriteLine("Ошибка, введите правильное имя пользователя!");
                }
                if (name == "Valera")
                {
                    Console.WriteLine("Пароль: ");
                    string passsword = Console.ReadLine();
                    if (passsword != "12345")
                    {
                        Console.WriteLine("Введите правильный пароль!");
                    }
                    else
                    {
                        Console.WriteLine("Добро пожаловать на страницу, " + name);
                    }
                }
            }
            if (answerReg == "Зарегистрироваться")
            {
                
            }
            
            
        }
    }
}
