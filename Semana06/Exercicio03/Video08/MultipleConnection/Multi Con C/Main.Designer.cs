namespace Multi_Con_C;

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
        button1 = new Button();
        button2 = new Button();
        textBox1 = new TextBox();
        button3 = new Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(12, 12);
        button1.Name = "button1";
        button1.Size = new Size(125, 29);
        button1.TabIndex = 0;
        button1.Text = "Connect";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(12, 47);
        button2.Name = "button2";
        button2.Size = new Size(125, 29);
        button2.TabIndex = 1;
        button2.Text = "Send";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(12, 82);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(125, 27);
        textBox1.TabIndex = 2;
        // 
        // button3
        // 
        button3.Location = new Point(12, 115);
        button3.Name = "button3";
        button3.Size = new Size(125, 29);
        button3.TabIndex = 3;
        button3.Text = "Close";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(160, 154);
        Controls.Add(button3);
        Controls.Add(textBox1);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private TextBox textBox1;
    private Button button3;
}
