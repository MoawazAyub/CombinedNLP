using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TestForm2
{
   

    public partial class FirstForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FirstForm()
        {
            InitializeComponent();
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            CoreNLPButton.BackColor = Color.Purple;
            OpenNLPButton.BackColor = Color.Purple;
            WordNetButton.BackColor = Color.Purple;
            MicroButton.BackColor = Color.Purple;

            CoreNLPLabel.BackColor = Color.Purple;
            OpenNLPLabel.BackColor = Color.Purple;
            WordNetLabel.BackColor = Color.Purple;
            MicroLabel.BackColor = Color.Purple;

        }

        private void TopBar_Click(object sender, EventArgs e)
        {
            
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
            
            //FirstForm Fs = new FirstForm();
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

        private void CoreNLPButton_MouseClick(object sender, MouseEventArgs e)
        {
            //Form2 Fs = new Form2();
           // Fs.Show();
        }

        private void CoreNLPButton_Click(object sender, EventArgs e)
        {
            Thread Th = new Thread(LanchCoreNLPForm);
            Th.SetApartmentState(ApartmentState.STA);
         
            Th.Start();

           // CoreNLPForm Fs = new CoreNLPForm();
           // Fs.Show();
        }

        public void LanchCoreNLPForm()
        {
             CoreNLPForm Fs = new CoreNLPForm();
             Fs.ShowDialog();
        }

        public void LanchOpenNLPForm()
        {
            OpenNLPForm Fs = new OpenNLPForm();
            Fs.ShowDialog();
        }
        public void LanchWordNetForm()
        {
            WordNetForm Fs = new WordNetForm();
            Fs.ShowDialog();
        }
        public void LanchMicroForm()
        {
            MicrosoftRecognizersForm Fs = new MicrosoftRecognizersForm();
            Fs.ShowDialog();
        }

        private void CoreNLPButton_MouseHover(object sender, EventArgs e)
        {
            CoreNLPButton.BackColor = Color.Navy;
            CoreNLPLabel.BackColor = Color.Navy; 
        }

        private void CoreNLPButton_MouseLeave(object sender, EventArgs e)
        {
            CoreNLPButton.BackColor = Color.Purple;
            CoreNLPLabel.BackColor = Color.Purple;
        }

        private void OpenNLPButton_MouseHover(object sender, EventArgs e)
        {
            OpenNLPButton.BackColor = Color.Navy;
            OpenNLPLabel.BackColor = Color.Navy;
        }

        private void OpenNLPButton_MouseLeave(object sender, EventArgs e)
        {
            OpenNLPButton.BackColor = Color.Purple;
            OpenNLPLabel.BackColor = Color.Purple;
        }

        private void WordNetButton_MouseHover(object sender, EventArgs e)
        {
            WordNetButton.BackColor = Color.Navy;
            WordNetLabel.BackColor = Color.Navy;
        }

        private void WordNetButton_MouseLeave(object sender, EventArgs e)
        {
            WordNetButton.BackColor = Color.Purple;
            WordNetLabel.BackColor = Color.Purple;
        }

        private void MicroButton_MouseHover(object sender, EventArgs e)
        {
            MicroButton.BackColor = Color.Navy;
            MicroLabel.BackColor = Color.Navy;
        }

        private void MicroButton_MouseLeave(object sender, EventArgs e)
        {
            MicroButton.BackColor = Color.Purple;
            MicroLabel.BackColor = Color.Purple;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CoreNLPLabel_Click(object sender, EventArgs e)
        {
            Thread Th = new Thread(LanchCoreNLPForm);
            Th.SetApartmentState(ApartmentState.STA);

            Th.Start();
        }

        private void OpenNLPLabel_Click(object sender, EventArgs e)
        {
            Thread Th = new Thread(LanchOpenNLPForm);
            Th.SetApartmentState(ApartmentState.STA);

            Th.Start();
        }

        private void WordNetLabel_Click(object sender, EventArgs e)
        {
            Thread Th = new Thread(LanchWordNetForm);
            Th.SetApartmentState(ApartmentState.STA);

            Th.Start();
        }

        private void MicroLabel_Click(object sender, EventArgs e)
        {
            Thread Th = new Thread(LanchMicroForm);
            Th.SetApartmentState(ApartmentState.STA);

            Th.Start();
        }

        private void CoreNLPLabel_MouseHover(object sender, EventArgs e)
        {
            CoreNLPButton.BackColor = Color.Navy;
            CoreNLPLabel.BackColor = Color.Navy;
        }

        private void CoreNLPLabel_MouseLeave(object sender, EventArgs e)
        {
            CoreNLPButton.BackColor = Color.Purple;
            CoreNLPLabel.BackColor = Color.Purple;
        }

        private void OpenNLPLabel_MouseHover(object sender, EventArgs e)
        {
            OpenNLPButton.BackColor = Color.Navy;
            OpenNLPLabel.BackColor = Color.Navy;
        }

        private void OpenNLPLabel_MouseLeave(object sender, EventArgs e)
        {
            OpenNLPButton.BackColor = Color.Purple;
            OpenNLPLabel.BackColor = Color.Purple;
        }

        private void WordNetLabel_MouseHover(object sender, EventArgs e)
        {
            WordNetButton.BackColor = Color.Navy;
            WordNetLabel.BackColor = Color.Navy;
        }

        private void WordNetLabel_MouseLeave(object sender, EventArgs e)
        {
            WordNetButton.BackColor = Color.Purple;
            WordNetLabel.BackColor = Color.Purple;
        }

        private void MicroLabel_MouseHover(object sender, EventArgs e)
        {
            MicroButton.BackColor = Color.Navy;
            MicroLabel.BackColor = Color.Navy;
        }

        private void MicroLabel_MouseLeave(object sender, EventArgs e)
        {
            MicroButton.BackColor = Color.Purple;
            MicroLabel.BackColor = Color.Purple;
        }

        private void WordNetButton_Click(object sender, EventArgs e)
        {
            //WordNetForm WF = new WordNetForm();
            // WF.Show();
            Thread Th = new Thread(LanchWordNetForm);
            Th.SetApartmentState(ApartmentState.STA);

            Th.Start();
        }

        private void MicroButton_Click(object sender, EventArgs e)
        {
            //MicrosoftRecognizersForm MRF = new MicrosoftRecognizersForm();
            //MRF.Show();
            Thread Th = new Thread(LanchMicroForm);
            Th.SetApartmentState(ApartmentState.STA);

            Th.Start();
        }

        private void OpenNLPButton_Click(object sender, EventArgs e)
        {
            //OpenNLPForm OF = new OpenNLPForm();
            // OF.Show();
            Thread Th = new Thread(LanchOpenNLPForm);
            Th.SetApartmentState(ApartmentState.STA);

            Th.Start();

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
