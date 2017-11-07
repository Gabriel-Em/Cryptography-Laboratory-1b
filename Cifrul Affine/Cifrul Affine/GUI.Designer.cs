namespace Cifrul_Affine
{
    partial class GUI
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
            this.CheieRT = new System.Windows.Forms.RichTextBox();
            this.CheieT = new System.Windows.Forms.PictureBox();
            this.KeyLoadB = new System.Windows.Forms.Button();
            this.Titlu = new System.Windows.Forms.PictureBox();
            this.ExitB = new System.Windows.Forms.Button();
            this.DecryptB = new System.Windows.Forms.Button();
            this.EncryptB = new System.Windows.Forms.Button();
            this.EncryptedRT = new System.Windows.Forms.RichTextBox();
            this.DecryptedRT = new System.Windows.Forms.RichTextBox();
            this.DecriptatMargin = new System.Windows.Forms.PictureBox();
            this.CriptatMargin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheieT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecriptatMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriptatMargin)).BeginInit();
            this.SuspendLayout();
            // 
            // CheieRT
            // 
            this.CheieRT.BackColor = System.Drawing.Color.GhostWhite;
            this.CheieRT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheieRT.Location = new System.Drawing.Point(12, 138);
            this.CheieRT.Name = "CheieRT";
            this.CheieRT.ReadOnly = true;
            this.CheieRT.Size = new System.Drawing.Size(773, 120);
            this.CheieRT.TabIndex = 36;
            this.CheieRT.Text = "";
            // 
            // CheieT
            // 
            this.CheieT.BackColor = System.Drawing.Color.Transparent;
            this.CheieT.BackgroundImage = global::Cifrul_Affine.Properties.Resources.Cheie;
            this.CheieT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CheieT.Location = new System.Drawing.Point(-3, 91);
            this.CheieT.Name = "CheieT";
            this.CheieT.Size = new System.Drawing.Size(126, 51);
            this.CheieT.TabIndex = 38;
            this.CheieT.TabStop = false;
            // 
            // KeyLoadB
            // 
            this.KeyLoadB.BackColor = System.Drawing.Color.Transparent;
            this.KeyLoadB.BackgroundImage = global::Cifrul_Affine.Properties.Resources.ICheie;
            this.KeyLoadB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.KeyLoadB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyLoadB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyLoadB.ForeColor = System.Drawing.Color.GreenYellow;
            this.KeyLoadB.Location = new System.Drawing.Point(12, 261);
            this.KeyLoadB.Name = "KeyLoadB";
            this.KeyLoadB.Size = new System.Drawing.Size(773, 42);
            this.KeyLoadB.TabIndex = 37;
            this.KeyLoadB.UseVisualStyleBackColor = false;
            this.KeyLoadB.Click += new System.EventHandler(this.KeyLoadB_Click);
            // 
            // Titlu
            // 
            this.Titlu.BackColor = System.Drawing.Color.Transparent;
            this.Titlu.BackgroundImage = global::Cifrul_Affine.Properties.Resources.Titlu;
            this.Titlu.Location = new System.Drawing.Point(-6, -20);
            this.Titlu.Name = "Titlu";
            this.Titlu.Size = new System.Drawing.Size(810, 139);
            this.Titlu.TabIndex = 33;
            this.Titlu.TabStop = false;
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.Color.Transparent;
            this.ExitB.BackgroundImage = global::Cifrul_Affine.Properties.Resources.Iesire;
            this.ExitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitB.ForeColor = System.Drawing.Color.GreenYellow;
            this.ExitB.Location = new System.Drawing.Point(12, 639);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(776, 42);
            this.ExitB.TabIndex = 32;
            this.ExitB.UseVisualStyleBackColor = false;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // DecryptB
            // 
            this.DecryptB.BackColor = System.Drawing.Color.Transparent;
            this.DecryptB.BackgroundImage = global::Cifrul_Affine.Properties.Resources.Decripteaza;
            this.DecryptB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DecryptB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DecryptB.ForeColor = System.Drawing.Color.GreenYellow;
            this.DecryptB.Location = new System.Drawing.Point(403, 450);
            this.DecryptB.Name = "DecryptB";
            this.DecryptB.Size = new System.Drawing.Size(382, 42);
            this.DecryptB.TabIndex = 31;
            this.DecryptB.UseVisualStyleBackColor = false;
            this.DecryptB.Click += new System.EventHandler(this.DecryptB_Click);
            // 
            // EncryptB
            // 
            this.EncryptB.BackColor = System.Drawing.Color.Transparent;
            this.EncryptB.BackgroundImage = global::Cifrul_Affine.Properties.Resources.Cripteaza;
            this.EncryptB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EncryptB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncryptB.ForeColor = System.Drawing.Color.GreenYellow;
            this.EncryptB.Location = new System.Drawing.Point(12, 450);
            this.EncryptB.Name = "EncryptB";
            this.EncryptB.Size = new System.Drawing.Size(385, 42);
            this.EncryptB.TabIndex = 30;
            this.EncryptB.UseVisualStyleBackColor = false;
            this.EncryptB.Click += new System.EventHandler(this.EncryptB_Click);
            // 
            // EncryptedRT
            // 
            this.EncryptedRT.BackColor = System.Drawing.Color.GhostWhite;
            this.EncryptedRT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptedRT.ForeColor = System.Drawing.Color.Black;
            this.EncryptedRT.Location = new System.Drawing.Point(12, 498);
            this.EncryptedRT.Name = "EncryptedRT";
            this.EncryptedRT.Size = new System.Drawing.Size(731, 135);
            this.EncryptedRT.TabIndex = 29;
            this.EncryptedRT.Text = "";
            // 
            // DecryptedRT
            // 
            this.DecryptedRT.BackColor = System.Drawing.Color.GhostWhite;
            this.DecryptedRT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptedRT.Location = new System.Drawing.Point(56, 309);
            this.DecryptedRT.Name = "DecryptedRT";
            this.DecryptedRT.Size = new System.Drawing.Size(729, 135);
            this.DecryptedRT.TabIndex = 28;
            this.DecryptedRT.Text = "";
            // 
            // DecriptatMargin
            // 
            this.DecriptatMargin.BackColor = System.Drawing.Color.Transparent;
            this.DecriptatMargin.BackgroundImage = global::Cifrul_Affine.Properties.Resources.MarginDecriptat;
            this.DecriptatMargin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DecriptatMargin.Location = new System.Drawing.Point(-3, 309);
            this.DecriptatMargin.Name = "DecriptatMargin";
            this.DecriptatMargin.Size = new System.Drawing.Size(65, 135);
            this.DecriptatMargin.TabIndex = 34;
            this.DecriptatMargin.TabStop = false;
            // 
            // CriptatMargin
            // 
            this.CriptatMargin.BackColor = System.Drawing.Color.Transparent;
            this.CriptatMargin.BackgroundImage = global::Cifrul_Affine.Properties.Resources.MarginCriptat;
            this.CriptatMargin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CriptatMargin.Location = new System.Drawing.Point(738, 498);
            this.CriptatMargin.Name = "CriptatMargin";
            this.CriptatMargin.Size = new System.Drawing.Size(65, 135);
            this.CriptatMargin.TabIndex = 35;
            this.CriptatMargin.TabStop = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cifrul_Affine.Properties.Resources.sn_cryptography;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 689);
            this.ControlBox = false;
            this.Controls.Add(this.CheieRT);
            this.Controls.Add(this.CheieT);
            this.Controls.Add(this.KeyLoadB);
            this.Controls.Add(this.Titlu);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.DecryptB);
            this.Controls.Add(this.EncryptB);
            this.Controls.Add(this.EncryptedRT);
            this.Controls.Add(this.DecryptedRT);
            this.Controls.Add(this.DecriptatMargin);
            this.Controls.Add(this.CriptatMargin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "Cifrul Affine - Copyright © Gaby Em";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheieT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecriptatMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriptatMargin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CheieRT;
        private System.Windows.Forms.PictureBox CheieT;
        private System.Windows.Forms.Button KeyLoadB;
        private System.Windows.Forms.PictureBox Titlu;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Button DecryptB;
        private System.Windows.Forms.Button EncryptB;
        private System.Windows.Forms.RichTextBox EncryptedRT;
        private System.Windows.Forms.RichTextBox DecryptedRT;
        private System.Windows.Forms.PictureBox DecriptatMargin;
        private System.Windows.Forms.PictureBox CriptatMargin;
    }
}