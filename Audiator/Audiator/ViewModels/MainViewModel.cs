using Audiator.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

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

    #region ListOfAudioFiles : string[] - List of Audio FIles

    [ObservableProperty]
    /// <summary>List of Audio FIles</summary>
    private string[] _ListOfAudioFiles;

    #endregion

    #region SelectedAudioFile : string - Selected Audio FIle

    [ObservableProperty]
    /// <summary>Selected Audio FIle</summary>
    private string? _SelectedAudioFile;

    #endregion

    #endregion

    #region Commands

    #region RelayCommand ScanFolderCommand - Scan Folder Command

    /// <summary>Scan Folder Command</summary>
    [RelayCommand(CanExecute = nameof(CanScanFolder))]
    private void ScanFolder()
    {
        ListOfAudioFiles = fileExplorer.GetAudioFiles(@"C:\Users\David\Downloads");
    }

    /// <summary>Scan Folder Command</summary>
    private bool CanScanFolder() => true;

    #endregion

    #region RelayCommand PlaySelectedAudioFileCommand - Play selected audio

    /// <summary>Play selected audio</summary>
    [RelayCommand(CanExecute = nameof(CanPlaySelectedAudioFile))]
    private void PlaySelectedAudioFile()
    {
        audioPlayer.Play(SelectedAudioFile);
    }

    /// <summary>Play selected audio</summary>
    private bool CanPlaySelectedAudioFile() => true;

    #endregion




    #endregion




}
