using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morkovka
{
    class TestProcessing
    {
        Link currentLink;
        public TestProcessing (Link root)
        {
            currentLink = root;
        }
        public List<String> getAnswers()
        {
            if (currentLink.GetType() == typeof(Question))
                return (currentLink as Question).getAnswers();
            else
                return null;
        }
        public string getCurQuestion()
        {
            if (currentLink.GetType() == typeof(Question))
                return (currentLink as Question).getText();
            else
                return null;
        }
        public bool goNext(String answer)
        {
            currentLink = (currentLink as Question).getNext(answer);
            return currentLink.isQuestion();
        }
    }
}
