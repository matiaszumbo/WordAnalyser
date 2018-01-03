using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordAnalyzer
{
    public class Word
    {
        private string _text;
        private int _index;

        public Word(string text, int index)
        {
            _text = text;
            _index = index;
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
         
        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
         
    }
}
