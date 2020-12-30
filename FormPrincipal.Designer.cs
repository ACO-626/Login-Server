namespace Login_Server
{
    partial class FormPrincipal
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
            this.textRuta = new System.Windows.Forms.TextBox();
            this.textSecret = new System.Windows.Forms.TextBox();
            this.lbSimpleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textRuta
            // 
            this.textRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRuta.Location = new System.Drawing.Point(136, 89);
            this.textRuta.Name = "textRuta";
            this.textRuta.Size = new System.Drawing.Size(531, 26);
            this.textRuta.TabIndex = 0;
            // 
            // textSecret
            // 
            this.textSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecret.Location = new System.Drawing.Point(136, 138);
            this.textSecret.Name = "textSecret";
            this.textSecret.Size = new System.Drawing.Size(531, 26);
            this.textSecret.TabIndex = 1;
            // 
            // lbSimpleLabel
            // 
            this.lbSimpleLabel.AutoSize = true;
            this.lbSimpleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSimpleLabel.Location = new System.Drawing.Point(45, 95);
            this.lbSimpleLabel.Name = "lbSimpleLabel";
            this.lbSimpleLabel.Size = new System.Drawing.Size(42, 17);
            this.lbSimpleLabel.TabIndex = 2;
            this.lbSimpleLabel.Text = "Ruta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Secret:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Indique los datos de su Base de datos en Firebase para entablar una conexión";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(704, 109);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(91, 34);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1032, 567);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSimpleLabel);
            this.Controls.Add(this.textSecret);
            this.Controls.Add(this.textRuta);
            this.Name = "FormPrincipal";
            this.Text = "Login Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRuta;
        private System.Windows.Forms.TextBox textSecret;
        private System.Windows.Forms.Label lbSimpleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConectar;
    }
}

