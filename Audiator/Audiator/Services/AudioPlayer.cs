using Audiator.Services.Interfaces;
using NAudio.Wave;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audiator.Services
{
    public class AudioPlayer : IAudioPlayer
    {
        public void Play(string filePath)
        {
            using (var audioFile = new AudioFileReader(filePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
            }
        }
    }
}
