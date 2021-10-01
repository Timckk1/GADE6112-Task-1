
namespace GADE6112_Task_1
{
    partial class MapForm
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
            this.btnLEFT = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnRIGHT = new System.Windows.Forms.Button();
            this.btnDOWN = new System.Windows.Forms.Button();
            this.strInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLEFT
            // 
            this.btnLEFT.Location = new System.Drawing.Point(670, 481);
            this.btnLEFT.Name = "btnLEFT";
            this.btnLEFT.Size = new System.Drawing.Size(66, 48);
            this.btnLEFT.TabIndex = 0;
            this.btnLEFT.Text = "LEFT";
            this.btnLEFT.UseVisualStyleBackColor = true;
            this.btnLEFT.Click += new System.EventHandler(this.btnLEFT_Click);
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(742, 439);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(66, 48);
            this.btnUP.TabIndex = 1;
            this.btnUP.Text = "UP";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnRIGHT
            // 
            this.btnRIGHT.Location = new System.Drawing.Point(814, 481);
            this.btnRIGHT.Name = "btnRIGHT";
            this.btnRIGHT.Size = new System.Drawing.Size(66, 48);
            this.btnRIGHT.TabIndex = 2;
            this.btnRIGHT.Text = "RIGHT";
            this.btnRIGHT.UseVisualStyleBackColor = true;
            this.btnRIGHT.Click += new System.EventHandler(this.btnRIGHT_Click);
            // 
            // btnDOWN
            // 
            this.btnDOWN.Location = new System.Drawing.Point(742, 527);
            this.btnDOWN.Name = "btnDOWN";
            this.btnDOWN.Size = new System.Drawing.Size(66, 48);
            this.btnDOWN.TabIndex = 3;
            this.btnDOWN.Text = "DOWN";
            this.btnDOWN.UseVisualStyleBackColor = true;
            this.btnDOWN.Click += new System.EventHandler(this.btnDOWN_Click);
            // 
            // strInfo
            // 
            this.strInfo.FormattingEnabled = true;
            this.strInfo.Location = new System.Drawing.Point(685, 41);
            this.strInfo.Name = "strInfo";
            this.strInfo.Size = new System.Drawing.Size(194, 381);
            this.strInfo.TabIndex = 4;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 608);
            this.Controls.Add(this.strInfo);
            this.Controls.Add(this.btnDOWN);
            this.Controls.Add(this.btnRIGHT);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnLEFT);
            this.Name = "MapForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLEFT;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnRIGHT;
        private System.Windows.Forms.Button btnDOWN;
        private System.Windows.Forms.ListBox strInfo;
    }
}