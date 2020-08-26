namespace ToDoList
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TodayToDo1 = new System.Windows.Forms.TextBox();
            this.TodayToDo2 = new System.Windows.Forms.TextBox();
            this.TodayToDo3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TodayToDo3);
            this.groupBox1.Controls.Add(this.TodayToDo2);
            this.groupBox1.Controls.Add(this.TodayToDo1);
            this.groupBox1.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "本日やること";
            // 
            // TodayToDo1
            // 
            this.TodayToDo1.Location = new System.Drawing.Point(24, 47);
            this.TodayToDo1.Name = "TodayToDo1";
            this.TodayToDo1.Size = new System.Drawing.Size(785, 48);
            this.TodayToDo1.TabIndex = 0;
            // 
            // TodayToDo2
            // 
            this.TodayToDo2.Location = new System.Drawing.Point(24, 117);
            this.TodayToDo2.Name = "TodayToDo2";
            this.TodayToDo2.Size = new System.Drawing.Size(785, 48);
            this.TodayToDo2.TabIndex = 1;
            // 
            // TodayToDo3
            // 
            this.TodayToDo3.Location = new System.Drawing.Point(24, 189);
            this.TodayToDo3.Name = "TodayToDo3";
            this.TodayToDo3.Size = new System.Drawing.Size(785, 48);
            this.TodayToDo3.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1096, 382);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Opacity = 0.5D;
            this.Text = "MainForm";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TodayToDo3;
        private System.Windows.Forms.TextBox TodayToDo2;
        private System.Windows.Forms.TextBox TodayToDo1;
    }
}