namespace PracticeForm
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
            this.btnUppercaseLetters = new System.Windows.Forms.Button();
            this.btnGeaterThanThirdOne = new System.Windows.Forms.Button();
            this.btnIfSortedAscending = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUppercaseLetters
            // 
            this.btnUppercaseLetters.Location = new System.Drawing.Point(43, 37);
            this.btnUppercaseLetters.Name = "btnUppercaseLetters";
            this.btnUppercaseLetters.Size = new System.Drawing.Size(114, 52);
            this.btnUppercaseLetters.TabIndex = 0;
            this.btnUppercaseLetters.Text = "If consists of uppercase letters";
            this.btnUppercaseLetters.UseVisualStyleBackColor = true;
            this.btnUppercaseLetters.Click += new System.EventHandler(this.btnUppercaseLetters_Click);
            // 
            // btnGeaterThanThirdOne
            // 
            this.btnGeaterThanThirdOne.Location = new System.Drawing.Point(43, 111);
            this.btnGeaterThanThirdOne.Name = "btnGeaterThanThirdOne";
            this.btnGeaterThanThirdOne.Size = new System.Drawing.Size(114, 49);
            this.btnGeaterThanThirdOne.TabIndex = 1;
            this.btnGeaterThanThirdOne.Text = "If greater than third one";
            this.btnGeaterThanThirdOne.UseVisualStyleBackColor = true;
            this.btnGeaterThanThirdOne.Click += new System.EventHandler(this.btnGeaterThanThirdOne_Click);
            // 
            // btnIfSortedAscending
            // 
            this.btnIfSortedAscending.Location = new System.Drawing.Point(43, 182);
            this.btnIfSortedAscending.Name = "btnIfSortedAscending";
            this.btnIfSortedAscending.Size = new System.Drawing.Size(114, 43);
            this.btnIfSortedAscending.TabIndex = 2;
            this.btnIfSortedAscending.Text = "IfSortedAscending";
            this.btnIfSortedAscending.UseVisualStyleBackColor = true;
            this.btnIfSortedAscending.Click += new System.EventHandler(this.btnIfSortedAscending_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "PositiveNegitiveZero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIfSortedAscending);
            this.Controls.Add(this.btnGeaterThanThirdOne);
            this.Controls.Add(this.btnUppercaseLetters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUppercaseLetters;
        private System.Windows.Forms.Button btnGeaterThanThirdOne;
        private System.Windows.Forms.Button btnIfSortedAscending;
        private System.Windows.Forms.Button button1;
    }
}

