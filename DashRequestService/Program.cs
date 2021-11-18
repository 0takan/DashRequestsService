using DashRequestService.Clients;
using DashRequestService.Clients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashRequestService
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");

            var service = new DashService();

            IEnumerable<DashTransaction> transactions = new List<DashTransaction>();
            //var address = service.GetNewAddress();
            //Console.WriteLine(address);

            //var tran = service.SendToAddress("Xw9SmqSRBBWJknYFsDjEubeH6Ck9UJN3zG", 0.01);

            var alltransaction = service.ListTransactions();

        }
    }
}
