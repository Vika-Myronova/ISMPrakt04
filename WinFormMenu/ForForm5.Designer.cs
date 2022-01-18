
namespace WinFormMenu
{
    partial class ForForm5
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
            this.buttonSolve = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonSolve.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSolve.Location = new System.Drawing.Point(53, 106);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(192, 38);
            this.buttonSolve.TabIndex = 0;
            this.buttonSolve.Text = "Порахувати";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labelN.Location = new System.Drawing.Point(68, 46);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(41, 23);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "N =";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(126, 46);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(109, 30);
            this.textBoxN.TabIndex = 2;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labelSum.Location = new System.Drawing.Point(81, 190);
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
            this.labelResult.Location = new System.Drawing.Point(191, 190);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(51, 23);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "label";
            this.labelResult.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonClose.Location = new System.Drawing.Point(258, 281);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(111, 36);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ForForm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 329);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.buttonSolve);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForForm5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForForm5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonClose;
    }
}