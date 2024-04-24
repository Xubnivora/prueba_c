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

namespace PruebaC
{
    public partial class Frmdetalle : Form
    {
        public Frmdetalle()
        {
            InitializeComponent();
        }

        private void Frmdetalle_Load(object sender, EventArgs e)
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
                        SqlCommand sqlCmd = new SqlCommand("SELECT [id_kardex] as id_kardexes ,Convert(varchar(32),[id_kardex])+' - '+Convert(varchar(32),fecha_creacion) as det_kardexes FROM [PRUEBA_C].[dbo].[KARDEX_ENCABEZADO]", sqlConnection);

                        sqlConnection.Open();
                        SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                        while (sqlReader.Read())
                        {

                            productype.Add(new Productype(sqlReader.GetInt32(0), sqlReader.GetString(1)));



                        }
                        sqlReader.Close();
                        this.cmbKardex.DataSource = productype;
                        this.cmbKardex.DisplayMember = "Nombre";
                        this.cmbKardex.ValueMember = "Valor";
                        this.cmbKardex.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    connection.Close();
                }
                connection.Close();
            }

            var operation = new List<Productype>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        SqlCommand sqlCmd = new SqlCommand("SELECT [id_tipo_operacion],[nombre_operacion] FROM [PRUEBA_C].[dbo].[TIPO_OPERACION] ORDER BY nombre_operacion ASC;", sqlConnection);

                        sqlConnection.Open();
                        SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                        while (sqlReader.Read())
                        {

                            operation.Add(new Productype(sqlReader.GetInt32(0), sqlReader.GetString(1)));

                        }
                        sqlReader.Close();
                        this.cmbOperacion.DataSource = operation;
                        this.cmbOperacion.DisplayMember = "Nombre";
                        this.cmbOperacion.ValueMember = "Valor";
                        this.cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void cmbKardex_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produc = new List<Productype>();

            String connectionString = "Server=LAPTOP-DIJC1E1E\\SQLEXPRESS;Database=PRUEBAREST;Integrated Security=SSPI;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                if (this.cmbKardex.SelectedValue.ToString().Equals("PruebaC.Productype") == false)
                {

                    connection.Open();

                    try
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            SqlCommand sqlCmd_x = new SqlCommand($"SELECT PR.id_producto,PR.nombre_producto FROM [PRUEBA_C].[dbo].[PRODUCTO] AS PR INNER JOIN [PRUEBA_C].[dbo].[KARDEX_ENCABEZADO] KAE ON (KAE.id_producto = PR.id_producto)  WHERE KAE.id_kardex = {this.cmbKardex.SelectedValue.ToString()} ORDER BY PR.nombre_producto ASC;", sqlConnection);

                            sqlConnection.Open();


                            SqlDataReader sqlReader = sqlCmd_x.ExecuteReader();



                            while (sqlReader.Read())
                            {

                                produc.Add(new Productype(sqlReader.GetInt32(0), sqlReader.GetString(1)));

                            }
                            sqlReader.Close();
                            this.cmbProducto.DataSource = produc;
                            this.cmbProducto.DisplayMember = "Nombre";
                            this.cmbProducto.ValueMember = "Valor";
                            this.cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;



                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        connection.Close();
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var bodega = new List<Productype>();

                if (this.cmbKardex.SelectedValue.ToString().Equals("PruebaC.Productype") == false)
                {

                    connection.Open();

                    try
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            SqlCommand sqlCmd_x = new SqlCommand($"SELECT BD.id_bodega,Convert(varchar(32),BD.id_bodega)+' - '+Convert(varchar(32),BD.direccion) FROM [PRUEBA_C].[dbo].[BODEGA] AS BD INNER JOIN [PRUEBA_C].[dbo].[KARDEX_ENCABEZADO] KAE ON (KAE.id_bodega = BD.id_bodega)  WHERE KAE.id_kardex = {this.cmbKardex.SelectedValue.ToString()} ORDER BY BD.id_bodega ASC;", sqlConnection);

                            sqlConnection.Open();


                            SqlDataReader sqlReader = sqlCmd_x.ExecuteReader();



                            while (sqlReader.Read())
                            {

                                bodega.Add(new Productype(sqlReader.GetInt32(0), sqlReader.GetString(1)));

                            }
                            sqlReader.Close();
                            this.cmbBodega.DataSource = bodega;
                            this.cmbBodega.DisplayMember = "Nombre";
                            this.cmbBodega.ValueMember = "Valor";
                            this.cmbBodega.DropDownStyle = ComboBoxStyle.DropDownList;



                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        connection.Close();
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var operation = new List<Productype>();

                if (this.cmbKardex.SelectedValue.ToString().Equals("PruebaC.Productype") == false)
                {

                    connection.Open();

                    try
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            SqlCommand sqlCmd_x = new SqlCommand($"SELECT OP.[id_inventario],OP.[nombre_metodologia] FROM [PRUEBA_C].[dbo].[METODOLOGIA_INVENTARIO] AS OP INNER JOIN [PRUEBA_C].[dbo].[KARDEX_ENCABEZADO] KAE ON (KAE.id_metodo = OP.id_inventario)  WHERE KAE.id_kardex = {this.cmbKardex.SelectedValue.ToString()} ORDER BY OP.id_inventario ASC;", sqlConnection);

                            sqlConnection.Open();


                            SqlDataReader sqlReader = sqlCmd_x.ExecuteReader();



                            while (sqlReader.Read())
                            {

                                operation.Add(new Productype(sqlReader.GetInt32(0), sqlReader.GetString(1)));

                            }
                            sqlReader.Close();
                            this.cmbAccion.DataSource = operation;
                            this.cmbAccion.DisplayMember = "Nombre";
                            this.cmbAccion.ValueMember = "Valor";
                            this.cmbAccion.DropDownStyle = ComboBoxStyle.DropDownList;



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

        private void cmbOperacion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbKardex.SelectedValue.ToString().Equals("1") == true)
            {

                this.txtEntradaUnit.Enabled = true;
                this.txtEntradavalorUnit.Enabled = true;
                this.txtEntradavalorTot.Enabled = true;

                this.txtSalidaUnit.Enabled = false;
                this.txtSalidaValorUnit.Enabled = false;
                this.txtSalidaValorTotal.Enabled = false;
            }

            if (this.cmbKardex.SelectedValue.ToString().Equals("2") == true)
            {

                this.txtEntradaUnit.Enabled = false;
                this.txtEntradavalorUnit.Enabled = false;
                this.txtEntradavalorTot.Enabled = false;

                this.txtSalidaUnit.Enabled = true;
                this.txtSalidaValorUnit.Enabled = true;
                this.txtSalidaValorTotal.Enabled = true;


            }
            if (this.cmbKardex.SelectedValue.ToString().Equals("3") == true)
            {
                this.txtEntradaUnit.Enabled = true;
                this.txtEntradavalorUnit.Enabled = true;
                this.txtEntradavalorTot.Enabled = true;

                this.txtSalidaUnit.Enabled = false;
                this.txtSalidaValorUnit.Enabled = false;
                this.txtSalidaValorTotal.Enabled = false;

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (this.cmbKardex.SelectedValue.ToString().Equals("1") == true)
            {

                if (txtEntradaUnit.Text.Length > 0 && txtEntradavalorUnit.Text.Length > 0 && txtEntradavalorTot.Text.Length > 0)
                {

                    String connectionString = "Server=LAPTOP-DIJC1E1E\\SQLEXPRESS;Database=PRUEBAREST;Integrated Security=SSPI;Trusted_Connection=True;";

                    try
                    {

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();


                            SqlCommand cmd = new SqlCommand("INSERT INTO [PRUEBA_C].[dbo].[KARDEX_DETALLE]([fecha],[id_kardex],[id_tipo_operacion],[entrada_cantidad],[entrada_valor_unitario],[entrada_valor_total])\r\nVALUES (GETDATE(),@id_kardex,@id_tipo_operacion ,@entrada_cantidad ,@entrada_valor_unitario,@entrada_valor_total)", con);

                            cmd.Parameters.AddWithValue("@id_kardex", this.cmbKardex.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@id_tipo_operacion", this.cmbAccion.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@entrada_cantidad", this.txtEntradaUnit.Text);
                            cmd.Parameters.AddWithValue("@entrada_valor_unitario", this.txtEntradavalorUnit.Text);
                            cmd.Parameters.AddWithValue("@entrada_valor_total", this.txtEntradavalorTot.Text);
    

                            cmd.ExecuteNonQuery();

                            con.Close();
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
