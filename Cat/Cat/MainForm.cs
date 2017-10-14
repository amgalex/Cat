using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            mainForm = this;
        }
        static private MainForm mainForm;
        static public MainForm Form { get { return mainForm; } }

        static public void AddMdiChild(Form form, Image image)
        {
            MainForm mainForm = Form;
            if (mainForm.activeFormButton != null) mainForm.activeFormButton.Checked = false;
            form.MdiParent = mainForm;
            ToolStripButton btn = new ToolStripButton();
            btn.AutoSize = false;
            btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            btn.Size = new System.Drawing.Size(150, 22);
            btn.Image = image;
            btn.Text = form.Text.Substring(0, Math.Min(20, form.Text.Length)) + (form.Text.Length > 20 ? ".." : "");
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.DoubleClickEnabled = true;
            btn.Tag = form;
            btn.Checked = true;
            btn.Click += new EventHandler(mainForm.formButtonClick);
            form.Tag = btn;
            form.FormClosed += new FormClosedEventHandler(mainForm.form_FormClosed);
            form.Activated += new EventHandler(mainForm.form_Activated);

            mainForm.activeFormButton = btn;
            mainForm.windowStrip.Items.Add(btn);
        }

        void form_Activated(object sender, EventArgs e)
        {
            if (activeFormButton != null)
                activeFormButton.Checked = false;
            if (this.ActiveMdiChild != null)
            {
                activeFormButton = ((ToolStripButton)this.ActiveMdiChild.Tag);
                activeFormButton.Checked = true;
            }
            else activeFormButton = null;
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ToolStripItem)((Form)sender).Tag).Dispose();
        }

        private ToolStripButton activeFormButton;

        void formButtonClick(object sender, EventArgs e)
        {
            if (activeFormButton != null) activeFormButton.Checked = false;
            activeFormButton = ((ToolStripButton)sender);
            ((Form)activeFormButton.Tag).Activate();
            activeFormButton.Checked = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChildForm f = new ChildForm();
            AddMdiChild(f, Properties.Resources.application);
            f.Show();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm f = new ChildForm();
            AddMdiChild(f, Properties.Resources.application);
            f.Show();
        }
    }
}
