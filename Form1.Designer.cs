namespace _01BASIC
{
    partial class winform
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComBox = new System.Windows.Forms.ComboBox();
            this.coon_btn = new System.Windows.Forms.Button();
            this.button1_ON = new System.Windows.Forms.Button();
            this.button1_OFF = new System.Windows.Forms.Button();
            this.button2_ON = new System.Windows.Forms.Button();
            this.button2_OFF = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComBox
            // 
            this.ComBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox.FormattingEnabled = true;
            this.ComBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.ComBox.Location = new System.Drawing.Point(43, 28);
            this.ComBox.Name = "ComBox";
            this.ComBox.Size = new System.Drawing.Size(121, 20);
            this.ComBox.TabIndex = 0;
            this.ComBox.SelectedIndexChanged += new System.EventHandler(this.ComBox_SelectedIndexChanged);
            // 
            // coon_btn
            // 
            this.coon_btn.Location = new System.Drawing.Point(196, 28);
            this.coon_btn.Name = "coon_btn";
            this.coon_btn.Size = new System.Drawing.Size(121, 20);
            this.coon_btn.TabIndex = 1;
            this.coon_btn.Text = "연결";
            this.coon_btn.UseVisualStyleBackColor = true;
            this.coon_btn.Click += new System.EventHandler(this.coon_btn_Click_1);
            // 
            // button1_ON
            // 
            this.button1_ON.Location = new System.Drawing.Point(43, 88);
            this.button1_ON.Name = "button1_ON";
            this.button1_ON.Size = new System.Drawing.Size(121, 50);
            this.button1_ON.TabIndex = 2;
            this.button1_ON.Text = "LED_01_ON";
            this.button1_ON.UseVisualStyleBackColor = true;
            this.button1_ON.Click += new System.EventHandler(this.button1_ON_Click);
            // 
            // button1_OFF
            // 
            this.button1_OFF.Location = new System.Drawing.Point(196, 88);
            this.button1_OFF.Name = "button1_OFF";
            this.button1_OFF.Size = new System.Drawing.Size(121, 50);
            this.button1_OFF.TabIndex = 3;
            this.button1_OFF.Text = "LED_01_OFF";
            this.button1_OFF.UseVisualStyleBackColor = true;
            this.button1_OFF.Click += new System.EventHandler(this.button1_OFF_Click);
            // 
            // button2_ON
            // 
            this.button2_ON.Location = new System.Drawing.Point(43, 160);
            this.button2_ON.Name = "button2_ON";
            this.button2_ON.Size = new System.Drawing.Size(121, 50);
            this.button2_ON.TabIndex = 4;
            this.button2_ON.Text = "LED_02_ON";
            this.button2_ON.UseVisualStyleBackColor = true;
            this.button2_ON.Click += new System.EventHandler(this.button2_ON_Click);
            // 
            // button2_OFF
            // 
            this.button2_OFF.Location = new System.Drawing.Point(196, 160);
            this.button2_OFF.Name = "button2_OFF";
            this.button2_OFF.Size = new System.Drawing.Size(121, 50);
            this.button2_OFF.TabIndex = 5;
            this.button2_OFF.Text = "LED_02_OFF";
            this.button2_OFF.UseVisualStyleBackColor = true;
            this.button2_OFF.Click += new System.EventHandler(this.button2_OFF_Click);
            // 
            // Message
            // 
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message.Enabled = false;
            this.Message.Location = new System.Drawing.Point(43, 267);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Size = new System.Drawing.Size(281, 21);
            this.Message.TabIndex = 6;
            this.Message.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Message :";
            // 
            // winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.button2_OFF);
            this.Controls.Add(this.button2_ON);
            this.Controls.Add(this.button1_OFF);
            this.Controls.Add(this.button1_ON);
            this.Controls.Add(this.coon_btn);
            this.Controls.Add(this.ComBox);
            this.Name = "winform";
            this.Text = "WINFORMTEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComBox;
        private System.Windows.Forms.Button coon_btn;
        private System.Windows.Forms.Button button1_ON;
        private System.Windows.Forms.Button button1_OFF;
        private System.Windows.Forms.Button button2_ON;
        private System.Windows.Forms.Button button2_OFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Message;
    }
}

