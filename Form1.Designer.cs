
namespace PDF_Resume_Creator
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
            this.RichTxtBox = new System.Windows.Forms.RichTextBox();
            this.SaveBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTxtBox
            // 
            this.RichTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTxtBox.Location = new System.Drawing.Point(12, 12);
            this.RichTxtBox.Name = "RichTxtBox";
            this.RichTxtBox.Size = new System.Drawing.Size(508, 319);
            this.RichTxtBox.TabIndex = 0;
            this.RichTxtBox.Text = "";
            // 
            // SaveBttn
            // 
            this.SaveBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBttn.Location = new System.Drawing.Point(445, 346);
            this.SaveBttn.Name = "SaveBttn";
            this.SaveBttn.Size = new System.Drawing.Size(75, 23);
            this.SaveBttn.TabIndex = 1;
            this.SaveBttn.Text = "Save";
            this.SaveBttn.UseVisualStyleBackColor = true;
            this.SaveBttn.Click += new System.EventHandler(this.SaveBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 381);
            this.Controls.Add(this.SaveBttn);
            this.Controls.Add(this.RichTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTxtBox;
        private System.Windows.Forms.Button SaveBttn;
    }
}

