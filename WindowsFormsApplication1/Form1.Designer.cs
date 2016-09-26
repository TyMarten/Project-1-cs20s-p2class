namespace WindowsFormsApplication1
{
    partial class Frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnNoHelp = new System.Windows.Forms.Button();
            this.lblHelpTxt = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(139, 87);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(121, 37);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "No, Go away";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnNoHelp_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(46, 160);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNoHelp
            // 
            this.btnNoHelp.Location = new System.Drawing.Point(12, 87);
            this.btnNoHelp.Name = "btnNoHelp";
            this.btnNoHelp.Size = new System.Drawing.Size(121, 37);
            this.btnNoHelp.TabIndex = 3;
            this.btnNoHelp.Text = "Sure, Lets Hear it";
            this.btnNoHelp.UseVisualStyleBackColor = true;
            this.btnNoHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblHelpTxt
            // 
            this.lblHelpTxt.AutoSize = true;
            this.lblHelpTxt.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpTxt.Location = new System.Drawing.Point(15, 30);
            this.lblHelpTxt.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.lblHelpTxt.Name = "lblHelpTxt";
            this.lblHelpTxt.Size = new System.Drawing.Size(245, 30);
            this.lblHelpTxt.TabIndex = 4;
            this.lblHelpTxt.Text = "Want to hear a Banana joke?";
            this.lblHelpTxt.Click += new System.EventHandler(this.lblHelpTxt_Click);
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(133, 160);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(0, 13);
            this.lblK.TabIndex = 5;
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblHelpTxt);
            this.Controls.Add(this.btnNoHelp);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnHelp);
            this.Name = "Frm1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnNoHelp;
        private System.Windows.Forms.Label lblHelpTxt;
        private System.Windows.Forms.Label lblK;
    }
}

