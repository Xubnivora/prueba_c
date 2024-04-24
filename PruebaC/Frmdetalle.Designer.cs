namespace PruebaC
{
    partial class Frmdetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdetalle));
            this.cmbKardex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.txtEntradaUnit = new System.Windows.Forms.TextBox();
            this.txtEntradavalorUnit = new System.Windows.Forms.TextBox();
            this.txtEntradavalorTot = new System.Windows.Forms.TextBox();
            this.txtSalidaUnit = new System.Windows.Forms.TextBox();
            this.txtSalidaValorUnit = new System.Windows.Forms.TextBox();
            this.txtSalidaValorTotal = new System.Windows.Forms.TextBox();
            this.txtSaldosUnit = new System.Windows.Forms.TextBox();
            this.txtSaldoscosto = new System.Windows.Forms.TextBox();
            this.txtSaldostotal = new System.Windows.Forms.TextBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKardex
            // 
            this.cmbKardex.FormattingEnabled = true;
            this.cmbKardex.Location = new System.Drawing.Point(12, 41);
            this.cmbKardex.Name = "cmbKardex";
            this.cmbKardex.Size = new System.Drawing.Size(179, 21);
            this.cmbKardex.TabIndex = 0;
            this.cmbKardex.SelectedIndexChanged += new System.EventHandler(this.cmbKardex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID KARDEX";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(233, 41);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(12, 99);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(121, 21);
            this.cmbOperacion.TabIndex = 4;
            this.cmbOperacion.SelectedValueChanged += new System.EventHandler(this.cmbOperacion_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de operacion";
            // 
            // cmbBodega
            // 
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(403, 40);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(188, 21);
            this.cmbBodega.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bodega";
            // 
            // cmbAccion
            // 
            this.cmbAccion.FormattingEnabled = true;
            this.cmbAccion.Location = new System.Drawing.Point(616, 41);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(121, 21);
            this.cmbAccion.TabIndex = 8;
            // 
            // txtEntradaUnit
            // 
            this.txtEntradaUnit.Location = new System.Drawing.Point(149, 116);
            this.txtEntradaUnit.Name = "txtEntradaUnit";
            this.txtEntradaUnit.Size = new System.Drawing.Size(84, 20);
            this.txtEntradaUnit.TabIndex = 9;
            // 
            // txtEntradavalorUnit
            // 
            this.txtEntradavalorUnit.Location = new System.Drawing.Point(269, 116);
            this.txtEntradavalorUnit.Name = "txtEntradavalorUnit";
            this.txtEntradavalorUnit.Size = new System.Drawing.Size(100, 20);
            this.txtEntradavalorUnit.TabIndex = 10;
            // 
            // txtEntradavalorTot
            // 
            this.txtEntradavalorTot.Location = new System.Drawing.Point(403, 116);
            this.txtEntradavalorTot.Name = "txtEntradavalorTot";
            this.txtEntradavalorTot.Size = new System.Drawing.Size(100, 20);
            this.txtEntradavalorTot.TabIndex = 11;
            // 
            // txtSalidaUnit
            // 
            this.txtSalidaUnit.Location = new System.Drawing.Point(149, 173);
            this.txtSalidaUnit.Name = "txtSalidaUnit";
            this.txtSalidaUnit.Size = new System.Drawing.Size(84, 20);
            this.txtSalidaUnit.TabIndex = 12;
            // 
            // txtSalidaValorUnit
            // 
            this.txtSalidaValorUnit.Location = new System.Drawing.Point(269, 173);
            this.txtSalidaValorUnit.Name = "txtSalidaValorUnit";
            this.txtSalidaValorUnit.Size = new System.Drawing.Size(99, 20);
            this.txtSalidaValorUnit.TabIndex = 13;
            // 
            // txtSalidaValorTotal
            // 
            this.txtSalidaValorTotal.Location = new System.Drawing.Point(403, 173);
            this.txtSalidaValorTotal.Name = "txtSalidaValorTotal";
            this.txtSalidaValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSalidaValorTotal.TabIndex = 14;
            // 
            // txtSaldosUnit
            // 
            this.txtSaldosUnit.Location = new System.Drawing.Point(149, 222);
            this.txtSaldosUnit.Name = "txtSaldosUnit";
            this.txtSaldosUnit.ReadOnly = true;
            this.txtSaldosUnit.Size = new System.Drawing.Size(84, 20);
            this.txtSaldosUnit.TabIndex = 15;
            // 
            // txtSaldoscosto
            // 
            this.txtSaldoscosto.Location = new System.Drawing.Point(268, 222);
            this.txtSaldoscosto.Name = "txtSaldoscosto";
            this.txtSaldoscosto.ReadOnly = true;
            this.txtSaldoscosto.Size = new System.Drawing.Size(99, 20);
            this.txtSaldoscosto.TabIndex = 16;
            // 
            // txtSaldostotal
            // 
            this.txtSaldostotal.Location = new System.Drawing.Point(403, 222);
            this.txtSaldostotal.Name = "txtSaldostotal";
            this.txtSaldostotal.ReadOnly = true;
            this.txtSaldostotal.Size = new System.Drawing.Size(100, 20);
            this.txtSaldostotal.TabIndex = 17;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(15, 79);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(85, 13);
            this.lblAccion.TabIndex = 18;
            this.lblAccion.Text = "Accion a realizar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Entrada unidades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Entrada valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "EntradaValor Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Salida Unidades";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Salida Valor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Salida Saldo Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(149, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Saldo Cantidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Saldo Valor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(405, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Saldo Total";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(616, 138);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 44);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Frmdetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.txtSaldostotal);
            this.Controls.Add(this.txtSaldoscosto);
            this.Controls.Add(this.txtSaldosUnit);
            this.Controls.Add(this.txtSalidaValorTotal);
            this.Controls.Add(this.txtSalidaValorUnit);
            this.Controls.Add(this.txtSalidaUnit);
            this.Controls.Add(this.txtEntradavalorTot);
            this.Controls.Add(this.txtEntradavalorUnit);
            this.Controls.Add(this.txtEntradaUnit);
            this.Controls.Add(this.cmbAccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBodega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKardex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmdetalle";
            this.Text = "Frmdetalle";
            this.Load += new System.EventHandler(this.Frmdetalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKardex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.TextBox txtEntradaUnit;
        private System.Windows.Forms.TextBox txtEntradavalorUnit;
        private System.Windows.Forms.TextBox txtEntradavalorTot;
        private System.Windows.Forms.TextBox txtSalidaUnit;
        private System.Windows.Forms.TextBox txtSalidaValorUnit;
        private System.Windows.Forms.TextBox txtSalidaValorTotal;
        private System.Windows.Forms.TextBox txtSaldosUnit;
        private System.Windows.Forms.TextBox txtSaldoscosto;
        private System.Windows.Forms.TextBox txtSaldostotal;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGuardar;
    }
}