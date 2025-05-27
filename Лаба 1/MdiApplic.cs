using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
             
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
        
        }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            ParentForm добавьте код:
            public ParentForm()
            {
                InitializeComponent();
                // Свойству Text панели spData устанавливается текущая дата
                spData.Text =
                Convert.ToString(System.DateTime.Today.ToLongDateString());
            }
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);

        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Show();


            newChild.Text = newChild.Text + " " + ++openDocuments;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " +
                    ++openDocuments;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
                case "Title":
                    this.LayoutMdi
                    (System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }
        }
    }
}
