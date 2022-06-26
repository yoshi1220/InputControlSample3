namespace InputControlSample
{
    partial class CustomerSearchForm
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
            this.customerListGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)(this.customerListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerListGrid
            // 
            this.customerListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerListGrid.Location = new System.Drawing.Point(14, 14);
            this.customerListGrid.Name = "customerListGrid";
            this.customerListGrid.Size = new System.Drawing.Size(873, 483);
            this.customerListGrid.TabIndex = 0;
            this.customerListGrid.Text = "顧客一覧";
            this.customerListGrid.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.customerListGrid_InitializeLayout);
            this.customerListGrid.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.customerListGrid_DoubleClickCell);
            // 
            // CustomerSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.customerListGrid);
            this.Font = new System.Drawing.Font("BIZ UDゴシック", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "CustomerSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顧客検索画面";
            this.Load += new System.EventHandler(this.CustomerSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid customerListGrid;
    }
}