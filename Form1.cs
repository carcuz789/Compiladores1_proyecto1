using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compiladores1_proyecto1
{

   
    public partial class Form1 : Form
    {
       public static ListaGenericaDoble listok = new ListaGenericaDoble();
        
        public Form1()
        {
           
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string line = "";
            string texto = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                while (line!=null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        texto = line + "\n";

                    }
                }
                sr.Close();
                this.txtPrincipal.Text = texto;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Lexico lexco = new Lexico();
            try {
                lexco.AnaliLexico(this.txtPrincipal.Text.ToCharArray());
                MessageBox.Show("LEXICO EXITOS");
                listok.Imprimir();
            } catch(InvalidCastException ) {
                MessageBox.Show("ESTA MALO :,(");
            }
           

        }
    }
}
