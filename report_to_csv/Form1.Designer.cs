
namespace report_to_csv
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
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.lblCata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(12, 12);
            this.txtIn.MaxLength = 65535;
            this.txtIn.Multiline = true;
            this.txtIn.Name = "txtIn";
            this.txtIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIn.Size = new System.Drawing.Size(366, 477);
            this.txtIn.TabIndex = 0;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(652, 12);
            this.txtOut.MaxLength = 65535;
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(344, 477);
            this.txtOut.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(452, 58);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 52);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(486, 15);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(139, 26);
            this.txtRoot.TabIndex = 3;
            this.txtRoot.Text = "crer-svcsit";
            // 
            // lblCata
            // 
            this.lblCata.AutoSize = true;
            this.lblCata.Location = new System.Drawing.Point(399, 18);
            this.lblCata.Name = "lblCata";
            this.lblCata.Size = new System.Drawing.Size(81, 20);
            this.lblCata.TabIndex = 4;
            this.lblCata.Text = "Path Root";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 501);
            this.Controls.Add(this.lblCata);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Label lblCata;
    }
}

