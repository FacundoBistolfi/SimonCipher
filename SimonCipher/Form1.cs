using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

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
            if (rb128.Checked) { blockSize = 128; keySize = 128; tbKey.Text = ""; tbKey.MaxLength = 16; }
            if (rb192.Checked) { blockSize = 128; keySize = 192; tbKey.Text = ""; tbKey.MaxLength = 24; }
            if (rb256.Checked) { blockSize = 128; keySize = 256; tbKey.Text = ""; tbKey.MaxLength = 32; }
            label4.Text = keySize + " bits";
            simonCipher = new Simon(blockSize, keySize);
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            FileStream inFs = new FileStream(tbEntrada.Text, FileMode.Open, FileAccess.Read);
            FileStream outFs = new FileStream(tbSalida.Text, FileMode.Create);
            byte[] bufferIn = new byte[16];
            int fileOffset = 0;
            ulong i = 0;

            simonCipher.calcularKeys(Encoding.ASCII.GetBytes(tbKey.Text));

            while (fileOffset < inFs.Length)
            {
                inFs.Seek(fileOffset, SeekOrigin.Begin);
                bufferIn = new byte[16];
                int bytesRead = inFs.Read(bufferIn, 0, 16);

                outFs.Write(simonCipher.cifrarBloque(bufferIn), 0, 16);
                fileOffset += 16;
                i++;
            }
            
            inFs.Close();
            outFs.Close();
            //watch.Stop();
            //tbTime.Text = watch.ElapsedMilliseconds.ToString();
            

        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            FileStream inFs = new FileStream(tbEntrada.Text, FileMode.Open, FileAccess.Read);
            FileStream outFs = new FileStream(tbSalida.Text, FileMode.Create);
            byte[] bufferIn = new byte[16];
            int fileOffset = 0;
            ulong i = 0;

            simonCipher.calcularKeys(Encoding.ASCII.GetBytes(tbKey.Text));

            while (fileOffset < inFs.Length)
            {
                inFs.Seek(fileOffset, SeekOrigin.Begin);
                bufferIn = new byte[16];
                int bytesRead = inFs.Read(bufferIn, 0, 16);

                

                outFs.Write(simonCipher.descifrarBloque(bufferIn), 0, 16);
                fileOffset += 16;
                i++;
            }

            inFs.Close();
            outFs.Close();
            //watch.Stop();
            //tbTime.Text = watch.ElapsedMilliseconds.ToString();

        }


        //Funcion que convierte un array de ulong a un string (En ASCII)
        public String ulongToString(ulong[] array)
        {
            String decoded = "";
            for (int i = 0; i < array.Length; i++)
            {
                decoded += Encoding.Unicode.GetString(BitConverter.GetBytes(array[i]));
            }
            return decoded;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fd.FilterIndex = 2;
                fd.RestoreDirectory = true;

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    tbEntrada.Text = fd.FileName;
                }
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog fd = new SaveFileDialog())
            {
                fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fd.FilterIndex = 2;
                fd.RestoreDirectory = true;

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    tbSalida.Text = fd.FileName;
                }
            }
        }

        private void Rb128_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

   
}
