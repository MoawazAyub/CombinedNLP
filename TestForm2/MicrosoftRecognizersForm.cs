using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Recognizers.Text;
using Microsoft.Recognizers.Text.DateTime;
using Microsoft.Recognizers.Text.Number;
using Microsoft.Recognizers.Text.NumberWithUnit;
using Microsoft.Recognizers.Text.Sequence;
using Microsoft.Recognizers.Text.Choice;
using System.IO;

namespace TestForm2
{
    public partial class MicrosoftRecognizersForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
       

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MicrosoftRecognizersForm()
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

        private string LanguageToCode(string str)
        {
            if (str == "Spanish")
            { return "es-es"; }
            else if (str == "Chinese")
            { return "zh-cn"; }
            else if (str == "Dutch")
            { return "nl-nl"; }
            else if (str == "English")
            { return "en-us"; }
            else if (str == "English Other")
            { return "en-*"; }
            else if (str == "French")
            { return "fr-fr"; }
            else if (str == "German")
            { return "de-de"; }
            else if (str == "Italian")
            { return "it-it"; }
            else if (str == "Japanese")
            { return "ja-jp"; }
            else if (str == "Korean")
            { return "ko-kr"; }
            else if (str == "Portuguese")
            { return "pt-br"; }

            return "en-us";
        }

        private void MicrosoftRecognizersForm_Load(object sender, EventArgs e)
        {
            LanguageField.Text = "English";

            LanguageField.Items.Add("Chinese");
            LanguageField.Items.Add("Dutch");
            LanguageField.Items.Add("English");
            LanguageField.Items.Add("English Other");
            LanguageField.Items.Add("French");
            LanguageField.Items.Add("German");
            LanguageField.Items.Add("Italian");
            LanguageField.Items.Add("Japanese");
            LanguageField.Items.Add("Korean");
            LanguageField.Items.Add("Portuguese");
            LanguageField.Items.Add("Spanish");

            //LanguageField.Items.IsReadOnly = ;

            RecognizerField.Text = "Number Recognizer";

            RecognizerField.Items.Add("Number Recognizer");
            RecognizerField.Items.Add("Ordinal Recognizer");
            RecognizerField.Items.Add("Percentage Recognizer");
            RecognizerField.Items.Add("Number Range Recognizer");
            RecognizerField.Items.Add("Age Recognizer");
            RecognizerField.Items.Add("Currency Recognizer");
            RecognizerField.Items.Add("Dimention Recognizer");
            RecognizerField.Items.Add("Temperature Recognizer");
            RecognizerField.Items.Add("Date And Time Recognizer");
            RecognizerField.Items.Add("Phone Number Recognizer");
            RecognizerField.Items.Add("Ip Address Recognizer");
            RecognizerField.Items.Add("Choice Recognizer");

            InputField.Text = "";

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Word", 133);
            listView1.Columns.Add("recognized As", 134);
            listView1.Columns.Add("Starting Index", 134);
            listView1.Columns.Add("Ending Index", 133);
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();

            string query = InputField.Text;
            string SelectedRecognizer = RecognizerField.Text;
            string culture = LanguageToCode(LanguageField.Text);
            if (query != "")
            {
                //----------------------------------------------------------Recognizers
                try
                {
                    if (SelectedRecognizer == "Number Recognizer")
                    {
                        // Number recognizer will find any number from the input
                        // E.g "I have two apples" will return "2".
                        var Recognizer = NumberRecognizer.RecognizeNumber(query, culture);

                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                           
                        }
                    }
                    else if (SelectedRecognizer == "Ordinal Recognizer")
                    {
                        // Ordinal number recognizer will find any ordinal number
                        // E.g "eleventh" will return "11".
                        var Recognizer = NumberRecognizer.RecognizeOrdinal(query, culture);

                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    else if (SelectedRecognizer == "Percentage Recognizer")
                    {
                        // Percentage recognizer will find any number presented as percentage
                        // E.g "one hundred percents" will return "100%"
                        var Recognizer = NumberRecognizer.RecognizePercentage(query, culture);

                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    else if (SelectedRecognizer == "Number Range Recognizer")
                    {
                        // Number Range recognizer will find any cardinal or ordinal number range
                        // E.g. "between 2 and 5" will return "(2,5)"
                        var Recognizer = NumberRecognizer.RecognizeNumberRange(query, culture);

                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    else if (SelectedRecognizer == "Age Recognizer")
                    {
                        // Age recognizer will find any age number presented
                        // E.g "After ninety five years of age, perspectives change" will return "95 Year"
                        var Recognizer = NumberWithUnitRecognizer.RecognizeAge(query, culture);

                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    else if (SelectedRecognizer == "Currency Recognizer")
                    {
                        // Currency recognizer will find any currency presented
                        // E.g "Interest expense in the 1988 third quarter was $ 75.3 million" will return "75300000 Dollar"
                        var Recognizer = NumberWithUnitRecognizer.RecognizeCurrency(query, culture);

                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    else if (SelectedRecognizer == "Dimention Recognizer")
                    {
                        // Dimension recognizer will find any dimension presented
                        // E.g "The six-mile trip to my airport hotel that had taken 20 minutes earlier in the day took more than three hours." will return "6 Mile"
                        var Recognizer = NumberWithUnitRecognizer.RecognizeDimension(query, culture);

                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    else if (SelectedRecognizer == "Temperature Recognizer")
                    {
                        // Temperature recognizer will find any temperature presented
                        // E.g "Set the temperature to 30 degrees celsius" will return "30 C"
                        var Recognizer = NumberWithUnitRecognizer.RecognizeTemperature(query, culture);
                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    else if (SelectedRecognizer == "Date And Time Recognizer")
                    {
                        // Datetime recognizer This model will find any Date even if its write in coloquial language 
                        // E.g "I'll go back 8pm today" will return "2017-10-04 20:00:00"
                        var Recognizer = DateTimeRecognizer.RecognizeDateTime(query, culture);

                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    else if (SelectedRecognizer == "Phone Number Recognizer")
                    {
                        // PhoneNumber recognizer will find any phone number presented
                        // E.g "My phone number is ( 19 ) 38294427."
                        var Recognizer = SequenceRecognizer.RecognizePhoneNumber(query, culture);

                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    else if (SelectedRecognizer == "Ip Address Recognizer")
                    {
                        //IP recognizer will find any Ipv4/Ipv6 presented
                        // E.g "My Ip is 8.8.8.8"
                        var Recognizer = SequenceRecognizer.RecognizeIpAddress(query, culture);

                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                    else if (SelectedRecognizer == "Choice Recognizer")
                    {
                        //Boolean recognizer will find yes/no like responses, including emoji -
                        // E.g "yup, I need that" will return "True"
                        var Recognizer = ChoiceRecognizer.RecognizeBoolean(query, culture);

                        for (int i = 0; i < Recognizer.Count; i++)
                        {
                            string[] arr = new string[4];
                            ListViewItem itm;
                            //add items to ListView
                            arr[0] = Recognizer[i].Text.ToString();
                            arr[1] = Recognizer[i].Resolution["value"].ToString();
                            arr[2] = Recognizer[i].Start.ToString();
                            arr[3] = Recognizer[i].End.ToString();
                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Unable to Recognize\n"+ "Exception: " + error.Message.ToString());
                   
                }
            }
            //----------------------------------------------------------Recognizers End
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
               // MessageBox.Show(file);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveToFile_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
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
                    sw.WriteLine("Word  Recognized_As   Starting_Index  Ending_index\n");
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        //sw.WriteLine(listView1.Items[i].ToString());
                        for (int j = 0;j < listView1.Items[i].SubItems.Count; j++)
                        {
                            sw.Write(listView1.Items[i].SubItems[j].Text.ToString()+"   ");
                        }
                       
                        sw.WriteLine("  ");
                    }
                    

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
