using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        IBitmapGenerator bitmapGenerator;
        IMusicSheetsSystemFacade musicSheetsSystemFacade;
        PDFConverter pdfConverter;

        public Form1()
        {
            InitializeComponent();

            bitmapGenerator = new BitmapGenerator();
            musicSheetsSystemFacade = new MusicSheetsSystemFacade(bitmapGenerator);
            pdfConverter = new PDFConverter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musicSheetsSystemFacade.InitializeMusicSheets();
            pictureBox1.Image = musicSheetsSystemFacade.Background;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = musicSheetsSystemFacade.UpdateMusicSheet(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SaveCommand(pdfConverter, (Bitmap)pictureBox1.Image));
            invoker.DoCommands();
        }

        private void button1_Click(object sender, EventArgs e) //next (TODO)
        {
            musicSheetsSystemFacade.SelectNextMusicSheet();
        }

        private void button2_Click(object sender, EventArgs e) //back (TODO)
        {
            musicSheetsSystemFacade.SelectPreviousMusicSheet();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //override for shortcut saving
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                Invoker invoker = new Invoker();
                invoker.SetOnStart(new SaveCommand(pdfConverter, (Bitmap)pictureBox1.Image));
                invoker.DoCommands();

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
