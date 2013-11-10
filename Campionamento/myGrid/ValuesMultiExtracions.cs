using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGrid
{
    public class ValuesMultiExtracions
    {
        private List<Values> values = new List<Values>();
        public string TableName { get; set; }
        public List<Values> Values { get { return values; } set { values = value; } }
    }
}
