using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMP.ViewModels
{
    public class VMResponse
    {
        public bool is_success { get; set; }
        public string message { get; set; }
        public object result { get; set; }
    }
}
