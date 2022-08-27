namespace PruebaSistematica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lvMostrar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lvDatos = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.lvMontos = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnEsta = new System.Windows.Forms.Button();
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "03-12",
            "13-59",
            "60++"});
            this.cboTipo.Location = new System.Drawing.Point(97, 38);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(168, 23);
            this.cboTipo.TabIndex = 1;
            this.cboTipo.Text = "(Seleccione la edad)";
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lvMostrar
            // 
            this.lvMostrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvMostrar.GridLines = true;
            this.lvMostrar.Location = new System.Drawing.Point(97, 85);
            this.lvMostrar.Name = "lvMostrar";
            this.lvMostrar.Size = new System.Drawing.Size(168, 102);
            this.lvMostrar.TabIndex = 2;
            this.lvMostrar.UseCompatibleStateImageBehavior = false;
            this.lvMostrar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Categoria";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(334, 109);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(93, 35);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(298, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Boletos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(377, 38);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 5;
            // 
            // lvDatos
            // 
            this.lvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvDatos.GridLines = true;
            this.lvDatos.Location = new System.Drawing.Point(24, 193);
            this.lvDatos.Name = "lvDatos";
            this.lvDatos.Size = new System.Drawing.Size(620, 140);
            this.lvDatos.TabIndex = 6;
            this.lvDatos.UseCompatibleStateImageBehavior = false;
            this.lvDatos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Categoria";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio Unitario";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cantidad de Boletos";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Subtotal";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Descuento";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Total";
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(24, 339);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(156, 34);
            this.btnEstadisticas.TabIndex = 7;
            this.btnEstadisticas.Text = "Generar Montos";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // lvMontos
            // 
            this.lvMontos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.lvMontos.GridLines = true;
            this.lvMontos.Location = new System.Drawing.Point(24, 379);
            this.lvMontos.Name = "lvMontos";
            this.lvMontos.Size = new System.Drawing.Size(257, 122);
            this.lvMontos.TabIndex = 8;
            this.lvMontos.UseCompatibleStateImageBehavior = false;
            this.lvMontos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Monto Acumulado";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Total de Descuentos";
            this.columnHeader10.Width = 120;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(449, 109);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(110, 35);
            this.btnRegistro.TabIndex = 10;
            this.btnRegistro.Text = "Otro Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnEsta
            // 
            this.btnEsta.Location = new System.Drawing.Point(298, 339);
            this.btnEsta.Name = "btnEsta";
            this.btnEsta.Size = new System.Drawing.Size(168, 34);
            this.btnEsta.TabIndex = 11;
            this.btnEsta.Text = "Generar Estadisticas";
            this.btnEsta.UseVisualStyleBackColor = true;
            this.btnEsta.Click += new System.EventHandler(this.btnEsta_Click);
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.lvEstadisticas.GridLines = true;
            this.lvEstadisticas.Location = new System.Drawing.Point(334, 379);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(190, 122);
            this.lvEstadisticas.TabIndex = 12;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            this.lvEstadisticas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Categoria";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Monto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 513);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.btnEsta);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lvMontos);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.lvDatos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lvMostrar);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cboTipo;
        private ListView lvMostrar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnRegistrar;
        private Label label2;
        private TextBox txtCantidad;
        private ListView lvDatos;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button btnEstadisticas;
        private ListView lvMontos;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Button btnRegistro;
        private Button btnEsta;
        private ListView lvEstadisticas;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
    }
}