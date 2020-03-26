using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kawal_Corona
{
    public class Covid19
    {
        public int OBJECTID { get; set; }

        public String Country_Region { get; set; }

        public long Last_Update { get; set; }

        public float Lat { get; set; }

        public float Long_ { get; set; }

        public int Confirmed { get; set; }

        public int Deaths { get; set; }

        public int Recovered { get; set; }

        public int Active { get; set; }
    }
}