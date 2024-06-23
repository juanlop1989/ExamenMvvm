using Examen_Mvvm.ViewModels;

namespace ExamenMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage
            {
                BindingContext = new QuadraticFormulaViewModel()
            };
        }
    }
}
