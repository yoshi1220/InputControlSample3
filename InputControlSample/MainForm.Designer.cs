namespace InputControlSample
{
    partial class MainForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonClose = new Infragistics.Win.Misc.UltraButton();
            this.customerInput2 = new InputControlSample.UserControls.CustomerInput();
            this.customerInput1 = new InputControlSample.UserControls.CustomerInput();
            this.customerInput3 = new InputControlSample.UserControls.CustomerInput();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(424, 166);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(125, 40);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.Text = "閉じる";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // customerInput2
            // 
            this.customerInput2.Font = new System.Drawing.Font("BIZ UDゴシック", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.customerInput2.Location = new System.Drawing.Point(29, 68);
            this.customerInput2.Name = "customerInput2";
            this.customerInput2.Size = new System.Drawing.Size(520, 29);
            this.customerInput2.TabIndex = 1;
            // 
            // customerInput1
            // 
            this.customerInput1.Font = new System.Drawing.Font("BIZ UDゴシック", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.customerInput1.Location = new System.Drawing.Point(29, 29);
            this.customerInput1.Name = "customerInput1";
            this.customerInput1.Size = new System.Drawing.Size(520, 29);
            this.customerInput1.TabIndex = 0;
            // 
            // customerInput3
            // 
            this.customerInput3.Font = new System.Drawing.Font("BIZ UDゴシック", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.customerInput3.Location = new System.Drawing.Point(29, 107);
            this.customerInput3.Name = "customerInput3";
            this.customerInput3.Size = new System.Drawing.Size(520, 29);
            this.customerInput3.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 218);
            this.Controls.Add(this.customerInput3);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.customerInput2);
            this.Controls.Add(this.customerInput1);
            this.Font = new System.Drawing.Font("BIZ UDゴシック", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "MainForm";
            this.Text = "サンプル画面";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.CustomerInput customerInput1;
        private UserControls.CustomerInput customerInput2;
        private Infragistics.Win.Misc.UltraButton ButtonClose;
        private UserControls.CustomerInput customerInput3;
    }
}

