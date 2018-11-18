namespace Task_Management_System
{
    partial class Task
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
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.TaskDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DueLabel = new System.Windows.Forms.Label();
            this.ResponsibleBox = new System.Windows.Forms.ComboBox();
            this.ResponsibleLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameLabel.Location = new System.Drawing.Point(20, 15);
            this.TaskNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(57, 23);
            this.TaskNameLabel.TabIndex = 0;
            this.TaskNameLabel.Text = "Task";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(24, 51);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(584, 180);
            this.TextBoxDescription.TabIndex = 3;
            this.TextBoxDescription.Text = "";
            // 
            // TaskDateTimePicker
            // 
            this.TaskDateTimePicker.Location = new System.Drawing.Point(107, 260);
            this.TaskDateTimePicker.Name = "TaskDateTimePicker";
            this.TaskDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.TaskDateTimePicker.TabIndex = 0;
            // 
            // DueLabel
            // 
            this.DueLabel.AutoSize = true;
            this.DueLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueLabel.Location = new System.Drawing.Point(22, 260);
            this.DueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DueLabel.Name = "DueLabel";
            this.DueLabel.Size = new System.Drawing.Size(55, 23);
            this.DueLabel.TabIndex = 4;
            this.DueLabel.Text = "Due:";
            // 
            // ResponsibleBox
            // 
            this.ResponsibleBox.FormattingEnabled = true;
            this.ResponsibleBox.Location = new System.Drawing.Point(107, 293);
            this.ResponsibleBox.Name = "ResponsibleBox";
            this.ResponsibleBox.Size = new System.Drawing.Size(200, 28);
            this.ResponsibleBox.TabIndex = 5;
            // 
            // ResponsibleLabel
            // 
            this.ResponsibleLabel.AutoSize = true;
            this.ResponsibleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsibleLabel.Location = new System.Drawing.Point(22, 293);
            this.ResponsibleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResponsibleLabel.Name = "ResponsibleLabel";
            this.ResponsibleLabel.Size = new System.Drawing.Size(59, 23);
            this.ResponsibleLabel.TabIndex = 6;
            this.ResponsibleLabel.Text = "Who:";
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(107, 327);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(200, 28);
            this.StatusBox.TabIndex = 7;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(22, 327);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(78, 23);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Think about how we are going to keep the log with all changes here...";
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.ResponsibleLabel);
            this.Controls.Add(this.ResponsibleBox);
            this.Controls.Add(this.DueLabel);
            this.Controls.Add(this.TaskDateTimePicker);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TaskNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.RichTextBox TextBoxDescription;
        private System.Windows.Forms.DateTimePicker TaskDateTimePicker;
        private System.Windows.Forms.Label DueLabel;
        private System.Windows.Forms.ComboBox ResponsibleBox;
        private System.Windows.Forms.Label ResponsibleLabel;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label1;
    }
}
