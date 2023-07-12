using System;

namespace Audiator.Services.Interfaces;

public interface IAudioScheduler
{
    void Schedule(string filePath, DateTime playDateTime);
}