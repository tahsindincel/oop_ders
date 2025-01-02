using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Intli
{
    internal interface Isesverebilenler //interfacelerin başına I harfi koyabiliriz
    {
        // interfaceler çocuk sınıflara kalıtım sunmak ve belli ortak özelliklere sahip birçok türü kapsayıcı üst türler, high level türler tanımlamak için kullanılır
        // erişim seviyesi belirtilmez abstract belirtilmez
        // interfacelerin yapıcı metotları aracılığı ile interfaceden nesne türetilmez ancak interfaceden miras alan gövdesi olmayan abstract üyeleri
        // implemente etmiş ve tamamlamış olan insan sınıfı gibi concrete bir sınıftan nesne türetilerek ata nesneye atanabilir. Liskov's substitution prensibi
        // ISesverenler nesne = new IVesverenler YAZILAMAZ ISesverenler nesne = new Insan() YAZILABİLİR
        // abstract classlarda hem gövdeli hem gövdesiz üyeler olabiliyorken interfacelerde gövdeli üye bulunmaz
        // miras alan çocuk sınıflarda interface üyeleri implement edilirken override anahtar kelimesi kullanılmaz
        void sesVer(); // gövdesi ve erişim belirleyicisi olmaz
    }
}
