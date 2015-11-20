using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento_Lite
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            txtFolio.Value++;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.Margins = new Margins(0, 0, 10, 10);
            PaperSize pkCustomSize1 = new PaperSize("CustomSize", 2, 0);
            
            printDocument1.DefaultPageSettings.PaperSize = pkCustomSize1;
            
            List<string> cadenaSalida = new List<string>();
            List<string> cabecera= txtCabecera.Text.Trim().Split('\n','\r').ToList();
            List<string> pie = txtPie.Text.Trim().Split('\n', '\r').ToList();
            cadenaSalida.AddRange(acomodarALargoHoja(cabecera));
            cadenaSalida.AddRange(acomodarALargoHoja(pie));
            cadenaSalida.Add("Folio:" + txtFolio.Value.ToString());

            e.Graphics.DrawString(string.Join(Environment.NewLine,cadenaSalida),
                new Font("Consolas", (float)9.75), Brushes.Black, new Point(0, 0));
        }

        private static List<string> acomodarALargoHoja(List<string> cabecera)
        {
            const int largoLinea = 32;
            List<string> resultado = new List<string>();
            foreach (string l in cabecera)
            {
                if (l.Length < largoLinea)
                    resultado.Add(l);
                else
                {
                    for (int i = 0; i < l.Length; i += largoLinea)
                    {
                        int corte = (i + largoLinea > l.Length - 1) ? l.Length - i - 1 : largoLinea;
                        resultado.Add(l.Substring(i, corte));
                    }
                }
            }

            return resultado;
        }
    }
}
