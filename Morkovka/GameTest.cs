using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morkovka
{
    class GameTest
    {
        public TestProcessing myTP;
        public GameTest()
        {
            Answer a1, a2, a3;
            Question q1, q2, q3, q4, q5;
            List<String> str = new List<String>();
            List<Link> lnk = new List<Link>();

            a1 = new Answer("Результат 1");
            a2 = new Answer("Результат 2");
            a3 = new Answer("Результат 3");

            str.Add("Ответ на вопрос 5");
            str.Add("Ответ на вопрос 5.1");
            lnk.Add(a1);
            lnk.Add(a2);
            q5 = new Question("Вопрос 5", str, lnk);

            str.Clear();
            lnk.Clear();

            str.Add("Ответ на вопрос 4");
            str.Add("Ответ на вопрос 4.1");
            lnk.Add(a3);
            lnk.Add(a2);
            q4 = new Question("Вопрос 4", str, lnk);

            str.Clear();
            lnk.Clear();

            str.Add("Ответ на вопрос 3");
            str.Add("Ответ на вопрос 3.1");
            lnk.Add(q4);
            lnk.Add(q5);
            q3 = new Question("Вопрос 3", str, lnk);

            str.Clear();
            lnk.Clear();

            str.Add("Ответ на вопрос 2");
            str.Add("Ответ на вопрос 2.1");
            lnk.Add(q4);
            lnk.Add(q3);
            q2 = new Question("Вопрос 2", str, lnk);

            str.Clear();
            lnk.Clear();

            str.Add("Ответ на вопрос 1");
            str.Add("Ответ на вопрос 1.1");
            lnk.Add(q2);
            lnk.Add(q3);
            q1 = new Question("Вопрос 1", str, lnk);

            str.Clear();
            lnk.Clear();

            myTP = new TestProcessing(q1);
        }

          
    }
}
