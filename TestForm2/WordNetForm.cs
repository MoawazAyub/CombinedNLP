using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Syn.WordNet;
using System.IO;
using System.Diagnostics;

namespace TestForm2
{
    public partial class WordNetForm : Form
    {
        PleaseWaitForm2 PWF2;
        static WordNetEngine wordNet;
        System.String directory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\dict";


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public WordNetForm()
        {
            InitializeComponent();
        }

        public string AddNewLines(string str, int val)
        {
            string temp = "";
            int j = 0;

            for (int i = 0; i < str.Length; i++)
            {
                j = j + 1;
                temp = temp + str[i];
                if (str[i] == ' ' && j >= val)
                {
                    j = 0;
                    temp = temp + '\n';
                }
            }


            return temp;
        }

        private void TopBar_Click(object sender, EventArgs e)
        {

        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CrossButton_MouseHover(object sender, EventArgs e)
        {
            CrossButton.BackgroundImage = TestForm2.Properties.Resources.cross3;
            CrossButton.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void CrossButton_MouseLeave(object sender, EventArgs e)
        {
            CrossButton.BackgroundImage = TestForm2.Properties.Resources.cross4;
            CrossButton.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WordNetForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            PWF2 = new PleaseWaitForm2();
            PWF2.Show();
            
            //--------------------------------Word Net Loading
            wordNet = new WordNetEngine();

            wordNet.LoadFromDirectory(directory);

            PWF2.Close();
            this.Visible = true;
            //--------------------------------------------------------------
            textBox1.Text = "";
            //------------------------------------------
            dgv.AutoGenerateColumns = false;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //----------------------------------------------------------------------------
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Synonyms",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Parts of Speech",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 50,
                
                //FillWeight = 25
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Gloss",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 300
                // Width = 100,
            });
            //---------------------------------------------------1
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Also See",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 2000
                //FillWeight = 25
            });
            //---------------------------------------------------2
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Antonym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 60

                //FillWeight = 25
            });
            //---------------------------------------------------3
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Attribute",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 200
                //FillWeight = 25
            });
            //---------------------------------------------------4
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cause",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 200
                //FillWeight = 25
            });
            //---------------------------------------------------5
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Derivationally Related",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 200
                //FillWeight = 25
            });
            //---------------------------------------------------6
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Derived from Adjective",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 200
                //FillWeight = 25
            });
            //---------------------------------------------------7
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Entailment",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
                //FillWeight = 25
            });
            //---------------------------------------------------8
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Hypernym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 700
                //FillWeight = 25
            });
            //---------------------------------------------------9
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Hyponym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 1600
                //FillWeight = 25
            });
            //---------------------------------------------------10
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Instance Hypernym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 300
                //FillWeight = 25
            });
            //---------------------------------------------------11
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Instance Hyponym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 3000
                //FillWeight = 25
            });
            //---------------------------------------------------12
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Member Holonym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 300
                //FillWeight = 25
            });
            //---------------------------------------------------13
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Member Meronym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 300
                //FillWeight = 25
            });
            //---------------------------------------------------14
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Part Holonym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 300
                //FillWeight = 25
            });
            //---------------------------------------------------15
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Participle of Verb",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 200
                //FillWeight = 25
            });
            //---------------------------------------------------16
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Part Meronym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 1000
                //FillWeight = 25
            });
            //---------------------------------------------------17
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Part Ainym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
                //FillWeight = 25
            });
            //---------------------------------------------------18
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Region Domain",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 500
                //FillWeight = 25
            });
            //---------------------------------------------------19
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Region Domain Member",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 700
                //FillWeight = 25
            });
            //---------------------------------------------------20
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Similar To",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 600
                //FillWeight = 25
            });
            //---------------------------------------------------21
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Substance Holonym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 200
                //FillWeight = 25
            });
            //---------------------------------------------------22
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "substance Meronym",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 200
                //FillWeight = 25
            });
            //---------------------------------------------------23
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Topic Domain",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 200
                //FillWeight = 25
            });
            //---------------------------------------------------24
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Topic Domain Member",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 300
                //FillWeight = 25
            });
            //---------------------------------------------------25
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Usage Domain",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 300
                //FillWeight = 25
            });
            //---------------------------------------------------26
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Usage Domain Member",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 200
                //FillWeight = 25
            });
            //---------------------------------------------------27
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Verb Group",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 1000
                //FillWeight = 25
            });
            //----------------------------------------------------------------------


        }

        private void GenerateOutputButton_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            dgv.Refresh();
            this.Visible = false;
            PWF2 = new PleaseWaitForm2();
            PWF2.Show();

            string input = textBox1.Text.ToString();

            if (input != "")
            {
                InsertInTable(input);
            }
           

            PWF2.Close();
            this.Visible = true;
        }

        public void InsertInTable(string word)
        {

         //   try
         //   {

                var synSetList = wordNet.GetSynSets(word);

                if (synSetList.Count == 0)
                {
                    return;
                }
            int index = 0;
                foreach (var synSet in synSetList)
                {
                    string words = string.Join(", ", synSet.Words);

                    string pos = $"{synSet.PartOfSpeech}";

                    string gloss = $"{synSet.Gloss}";

                    string[] NYMS = new string[27];

                    for (int i = 0; i < 27; i++)
                    {
                        NYMS[i] = " --- ";
                    }
                

                    //var hypernyms = synSet.GetRelatedSynSets(SynSetRelation.AlsoSee, true);
                    System.Collections.Generic.List<SynSet> nyms;
                    //-------------------------------------------------------------------1

                    for (int i = 0; i < 27; i++)
                    {
                        nyms = synSet.GetRelatedSynSets((SynSetRelation)i+1, true);

                        foreach (var item in nyms)
                        {
                            NYMS[i] = NYMS[i] + ", " + item;
                        }
                        //NYMS[i] = AddNewLines(NYMS[i],25);
                    }

              
               
                dgv.Rows.Add(words, pos, gloss, NYMS[0], NYMS[1], NYMS[2], NYMS[3], NYMS[4], NYMS[5], NYMS[6], NYMS[7], NYMS[8], NYMS[9], NYMS[10], NYMS[11], NYMS[12], NYMS[13], NYMS[14], NYMS[15], NYMS[16], NYMS[17], NYMS[18], NYMS[19], NYMS[20], NYMS[21], NYMS[22], NYMS[23], NYMS[24], NYMS[25], NYMS[26]);
                index++;

               

            }



          //  }
           // catch (Exception e)
          //  {

           // }


            
        }

        private void Heading_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SaveToFile_Click(object sender, EventArgs e)
        {
            
            if (dgv.RowCount == 0)
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
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        //sw.WriteLine(listView1.Items[i].ToString());
                        for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                        {
                            sw.Write(AddNewLines(dgv.Rows[i].Cells[j].Value.ToString(), 100) + "                     ");
                        }

                        for (int j = 0; j < 5 ; j++)
                        {
                            sw.WriteLine("  ");
                        }
                        
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
