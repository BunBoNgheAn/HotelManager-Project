namespace GUI_QLKS
{
    partial class FrmLogin
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
            this.BtnShow = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkForgot = new System.Windows.Forms.LinkLabel();
            this.linkCreateAC = new System.Windows.Forms.LinkLabel();
            this.checkRem = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.AutoSize = true;
            this.BtnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.Location = new System.Drawing.Point(223, 195);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(15, 14);
            this.BtnShow.TabIndex = 19;
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.CheckedChanged += new System.EventHandler(this.checkShow_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Or";
            // 
            // linkForgot
            // 
            this.linkForgot.AutoSize = true;
            this.linkForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgot.Location = new System.Drawing.Point(175, 305);
            this.linkForgot.Name = "linkForgot";
            this.linkForgot.Size = new System.Drawing.Size(98, 15);
            this.linkForgot.TabIndex = 17;
            this.linkForgot.TabStop = true;
            this.linkForgot.Text = "Forgot password";
            // 
            // linkCreateAC
            // 
            this.linkCreateAC.AutoSize = true;
            this.linkCreateAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCreateAC.Location = new System.Drawing.Point(64, 305);
            this.linkCreateAC.Name = "linkCreateAC";
            this.linkCreateAC.Size = new System.Drawing.Size(89, 15);
            this.linkCreateAC.TabIndex = 16;
            this.linkCreateAC.TabStop = true;
            this.linkCreateAC.Text = "Create Account";
            // 
            // checkRem
            // 
            this.checkRem.AutoSize = true;
            this.checkRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRem.Location = new System.Drawing.Point(117, 228);
            this.checkRem.Name = "checkRem";
            this.checkRem.Size = new System.Drawing.Size(117, 20);
            this.checkRem.TabIndex = 15;
            this.checkRem.Text = "Remember me";
            this.checkRem.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(117, 255);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 34);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(117, 192);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 22);
            this.txtPass.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pass : ";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(117, 166);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "User : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.BtnShow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.linkForgot);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linkCreateAC);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.checkRem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(829, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 627);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_QLKS.Properties.Resources.c180e61cbc9267cc3e83;
            this.pictureBox1.Location = new System.Drawing.Point(42, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 109);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QLKS.Properties.Resources.bigstock_Manager_Hands_Over_Key_Hotel_T_286425856_2;
            this.ClientSize = new System.Drawing.Size(1168, 627);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox BtnShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkForgot;
        private System.Windows.Forms.LinkLabel linkCreateAC;
        private System.Windows.Forms.CheckBox checkRem;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}