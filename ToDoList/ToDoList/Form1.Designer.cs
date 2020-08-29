namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.TodayToDoList = new System.Windows.Forms.GroupBox();
            this.ToDo3 = new System.Windows.Forms.TextBox();
            this.ToDo2 = new System.Windows.Forms.TextBox();
            this.ToDo1 = new System.Windows.Forms.TextBox();
            this.TodayToDoList.SuspendLayout();
            this.SuspendLayout();
            // 
            // TodayToDoList
            // 
            this.TodayToDoList.Controls.Add(this.ToDo3);
            this.TodayToDoList.Controls.Add(this.ToDo2);
            this.TodayToDoList.Controls.Add(this.ToDo1);
            this.TodayToDoList.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TodayToDoList.Location = new System.Drawing.Point(23, 29);
            this.TodayToDoList.Name = "TodayToDoList";
            this.TodayToDoList.Size = new System.Drawing.Size(787, 297);
            this.TodayToDoList.TabIndex = 0;
            this.TodayToDoList.TabStop = false;
            this.TodayToDoList.Text = "ToDoList";
            // 
            // ToDo3
            // 
            this.ToDo3.Location = new System.Drawing.Point(31, 210);
            this.ToDo3.Name = "ToDo3";
            this.ToDo3.Size = new System.Drawing.Size(724, 48);
            this.ToDo3.TabIndex = 2;
            // 
            // ToDo2
            // 
            this.ToDo2.Location = new System.Drawing.Point(31, 135);
            this.ToDo2.Name = "ToDo2";
            this.ToDo2.Size = new System.Drawing.Size(724, 48);
            this.ToDo2.TabIndex = 1;
            // 
            // ToDo1
            // 
            this.ToDo1.Location = new System.Drawing.Point(31, 60);
            this.ToDo1.Name = "ToDo1";
            this.ToDo1.Size = new System.Drawing.Size(724, 48);
            this.ToDo1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 351);
            this.Controls.Add(this.TodayToDoList);
            this.Name = "Form1";
            this.Text = "ToDoList";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TodayToDoList.ResumeLayout(false);
            this.TodayToDoList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TodayToDoList;
        private System.Windows.Forms.TextBox ToDo3;
        private System.Windows.Forms.TextBox ToDo2;
        private System.Windows.Forms.TextBox ToDo1;
    }
}

