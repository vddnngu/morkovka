using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morkovka
{
    class Testing
    {
        public Testing()
        {
            Answer a1, a2, a3;
            Question q1, q2;
            List<String> str = new List<String>();
            List<Link> lnk = new List<Link>();


            a1 = new Answer("A1");
            a2 = new Answer("A2");
            a3 = new Answer("A3");


            str.Add("a1");
            str.Add("a2");
            lnk.Add(a1);
            lnk.Add(a2);
            q1 = new Question("q1", str, lnk);


            str.Clear();
            lnk.Clear();


            str.Add("a3");
            str.Add("q1");
            lnk.Add(a3);
            lnk.Add(q1);
            q2 = new Question("q2", str, lnk);


            TestProcessing test = new TestProcessing(q2);
            str = test.getAnswers();
            test.goNext("q1");
            str = test.getAnswers();
            test.goNext("a1");
            str = test.getAnswers();
        }
    }
}
