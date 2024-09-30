namespace MetodoBurbuja
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
            this.btnumero = new System.Windows.Forms.TextBox();
            this.btagregar = new System.Windows.Forms.Button();
            this.lblist = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa un numero:";
            // 
            // btnumero
            // 
            this.btnumero.Location = new System.Drawing.Point(162, 26);
            this.btnumero.Name = "btnumero";
            this.btnumero.Size = new System.Drawing.Size(176, 20);
            this.btnumero.TabIndex = 1;
            // 
            // btagregar
            // 
            this.btagregar.Location = new System.Drawing.Point(363, 26);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(77, 20);
            this.btagregar.TabIndex = 2;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // lblist
            // 
            this.lblist.FormattingEnabled = true;
            this.lblist.Location = new System.Drawing.Point(54, 70);
            this.lblist.Name = "lblist";
            this.lblist.Size = new System.Drawing.Size(262, 160);
            this.lblist.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ordenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblist);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.btnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Metodo de Burbuja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnumero;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.ListBox lblist;
        private System.Windows.Forms.Button button1;
    }
}

