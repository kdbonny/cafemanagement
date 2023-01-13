using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
    internal class SalesReport
    {
        int order_id { get; set; }
        string name { get; set; }
        string phone { get; set; }
        string address { get; set; }
        decimal total_amount { get; set; }
        decimal discount { get; set; }
        decimal tax { get; set; }
        decimal received { get; set; }
        decimal due { get; set; }
        DateTime date { get; set; }

    }
}
