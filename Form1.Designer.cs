namespace IteratorPattern
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
            this.list_people = new System.Windows.Forms.ListBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.btn_ageSort = new System.Windows.Forms.Button();
            this.btn_nameSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_people
            // 
            this.list_people.FormattingEnabled = true;
            this.list_people.ItemHeight = 25;
            this.list_people.Location = new System.Drawing.Point(13, 13);
            this.list_people.Name = "list_people";
            this.list_people.Size = new System.Drawing.Size(433, 879);
            this.list_people.TabIndex = 0;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(453, 13);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(270, 65);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next Person";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(453, 85);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(270, 76);
            this.btn_first.TabIndex = 2;
            this.btn_first.Text = "First Person";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(451, 179);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(70, 25);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "label1";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(452, 226);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(70, 25);
            this.lbl_age.TabIndex = 4;
            this.lbl_age.Text = "label1";
            // 
            // btn_ageSort
            // 
            this.btn_ageSort.Location = new System.Drawing.Point(1053, 13);
            this.btn_ageSort.Name = "btn_ageSort";
            this.btn_ageSort.Size = new System.Drawing.Size(274, 65);
            this.btn_ageSort.TabIndex = 5;
            this.btn_ageSort.Text = "Sort by Age";
            this.btn_ageSort.UseVisualStyleBackColor = true;
            this.btn_ageSort.Click += new System.EventHandler(this.btn_ageSort_Click);
            // 
            // btn_nameSort
            // 
            this.btn_nameSort.Location = new System.Drawing.Point(1053, 85);
            this.btn_nameSort.Name = "btn_nameSort";
            this.btn_nameSort.Size = new System.Drawing.Size(273, 76);
            this.btn_nameSort.TabIndex = 6;
            this.btn_nameSort.Text = "Sort by Name";
            this.btn_nameSort.UseVisualStyleBackColor = true;
            this.btn_nameSort.Click += new System.EventHandler(this.btn_nameSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 917);
            this.Controls.Add(this.btn_nameSort);
            this.Controls.Add(this.btn_ageSort);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.list_people);
            this.Name = "Form1";
            this.Text = "Iterator Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_people;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Button btn_ageSort;
        private System.Windows.Forms.Button btn_nameSort;
    }
}

