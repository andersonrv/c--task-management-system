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
            this.ListArea = new System.Windows.Forms.FlowLayoutPanel();
            this.Board1.SuspendLayout();
            this.BoardArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBoard
            // 
            this.AddBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBoard.Location = new System.Drawing.Point(9, 8);
            this.AddBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBoard.Name = "AddBoard";
            this.AddBoard.Size = new System.Drawing.Size(107, 31);
            this.AddBoard.TabIndex = 0;
            this.AddBoard.Text = "+ Board";
            this.AddBoard.UseVisualStyleBackColor = true;
            this.AddBoard.Click += new System.EventHandler(this.AddBoard_Click);
            // 
            // Board2
            // 
            this.Board2.Location = new System.Drawing.Point(4, 22);
            this.Board2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Board2.Name = "Board2";
            this.Board2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Board2.Size = new System.Drawing.Size(774, 552);
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
            this.Board1.Location = new System.Drawing.Point(4, 22);
            this.Board1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Board1.Name = "Board1";
            this.Board1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Board1.Size = new System.Drawing.Size(849, 552);
            this.Board1.TabIndex = 0;
            this.Board1.Text = "Board1";
            this.Board1.UseVisualStyleBackColor = true;
            // 
            // DeleteBoard
            // 
            this.DeleteBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBoard.Location = new System.Drawing.Point(623, 4);
            this.DeleteBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBoard.Name = "DeleteBoard";
            this.DeleteBoard.Size = new System.Drawing.Size(107, 31);
            this.DeleteBoard.TabIndex = 2;
            this.DeleteBoard.Text = "- Board";
            this.DeleteBoard.UseVisualStyleBackColor = true;
            this.DeleteBoard.Click += new System.EventHandler(this.DeleteBoard_Click);
            // 
            // AddList
            // 
            this.AddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddList.Location = new System.Drawing.Point(4, 4);
            this.AddList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(107, 31);
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
            this.BoardArea.Location = new System.Drawing.Point(9, 44);
            this.BoardArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoardArea.Name = "BoardArea";
            this.BoardArea.SelectedIndex = 0;
            this.BoardArea.Size = new System.Drawing.Size(857, 578);
            this.BoardArea.TabIndex = 1;
            // 
            // DeleteTask
            // 
            this.DeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTask.Location = new System.Drawing.Point(412, 11);
            this.DeleteTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(80, 30);
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
            this.ListArea.Location = new System.Drawing.Point(5, 40);
            this.ListArea.Name = "ListArea";
            this.ListArea.Size = new System.Drawing.Size(839, 507);
            this.ListArea.TabIndex = 4;
            this.ListArea.WrapContents = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 630);
            this.Controls.Add(this.BoardArea);
            this.Controls.Add(this.DeleteTask);
            this.Controls.Add(this.AddBoard);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.FlowLayoutPanel ListArea;
    }
}