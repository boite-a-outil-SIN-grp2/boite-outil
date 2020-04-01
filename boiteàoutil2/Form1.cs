using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boiteàoutil2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            String Dec = DecBox.Text;
            String Bin = BinBox.Text;
            String Hex = HexBox.Text;

            if (Dec != "" && Bin == "" && Hex == "")
            {
                int reste = 0;
                int reste2 = 0;
                String resultat = "";
                String resultat2 = "";
                BinBox.Text = "";
                HexBox.Text = "";
                int nombre = int.Parse(DecBox.Text);
                int nombre2 = int.Parse(DecBox.Text);
                while (nombre > 0)
                {
                    reste = nombre % 2;
                    if (nombre % 2 == 0)
                    {
                        resultat = 0 + resultat;
                    }
                    else
                    {
                        resultat = reste + resultat;
                    }
                    nombre = nombre / 2;

                }
                BinBox.Text = resultat;

                while (nombre2 > 0)
                {
                    reste2 = nombre2 % 16;
                    if (reste2 == 0)
                    {

                        resultat2 = 0 + resultat2;

                    }


                    if (reste2 > 9)
                    {


                        if (reste2 == 10)
                        {

                            resultat2 = "A" + resultat2;
                        }
                        if (reste2 == 11)
                        {

                            resultat2 = "B" + resultat2;
                        }
                        if (reste2 == 12)
                        {

                            resultat2 = "C" + resultat2;
                        }
                        if (reste2 == 13)
                        {

                            resultat2 = "D" + resultat2;
                        }
                        if (reste2 == 14)
                        {

                            resultat2 = "E" + resultat2;
                        }
                        if (reste2 == 15)
                        {

                            resultat2 = "F" + resultat2;
                        }

                    }
                    if (reste2 <= 9 && reste2 > 0)
                    {

                        resultat2 = reste2 + resultat2;

                    }

                    nombre2 = nombre2 / 16;
                }
                HexBox.Text = resultat2;
            } 

            if (Bin != "" && Dec == "" && Hex == "")
            {
                int Decres = 0;
                int puissance = 1;
                int position = Bin.Length;
                DecBox.Text = "";
                HexBox.Text = "";

                for ( int i = position - 1; i >= 0; i--)
                {

                    if (Bin[i] == '1')
                    {
                        Decres += puissance;
                    }
                    puissance *= 2;
                }
                DecBox.Text = Convert.ToString(Decres);

                int nombre2 = int.Parse(DecBox.Text);
                int reste2 = 0;
                String resultat2 = "";
                while (nombre2 > 0)
                {
                    reste2 = nombre2 % 16;
                    if (reste2 == 0)
                    {

                        resultat2 = 0 + resultat2;

                    }


                    if (reste2 > 9)
                    {


                        if (reste2 == 10)
                        {

                            resultat2 = "A" + resultat2;
                        }
                        if (reste2 == 11)
                        {

                            resultat2 = "B" + resultat2;
                        }
                        if (reste2 == 12)
                        {

                            resultat2 = "C" + resultat2;
                        }
                        if (reste2 == 13)
                        {

                            resultat2 = "D" + resultat2;
                        }
                        if (reste2 == 14)
                        {

                            resultat2 = "E" + resultat2;
                        }
                        if (reste2 == 15)
                        {

                            resultat2 = "F" + resultat2;
                        }

                    }
                    if (reste2 <= 9 && reste2 > 0)
                    {

                        resultat2 = reste2 + resultat2;

                    }

                    nombre2 = nombre2 / 16;
                }
                HexBox.Text = resultat2;

            }
            if (Hex != "" && Dec == "" && Bin == "")
            {
                int position = Hex.Length;
                int Decres = 0;
                int puissance = 1;
                DecBox.Text = "";
                BinBox.Text = "";

                for (int i = position - 1; i >= 0; i--)
                {
                    if (Hex[i] >= '0' && Hex[i] <= '9')
                    {
                        Decres += (Hex[i] - 48) * puissance;
                    }
                    else if (Hex[i] >= 'A' && Hex[i] <= 'F')
                    {
                        Decres += (Hex[i] - 55) * puissance;
                    }
                    puissance *= 16;
                }
                DecBox.Text = Convert.ToString(Decres);
                int nombre = int.Parse(DecBox.Text);
                int reste = 0;
                String resultat = "";

                while (nombre > 0)
                {
                    reste = nombre % 2;
                    if (nombre % 2 == 0)
                    {
                        resultat = 0 + resultat;
                    }
                    else
                    {
                        resultat = reste + resultat;
                    }
                    nombre = nombre / 2;

                }
                BinBox.Text = resultat;
            }
        }

        private void Res_Click(object sender, EventArgs e)
        {
            DecBox.Text = "";
            BinBox.Text = "";
            HexBox.Text = "";
        }
    }
}
