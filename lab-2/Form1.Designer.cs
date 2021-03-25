
namespace lab_2
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
            this.bSend = new System.Windows.Forms.Button();
            this.bReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSend
            // 
            this.bSend.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSend.Location = new System.Drawing.Point(99, 39);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(266, 94);
            this.bSend.TabIndex = 0;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            // 
            // bReceive
            // 
            this.bReceive.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReceive.Location = new System.Drawing.Point(99, 161);
            this.bReceive.Name = "bReceive";
            this.bReceive.Size = new System.Drawing.Size(266, 100);
            this.bReceive.TabIndex = 1;
            this.bReceive.Text = "Receive";
            this.bReceive.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(480, 302);
            this.Controls.Add(this.bReceive);
            this.Controls.Add(this.bSend);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TransferFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Button bReceive;
    }
}

