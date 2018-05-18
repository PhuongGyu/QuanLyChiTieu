namespace Demo
{
    partial class SpendShow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(2, 0);
            this.txbName.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(165, 29);
            this.txbName.TabIndex = 0;
            this.txbName.Text = "Ăn Sáng";
            // 
            // txbMoney
            // 
            this.txbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMoney.Location = new System.Drawing.Point(167, 0);
            this.txbMoney.Name = "txbMoney";
            this.txbMoney.Size = new System.Drawing.Size(90, 29);
            this.txbMoney.TabIndex = 1;
            this.txbMoney.Text = "20000";
            // 
            // DiaryShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbMoney);
            this.Controls.Add(this.txbName);
            this.Name = "DiaryShow";
            this.Size = new System.Drawing.Size(258, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbMoney;
    }
}
