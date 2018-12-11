namespace Task_Management_System
{
    partial class Home
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
            this.AddBoard = new System.Windows.Forms.Button();
            this.DeleteBoard = new System.Windows.Forms.Button();
            this.BoardArea = new System.Windows.Forms.TabControl();
            this.BoardNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBoard
            // 
            this.AddBoard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBoard.Location = new System.Drawing.Point(9, 8);
            this.AddBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBoard.Name = "AddBoard";
            this.AddBoard.Size = new System.Drawing.Size(107, 31);
            this.AddBoard.TabIndex = 1;
            this.AddBoard.Text = "+ Board";
            this.AddBoard.UseVisualStyleBackColor = false;
            this.AddBoard.Click += new System.EventHandler(this.AddBoard_Click);
            // 
            // DeleteBoard
            // 
            this.DeleteBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBoard.Location = new System.Drawing.Point(757, 8);
            this.DeleteBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBoard.Name = "DeleteBoard";
            this.DeleteBoard.Size = new System.Drawing.Size(107, 31);
            this.DeleteBoard.TabIndex = 2;
            this.DeleteBoard.Text = "- Board";
            this.DeleteBoard.UseVisualStyleBackColor = false;
            this.DeleteBoard.Click += new System.EventHandler(this.DeleteBoard_Click);
            // 
            // BoardArea
            // 
            this.BoardArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoardArea.Location = new System.Drawing.Point(9, 44);
            this.BoardArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoardArea.Name = "BoardArea";
            this.BoardArea.SelectedIndex = 0;
            this.BoardArea.Size = new System.Drawing.Size(857, 578);
            this.BoardArea.TabIndex = 3;
            // 
            // BoardNameTextBox
            // 
            this.BoardNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BoardNameTextBox.Location = new System.Drawing.Point(120, 9);
            this.BoardNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoardNameTextBox.Name = "BoardNameTextBox";
            this.BoardNameTextBox.Size = new System.Drawing.Size(307, 29);
            this.BoardNameTextBox.TabIndex = 0;
            this.BoardNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoardNameTextBox_KeyDown);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(875, 630);
            this.Controls.Add(this.BoardNameTextBox);
            this.Controls.Add(this.BoardArea);
            this.Controls.Add(this.DeleteBoard);
            this.Controls.Add(this.AddBoard);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBoard;
        private System.Windows.Forms.Button DeleteBoard;
        private System.Windows.Forms.TextBox BoardNameTextBox;
        private System.Windows.Forms.TabControl BoardArea;
    }
}