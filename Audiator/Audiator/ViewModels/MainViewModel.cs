using Audiator.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Audiator.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    #region Private Members

    private readonly IFileExplorer fileExplorer;
    private readonly IAudioPlayer audioPlayer;
    private readonly IAudioScheduler audioScheduler;

    #endregion

    #region Constructor

    public MainViewModel(IFileExplorer fileExplorer, IAudioPlayer audioPlayer, IAudioScheduler audioScheduler)
    {
        this.fileExplorer = fileExplorer;
        this.audioPlayer = audioPlayer;
        this.audioScheduler = audioScheduler;
    }

    public MainViewModel()
    {
        
    }

    #endregion

    #region Properties

    #region Title : string - Title

    [ObservableProperty]
    /// <summary>Title</summary>
    private string? _Title = "Audiator";

    #endregion


    #endregion

    #region Commands

    

    #endregion




}
