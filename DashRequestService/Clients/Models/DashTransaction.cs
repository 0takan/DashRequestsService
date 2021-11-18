using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashRequestService.Clients.Models
{
    public class DashTransaction
    {
        //public class Rootobject
        //{
        //    public Result[] result { get; set; }
        //    public object error { get; set; }
        //    public int id { get; set; }
        //}

        //public class Result
        //{
        public string address { get; set; }
        public string category { get; set; }
        public float amount { get; set; }
        public string label { get; set; }
        public int vout { get; set; }
        public int confirmations { get; set; }
        public bool instantlock { get; set; }
        public bool instantlock_internal { get; set; }
        public bool chainlock { get; set; }
        public string blockhash { get; set; }
        public int blockindex { get; set; }
        public int blocktime { get; set; }
        public string txid { get; set; }
        public object[] walletconflicts { get; set; }
        public int time { get; set; }
        public int timereceived { get; set; }
        public float fee { get; set; }
        public bool abandoned { get; set; }
    }
}

//}
