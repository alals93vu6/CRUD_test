namespace CRUDTest
{
    partial class Form2
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBox_preparing = new System.Windows.Forms.CheckBox();
            this.checkBox_inProgress = new System.Windows.Forms.CheckBox();
            this.checkBox_completed = new System.Windows.Forms.CheckBox();
            this.checkBox_finished = new System.Windows.Forms.CheckBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // titleTextBox
            //
            this.titleTextBox.Location = new System.Drawing.Point(60, 160);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(280, 25);
            this.titleTextBox.TabIndex = 0;
            //
            // contentTextBox
            //
            this.contentTextBox.Location = new System.Drawing.Point(60, 240);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(280, 80);
            this.contentTextBox.TabIndex = 1;
            //
            // endTimePicker
            //
            this.endTimePicker.Location = new System.Drawing.Point(420, 160);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(200, 25);
            this.endTimePicker.TabIndex = 2;
            //
            // checkBox_preparing
            //
            this.checkBox_preparing.AutoSize = true;
            this.checkBox_preparing.Location = new System.Drawing.Point(420, 240);
            this.checkBox_preparing.Name = "checkBox_preparing";
            this.checkBox_preparing.Size = new System.Drawing.Size(79, 19);
            this.checkBox_preparing.TabIndex = 3;
            this.checkBox_preparing.Text = "準備中";
            this.checkBox_preparing.UseVisualStyleBackColor = true;
            this.checkBox_preparing.CheckedChanged += new System.EventHandler(this.statusCheckBox_CheckedChanged);
            //
            // checkBox_inProgress
            //
            this.checkBox_inProgress.AutoSize = true;
            this.checkBox_inProgress.Location = new System.Drawing.Point(540, 240);
            this.checkBox_inProgress.Name = "checkBox_inProgress";
            this.checkBox_inProgress.Size = new System.Drawing.Size(79, 19);
            this.checkBox_inProgress.TabIndex = 4;
            this.checkBox_inProgress.Text = "進行中";
            this.checkBox_inProgress.UseVisualStyleBackColor = true;
            this.checkBox_inProgress.CheckedChanged += new System.EventHandler(this.statusCheckBox_CheckedChanged);
            //
            // checkBox_completed
            //
            this.checkBox_completed.AutoSize = true;
            this.checkBox_completed.Location = new System.Drawing.Point(420, 280);
            this.checkBox_completed.Name = "checkBox_completed";
            this.checkBox_completed.Size = new System.Drawing.Size(64, 19);
            this.checkBox_completed.TabIndex = 5;
            this.checkBox_completed.Text = "完成";
            this.checkBox_completed.UseVisualStyleBackColor = true;
            this.checkBox_completed.CheckedChanged += new System.EventHandler(this.statusCheckBox_CheckedChanged);
            //
            // checkBox_finished
            //
            this.checkBox_finished.AutoSize = true;
            this.checkBox_finished.Location = new System.Drawing.Point(540, 280);
            this.checkBox_finished.Name = "checkBox_finished";
            this.checkBox_finished.Size = new System.Drawing.Size(64, 19);
            this.checkBox_finished.TabIndex = 6;
            this.checkBox_finished.Text = "結束";
            this.checkBox_finished.UseVisualStyleBackColor = true;
            this.checkBox_finished.CheckedChanged += new System.EventHandler(this.statusCheckBox_CheckedChanged);
            //
            // confirmButton
            //
            this.confirmButton.Location = new System.Drawing.Point(100, 350);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 40);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "確認";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            //
            // deleteButton
            //
            this.deleteButton.Location = new System.Drawing.Point(250, 350);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 40);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "刪除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            //
            // closeButton
            //
            this.closeButton.Location = new System.Drawing.Point(500, 350);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 40);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "關閉";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(60, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "標題";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(60, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "內容";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(420, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "結束時間";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(420, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "狀態";
            //
            // Form2
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.checkBox_finished);
            this.Controls.Add(this.checkBox_completed);
            this.Controls.Add(this.checkBox_inProgress);
            this.Controls.Add(this.checkBox_preparing);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.titleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "編輯事件";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox titleTextBox;
        public System.Windows.Forms.TextBox contentTextBox;
        public System.Windows.Forms.DateTimePicker endTimePicker;
        public System.Windows.Forms.CheckBox checkBox_preparing;
        public System.Windows.Forms.CheckBox checkBox_inProgress;
        public System.Windows.Forms.CheckBox checkBox_completed;
        public System.Windows.Forms.CheckBox checkBox_finished;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}