using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class Authorisation
    {
        
        
         string _login;
         string _FirstPassword;
        string _SecondPassword;
        string _email;
        string _phone;
        string _code;
        public string GetLogin()
        {
            return _login;
        }
        public void SetLogin(string login)
        {
            _login = login;
        }
        public string GetFirstPassword()
        {
            return _FirstPassword;
        }
        public void SetFirstPassword(string firstPassword)
        {
            _FirstPassword = firstPassword;
        }
        public string GetSecondPassword()
        {
            return _SecondPassword;
        }
        public void SetSecondPassword(string secondPassword)
        {
            _SecondPassword = secondPassword;
        }
        public string GetEmail()
        {
            return _email;
        }
        public void SetEmail(string email)
        {
            _email = email;
        }
        public  string GetPhone()
        {
            return _phone;
        }
        public void SetPhone(string phone)
        {
            _phone = phone;
        }
        public string GetCode()
        {
            return _code;
        }
        public void SetCode(string code)
        {
            _code = code;
        }


        public void LoginAndPassword()
        {
            Program program = new Program();
            
            Console.WriteLine("Введите логин");
            _login = Console.ReadLine();

Console.WriteLine("Введите пароль");
                _FirstPassword = Console.ReadLine();
                Console.WriteLine("Подтвердите пароль");
                _SecondPassword = Console.ReadLine();
            while (true)
            {
                
                if (_FirstPassword != _SecondPassword)
                {
                   
                    Console.WriteLine("Пароли не совпадают");
                    Console.WriteLine("Введите пароль заново");
                    _FirstPassword = Console.ReadLine();
                    Console.WriteLine("Подтвердите пароль");
                    _SecondPassword = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Все прошло успешно");
                    break;
                }
            }

            //string pass = "";
            //do
            //{
            //    ConsoleKeyInfo key = Console.ReadKey(true);
            //    // Backspace Should Not Work
            //    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            //    {
            //        pass += key.KeyChar;
            //        Console.Write("*");
            //    }
            //    else
            //    {
            //        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
            //        {
            //            pass = pass.Substring(0, (pass.Length - 1));
            //            Console.Write("\b \b");
            //        }
            //        else if (key.Key == ConsoleKey.Enter)
            //        {
            //            break;
            //        }
            //    }
            //} while (true);




            Console.WriteLine("Введите Email");
            _email=Console.ReadLine();
            while (true)
            {
                if (!_email.Contains("@") || !_email.Contains("."))
                {
                    Console.WriteLine("Неправильно введен Email");
                    Console.WriteLine("Повторите попытку");
                    _email = Console.ReadLine();


                }
                
                
                    break;
                
                
            }
            Console.Clear();
            // Console.ReadLine();
            Console.WriteLine("Введите номер телефона");
            _phone = Console.ReadLine();

           


            
             


            
        }
        public void Code()
            { Console.WriteLine("Введите код");
            _code = Console.ReadLine();

            while (true)
            {

               
                
                if (_code == "4444")
                {
                    Console.WriteLine("Вы зарегистрировались успешно");
                    break;
                }
                else
                {
                    Console.WriteLine("Код не совпадает. Введите его еще раз");
                    _code = Console.ReadLine();

                }
            }
            }
           

       
    }
}

    




