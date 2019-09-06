namespace ASCIIConverter
{
    partial class ASCIIConverter
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.cbRemoveOx = new System.Windows.Forms.CheckBox();
            this.cbAddSpace = new System.Windows.Forms.CheckBox();
            this.cbRemoveComma = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 12);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(455, 101);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            this.rtbInput.TextChanged += new System.EventHandler(this.rtbInput_TextChanged);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 169);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(455, 114);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // cbRemoveOx
            // 
            this.cbRemoveOx.AutoSize = true;
            this.cbRemoveOx.Location = new System.Drawing.Point(12, 130);
            this.cbRemoveOx.Name = "cbRemoveOx";
            this.cbRemoveOx.Size = new System.Drawing.Size(78, 16);
            this.cbRemoveOx.TabIndex = 2;
            this.cbRemoveOx.Text = "Remove 0x";
            this.cbRemoveOx.UseVisualStyleBackColor = true;
            this.cbRemoveOx.CheckedChanged += new System.EventHandler(this.cbRemoveOx_CheckedChanged);
            // 
            // cbAddSpace
            // 
            this.cbAddSpace.AutoSize = true;
            this.cbAddSpace.Location = new System.Drawing.Point(96, 130);
            this.cbAddSpace.Name = "cbAddSpace";
            this.cbAddSpace.Size = new System.Drawing.Size(78, 16);
            this.cbAddSpace.TabIndex = 3;
            this.cbAddSpace.Text = "Add Space";
            this.cbAddSpace.UseVisualStyleBackColor = true;
            this.cbAddSpace.CheckedChanged += new System.EventHandler(this.cbAddSpace_CheckedChanged);
            // 
            // cbRemoveComma
            // 
            this.cbRemoveComma.AutoSize = true;
            this.cbRemoveComma.Location = new System.Drawing.Point(180, 130);
            this.cbRemoveComma.Name = "cbRemoveComma";
            this.cbRemoveComma.Size = new System.Drawing.Size(96, 16);
            this.cbRemoveComma.TabIndex = 4;
            this.cbRemoveComma.Text = "Remove Comma";
            this.cbRemoveComma.UseVisualStyleBackColor = true;
            this.cbRemoveComma.CheckedChanged += new System.EventHandler(this.cbRemoveComma_CheckedChanged);
            // 
            // ASCIIConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 308);
            this.Controls.Add(this.cbRemoveComma);
            this.Controls.Add(this.cbAddSpace);
            this.Controls.Add(this.cbRemoveOx);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Name = "ASCIIConverter";
            this.Text = "ASCII Converter";
            this.Load += new System.EventHandler(this.ASCIIConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.CheckBox cbRemoveOx;
        private System.Windows.Forms.CheckBox cbAddSpace;
        private System.Windows.Forms.CheckBox cbRemoveComma;
    }
}

