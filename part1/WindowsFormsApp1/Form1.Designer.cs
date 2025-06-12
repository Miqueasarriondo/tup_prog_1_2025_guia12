namespace WindowsFormsApp1
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
            this.btnsolicitar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMostrarValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsolicitar
            // 
            this.btnsolicitar.Location = new System.Drawing.Point(73, 12);
            this.btnsolicitar.Name = "btnsolicitar";
            this.btnsolicitar.Size = new System.Drawing.Size(100, 23);
            this.btnsolicitar.TabIndex = 1;
            this.btnsolicitar.Text = "solicitar valor";
            this.btnsolicitar.UseVisualStyleBackColor = true;
            this.btnsolicitar.Click += new System.EventHandler(this.btnsolicitar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "resultados";
            // 
            // lbMostrarValor
            // 
            this.lbMostrarValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbMostrarValor.Location = new System.Drawing.Point(73, 66);
            this.lbMostrarValor.Name = "lbMostrarValor";
            this.lbMostrarValor.Size = new System.Drawing.Size(100, 20);
            this.lbMostrarValor.TabIndex = 3;
            this.lbMostrarValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 129);
            this.Controls.Add(this.lbMostrarValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsolicitar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ejemplo modal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsolicitar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lbMostrarValor;
    }
}

