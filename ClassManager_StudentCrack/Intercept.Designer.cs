
namespace ClassManager_StudentCrack
{
    partial class Intercept
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
            this.PictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.Button_Prevent = new System.Windows.Forms.Button();
            this.Button_Allow = new System.Windows.Forms.Button();
            this.Label_TextShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_Icon
            // 
            this.PictureBox_Icon.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Icon.Location = new System.Drawing.Point(20, 60);
            this.PictureBox_Icon.Name = "PictureBox_Icon";
            this.PictureBox_Icon.Size = new System.Drawing.Size(80, 80);
            this.PictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Icon.TabIndex = 0;
            this.PictureBox_Icon.TabStop = false;
            // 
            // Button_Prevent
            // 
            this.Button_Prevent.Location = new System.Drawing.Point(377, 196);
            this.Button_Prevent.Name = "Button_Prevent";
            this.Button_Prevent.Size = new System.Drawing.Size(75, 23);
            this.Button_Prevent.TabIndex = 1;
            this.Button_Prevent.Text = "阻止";
            this.Button_Prevent.UseVisualStyleBackColor = true;
            this.Button_Prevent.Click += new System.EventHandler(this.Button_Prevent_Click);
            // 
            // Button_Allow
            // 
            this.Button_Allow.Location = new System.Drawing.Point(296, 196);
            this.Button_Allow.Name = "Button_Allow";
            this.Button_Allow.Size = new System.Drawing.Size(75, 23);
            this.Button_Allow.TabIndex = 2;
            this.Button_Allow.Text = "允许";
            this.Button_Allow.UseVisualStyleBackColor = true;
            this.Button_Allow.Click += new System.EventHandler(this.Button_Allow_Click);
            // 
            // Label_TextShow
            // 
            this.Label_TextShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_TextShow.Location = new System.Drawing.Point(128, 10);
            this.Label_TextShow.Name = "Label_TextShow";
            this.Label_TextShow.Size = new System.Drawing.Size(325, 180);
            this.Label_TextShow.TabIndex = 3;
            this.Label_TextShow.Text = "关于 {0} 功能的描述：\r\n\r\n{1}\r\n\r\n\r\n若不想受 {2} 打扰，请选择 阻止\r\n\r\n若需要受 {3} 协助，请选择 允许\r\n(直到下一次之前永久允许)" +
    "";
            // 
            // Intercept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 231);
            this.Controls.Add(this.Label_TextShow);
            this.Controls.Add(this.Button_Allow);
            this.Controls.Add(this.Button_Prevent);
            this.Controls.Add(this.PictureBox_Icon);
            this.Name = "Intercept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "极域窗口拦截器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Intercept_FormClosing);
            this.Load += new System.EventHandler(this.Intercept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Icon;
        private System.Windows.Forms.Button Button_Prevent;
        private System.Windows.Forms.Button Button_Allow;
        private System.Windows.Forms.Label Label_TextShow;
    }
}