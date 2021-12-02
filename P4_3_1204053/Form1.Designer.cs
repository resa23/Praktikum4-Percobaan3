namespace P4_3_1204053
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelHuruf = new System.Windows.Forms.Label();
            this.labelAngka = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAturan = new System.Windows.Forms.Label();
            this.lbAngka1 = new System.Windows.Forms.Label();
            this.lbAngka2 = new System.Windows.Forms.Label();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Location = new System.Drawing.Point(80, 65);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(109, 20);
            this.labelHuruf.TabIndex = 0;
            this.labelHuruf.Text = "Huruf              :";
            // 
            // labelAngka
            // 
            this.labelAngka.AutoSize = true;
            this.labelAngka.Location = new System.Drawing.Point(80, 99);
            this.labelAngka.Name = "labelAngka";
            this.labelAngka.Size = new System.Drawing.Size(107, 20);
            this.labelAngka.TabIndex = 1;
            this.labelAngka.Text = "Angka            :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(80, 139);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(104, 20);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email             :";
            // 
            // labelAturan
            // 
            this.labelAturan.AutoSize = true;
            this.labelAturan.ForeColor = System.Drawing.Color.Red;
            this.labelAturan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAturan.Location = new System.Drawing.Point(80, 217);
            this.labelAturan.Name = "labelAturan";
            this.labelAturan.Size = new System.Drawing.Size(150, 20);
            this.labelAturan.TabIndex = 3;
            this.labelAturan.Text = "*Angka 1 > Angka 2";
            // 
            // lbAngka1
            // 
            this.lbAngka1.AutoSize = true;
            this.lbAngka1.Location = new System.Drawing.Point(80, 265);
            this.lbAngka1.Name = "lbAngka1";
            this.lbAngka1.Size = new System.Drawing.Size(112, 20);
            this.lbAngka1.TabIndex = 4;
            this.lbAngka1.Text = "Angka 1          :";
            // 
            // lbAngka2
            // 
            this.lbAngka2.AutoSize = true;
            this.lbAngka2.Location = new System.Drawing.Point(80, 302);
            this.lbAngka2.Name = "lbAngka2";
            this.lbAngka2.Size = new System.Drawing.Size(108, 20);
            this.lbAngka2.TabIndex = 5;
            this.lbAngka2.Text = "Angka2          :";
            // 
            // txtHuruf
            // 
            this.txtHuruf.Location = new System.Drawing.Point(195, 62);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(139, 26);
            this.txtHuruf.TabIndex = 6;
            this.txtHuruf.Leave += new System.EventHandler(this.txtHuruf_Leave);
            // 
            // txtAngka
            // 
            this.txtAngka.Location = new System.Drawing.Point(195, 101);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(139, 26);
            this.txtAngka.TabIndex = 7;
            this.txtAngka.Leave += new System.EventHandler(this.txtAngka_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(139, 26);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(198, 265);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(136, 26);
            this.txtAngka1.TabIndex = 9;
            this.txtAngka1.TextChanged += new System.EventHandler(this.txtAngka1_TextChanged);
            this.txtAngka1.Leave += new System.EventHandler(this.txtAngka1_Leave);
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(198, 302);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(136, 26);
            this.txtAngka2.TabIndex = 10;
            this.txtAngka2.Leave += new System.EventHandler(this.txtAngka2_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 389);
            this.Controls.Add(this.lbAngka2);
            this.Controls.Add(this.lbAngka1);
            this.Controls.Add(this.labelAturan);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAngka);
            this.Controls.Add(this.labelHuruf);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.txtHuruf);
            this.Name = "Form1";
            this.Text = "Validasi";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.Label labelAngka;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAturan;
        private System.Windows.Forms.Label lbAngka1;
        private System.Windows.Forms.Label lbAngka2;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

