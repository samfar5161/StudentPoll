namespace StudentPoll
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnDone = new System.Windows.Forms.Button();
            this.BtnShowResults = new System.Windows.Forms.Button();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an integer result (1 - 10) and press Enter: ";
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(110, 81);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(113, 22);
            this.TxtInput.TabIndex = 1;
            this.TxtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtInput_KeyDown);
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(229, 81);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(75, 23);
            this.BtnDone.TabIndex = 2;
            this.BtnDone.Text = "Done";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // BtnShowResults
            // 
            this.BtnShowResults.Location = new System.Drawing.Point(123, 123);
            this.BtnShowResults.Name = "BtnShowResults";
            this.BtnShowResults.Size = new System.Drawing.Size(169, 23);
            this.BtnShowResults.TabIndex = 3;
            this.BtnShowResults.Text = "View Survey Results";
            this.BtnShowResults.UseVisualStyleBackColor = true;
            this.BtnShowResults.Click += new System.EventHandler(this.BtnShowResults_Click);
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(62, 169);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ReadOnly = true;
            this.TxtOutput.Size = new System.Drawing.Size(310, 257);
            this.TxtOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.TxtOutput);
            this.Controls.Add(this.BtnShowResults);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Student Poll";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Button BtnShowResults;
        private System.Windows.Forms.TextBox TxtOutput;
    }
}

