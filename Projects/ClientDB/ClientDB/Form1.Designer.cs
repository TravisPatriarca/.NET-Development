
namespace ClientDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addClientBtn = new System.Windows.Forms.Button();
            this.removeClientBtn = new System.Windows.Forms.Button();
            this.isClientBtn = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addClientBtn
            // 
            this.addClientBtn.Location = new System.Drawing.Point(83, 136);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(75, 23);
            this.addClientBtn.TabIndex = 0;
            this.addClientBtn.Text = "Add Client";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // removeClientBtn
            // 
            this.removeClientBtn.Location = new System.Drawing.Point(184, 136);
            this.removeClientBtn.Name = "removeClientBtn";
            this.removeClientBtn.Size = new System.Drawing.Size(75, 23);
            this.removeClientBtn.TabIndex = 1;
            this.removeClientBtn.Text = "Remove Client";
            this.removeClientBtn.UseVisualStyleBackColor = true;
            this.removeClientBtn.Click += new System.EventHandler(this.removeClientBtn_Click);
            // 
            // isClientBtn
            // 
            this.isClientBtn.Location = new System.Drawing.Point(279, 136);
            this.isClientBtn.Name = "isClientBtn";
            this.isClientBtn.Size = new System.Drawing.Size(75, 23);
            this.isClientBtn.TabIndex = 2;
            this.isClientBtn.Text = "Is A Client?";
            this.isClientBtn.UseVisualStyleBackColor = true;
            this.isClientBtn.Click += new System.EventHandler(this.isClientBtn_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(159, 71);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 23);
            this.inputBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ClientName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.isClientBtn);
            this.Controls.Add(this.removeClientBtn);
            this.Controls.Add(this.addClientBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.Button removeClientBtn;
        private System.Windows.Forms.Button isClientBtn;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
    }
}

