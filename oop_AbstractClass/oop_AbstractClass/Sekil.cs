using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_AbstractClass
{
    internal abstract class Sekil
    {
        public abstract void alanHesapla(); //gövdesi yok. Abstract olduğu için çocuklarının alanHesapla() özelliği taşıdığını garanti ediyor
        //bir sınıfın içerisinde çocuk sınıflar için ortak bir kod bloğu sunulamıyorsa bu metotlar çocuk sınıfların gövdelerini tamamlamaları adına abstract olarak işaretlenir
        //bir sınıfın içerisinde en az 1 tane abstart öge var ise sınıfın da başına abstract yazılmalıdır
        //abstract bir classtan constructor ile nesne türetilmez bu sınıfların var olma amacı çocuklarına kalıtım verir
        //çocuklarının sahip oldukları özelliklere teminat vermek setifikasağlamaktır
    }

    class Kare : Sekil
    {
        public override void alanHesapla()
        {
            Console.WriteLine("alan a*a ile hesaplandı");
        }
    }

    sealed class KalıtımaKapalıClass
    {
        //kalıtıma kapalı sınıftan nesne üretilebilir ama kalıtım yapılmaz
    }
}
