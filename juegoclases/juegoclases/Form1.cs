namespace juegoclases
{
    public partial class txtNombre1 : Form
    {
        public txtNombre1()
        {
            InitializeComponent();
            AcomodarFormulario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AcomodarFormulario()
        {
            this.Text = "Juego de Personajes";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
        
        
    }
}