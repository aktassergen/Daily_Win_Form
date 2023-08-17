namespace WinFormsApp2
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(965, 36);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 17;
            label4.Text = "Daily Read";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 36);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 16;
            label3.Text = "Daily Write";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 36);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 15;
            label2.Text = "Wrote Daily Title";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(296, 59);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(365, 264);
            richTextBox2.TabIndex = 14;
            richTextBox2.Text = "";
            richTextBox2.DoubleClick += richTextBox2_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(607, 385);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 389);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 12;
            label1.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 384);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 27);
            textBox1.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(810, 59);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(383, 264);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(56, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 264);
            listBox1.TabIndex = 9;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private ListBox listBox1;
    }
}