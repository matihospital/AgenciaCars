namespace AgenciaCars.formularios
{
    partial class BUSQ_Producto
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_patron = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rb_modelo = new System.Windows.Forms.RadioButton();
            this.rb_año = new System.Windows.Forms.RadioButton();
            this.rb_color = new System.Windows.Forms.RadioButton();
            this.rb_id = new System.Windows.Forms.RadioButton();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_titulo.Location = new System.Drawing.Point(46, 28);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(413, 42);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "BUSCAR PRODUCTO";
            // 
            // lbl_patron
            // 
            this.lbl_patron.AutoSize = true;
            this.lbl_patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patron.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_patron.Location = new System.Drawing.Point(12, 110);
            this.lbl_patron.Name = "lbl_patron";
            this.lbl_patron.Size = new System.Drawing.Size(182, 24);
            this.lbl_patron.TabIndex = 1;
            this.lbl_patron.Text = "Patrón de Búsqueda";
            // 
            // txt_producto
            // 
            this.txt_producto.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_producto.Location = new System.Drawing.Point(200, 110);
            this.txt_producto.Multiline = true;
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(304, 28);
            this.txt_producto.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 191);
            this.dataGridView1.TabIndex = 3;
            // 
            // rb_modelo
            // 
            this.rb_modelo.AutoSize = true;
            this.rb_modelo.Location = new System.Drawing.Point(19, 148);
            this.rb_modelo.Name = "rb_modelo";
            this.rb_modelo.Size = new System.Drawing.Size(60, 17);
            this.rb_modelo.TabIndex = 4;
            this.rb_modelo.TabStop = true;
            this.rb_modelo.Text = "Modelo";
            this.rb_modelo.UseVisualStyleBackColor = true;
            // 
            // rb_año
            // 
            this.rb_año.AutoSize = true;
            this.rb_año.Location = new System.Drawing.Point(123, 148);
            this.rb_año.Name = "rb_año";
            this.rb_año.Size = new System.Drawing.Size(44, 17);
            this.rb_año.TabIndex = 5;
            this.rb_año.TabStop = true;
            this.rb_año.Text = "Año";
            this.rb_año.UseVisualStyleBackColor = true;
            // 
            // rb_color
            // 
            this.rb_color.AutoSize = true;
            this.rb_color.Location = new System.Drawing.Point(223, 148);
            this.rb_color.Name = "rb_color";
            this.rb_color.Size = new System.Drawing.Size(49, 17);
            this.rb_color.TabIndex = 6;
            this.rb_color.TabStop = true;
            this.rb_color.Text = "Color";
            this.rb_color.UseVisualStyleBackColor = true;
            // 
            // rb_id
            // 
            this.rb_id.AutoSize = true;
            this.rb_id.Location = new System.Drawing.Point(325, 148);
            this.rb_id.Name = "rb_id";
            this.rb_id.Size = new System.Drawing.Size(36, 17);
            this.rb_id.TabIndex = 7;
            this.rb_id.TabStop = true;
            this.rb_id.Text = "ID";
            this.rb_id.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_buscar.Location = new System.Drawing.Point(404, 144);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(100, 29);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // BUSQ_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(512, 378);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.rb_id);
            this.Controls.Add(this.rb_color);
            this.Controls.Add(this.rb_año);
            this.Controls.Add(this.rb_modelo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.lbl_patron);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "BUSQ_Producto";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_patron;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rb_modelo;
        private System.Windows.Forms.RadioButton rb_año;
        private System.Windows.Forms.RadioButton rb_color;
        private System.Windows.Forms.RadioButton rb_id;
        private System.Windows.Forms.Button btn_buscar;
    }
}