namespace Tasks.Views;

public partial class TaskPage : ContentPage
{
	public TaskPage()
	{
		InitializeComponent();
	}

    private async void OnAddStep(object sender, EventArgs e)
    {
       var stepName = await DisplayPromptAsync("Etapa", "Digite o nome da subtarefa: ", "Adicionar", "Cancelar");
    }

    private void OnCloseModal(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private void OnSaveData(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}