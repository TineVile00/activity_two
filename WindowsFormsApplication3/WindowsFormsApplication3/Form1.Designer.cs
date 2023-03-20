namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.wishList = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.Label();
            this.selection = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.fillBtn = new System.Windows.Forms.Button();
            this.sortbtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.countBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.selectionBox = new System.Windows.Forms.TextBox();
            this.countBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wishList
            // 
            this.wishList.FormattingEnabled = true;
            this.wishList.Location = new System.Drawing.Point(19, 74);
            this.wishList.Name = "wishList";
            this.wishList.Size = new System.Drawing.Size(181, 173);
            this.wishList.TabIndex = 0;
            this.wishList.SelectedIndexChanged += new System.EventHandler(this.wishList_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.title.Location = new System.Drawing.Point(13, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(124, 31);
            this.title.TabIndex = 1;
            this.title.Text = "Wish List";
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Location = new System.Drawing.Point(23, 285);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(54, 13);
            this.selection.TabIndex = 2;
            this.selection.Text = "Selection:";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(23, 330);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(38, 13);
            this.count.TabIndex = 3;
            this.count.Text = "Count:";
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(237, 74);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(75, 23);
            this.fillBtn.TabIndex = 4;
            this.fillBtn.Text = "Fill";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // sortbtn
            // 
            this.sortbtn.Location = new System.Drawing.Point(237, 113);
            this.sortbtn.Name = "sortbtn";
            this.sortbtn.Size = new System.Drawing.Size(75, 23);
            this.sortbtn.TabIndex = 5;
            this.sortbtn.Text = "Sort";
            this.sortbtn.UseVisualStyleBackColor = true;
            this.sortbtn.Click += new System.EventHandler(this.sortbtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(237, 151);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(237, 188);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(75, 23);
            this.countBtn.TabIndex = 7;
            this.countBtn.Text = "Count";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(237, 224);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // selectionBox
            // 
            this.selectionBox.Location = new System.Drawing.Point(83, 282);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(101, 20);
            this.selectionBox.TabIndex = 9;
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(83, 323);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(100, 20);
            this.countBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 391);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.selectionBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.sortbtn);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.count);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.title);
            this.Controls.Add(this.wishList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wishList;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label selection;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button sortbtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox selectionBox;
        private System.Windows.Forms.TextBox countBox;
    }
}

