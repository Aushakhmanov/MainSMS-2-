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



            //while (true)
            //{



            //    if (_FirstPassword != _SecondPassword)
            //    {

            //        Console.WriteLine("Пароли не совпадают");
            //        Console.WriteLine("Введите пароль заново");
            //        _FirstPassword = Console.ReadLine();
            //        Console.WriteLine("Подтвердите пароль");
            //        _SecondPassword = Console.ReadLine();
            //        Console.Clear();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Все прошло успешно");
            //        break;
            //    }
            //}

             _FirstPassword = "";
            Console.WriteLine("Введите пароль");
            
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {

                        //_FirstPassword = Console.ReadLine();

                        //_SecondPassword = Console.ReadLine();

                        _FirstPassword += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && _FirstPassword.Length > 0)
                        {
                            _FirstPassword = _FirstPassword.Substring(0, (_FirstPassword.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }

                    }
                } while (true);
                 _SecondPassword = "";
                Console.WriteLine("");
                Console.WriteLine("Подтвердите пароль");
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {

                        

                        _SecondPassword += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && _SecondPassword.Length > 0)
                        {
                            _SecondPassword = _SecondPassword.Substring(0, (_SecondPassword.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                if (_FirstPassword != _SecondPassword)
                {
                    Console.WriteLine("Пароли не совпадают");
                    Console.WriteLine("Введите пароль заново");
                    do
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        // Backspace Should Not Work
                        if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                        {

                            //_FirstPassword = Console.ReadLine();

                            //_SecondPassword = Console.ReadLine();

                            _FirstPassword += key.KeyChar;
                            Console.Write("*");
                        }
                        else
                        {
                            if (key.Key == ConsoleKey.Backspace && _FirstPassword.Length > 0)
                            {
                                _FirstPassword = _FirstPassword.Substring(0, (_FirstPassword.Length - 1));
                                Console.Write("\b \b");
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                break;
                            }

                        }
                    } while (true);


                    Console.WriteLine("Подтвердите пароль");
                    do
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        // Backspace Should Not Work
                        if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                        {



                            _SecondPassword += key.KeyChar;
                            Console.Write("*");
                        }
                        else
                        {
                            if (key.Key == ConsoleKey.Backspace && _SecondPassword.Length > 0)
                            {
                                _SecondPassword = _SecondPassword.Substring(0, (_SecondPassword.Length - 1));
                                Console.Write("\b \b");
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                    } while (true);
                }
                else
                {
                    //Console.WriteLine("");
                    Console.WriteLine("Все прошло успешно");
                    break;
                }

            } while (true);




            //while (true)
            //{

            //    if (_FirstPassword != _SecondPassword)
            //    {

            //        Console.WriteLine("Пароли не совпадают");
            //        Console.WriteLine("Введите пароль заново");
            //        do
            //        {
            //            ConsoleKeyInfo key = Console.ReadKey(true);
            //            // Backspace Should Not Work
            //            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            //            {

            //                //_FirstPassword = Console.ReadLine();

            //                //_SecondPassword = Console.ReadLine();

            //                _FirstPassword += key.KeyChar;
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                if (key.Key == ConsoleKey.Backspace && _FirstPassword.Length > 0)
            //                {
            //                    _FirstPassword = _FirstPassword.Substring(0, (_FirstPassword.Length - 1));
            //                    Console.Write("\b \b");
            //                }
            //                else if (key.Key == ConsoleKey.Enter)
            //                {
            //                    break;
            //                }

            //            }
            //        } while (true);


            //        Console.WriteLine("Подтвердите пароль");
            //        do
            //        {
            //            ConsoleKeyInfo key = Console.ReadKey(true);
            //            // Backspace Should Not Work
            //            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            //            {



            //                _SecondPassword += key.KeyChar;
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                if (key.Key == ConsoleKey.Backspace && _SecondPassword.Length > 0)
            //                {
            //                    _SecondPassword = _SecondPassword.Substring(0, (_SecondPassword.Length - 1));
            //                    Console.Write("\b \b");
            //                }
            //                else if (key.Key == ConsoleKey.Enter)
            //                {
            //                    break;
            //                }
            //            }
            //        } while (true);

            //        Console.Clear();
            //    }
            //    else
            //    {
            //        //Console.WriteLine("");
            //        Console.WriteLine("Все прошло успешно");
            //        break;
            //    }
            //}





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
                else
                {


                    break;
                }
                
                
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

    




