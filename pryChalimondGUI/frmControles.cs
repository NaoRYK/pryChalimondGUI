namespace pryChalimondGUI
{
    public partial class frmControles : Form
    {




        public frmControles()
        {
            InitializeComponent();
        }



        private void btnBotonera_Click(object sender, EventArgs e)
        {
            frmBotonera botonera = new frmBotonera(this); // le paso referencia
            botonera.Show();
            this.Hide();
        }
        public void RefreshList(string[] names)
        {
            lstNames.Items.Clear();
            foreach (string name in names)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    lstNames.Items.Add(name);
                }
            }
            if (lstNames.Items.Count > 0) {
                lstNames.SelectedIndex = 0;
            }
        }
        private void frmControles_Load(object sender, EventArgs e)
        {
                lstNames.Items.Add("Todavia no hay elementos, debe cargarlos ");
                lstNames.SelectedIndex = 0;

        }
    }
}
