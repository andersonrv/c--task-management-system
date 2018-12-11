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
            this.DueTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DueLabel = new System.Windows.Forms.Label();
            this.WhoBox = new System.Windows.Forms.ComboBox();
            this.WhoLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameLabel.Location = new System.Drawing.Point(13, 10);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(39, 16);
            this.TaskNameLabel.TabIndex = 7;
            this.TaskNameLabel.Text = "Task";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(16, 33);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(391, 118);
            this.TextBoxDescription.TabIndex = 0;
            this.TextBoxDescription.Text = "";
            // 
            // DueTimePicker
            // 
            this.DueTimePicker.Location = new System.Drawing.Point(71, 169);
            this.DueTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DueTimePicker.Name = "DueTimePicker";
            this.DueTimePicker.Size = new System.Drawing.Size(135, 20);
            this.DueTimePicker.TabIndex = 1;
            // 
            // DueLabel
            // 
            this.DueLabel.AutoSize = true;
            this.DueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueLabel.Location = new System.Drawing.Point(15, 169);
            this.DueLabel.Name = "DueLabel";
            this.DueLabel.Size = new System.Drawing.Size(36, 16);
            this.DueLabel.TabIndex = 8;
            this.DueLabel.Text = "Due:";
            // 
            // WhoBox
            // 
            this.WhoBox.FormattingEnabled = true;
            this.WhoBox.Location = new System.Drawing.Point(71, 190);
            this.WhoBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WhoBox.Name = "WhoBox";
            this.WhoBox.Size = new System.Drawing.Size(135, 21);
            this.WhoBox.TabIndex = 2;
            // 
            // WhoLabel
            // 
            this.WhoLabel.AutoSize = true;
            this.WhoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoLabel.Location = new System.Drawing.Point(15, 190);
            this.WhoLabel.Name = "WhoLabel";
            this.WhoLabel.Size = new System.Drawing.Size(39, 16);
            this.WhoLabel.TabIndex = 9;
            this.WhoLabel.Text = "Who:";
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(71, 213);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(135, 21);
            this.StatusBox.TabIndex = 3;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(15, 213);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(48, 16);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "Status:";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.DarkGreen;
            this.SaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveChangesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveChangesButton.Location = new System.Drawing.Point(275, 169);
            this.SaveChangesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(131, 28);
            this.SaveChangesButton.TabIndex = 4;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.DeleteTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteTaskButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteTaskButton.Location = new System.Drawing.Point(275, 203);
            this.DeleteTaskButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(131, 28);
            this.DeleteTaskButton.TabIndex = 5;
            this.DeleteTaskButton.Text = "Delete Task";
            this.DeleteTaskButton.UseVisualStyleBackColor = false;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(421, 253);
            this.Controls.Add(this.DeleteTaskButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.WhoLabel);
            this.Controls.Add(this.WhoBox);
            this.Controls.Add(this.DueLabel);
            this.Controls.Add(this.DueTimePicker);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TaskNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.RichTextBox TextBoxDescription;
        private System.Windows.Forms.DateTimePicker DueTimePicker;
        private System.Windows.Forms.Label DueLabel;
        private System.Windows.Forms.ComboBox WhoBox;
        private System.Windows.Forms.Label WhoLabel;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button DeleteTaskButton;
    }

}
