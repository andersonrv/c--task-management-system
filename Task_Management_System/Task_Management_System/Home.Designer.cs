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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BoardArea = new System.Windows.Forms.TabControl();
            this.DeleteBoard = new System.Windows.Forms.Button();
            this.DeleteList = new System.Windows.Forms.Button();
            this.AddList = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.BoardArea.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1903, 857);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteList);
            this.tabPage1.Controls.Add(this.AddList);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1903, 857);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BoardArea
            // 
            this.BoardArea.Controls.Add(this.tabPage1);
            this.BoardArea.Controls.Add(this.tabPage2);
            this.BoardArea.Location = new System.Drawing.Point(13, 68);
            this.BoardArea.Name = "BoardArea";
            this.BoardArea.SelectedIndex = 0;
            this.BoardArea.Size = new System.Drawing.Size(1911, 890);
            this.BoardArea.TabIndex = 1;
            // 
            // DeleteBoard
            // 
            this.DeleteBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBoard.Location = new System.Drawing.Point(180, 14);
            this.DeleteBoard.Name = "DeleteBoard";
            this.DeleteBoard.Size = new System.Drawing.Size(161, 48);
            this.DeleteBoard.TabIndex = 2;
            this.DeleteBoard.Text = "- Board";
            this.DeleteBoard.UseVisualStyleBackColor = true;
            // 
            // DeleteList
            // 
            this.DeleteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteList.Location = new System.Drawing.Point(173, 7);
            this.DeleteList.Name = "DeleteList";
            this.DeleteList.Size = new System.Drawing.Size(161, 48);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1936, 970);
            this.Controls.Add(this.DeleteBoard);
            this.Controls.Add(this.BoardArea);
            this.Controls.Add(this.AddBoard);
            this.Name = "Home";
            this.Text = "Home";
            this.tabPage1.ResumeLayout(false);
            this.BoardArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBoard;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl BoardArea;
        private System.Windows.Forms.Button DeleteBoard;
        private System.Windows.Forms.Button DeleteList;
        private System.Windows.Forms.Button AddList;
    }
}