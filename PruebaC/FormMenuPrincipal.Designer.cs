namespace PruebaC
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolstripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmenuArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmenuEncKardex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmenuDetKardex = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolstripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolstripMenu
            // 
            this.ToolstripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolmenuArticulos,
            this.toolmenuEncKardex,
            this.toolmenuDetKardex});
            this.ToolstripMenu.Name = "ToolstripMenu";
            this.ToolstripMenu.Size = new System.Drawing.Size(85, 20);
            this.ToolstripMenu.Text = "Operaciones";
            // 
            // toolmenuArticulos
            // 
            this.toolmenuArticulos.Name = "toolmenuArticulos";
            this.toolmenuArticulos.Size = new System.Drawing.Size(277, 22);
            this.toolmenuArticulos.Text = "Operaciones de articulos";
            this.toolmenuArticulos.Click += new System.EventHandler(this.toolmenuArticulos_Click);
            // 
            // toolmenuEncKardex
            // 
            this.toolmenuEncKardex.Name = "toolmenuEncKardex";
            this.toolmenuEncKardex.Size = new System.Drawing.Size(277, 22);
            this.toolmenuEncKardex.Text = "Operaciones de encabezado de Kardex";
            // 
            // toolmenuDetKardex
            // 
            this.toolmenuDetKardex.Name = "toolmenuDetKardex";
            this.toolmenuDetKardex.Size = new System.Drawing.Size(277, 22);
            this.toolmenuDetKardex.Text = "Operaciones de Detalle de Kardex";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PruebaC.Properties.Resources._20221112_164035;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuPrincipal";
            this.Text = "Formulario Articulos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolstripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolmenuArticulos;
        private System.Windows.Forms.ToolStripMenuItem toolmenuEncKardex;
        private System.Windows.Forms.ToolStripMenuItem toolmenuDetKardex;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

