using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Animals.BL;
using Animals.Enumerations;

namespace OldMcDonaldsFarm.UI
{
    public partial class frmAnimals : Form
    {
        List<Cat> cats;
        public frmAnimals()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cats = new List<Cat>();
            
        }


        private void btnFillCat_Click(object sender, EventArgs e)
        {
            cats = CatManager.Fill(cats);

            dgvCat.AutoGenerateColumns = true;
            dgvCat.DataSource = cats;
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            try
            {
                CatManager.SaveXML(cats);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadCat_Click(object sender, EventArgs e)
        {
            try
            {
                CatManager.LoadXML(cats);
                dgvCat.AutoGenerateColumns = true;
                dgvCat.DataSource = cats;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearCats_Click(object sender, EventArgs e)
        {
            dgvCat.DataSource = null;
            cats = new List<Cat>();

        }


       
    }
}
