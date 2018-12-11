namespace Task_Management_System
{
    partial class List
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListNameLabel = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.taskInputBox = new System.Windows.Forms.RichTextBox();
            this.DeleteListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListNameLabel
            // 
            this.ListNameLabel.AutoSize = true;
            this.ListNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNameLabel.Location = new System.Drawing.Point(13, 15);
            this.ListNameLabel.Name = "ListNameLabel";
            this.ListNameLabel.Size = new System.Drawing.Size(38, 16);
            this.ListNameLabel.TabIndex = 3;
            this.ListNameLabel.Text = "List 1";
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addTaskButton.Location = new System.Drawing.Point(10, 73);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(143, 25);
            this.addTaskButton.TabIndex = 1;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // taskPanel
            // 
            this.taskPanel.AutoScroll = true;
            this.taskPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.taskPanel.Location = new System.Drawing.Point(10, 111);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(143, 234);
            this.taskPanel.TabIndex = 2;
            this.taskPanel.WrapContents = false;
            // 
            // taskInputBox
            // 
            this.taskInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskInputBox.Location = new System.Drawing.Point(10, 33);
            this.taskInputBox.Name = "taskInputBox";
            this.taskInputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.taskInputBox.Size = new System.Drawing.Size(143, 34);
            this.taskInputBox.TabIndex = 0;
            this.taskInputBox.Text = "";
            this.taskInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taskInputBox_KeyDown);
            // 
            // DeleteListButton
            // 
            this.DeleteListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteListButton.Location = new System.Drawing.Point(10, 362);
            this.DeleteListButton.Name = "DeleteListButton";
            this.DeleteListButton.Size = new System.Drawing.Size(143, 25);
            this.DeleteListButton.TabIndex = 4;
            this.DeleteListButton.Text = "Delete List";
            this.DeleteListButton.UseVisualStyleBackColor = false;
            this.DeleteListButton.Click += new System.EventHandler(this.DeleteListButton_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DeleteListButton);
            this.Controls.Add(this.taskInputBox);
            this.Controls.Add(this.taskPanel);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.ListNameLabel);
            this.Name = "List";
            this.Size = new System.Drawing.Size(166, 398);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ListNameLabel;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.FlowLayoutPanel taskPanel;
        private System.Windows.Forms.RichTextBox taskInputBox;
        private System.Windows.Forms.Button DeleteListButton;
    }
}
