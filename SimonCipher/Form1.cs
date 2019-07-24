using System;
using System.Windows.Forms;
using System.Text;

namespace SimonCipher
{
    public partial class Form1 : Form
    {
        int blockSize;
        int keySize;
        Simon simonCipher;

        public Form1()
        {
            InitializeComponent();
            blockSize = 128;
            keySize = 128;
            simonCipher = new Simon(blockSize, keySize);
        }

        private void rb128_Click(object sender, EventArgs e)
        {
            changeBlockAndKeySize();
        }

        private void changeBlockAndKeySize()
        {
            /*
            if (rb1.Checked) { blockSize = 32; keySize = 64; }
            if (rb1.Checked) { blockSize = 48; keySize = 72; }
            if (rb1.Checked) { blockSize = 48; keySize = 96; }
            if (rb1.Checked) { blockSize = 64; keySize = 96; }
            if (rb1.Checked) { blockSize = 64; keySize = 128;}
            if (rb1.Checked) { blockSize = 96; keySize = 96; }
            if (rb1.Checked) { blockSize = 96; keySize = 144; }
            */
            if (rb128.Checked) { blockSize = 128; keySize = 128; }
            if (rb192.Checked) { blockSize = 128; keySize = 192; }
            if (rb256.Checked) { blockSize = 128; keySize = 256; }
            label4.Text = keySize + " size";
            simonCipher = new Simon(blockSize, keySize);
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            simonCipher.cifrarMensaje
        }
    }

   
}
