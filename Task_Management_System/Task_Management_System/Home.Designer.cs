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
            this.Board2 = new System.Windows.Forms.TabPage();
            this.Board1 = new System.Windows.Forms.TabPage();
            this.DeleteBoard = new System.Windows.Forms.Button();
            this.AddList = new System.Windows.Forms.Button();
            this.BoardArea = new System.Windows.Forms.TabControl();
            this.DeleteTask = new System.Windows.Forms.Button();
            this.ListArea = new System.Windows.Forms.Panel();
            this.Board1.SuspendLayout();
            this.BoardArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBoard
            // 
            this.AddBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBoard.Location = new System.Drawing.Point(12, 10);
            this.AddBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBoard.Name = "AddBoard";
            this.AddBoard.Size = new System.Drawing.Size(143, 38);
            this.AddBoard.TabIndex = 0;
            this.AddBoard.Text = "+ Board";
            this.AddBoard.UseVisualStyleBackColor = true;
            this.AddBoard.Click += new System.EventHandler(this.AddBoard_Click);
            // 
            // Board2
            // 
            this.Board2.Location = new System.Drawing.Point(4, 25);
            this.Board2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Board2.Name = "Board2";
            this.Board2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Board2.Size = new System.Drawing.Size(1691, 683);
            this.Board2.TabIndex = 1;
            this.Board2.Text = "Board2";
            this.Board2.UseVisualStyleBackColor = true;
            // 
            // Board1
            // 
            this.Board1.Controls.Add(this.ListArea);
            this.Board1.Controls.Add(this.DeleteBoard);
            this.Board1.Controls.Add(this.AddList);
            this.Board1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Board1.Location = new System.Drawing.Point(4, 25);
            this.Board1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Board1.Name = "Board1";
            this.Board1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Board1.Size = new System.Drawing.Size(1035, 683);
            this.Board1.TabIndex = 0;
            this.Board1.Text = "Board1";
            this.Board1.UseVisualStyleBackColor = true;
            // 
            // DeleteBoard
            // 
            this.DeleteBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBoard.Location = new System.Drawing.Point(645, 7);
            this.DeleteBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBoard.Name = "DeleteBoard";
            this.DeleteBoard.Size = new System.Drawing.Size(143, 38);
            this.DeleteBoard.TabIndex = 2;
            this.DeleteBoard.Text = "- Board";
            this.DeleteBoard.UseVisualStyleBackColor = true;
            this.DeleteBoard.Click += new System.EventHandler(this.DeleteBoard_Click);
            // 
            // AddList
            // 
            this.AddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddList.Location = new System.Drawing.Point(5, 5);
            this.AddList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(143, 38);
            this.AddList.TabIndex = 3;
            this.AddList.Text = "+ List";
            this.AddList.UseVisualStyleBackColor = true;
            this.AddList.Click += new System.EventHandler(this.AddList_Click);
            // 
            // BoardArea
            // 
            this.BoardArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoardArea.Controls.Add(this.Board1);
            this.BoardArea.Controls.Add(this.Board2);
            this.BoardArea.Location = new System.Drawing.Point(12, 54);
            this.BoardArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoardArea.Name = "BoardArea";
            this.BoardArea.SelectedIndex = 0;
            this.BoardArea.Size = new System.Drawing.Size(1043, 712);
            this.BoardArea.TabIndex = 1;
            // 
            // DeleteTask
            // 
            this.DeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTask.Location = new System.Drawing.Point(549, 13);
            this.DeleteTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(107, 37);
            this.DeleteTask.TabIndex = 7;
            this.DeleteTask.Text = "- Task";
            this.DeleteTask.UseVisualStyleBackColor = true;
            // 
            // ListArea
            // 
            this.ListArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListArea.AutoScroll = true;
            this.ListArea.Location = new System.Drawing.Point(6, 49);
            this.ListArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListArea.Name = "ListArea";
            this.ListArea.Size = new System.Drawing.Size(1005, 632);
            this.ListArea.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 776);
            this.Controls.Add(this.BoardArea);
            this.Controls.Add(this.DeleteTask);
            this.Controls.Add(this.AddBoard);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Board1.ResumeLayout(false);
            this.BoardArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBoard;
        private System.Windows.Forms.TabPage Board2;
        private System.Windows.Forms.TabPage Board1;
        private System.Windows.Forms.TabControl BoardArea;
        private System.Windows.Forms.Button DeleteBoard;
        private System.Windows.Forms.Button AddList;
        private System.Windows.Forms.Button DeleteTask;
        private System.Windows.Forms.Panel ListArea;
    }
}