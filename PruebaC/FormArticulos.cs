using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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


        public Int32 maximus = 0;

        private void Txtprecioproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPeso_TextChanged(object sender, EventArgs e)
        {

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
                            SqlCommand sqlCmd_x = new SqlCommand($"SELECT [id_producto],[id_tipo_producto],[nombre_producto],[precio_unitario_producto],[SKU],[codigo_barras],[peso_kg],[detalles_producto]\r\n  FROM [PRUEBA_C].[dbo].[PRODUCTO] WHERE [id_tipo_producto] = {this.cmbTipProduct.SelectedValue.ToString()} ORDER BY [id_producto] ASC;", sqlConnection);

                            sqlConnection.Open();

                            SqlDataAdapter sqlReader = new SqlDataAdapter(sqlCmd_x);

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

                    try
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            SqlCommand sqlCmd = new SqlCommand($"SELECT TOP 1 [id_producto] FROM [PRUEBA_C].[dbo].[PRODUCTO] ORDER BY [id_producto] DESC;", sqlConnection);

                            sqlConnection.Open();


                            SqlDataReader sqlReader_X = sqlCmd.ExecuteReader();

                            while (sqlReader_X.Read())
                            {

                                maximus = sqlReader_X.GetInt32(0);

                            }


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

        private void Btnagregar_Click(object sender, EventArgs e)
        {


           if (Txtproductname.Text.Length > 0 && Txtprecioproduct.Text.Length > 0 && Txtsku.Text.Length > 0 && Txtcodebar.Text.Length > 0 && TxtPeso.Text.Length > 0) {

                String connectionString = "Server=LAPTOP-DIJC1E1E\\SQLEXPRESS;Database=PRUEBAREST;Integrated Security=SSPI;Trusted_Connection=True;";

                try
                {

                    using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();


                    SqlCommand cmd = new SqlCommand("INSERT INTO [PRUEBA_C].[dbo].[PRODUCTO]\r\n           ([id_producto],[id_tipo_producto],[nombre_producto] ,[precio_unitario_producto],[SKU],[codigo_barras],[peso_kg],[detalles_producto])\r\n     VALUES (@id_producto,@id_tipo_producto,@nombre_producto,@precio_unitario_producto,@SKU,@codigo_barras,@peso_kg,@detalles_producto)", con);
                        maximus = maximus + 1;
                    cmd.Parameters.AddWithValue("@id_producto", maximus.ToString()) ;
                    cmd.Parameters.AddWithValue("@id_tipo_producto", this.cmbTipProduct.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@nombre_producto", Txtproductname.Text);
                    cmd.Parameters.AddWithValue("@precio_unitario_producto", Txtprecioproduct.Text);
                    cmd.Parameters.AddWithValue("@SKU", Txtsku.Text);
                    cmd.Parameters.AddWithValue("@codigo_barras", Txtcodebar.Text);
                    cmd.Parameters.AddWithValue("@peso_kg", TxtPeso.Text);
                    cmd.Parameters.AddWithValue("@detalles_producto", richTextBox1.Text);

              
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }

                    try
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            SqlCommand sqlCmd_x = new SqlCommand($"SELECT [id_producto],[id_tipo_producto],[nombre_producto],[precio_unitario_producto],[SKU],[codigo_barras],[peso_kg],[detalles_producto]\r\n  FROM [PRUEBA_C].[dbo].[PRODUCTO] WHERE [id_tipo_producto] = {this.cmbTipProduct.SelectedValue.ToString()} ORDER BY [id_producto] ASC;", sqlConnection);

                            sqlConnection.Open();

                            SqlDataAdapter sqlReader = new SqlDataAdapter(sqlCmd_x);

                            var datamart = new DataTable();

                            sqlReader.Fill(datamart);

                            DTGRProducts.DataSource = datamart;
                            sqlConnection.Close();
                        }

                     
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        
                    }



                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                
                }

          

            }




        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {

                e.Handled = true;
            }
        }

        private void Txtprecioproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
              
                e.Handled = true;
            }

        }
    }
}
