namespace AWSBucketTest
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
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxBucket = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonGetFile = new System.Windows.Forms.Button();
            this.textBoxSecret = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxUseKeySecret = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxProxy = new System.Windows.Forms.TextBox();
            this.textBoxProxyPort = new System.Windows.Forms.TextBox();
            this.checkBoxUseProxy = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.checkBoxUseToken = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxProxyBypass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(95, 510);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(276, 20);
            this.textBoxFile.TabIndex = 0;
            this.textBoxFile.Text = "folder/file";
            // 
            // textBoxBucket
            // 
            this.textBoxBucket.Location = new System.Drawing.Point(95, 484);
            this.textBoxBucket.Name = "textBoxBucket";
            this.textBoxBucket.Size = new System.Drawing.Size(276, 20);
            this.textBoxBucket.TabIndex = 1;
            this.textBoxBucket.Text = "bucket";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(377, 35);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(181, 464);
            this.textBoxOutput.TabIndex = 2;
            // 
            // buttonGetFile
            // 
            this.buttonGetFile.Location = new System.Drawing.Point(472, 505);
            this.buttonGetFile.Name = "buttonGetFile";
            this.buttonGetFile.Size = new System.Drawing.Size(90, 29);
            this.buttonGetFile.TabIndex = 3;
            this.buttonGetFile.Text = "Get File";
            this.buttonGetFile.UseVisualStyleBackColor = true;
            this.buttonGetFile.Click += new System.EventHandler(this.buttonGetFile_Click);
            // 
            // textBoxSecret
            // 
            this.textBoxSecret.Location = new System.Drawing.Point(95, 167);
            this.textBoxSecret.Name = "textBoxSecret";
            this.textBoxSecret.Size = new System.Drawing.Size(276, 20);
            this.textBoxSecret.TabIndex = 4;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(95, 141);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(276, 20);
            this.textBoxKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Secret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bucket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "File";
            // 
            // checkBoxUseKeySecret
            // 
            this.checkBoxUseKeySecret.AutoSize = true;
            this.checkBoxUseKeySecret.Location = new System.Drawing.Point(24, 119);
            this.checkBoxUseKeySecret.Name = "checkBoxUseKeySecret";
            this.checkBoxUseKeySecret.Size = new System.Drawing.Size(102, 17);
            this.checkBoxUseKeySecret.TabIndex = 11;
            this.checkBoxUseKeySecret.Text = "Use Key/Secret";
            this.checkBoxUseKeySecret.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Proxy Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Proxy";
            // 
            // textBoxProxy
            // 
            this.textBoxProxy.Location = new System.Drawing.Point(91, 35);
            this.textBoxProxy.Name = "textBoxProxy";
            this.textBoxProxy.Size = new System.Drawing.Size(276, 20);
            this.textBoxProxy.TabIndex = 13;
            // 
            // textBoxProxyPort
            // 
            this.textBoxProxyPort.Location = new System.Drawing.Point(91, 61);
            this.textBoxProxyPort.Name = "textBoxProxyPort";
            this.textBoxProxyPort.Size = new System.Drawing.Size(276, 20);
            this.textBoxProxyPort.TabIndex = 12;
            // 
            // checkBoxUseProxy
            // 
            this.checkBoxUseProxy.AutoSize = true;
            this.checkBoxUseProxy.Location = new System.Drawing.Point(24, 12);
            this.checkBoxUseProxy.Name = "checkBoxUseProxy";
            this.checkBoxUseProxy.Size = new System.Drawing.Size(74, 17);
            this.checkBoxUseProxy.TabIndex = 16;
            this.checkBoxUseProxy.Text = "Use Proxy";
            this.checkBoxUseProxy.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Token";
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(95, 208);
            this.textBoxToken.Multiline = true;
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxToken.Size = new System.Drawing.Size(276, 271);
            this.textBoxToken.TabIndex = 17;
            // 
            // checkBoxUseToken
            // 
            this.checkBoxUseToken.AutoSize = true;
            this.checkBoxUseToken.Location = new System.Drawing.Point(20, 188);
            this.checkBoxUseToken.Name = "checkBoxUseToken";
            this.checkBoxUseToken.Size = new System.Drawing.Size(79, 17);
            this.checkBoxUseToken.TabIndex = 19;
            this.checkBoxUseToken.Text = "Use Token";
            this.checkBoxUseToken.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Proxy Bypass";
            // 
            // textBoxProxyBypass
            // 
            this.textBoxProxyBypass.Location = new System.Drawing.Point(91, 87);
            this.textBoxProxyBypass.Name = "textBoxProxyBypass";
            this.textBoxProxyBypass.Size = new System.Drawing.Size(276, 20);
            this.textBoxProxyBypass.TabIndex = 20;
            this.textBoxProxyBypass.Text = "169.254.169.254";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 554);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxProxyBypass);
            this.Controls.Add(this.checkBoxUseToken);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxToken);
            this.Controls.Add(this.checkBoxUseProxy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxProxy);
            this.Controls.Add(this.textBoxProxyPort);
            this.Controls.Add(this.checkBoxUseKeySecret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxSecret);
            this.Controls.Add(this.buttonGetFile);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxBucket);
            this.Controls.Add(this.textBoxFile);
            this.Name = "Form1";
            this.Text = "AWSBucketTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxBucket;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonGetFile;
        private System.Windows.Forms.TextBox textBoxSecret;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxUseKeySecret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxProxy;
        private System.Windows.Forms.TextBox textBoxProxyPort;
        private System.Windows.Forms.CheckBox checkBoxUseProxy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.CheckBox checkBoxUseToken;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxProxyBypass;
    }
}

