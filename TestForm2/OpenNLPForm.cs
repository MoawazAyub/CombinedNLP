using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

using OpenNLP.Tools.Chunker;
using OpenNLP.Tools.Coreference;
using OpenNLP.Tools.Graphs;
using OpenNLP.Tools.Parser;
using OpenNLP.Tools.PosTagger;
using OpenNLP.Tools.SentenceDetect;
using OpenNLP.Tools.Tokenize;
using OpenNLP.Tools.Trees;
using OpenNLP.Tools.Lang.English;
using OpenNLP.Tools.NameFind;

namespace TestForm2
{
    public partial class OpenNLPForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public OpenNLPForm()
        {
            InitializeComponent();
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CrossSign_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CrossSign_MouseHover(object sender, EventArgs e)
        {
            CrossSign.BackgroundImage = TestForm2.Properties.Resources.cross3;
            CrossSign.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void CrossSign_MouseLeave(object sender, EventArgs e)
        {
            CrossSign.BackgroundImage = TestForm2.Properties.Resources.cross4;
            CrossSign.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void OpenNLPForm_Load(object sender, EventArgs e)
        {
            OutputField.ScrollBars = ScrollBars.Vertical;
            ToolField.Text = "";
            InputField.Text = "";

            ToolField.Items.Add("Detect Sentence");
            ToolField.Items.Add("Tokenizer");
            ToolField.Items.Add("English Tokenizer");
            ToolField.Items.Add("Parts of Speech Tagger");
            ToolField.Items.Add("Chunker");
            ToolField.Items.Add("Named Entity Recognition");
            ToolField.Items.Add("Sentence Structure");
        }

        private void GenerateOutputButton_Click(object sender, EventArgs e)
        {
            //var test = MySentenceDetector("Mr. & Mrs. Smith is a 2005 American romantic comedy action film. The film stars Brad Pitt and Angelina Jolie as a bored upper-middle class married couple. They are surprised to learn that they are both assassins hired by competing agencies to kill each other.");
            //MessageBox.Show(test.Count().ToString());

            // var text = MyChunker("i am good");
            //MessageBox.Show(text.Count.ToString());
            //var ss = MySentenceStructure("i am gios");//MyNer("Mr. & Mrs. Smith is a 2005 American romantic comedy action film.");
            // MessageBox.Show(ss.ToString());

            string myInput = InputField.Text;

            if (ToolField.Text == "")
            {
                MessageBox.Show("Please Select Tool");
                return;
            }
            else if (InputField.Text == "")
            {
                MessageBox.Show("Input FIeld is empty");
                return;
            }

            if(ToolField.Text == "Detect Sentence")
            {
                OutputField.Text = "Please Wait";
                           
                var text = MySentenceDetector(myInput);
                GenerateOutputButton.Enabled = false;
                OutputField.Text = "";
                for (int i = 0 ; i < text.Count() ; i++)
                {
                    OutputField.Text = OutputField.Text + "Sentence # " + (i + 1).ToString() +" : " + text[i] + Environment.NewLine; 
                }
                GenerateOutputButton.Enabled = true;
            }
            else if(ToolField.Text == "Tokenizer")
            {
                OutputField.Text = "Please Wait";
                
                var text = MyTokenizer(myInput);
                GenerateOutputButton.Enabled = false;
                OutputField.Text = "";
                for (int i = 0; i < text.Count(); i++)
                {
                    OutputField.Text = OutputField.Text + "Token # " + (i + 1).ToString() + " : " + text[i] + Environment.NewLine;
                }
                GenerateOutputButton.Enabled = true;
            }
            else if (ToolField.Text == "English Tokenizer")
            {
                OutputField.Text = "Please Wait";
              
                var text = MyEnglishTokenizer(myInput);
                GenerateOutputButton.Enabled = false;
                OutputField.Text = "";
                for (int i = 0; i < text.Count(); i++)
                {
                    OutputField.Text = OutputField.Text + "Token # " + (i + 1).ToString() + " : " + text[i] + Environment.NewLine;
                }
                GenerateOutputButton.Enabled = true;
            }
            else if (ToolField.Text == "Parts of Speech Tagger")
            {
                OutputField.Text = "Please Wait";
              
                var text = MyPosTagger(myInput);
                GenerateOutputButton.Enabled = false;
                OutputField.Text = "";
                for (int i = 0; i < text.Count(); i++)
                {
                    OutputField.Text = OutputField.Text + "POS # " + (i + 1).ToString() + " : " + text[i] + Environment.NewLine;
                }
                GenerateOutputButton.Enabled = true;
            }
            else if (ToolField.Text == "Chunker")
            {
                OutputField.Text = "Please Wait";
                
                var text = MyChunker(myInput);
                GenerateOutputButton.Enabled = false;
                OutputField.Text = "";
                for (int i = 0; i < text.Count(); i++)
                {
                    OutputField.Text = OutputField.Text + "Chunk # " + (i + 1).ToString() + " : " + text[i] + Environment.NewLine;
                }
                GenerateOutputButton.Enabled = true;
            }
            else if (ToolField.Text == "Named Entity Recognition")
            {
                OutputField.Text = "Please Wait";
         
                var text = MyNer(myInput);
                GenerateOutputButton.Enabled = false;
                
                    OutputField.Text = "Name Entity : # " + text;
                
                GenerateOutputButton.Enabled = true;
            }
            else if (ToolField.Text == "Sentence Structure")
            {
                OutputField.Text = "Please Wait";
              
                var text = MySentenceStructure(myInput);
                GenerateOutputButton.Enabled = false;

                OutputField.Text = "Sentence Structure : # " + text;

                GenerateOutputButton.Enabled = true;
            }


        }

        //---------------------------------------------------OpenLP Methods

        private string[] MySentenceDetector(string paragraph)
        {
            var modelPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Models\EnglishSD.nbin";
            EnglishMaximumEntropySentenceDetector EMESD = new EnglishMaximumEntropySentenceDetector(modelPath);
            var sentenceDetector = EMESD;
            //var sentenceDetector = EnglishMaximumEntropySentenceDetector(modelPath);
            var sentences = sentenceDetector.SentenceDetect(paragraph);

            return sentences;
        }

        private string[] MyTokenizer(string sentence)
        {
            var modelPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Models\EnglishTok.nbin";
            
            var tokenizer = new EnglishMaximumEntropyTokenizer(modelPath);
            var tokens = tokenizer.Tokenize(sentence);

            return tokens;
        }

        private string[] MyEnglishTokenizer(string sentence)
        {
            var tokenizer = new EnglishRuleBasedTokenizer(true);
            
            var tokens = tokenizer.Tokenize(sentence);

            return tokens;
        }

        private string[] MyPosTagger(string str)
        {
            var modelPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Models\EnglishPOS.nbin";
            var tagDictDir = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Models\Parser\tagdict";
            //var posTagger = EnglishMaximumEntropyPosTagger(modelPath, tagDictDir);
            var posTagger = new EnglishMaximumEntropyPosTagger(modelPath, tagDictDir);
            var tokens = MyTokenizer(str);
            var pos = posTagger.Tag(tokens);
            return pos;

        }

        private List<SentenceChunk> MyChunker(string str)
        {
            var modelPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Models\EnglishChunk.nbin";
            var chunker = new EnglishTreebankChunker(modelPath);
            var tokens = MyTokenizer(str);
            var pos = MyPosTagger(str);

            var chunks = chunker.GetChunks(tokens, pos);
            return chunks;
        }


        private string MyCorefferencer(string str)
        {

            var modelPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Models\Coref";
            var coreferenceFinder = new TreebankLinker(modelPath);
            var sentences = MySentenceDetector(str);//["Mr. & Mrs. Smith is a 2005 American romantic comedy action film.",
                                                    //"The film stars Brad Pitt and Angelina Jolie as a bored upper-middle class married couple.",
                                                    //"They are surprised to learn that they are both assassins hired by competing agencies to kill each other."];
            var coref = coreferenceFinder.GetCoreferenceParse(sentences);

            return coref;
        }

        private string MyNer(string sentence)
        {
            var modelPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Models\NameFind\";
            var nameFinder = new EnglishNameFinder(modelPath);

            // specify which types of entities you want to detect
            string[] models = new string[7];//MySentenceDetector("date. location. money. organization. percentage. person. time");
            models[0] = "date";
            models[1] = "location";
            models[2] = "money";
            models[3] = "organization";
            models[4] = "percentage";
            models[5] = "person";
            models[6] = "time";

            var ner = nameFinder.GetNames(models, sentence);
            return ner;
        }


        private string MySentenceStructure(string sentence)
        {
            var modelPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Models\";

            var parser = new EnglishTreebankParser(modelPath);
            var parse = parser.DoParse(sentence);
            var result = parse.Show();
            return result;
        }

        private void Heading_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void InputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = System.IO.File.ReadAllText(file);
                    size = text.Length;

                    if (size > 0)
                    {
                        InputField.Text = text;
                    }
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Error occured while reading file");
                }
            }
        }

        private void SaveToFile_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "")
            {
                MessageBox.Show("Output field is empty");
                return;
            }



            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                MessageBox.Show("Please Wait while data gets copied into the file");
                try
                {
                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter(@file);

                    //Write a line of text

                    sw.WriteLine(OutputField.Text.ToString());


                    //Close the file
                    sw.Close();
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Error occured while Saving to file");
                }

                MessageBox.Show("Successfully Copied File");
            }
        }
        //---------------------------------------------------OpenLP Methods END
    }
}
