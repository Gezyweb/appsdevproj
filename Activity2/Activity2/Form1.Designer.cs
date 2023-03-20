namespace Activity2
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
            this.label1 = new System.Windows.Forms.Label();
            this.wishlist = new System.Windows.Forms.ListBox();
            this.fillButton = new System.Windows.Forms.Button();
            this.countOutputBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.selection = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectionOutputBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WISHLIST";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // wishlist
            // 
            this.wishlist.FormattingEnabled = true;
            this.wishlist.Location = new System.Drawing.Point(40, 76);
            this.wishlist.Name = "wishlist";
            this.wishlist.Size = new System.Drawing.Size(142, 160);
            this.wishlist.TabIndex = 1;
            this.wishlist.SelectedIndexChanged += new System.EventHandler(this.wishlist_SelectedIndexChanged);
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(215, 76);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(75, 23);
            this.fillButton.TabIndex = 2;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // countOutputBox
            // 
            this.countOutputBox.Location = new System.Drawing.Point(111, 305);
            this.countOutputBox.Name = "countOutputBox";
            this.countOutputBox.Size = new System.Drawing.Size(100, 20);
            this.countOutputBox.TabIndex = 3;
            this.countOutputBox.TextChanged += new System.EventHandler(this.countOutputBox_TextChanged);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(215, 117);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(215, 159);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(215, 206);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 6;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Location = new System.Drawing.Point(37, 265);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(51, 13);
            this.selection.TabIndex = 7;
            this.selection.Text = "Selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Count";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // selectionOutputBox
            // 
            this.selectionOutputBox.Location = new System.Drawing.Point(111, 265);
            this.selectionOutputBox.Name = "selectionOutputBox";
            this.selectionOutputBox.Size = new System.Drawing.Size(100, 20);
            this.selectionOutputBox.TabIndex = 9;
            this.selectionOutputBox.TextChanged += new System.EventHandler(this.selectionOutputBox_TextChanged);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(215, 245);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 404);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.selectionOutputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.countOutputBox);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.wishlist);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox wishlist;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.TextBox countOutputBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label selection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selectionOutputBox;
        private System.Windows.Forms.Button closeButton;
    }
}

