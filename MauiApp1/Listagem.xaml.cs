namespace MauiApp1;

public partial class Listagem : ContentPage
{

	public Listagem()
	{
		InitializeComponent();

		Pessoa p1 = new Pessoa();
		p1.nome = "Gabriel";
		p1.idade = 15;

        Pessoa p2 = new Pessoa();
        p2.idade = 45;
        p2.nome = "Gustavo";

        Pessoa p3 = new Pessoa();
        p3.nome = "Ariel";
        p3.idade = 51;

        Pessoa.lista.Add(p1);
        Pessoa.lista.Add(p2);
        Pessoa.lista.Add(p3);

        Lista.ItemsSource = Pessoa.lista;
    }


    // Esse código "override OnAppearing" é para quando entramos na página "Listagem", ele atualize de forma automatica 
    protected override void OnAppearing()
    {
        base.OnAppearing();

        Lista.ItemsSource = null;
        Lista.ItemsSource = Pessoa.lista;
    }

}