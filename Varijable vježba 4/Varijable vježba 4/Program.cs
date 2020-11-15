using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_vježba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string upis;
                Console.Write("Unesite rečenicu: ");
                upis = Console.ReadLine();
                string sVelika = upis.ToUpper();
                string sMala = upis.ToLower();
                string sPrvaTri = upis.Substring(0, 3);
                string sZadnjihPet = upis.Substring(upis.Length - 5);
                string s8_11 = upis.Substring(7, 4);
                
                Console.WriteLine(sVelika);
                Console.WriteLine(sMala);
                Console.WriteLine(sPrvaTri);
                Console.WriteLine(sZadnjihPet);
                Console.WriteLine(s8_11);
                
                
                
                Console.ReadKey();
            }
        }
    }
}
