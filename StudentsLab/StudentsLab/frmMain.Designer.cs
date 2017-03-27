namespace StudentsLab
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label studentLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label wasAttendedLabel;
            this.studentsLabsDataSet = new StudentsLab.StudentsLabsDataSet();
            this.studentLabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentLabTableAdapter = new StudentsLab.StudentsLabsDataSetTableAdapters.StudentLabTableAdapter();
            this.tableAdapterManager = new StudentsLab.StudentsLabsDataSetTableAdapters.TableAdapterManager();
            this.Nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.studentLabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.studentTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.wasAttendedCheckBox = new System.Windows.Forms.CheckBox();
            this.closeBtn = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            studentLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            wasAttendedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsLabsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nav)).BeginInit();
            this.Nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsLabsDataSet
            // 
            this.studentsLabsDataSet.DataSetName = "StudentsLabsDataSet";
            this.studentsLabsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentLabBindingSource
            // 
            this.studentLabBindingSource.DataMember = "StudentLab";
            this.studentLabBindingSource.DataSource = this.studentsLabsDataSet;
            // 
            // studentLabTableAdapter
            // 
            this.studentLabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentLabTableAdapter = this.studentLabTableAdapter;
            this.tableAdapterManager.UpdateOrder = StudentsLab.StudentsLabsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Nav
            // 
            this.Nav.AddNewItem = this.bindingNavigatorAddNewItem;
            this.Nav.BindingSource = this.studentLabBindingSource;
            this.Nav.CountItem = this.bindingNavigatorCountItem;
            this.Nav.DeleteItem = this.bindingNavigatorDeleteItem;
            this.Nav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentLabBindingNavigatorSaveItem});
            this.Nav.Location = new System.Drawing.Point(0, 0);
            this.Nav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.Nav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.Nav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.Nav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.Nav.Name = "Nav";
            this.Nav.PositionItem = this.bindingNavigatorPositionItem;
            this.Nav.Size = new System.Drawing.Size(297, 25);
            this.Nav.TabIndex = 0;
            this.Nav.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // studentLabBindingNavigatorSaveItem
            // 
            this.studentLabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentLabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentLabBindingNavigatorSaveItem.Image")));
            this.studentLabBindingNavigatorSaveItem.Name = "studentLabBindingNavigatorSaveItem";
            this.studentLabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentLabBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studentLabBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentLabBindingNavigatorSaveItem_Click_1);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(6, 36);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentLabBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(90, 33);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Location = new System.Drawing.Point(6, 62);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new System.Drawing.Size(47, 13);
            studentLabel.TabIndex = 3;
            studentLabel.Text = "Student:";
            studentLabel.Click += new System.EventHandler(this.studentLabel_Click);
            // 
            // studentTextBox
            // 
            this.studentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentLabBindingSource, "Student", true));
            this.studentTextBox.Location = new System.Drawing.Point(90, 59);
            this.studentTextBox.Name = "studentTextBox";
            this.studentTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentTextBox.TabIndex = 4;
            this.studentTextBox.TextChanged += new System.EventHandler(this.studentTextBox_TextChanged);
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(6, 88);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(46, 13);
            subjectLabel.TabIndex = 5;
            subjectLabel.Text = "Subject:";
            subjectLabel.Click += new System.EventHandler(this.subjectLabel_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentLabBindingSource, "Subject", true));
            this.subjectTextBox.Location = new System.Drawing.Point(90, 85);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(200, 20);
            this.subjectTextBox.TabIndex = 6;
            this.subjectTextBox.TextChanged += new System.EventHandler(this.subjectTextBox_TextChanged);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(6, 115);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "Date:";
            dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentLabBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(90, 111);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 8;
            this.dateDateTimePicker.ValueChanged += new System.EventHandler(this.dateDateTimePicker_ValueChanged);
            // 
            // wasAttendedLabel
            // 
            wasAttendedLabel.AutoSize = true;
            wasAttendedLabel.Location = new System.Drawing.Point(6, 142);
            wasAttendedLabel.Name = "wasAttendedLabel";
            wasAttendedLabel.Size = new System.Drawing.Size(78, 13);
            wasAttendedLabel.TabIndex = 9;
            wasAttendedLabel.Text = "Was Attended:";
            wasAttendedLabel.Click += new System.EventHandler(this.wasAttendedLabel_Click);
            // 
            // wasAttendedCheckBox
            // 
            this.wasAttendedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.studentLabBindingSource, "WasAttended", true));
            this.wasAttendedCheckBox.Location = new System.Drawing.Point(90, 137);
            this.wasAttendedCheckBox.Name = "wasAttendedCheckBox";
            this.wasAttendedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.wasAttendedCheckBox.TabIndex = 10;
            this.wasAttendedCheckBox.UseVisualStyleBackColor = true;
            this.wasAttendedCheckBox.CheckedChanged += new System.EventHandler(this.wasAttendedCheckBox_CheckedChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(215, 142);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.OnClose);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 262);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(studentLabel);
            this.Controls.Add(this.studentTextBox);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(wasAttendedLabel);
            this.Controls.Add(this.wasAttendedCheckBox);
            this.Controls.Add(this.Nav);
            this.Name = "frmMain";
            this.Text = "Students Attendance of Labs";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsLabsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nav)).EndInit();
            this.Nav.ResumeLayout(false);
            this.Nav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentsLabsDataSet studentsLabsDataSet;
        private System.Windows.Forms.BindingSource studentLabBindingSource;
        private StudentsLabsDataSetTableAdapters.StudentLabTableAdapter studentLabTableAdapter;
        private StudentsLabsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator Nav;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentLabBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox studentTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.CheckBox wasAttendedCheckBox;
        private System.Windows.Forms.Button closeBtn;

    }
}

