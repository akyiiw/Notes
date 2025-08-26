namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");

        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(caminho))
                Edit.Text = File.ReadAllText(caminho);

        }
       
        private void Edit_TextChanged(object sender, TextChangedEventArgs e)
        {
 
        }

        private void Edit_Completed(object sender, EventArgs e)
        {

        }

        private void SalvarBtn_Clicked(object sender, EventArgs e)
        {
            string conteudo = Edit.Text;
            File.WriteAllText(caminho, conteudo);
            DisplayAlert($"O arquivo de nome {Path.GetFileName(caminho)} foi salvo!", $"O arquivo foi salvo com sucesso em {caminho}", "Ok");

        }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {
            Edit.Text = "";
            if (File.Exists(caminho))
            {
                File.Delete(caminho);
                DisplayAlert("Arquivo apagado", "Arquivo apagado com sucesso", "Ok");
            } 
           else
           {
                DisplayAlert("O arquivo não foi encontrado.", "Certifique-se de o arquivo foi criado antes de deletá-lo", "Voltar");
           }
    }
    }

}
