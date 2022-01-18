
namespace WinFormMenu
{
    partial class ForForm2
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
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonSolveFor2 = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.BackColor = System.Drawing.Color.MintCream;
            this.labelN.Location = new System.Drawing.Point(39, 64);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(47, 23);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "N = ";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(94, 61);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(136, 30);
            this.textBoxN.TabIndex = 1;
            // 
            // buttonSolveFor2
            // 
            this.buttonSolveFor2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonSolveFor2.Location = new System.Drawing.Point(67, 127);
            this.buttonSolveFor2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSolveFor2.Name = "buttonSolveFor2";
            this.buttonSolveFor2.Size = new System.Drawing.Size(183, 31);
            this.buttonSolveFor2.TabIndex = 2;
            this.buttonSolveFor2.Text = "Порахувати";
            this.buttonSolveFor2.UseVisualStyleBackColor = false;
            this.buttonSolveFor2.Click += new System.EventHandler(this.buttonSolveFor2_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.BackColor = System.Drawing.Color.MintCream;
            this.labelSum.Location = new System.Drawing.Point(39, 211);
            this.labelSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(82, 23);
            this.labelSum.TabIndex = 3;
            this.labelSum.Text = "Сума  =";
            this.labelSum.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(139, 211);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 23);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "label3";
            this.labelResult.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonClose.Location = new System.Drawing.Point(309, 357);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(119, 31);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ForForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 413);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonSolveFor2);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonSolveFor2;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonClose;
    }
}