namespace Compiladores1_proyecto1
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btntokens = new System.Windows.Forms.Button();
            this.Errores = new System.Windows.Forms.Button();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtSecundario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(93, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btntokens
            // 
            this.btntokens.Location = new System.Drawing.Point(175, 11);
            this.btntokens.Name = "btntokens";
            this.btntokens.Size = new System.Drawing.Size(75, 23);
            this.btntokens.TabIndex = 2;
            this.btntokens.Text = "Tokens";
            this.btntokens.UseVisualStyleBackColor = true;
            // 
            // Errores
            // 
            this.Errores.Location = new System.Drawing.Point(257, 10);
            this.Errores.Name = "Errores";
            this.Errores.Size = new System.Drawing.Size(75, 23);
            this.Errores.TabIndex = 3;
            this.Errores.Text = "Errores";
            this.Errores.UseVisualStyleBackColor = true;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(13, 52);
            this.txtPrincipal.Multiline = true;
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(423, 438);
            this.txtPrincipal.TabIndex = 4;
            // 
            // txtSecundario
            // 
            this.txtSecundario.Location = new System.Drawing.Point(12, 507);
            this.txtSecundario.Multiline = true;
            this.txtSecundario.Name = "txtSecundario";
            this.txtSecundario.Size = new System.Drawing.Size(424, 120);
            this.txtSecundario.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thomson";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSecundario);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.Errores);
            this.Controls.Add(this.btntokens);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btntokens;
        private System.Windows.Forms.Button Errores;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtSecundario;
        private System.Windows.Forms.Button button1;
    }
}

