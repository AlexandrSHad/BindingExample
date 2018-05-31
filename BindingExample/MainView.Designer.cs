namespace BindingExample
{
    partial class MainView
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.mainPageView = new Telerik.WinControls.UI.RadPageView();
            this.usersListPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.usersGridView = new Telerik.WinControls.UI.RadGridView();
            this.createUserPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.userInfoCtrl = new ViewControlLibrary.UserInfoControl();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.roleDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.birthDateDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.nameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageView)).BeginInit();
            this.mainPageView.SuspendLayout();
            this.usersListPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView.MasterTemplate)).BeginInit();
            this.createUserPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPageView
            // 
            this.mainPageView.Controls.Add(this.usersListPage);
            this.mainPageView.Controls.Add(this.createUserPage);
            this.mainPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPageView.Location = new System.Drawing.Point(0, 0);
            this.mainPageView.Name = "mainPageView";
            this.mainPageView.SelectedPage = this.createUserPage;
            this.mainPageView.Size = new System.Drawing.Size(631, 389);
            this.mainPageView.TabIndex = 0;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.mainPageView.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // usersListPage
            // 
            this.usersListPage.Controls.Add(this.usersGridView);
            this.usersListPage.ItemSize = new System.Drawing.SizeF(61F, 28F);
            this.usersListPage.Location = new System.Drawing.Point(10, 37);
            this.usersListPage.Name = "usersListPage";
            this.usersListPage.Size = new System.Drawing.Size(610, 341);
            this.usersListPage.Text = "List page";
            // 
            // usersGridView
            // 
            this.usersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.usersGridView.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 150;
            gridViewDateTimeColumn1.CustomFormat = "dd/MM/yyyy";
            gridViewDateTimeColumn1.FieldName = "BirthDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn1.FormatString = "{0:dd/MM/yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Birth date";
            gridViewDateTimeColumn1.Name = "BirthDate";
            gridViewDateTimeColumn1.Width = 100;
            gridViewComboBoxColumn1.DataType = typeof(int);
            gridViewComboBoxColumn1.FieldName = "RoleId";
            gridViewComboBoxColumn1.HeaderText = "Role";
            gridViewComboBoxColumn1.Name = "Role";
            gridViewComboBoxColumn1.Width = 100;
            this.usersGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewComboBoxColumn1});
            this.usersGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.Size = new System.Drawing.Size(610, 341);
            this.usersGridView.TabIndex = 0;
            this.usersGridView.DoubleClick += new System.EventHandler(this.usersGridView_DoubleClick);
            // 
            // createUserPage
            // 
            this.createUserPage.Controls.Add(this.userInfoCtrl);
            this.createUserPage.Controls.Add(this.radLabel2);
            this.createUserPage.Controls.Add(this.radLabel3);
            this.createUserPage.Controls.Add(this.roleDropDownList);
            this.createUserPage.Controls.Add(this.birthDateDateTimePicker);
            this.createUserPage.Controls.Add(this.nameTextBox);
            this.createUserPage.Controls.Add(this.radLabel1);
            this.createUserPage.ItemSize = new System.Drawing.SizeF(100F, 28F);
            this.createUserPage.Location = new System.Drawing.Point(10, 37);
            this.createUserPage.Name = "createUserPage";
            this.createUserPage.Size = new System.Drawing.Size(610, 341);
            this.createUserPage.Text = "Create/edit page";
            // 
            // userInfoCtrl
            // 
            this.userInfoCtrl.DataSource = typeof(BindingExample.Core.Models.IUserModel);
            this.userInfoCtrl.Location = new System.Drawing.Point(42, 172);
            this.userInfoCtrl.Name = "userInfoCtrl";
            this.userInfoCtrl.Size = new System.Drawing.Size(247, 80);
            this.userInfoCtrl.TabIndex = 4;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(40, 73);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(57, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Birth date:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(40, 99);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(31, 18);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Role:";
            // 
            // roleDropDownList
            // 
            this.roleDropDownList.Location = new System.Drawing.Point(119, 99);
            this.roleDropDownList.Name = "roleDropDownList";
            this.roleDropDownList.Size = new System.Drawing.Size(164, 20);
            this.roleDropDownList.TabIndex = 3;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.CustomFormat = "";
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(119, 72);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDateDateTimePicker.NullText = "Pick a date";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(164, 20);
            this.birthDateDateTimePicker.TabIndex = 2;
            this.birthDateDateTimePicker.TabStop = false;
            this.birthDateDateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(119, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(164, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(42, 46);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Name:";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 389);
            this.Controls.Add(this.mainPageView);
            this.Name = "MainView";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.mainPageView)).EndInit();
            this.mainPageView.ResumeLayout(false);
            this.usersListPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.createUserPage.ResumeLayout(false);
            this.createUserPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView mainPageView;
        private Telerik.WinControls.UI.RadPageViewPage usersListPage;
        private Telerik.WinControls.UI.RadPageViewPage createUserPage;
        private Telerik.WinControls.UI.RadGridView usersGridView;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList roleDropDownList;
        private Telerik.WinControls.UI.RadDateTimePicker birthDateDateTimePicker;
        private Telerik.WinControls.UI.RadTextBox nameTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private ViewControlLibrary.UserInfoControl userInfoCtrl;
    }
}