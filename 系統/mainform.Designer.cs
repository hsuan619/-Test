namespace 系統
{
    partial class mainform
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
            this.buttonsign = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.outputexcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonsign
            // 
            this.buttonsign.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonsign.Location = new System.Drawing.Point(126, 160);
            this.buttonsign.Name = "buttonsign";
            this.buttonsign.Size = new System.Drawing.Size(203, 104);
            this.buttonsign.TabIndex = 0;
            this.buttonsign.Text = "註冊會員";
            this.buttonsign.UseVisualStyleBackColor = true;
            this.buttonsign.Click += new System.EventHandler(this.buttonsign_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonsearch.Location = new System.Drawing.Point(401, 160);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(203, 104);
            this.buttonsearch.TabIndex = 1;
            this.buttonsearch.Text = "查詢會員";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // outputexcel
            // 
            this.outputexcel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputexcel.Location = new System.Drawing.Point(680, 160);
            this.outputexcel.Name = "outputexcel";
            this.outputexcel.Size = new System.Drawing.Size(279, 104);
            this.outputexcel.TabIndex = 2;
            this.outputexcel.Text = "輸出會員資料";
            this.outputexcel.UseVisualStyleBackColor = true;
            this.outputexcel.Click += new System.EventHandler(this.outputexcel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1017, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "離開";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputexcel);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.buttonsign);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainform";
            this.Text = "會員系統";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonsign;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button outputexcel;
        private System.Windows.Forms.Button button1;
    }
}