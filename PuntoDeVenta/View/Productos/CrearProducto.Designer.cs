namespace PuntoDeVenta.Productos
{
    partial class CrearProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Crear = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.nombreProducto = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock";
            // 
            // Crear
            // 
            this.Crear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Crear.Location = new System.Drawing.Point(101, 173);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(75, 23);
            this.Crear.TabIndex = 4;
            this.Crear.Text = "Registrar";
            this.Crear.UseVisualStyleBackColor = false;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.Color.White;
            this.codigo.Location = new System.Drawing.Point(101, 12);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(186, 23);
            this.codigo.TabIndex = 5;
            // 
            // nombreProducto
            // 
            this.nombreProducto.BackColor = System.Drawing.Color.White;
            this.nombreProducto.Location = new System.Drawing.Point(101, 49);
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Size = new System.Drawing.Size(186, 23);
            this.nombreProducto.TabIndex = 6;
            // 
            // precio
            // 
            this.precio.BackColor = System.Drawing.Color.White;
            this.precio.Location = new System.Drawing.Point(101, 84);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(186, 23);
            this.precio.TabIndex = 7;
            // 
            // stock
            // 
            this.stock.BackColor = System.Drawing.Color.White;
            this.stock.Location = new System.Drawing.Point(101, 123);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(186, 23);
            this.stock.TabIndex = 8;
            // 
            // CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(299, 222);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.nombreProducto);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearProducto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Crear;
        private TextBox codigo;
        private TextBox nombreProducto;
        private TextBox precio;
        private TextBox stock;
    }
}