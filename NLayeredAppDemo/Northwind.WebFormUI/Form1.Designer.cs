
namespace Northwind.WebFormUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxKatagory = new System.Windows.Forms.GroupBox();
            this.gbxUrun = new System.Windows.Forms.GroupBox();
            this.lblKatagory = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.cbxKatagory = new System.Windows.Forms.ComboBox();
            this.tbxUrun = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxKatagory.SuspendLayout();
            this.gbxUrun.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 12);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(509, 150);
            this.dgwProduct.TabIndex = 0;
            // 
            // gbxKatagory
            // 
            this.gbxKatagory.Controls.Add(this.cbxKatagory);
            this.gbxKatagory.Controls.Add(this.lblKatagory);
            this.gbxKatagory.Location = new System.Drawing.Point(12, 168);
            this.gbxKatagory.Name = "gbxKatagory";
            this.gbxKatagory.Size = new System.Drawing.Size(260, 64);
            this.gbxKatagory.TabIndex = 1;
            this.gbxKatagory.TabStop = false;
            this.gbxKatagory.Text = "Katagorye gore ara";
            // 
            // gbxUrun
            // 
            this.gbxUrun.Controls.Add(this.tbxUrun);
            this.gbxUrun.Controls.Add(this.lblUrun);
            this.gbxUrun.Location = new System.Drawing.Point(12, 262);
            this.gbxUrun.Name = "gbxUrun";
            this.gbxUrun.Size = new System.Drawing.Size(260, 63);
            this.gbxUrun.TabIndex = 2;
            this.gbxUrun.TabStop = false;
            this.gbxUrun.Text = "Urun ismine gore ara";
            // 
            // lblKatagory
            // 
            this.lblKatagory.AutoSize = true;
            this.lblKatagory.Location = new System.Drawing.Point(19, 29);
            this.lblKatagory.Name = "lblKatagory";
            this.lblKatagory.Size = new System.Drawing.Size(49, 13);
            this.lblKatagory.TabIndex = 3;
            this.lblKatagory.Text = "Katagory";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(19, 34);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(50, 13);
            this.lblUrun.TabIndex = 3;
            this.lblUrun.Text = "Urun ismi";
            // 
            // cbxKatagory
            // 
            this.cbxKatagory.FormattingEnabled = true;
            this.cbxKatagory.Location = new System.Drawing.Point(83, 26);
            this.cbxKatagory.Name = "cbxKatagory";
            this.cbxKatagory.Size = new System.Drawing.Size(121, 21);
            this.cbxKatagory.TabIndex = 3;
            // 
            // tbxUrun
            // 
            this.tbxUrun.Location = new System.Drawing.Point(83, 27);
            this.tbxUrun.Name = "tbxUrun";
            this.tbxUrun.Size = new System.Drawing.Size(121, 20);
            this.tbxUrun.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxUrun);
            this.Controls.Add(this.gbxKatagory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxKatagory.ResumeLayout(false);
            this.gbxKatagory.PerformLayout();
            this.gbxUrun.ResumeLayout(false);
            this.gbxUrun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxKatagory;
        private System.Windows.Forms.ComboBox cbxKatagory;
        private System.Windows.Forms.Label lblKatagory;
        private System.Windows.Forms.GroupBox gbxUrun;
        private System.Windows.Forms.TextBox tbxUrun;
        private System.Windows.Forms.Label lblUrun;
    }
}

