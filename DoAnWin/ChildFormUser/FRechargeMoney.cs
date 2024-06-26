﻿using DoAnWin.DAOClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin.ChildFormUser
{
    public partial class FRechargeMoney : Form
    {
        public FRechargeMoney()
        {
            InitializeComponent();
        }

        private void FRechargeMoney_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            UserDAO ud = new UserDAO();
            string Money = (long.Parse(ud.MoneyBalance()) + long.Parse(txtMoney.Text)).ToString();
            ud.RechargeMoney(Money);
        }
    }
}
