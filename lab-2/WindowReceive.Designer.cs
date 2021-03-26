
namespace lab_2
{
    partial class WindowReceive
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
            this.lIPPort = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.bAccept = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lIPPort
            // 
            this.lIPPort.AutoSize = true;
            this.lIPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lIPPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lIPPort.Location = new System.Drawing.Point(151, 21);
            this.lIPPort.Name = "lIPPort";
            this.lIPPort.Size = new System.Drawing.Size(128, 39);
            this.lIPPort.TabIndex = 0;
            this.lIPPort.Text = "IP:Port";
            this.lIPPort.Click += new System.EventHandler(this.label1_Click);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStatus.ForeColor = System.Drawing.Color.Green;
            this.lStatus.Location = new System.Drawing.Point(107, 109);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(208, 36);
            this.lStatus.TabIndex = 1;
            this.lStatus.Text = "Not connected";
            this.lStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // bAccept
            // 
            this.bAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAccept.Location = new System.Drawing.Point(102, 184);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(242, 60);
            this.bAccept.TabIndex = 2;
            this.bAccept.Text = "Accept";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.button1_Click);
            // 
            // WindowReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 268);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.lIPPort);
            this.Name = "WindowReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowReceive";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WindowReceive_FormClosed);
            this.Load += new System.EventHandler(this.WindowReceive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lIPPort;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}