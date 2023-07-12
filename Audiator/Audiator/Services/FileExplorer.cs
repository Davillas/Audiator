using Audiator.Services.Interfaces;
using System.IO;

namespace Audiator.Services;

public class FileExplorer : IFileExplorer
{
    public string[] GetAudioFiles(string audioFolderPath)
    {
        return Directory.GetFiles(audioFolderPath, "*.mp3");
    }
}