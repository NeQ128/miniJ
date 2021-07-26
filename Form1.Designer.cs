namespace miniJ
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
            this.start_btn = new System.Windows.Forms.Button();
            this.score_lb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.hit_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.start_btn.Location = new System.Drawing.Point(157, 535);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(68, 56);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "両方";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // score_lb
            // 
            this.score_lb.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.score_lb.Location = new System.Drawing.Point(167, 9);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(205, 27);
            this.score_lb.TabIndex = 1;
            this.score_lb.Text = " Score : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(12, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "平仮名";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(253, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "片仮名";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(128, 607);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(125, 22);
            this.input.TabIndex = 4;
            this.input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_KeyUp);
            // 
            // hit_lb
            // 
            this.hit_lb.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hit_lb.Location = new System.Drawing.Point(8, 9);
            this.hit_lb.Name = "hit_lb";
            this.hit_lb.Size = new System.Drawing.Size(153, 27);
            this.hit_lb.TabIndex = 5;
            this.hit_lb.Text = "正解 :  ";
            this.hit_lb.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 641);
            this.Controls.Add(this.hit_lb);
            this.Controls.Add(this.input);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.score_lb);
            this.Controls.Add(this.start_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "miniJ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label hit_lb;
    }
}

