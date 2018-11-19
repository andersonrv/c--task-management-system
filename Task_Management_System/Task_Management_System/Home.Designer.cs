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
            this.AddBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBoard.Location = new System.Drawing.Point(14, 12);
            this.AddBoard.Name = "AddBoard";
            this.AddBoard.Size = new System.Drawing.Size(160, 48);
            this.AddBoard.TabIndex = 1;
            this.AddBoard.Text = "+ Board";
            this.AddBoard.UseVisualStyleBackColor = true;
            this.AddBoard.Click += new System.EventHandler(this.AddBoard_Click);
            // 
            // DeleteBoard
            // 
            this.DeleteBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBoard.Location = new System.Drawing.Point(1136, 12);
            this.DeleteBoard.Name = "DeleteBoard";
            this.DeleteBoard.Size = new System.Drawing.Size(160, 48);
            this.DeleteBoard.TabIndex = 2;
            this.DeleteBoard.Text = "- Board";
            this.DeleteBoard.UseVisualStyleBackColor = true;
            this.DeleteBoard.Click += new System.EventHandler(this.DeleteBoard_Click);
            // 
            // BoardArea
            // 
            this.BoardArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoardArea.Location = new System.Drawing.Point(14, 68);
            this.BoardArea.Name = "BoardArea";
            this.BoardArea.SelectedIndex = 0;
            this.BoardArea.Size = new System.Drawing.Size(1286, 889);
            this.BoardArea.TabIndex = 3;
            // 
            // BoardNameTextBox
            // 
            this.BoardNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BoardNameTextBox.Location = new System.Drawing.Point(180, 14);
            this.BoardNameTextBox.Name = "BoardNameTextBox";
            this.BoardNameTextBox.Size = new System.Drawing.Size(459, 39);
            this.BoardNameTextBox.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 969);
            this.Controls.Add(this.BoardNameTextBox);
            this.Controls.Add(this.BoardArea);
            this.Controls.Add(this.DeleteBoard);
            this.Controls.Add(this.AddBoard);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBoard;
        private System.Windows.Forms.TabControl BoardArea;
        private System.Windows.Forms.Button DeleteBoard;
        private System.Windows.Forms.TextBox BoardNameTextBox;
    }
}