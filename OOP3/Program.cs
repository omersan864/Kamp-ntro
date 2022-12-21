using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        private static object list;

        //interface(ICreditManager) onu implemente(PersonalCreditManager) eden classın referans numarasını tutabilir 
        public static void Main(string[] args)
        {
            ICreditManager personalCreditManager=new PersonalCreditManager(); // interface de referans numarası tutabilir 
            ICreditManager vehicleCreditManager=new VehicleCreditManager();
            HousCreditManager housCreditManager=new HousCreditManager();

            ILoggerService databaseloggerservice = new DatabaseLoggerService();
            ILoggerService fileloggerservice= new FileLoggerService();
          
            ApplicationManager applicationManager =new ApplicationManager();
            applicationManager.To_Apply(personalCreditManager,databaseloggerservice); // Bu kısıma dikkat et 

            List<ICreditManager> credits = new List<ICreditManager>() { personalCreditManager,housCreditManager};

            applicationManager.CreditPreliminaries(credits);

        }
    }
}