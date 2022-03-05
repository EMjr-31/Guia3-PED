namespace Arbol_Binario
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
            this.label1 = new System.Windows.Forms.Label();
            this.brnIngresar = new System.Windows.Forms.Button();
            this.btnElimnar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de Arbol Binario de Busqueda";
            // 
            // brnIngresar
            // 
            this.brnIngresar.Location = new System.Drawing.Point(12, 48);
            this.brnIngresar.Name = "brnIngresar";
            this.brnIngresar.Size = new System.Drawing.Size(75, 23);
            this.brnIngresar.TabIndex = 1;
            this.brnIngresar.Text = "Insertar Nodo";
            this.brnIngresar.UseVisualStyleBackColor = true;
            this.brnIngresar.Click += new System.EventHandler(this.brnIngresar_Click);
            // 
            // btnElimnar
            // 
            this.btnElimnar.Location = new System.Drawing.Point(12, 78);
            this.btnElimnar.Name = "btnElimnar";
            this.btnElimnar.Size = new System.Drawing.Size(75, 23);
            this.btnElimnar.TabIndex = 2;
            this.btnElimnar.Text = "Elimnar Nodo";
            this.btnElimnar.UseVisualStyleBackColor = true;
            this.btnElimnar.Click += new System.EventHandler(this.btnElimnar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar Nodo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(110, 50);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(58, 20);
            this.txtInsertar.TabIndex = 4;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(110, 80);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(58, 20);
            this.txtEliminar.TabIndex = 5;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(110, 120);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(58, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnElimnar);
            this.Controls.Add(this.brnIngresar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brnIngresar;
        private System.Windows.Forms.Button btnElimnar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}

