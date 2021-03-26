
namespace lab_2
{
    partial class WindowSend
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
            this.label1 = new System.Windows.Forms.Label();
            this.bJoin = new System.Windows.Forms.Button();
            this.lInfo = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbIPPort = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:port";
            // 
            // bJoin
            // 
            this.bJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bJoin.Location = new System.Drawing.Point(70, 187);
            this.bJoin.Name = "bJoin";
            this.bJoin.Size = new System.Drawing.Size(266, 70);
            this.bJoin.TabIndex = 2;
            this.bJoin.Text = "Join";
            this.bJoin.UseVisualStyleBackColor = true;
            this.bJoin.Click += new System.EventHandler(this.bJoin_Click);
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lInfo.Location = new System.Drawing.Point(90, 135);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(198, 32);
            this.lInfo.TabIndex = 3;
            this.lInfo.Text = "Not connected";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tbIPPort
            // 
            this.tbIPPort.Culture = new System.Globalization.CultureInfo("es-US");
            this.tbIPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIPPort.Location = new System.Drawing.Point(12, 70);
            this.tbIPPort.Name = "tbIPPort";
            this.tbIPPort.Size = new System.Drawing.Size(409, 34);
            this.tbIPPort.TabIndex = 4;
            this.tbIPPort.ValidatingType = typeof(System.DateTime);
            // 
            // WindowSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 268);
            this.Controls.Add(this.tbIPPort);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.bJoin);
            this.Controls.Add(this.label1);
            this.Name = "WindowSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowSend";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WindowSend_FormClosed);
            this.Load += new System.EventHandler(this.WindowSend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bJoin;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MaskedTextBox tbIPPort;
    }
}