namespace BlumBlumShub
{
    partial class Reg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passworbox = new System.Windows.Forms.TextBox();
            this.acceptpasswordbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Подтвердите пароль:";
            // 
            // loginbox
            // 
            this.loginbox.Location = new System.Drawing.Point(247, 47);
            this.loginbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(247, 22);
            this.loginbox.TabIndex = 3;
            // 
            // passworbox
            // 
            this.passworbox.Location = new System.Drawing.Point(247, 89);
            this.passworbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passworbox.Name = "passworbox";
            this.passworbox.Size = new System.Drawing.Size(247, 22);
            this.passworbox.TabIndex = 4;
            // 
            // acceptpasswordbox
            // 
            this.acceptpasswordbox.Location = new System.Drawing.Point(247, 134);
            this.acceptpasswordbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptpasswordbox.Name = "acceptpasswordbox";
            this.acceptpasswordbox.Size = new System.Drawing.Size(247, 22);
            this.acceptpasswordbox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(208, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.acceptpasswordbox);
            this.Controls.Add(this.passworbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reg";
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reg_Closed);
            this.Load += new System.EventHandler(this.Reg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passworbox;
        private System.Windows.Forms.TextBox acceptpasswordbox;
        private System.Windows.Forms.Button button1;
    }
}