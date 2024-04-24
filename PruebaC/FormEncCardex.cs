using System;
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

namespace PruebaC
{
    public partial class FormEncCardex : Form
    {
        public FormEncCardex()
        {
            InitializeComponent();
        }

        private void FormEncCardex_Load(object sender, EventArgs e)
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


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var productypo = new List<Productype>();

                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        SqlCommand sqlCmd = new SqlCommand("SELECT [id_tipo_producto],[nombre_tipo_producto] FROM [PRUEBA_C].[dbo].[TIPO_PRODUCTO] ORDER BY nombre_tipo_producto ASC;", sqlConnection);

                        sqlConnection.Open();
                        SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                        while (sqlReader.Read())
                        {

                            productypo.Add(new Productype(sqlReader.GetInt32(0), sqlReader.GetString(1)));

                        }
                        sqlReader.Close();
                        this.cmbTipProduct.DataSource = productypo;
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

            

           using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var foliuos = new List<Productype>();
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        SqlCommand sqlCmd = new SqlCommand("SELECT [id_folio] AS keyine,CONVERT(VARCHAR(32),[id_folio]) AS foloiis FROM [PRUEBA_C].[dbo].[FOLIO] ORDER BY  keyine ASC;", sqlConnection);

                        sqlConnection.Open();
                        SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                        while (sqlReader.Read())
                        {

                            foliuos.Add(new Productype(sqlReader.GetInt32(0), sqlReader.GetString(1)));

                        }
                        sqlReader.Close();
                        this.cmbFolio.DataSource = foliuos;
                        this.cmbFolio.DisplayMember = "Nombre";
                        this.cmbFolio.ValueMember = "Valor";
                        this.cmbFolio.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    connection.Close();
                }
                connection.Close();
            }



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var productypi = new List<Productype>();
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        SqlCommand sqlCmd = new SqlCommand("SELECT [id_bodega],[direccion]FROM [PRUEBA_C].[dbo].[BODEGA] ORDER BY [direccion] ASC;", sqlConnection);

                        sqlConnection.Open();
                        SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                        while (sqlReader.Read())
                        {

                            productypi.Add(new Productype(sqlReader.GetInt32(0), sqlReader.GetString(1)));

                        }
                        sqlReader.Close();
                        this.CmbBodega.DataSource = productypi;
                        this.CmbBodega.DisplayMember = "Nombre";
                        this.CmbBodega.ValueMember = "Valor";
                        this.CmbBodega.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    connection.Close();
                }
                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var productypu = new List<Productype>();
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        SqlCommand sqlCmd = new SqlCommand("SELECT [id_inventario], [nombre_metodologia] FROM [PRUEBA_C].[dbo].[METODOLOGIA_INVENTARIO] ORDER BY [nombre_metodologia] ASC;", sqlConnection);

                        sqlConnection.Open();
                        SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                        while (sqlReader.Read())
                        {

                            productypu.Add(new Productype(sqlReader.GetInt32(0), sqlReader.GetString(1)));

                        }
                        sqlReader.Close();
                        this.Cmbmetod.DataSource = productypu;
                        this.Cmbmetod.DisplayMember = "Nombre";
                        this.Cmbmetod.ValueMember = "Valor";
                        this.Cmbmetod.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    connection.Close();
                }
                connection.Close();
            }

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCmd_x = new SqlCommand($"SELECT [id_kardex],[id_folio],[id_producto],[serie_lote] as LOTE_SRIE ,[id_lote] AS ID_LOTE,[id_bodega],[id_metodo],[fecha_creacion] FROM [PRUEBA_C].[dbo].[KARDEX_ENCABEZADO] WHERE [id_producto] = {this.cmbProduct.SelectedValue.ToString()} ORDER BY [id_producto] ASC;", sqlConnection);

                    sqlConnection.Open();

                    SqlDataAdapter sqlReader = new SqlDataAdapter(sqlCmd_x);

                    var datamart = new DataTable();

                    sqlReader.Fill(datamart);

                    DatGKardex.DataSource = datamart;
                    sqlConnection.Close();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

        }

        private void cmbTipProduct_SelectedValueChanged(object sender, EventArgs e)
        {

            var produc = new List<Productype>();

            String connectionString = "Server=LAPTOP-DIJC1E1E\\SQLEXPRESS;Database=PRUEBAREST;Integrated Security=SSPI;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                if (this.cmbTipProduct.SelectedValue.ToString().Equals("PruebaC.Productype") == false)
                {

                    connection.Open();

                    try
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            SqlCommand sqlCmd_x = new SqlCommand($"SELECT [id_producto],[nombre_producto] FROM [PRUEBA_C].[dbo].[PRODUCTO] WHERE [id_tipo_producto] = {this.cmbTipProduct.SelectedValue.ToString()} ORDER BY [nombre_producto] ASC;", sqlConnection);

                            sqlConnection.Open();


                            SqlDataReader sqlReader = sqlCmd_x.ExecuteReader();



                            while (sqlReader.Read())
                            {

                                produc.Add(new Productype(sqlReader.GetInt32(0), sqlReader.GetString(1)));

                            }
                            sqlReader.Close();
                            this.cmbProduct.DataSource = produc;
                            this.cmbProduct.DisplayMember = "Nombre";
                            this.cmbProduct.ValueMember = "Valor";
                            this.cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;



                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        connection.Close();
                    }
                }
            }
        }

        private void Btnagreagar_Click(object sender, EventArgs e)
        {

            if (txtLoteser.Text.Length > 0 && txtLote.Text.Length > 0  && txtKardex.Text.Length > 0 )
            {

                String connectionString = "Server=LAPTOP-DIJC1E1E\\SQLEXPRESS;Database=PRUEBAREST;Integrated Security=SSPI;Trusted_Connection=True;";

                try
                {

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();


                        SqlCommand cmd = new SqlCommand("INSERT INTO [PRUEBA_C].[dbo].[KARDEX_ENCABEZADO]([id_kardex],[id_folio],[id_producto],[serie_lote],[id_lote],[id_bodega],[id_metodo] ,[fecha_creacion])\r\nVALUES (@id_kardex,@id_folio,@id_producto ,@serie_lote ,@id_lote,@id_bodega,@id_metodo,GETDATE())", con);
                        
                        cmd.Parameters.AddWithValue("@id_producto", this.cmbProduct.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@id_tipo_producto", this.cmbTipProduct.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@id_kardex", this.txtKardex.Text);
                        cmd.Parameters.AddWithValue("@serie_lote", this.txtLoteser.Text);
                        cmd.Parameters.AddWithValue("@id_lote", this.txtLote.Text);
                        cmd.Parameters.AddWithValue("@id_folio", this.cmbFolio.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@id_bodega", this.CmbBodega.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@id_metodo", this.Cmbmetod.SelectedValue.ToString());

                        cmd.ExecuteNonQuery();

                        con.Close();
                    }

                    try
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            SqlCommand sqlCmd_x = new SqlCommand($"SELECT [id_kardex],[id_folio],[id_producto],[serie_lote] as LOTE_SRIE ,[id_lote] AS ID_LOTE,[id_bodega],[id_metodo],[fecha_creacion] FROM [PRUEBA_C].[dbo].[KARDEX_ENCABEZADO] WHERE [id_producto] = {this.cmbProduct.SelectedValue.ToString()} ORDER BY [id_producto] ASC;", sqlConnection);

                            sqlConnection.Open();

                            SqlDataAdapter sqlReader = new SqlDataAdapter(sqlCmd_x);

                            var datamart = new DataTable();

                            sqlReader.Fill(datamart);

                            DatGKardex.DataSource = datamart;
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





    }
    }
