namespace CRUDTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.NowPageText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.CleanBtn = new System.Windows.Forms.Button();
            this.logText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_QueryKetword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.QueryBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "事件1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(386, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "事件2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(386, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "事件3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(386, 64);
            this.button4.TabIndex = 3;
            this.button4.Text = "事件4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(37, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(386, 64);
            this.button5.TabIndex = 4;
            this.button5.Text = "事件5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Location = new System.Drawing.Point(37, 387);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(125, 51);
            this.PreviousBtn.TabIndex = 5;
            this.PreviousBtn.Text = "上一頁";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(298, 387);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(125, 51);
            this.NextBtn.TabIndex = 6;
            this.NextBtn.Text = "下一頁";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // NowPageText
            // 
            this.NowPageText.AutoSize = true;
            this.NowPageText.Location = new System.Drawing.Point(174, 405);
            this.NowPageText.Name = "NowPageText";
            this.NowPageText.Size = new System.Drawing.Size(118, 15);
            this.NowPageText.TabIndex = 7;
            this.NowPageText.Text = "當前位於第999頁";
            this.NowPageText.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "事件標題";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(464, 160);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(257, 25);
            this.textBox_Title.TabIndex = 9;
            // 
            // textBox_Content
            // 
            this.textBox_Content.Location = new System.Drawing.Point(464, 231);
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.Size = new System.Drawing.Size(257, 25);
            this.textBox_Content.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "事件內容";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(454, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 25);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "結束時間";
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(473, 357);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(125, 51);
            this.EnterBtn.TabIndex = 14;
            this.EnterBtn.Text = "確認";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // CleanBtn
            // 
            this.CleanBtn.Location = new System.Drawing.Point(641, 357);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(125, 51);
            this.CleanBtn.TabIndex = 15;
            this.CleanBtn.Text = "清空";
            this.CleanBtn.UseVisualStyleBackColor = true;
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // logText
            // 
            this.logText.AutoSize = true;
            this.logText.Location = new System.Drawing.Point(579, 423);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(0, 15);
            this.logText.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("新細明體", 20F);
            this.label6.Location = new System.Drawing.Point(458, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 34);
            this.label6.TabIndex = 17;
            this.label6.Text = "新增事件";
            // 
            // textBox_QueryKetword
            // 
            this.textBox_QueryKetword.Location = new System.Drawing.Point(449, 43);
            this.textBox_QueryKetword.Name = "textBox_QueryKetword";
            this.textBox_QueryKetword.Size = new System.Drawing.Size(219, 25);
            this.textBox_QueryKetword.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "關鍵字搜尋";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // QueryBtn
            // 
            this.QueryBtn.Location = new System.Drawing.Point(674, 21);
            this.QueryBtn.Name = "QueryBtn";
            this.QueryBtn.Size = new System.Drawing.Size(101, 41);
            this.QueryBtn.TabIndex = 20;
            this.QueryBtn.Text = "查詢";
            this.QueryBtn.UseVisualStyleBackColor = true;
            this.QueryBtn.Click += new System.EventHandler(this.QueryBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "準備中",
            "進行中",
            "已完成",
            "結束"});
            this.comboBox1.Location = new System.Drawing.Point(621, 297);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "進行狀態";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.QueryBtn);
            this.Controls.Add(this.textBox_QueryKetword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.CleanBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Content);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NowPageText);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PreviousBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label NowPageText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button CleanBtn;
        private System.Windows.Forms.Label logText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_QueryKetword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button QueryBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}

