using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tikhe_POS
{
    class Transaction
    {
        public string IDOrder { get; set; }
        public string Application { get; set; }
		public string Service { get; set; }
        public string Subservice { get; set; }
        public string Cabang { get; set; }
        public string Customer { get; set; }
		public string Tanggal { get; set; }
		public string Total { get; set; }
	}
}
