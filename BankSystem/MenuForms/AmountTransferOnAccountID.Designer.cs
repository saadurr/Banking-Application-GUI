//Author: Saad

namespace ABCSystem
{
    partial class AmountTransferOnAccountID
    {
  
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmountTransferOnAccountID));
            this.TextLabelMessage = new System.Windows.Forms.Label();
            this.AccountIDInput = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextLabelMessage
            // 
            this.TextLabelMessage.AutoSize = true;
            this.TextLabelMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabelMessage.Location = new System.Drawing.Point(16, 22);
            this.TextLabelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextLabelMessage.Name = "TextLabelMessage";
            this.TextLabelMessage.Size = new System.Drawing.Size(295, 21);
            this.TextLabelMessage.TabIndex = 0;
            this.TextLabelMessage.Text = "Please Enter Beneficiary\'s Account ID:";
            // 
            // AccountIDInput
            // 
            this.AccountIDInput.Location = new System.Drawing.Point(21, 60);
            this.AccountIDInput.Margin = new System.Windows.Forms.Padding(4);
            this.AccountIDInput.Name = "AccountIDInput";
            this.AccountIDInput.Size = new System.Drawing.Size(279, 22);
            this.AccountIDInput.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(21, 111);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(117, 28);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(169, 111);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(111, 28);
            this.Cancelbutton.TabIndex = 3;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // TransferToEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 158);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.AccountIDInput);
            this.Controls.Add(this.TextLabelMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TransferToEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Amount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextLabelMessage;
        private System.Windows.Forms.TextBox AccountIDInput;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button Cancelbutton;
    }
}
//Author: Saad