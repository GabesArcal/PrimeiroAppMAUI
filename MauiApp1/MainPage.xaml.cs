namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int cont = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Entrar_Clicked(object sender, EventArgs e)
        {
            string usuario = InputUsuario.Text;
            string senha = InputSenha.Text;

            //Como aqui é C# é preciso espeficar se é número com int ou texto como string;

            if ( usuario == "Gabriel" && senha == "123")
            {
                // Nesse DisplayAlert precisa de "titulo", "corpo", e "botão"
                DisplayAlert("Sucesso", "Você foi autenticado com sucesso", "Concluir");
            }
            else
            {
                DisplayAlert("Erro", "Usuario ou senha incorreto", "Fechar");
            }
        }
    }

}
