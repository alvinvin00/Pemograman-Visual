using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Rank
{
    public class ValueData<T>
    {
        public int success { get; set; }
        public String message { get; set; }
        public List<T> data { get; set; }
    }
}