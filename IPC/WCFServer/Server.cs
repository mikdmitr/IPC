using System.ServiceModel;
using WCFServer;

namespace WCFServerHost
{
    class Server
    {
        static void Main(string[] args)
        {
            // Создание URI для сервиса
            Uri baseAddress = new Uri("http://localhost:8080/CalculatorService");

            // Создание экземпляра хоста
            //using (ServiceHost host = new ServiceHost(typeof(Calculator), baseAddress))
            //{
            //    // Настройка привязки (binding)
            //    host.AddServiceEndpoint(typeof(ICalculator), new BasicHttpBinding(), "");

            //    // Открытие хоста
            //    host.Open();
            //    Console.WriteLine("Сервис запущен. Нажмите Enter для завершения работы...");
            //    Console.ReadLine();
            //}
        }
    }
}
