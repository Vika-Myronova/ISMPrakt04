
namespace WinFormMenu
{
    partial class WhileForm3
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
            this.labelP = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelResult2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSolve.Location = new System.Drawing.Point(115, 128);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(218, 47);
            this.buttonSolve.TabIndex = 0;
            this.buttonSolve.Text = "Порахувати";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.BackColor = System.Drawing.Color.MistyRose;
            this.labelP.Location = new System.Drawing.Point(82, 61);
            this.labelP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(41, 23);
            this.labelP.TabIndex = 1;
            this.labelP.Text = "P =";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(155, 58);
            this.textBoxP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(148, 32);
            this.textBoxP.TabIndex = 2;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BackColor = System.Drawing.Color.MistyRose;
            this.labelDay.Location = new System.Drawing.Point(73, 220);
            this.labelDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(216, 23);
            this.labelDay.TabIndex = 3;
            this.labelDay.Text = "Після                   дня";
            this.labelDay.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(151, 220);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(54, 23);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "label";
            this.labelResult.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClose.Location = new System.Drawing.Point(329, 391);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(124, 38);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.BackColor = System.Drawing.Color.MistyRose;
            this.labelSum.Location = new System.Drawing.Point(73, 285);
            this.labelSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(84, 23);
            this.labelSum.TabIndex = 6;
            this.labelSum.Text = "Сума  =";
            this.labelSum.Visible = false;
            // 
            // labelResult2
            // 
            this.labelResult2.AutoSize = true;
            this.labelResult2.Location = new System.Drawing.Point(167, 285);
            this.labelResult2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult2.Name = "labelResult2";
            this.labelResult2.Size = new System.Drawing.Size(54, 23);
            this.labelResult2.TabIndex = 7;
            this.labelResult2.Text = "label";
            this.labelResult2.Visible = false;
            // 
            // WhileForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(481, 457);
            this.Controls.Add(this.labelResult2);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.buttonSolve);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WhileForm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhileForm3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelResult2;
    }
}