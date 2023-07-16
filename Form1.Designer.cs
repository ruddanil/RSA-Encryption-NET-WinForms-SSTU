namespace RSA_Encryption_WinForms_SSTU
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
            this.buttonOpenFileForEncClient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPublicServer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPrivateServer = new System.Windows.Forms.TextBox();
            this.buttonOpenPublicServer = new System.Windows.Forms.Button();
            this.richTextBoxTextForEncClient = new System.Windows.Forms.RichTextBox();
            this.buttonOpenPrivateServer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBoxEncTextClient = new System.Windows.Forms.RichTextBox();
            this.buttonStartEncServer = new System.Windows.Forms.Button();
            this.buttonStartDecServer = new System.Windows.Forms.Button();
            this.richTextBoxDecTextServer = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBoxTextForDecServer = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonOpenFileForDecServer = new System.Windows.Forms.Button();
            this.buttonOpenPublicClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPublicClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenFileForSignServer = new System.Windows.Forms.Button();
            this.buttonStartSignServer = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonOpenFileForSignClient = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonOpenSignClient = new System.Windows.Forms.Button();
            this.buttonStartVerifyClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenFileForEncClient
            // 
            this.buttonOpenFileForEncClient.Location = new System.Drawing.Point(402, 85);
            this.buttonOpenFileForEncClient.Name = "buttonOpenFileForEncClient";
            this.buttonOpenFileForEncClient.Size = new System.Drawing.Size(130, 23);
            this.buttonOpenFileForEncClient.TabIndex = 2;
            this.buttonOpenFileForEncClient.Text = "Open";
            this.buttonOpenFileForEncClient.UseVisualStyleBackColor = true;
            this.buttonOpenFileForEncClient.Click += new System.EventHandler(this.buttonOpenFileForEncClient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(281, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "File for encryption:";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(116, 37);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(147, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Generate keys:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(48, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Working as a server";
            // 
            // textBoxPublicServer
            // 
            this.textBoxPublicServer.BackColor = System.Drawing.Color.White;
            this.textBoxPublicServer.Location = new System.Drawing.Point(94, 66);
            this.textBoxPublicServer.Name = "textBoxPublicServer";
            this.textBoxPublicServer.ReadOnly = true;
            this.textBoxPublicServer.Size = new System.Drawing.Size(109, 20);
            this.textBoxPublicServer.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Public key:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Private key:";
            // 
            // textBoxPrivateServer
            // 
            this.textBoxPrivateServer.BackColor = System.Drawing.Color.White;
            this.textBoxPrivateServer.Location = new System.Drawing.Point(94, 92);
            this.textBoxPrivateServer.Name = "textBoxPrivateServer";
            this.textBoxPrivateServer.ReadOnly = true;
            this.textBoxPrivateServer.Size = new System.Drawing.Size(109, 20);
            this.textBoxPrivateServer.TabIndex = 10;
            // 
            // buttonOpenPublicServer
            // 
            this.buttonOpenPublicServer.Location = new System.Drawing.Point(209, 65);
            this.buttonOpenPublicServer.Name = "buttonOpenPublicServer";
            this.buttonOpenPublicServer.Size = new System.Drawing.Size(54, 23);
            this.buttonOpenPublicServer.TabIndex = 12;
            this.buttonOpenPublicServer.Text = "Open";
            this.buttonOpenPublicServer.UseVisualStyleBackColor = true;
            this.buttonOpenPublicServer.Click += new System.EventHandler(this.buttonOpenPublicServer_Click);
            // 
            // richTextBoxTextForEncClient
            // 
            this.richTextBoxTextForEncClient.Location = new System.Drawing.Point(281, 130);
            this.richTextBoxTextForEncClient.Name = "richTextBoxTextForEncClient";
            this.richTextBoxTextForEncClient.Size = new System.Drawing.Size(251, 100);
            this.richTextBoxTextForEncClient.TabIndex = 13;
            this.richTextBoxTextForEncClient.Text = "";
            // 
            // buttonOpenPrivateServer
            // 
            this.buttonOpenPrivateServer.Location = new System.Drawing.Point(209, 91);
            this.buttonOpenPrivateServer.Name = "buttonOpenPrivateServer";
            this.buttonOpenPrivateServer.Size = new System.Drawing.Size(54, 23);
            this.buttonOpenPrivateServer.TabIndex = 14;
            this.buttonOpenPrivateServer.Text = "Open";
            this.buttonOpenPrivateServer.UseVisualStyleBackColor = true;
            this.buttonOpenPrivateServer.Click += new System.EventHandler(this.buttonOpenPrivateServer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(345, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Text for encryption:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(327, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Working as a client";
            // 
            // richTextBoxEncTextClient
            // 
            this.richTextBoxEncTextClient.BackColor = System.Drawing.Color.White;
            this.richTextBoxEncTextClient.Location = new System.Drawing.Point(281, 265);
            this.richTextBoxEncTextClient.Name = "richTextBoxEncTextClient";
            this.richTextBoxEncTextClient.ReadOnly = true;
            this.richTextBoxEncTextClient.Size = new System.Drawing.Size(251, 129);
            this.richTextBoxEncTextClient.TabIndex = 17;
            this.richTextBoxEncTextClient.Text = "";
            // 
            // buttonStartEncServer
            // 
            this.buttonStartEncServer.Location = new System.Drawing.Point(281, 236);
            this.buttonStartEncServer.Name = "buttonStartEncServer";
            this.buttonStartEncServer.Size = new System.Drawing.Size(251, 23);
            this.buttonStartEncServer.TabIndex = 19;
            this.buttonStartEncServer.Text = "Encrypt text";
            this.buttonStartEncServer.UseVisualStyleBackColor = true;
            this.buttonStartEncServer.Click += new System.EventHandler(this.buttonStartEncServer_Click);
            // 
            // buttonStartDecServer
            // 
            this.buttonStartDecServer.Location = new System.Drawing.Point(12, 291);
            this.buttonStartDecServer.Name = "buttonStartDecServer";
            this.buttonStartDecServer.Size = new System.Drawing.Size(251, 23);
            this.buttonStartDecServer.TabIndex = 27;
            this.buttonStartDecServer.Text = "Decrypt text";
            this.buttonStartDecServer.UseVisualStyleBackColor = true;
            this.buttonStartDecServer.Click += new System.EventHandler(this.buttonStartDecServer_Click);
            // 
            // richTextBoxDecTextServer
            // 
            this.richTextBoxDecTextServer.BackColor = System.Drawing.Color.White;
            this.richTextBoxDecTextServer.Location = new System.Drawing.Point(12, 320);
            this.richTextBoxDecTextServer.Name = "richTextBoxDecTextServer";
            this.richTextBoxDecTextServer.ReadOnly = true;
            this.richTextBoxDecTextServer.Size = new System.Drawing.Size(251, 100);
            this.richTextBoxDecTextServer.TabIndex = 25;
            this.richTextBoxDecTextServer.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(74, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Text for decryption:";
            // 
            // richTextBoxTextForDecServer
            // 
            this.richTextBoxTextForDecServer.BackColor = System.Drawing.Color.White;
            this.richTextBoxTextForDecServer.Location = new System.Drawing.Point(12, 185);
            this.richTextBoxTextForDecServer.Name = "richTextBoxTextForDecServer";
            this.richTextBoxTextForDecServer.ReadOnly = true;
            this.richTextBoxTextForDecServer.Size = new System.Drawing.Size(251, 100);
            this.richTextBoxTextForDecServer.TabIndex = 23;
            this.richTextBoxTextForDecServer.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "File for decryption:";
            // 
            // buttonOpenFileForDecServer
            // 
            this.buttonOpenFileForDecServer.Location = new System.Drawing.Point(133, 140);
            this.buttonOpenFileForDecServer.Name = "buttonOpenFileForDecServer";
            this.buttonOpenFileForDecServer.Size = new System.Drawing.Size(130, 23);
            this.buttonOpenFileForDecServer.TabIndex = 21;
            this.buttonOpenFileForDecServer.Text = "Open";
            this.buttonOpenFileForDecServer.UseVisualStyleBackColor = true;
            this.buttonOpenFileForDecServer.Click += new System.EventHandler(this.buttonOpenFileForDecServer_Click);
            // 
            // buttonOpenPublicClient
            // 
            this.buttonOpenPublicClient.Location = new System.Drawing.Point(476, 36);
            this.buttonOpenPublicClient.Name = "buttonOpenPublicClient";
            this.buttonOpenPublicClient.Size = new System.Drawing.Size(54, 23);
            this.buttonOpenPublicClient.TabIndex = 30;
            this.buttonOpenPublicClient.Text = "Open";
            this.buttonOpenPublicClient.UseVisualStyleBackColor = true;
            this.buttonOpenPublicClient.Click += new System.EventHandler(this.buttonOpenPublicClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(279, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Public key:";
            // 
            // textBoxPublicClient
            // 
            this.textBoxPublicClient.BackColor = System.Drawing.Color.White;
            this.textBoxPublicClient.Location = new System.Drawing.Point(361, 37);
            this.textBoxPublicClient.Name = "textBoxPublicClient";
            this.textBoxPublicClient.ReadOnly = true;
            this.textBoxPublicClient.Size = new System.Drawing.Size(109, 20);
            this.textBoxPublicClient.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(66, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Decryption Module";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(39, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Signature Creation Module";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "File to be signed:";
            // 
            // buttonOpenFileForSignServer
            // 
            this.buttonOpenFileForSignServer.Location = new System.Drawing.Point(127, 448);
            this.buttonOpenFileForSignServer.Name = "buttonOpenFileForSignServer";
            this.buttonOpenFileForSignServer.Size = new System.Drawing.Size(136, 23);
            this.buttonOpenFileForSignServer.TabIndex = 35;
            this.buttonOpenFileForSignServer.Text = "Open";
            this.buttonOpenFileForSignServer.UseVisualStyleBackColor = true;
            this.buttonOpenFileForSignServer.Click += new System.EventHandler(this.buttonOpenFileForSignServer_Click);
            // 
            // buttonStartSignServer
            // 
            this.buttonStartSignServer.Location = new System.Drawing.Point(12, 477);
            this.buttonStartSignServer.Name = "buttonStartSignServer";
            this.buttonStartSignServer.Size = new System.Drawing.Size(251, 23);
            this.buttonStartSignServer.TabIndex = 37;
            this.buttonStartSignServer.Text = "Sign the file";
            this.buttonStartSignServer.UseVisualStyleBackColor = true;
            this.buttonStartSignServer.Click += new System.EventHandler(this.buttonStartSignServer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(335, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "Encryption Module";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(301, 402);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 16);
            this.label15.TabIndex = 39;
            this.label15.Text = "Signature Verification Module";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(281, 424);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "File:";
            // 
            // buttonOpenFileForSignClient
            // 
            this.buttonOpenFileForSignClient.Location = new System.Drawing.Point(319, 421);
            this.buttonOpenFileForSignClient.Name = "buttonOpenFileForSignClient";
            this.buttonOpenFileForSignClient.Size = new System.Drawing.Size(213, 23);
            this.buttonOpenFileForSignClient.TabIndex = 40;
            this.buttonOpenFileForSignClient.Text = "Open";
            this.buttonOpenFileForSignClient.UseVisualStyleBackColor = true;
            this.buttonOpenFileForSignClient.Click += new System.EventHandler(this.buttonOpenFileForSignClient_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(281, 453);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 16);
            this.label17.TabIndex = 43;
            this.label17.Text = "Digital signature:";
            // 
            // buttonOpenSignClient
            // 
            this.buttonOpenSignClient.Location = new System.Drawing.Point(393, 450);
            this.buttonOpenSignClient.Name = "buttonOpenSignClient";
            this.buttonOpenSignClient.Size = new System.Drawing.Size(139, 23);
            this.buttonOpenSignClient.TabIndex = 42;
            this.buttonOpenSignClient.Text = "Open";
            this.buttonOpenSignClient.UseVisualStyleBackColor = true;
            this.buttonOpenSignClient.Click += new System.EventHandler(this.buttonOpenSignClient_Click);
            // 
            // buttonStartVerifyClient
            // 
            this.buttonStartVerifyClient.Location = new System.Drawing.Point(281, 477);
            this.buttonStartVerifyClient.Name = "buttonStartVerifyClient";
            this.buttonStartVerifyClient.Size = new System.Drawing.Size(251, 23);
            this.buttonStartVerifyClient.TabIndex = 44;
            this.buttonStartVerifyClient.Text = "Verify digital signature";
            this.buttonStartVerifyClient.UseVisualStyleBackColor = true;
            this.buttonStartVerifyClient.Click += new System.EventHandler(this.buttonStartVerifyClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 513);
            this.Controls.Add(this.buttonStartVerifyClient);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.buttonOpenSignClient);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonOpenFileForSignClient);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonStartSignServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenFileForSignServer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonOpenPublicClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPublicClient);
            this.Controls.Add(this.buttonStartDecServer);
            this.Controls.Add(this.richTextBoxDecTextServer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.richTextBoxTextForDecServer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonOpenFileForDecServer);
            this.Controls.Add(this.buttonStartEncServer);
            this.Controls.Add(this.richTextBoxEncTextClient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonOpenPrivateServer);
            this.Controls.Add(this.richTextBoxTextForEncClient);
            this.Controls.Add(this.buttonOpenPublicServer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPrivateServer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPublicServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOpenFileForEncClient);
            this.Name = "Form1";
            this.Text = "RSA Encryption/Decryption/DigitalSignature tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenFileForEncClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPublicServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPrivateServer;
        private System.Windows.Forms.Button buttonOpenPublicServer;
        private System.Windows.Forms.RichTextBox richTextBoxTextForEncClient;
        private System.Windows.Forms.Button buttonOpenPrivateServer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBoxEncTextClient;
        private System.Windows.Forms.Button buttonStartEncServer;
        private System.Windows.Forms.Button buttonStartDecServer;
        private System.Windows.Forms.RichTextBox richTextBoxDecTextServer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBoxTextForDecServer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonOpenFileForDecServer;
        private System.Windows.Forms.Button buttonOpenPublicClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPublicClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenFileForSignServer;
        private System.Windows.Forms.Button buttonStartSignServer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonOpenFileForSignClient;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonOpenSignClient;
        private System.Windows.Forms.Button buttonStartVerifyClient;
    }
}

