namespace PruebaC
{
    partial class FormEncCardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEncCardex));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipProduct = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.CmbBodega = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoteser = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKardex = new System.Windows.Forms.TextBox();
            this.Cmbmetod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DatGKardex = new System.Windows.Forms.DataGridView();
            this.Btnagreagar = new System.Windows.Forms.Button();
            this.cmbFolio = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatGKardex)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFolio);
            this.groupBox1.Controls.Add(this.Btnagreagar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Cmbmetod);
            this.groupBox1.Controls.Add(this.txtKardex);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLote);
            this.groupBox1.Controls.Add(this.txtLoteser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbBodega);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.cmbTipProduct);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Encabezado de Cardex";
            // 
            // cmbTipProduct
            // 
            this.cmbTipProduct.FormattingEnabled = true;
            this.cmbTipProduct.Location = new System.Drawing.Point(6, 55);
            this.cmbTipProduct.Name = "cmbTipProduct";
            this.cmbTipProduct.Size = new System.Drawing.Size(167, 21);
            this.cmbTipProduct.TabIndex = 0;
            this.cmbTipProduct.SelectedValueChanged += new System.EventHandler(this.cmbTipProduct_SelectedValueChanged);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(189, 55);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(169, 21);
            this.cmbProduct.TabIndex = 1;
            // 
            // CmbBodega
            // 
            this.CmbBodega.FormattingEnabled = true;
            this.CmbBodega.Location = new System.Drawing.Point(376, 55);
            this.CmbBodega.Name = "CmbBodega";
            this.CmbBodega.Size = new System.Drawing.Size(121, 21);
            this.CmbBodega.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "bodega";
            // 
            // txtLoteser
            // 
            this.txtLoteser.Location = new System.Drawing.Point(517, 55);
            this.txtLoteser.Name = "txtLoteser";
            this.txtLoteser.Size = new System.Drawing.Size(100, 20);
            this.txtLoteser.TabIndex = 6;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(636, 54);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(100, 20);
            this.txtLote.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Serie Lote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lote";
            // 
            // txtKardex
            // 
            this.txtKardex.Location = new System.Drawing.Point(10, 109);
            this.txtKardex.Name = "txtKardex";
            this.txtKardex.Size = new System.Drawing.Size(163, 20);
            this.txtKardex.TabIndex = 10;
            // 
            // Cmbmetod
            // 
            this.Cmbmetod.FormattingEnabled = true;
            this.Cmbmetod.Location = new System.Drawing.Point(376, 107);
            this.Cmbmetod.Name = "Cmbmetod";
            this.Cmbmetod.Size = new System.Drawing.Size(121, 21);
            this.Cmbmetod.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id kardex";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Id Folio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Metodología de inventario";
            // 
            // DatGKardex
            // 
            this.DatGKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatGKardex.Location = new System.Drawing.Point(12, 208);
            this.DatGKardex.Name = "DatGKardex";
            this.DatGKardex.Size = new System.Drawing.Size(776, 176);
            this.DatGKardex.TabIndex = 1;
            // 
            // Btnagreagar
            // 
            this.Btnagreagar.Location = new System.Drawing.Point(529, 107);
            this.Btnagreagar.Name = "Btnagreagar";
            this.Btnagreagar.Size = new System.Drawing.Size(207, 23);
            this.Btnagreagar.TabIndex = 16;
            this.Btnagreagar.Text = "Agreagar";
            this.Btnagreagar.UseVisualStyleBackColor = true;
            this.Btnagreagar.Click += new System.EventHandler(this.Btnagreagar_Click);
            // 
            // cmbFolio
            // 
            this.cmbFolio.FormattingEnabled = true;
            this.cmbFolio.Location = new System.Drawing.Point(192, 108);
            this.cmbFolio.Name = "cmbFolio";
            this.cmbFolio.Size = new System.Drawing.Size(166, 21);
            this.cmbFolio.TabIndex = 17;
            // 
            // FormEncCardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatGKardex);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEncCardex";
            this.Text = "FormEncCardex";
            this.Load += new System.EventHandler(this.FormEncCardex_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatGKardex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbBodega;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbTipProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmbmetod;
        private System.Windows.Forms.TextBox txtKardex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.TextBox txtLoteser;
        private System.Windows.Forms.DataGridView DatGKardex;
        private System.Windows.Forms.Button Btnagreagar;
        private System.Windows.Forms.ComboBox cmbFolio;
    }
}