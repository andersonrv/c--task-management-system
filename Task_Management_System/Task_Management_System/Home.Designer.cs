﻿namespace Task_Management_System
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
            this.BoardArea = new System.Windows.Forms.TabControl();
            this.DeleteBoard = new System.Windows.Forms.Button();
            this.DeleteList = new System.Windows.Forms.Button();
            this.AddList = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.Panel();
            this.DeleteTask = new System.Windows.Forms.Button();
            this.AddTask = new System.Windows.Forms.Button();
            this.ListArea = new System.Windows.Forms.Panel();
            this.ListName = new System.Windows.Forms.Label();
            this.Board1.SuspendLayout();
            this.BoardArea.SuspendLayout();
            this.List.SuspendLayout();
            this.ListArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBoard
            // 
            this.AddBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBoard.Location = new System.Drawing.Point(13, 13);
            this.AddBoard.Name = "AddBoard";
            this.AddBoard.Size = new System.Drawing.Size(161, 48);
            this.AddBoard.TabIndex = 0;
            this.AddBoard.Text = "+ Board";
            this.AddBoard.UseVisualStyleBackColor = true;
            this.AddBoard.Click += new System.EventHandler(this.AddBoard_Click);
            // 
            // Board2
            // 
            this.Board2.Location = new System.Drawing.Point(4, 29);
            this.Board2.Name = "Board2";
            this.Board2.Padding = new System.Windows.Forms.Padding(3);
            this.Board2.Size = new System.Drawing.Size(1903, 857);
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
            this.Board1.Location = new System.Drawing.Point(4, 29);
            this.Board1.Name = "Board1";
            this.Board1.Padding = new System.Windows.Forms.Padding(3);
            this.Board1.Size = new System.Drawing.Size(1903, 857);
            this.Board1.TabIndex = 0;
            this.Board1.Text = "Board1";
            this.Board1.UseVisualStyleBackColor = true;
            // 
            // BoardArea
            // 
            this.BoardArea.Controls.Add(this.Board1);
            this.BoardArea.Controls.Add(this.Board2);
            this.BoardArea.Location = new System.Drawing.Point(13, 68);
            this.BoardArea.Name = "BoardArea";
            this.BoardArea.SelectedIndex = 0;
            this.BoardArea.Size = new System.Drawing.Size(1911, 890);
            this.BoardArea.TabIndex = 1;
            // 
            // DeleteBoard
            // 
            this.DeleteBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBoard.Location = new System.Drawing.Point(1736, 6);
            this.DeleteBoard.Name = "DeleteBoard";
            this.DeleteBoard.Size = new System.Drawing.Size(161, 48);
            this.DeleteBoard.TabIndex = 2;
            this.DeleteBoard.Text = "- Board";
            this.DeleteBoard.UseVisualStyleBackColor = true;
            this.DeleteBoard.Click += new System.EventHandler(this.DeleteBoard_Click);
            // 
            // DeleteList
            // 
            this.DeleteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteList.Location = new System.Drawing.Point(3, 697);
            this.DeleteList.Name = "DeleteList";
            this.DeleteList.Size = new System.Drawing.Size(321, 48);
            this.DeleteList.TabIndex = 4;
            this.DeleteList.Text = "- List";
            this.DeleteList.UseVisualStyleBackColor = true;
            // 
            // AddList
            // 
            this.AddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddList.Location = new System.Drawing.Point(6, 6);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(161, 48);
            this.AddList.TabIndex = 3;
            this.AddList.Text = "+ List";
            this.AddList.UseVisualStyleBackColor = true;
            // 
            // List
            // 
            this.List.Controls.Add(this.ListName);
            this.List.Controls.Add(this.DeleteList);
            this.List.Controls.Add(this.AddTask);
            this.List.Location = new System.Drawing.Point(3, 3);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(327, 748);
            this.List.TabIndex = 5;
            // 
            // DeleteTask
            // 
            this.DeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTask.Location = new System.Drawing.Point(618, 16);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(120, 46);
            this.DeleteTask.TabIndex = 7;
            this.DeleteTask.Text = "- Task";
            this.DeleteTask.UseVisualStyleBackColor = true;
            // 
            // AddTask
            // 
            this.AddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTask.Location = new System.Drawing.Point(3, 51);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(321, 46);
            this.AddTask.TabIndex = 6;
            this.AddTask.Text = "+ Task";
            this.AddTask.UseVisualStyleBackColor = true;
            // 
            // ListArea
            // 
            this.ListArea.AutoScroll = true;
            this.ListArea.Controls.Add(this.List);
            this.ListArea.Location = new System.Drawing.Point(7, 61);
            this.ListArea.Name = "ListArea";
            this.ListArea.Size = new System.Drawing.Size(1890, 790);
            this.ListArea.TabIndex = 6;
            // 
            // ListName
            // 
            this.ListName.AutoSize = true;
            this.ListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListName.Location = new System.Drawing.Point(96, 11);
            this.ListName.Name = "ListName";
            this.ListName.Size = new System.Drawing.Size(142, 32);
            this.ListName.TabIndex = 7;
            this.ListName.Text = "List Name";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1936, 970);
            this.Controls.Add(this.BoardArea);
            this.Controls.Add(this.DeleteTask);
            this.Controls.Add(this.AddBoard);
            this.Name = "Home";
            this.Text = "Home";
            this.Board1.ResumeLayout(false);
            this.BoardArea.ResumeLayout(false);
            this.List.ResumeLayout(false);
            this.List.PerformLayout();
            this.ListArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBoard;
        private System.Windows.Forms.TabPage Board2;
        private System.Windows.Forms.TabPage Board1;
        private System.Windows.Forms.TabControl BoardArea;
        private System.Windows.Forms.Button DeleteBoard;
        private System.Windows.Forms.Button DeleteList;
        private System.Windows.Forms.Button AddList;
        private System.Windows.Forms.Panel List;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.Button DeleteTask;
        private System.Windows.Forms.Panel ListArea;
        private System.Windows.Forms.Label ListName;
    }
}