using DashRequestService.Clients.Models;
using DashRequestService.Models;
using System.Collections.Generic;
using System.Linq;

namespace DashRequestService.Clients
{
    public class DashService
    {
        private RestRequestClient _client;

        public DashService()
        {
            _client = new RestRequestClient();
        }

        public string GetNewAddress()
        {
            var resp = _client.MakeRequest<string>(RestMethods.getnewaddress);
            return resp;
        }

        public string SendToAddress(string address, double amount)
            =>_client.MakeRequest<string>(RestMethods.sendtoaddress, address, amount);
        
        public List<DashTransaction> ListTransactions()
        {
            var resp = _client.MakeRequest<List<DashTransaction>>(RestMethods.listtransactions);
            return resp;
        }
    }
}
