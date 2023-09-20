namespace ModInstallerInstaller
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
            selectDirBtn = new Button();
            textBox1 = new TextBox();
            installBtn = new Button();
            runGameBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // selectDirBtn
            // 
            selectDirBtn.Location = new Point(23, 12);
            selectDirBtn.Name = "selectDirBtn";
            selectDirBtn.Size = new Size(200, 38);
            selectDirBtn.TabIndex = 0;
            selectDirBtn.Text = "Select Game Directory...";
            selectDirBtn.UseVisualStyleBackColor = true;
            selectDirBtn.Click += selectDirBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "C:/";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // installBtn
            // 
            installBtn.Location = new Point(23, 56);
            installBtn.Name = "installBtn";
            installBtn.Size = new Size(200, 50);
            installBtn.TabIndex = 2;
            installBtn.Text = "Install";
            installBtn.UseVisualStyleBackColor = true;
            installBtn.Click += installBtn_Click;
            // 
            // runGameBtn
            // 
            runGameBtn.Location = new Point(234, 56);
            runGameBtn.Name = "runGameBtn";
            runGameBtn.Size = new Size(220, 50);
            runGameBtn.TabIndex = 3;
            runGameBtn.Text = "Run Game";
            runGameBtn.UseVisualStyleBackColor = true;
            runGameBtn.Click += runGameBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 109);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 4;
            label1.Text = "Status: Ready";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 139);
            Controls.Add(label1);
            Controls.Add(runGameBtn);
            Controls.Add(installBtn);
            Controls.Add(textBox1);
            Controls.Add(selectDirBtn);
            Name = "Form1";
            Text = "SFS ModInstaller Installer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectDirBtn;
        private TextBox textBox1;
        private Button installBtn;
        private Button runGameBtn;
        private Label label1;
    }
}