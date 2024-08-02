namespace QLCHOTHUENHA
{
    partial class frmMain
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
            this.btnNha = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNha
            // 
            this.btnNha.Location = new System.Drawing.Point(30, 108);
            this.btnNha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNha.Name = "btnNha";
            this.btnNha.Size = new System.Drawing.Size(350, 207);
            this.btnNha.TabIndex = 0;
            this.btnNha.Text = "NHÀ";
            this.btnNha.UseVisualStyleBackColor = true;
            this.btnNha.Click += new System.EventHandler(this.btnNha_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Location = new System.Drawing.Point(417, 108);
            this.btnHopDong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(350, 207);
            this.btnHopDong.TabIndex = 1;
            this.btnHopDong.Text = "HỢP ĐỒNG";
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 425);
            this.Controls.Add(this.btnHopDong);
            this.Controls.Add(this.btnNha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMain";
            this.Text = "MAIN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNha;
        private System.Windows.Forms.Button btnHopDong;
    }
}