using FirstMauiAPP.ViewModel;

namespace FirstMauiAPP;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

	}
    //int count = 0;

    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //	count++;

    //	if (count == 1)
    //		CounterBtn.Text = $"Clicked {count} time";
    //	else
    //		CounterBtn.Text = $"Clicked {count} times";

    //	SemanticScreenReader.Announce(CounterBtn.Text);
    //}
}

