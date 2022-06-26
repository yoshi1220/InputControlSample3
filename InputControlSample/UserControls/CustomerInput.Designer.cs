namespace InputControlSample.UserControls
{
    partial class CustomerInput
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            this.CustomerSearchButton = new Infragistics.Win.Misc.UltraButton();
            this.CustomerNameLabel = new Infragistics.Win.Misc.UltraLabel();
            this.CustomerIdText = new InputControlSample.UserControls.UserTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIdText)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerSearchButton
            // 
            this.CustomerSearchButton.Location = new System.Drawing.Point(179, 0);
            this.CustomerSearchButton.Name = "CustomerSearchButton";
            this.CustomerSearchButton.Size = new System.Drawing.Size(48, 29);
            this.CustomerSearchButton.TabIndex = 1;
            this.CustomerSearchButton.TabStop = false;
            this.CustomerSearchButton.Text = "検索";
            this.CustomerSearchButton.Click += new System.EventHandler(this.CustomerSearchButton_Click);
            // 
            // CustomerNameLabel
            // 
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            appearance4.TextHAlignAsString = "Left";
            appearance4.TextVAlignAsString = "Middle";
            this.CustomerNameLabel.Appearance = appearance4;
            this.CustomerNameLabel.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid;
            this.CustomerNameLabel.Location = new System.Drawing.Point(227, 1);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(293, 27);
            this.CustomerNameLabel.TabIndex = 2;
            // 
            // CustomerIdText
            // 
            this.CustomerIdText.AutoSize = false;
            this.CustomerIdText.Location = new System.Drawing.Point(0, 1);
            this.CustomerIdText.MaxInputBytes = 32767;
            this.CustomerIdText.Name = "CustomerIdText";
            this.CustomerIdText.Size = new System.Drawing.Size(179, 27);
            this.CustomerIdText.TabIndex = 0;
            this.CustomerIdText.Validated += new System.EventHandler(this.CustomerIdText_Validated);
            // 
            // CustomerInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerSearchButton);
            this.Controls.Add(this.CustomerIdText);
            this.Font = new System.Drawing.Font("BIZ UDゴシック", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "CustomerInput";
            this.Size = new System.Drawing.Size(520, 29);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIdText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserTextEditor CustomerIdText;
        private Infragistics.Win.Misc.UltraButton CustomerSearchButton;
        private Infragistics.Win.Misc.UltraLabel CustomerNameLabel;
    }
}
