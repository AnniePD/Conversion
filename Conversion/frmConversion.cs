using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class frmConversion : Form
    {
        string[] m_Hexadecimal;
        public frmConversion()
        {
            InitializeComponent();
            m_Hexadecimal = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        }

        private void SortieBinaire(string Sortie)
        {
            txtBinaire.Text = Sortie;
        }

        private void SortieHexa(string Sortie)
        {
            txtHexa.Text = Sortie;
        }

        private void SortieDecimale(string Sortie)
        {
            txtDecimale.Text = Sortie;
        }

        /*private int ConversionHexaDeci(int Entree)
        {

        }*/

        private int ConversionDeciBin(int Entree)
        {
            int Resultat;
            int Reste;
            string Sortie = "";

            while(Entree > 0)
            {
                Resultat = Entree / 2;
                Reste = Entree % 2;
                Entree = Resultat;
                Sortie = Reste.ToString() + Sortie;
            }
            Int32.TryParse(Sortie, out Entree);
            return Entree;
        }

        private int ConversionBinDeci(int Entree)
        {
            int Reste;
            int Sortie = 0;
            for (int exposant = 0; Entree > 0; exposant++)
            {
                Reste = Entree % 10;
                Entree = Entree / 10;
                Sortie = Sortie + (int)Math.Pow(Reste, exposant);

            }

            return Sortie;
        }

        private void btnBinaire_Click(object sender, EventArgs e)
        {
            string Entree;
            int Sortie;

            Entree = txtEntree.Text;
            if (Entree[0] == '0' && Entree[1] == 'x')
            {
                Entree = Entree.Remove(0, 2);
                Int32.TryParse(Entree, out Sortie);
                //Sortie = ConversionHexaDeci(Sortie);
                Sortie = ConversionDeciBin(Sortie);
            }
            else if(Entree[0] != 'b')
            {
                Int32.TryParse(Entree, out Sortie);
                Sortie = ConversionDeciBin(Sortie);
            }
            else
            {
                Entree = Entree.Remove(0, 1);
                Int32.TryParse(Entree, out Sortie);
            }
            SortieBinaire(Sortie.ToString());
        }

        private void btnDecimale_Click(object sender, EventArgs e)
        {
            string Entree;
            int Sortie;

            Entree = txtEntree.Text;
            if (Entree[0] == '0' && Entree[1] == 'x')
            {
                Entree = Entree.Remove(0, 2);
                Int32.TryParse(Entree, out Sortie);
                //Sortie = ConversionHexaDeci(Sortie);
                Sortie = ConversionDeciBin(Sortie);
            }
            else if (Entree[0] == 'b')
            {
                Entree = Entree.Remove(0, 1);
                Int32.TryParse(Entree, out Sortie);
                Sortie = ConversionBinDeci(Sortie);
            }
            else
            {

                Int32.TryParse(Entree, out Sortie);
            }
            SortieDecimale(Sortie.ToString());

        }
    }
}
