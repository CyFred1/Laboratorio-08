using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                DB basedatos = new DB();
                MessageBox.Show(basedatos.nombre_producto);
            

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            //instanciar un objeto del formulario de crear factura 
            CrearFactura formulario = new CrearFactura();

            formulario.Show();


        }
    }
}
