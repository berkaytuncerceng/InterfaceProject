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
            
            BasvuruManager basvuruManager = new BasvuruManager();
            
            List<IKrediManager> krediler = new List<IKrediManager>() {konutKrediManager, ihtiyacKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            Console.ReadKey();
        }
    }
}
