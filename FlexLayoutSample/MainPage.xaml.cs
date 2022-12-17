namespace FlexLayoutSample
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {            
            InitializeComponent();
            Items = new() { "MAUI", "Xamarin Forms" };
            BindingContext = this;

        }

        public List<string> Items { get; }


    }
}