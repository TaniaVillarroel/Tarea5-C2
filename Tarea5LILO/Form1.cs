using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5LILO
{
    public partial class Form1 : Form
    {
        int contador = 0;

        const int tam = 2;
        //string[] aNombre = new string[tam];
        //double[] aPrecio = new double[tam];
        //int[] aCantidad = new int [tam];
        //double[] aImporte = new double [tam];
        //En ves de hacer un arreglo para cada atributo hacemos un arreglo producto

        ClaseProductoEjercicio5[] aProducto = new ClaseProductoEjercicio5[tam];


        public Form1() // esto el profe lo llama contructor
        {
            InitializeComponent();
            for(int i = 0; i < tam; i++)
            {
                //aNombre[i] = "";
                //aNombre[i] = string.Empty; // representa la cadena vacia
                //aPrecio[i] = aImporte[i] = aCantidad[i] = 0;

                aProducto[i] = null;
  
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //aNombre[0] = "pan";
            //aPrecio[0] = 50;
            //aCantidad[0] = 2;

            //aNombre[1] = "leche";
            //aPrecio[1] = 35;
            //aCantidad[1] = 2;

            //for (int i = 0; i < tam; i++)
            //{
            //    lstNombre.Items.Add(aNombre[i]);
            //    lstPrecio.Items.Add(aPrecio[i]);
            //    lstCantidad.Items.Add(aCantidad[i]);
            //}


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double acumulador=0 ;

            lstImporte.Items.Clear();
            for (int i = 0; i < contador; i++)
            {
                //aImporte[i] = aPrecio[i] * aCantidad[i];
                //lstImporte.Items.Add(aImporte[i].ToString());
                //acumulador+= aImporte[i];
                lstImporte.Items.Add(aProducto[i].calcularImporte());
                acumulador += aProducto[i].calcularImporte();
            }

            txtImporte.Text = acumulador.ToString(); // esto es un acumulador
           
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (contador == tam)
            {
                MessageBox.Show("Se completo la carga");
                btnCargar.Enabled = false;
            }
            else
            //{
            //    aNombre[contador] = txtNombre.Text;
            //    aPrecio[contador] = double.Parse(txtPrecio.Text);
            //    aCantidad[contador] = int.Parse(txtCantidad.Text);

            //    lstNombre.Items.Add(aNombre[contador]);
            //    lstPrecio.Items.Add(aPrecio[contador]);
            //    lstCantidad.Items.Add(aCantidad[contador]);

                aProducto[contador]= new ClaseProductoEjercicio5();
                aProducto[contador].pNombre = txtNombre.Text;
                aProducto[contador].pPrecio= Convert.ToDouble(txtPrecio.Text);
                aProducto[contador].pCantidad=  Convert.ToInt32(txtCantidad.Text);

                lstNombre.Items.Add(aProducto[contador].pNombre);
                lstPrecio.Items.Add(aProducto[contador].pPrecio);
                lstCantidad.Items.Add(aProducto[contador].pCantidad);
            
                contador++;
            }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        
        }
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Quiere salir..?",
                               "SALIENDO", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere salir..?",
                                 "SALIENDO", MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Close();
        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("¿Quiere salir..?",
        //                       "SALIENDO", MessageBoxButtons.YesNo,
        //                        MessageBoxIcon.Question,
        //                       MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        //        e.Cancel = false;
        //    else
        //        e.Cancel = true;
        //}
    }
}
