using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PruebaC
{
    public partial class FormArticulos : Form
    {
        public FormArticulos()
        {
            InitializeComponent();
        }

        private void Txtprecioproduct_TextChanged(object sender, EventArgs e)
        {
          if (System.Text.RegularExpressions.Regex.IsMatch(Txtprecioproduct.Text, "[^0-9].[^0-9]"))
            {
  
               Txtprecioproduct.Text = Txtprecioproduct.Text.Remove(Txtprecioproduct.Text.Length - 1);
            }
        }

        private void TxtPeso_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtPeso.Text, "[^0-9].[^0-9]"))
            {

                TxtPeso.Text = TxtPeso.Text.Remove(TxtPeso.Text.Length - 1);
            }
        }

        private void FormArticulos_Load(object sender, EventArgs e)
         {

            var productype = new List<Productype>();

            String connectionString = "Server=LAPTOP-DIJC1E1E\\SQLEXPRESS;Database=PRUEBAREST;Integrated Security=SSPI;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        SqlCommand sqlCmd = new SqlCommand("SELECT [id_tipo_producto],[nombre_tipo_producto] FROM [PRUEBA_C].[dbo].[TIPO_PRODUCTO] ORDER BY nombre_tipo_producto ASC;", sqlConnection);

                        sqlConnection.Open();
                        SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                        while (sqlReader.Read())
                        {

                    productype.Add(new Productype(sqlReader.GetInt32(0), sqlReader.GetString(1)));

                        }
                        sqlReader.Close();
                        this.cmbTipProduct.DataSource = productype;
                        this.cmbTipProduct.DisplayMember = "Nombre";
                        this.cmbTipProduct.ValueMember = "Valor";
                        this.cmbTipProduct.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    connection.Close();
                }
                connection.Close();
            }



        }

        private void cmbTipProduct_SelectedValueChanged(object sender, EventArgs e)
        {

            var gridarts = new List<grdArticulos>();

            String connectionString = "Server=LAPTOP-DIJC1E1E\\SQLEXPRESS;Database=PRUEBAREST;Integrated Security=SSPI;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                if (this.cmbTipProduct.SelectedValue.ToString().Equals("PruebaC.Productype")==false)
                {

                    connection.Open();

                    try
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            SqlCommand sqlCmd = new SqlCommand($"SELECT [id_producto],[id_tipo_producto],[nombre_producto],[precio_unitario_producto],[SKU],[codigo_barras],[peso_kg],[detalles_producto]\r\n  FROM [PRUEBA_C].[dbo].[PRODUCTO] WHERE [id_tipo_producto] = {this.cmbTipProduct.SelectedValue.ToString()} ORDER BY [nombre_producto] ASC;", sqlConnection);

                            sqlConnection.Open();

                            SqlDataAdapter sqlReader = new SqlDataAdapter(sqlCmd);

                            var datamart = new DataTable();

                            sqlReader.Fill(datamart);

                            DTGRProducts.DataSource = datamart;

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        connection.Close();
                    }
                    connection.Close();
                }
            }



        }





    }
}
