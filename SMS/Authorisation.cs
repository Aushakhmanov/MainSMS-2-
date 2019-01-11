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
         string _password;
        string _email;
        char _phone;
        string _code;
        public string GetLogin()
        {
            return _login;
        }
        public void SetLogin(string login)
        {
            _login = login;
        }
        public string GetPassword()
        {
            return _password;
        }
        public void SetPassword(string password)
        {
            _password = password;
        }
        public string GetEmail()
        {
            return _email;
        }
        public void SetEmail(string email)
        {
            _email = email;
        }
        public char GetPhone()
        {
            return _phone;
        }
        public void SetPhone(char phone)
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
            Console.WriteLine("Введите логин");
            _login = Console.ReadLine();
            Console.Write("Введите пароль");
            
            
            _password = Console.ReadLine();
            Console.Write("Подтвердите пароль");
            _password = Console.ReadLine();

            Console.WriteLine("Введите Email");
            _email = Console.ReadLine();
            Console.WriteLine("Введите номер телефона");
            _phone = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите код");
            if (_code=="4455")
            {
                Console.WriteLine("Вы зарегистрировались успешно");
            }
            Console.ReadLine();


            



            
        }

       
    }
}

    




