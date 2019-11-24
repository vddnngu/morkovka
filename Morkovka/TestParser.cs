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
        public typeEntity type;
        
    }

    class QwestEntity :  RecEntity
    {
        public int numText;
        public List<int> numbersTexts = new List<int>();
        public List<int> numbersAnswers = new List<int>();

    }

    class AnswerEntity : RecEntity
    {
        public int numText;
    }

    class TextEntity : RecEntity
    {
        public string text;
    }
    class TestParser
    {
        string path;
        FileStream file;
        Dictionary<int, RecEntity> entityRecords = new Dictionary<int, RecEntity>();
        public TestParser(string _path)
        {
            path = _path;
            file = new FileStream(path, FileMode.Open);
        }

        public void Parse()
        {
            StreamReader fin = new StreamReader(file);
            string tmp;
            while((tmp = fin.ReadLine())!= "")
            {
                continue;
            }
            while ((tmp = fin.ReadLine()) != "END.")
            {
                string[] strs = tmp.Split('|');
                AddEntity(strs);
            }
            tmp = (entityRecords[(entityRecords[5] as QwestEntity).numText] as TextEntity).text;
        }

        private void AddEntity(string[] strs)
        {
            RecEntity tmp;
            if (strs[1] == "Q")
            {
                tmp = CreateQwest(strs);
            }
            else if (strs[1] == "A")
            {
                tmp = CreateAnswer(strs);
            }
            else if (strs[1] == "T")
            {
                tmp = CreateText(strs);
            }
            else tmp = null;
            entityRecords[Convert.ToInt32(strs[0])] = tmp;        
        }

        private RecEntity CreateText(string[] strs)
        {
            TextEntity res = new TextEntity();
            res.num = Convert.ToInt32(strs[0]);
            res.text = strs[2];
            return res;
        }

        private RecEntity CreateAnswer(string[] strs)
        {
            AnswerEntity res = new AnswerEntity();
            res.num = Convert.ToInt32(strs[0]);
            res.numText = Convert.ToInt32(strs[2]);
            return res;
        }

        private RecEntity CreateQwest(string[] strs)
        {
            QwestEntity res = new QwestEntity();
            res.num = Convert.ToInt32(strs[0]);
            res.numText = Convert.ToInt32(strs[2]);
            int count = Convert.ToInt32(strs[3]);
            for(int i = 0; i < count; i++)
            {
                res.numbersTexts.Add(Convert.ToInt32(strs[2 + i]));
                res.numbersAnswers.Add(Convert.ToInt32(strs[2 + count + i]));
            }
            return res;
        }
    }
}
