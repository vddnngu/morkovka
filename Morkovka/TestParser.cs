using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morkovka
{
    enum typeEntity
    {
        text,
        quwestion,
        answer
    }
    class RecEntity
    {
        public int num;
        typeEntity type;
        string text;
        List<int> numbers;
    }
    class TestParser
    {
        string path;
        FileStream file;
        Dictionary<int, RecEntity> a;
        public TestParser(string _path)
        {
            path = _path;
            file = new FileStream(path, FileMode.Open);
        }

        public void Parse()
        {
            StreamReader fin = new StreamReader(file);
            string tmp="";
            while (tmp != "END.")
            {
                tmp = fin.ReadLine();
                string[] strs = tmp.Split('|');

            }
        }
        void ParseLine(string num, string type, string data)
        {

        }
    }
}
