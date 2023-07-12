using CommunityToolkit.Mvvm.ComponentModel;

namespace Audiator.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    #region Title : string - Title

    [ObservableProperty]
    /// <summary>Title</summary>
    private string? _Title = "Audiator";

    #endregion
}
