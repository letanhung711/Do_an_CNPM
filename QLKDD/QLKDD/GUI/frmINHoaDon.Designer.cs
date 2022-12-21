namespace QLKDD.GUI
{
    partial class frmINHoaDon
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
            this.cryin = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryin
            // 
            this.cryin.ActiveViewIndex = -1;
            this.cryin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryin.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryin.Location = new System.Drawing.Point(0, 0);
            this.cryin.Name = "cryin";
            this.cryin.Size = new System.Drawing.Size(1150, 586);
            this.cryin.TabIndex = 0;
            // 
            // frmINHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 586);
            this.Controls.Add(this.cryin);
            this.Name = "frmINHoaDon";
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.frmINHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryin;
    }
}