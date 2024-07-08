using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            
            List<IKrediManager> krediler = new List<IKrediManager>() {konutKrediManager, ihtiyacKrediManager , tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);
            Console.ReadKey();
        }
    }
}
