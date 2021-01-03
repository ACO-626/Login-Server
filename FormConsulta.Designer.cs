namespace Login_Server
{
    partial class FormConsulta
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.panelDown = new System.Windows.Forms.Panel();
            this.lbSimpleMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSimpleName = new System.Windows.Forms.Label();
            this.lbSimpleUser = new System.Windows.Forms.Label();
            this.lbSimpleContra = new System.Windows.Forms.Label();
            this.lbNatalicio = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textNata = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textSexo = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panelDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.Location = new System.Drawing.Point(150, 130);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(137, 43);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(147, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Usuario";
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(150, 89);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(434, 26);
            this.textUser.TabIndex = 15;
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.btnEnviar);
            this.panelDown.Controls.Add(this.textSexo);
            this.panelDown.Controls.Add(this.textTel);
            this.panelDown.Controls.Add(this.textNata);
            this.panelDown.Controls.Add(this.textPass);
            this.panelDown.Controls.Add(this.textUsuario);
            this.panelDown.Controls.Add(this.textName);
            this.panelDown.Controls.Add(this.btnModifica);
            this.panelDown.Controls.Add(this.lbSexo);
            this.panelDown.Controls.Add(this.lbTel);
            this.panelDown.Controls.Add(this.lbNatalicio);
            this.panelDown.Controls.Add(this.lbSimpleContra);
            this.panelDown.Controls.Add(this.lbSimpleUser);
            this.panelDown.Controls.Add(this.lbSimpleName);
            this.panelDown.Controls.Add(this.label7);
            this.panelDown.Controls.Add(this.label6);
            this.panelDown.Controls.Add(this.label4);
            this.panelDown.Controls.Add(this.label3);
            this.panelDown.Controls.Add(this.label2);
            this.panelDown.Controls.Add(this.label1);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 253);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(950, 217);
            this.panelDown.TabIndex = 17;
            this.panelDown.Visible = false;
            // 
            // lbSimpleMessage
            // 
            this.lbSimpleMessage.AutoSize = true;
            this.lbSimpleMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSimpleMessage.Location = new System.Drawing.Point(25, 218);
            this.lbSimpleMessage.Name = "lbSimpleMessage";
            this.lbSimpleMessage.Size = new System.Drawing.Size(12, 17);
            this.lbSimpleMessage.TabIndex = 18;
            this.lbSimpleMessage.Text = ".";
            this.lbSimpleMessage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(53, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(53, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Natalicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(53, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(53, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sexo:";
            // 
            // lbSimpleName
            // 
            this.lbSimpleName.AutoSize = true;
            this.lbSimpleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSimpleName.Location = new System.Drawing.Point(138, 19);
            this.lbSimpleName.Name = "lbSimpleName";
            this.lbSimpleName.Size = new System.Drawing.Size(38, 17);
            this.lbSimpleName.TabIndex = 25;
            this.lbSimpleName.Text = "------";
            // 
            // lbSimpleUser
            // 
            this.lbSimpleUser.AutoSize = true;
            this.lbSimpleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSimpleUser.Location = new System.Drawing.Point(138, 48);
            this.lbSimpleUser.Name = "lbSimpleUser";
            this.lbSimpleUser.Size = new System.Drawing.Size(38, 17);
            this.lbSimpleUser.TabIndex = 26;
            this.lbSimpleUser.Text = "------";
            // 
            // lbSimpleContra
            // 
            this.lbSimpleContra.AutoSize = true;
            this.lbSimpleContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleContra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSimpleContra.Location = new System.Drawing.Point(138, 77);
            this.lbSimpleContra.Name = "lbSimpleContra";
            this.lbSimpleContra.Size = new System.Drawing.Size(38, 17);
            this.lbSimpleContra.TabIndex = 27;
            this.lbSimpleContra.Text = "------";
            // 
            // lbNatalicio
            // 
            this.lbNatalicio.AutoSize = true;
            this.lbNatalicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNatalicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNatalicio.Location = new System.Drawing.Point(138, 110);
            this.lbNatalicio.Name = "lbNatalicio";
            this.lbNatalicio.Size = new System.Drawing.Size(38, 17);
            this.lbNatalicio.TabIndex = 28;
            this.lbNatalicio.Text = "------";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTel.Location = new System.Drawing.Point(138, 141);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(38, 17);
            this.lbTel.TabIndex = 29;
            this.lbTel.Text = "------";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSexo.Location = new System.Drawing.Point(138, 173);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(38, 17);
            this.lbSexo.TabIndex = 30;
            this.lbSexo.Text = "------";
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnModifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifica.FlatAppearance.BorderSize = 0;
            this.btnModifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModifica.ForeColor = System.Drawing.Color.Black;
            this.btnModifica.Location = new System.Drawing.Point(811, 152);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(101, 38);
            this.btnModifica.TabIndex = 19;
            this.btnModifica.Text = "Modificar";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(160, 25);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(343, 20);
            this.textName.TabIndex = 31;
            this.textName.Visible = false;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(160, 54);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(343, 20);
            this.textUsuario.TabIndex = 32;
            this.textUsuario.Visible = false;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(160, 83);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(343, 20);
            this.textPass.TabIndex = 33;
            this.textPass.Visible = false;
            // 
            // textNata
            // 
            this.textNata.Location = new System.Drawing.Point(160, 112);
            this.textNata.Name = "textNata";
            this.textNata.Size = new System.Drawing.Size(343, 20);
            this.textNata.TabIndex = 34;
            this.textNata.Visible = false;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(160, 141);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(343, 20);
            this.textTel.TabIndex = 35;
            this.textTel.Visible = false;
            // 
            // textSexo
            // 
            this.textSexo.Location = new System.Drawing.Point(160, 170);
            this.textSexo.Name = "textSexo";
            this.textSexo.Size = new System.Drawing.Size(343, 20);
            this.textSexo.TabIndex = 36;
            this.textSexo.Visible = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(811, 112);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(101, 38);
            this.btnEnviar.TabIndex = 37;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(950, 470);
            this.Controls.Add(this.lbSimpleMessage);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.btnConsulta);
            this.Name = "FormConsulta";
            this.Text = "Consulta y Modificación";
            this.panelDown.ResumeLayout(false);
            this.panelDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSimpleMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSexo;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textNata;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbNatalicio;
        private System.Windows.Forms.Label lbSimpleContra;
        private System.Windows.Forms.Label lbSimpleUser;
        private System.Windows.Forms.Label lbSimpleName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
    }
}