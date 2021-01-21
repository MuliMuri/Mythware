
namespace ClassManager_StudentCrack.Chat.Template
{
    partial class Reply_Form
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
            this.Reply_RichTextBox_Show = new System.Windows.Forms.RichTextBox();
            this.Reply_TextBox_Input = new System.Windows.Forms.TextBox();
            this.Reply_Button_Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reply_RichTextBox_Show
            // 
            this.Reply_RichTextBox_Show.Location = new System.Drawing.Point(12, 12);
            this.Reply_RichTextBox_Show.Name = "Reply_RichTextBox_Show";
            this.Reply_RichTextBox_Show.Size = new System.Drawing.Size(577, 285);
            this.Reply_RichTextBox_Show.TabIndex = 0;
            this.Reply_RichTextBox_Show.Text = "";
            // 
            // Reply_TextBox_Input
            // 
            this.Reply_TextBox_Input.Location = new System.Drawing.Point(12, 303);
            this.Reply_TextBox_Input.Multiline = true;
            this.Reply_TextBox_Input.Name = "Reply_TextBox_Input";
            this.Reply_TextBox_Input.Size = new System.Drawing.Size(577, 62);
            this.Reply_TextBox_Input.TabIndex = 1;
            // 
            // Reply_Button_Send
            // 
            this.Reply_Button_Send.Location = new System.Drawing.Point(514, 371);
            this.Reply_Button_Send.Name = "Reply_Button_Send";
            this.Reply_Button_Send.Size = new System.Drawing.Size(75, 23);
            this.Reply_Button_Send.TabIndex = 2;
            this.Reply_Button_Send.Text = "发送";
            this.Reply_Button_Send.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ctrl + Enter 可快速发送";
            // 
            // Reply_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reply_Button_Send);
            this.Controls.Add(this.Reply_TextBox_Input);
            this.Controls.Add(this.Reply_RichTextBox_Show);
            this.Name = "Reply_Form";
            this.Text = "来自 PCName-(“IP”) 的信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Reply_RichTextBox_Show;
        private System.Windows.Forms.TextBox Reply_TextBox_Input;
        private System.Windows.Forms.Button Reply_Button_Send;
        private System.Windows.Forms.Label label1;
    }
}