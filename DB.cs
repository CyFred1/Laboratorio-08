using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFINAL

{
    internal class DB
    {
     public static string conexion = "Data source = DESKTOP-6ELSEII; Initial Catalog=db_proyectoFinal; Integrated Security=True; MultipleActiveResultSets=True";



        public int id_producto;
        public string nombre_producto;
        public decimal precio_producto;

        public DB()
        {
            // Vamos a probar
            using (SqlConnection con = new SqlConnection(DB.conexion))
            {
                con.Open();
                string query = "SELECT * FROM productos";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    using (SqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            this.nombre_producto = read["nombre"].ToString();
                        }
                    }

                }

                }
                }
            }
        }