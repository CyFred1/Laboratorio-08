using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFINAL
{
    public partial class CrearFactura : Form
    {
        public CrearFactura()
        {
            InitializeComponent();






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public int leer_id()

            
        {
            int ultimo_id = 0;
            using (SqlConnection con = new SqlConnection(DB.conexion))
            {
                con.Open();
                string query = "SELECT TOP 1 id_factura from facturas order by id_factura DESC";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    using (SqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            ultimo_id = (int)read["id_factura"];


                            return ultimo_id + 1 ;
                        }
                    }

                }

            }

            return ultimo_id + 1;

        }

        public int leer_id_producto()


        {
            int ultimo_id = 0;
            using (SqlConnection con = new SqlConnection(DB.conexion))
            {
                con.Open();
                string query = "SELECT TOP 1 id_producto from productos order by id_producto DESC";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    using (SqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            ultimo_id = (int)read["id_producto"];


                            return ultimo_id ;
                        }
                    }

                }

            }

            return ultimo_id ;

        }




        private void button1_Click(object sender, EventArgs e)


        {

            int id = leer_id();
            int id_producto = leer_id_producto();

            using (SqlConnection con = new SqlConnection(DB.conexion))
            {
                con.Open();
                string query = "INSERT INTO facturas (id_factura, fecha, nombre_cliente,direccion, nit) Values (@valor1, @valor2, @valor3, @valor4, @valor5)";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@valor1", id);
                    command.Parameters.AddWithValue("@valor2", this.in_fecha.Text);
                    command.Parameters.AddWithValue("@valor3", this.in_nombre_cliente.Text);
                    command.Parameters.AddWithValue("@valor4", this.in_direccion.Text);
                    command.Parameters.AddWithValue("@valor5", this.in_nit.Text);

                    command.ExecuteNonQuery();
                }

                //producto 1
                string query_producto_1 = "INSERT INTO productos (id_producto, nombre, precio,cantidad,id_factura) Values (@valor1, @valor2, @valor3, @valor4, @valor5)";
                using (SqlCommand command = new SqlCommand(query_producto_1, con))
                {
                    command.Parameters.AddWithValue("@valor1", id_producto + 1);
                    command.Parameters.AddWithValue("@valor2", this.in_prod_1.Text);
                    command.Parameters.AddWithValue("@valor3", this.in_prec_1.Text);
                    command.Parameters.AddWithValue("@valor4", this.int_cantidad_1.Text);
                    command.Parameters.AddWithValue("@valor5", id);

                    command.ExecuteNonQuery();
                    MessageBox.Show("se ha guardado correctamente la factura", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }


        }
            
                

        private void out_id_factura_Click(object sender, EventArgs e)
        {

        }
    }




        }
   
