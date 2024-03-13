//forma de organizar o projeto
namespace WinFormsApp
{ //classe
    public partial class Form1 : Form
    {
        //construtor
        public Form1()
        {
            //metodo inicializa os componentes
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //evento de clique do botao novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            //exibir uma mensagem com o texto formado
            MessageBox.Show("Clicou no botão Novo");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no botão Editar");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no botão Salvar");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no botão Excluir");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no botão Imprimir");
        }
    }
}
