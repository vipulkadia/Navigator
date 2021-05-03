namespace NavigatorApplication
{
    partial class frmNavigator
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
            this.txtInputInstructions = new System.Windows.Forms.TextBox();
            this.txtOutputResult = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputInstructions
            // 
            this.txtInputInstructions.Location = new System.Drawing.Point(34, 50);
            this.txtInputInstructions.Multiline = true;
            this.txtInputInstructions.Name = "txtInputInstructions";
            this.txtInputInstructions.Size = new System.Drawing.Size(561, 161);
            this.txtInputInstructions.TabIndex = 0;
            // 
            // txtOutputResult
            // 
            this.txtOutputResult.Location = new System.Drawing.Point(34, 277);
            this.txtOutputResult.Multiline = true;
            this.txtOutputResult.Name = "txtOutputResult";
            this.txtOutputResult.Size = new System.Drawing.Size(561, 161);
            this.txtOutputResult.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(260, 231);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // frmNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtOutputResult);
            this.Controls.Add(this.txtInputInstructions);
            this.Name = "frmNavigator";
            this.Text = "Navigator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputInstructions;
        private System.Windows.Forms.TextBox txtOutputResult;
        private System.Windows.Forms.Button btnProcess;
    }
}