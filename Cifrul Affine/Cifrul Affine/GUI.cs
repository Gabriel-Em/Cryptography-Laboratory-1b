using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cifrul_Affine
{
    public partial class GUI : Form
    {
        private Criptograf crp = new Criptograf();
        private int valid;

        public GUI()
        {
            InitializeComponent();
        }


        private void GUI_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            KeyLoad();
        }

        private void KeyLoad()
        {
            valid = crp.KeyLoad();

            if (valid == 1)
            {
                int a = crp.getA(), b = crp.getB();

                CheieRT.Clear();
                CheieRT.Text = "Tabel de simboluri:\n-------------------------------------------------------------------------------------------------------------\n|   | A | B | C | D | E | F | G | H | I | J | K | L | M | N | O | P | Q | R | S | T | U | V | W | X | Y | Z |\n-------------------------------------------------------------------------------------------------------------\n| 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10| 11| 12| 13| 14| 15| 16| 17| 18| 19| 20| 21| 22| 23| 24| 25| 26|\n-------------------------------------------------------------------------------------------------------------\n\n";
                CheieRT.Text = CheieRT.Text + "Cheia de criptare: " + a.ToString() + "x+" + b.ToString();
            }
            else
                if (valid == 0)
                {
                    CheieRT.Text = "Error: Fisierul 'Key.txt' nu exista sau nu poate fii accesat!";
                }
                else
                    if (valid == -1)
                        CheieRT.Text = "Error: Cheia de criptare e gresita!";
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa inchideti aplicatia?", "ATENTIONARE", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void KeyLoadB_Click(object sender, EventArgs e)
        {
            KeyLoad();
        }

        private void DecryptB_Click(object sender, EventArgs e)
        {
            DecryptedRT.Text = (crp.Decrypt(EncryptedRT.Text));
        }

        private void EncryptB_Click(object sender, EventArgs e)
        {
            EncryptedRT.Text = (crp.Encrypt(DecryptedRT.Text));
        }
    }
}
