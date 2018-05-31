namespace ViewControlLibrary
{
    partial class UserInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.roleDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.birthDateDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.nameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(1, 31);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(57, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Birth date:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(1, 57);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(31, 18);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Role:";
            // 
            // roleDropDownList
            // 
            this.roleDropDownList.Location = new System.Drawing.Point(80, 57);
            this.roleDropDownList.Name = "roleDropDownList";
            this.roleDropDownList.Size = new System.Drawing.Size(164, 20);
            this.roleDropDownList.TabIndex = 9;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.CustomFormat = "";
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(80, 30);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDateDateTimePicker.NullText = "Pick a date";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(164, 20);
            this.birthDateDateTimePicker.TabIndex = 8;
            this.birthDateDateTimePicker.TabStop = false;
            this.birthDateDateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(80, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(164, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Name:";
            // 
            // UserInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.roleDropDownList);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.radLabel1);
            this.Name = "UserInfoControl";
            this.Size = new System.Drawing.Size(247, 80);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList roleDropDownList;
        private Telerik.WinControls.UI.RadDateTimePicker birthDateDateTimePicker;
        private Telerik.WinControls.UI.RadTextBox nameTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
