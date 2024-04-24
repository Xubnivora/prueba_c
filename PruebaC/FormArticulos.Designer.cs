namespace PruebaC
{
    partial class FormArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticulos));
            this.cmbTipProduct = new System.Windows.Forms.ComboBox();
            this.Txtproductname = new System.Windows.Forms.TextBox();
            this.Txtprecioproduct = new System.Windows.Forms.TextBox();
            this.Txtsku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtcodebar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.Txtdetalles = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DTGRProducts = new System.Windows.Forms.DataGridView();
            this.Btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGRProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipProduct
            // 
            this.cmbTipProduct.FormattingEnabled = true;
            this.cmbTipProduct.Location = new System.Drawing.Point(24, 68);
            this.cmbTipProduct.Name = "cmbTipProduct";
            this.cmbTipProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbTipProduct.TabIndex = 0;
            this.cmbTipProduct.SelectedValueChanged += new System.EventHandler(this.cmbTipProduct_SelectedValueChanged);
            // 
            // Txtproductname
            // 
            this.Txtproductname.Location = new System.Drawing.Point(173, 68);
            this.Txtproductname.Name = "Txtproductname";
            this.Txtproductname.Size = new System.Drawing.Size(124, 20);
            this.Txtproductname.TabIndex = 1;
            // 
            // Txtprecioproduct
            // 
            this.Txtprecioproduct.Location = new System.Drawing.Point(303, 69);
            this.Txtprecioproduct.Name = "Txtprecioproduct";
            this.Txtprecioproduct.Size = new System.Drawing.Size(100, 20);
            this.Txtprecioproduct.TabIndex = 2;
            this.Txtprecioproduct.TextChanged += new System.EventHandler(this.Txtprecioproduct_TextChanged);
            // 
            // Txtsku
            // 
            this.Txtsku.Location = new System.Drawing.Point(420, 69);
            this.Txtsku.Name = "Txtsku";
            this.Txtsku.Size = new System.Drawing.Size(100, 20);
            this.Txtsku.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio de Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SKU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo de Barras";
            // 
            // Txtcodebar
            // 
            this.Txtcodebar.Location = new System.Drawing.Point(535, 69);
            this.Txtcodebar.Name = "Txtcodebar";
            this.Txtcodebar.Size = new System.Drawing.Size(100, 20);
            this.Txtcodebar.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Peso en Kg";
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(673, 68);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(100, 20);
            this.TxtPeso.TabIndex = 11;
            this.TxtPeso.TextChanged += new System.EventHandler(this.TxtPeso_TextChanged);
            // 
            // Txtdetalles
            // 
            this.Txtdetalles.AutoSize = true;
            this.Txtdetalles.Location = new System.Drawing.Point(24, 107);
            this.Txtdetalles.Name = "Txtdetalles";
            this.Txtdetalles.Size = new System.Drawing.Size(45, 13);
            this.Txtdetalles.TabIndex = 12;
            this.Txtdetalles.Text = "Detalles";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(496, 71);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // DTGRProducts
            // 
            this.DTGRProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGRProducts.Location = new System.Drawing.Point(24, 239);
            this.DTGRProducts.Name = "DTGRProducts";
            this.DTGRProducts.Size = new System.Drawing.Size(740, 150);
            this.DTGRProducts.TabIndex = 14;
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(535, 138);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(143, 26);
            this.Btnagregar.TabIndex = 15;
            this.Btnagregar.Text = "Agreagar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.DTGRProducts);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Txtdetalles);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txtcodebar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtsku);
            this.Controls.Add(this.Txtprecioproduct);
            this.Controls.Add(this.Txtproductname);
            this.Controls.Add(this.cmbTipProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormArticulos";
            this.Text = "FormArticulos";
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGRProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipProduct;
        private System.Windows.Forms.TextBox Txtproductname;
        private System.Windows.Forms.TextBox Txtprecioproduct;
        private System.Windows.Forms.TextBox Txtsku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtcodebar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Label Txtdetalles;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView DTGRProducts;
        private System.Windows.Forms.Button Btnagregar;
    }
}