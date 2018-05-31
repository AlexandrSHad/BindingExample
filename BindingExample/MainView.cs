﻿using BindingExample.Core.Models;
using BindingExample.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BindingExample
{
    public partial class MainView : Telerik.WinControls.UI.RadForm, IMainView
    {
        private IMainViewPresenter _presenter;
        private BindingSource _usersListBindingSource = new BindingSource();
        private BindingSource _userBindingSource = new BindingSource { DataSource = typeof(IUserModel) };
        private BindingSource _userRolesBindingSource = new BindingSource { DataSource = typeof(IUserRoleModel) };
        private IUserDictionaries _dictionaries;

        public MainView()
        {
            InitializeComponent();

            InitializeBindings();
        }

        private void InitializeBindings()
        {
            usersGridView.DataSource = _usersListBindingSource;

            nameTextBox.DataBindings.Add("Text", _userBindingSource, "Name");
            birthDateDateTimePicker.DataBindings.Add("Value", _userBindingSource, "BirthDate");
            roleDropDownList.DataBindings.Add("SelectedValue", _userRolesBindingSource, "RoleId");

            // controls
            userInfoCtrl.DataSource = _userBindingSource;
            userInfoCtrl.DataSourceRoles = _userRolesBindingSource;
            // controls

            var columnRole = usersGridView.Columns["Role"] as GridViewComboBoxColumn;
            columnRole.DataSource = _userRolesBindingSource;
            columnRole.ValueMember = "Id";
            columnRole.DisplayMember = "Name";

            roleDropDownList.DataSource = _userRolesBindingSource;
            roleDropDownList.ValueMember = "Id";
            roleDropDownList.DisplayMember = "Name";
        }

        #region IMainView implementation

        public IMainViewPresenter Presenter
        {
            get { return _presenter; }
            set
            {
                if (_presenter == null)
                {
                    _presenter = value;
                }
            }
        }

        public IUserDictionaries Dictionaries
        {
            get => _dictionaries;
            set
            {
                _dictionaries = value;

                _userRolesBindingSource.DataSource = _dictionaries.Roles;
            }
        }

        public IEnumerable<IUserModel> UsersList
        {
            get => _usersListBindingSource.List.Cast<IUserModel>();
            set => _usersListBindingSource.DataSource = value.ToList();
        }

        public int SelectedUserId
        {
            get
            {
                return (usersGridView.CurrentRow.DataBoundItem is IUserModel user) ? user.Id : 0;
            }
        }

        public IUserModel User
        {
            get => _userBindingSource.Current as IUserModel;
            set => _userBindingSource.DataSource = value;
        }

        public void Run()
        {
            ShowUserList();
            Application.Run(this);
        }

        public void ShowUserList()
        {
            mainPageView.SelectedPage = usersListPage;
        }

        public void ShowUserEdit()
        {
            mainPageView.SelectedPage = createUserPage;
        }

        #endregion

        private void usersGridView_DoubleClick(object sender, EventArgs e)
        {
            _presenter.RunUserEdit();
        }
    }
}
