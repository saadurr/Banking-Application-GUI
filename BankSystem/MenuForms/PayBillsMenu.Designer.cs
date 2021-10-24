//Author: Saad
namespace ABCSystem
{
    partial class PayBillsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayBillsMenu));
            this.PaymentText = new System.Windows.Forms.Label();
            this.PaymentServiceComboBox = new System.Windows.Forms.ComboBox();
            this.OkayButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaymentText
            // 
            this.PaymentText.AutoSize = true;
            this.PaymentText.Location = new System.Drawing.Point(17, 28);
            this.PaymentText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaymentText.Name = "PaymentText";
            this.PaymentText.Size = new System.Drawing.Size(157, 17);
            this.PaymentText.TabIndex = 0;
            this.PaymentText.Text = "Select Payment Service";
            // 
            // PaymentServiceComboBox
            // 
            this.PaymentServiceComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PaymentServiceComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PaymentServiceComboBox.FormattingEnabled = true;
            this.PaymentServiceComboBox.Items.AddRange(new object[] {
            "Internet Bill",
            "Mobile Recharge",
            "Electricity/Water Bill",
            "Book Ticket"});
            this.PaymentServiceComboBox.Location = new System.Drawing.Point(21, 69);
            this.PaymentServiceComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaymentServiceComboBox.Name = "PaymentServiceComboBox";
            this.PaymentServiceComboBox.Size = new System.Drawing.Size(283, 24);
            this.PaymentServiceComboBox.TabIndex = 1;
            // 
            // OkayButton
            // 
            this.OkayButton.Location = new System.Drawing.Point(21, 123);
            this.OkayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(113, 28);
            this.OkayButton.TabIndex = 2;
            this.OkayButton.Text = "OK";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(174, 123);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 28);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PayBillsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 170);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.PaymentServiceComboBox);
            this.Controls.Add(this.PaymentText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "PayBillsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaymentText;
        private System.Windows.Forms.ComboBox PaymentServiceComboBox;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

//Author: Saad