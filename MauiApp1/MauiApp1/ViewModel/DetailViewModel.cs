
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModel;
    [QueryProperty("Text", "Text")]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;
}
