using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DicBase
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class PII : DictionaryBase
    {
        public PII()
        {
            string filePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

            DateTime dt = DateTime.Now;
            DateTime dtEnd = dt.AddSeconds(1);
            using (StreamWriter streamWriter = new StreamWriter(filePath, true))
            {
                while (DateTime.Now < dtEnd)
                {
                    streamWriter.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmssfff") + "\n");
                }
            }
        }

        public void Add(int id, string name)
        {
            base.InnerHashtable.Add(id, name);
        }

        public string Item(int id)
        {
            return base.InnerHashtable[id].ToString();
        }

        public void Remove(int id)
        {
            base.InnerHashtable.Remove(id);
        }

        
    }
}
