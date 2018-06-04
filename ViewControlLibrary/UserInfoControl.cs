using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BindingExample.Core.Models;

namespace ViewControlLibrary
{
    public partial class UserInfoControl : UserControl
    {
        private BindingSource _bindingSource = new BindingSource { DataSource = typeof(IUserModel) };

        public UserInfoControl()
        {
            InitializeComponent();

            InitializeBinding();
        }

        private void InitializeBinding()
        {
            nameTextBox.DataBindings.Add("Text", _bindingSource, "Name");
            birthDateDateTimePicker.DataBindings.Add("Value", _bindingSource, "BirthDate");
            roleDropDownList.DataBindings.Add("SelectedValue", _bindingSource, "RoleId");
            roleDropDownList.ValueMember = "Id";
            roleDropDownList.DisplayMember = "Name";
        }

        [Category("Data")]
        [AttributeProvider(typeof(IListSource))]
        public object DataSource
        {
            get => _bindingSource.DataSource;
            set
            {
                if (_bindingSource.DataSource != value)
                {
                    _bindingSource.DataSource = value;
                }
            }
        }

        [Category("Data")]
        [AttributeProvider(typeof(IListSource))]
        public object DataSourceRoles
        {
            get => roleDropDownList.DataSource;
            set
            {
                if (roleDropDownList.DataSource != value)
                {
                    roleDropDownList.DataSource = value;
                }
            }
        }
    }
}
