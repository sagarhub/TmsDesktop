namespace trading.Login
{
    partial class ResetPassword
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
            this.ResetBox = new System.Windows.Forms.ComboBox();
            this.OldPasswordtxt = new System.Windows.Forms.TextBox();
            this.NewPasswordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResetBox
            // 
            this.ResetBox.FormattingEnabled = true;
            this.ResetBox.Location = new System.Drawing.Point(91, 65);
            this.ResetBox.Name = "ResetBox";
            this.ResetBox.Size = new System.Drawing.Size(180, 23);
            this.ResetBox.TabIndex = 0;
            // 
            // OldPasswordtxt
            // 
            this.OldPasswordtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OldPasswordtxt.Location = new System.Drawing.Point(91, 132);
            this.OldPasswordtxt.Name = "OldPasswordtxt";
            this.OldPasswordtxt.Size = new System.Drawing.Size(180, 23);
            this.OldPasswordtxt.TabIndex = 1;
            // 
            // NewPasswordTxt
            // 
            this.NewPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPasswordTxt.Location = new System.Drawing.Point(91, 193);
            this.NewPasswordTxt.Name = "NewPasswordTxt";
            this.NewPasswordTxt.Size = new System.Drawing.Size(180, 23);
            this.NewPasswordTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Image = global::trading.Properties.Resources.icons8_reset_242;
            this.ResetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetBtn.Location = new System.Drawing.Point(127, 236);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(94, 30);
            this.ResetBtn.TabIndex = 3;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 307);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPasswordTxt);
            this.Controls.Add(this.OldPasswordtxt);
            this.Controls.Add(this.ResetBox);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ResetBox;
        private TextBox OldPasswordtxt;
        private TextBox NewPasswordTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ResetBtn;
    }
}