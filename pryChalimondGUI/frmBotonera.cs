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
        int maxNumber = 3,minNumber= 0;
        public frmBotonera()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(index >= maxNumber  )
            {
                MessageBox.Show("No se puede realizar esa accion");

                return;
            }
            else
            {

                lblIndex.Text = $"Indice: {index}";

                lblName.Text = names[index];
                if (index >= maxNumber)
                {
                    index = maxNumber;
                }
                else
                {
                    index++;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(counter > 2)
            {
                MessageBox.Show("No se pueden agregar mas nombres");
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
            if (index < minNumber)
            {

                MessageBox.Show("No se puede realizar esa accion");
                return;
            }
            else
            {
                if(index <= minNumber)
                {
                    index= minNumber;
                }
                else
                {
                    index--;
                }
                lblIndex.Text = $"Indice: {index}";

                lblName.Text = names[index];

            }
        }
    }
}
