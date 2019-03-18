using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBase
{
    public class PII : DictionaryBase
    {
        public PII()
        {

        }

        public void Add(int id, string name)
        {
            base.InnerHashtable.Add(id, name);
        }
    }
}
