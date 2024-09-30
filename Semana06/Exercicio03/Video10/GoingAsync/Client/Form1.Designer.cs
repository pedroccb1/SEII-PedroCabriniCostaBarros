namespace Client
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
            btnConnect = new Button();
            btnSendText = new Button();
            txtBox = new TextBox();
            btnImage = new Button();
            btnDisconnect = new Button();
            lblDataSent = new Label();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 12);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(247, 29);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnSendText
            // 
            btnSendText.Location = new Point(12, 47);
            btnSendText.Name = "btnSendText";
            btnSendText.Size = new Size(116, 29);
            btnSendText.TabIndex = 1;
            btnSendText.Text = "Send Text";
            btnSendText.UseVisualStyleBackColor = true;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(134, 47);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(125, 27);
            txtBox.TabIndex = 2;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(12, 82);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(247, 29);
            btnImage.TabIndex = 3;
            btnImage.Text = "Send Image";
            btnImage.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(12, 115);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(247, 29);
            btnDisconnect.TabIndex = 4;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // lblDataSent
            // 
            lblDataSent.AutoSize = true;
            lblDataSent.Location = new Point(12, 147);
            lblDataSent.Name = "lblDataSent";
            lblDataSent.Size = new Size(77, 20);
            lblDataSent.TabIndex = 5;
            lblDataSent.Text = "Data Sent:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 176);
            Controls.Add(lblDataSent);
            Controls.Add(btnDisconnect);
            Controls.Add(btnImage);
            Controls.Add(txtBox);
            Controls.Add(btnSendText);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Button btnSendText;
        private TextBox txtBox;
        private Button btnImage;
        private Button btnDisconnect;
        private Label lblDataSent;
    }
}
