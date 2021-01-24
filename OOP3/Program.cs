using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
           ihtiyacKrediManager ihtiyacKrediManager = new ihtiyacKrediManager();
           TasitKrediManager tasitKrediManager = new TasitKrediManager();
           KonutKrediManager konutKrediManager = new KonutKrediManager();


            /* IKrediManager ihtiyacKrediManager = new ihtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla(); */

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



            Console.ReadLine();
        } 
    }
}
