using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
namespace Traductor
{
    public partial class Form1 : Form
    {
        string Letras;

        public Form1()
        {
            InitializeComponent();
            
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            Letras = textBox1.Text.ToString();
            SpeechSynthesizer _SS = new SpeechSynthesizer();
            SpeechRecognizer op = new SpeechRecognizer();
            
          if(textBox1.Text == "")
          {
                MessageBox.Show("Porfavor introduce texto | BOT");
          }
        
            
          else if(Letras == textBox1.Text)
          {
                _SS.Volume = trackBar2.Value;
               
                
                _SS.Rate = trackBar1.Value;

         
                
                _SS.Speak(Letras);
          }
          
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        int PosX;
        int PosY;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                PosX = e.X;
                PosY = e.Y;
            }
            else
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }
    }
}
