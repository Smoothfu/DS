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
            
            using (StreamReader readerFile = File.OpenText(filePath))
            {
                while(readerFile.Peek()!=-1)
                {
                    string word = readerFile.ReadLine();
                    Console.WriteLine(word);
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
