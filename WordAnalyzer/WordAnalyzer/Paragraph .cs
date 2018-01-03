
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordAnalyzer
{
    public class Paragraph
    {
        private string _text;
        public List<Sentence> _sentences;
        public Paragraph(string text, string[] exclude_words)
        {
            _text = text;
            _sentences = new List<Sentence>();

            var substrings = _text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();


            int index = 0;
            foreach (var item in substrings)
            {

                Sentence sentence = new Sentence(item, index, exclude_words);

                _sentences.Add(sentence);

                index++;
            }
             
        }

        public Result ProcessWord(Word text)
        {
            int count = 1;

            Result _result = new Result();
            foreach (var sentence in _sentences)
            {

                foreach (var word in sentence.Words)
                {

                    if (word.Text.ToLower() == text.Text.ToLower())
                    {
                        _result.repeat = count++;

                        if (!_result.index.Contains(word.Index))
                            _result.index.Add(word.Index);

                        _result.text = word.Text;
                    }

                }

            }

            return _result;
        }

         
    }

}
