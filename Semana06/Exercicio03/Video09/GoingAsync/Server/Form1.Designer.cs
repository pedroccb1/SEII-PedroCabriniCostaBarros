namespace Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            lstText = new ListView();
            lblInfo = new Label();
            pbImage = new PictureBox();
            btnListen = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // lstText
            // 
            lstText.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lstText.Location = new Point(274, 57);
            lstText.Name = "lstText";
            lstText.Size = new Size(295, 259);
            lstText.TabIndex = 0;
            lstText.UseCompatibleStateImageBehavior = false;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(274, 23);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(87, 20);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Connected: ";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(12, 23);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(256, 246);
            pbImage.TabIndex = 2;
            pbImage.TabStop = false;
            // 
            // btnListen
            // 
            btnListen.Location = new Point(12, 275);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(118, 41);
            btnListen.TabIndex = 3;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(136, 275);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(132, 41);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 328);
            Controls.Add(btnClose);
            Controls.Add(btnListen);
            Controls.Add(pbImage);
            Controls.Add(lblInfo);
            Controls.Add(lstText);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstText;
        private Label lblInfo;
        private PictureBox pbImage;
        private Button btnListen;
        private Button btnClose;
    }
}
