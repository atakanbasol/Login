using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı giriş sayfası uygulaması.Kullacının 2 kere yanlış girme hakkı var 3. de döngüyü bitirip tekrar kullanıcı girişi istemeyecek.
            string username = "Atakan";
            string password = "Atakan.315!";

            int i = 3;

            while (i > 0) { 
            
                Console.Write("Kullanıcı adını girin=");
                string loginUsername= Console.ReadLine();

                Console.Write("Şifrenizi girin=");
                string loginPassword = Console.ReadLine();

                if (loginUsername == username && loginPassword == password)
                {
                    Console.WriteLine("Kullanıcı girişi yapılıyor...");
                    break;
                }
                else if (loginUsername == username && loginPassword != password)
                {
                    Console.WriteLine("Şifreniz yanlış.");
                    i--;
                }
                else if (loginUsername != username && loginPassword == password)
                {
                    Console.WriteLine("Kullanıcı adınız yanlış.");
                    i--;
                }
                else 
                {
                    Console.WriteLine("Kullanıcı adınız ve şifreniz yanlış.");
                    i--;
                }
            }
            Console.ReadLine();
        }
    }
}
