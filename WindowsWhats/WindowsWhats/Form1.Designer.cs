namespace WindowsWhats
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(280, 71);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(311, 22);
            this.txbName.TabIndex = 4;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(280, 109);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(311, 22);
            this.txbPhone.TabIndex = 5;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(280, 157);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(311, 22);
            this.txbPass.TabIndex = 6;
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(280, 203);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(311, 22);
            this.txbStatus.TabIndex = 7;
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(280, 261);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(311, 58);
            this.btnReceive.TabIndex = 8;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 372);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Button btnReceive;
    }
}

