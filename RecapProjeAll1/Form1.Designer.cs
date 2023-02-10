
namespace RecapProjeAll1
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
            this.gbxCatagory = new System.Windows.Forms.GroupBox();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.cbxCatagory = new System.Windows.Forms.ComboBox();
            this.gbxSecarch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxCatagory.SuspendLayout();
            this.gbxSecarch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCatagory
            // 
            this.gbxCatagory.Controls.Add(this.lblCatagory);
            this.gbxCatagory.Controls.Add(this.cbxCatagory);
            this.gbxCatagory.Location = new System.Drawing.Point(25, 12);
            this.gbxCatagory.Name = "gbxCatagory";
            this.gbxCatagory.Size = new System.Drawing.Size(749, 76);
            this.gbxCatagory.TabIndex = 0;
            this.gbxCatagory.TabStop = false;
            this.gbxCatagory.Text = "Karagorye gore listele";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(52, 45);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(49, 13);
            this.lblCatagory.TabIndex = 1;
            this.lblCatagory.Text = "Katagory";
            // 
            // cbxCatagory
            // 
            this.cbxCatagory.FormattingEnabled = true;
            this.cbxCatagory.Location = new System.Drawing.Point(137, 37);
            this.cbxCatagory.Name = "cbxCatagory";
            this.cbxCatagory.Size = new System.Drawing.Size(121, 21);
            this.cbxCatagory.TabIndex = 0;
            this.cbxCatagory.SelectedIndexChanged += new System.EventHandler(this.cbxCatagory_SelectedIndexChanged);
            // 
            // gbxSecarch
            // 
            this.gbxSecarch.Controls.Add(this.tbxSearch);
            this.gbxSecarch.Controls.Add(this.lblSearch);
            this.gbxSecarch.Location = new System.Drawing.Point(25, 109);
            this.gbxSecarch.Name = "gbxSecarch";
            this.gbxSecarch.Size = new System.Drawing.Size(749, 74);
            this.gbxSecarch.TabIndex = 1;
            this.gbxSecarch.TabStop = false;
            this.gbxSecarch.Text = "Urun Ismine Gore Ara";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(137, 32);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(30, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(23, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Ara";
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(22, 245);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(752, 150);
            this.dgwProducts.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.gbxSecarch);
            this.Controls.Add(this.gbxCatagory);
            this.Name = "Form1";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCatagory.ResumeLayout(false);
            this.gbxCatagory.PerformLayout();
            this.gbxSecarch.ResumeLayout(false);
            this.gbxSecarch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCatagory;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.ComboBox cbxCatagory;
        private System.Windows.Forms.GroupBox gbxSecarch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwProducts;
    }
}

