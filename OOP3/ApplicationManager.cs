using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager // başvuru yap sayfası 
    {
        //Method injection To_Apply methodunun hangi krediyi kullanacağını ve hangi loglayıcı olacağını enjekte ediyoruz 
        public void To_Apply(ICreditManager creditManager,ILoggerService loggerService)// başvuru yap 
        {
            // başvuran bilgilerini değerlendirme  
            creditManager.calculate();
            loggerService.Log();
        }
        //aşağıda birden fazla kredinin hesabının yapılmasının istenmesi sebebi ile parantez içine bir Icredit listesi tanımlanır 
        public void CreditPreliminaries(List<ICreditManager> credits)// kredi ön bilgilendirmesi 
        {
            foreach (var credit in credits)
            {
                credit.calculate();        
            }
        }
    }
}
