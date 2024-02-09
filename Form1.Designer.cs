namespace EticketCase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyIcon1 = new NotifyIcon(components);
            checkBoxClipBoard = new CheckBox();
            checkBox_eTicket = new CheckBox();
            label1 = new Label();
            labelVersion = new Label();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "eTicket Case #";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // checkBoxClipBoard
            // 
            checkBoxClipBoard.AutoSize = true;
            checkBoxClipBoard.Location = new Point(38, 49);
            checkBoxClipBoard.Name = "checkBoxClipBoard";
            checkBoxClipBoard.Size = new Size(123, 19);
            checkBoxClipBoard.TabIndex = 0;
            checkBoxClipBoard.Text = "Copy to Clipboard";
            checkBoxClipBoard.UseVisualStyleBackColor = true;
            // 
            // checkBox_eTicket
            // 
            checkBox_eTicket.AutoSize = true;
            checkBox_eTicket.Location = new Point(38, 74);
            checkBox_eTicket.Name = "checkBox_eTicket";
            checkBox_eTicket.Size = new Size(102, 19);
            checkBox_eTicket.TabIndex = 1;
            checkBox_eTicket.Text = "Add to eTicket";
            checkBox_eTicket.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(38, 24);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 4;
            label1.Text = "Case # Behavior";
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(54, 102);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(38, 15);
            labelVersion.TabIndex = 5;
            labelVersion.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 128);
            Controls.Add(labelVersion);
            Controls.Add(label1);
            Controls.Add(checkBox_eTicket);
            Controls.Add(checkBoxClipBoard);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(218, 167);
            Name = "Form1";
            Text = "CasePaste";
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private CheckBox checkBoxClipBoard;
        private CheckBox checkBox_eTicket;
        private Label label1;
        private Label labelVersion;
    }
}