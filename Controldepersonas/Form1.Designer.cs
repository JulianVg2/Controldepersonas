namespace Controldepersonas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jtxt1 = new System.Windows.Forms.TextBox();
            this.Jtxt3 = new System.Windows.Forms.TextBox();
            this.Jtxt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.labelDpi = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Jtxt1
            // 
            this.Jtxt1.Location = new System.Drawing.Point(92, 32);
            this.Jtxt1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Jtxt1.Name = "Jtxt1";
            this.Jtxt1.Size = new System.Drawing.Size(76, 20);
            this.Jtxt1.TabIndex = 0;
            // 
            // Jtxt3
            // 
            this.Jtxt3.Location = new System.Drawing.Point(92, 98);
            this.Jtxt3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Jtxt3.Name = "Jtxt3";
            this.Jtxt3.Size = new System.Drawing.Size(76, 20);
            this.Jtxt3.TabIndex = 1;
            // 
            // Jtxt2
            // 
            this.Jtxt2.Location = new System.Drawing.Point(92, 64);
            this.Jtxt2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Jtxt2.Name = "Jtxt2";
            this.Jtxt2.Size = new System.Drawing.Size(76, 20);
            this.Jtxt2.TabIndex = 2;
            this.Jtxt2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dpi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 180);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(24, 242);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(80, 41);
            this.btnIngreso.TabIndex = 8;
            this.btnIngreso.Text = "Ingresar Persona";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // labelDpi
            // 
            this.labelDpi.AutoSize = true;
            this.labelDpi.Location = new System.Drawing.Point(325, 62);
            this.labelDpi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDpi.Name = "labelDpi";
            this.labelDpi.Size = new System.Drawing.Size(35, 13);
            this.labelDpi.TabIndex = 9;
            this.labelDpi.Text = "label5";
            this.labelDpi.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(325, 96);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(35, 13);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "label6";
            this.labelNombre.Visible = false;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(325, 163);
            this.labelFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(35, 13);
            this.labelFechaNacimiento.TabIndex = 12;
            this.labelFechaNacimiento.Text = "label7";
            this.labelFechaNacimiento.Visible = false;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(325, 129);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(35, 13);
            this.labelApellido.TabIndex = 11;
            this.labelApellido.Text = "label8";
            this.labelApellido.Visible = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(327, 242);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(114, 41);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Mostrar Persona";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Primera Mayuscula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(324, 187);
            this.labelEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(35, 13);
            this.labelEdad.TabIndex = 15;
            this.labelEdad.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 469);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDpi);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jtxt2);
            this.Controls.Add(this.Jtxt3);
            this.Controls.Add(this.Jtxt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ControlPersonas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Jtxt1;
        private System.Windows.Forms.TextBox Jtxt3;
        private System.Windows.Forms.TextBox Jtxt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Label labelDpi;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelEdad;
    }
}

