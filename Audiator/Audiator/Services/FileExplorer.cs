using Audiator.Services.Interfaces;
using System.IO;

namespace Audiator.Services;

public class FileExplorer : IFileExplorer
{
    public string[] GetAudioFiles()
    {
        string audioFolderPath = "D:\\Torrents\\Buena Vista Social Club - Buena Vista Social Club (1997, 2021, World Circuit) [LP 24-192]";
        return Directory.GetFiles(audioFolderPath, "*.flac");
    }
}