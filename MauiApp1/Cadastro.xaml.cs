namespace MauiApp1;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();
	}

    private void Salvar_Clicked(object sender, EventArgs e)
    {
		string nome = EntryNome.Text;
		int idade = int.Parse( EntryIdade.Text );

		DisplayAlert("Sucesso!", "Usuário cadastrado com sucesso.", "OK");

		// Aqui estamos criando uma nova pessoa, e logo em seguida estamos pegando os dados que foram colocados nos campos de idade e senha
		Pessoa p = new Pessoa();
		p.nome = nome;
		p.idade = idade;

		// Aqui estamos adicionando na lista para ver
		Pessoa.lista.Add(p);

		// Esse comando é para quando você cria o usuario ele direciona direto para a página de listagem
		Shell.Current.GoToAsync("//Listagem");

    }
}