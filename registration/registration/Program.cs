using System;

namespace registration
{
    class Program
    {
        static void Main(string[] args)
        {



            {
                Console.WriteLine("QEYDIYYAT");
                Console.WriteLine("---------------------");
                user u = new user();
                Console.WriteLine("ISTIFADECI ADI");
                u.Username = Console.ReadLine();
                Console.WriteLine("SIFRE");
                u.Password = Console.ReadLine();
              
                
              
            
                
               
                Console.WriteLine("---------------------");
                int count = 0;
                string user_enter;
                string pass_enter;


                while(true)
                {
                    Console.WriteLine(" HESABA DAXIL OLUN:");
                    Console.WriteLine("---------------------");
                    Console.WriteLine(" MOVCUD ISTIFADECI ADI:");
                    user_enter = Console.ReadLine();
                    Console.WriteLine("MOVCUD SIFRE:");
                    pass_enter = Console.ReadLine();
                    Console.WriteLine("---------------------");

                    if (u.Username == user_enter && u.Password == pass_enter)
                    {
                        Console.WriteLine("SISTEME GIRIS ETDINIZ");
                        break;
                    }
                    if (u.Username != user_enter || u.Password != pass_enter)
                    {
                        
                        count++;
                        if (count == 3)
                        {
                            Console.WriteLine("HESABINIZ BLOKLANDI");
                            break;
                        }
                        Console.WriteLine("SIFRE VE YA AD YANLISDIR YENIDEN YOXLAYIN");
                    }

                }














            }
        }
    }
}
