using System;
using System.Windows.Forms;
using System.Text;

namespace SimonCipher
{
    public partial class Form1 : Form
    {
        int blockSize;
        int keySize;

        public Form1()
        {
            InitializeComponent();
            blockSize = 32;
            keySize = 64;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void rb10_Click(object sender, EventArgs e)
        {
            changeBlockAndKeySize();
        }

        private void changeBlockAndKeySize()
        {
            if (rb1.Checked) { blockSize = 32; keySize = 64; }
            if (rb1.Checked) { blockSize = 48; keySize = 72; }
            if (rb1.Checked) { blockSize = 48; keySize = 96; }
            if (rb1.Checked) { blockSize = 64; keySize = 96; }
            if (rb1.Checked) { blockSize = 64; keySize = 128;}
            if (rb1.Checked) { blockSize = 96; keySize = 96; }
            if (rb1.Checked) { blockSize = 96; keySize = 144; }
            if (rb1.Checked) { blockSize = 128; keySize = 128; }
            if (rb1.Checked) { blockSize = 128; keySize = 196; }
            if (rb1.Checked) { blockSize = 128; keySize = 256; }
            label4.Text = keySize + " size";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simon sc = new Simon(blockSize, keySize);

            tbSalida.Text = sc.cifrarMensaje(
                    BitConverter.ToInt64(Encoding.ASCII.GetBytes(tbKey.Text),0),
                    BitConverter.ToInt64(Encoding.ASCII.GetBytes(tbKey.Text),0));

        }
    }
}
