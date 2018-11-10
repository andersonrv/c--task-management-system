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
            this.ListName = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.taskInputBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ListName
            // 
            this.ListName.AutoSize = true;
            this.ListName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListName.Location = new System.Drawing.Point(60, 15);
            this.ListName.Name = "ListName";
            this.ListName.Size = new System.Drawing.Size(42, 15);
            this.ListName.TabIndex = 1;
            this.ListName.Text = "List 1";
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(10, 68);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(143, 25);
            this.addTaskButton.TabIndex = 2;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // taskPanel
            // 
            this.taskPanel.AutoScroll = true;
            this.taskPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.taskPanel.Location = new System.Drawing.Point(10, 111);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(143, 234);
            this.taskPanel.TabIndex = 3;
            // 
            // taskInputBox
            // 
            this.taskInputBox.Location = new System.Drawing.Point(10, 33);
            this.taskInputBox.Name = "taskInputBox";
            this.taskInputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.taskInputBox.Size = new System.Drawing.Size(143, 29);
            this.taskInputBox.TabIndex = 4;
            this.taskInputBox.Text = "";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.taskInputBox);
            this.Controls.Add(this.taskPanel);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.ListName);
            this.Name = "List";
            this.Size = new System.Drawing.Size(166, 359);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ListName;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.FlowLayoutPanel taskPanel;
        private System.Windows.Forms.RichTextBox taskInputBox;
    }
}
