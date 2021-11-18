using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashRequestService.Clients.Models
{
    public class SignRawTransactionResponse
    {
        public string Hex { get; set; }
        public bool Complete { get; set; }
    }
}
