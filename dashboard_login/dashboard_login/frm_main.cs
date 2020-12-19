using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private UserControl activeForm = null;
        private void openChildForm(UserControl childForm)
        {
            if (activeForm != null) activeForm.Controls.Clear();
            activeForm = childForm;
            panel_Child.Dock = DockStyle.Fill;
            panel_Child.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnToggleDrawer_Click(object sender, EventArgs e)
        {

            if (pnlDrawer.Width == 233)
            {
                //Drawer Open
                this.Width = 961;
                pnlDrawer.Width = 56;
            }
            else
            {
                //Drawer Close
                this.Width = 1138;
                pnlDrawer.Width = 233;
            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            openChildForm(new tab_management());
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            openChildForm(new tab_management());
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            openChildForm(new tab_user_info());
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            openChildForm(new tab_info());
        }
    }
}
