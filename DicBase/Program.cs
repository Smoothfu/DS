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
           
        }

        static void LogStreamWriter()
        {
            string filePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

            DateTime dt = DateTime.Now;
            DateTime endDt = dt.AddSeconds(1);
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                while (DateTime.Now < endDt)
                {
                    streamWriter.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmssffff") + Guid.NewGuid());
                }
            }
        }
        public void Add(string id, string name)
        {
            base.InnerHashtable.Add(id, name);
        }

        public string Item(string id)
        {
            return base.InnerHashtable[id].ToString();
        }

        public void Remove(int id)
        {
            base.InnerHashtable.Remove(id);
        }

       public void KeyValuePairExample()
        {
            KeyValuePair<Guid, string> kvp = new KeyValuePair<Guid, string>(Guid.NewGuid(),"Fred");
            Console.WriteLine($"Key:{kvp.Key}");
            Console.WriteLine($"Value:{kvp.Value}");            
        }
    }
}
