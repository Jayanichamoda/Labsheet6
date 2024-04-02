namespace EmployeeManagement
{
    partial class Edit
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
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updatebtn = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(363, 26);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(118, 42);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(86, 32);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(245, 30);
            this.searchtxt.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 219);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(778, 372);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(109, 38);
            this.updatebtn.TabIndex = 4;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(178, 79);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(298, 25);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Enter username to display details";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(920, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.searchbtn);
            this.Name = "Edit";
            this.Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
    }
}