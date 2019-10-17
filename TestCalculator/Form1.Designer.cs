namespace TestCalculator
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
            this.box1 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.ansBox = new System.Windows.Forms.TextBox();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(32, 23);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(100, 20);
            this.box1.TabIndex = 0;
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(32, 58);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(100, 20);
            this.box2.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(43, 84);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ansBox
            // 
            this.ansBox.Location = new System.Drawing.Point(153, 42);
            this.ansBox.Name = "ansBox";
            this.ansBox.ReadOnly = true;
            this.ansBox.Size = new System.Drawing.Size(100, 20);
            this.ansBox.TabIndex = 3;
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Location = new System.Drawing.Point(43, 128);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(75, 23);
            this.multiplyBtn.TabIndex = 4;
            this.multiplyBtn.Text = "Multiply";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(153, 84);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(75, 23);
            this.subBtn.TabIndex = 5;
            this.subBtn.Text = "Subtract";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(153, 128);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(75, 23);
            this.divBtn.TabIndex = 6;
            this.divBtn.Text = "Divide";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 205);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.ansBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox ansBox;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button button1;
    }
}

