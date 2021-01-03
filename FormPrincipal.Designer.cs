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
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lbSimpleConexion = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPasswd = new System.Windows.Forms.TextBox();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.comboAno = new System.Windows.Forms.ComboBox();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSimpleDay = new System.Windows.Forms.Label();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.checkFem = new System.Windows.Forms.CheckBox();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPass2 = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRegistro.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.textSecret.Location = new System.Drawing.Point(136, 147);
            this.textSecret.Name = "textSecret";
            this.textSecret.Size = new System.Drawing.Size(531, 26);
            this.textSecret.TabIndex = 1;
            this.textSecret.UseSystemPasswordChar = true;
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
            this.label1.Location = new System.Drawing.Point(45, 147);
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
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.Location = new System.Drawing.Point(704, 89);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(91, 34);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.Location = new System.Drawing.Point(704, 138);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(91, 34);
            this.btnDesconectar.TabIndex = 6;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // lbSimpleConexion
            // 
            this.lbSimpleConexion.AutoSize = true;
            this.lbSimpleConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleConexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSimpleConexion.Location = new System.Drawing.Point(813, 123);
            this.lbSimpleConexion.Name = "lbSimpleConexion";
            this.lbSimpleConexion.Size = new System.Drawing.Size(85, 20);
            this.lbSimpleConexion.TabIndex = 7;
            this.lbSimpleConexion.Text = "MENSAJE";
            this.lbSimpleConexion.Visible = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Location = new System.Drawing.Point(646, 261);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(98, 31);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(51, 70);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(434, 26);
            this.textName.TabIndex = 9;
            // 
            // textPasswd
            // 
            this.textPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPasswd.Location = new System.Drawing.Point(51, 171);
            this.textPasswd.Name = "textPasswd";
            this.textPasswd.Size = new System.Drawing.Size(434, 26);
            this.textPasswd.TabIndex = 10;
            this.textPasswd.UseSystemPasswordChar = true;
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.comboAno);
            this.panelRegistro.Controls.Add(this.comboMes);
            this.panelRegistro.Controls.Add(this.label11);
            this.panelRegistro.Controls.Add(this.label10);
            this.panelRegistro.Controls.Add(this.label9);
            this.panelRegistro.Controls.Add(this.labelSimpleDay);
            this.panelRegistro.Controls.Add(this.checkMale);
            this.panelRegistro.Controls.Add(this.checkFem);
            this.panelRegistro.Controls.Add(this.comboDay);
            this.panelRegistro.Controls.Add(this.label7);
            this.panelRegistro.Controls.Add(this.textTel);
            this.panelRegistro.Controls.Add(this.label6);
            this.panelRegistro.Controls.Add(this.textPass2);
            this.panelRegistro.Controls.Add(this.btnClean);
            this.panelRegistro.Controls.Add(this.label5);
            this.panelRegistro.Controls.Add(this.textUser);
            this.panelRegistro.Controls.Add(this.label4);
            this.panelRegistro.Controls.Add(this.label3);
            this.panelRegistro.Controls.Add(this.textPasswd);
            this.panelRegistro.Controls.Add(this.textName);
            this.panelRegistro.Controls.Add(this.btnEnviar);
            this.panelRegistro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRegistro.Location = new System.Drawing.Point(0, 269);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(1061, 322);
            this.panelRegistro.TabIndex = 8;
            this.panelRegistro.Visible = false;
            // 
            // comboAno
            // 
            this.comboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboAno.FormattingEnabled = true;
            this.comboAno.Location = new System.Drawing.Point(787, 122);
            this.comboAno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboAno.Name = "comboAno";
            this.comboAno.Size = new System.Drawing.Size(92, 20);
            this.comboAno.TabIndex = 30;
            // 
            // comboMes
            // 
            this.comboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Location = new System.Drawing.Point(682, 122);
            this.comboMes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(92, 20);
            this.comboMes.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(568, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Nombre completo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(784, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Año (aaaa)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(679, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Mes (mm)";
            // 
            // labelSimpleDay
            // 
            this.labelSimpleDay.AutoSize = true;
            this.labelSimpleDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimpleDay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSimpleDay.Location = new System.Drawing.Point(571, 104);
            this.labelSimpleDay.Name = "labelSimpleDay";
            this.labelSimpleDay.Size = new System.Drawing.Size(59, 17);
            this.labelSimpleDay.TabIndex = 25;
            this.labelSimpleDay.Text = "Día (dd)";
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkMale.Location = new System.Drawing.Point(662, 192);
            this.checkMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(90, 21);
            this.checkMale.TabIndex = 24;
            this.checkMale.Text = "Masculino";
            this.checkMale.UseVisualStyleBackColor = true;
            // 
            // checkFem
            // 
            this.checkFem.AutoSize = true;
            this.checkFem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkFem.Location = new System.Drawing.Point(571, 190);
            this.checkFem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkFem.Name = "checkFem";
            this.checkFem.Size = new System.Drawing.Size(89, 21);
            this.checkFem.TabIndex = 23;
            this.checkFem.Text = "Femenino";
            this.checkFem.UseVisualStyleBackColor = true;
            // 
            // comboDay
            // 
            this.comboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Location = new System.Drawing.Point(571, 122);
            this.comboDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(92, 21);
            this.comboDay.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(568, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Teléfono (10 dígitos)";
            // 
            // textTel
            // 
            this.textTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTel.Location = new System.Drawing.Point(571, 70);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(434, 26);
            this.textTel.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(48, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Confirmar contraseña";
            // 
            // textPass2
            // 
            this.textPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass2.Location = new System.Drawing.Point(51, 220);
            this.textPass2.Name = "textPass2";
            this.textPass2.Size = new System.Drawing.Size(434, 26);
            this.textPass2.TabIndex = 16;
            this.textPass2.UseSystemPasswordChar = true;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.Location = new System.Drawing.Point(554, 261);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(86, 31);
            this.btnClean.TabIndex = 15;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(48, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Usuario";
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(51, 122);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(434, 26);
            this.textUser.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(48, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre completo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modoToolStripMenuItem
            // 
            this.modoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem});
            this.modoToolStripMenuItem.Name = "modoToolStripMenuItem";
            this.modoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.modoToolStripMenuItem.Text = "Modo";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.consultaToolStripMenuItem.Text = "Consulta o Modificación";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1061, 591);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.lbSimpleConexion);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSimpleLabel);
            this.Controls.Add(this.textSecret);
            this.Controls.Add(this.textRuta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Login Server";
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lbSimpleConexion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPasswd;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPass2;
        private System.Windows.Forms.ComboBox comboAno;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSimpleDay;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.CheckBox checkFem;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
    }
}

