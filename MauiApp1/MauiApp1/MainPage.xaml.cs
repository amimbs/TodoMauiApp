﻿using MauiApp1.ViewModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		
	}

	//private void OnCounterClicked(object sender, EventArgs e)
	//{
	//	count++;

	//	if (count == 1)
	//		CounterBtn.Text = $"Clicked {count} time";
	//	else
	//		CounterBtn.Text = $"Clicked {count} times";

	//	SemanticScreenReader.Announce(CounterBtn.Text);
	//}

 //   private void HelloWorld_Clicked(object sender, EventArgs e)
 //   {
	//	DisplayAlert("Helo", "World", "Yup");
 //   }
}

