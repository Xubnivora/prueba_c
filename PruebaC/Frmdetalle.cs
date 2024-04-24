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
                            SqlCommand sqlCmd_x = new SqlCommand($"SELECT OP.[id_inventario],OP.[nombre_metodologia] FROM [PRUEBA_C].[dbo].[METODOLOGIA_INVENTARIO] AS OP  ORDER BY OP.id_inventario ASC;", sqlConnection);

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


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var operation = new List<Productype>();

                Int16 numero = 0;

                Int32 cantidad = 0;
                Decimal valor_unitario = 0;
                Decimal total = 0;



                if (this.cmbKardex.SelectedValue.ToString().Equals("PruebaC.Productype") == false)
                {

                    connection.Open();

                    try
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            SqlCommand sqlCmd_x = new SqlCommand($"SELECT TOP 1 [saldos_cantidad],[saldos_valor_unitario],[saldos_valor_total] FROM [PRUEBA_C].[dbo].[KARDEX_DETALLE] WHERE [id_kardex] = {this.cmbKardex.SelectedValue.ToString()} ORDER BY  [fecha] DESC;", sqlConnection);

                            sqlConnection.Open();


                            SqlDataReader sqlReader = sqlCmd_x.ExecuteReader();

 

                            while (sqlReader.Read())
                            {
                                numero++;
                                cantidad =  sqlReader.GetInt32(0);
                                valor_unitario = Decimal.Parse( sqlReader.GetSqlDecimal(1).ToString());
                                total = Decimal.Parse(sqlReader.GetSqlDecimal(2).ToString());

                            }

                            if (numero == 0){

                                cantidad = 0;
                                valor_unitario = 0;
                                total =0;

                            }

                            this.txtSaldosUnit.Text = cantidad.ToString();
                            this.txtSaldoscosto.Text = valor_unitario.ToString();
                            this.txtSaldostotal.Text = total.ToString();


                            sqlReader.Close();




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

            if (this.cmbOperacion.SelectedValue.ToString().Equals("1") == true)
            {

                if (txtEntradaUnit.Text.Length > 0 && txtEntradavalorUnit.Text.Length > 0 && txtEntradavalorTot.Text.Length > 0)
                {

                    String connectionString = "Server=LAPTOP-DIJC1E1E\\SQLEXPRESS;Database=PRUEBAREST;Integrated Security=SSPI;Trusted_Connection=True;";

                    try
                    {

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();


                            float suma_valor = 0;
                            float suma_unidad = 0;
                            float suma_total = 0;


                            suma_unidad = float.Parse(txtEntradaUnit.Text) + float.Parse(txtSaldosUnit.Text);

                            suma_valor = float.Parse(txtEntradavalorUnit.Text) + float.Parse(txtSaldoscosto.Text);

                            suma_total = float.Parse(txtEntradavalorTot.Text) + float.Parse(txtSaldostotal.Text);

                            SqlCommand cmd = new SqlCommand("INSERT INTO [PRUEBA_C].[dbo].[KARDEX_DETALLE]([id_detalle_kardex],[fecha],[id_kardex],[id_tipo_operacion],[entrada_cantidad],[entrada_valor_unitario],[entrada_valor_total],[saldos_cantidad],[saldos_valor_unitario],[saldos_valor_total])\r\nVALUES (1,GETDATE(),@id_kardex,@id_tipo_operacion ,@entrada_cantidad ,@entrada_valor_unitario,@entrada_valor_total,@entrada_cantidad_total,@entrada_valor_unitario_total,@entrada_valor_total_total)", con);

                            cmd.Parameters.AddWithValue("@id_kardex", this.cmbKardex.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@id_tipo_operacion", this.cmbAccion.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@entrada_cantidad", this.txtEntradaUnit.Text);
                            cmd.Parameters.AddWithValue("@entrada_valor_unitario", this.txtEntradavalorUnit.Text);
                            cmd.Parameters.AddWithValue("@entrada_valor_total", this.txtEntradavalorTot.Text);

                            cmd.Parameters.AddWithValue("@entrada_cantidad_total", suma_unidad.ToString());
                            cmd.Parameters.AddWithValue("@entrada_valor_unitario_total", suma_valor.ToString());
                            cmd.Parameters.AddWithValue("@entrada_valor_total_total", suma_total.ToString());



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

            if (this.cmbOperacion.SelectedValue.ToString().Equals("3") == true)
            {

                if (txtEntradaUnit.Text.Length > 0 && txtEntradavalorUnit.Text.Length > 0 && txtEntradavalorTot.Text.Length > 0)
                {

                    String connectionString = "Server=LAPTOP-DIJC1E1E\\SQLEXPRESS;Database=PRUEBAREST;Integrated Security=SSPI;Trusted_Connection=True;";


                    float suma_valor = 0;
                    float suma_unidad = 0;
                    float suma_total = 0;

                    suma_unidad = float.Parse(txtEntradaUnit.Text) + float.Parse(txtSaldosUnit.Text);

                    suma_valor = float.Parse(txtEntradavalorUnit.Text) + float.Parse(txtSaldoscosto.Text);

                    suma_total = float.Parse(txtEntradavalorTot.Text) + float.Parse(txtSaldostotal.Text);

                    try
                    {

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();


                            SqlCommand cmd = new SqlCommand("INSERT INTO [PRUEBA_C].[dbo].[KARDEX_DETALLE]([id_detalle_kardex],[fecha],[id_kardex],[id_tipo_operacion],[entrada_cantidad],[entrada_valor_unitario],[entrada_valor_total],[saldos_cantidad],[saldos_valor_unitario],[saldos_valor_total])\r\nVALUES (1,GETDATE(),@id_kardex,@id_tipo_operacion ,@entrada_cantidad ,@entrada_valor_unitario,@entrada_valor_total,@entrada_cantidad_total,@entrada_valor_unitario_total,@entrada_valor_total_total)", con);

                            cmd.Parameters.AddWithValue("@id_kardex", this.cmbKardex.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@id_tipo_operacion", this.cmbAccion.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@entrada_cantidad", this.txtEntradaUnit.Text);
                            cmd.Parameters.AddWithValue("@entrada_valor_unitario", this.txtEntradavalorUnit.Text);
                            cmd.Parameters.AddWithValue("@entrada_valor_total", this.txtEntradavalorTot.Text);

                            cmd.Parameters.AddWithValue("@entrada_cantidad_total", suma_unidad.ToString());
                            cmd.Parameters.AddWithValue("@entrada_valor_unitario_total", suma_valor.ToString());
                            cmd.Parameters.AddWithValue("@entrada_valor_total_total", suma_total.ToString());


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

            if (this.cmbOperacion.SelectedValue.ToString().Equals("2") == true)
            {

                if (txtSalidaUnit.Text.Length > 0 && txtSalidaValorUnit.Text.Length > 0 && txtSalidaValorTotal.Text.Length > 0)
                {

                    String connectionString = "Server=LAPTOP-DIJC1E1E\\SQLEXPRESS;Database=PRUEBAREST;Integrated Security=SSPI;Trusted_Connection=True;";


                    float suma_valor = 0;
                    float suma_unidad = 0;
                    float suma_total = 0;

                    suma_unidad = float.Parse(txtSaldosUnit.Text) - float.Parse(txtSalidaUnit.Text); 

                    suma_valor = float.Parse(txtSaldoscosto.Text) - float.Parse(txtSalidaValorUnit.Text); 

                    suma_total = float.Parse(txtSaldostotal.Text) - float.Parse(txtSalidaValorTotal.Text); 

                    if ((suma_unidad > 0) && (suma_valor > 0) && (suma_total > 0))
                    {

                        try
                        {

                            using (SqlConnection con = new SqlConnection(connectionString))
                            {
                                con.Open();


                                SqlCommand cmd = new SqlCommand("INSERT INTO [PRUEBA_C].[dbo].[KARDEX_DETALLE]([id_detalle_kardex],[fecha],[id_kardex],[id_tipo_operacion],[salida_cantidad],[salida_valor_unitario],[salida_valor_total],[saldos_cantidad],[saldos_valor_unitario],[saldos_valor_total])\r\nVALUES (1,GETDATE(),@id_kardex,@id_tipo_operacion ,@salida_cantidad ,@salida_valor_unitario,@salida_valor_total,@salida_cantidad_total,@salida_valor_unitario_total,@salida_valor_total_total)", con);

                                cmd.Parameters.AddWithValue("@id_kardex", this.cmbKardex.SelectedValue.ToString());
                                cmd.Parameters.AddWithValue("@id_tipo_operacion", this.cmbAccion.SelectedValue.ToString());
                                cmd.Parameters.AddWithValue("@salida_cantidad", this.txtEntradaUnit.Text);
                                cmd.Parameters.AddWithValue("@salida_valor_unitario", this.txtEntradavalorUnit.Text);
                                cmd.Parameters.AddWithValue("@salida_valor_total", this.txtEntradavalorTot.Text);

                                cmd.Parameters.AddWithValue("@salida_cantidad_total", suma_unidad.ToString());
                                cmd.Parameters.AddWithValue("@salida_valor_unitario_total", suma_valor.ToString());
                                cmd.Parameters.AddWithValue("@salida_valor_total_total", suma_total.ToString());


                                cmd.ExecuteNonQuery();

                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());

                        }
                    }
                    else { Console.WriteLine("No se permiten valores negativos"); }

                }

            }

        }

        private void txtEntradaUnit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEntradavalorUnit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSalidaUnit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSalidaValorUnit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEntradaUnit_TextChanged(object sender, EventArgs e)
        {
   
            if ((txtEntradaUnit.Text.Length > 0) && (txtEntradavalorUnit.Text.Length > 0)) {

  
                txtEntradavalorTot.Text = (float.Parse(txtEntradaUnit.Text)* float.Parse(txtEntradavalorUnit.Text)).ToString();



            }

        }

        private void txtEntradavalorUnit_TextChanged(object sender, EventArgs e)
        {
            if ((txtEntradaUnit.Text.Length > 0) && (txtEntradavalorUnit.Text.Length > 0))
            {


                txtEntradavalorTot.Text = (float.Parse(txtEntradaUnit.Text) * float.Parse(txtEntradavalorUnit.Text)).ToString();

            }

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbOperacion.SelectedValue.ToString().Equals("1") == true)
            {

                this.txtSalidaUnit.Text = "0";

                this.txtSalidaValorUnit.Text = "0";

                this.txtEntradaUnit.ReadOnly = false;

                this.txtEntradavalorUnit.ReadOnly = false;


                this.txtSalidaUnit.ReadOnly = true;

                this.txtSalidaValorUnit.ReadOnly = true;


            }


            if (this.cmbOperacion.SelectedValue.ToString().Equals("2") == true)
            {


                this.txtEntradaUnit.Text = "0";

                this.txtEntradavalorUnit.Text = "0";

                this.txtEntradaUnit.ReadOnly = true;

                this.txtEntradavalorUnit.ReadOnly = true;


                this.txtSalidaUnit.ReadOnly = false; 

                this.txtSalidaValorUnit.ReadOnly = false;
            }

            if (this.cmbOperacion.SelectedValue.ToString().Equals("3") == true)
            {

                this.txtSalidaUnit.Text = "0";

                this.txtSalidaValorUnit.Text = "0";

                this.txtEntradaUnit.ReadOnly = false;

                this.txtEntradavalorUnit.ReadOnly = false;

                this.txtSalidaUnit.ReadOnly = true;

                this.txtSalidaValorUnit.ReadOnly = true;


            }


        }

        private void txtSalidaUnit_TextChanged(object sender, EventArgs e)
        {
            if ((this.txtSalidaUnit.Text.Length > 0) && (this.txtSalidaValorUnit.Text.Length > 0))
            {

                txtSalidaValorTotal.Text = (float.Parse(txtSalidaValorUnit.Text) * float.Parse(this.txtSalidaUnit.Text)).ToString(); 

            }
        }

        private void txtSalidaValorUnit_TextChanged(object sender, EventArgs e)
        {
            if ((this.txtSalidaUnit.Text.Length > 0) && (this.txtSalidaValorUnit.Text.Length > 0))
            {
                
                txtSalidaValorTotal.Text = (float.Parse(txtSalidaValorUnit.Text) * float.Parse(this.txtSalidaUnit.Text)).ToString();

            }
        }
    }
    }
