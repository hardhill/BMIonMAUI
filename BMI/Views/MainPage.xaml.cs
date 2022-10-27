using BMI.Models;

namespace BMI.Views;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new BmiViewModel();
	}

	
}

