using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Dato = 0;
        int cont = 0;
        Arbol_Binario mi_Arbol = new Arbol_Binario(null);
        Graphics g;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;
            mi_Arbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, Brushes.White);
        }

        private void brnIngresar_Click(object sender, EventArgs e)
        {
            if (txtInsertar.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor");
            }
            else
            {
                Dato = int.Parse(txtInsertar.Text);
                if (Dato < 0 || Dato >= 100)
                {
                    MessageBox.Show("Solo Recibe valores desde 1 hasta 99", "Error de Ingreso");
                }
                else
                {
                    mi_Arbol.Insertar(Dato);
                    txtInsertar.Clear();
                    txtInsertar.Focus();
                    cont++;
                    Refresh();
                    Refresh();
                }
            }
        }

        private void btnElimnar_Click(object sender, EventArgs e)
        {
            if (txtEliminar.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor");
            }
            else
            {
                Dato = int.Parse(txtEliminar.Text);
                if (Dato < 0 || Dato >= 100)
                {
                    MessageBox.Show("Solo Recibe valores desde 1 hasta 99", "Error de Ingreso");
                }
                else
                {
                    mi_Arbol.eliminar(Dato);
                    txtEliminar.Clear();
                    txtEliminar.Focus();
                    cont++;
                    Refresh();
                    Refresh();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor");
            }
            else
            {
                Dato = int.Parse(txtBuscar.Text);
                if (Dato < 0 || Dato >= 100)
                {
                    MessageBox.Show("Solo Recibe valores desde 1 hasta 99", "Error de Ingreso");
                }
                else
                {
                    mi_Arbol.Buscar(Dato);
                    txtBuscar.Clear();
                    txtBuscar.Focus();
                    cont++;
                    Refresh();
                    Refresh();
                }
            }
        }
    }
}
