using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        private object urun;

        // naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urun.urununAdi);
            
        }
        public void Ekle2(string urununAdi, string aciklama, double fiyat, int stokAdedi)
        {
         Console.WriteLine("Tebrikler.Sepete eklendi : " + urununAdi);
        }
    }
}
