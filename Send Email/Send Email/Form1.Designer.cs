namespace Send_Email
{
    partial class FordMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FordMail));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fromMailText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.icerikText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.toMailText = new System.Windows.Forms.TextBox();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellcome To Send mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(630, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ford Software Company©";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(510, 355);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(485, 329);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mail From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "From Name:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // fromMailText
            // 
            this.fromMailText.Location = new System.Drawing.Point(199, 110);
            this.fromMailText.Name = "fromMailText";
            this.fromMailText.Size = new System.Drawing.Size(358, 20);
            this.fromMailText.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Subject:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mail Text:";
            // 
            // icerikText
            // 
            this.icerikText.Location = new System.Drawing.Point(199, 257);
            this.icerikText.Name = "icerikText";
            this.icerikText.Size = new System.Drawing.Size(358, 20);
            this.icerikText.TabIndex = 3;
            this.icerikText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(199, 84);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(358, 20);
            this.nameText.TabIndex = 3;
            // 
            // toMailText
            // 
            this.toMailText.Location = new System.Drawing.Point(199, 200);
            this.toMailText.Name = "toMailText";
            this.toMailText.Size = new System.Drawing.Size(358, 20);
            this.toMailText.TabIndex = 3;
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(199, 226);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(358, 20);
            this.subjectText.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // toNameText
            // 
            this.toNameText.Location = new System.Drawing.Point(199, 162);
            this.toNameText.Name = "toNameText";
            this.toNameText.Size = new System.Drawing.Size(358, 20);
            this.toNameText.TabIndex = 3;
            // 
            // FordMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.icerikText);
            this.Controls.Add(this.subjectText);
            this.Controls.Add(this.toMailText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.toNameText);
            this.Controls.Add(this.fromMailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FordMail";
            this.Text = "Ford Software Mail Sending";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fromMailText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox icerikText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox toMailText;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox toNameText;
    }
}

