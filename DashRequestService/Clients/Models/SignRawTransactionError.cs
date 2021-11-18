using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashRequestService.Clients.Models
{
    public class SignRawTransactionError
    {
        public string Txid { get; set; }
        public int Vout { get; set; }
        public string ScriptSig { get; set; }
        public long Sequence { get; set; }
        public string Error { get; set; }
    }
}
