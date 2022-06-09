namespace AppChat.Telas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogado = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pbAnexo = new System.Windows.Forms.PictureBox();
            this.pbEmojis = new System.Windows.Forms.PictureBox();
            this.pbEnviar = new System.Windows.Forms.PictureBox();
            this.txtMensagemDigitada = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmojis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnviar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 449);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLogado);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 40);
            this.panel2.TabIndex = 0;
            // 
            // lblLogado
            // 
            this.lblLogado.AutoSize = true;
            this.lblLogado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogado.Location = new System.Drawing.Point(138, 2);
            this.lblLogado.Name = "lblLogado";
            this.lblLogado.Size = new System.Drawing.Size(39, 17);
            this.lblLogado.TabIndex = 3;
            this.lblLogado.Text = "Teste";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppChat.Properties.Resources.icons8_check_all_30;
            this.pictureBox2.Location = new System.Drawing.Point(25, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário logado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppChat.Properties.Resources._3837171;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.pbExit);
            this.panel3.Controls.Add(this.txtLog);
            this.panel3.Controls.Add(this.pbAnexo);
            this.panel3.Controls.Add(this.pbEmojis);
            this.panel3.Controls.Add(this.pbEnviar);
            this.panel3.Controls.Add(this.txtMensagemDigitada);
            this.panel3.Controls.Add(this.lblIp);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(191, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 449);
            this.panel3.TabIndex = 1;
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::AppChat.Properties.Resources.icons8_close_24;
            this.pbExit.Location = new System.Drawing.Point(572, -1);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(25, 24);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 7;
            this.pbExit.TabStop = false;
            this.pbExit.Visible = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLog.Location = new System.Drawing.Point(6, 26);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(553, 368);
            this.txtLog.TabIndex = 6;
            // 
            // pbAnexo
            // 
            this.pbAnexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAnexo.Image = ((System.Drawing.Image)(resources.GetObject("pbAnexo.Image")));
            this.pbAnexo.Location = new System.Drawing.Point(525, 405);
            this.pbAnexo.Name = "pbAnexo";
            this.pbAnexo.Size = new System.Drawing.Size(29, 27);
            this.pbAnexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnexo.TabIndex = 5;
            this.pbAnexo.TabStop = false;
            this.pbAnexo.Click += new System.EventHandler(this.pbAnexo_Click);
            // 
            // pbEmojis
            // 
            this.pbEmojis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEmojis.Image = ((System.Drawing.Image)(resources.GetObject("pbEmojis.Image")));
            this.pbEmojis.Location = new System.Drawing.Point(494, 405);
            this.pbEmojis.Name = "pbEmojis";
            this.pbEmojis.Size = new System.Drawing.Size(29, 27);
            this.pbEmojis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmojis.TabIndex = 4;
            this.pbEmojis.TabStop = false;
            // 
            // pbEnviar
            // 
            this.pbEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEnviar.Image = global::AppChat.Properties.Resources.icons8_sent_48;
            this.pbEnviar.Location = new System.Drawing.Point(464, 405);
            this.pbEnviar.Name = "pbEnviar";
            this.pbEnviar.Size = new System.Drawing.Size(29, 27);
            this.pbEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnviar.TabIndex = 3;
            this.pbEnviar.TabStop = false;
            this.pbEnviar.Click += new System.EventHandler(this.pbEnviar_Click);
            // 
            // txtMensagemDigitada
            // 
            this.txtMensagemDigitada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMensagemDigitada.Location = new System.Drawing.Point(4, 400);
            this.txtMensagemDigitada.Multiline = true;
            this.txtMensagemDigitada.Name = "txtMensagemDigitada";
            this.txtMensagemDigitada.PlaceholderText = "Digite a mensagem";
            this.txtMensagemDigitada.Size = new System.Drawing.Size(555, 38);
            this.txtMensagemDigitada.TabIndex = 2;
            this.txtMensagemDigitada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMensagem_KeyDown);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(92, 6);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(0, 15);
            this.lblIp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Conectado a :";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmojis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnviar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.PictureBox pbAnexo;
        private System.Windows.Forms.PictureBox pbEmojis;
        private System.Windows.Forms.PictureBox pbEnviar;
        private System.Windows.Forms.TextBox txtMensagemDigitada;
        public System.Windows.Forms.Label lblLogado;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}