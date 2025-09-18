using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryChalimondGUI
{
    public partial class frmBotonera : Form
    {

        string name;
        string[] names = new string[3];
        int counter = 0;
        int index = 0;
        const int minNumber = 0;
        public frmBotonera()
        {
            InitializeComponent();
        }

        private void updateForm(bool isIncreasing)
        {



            if (isIncreasing)
            {
                index++;

                if (index >= names.Length - 1)
                {
                    btnNext.Enabled = false;
                    btnLastItem.Enabled = false;
                    btnPrev.Enabled = true;
                    index = names.Length - 1;
                }
                else
                {
                    btnPrev.Enabled = true;
                    btnFirstItem.Enabled = true;


                }
                updateLabels();
            }
            else
            {
                index--;

                if (index <= minNumber)
                {
                    index = minNumber;
                    btnPrev.Enabled = false;
                    btnFirstItem.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                    btnLastItem.Enabled = true;
                }
                updateLabels();

            }
        }

        //pasar true para ir al primero, false para el segundo
        private void jumpTo(bool isFirst)
        {

            if (isFirst)
            {
                index = minNumber;
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
                btnFirstItem.Enabled = false;

                btnLastItem.Enabled = true;
            }
            else
            {
                index = names.Length - 1;
                btnNext.Enabled = false;
                btnPrev.Enabled = true;
                btnFirstItem.Enabled = true;
                btnLastItem.Enabled = false;
            }
            updateLabels();
        }

        private void updateLabels()
        {
            lblName.Text = names[index];
            lblIndex.Text = $"Indice: {index}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            updateForm(true);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (counter > 2)
            {
                MessageBox.Show("No se pueden agregar mas nombres");
                btnSubmit.Enabled = false;
                return;
            }
            else
            {
                name = txtName.Text;
                names[counter] = name;
                lblName.Text = names[index];
                lblIndex.Text = $"Indice: {index}";
                counter++;
                txtName.Clear();
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            updateForm(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmControles controlesForm = new frmControles();
            controlesForm.Show();
        }

        private void btnFirstItem_Click(object sender, EventArgs e)
        {
            jumpTo(true);
        }

        private void btnLastItem_Click(object sender, EventArgs e)
        {
            jumpTo(false);
        }
    }
}
