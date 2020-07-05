using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using java.util;
using java.io;
using edu.stanford.nlp.pipeline;
using Console = System.Console;
using System.Diagnostics;

namespace TestForm2
{
    public partial class CoreNLPForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        bool LoadingScreenOn = false;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        PleaseWaitForm PWF;
        Thread th;

        //-----------------------------------------java stuff
        String jarRoot;
        java.util.Properties props = new java.util.Properties();
        String curDir;
        edu.stanford.nlp.pipeline.StanfordCoreNLP pipeline;
        string text = "";
        string option = "XML";
        //--------------------------------------

        public CoreNLPForm()
        {
            InitializeComponent();
        }

        private void ToggleLoadingForm()
        {
            if (LoadingScreenOn == false)
            {
                LoadingScreenOn = true;
                PWF = new PleaseWaitForm();
                PWF.Show();
            }
            else if (LoadingScreenOn == true)
            {
                LoadingScreenOn = false;
                PWF.Close();
            }
        }

        private void ShowLoading()
        {
            LoadingScreenOn = true;
            PWF = new PleaseWaitForm();
            PWF.Show();
        }

        private void Cross_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OutputType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CoreNLPForm_Load(object sender, EventArgs e)
        {
            OutputType.Items.Add("XML");
            OutputType.Items.Add("Json");
            OutputType.Items.Add("Conll");
            OutputType.Items.Add("Pretty");
            OutputType.Text = "XML";
            OutputText.ScrollBars = ScrollBars.Both;
            InputText.Text = "";


            //PWF.Show();
            PWF = new PleaseWaitForm();
            PWF.Show();
            this.Visible = false;

            //----------------java
            jarRoot = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\stanford-corenlp-full-2016-10-31";

            props.setProperty("annotators", "tokenize, ssplit, pos, lemma, ner, parse, dcoref");
            props.setProperty("ner.useSUTime", "0");
            curDir = Environment.CurrentDirectory;
            Directory.SetCurrentDirectory(jarRoot);
            pipeline = new StanfordCoreNLP(props);
            Directory.SetCurrentDirectory(curDir);
            this.Visible = true;
            PWF.Close();
            //----------------
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = InputText.Text.ToString();
            option = OutputType.Text.ToString();
            if (text != "")
            {
                PWF = new PleaseWaitForm();
                PWF.Show();
                this.Visible = false;

                var annotation = new Annotation(text);
                pipeline.annotate(annotation);

                using (var stream = new ByteArrayOutputStream())
                {
                    if (option == "Pretty")
                    {
                        pipeline.prettyPrint(annotation, new PrintWriter(stream));
                    }
                    else if (option == "Json")
                    {
                        pipeline.jsonPrint(annotation, new PrintWriter(stream));
                    }
                    else if (option == "XML")
                    {
                        pipeline.xmlPrint(annotation, new PrintWriter(stream));
                    }
                    else if (option == "Conll")
                    {
                        pipeline.conllPrint(annotation, new PrintWriter(stream));
                    }
                    else
                    {
                        pipeline.conllPrint(annotation, new PrintWriter(stream));
                    }

                    OutputText.Text = stream.ToString();
                 
                    stream.close();
                }

                PWF.Close();
                this.Visible = true;
            }
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Cross_MouseHover(object sender, EventArgs e)
        {
            Cross.BackgroundImage = TestForm2.Properties.Resources.cross3;
            Cross.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Cross_MouseLeave(object sender, EventArgs e)
        {
            Cross.BackgroundImage = TestForm2.Properties.Resources.cross4;
            Cross.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void OutputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopBar_Click(object sender, EventArgs e)
        {

        }

        private void Heading_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FileInput_Click(object sender, EventArgs e)
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
                        InputText.Text = text;
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
            if (OutputText.Text == "")
            {
                MessageBox.Show("Output Field is Empty");
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
                    sw.WriteLine(OutputText.Text.ToString());

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
    }
}
