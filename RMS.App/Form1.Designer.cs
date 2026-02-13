namespace RMS.App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEquipment = new DataGridView();
            groupBox1 = new GroupBox();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            label4 = new Label();
            cbLoanStatus = new ComboBox();
            label3 = new Label();
            cbCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtModel = new TextBox();
            txtSerialNumber = new TextBox();
            Id = new DataGridViewTextBoxColumn();
            SerialNumber = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            LoanStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEquipment
            // 
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Columns.AddRange(new DataGridViewColumn[] { Id, SerialNumber, Model, Category, LoanStatus });
            dgvEquipment.Location = new Point(397, 30);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersWidth = 51;
            dgvEquipment.Size = new Size(425, 349);
            dgvEquipment.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbLoanStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(txtSerialNumber);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 468);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(36, 381);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 346);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(36, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 267);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 7;
            label4.Text = "Loan Status";
            // 
            // cbLoanStatus
            // 
            cbLoanStatus.FormattingEnabled = true;
            cbLoanStatus.Location = new Point(36, 301);
            cbLoanStatus.Name = "cbLoanStatus";
            cbLoanStatus.Size = new Size(262, 28);
            cbLoanStatus.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 179);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(36, 213);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(262, 28);
            cbCategory.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 110);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "Serial Number";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(36, 133);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(262, 27);
            txtModel.TabIndex = 1;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(36, 66);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(262, 27);
            txtSerialNumber.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.Frozen = true;
            Id.HeaderText = "**";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // SerialNumber
            // 
            SerialNumber.DataPropertyName = "SerialNumber";
            SerialNumber.HeaderText = "Serial Number";
            SerialNumber.MinimumWidth = 6;
            SerialNumber.Name = "SerialNumber";
            SerialNumber.Width = 125;
            // 
            // Model
            // 
            Model.DataPropertyName = "Models";
            Model.HeaderText = "Model";
            Model.MinimumWidth = 6;
            Model.Name = "Model";
            Model.Width = 125;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // LoanStatus
            // 
            LoanStatus.DataPropertyName = "LoanStatus";
            LoanStatus.HeaderText = "Loan Status";
            LoanStatus.MinimumWidth = 6;
            LoanStatus.Name = "LoanStatus";
            LoanStatus.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 501);
            Controls.Add(groupBox1);
            Controls.Add(dgvEquipment);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEquipment;
        private GroupBox groupBox1;
        private TextBox txtModel;
        private TextBox txtSerialNumber;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox cbCategory;
        private Label label4;
        private ComboBox cbLoanStatus;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SerialNumber;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn LoanStatus;
    }
}
