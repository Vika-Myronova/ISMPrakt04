
namespace WinFormMenu
{
    partial class WhileForm1
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
            this.buttonSolve = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.BackColor = System.Drawing.Color.MistyRose;
            this.labelN.Location = new System.Drawing.Point(82, 69);
            this.labelN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(47, 23);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "N = ";
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSolve.Location = new System.Drawing.Point(101, 125);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(174, 33);
            this.buttonSolve.TabIndex = 1;
            this.buttonSolve.Text = "Порахувати";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(139, 66);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(136, 30);
            this.textBoxN.TabIndex = 2;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.BackColor = System.Drawing.Color.MistyRose;
            this.labelSum.Location = new System.Drawing.Point(90, 206);
            this.labelSum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(82, 23);
            this.labelSum.TabIndex = 3;
            this.labelSum.Text = "Сума  =";
            this.labelSum.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(196, 206);
            this.labelResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(51, 23);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "label";
            this.labelResult.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(325, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Закрити";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WhileForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 373);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.labelN);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "WhileForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhileForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button2;
    }
}