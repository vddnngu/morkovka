﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morkovka
{

    class Link
    {
        protected string text;
        protected bool isQuest;
        public bool isQuestion()
        {
            return isQuest;
        }
        public string getText()
        {
            return text;
        }
    }
    class Question : Link
    {

        List<String>    answers;
        List<Link>      links;
        Dictionary<String, int> map;
        public Question ()
        {
            isQuest = true;
        }
        public Question (String _text, List<String> _answers, List<Link> _links)
        {
            int i = 0;
            foreach (var aIt in _answers)
            {
                answers.Add(aIt);
                map[aIt] = i++;
            }
            foreach (var lIt in _links) links.Add(lIt);
            text = _text;
            isQuest = true;
            
        }
        public Link getNext(String answer)
        {
            return links[map[answer]];
        }
        public List<String> getAnswers ()
        {
            return answers;
        }
    }
    class Answer : Link
    {

        public Answer()
        {
            isQuest = false;
        }
        public Answer(String _text)
        {
            isQuest = false;
            text = _text;
        }
    }
}