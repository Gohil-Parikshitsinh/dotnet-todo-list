namespace TodoListApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.taskGrid = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(191, 26);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(332, 22);
            this.txtTaskName.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(191, 56);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(332, 22);
            this.txtDescription.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(65, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(230, 99);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 43);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Task";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(404, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(576, 99);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(119, 43);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Mark Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // taskGrid
            // 
            this.taskGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskGrid.Location = new System.Drawing.Point(65, 172);
            this.taskGrid.Name = "taskGrid";
            this.taskGrid.RowHeadersWidth = 51;
            this.taskGrid.RowTemplate.Height = 24;
            this.taskGrid.Size = new System.Drawing.Size(630, 266);
            this.taskGrid.TabIndex = 8;
            this.taskGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskGrid_CellClick);
            this.taskGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.taskGrid_RowPrePaint_1);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(576, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 16);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total Tasks:";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(579, 48);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(73, 16);
            this.lblDone.TabIndex = 10;
            this.lblDone.Text = "Completed";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Location = new System.Drawing.Point(582, 68);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(57, 16);
            this.lblPending.TabIndex = 11;
            this.lblPending.Text = "Pending";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.taskGrid);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridView taskGrid;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblPending;
    }
}

