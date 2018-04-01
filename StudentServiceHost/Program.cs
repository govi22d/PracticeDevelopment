using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost studentServiceHost = null;

            Uri httpBaseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/WcfStudentService/StudentService/");
            studentServiceHost = new ServiceHost(typeof(WcfStudentService.StudentService), httpBaseAddress);
            studentServiceHost.AddServiceEndpoint(typeof(WcfStudentService.IStudentService),
                                                        new WSHttpBinding(), "");
            ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
            serviceBehavior.HttpGetEnabled = true;
            studentServiceHost.Description.Behaviors.Add(serviceBehavior);

            studentServiceHost.Open();
            Console.WriteLine("Student service is live now at: {0}", httpBaseAddress);



            ////Address
            //Uri calculatorBaseAddress = new Uri("http://localhost:8732/Design_Time_Addresses/WcfService/SimpleCalculator/");

            ////Host instance
            //ServiceHost calculatorServiceHost = new ServiceHost(typeof(WcfService.SimpleCalculator), calculatorBaseAddress);

            ////Add Endpoints
            //calculatorServiceHost.AddServiceEndpoint(typeof(WcfService.ISimpleCalculator),
            //                                            new WSHttpBinding(), "");
            ////Add behaviour
            //calculatorServiceHost.Description.Behaviors.Add(new ServiceMetadataBehavior() { HttpGetEnabled = true });

            //calculatorServiceHost.Open();
            //Console.WriteLine("Calculator Service is live now at: {0}", calculatorBaseAddress);

            Console.ReadKey();



        }
    }
}
