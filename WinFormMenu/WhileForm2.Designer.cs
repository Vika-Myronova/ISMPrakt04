
namespace WinFormMenu
{
    partial class WhileForm2
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
            this.labelK = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSolve.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSolve.Location = new System.Drawing.Point(59, 130);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(196, 42);
            this.buttonSolve.TabIndex = 0;
            this.buttonSolve.Text = "Порахувати";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.BackColor = System.Drawing.Color.MistyRose;
            this.labelN.Location = new System.Drawing.Point(55, 71);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(44, 23);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "N =";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(107, 68);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(148, 32);
            this.textBoxN.TabIndex = 2;
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.BackColor = System.Drawing.Color.MistyRose;
            this.labelK.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelK.Location = new System.Drawing.Point(55, 227);
            this.labelK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(180, 23);
            this.labelK.TabIndex = 3;
            this.labelK.Text = "Найменше K  = ";
            this.labelK.Visible = false;
            this.labelK.Click += new System.EventHandler(this.labelK_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(247, 227);
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
            this.buttonClose.Location = new System.Drawing.Point(290, 329);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(125, 38);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // WhileForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(442, 397);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.buttonSolve);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WhileForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhileForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonClose;
    }
}