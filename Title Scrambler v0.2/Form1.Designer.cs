namespace Title_Scrambler_v0._2
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
            this.button_browse = new System.Windows.Forms.Button();
            this.button_execute = new System.Windows.Forms.Button();
            this.textBox_extension = new System.Windows.Forms.TextBox();
            this.textBox_directory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(305, 44);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 0;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_execute
            // 
            this.button_execute.Location = new System.Drawing.Point(305, 98);
            this.button_execute.Name = "button_execute";
            this.button_execute.Size = new System.Drawing.Size(75, 23);
            this.button_execute.TabIndex = 1;
            this.button_execute.Text = "Scramble!";
            this.button_execute.UseVisualStyleBackColor = true;
            this.button_execute.Click += new System.EventHandler(this.button_execute_Click);
            // 
            // textBox_extension
            // 
            this.textBox_extension.Location = new System.Drawing.Point(27, 101);
            this.textBox_extension.Name = "textBox_extension";
            this.textBox_extension.Size = new System.Drawing.Size(254, 20);
            this.textBox_extension.TabIndex = 2;
            // 
            // textBox_directory
            // 
            this.textBox_directory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_directory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_directory.Location = new System.Drawing.Point(27, 44);
            this.textBox_directory.Name = "textBox_directory";
            this.textBox_directory.Size = new System.Drawing.Size(254, 20);
            this.textBox_directory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extension (.mp3, .txt etc)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 164);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_directory);
            this.Controls.Add(this.textBox_extension);
            this.Controls.Add(this.button_execute);
            this.Controls.Add(this.button_browse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_execute;
        private System.Windows.Forms.TextBox textBox_extension;
        private System.Windows.Forms.TextBox textBox_directory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

