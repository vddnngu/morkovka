using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morkovka
{

    abstract class Link
    {
        string Text;
        public abstract bool isQuestion();
        public string getText()
        {
            return Text;
        }
    }
    class Question : Link
    {
        bool isQuest;
        Dictionary<String, Link> map;
        public override bool isQuestion()
        {
            return isQuest;
        }
        public Link getNext(String answer)
        {
            return map[answer];
        }
    }
}
