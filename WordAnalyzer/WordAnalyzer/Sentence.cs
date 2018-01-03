using System;
using System.Collections.Generic;
using System.Data.Entity.Design.PluralizationServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordAnalyzer
{
    public class Sentence
    {
        private string _text;

        private int _index;

        private List<Word> _words;
        public List<Word> Words
        {
            get { return _words; }
            set { _words = value; }
        } 

        private PluralizationService ps = PluralizationService.CreateService(System.Globalization.CultureInfo.GetCultureInfo("en-us"));
         

        public Sentence(string text, int index, string[] exclude_words)
        {
            _text = text;
            _index = index;

            _words = new List<Word>();

            var substrings = _text.Split(new char[] { ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var item in substrings)
            {
                string item_singular = ps.Singularize(item);

                if (exclude_words.Contains(item_singular.ToLower()))
                    continue;

                Word word = new Word(item_singular.ToString(), index);

                _words.Add(word);
            }
        }


    }
}
