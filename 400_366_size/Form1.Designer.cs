namespace _400_366_size
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
            this.btn_selectFolder = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_Folder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.btn_Check = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_selectFolder
            // 
            this.btn_selectFolder.Location = new System.Drawing.Point(661, 5);
            this.btn_selectFolder.Name = "btn_selectFolder";
            this.btn_selectFolder.Size = new System.Drawing.Size(96, 30);
            this.btn_selectFolder.TabIndex = 1;
            this.btn_selectFolder.Text = "选择文件夹";
            this.btn_selectFolder.UseVisualStyleBackColor = true;
            this.btn_selectFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(745, 419);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // txt_Folder
            // 
            this.txt_Folder.Location = new System.Drawing.Point(136, 10);
            this.txt_Folder.Name = "txt_Folder";
            this.txt_Folder.Size = new System.Drawing.Size(508, 25);
            this.txt_Folder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "JCV图片文件夹：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Heigh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width:";
            // 
            // txt_Height
            // 
            this.txt_Height.Location = new System.Drawing.Point(136, 41);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(100, 25);
            this.txt_Height.TabIndex = 7;
            // 
            // txt_Width
            // 
            this.txt_Width.Location = new System.Drawing.Point(136, 72);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(100, 25);
            this.txt_Width.TabIndex = 8;
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(661, 63);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(96, 31);
            this.btn_Check.TabIndex = 9;
            this.btn_Check.Text = "检测";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "像素";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "像素";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 534);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.txt_Width);
            this.Controls.Add(this.txt_Height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Folder);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_selectFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_selectFolder;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_Folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

