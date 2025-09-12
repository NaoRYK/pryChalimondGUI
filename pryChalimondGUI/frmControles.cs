namespace pryChalimondGUI
{
    public partial class frmControles : Form
    {

        frmBotonera controlesForm = new frmBotonera();



        public frmControles()
        {
            InitializeComponent();
        }



        private void btnBotonera_Click(object sender, EventArgs e)
        {
            controlesForm.Show();
            this.Hide();
        }
    }
}
