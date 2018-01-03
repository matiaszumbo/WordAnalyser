using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WordAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btn_start_Click(object sender, EventArgs e)
        {

           

            // string input = @"Take this paragraph of text and return an alphabetized list of ALL unique words.  A unique word is any form of a word often communicated with essentially the same meaning. For example, fish and fishes could be defined as a unique word by using their stem fish. For each unique word found in this entire paragraph, determine the how many times the word appears in total. Also, provide an analysis of what unique sentence index position or positions the word is found. The following words should not be included in your analysis or result set: a, the, and, of, in, be, also and as.  Your final result MUST be displayed in a readable console output in the same format as the JSON sample object shown below.";

            string[] exclude_words = { "a", "\"a\"", "the", "\"the\"", "and", "\"and\"", "of", "\"of\"", "in", "\"in\"", "be", "\"be\"", "also", "\"also\"", "as", "\"as\"" };

            Paragraph parrafo = new Paragraph(txt_parrafo.Text, exclude_words);


            List<Result> final_result = new List<Result>();

            foreach (var sentence in parrafo._sentences)
            {
                foreach (var word in sentence.Words)
                {
                    Result result = parrafo.ProcessWord(word);

                    if (final_result.Any(x => x.text == result.text)) //check exists
                        continue;

                    final_result.Add(result);
                     
                }
            }

            //Print RESULT
            foreach (var item in final_result.OrderBy(x => x.text))
            {
                string word = "word: " + item.text + Environment.NewLine;
                string repeat = "total-occurrences: " + item.repeat + Environment.NewLine;

                string indexes = "";
                int i = 1;
                foreach (var index in item.index)
                {
                    if (i == item.index.Count)
                        indexes = indexes + index.ToString();
                    else
                        indexes = indexes + index.ToString() + ",";
                    i++;
                }

                indexes = "sentence-indexes: " + "[" + indexes + "]" + Environment.NewLine;

                txt_result.Text = txt_result.Text + word + repeat + indexes + Environment.NewLine;

            }

        }

    }
}

      
