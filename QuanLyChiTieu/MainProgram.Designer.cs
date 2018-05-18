namespace Demo
{
    partial class MainProgram
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
            this.btnSpend = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.btnDiary = new System.Windows.Forms.Button();
            this.btnIput = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSpend
            // 
            this.btnSpend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpend.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSpend.Location = new System.Drawing.Point(1, 3);
            this.btnSpend.Name = "btnSpend";
            this.btnSpend.Size = new System.Drawing.Size(74, 37);
            this.btnSpend.TabIndex = 0;
            this.btnSpend.Text = "Chi Tiêu";
            this.btnSpend.UseVisualStyleBackColor = true;
            this.btnSpend.Click += new System.EventHandler(this.btnSpend_Click);
            // 
            // btnPresent
            // 
            this.btnPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresent.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnPresent.Location = new System.Drawing.Point(73, 3);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(73, 37);
            this.btnPresent.TabIndex = 1;
            this.btnPresent.Text = "Hiện Tại";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // btnDiary
            // 
            this.btnDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiary.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDiary.Location = new System.Drawing.Point(145, 3);
            this.btnDiary.Name = "btnDiary";
            this.btnDiary.Size = new System.Drawing.Size(72, 37);
            this.btnDiary.TabIndex = 2;
            this.btnDiary.Text = "Nhật Ký";
            this.btnDiary.UseVisualStyleBackColor = true;
            this.btnDiary.Click += new System.EventHandler(this.btnDiary_Click);
            // 
            // btnIput
            // 
            this.btnIput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIput.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnIput.Location = new System.Drawing.Point(216, 3);
            this.btnIput.Name = "btnIput";
            this.btnIput.Size = new System.Drawing.Size(72, 37);
            this.btnIput.TabIndex = 3;
            this.btnIput.Text = "Nhập";
            this.btnIput.UseVisualStyleBackColor = true;
            this.btnIput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(1, 45);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(289, 370);
            this.pnlMain.TabIndex = 1;
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 420);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnIput);
            this.Controls.Add(this.btnDiary);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.btnSpend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi tiêu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpend;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btnDiary;
        private System.Windows.Forms.Button btnIput;
        private System.Windows.Forms.Panel pnlMain;
    }
}

