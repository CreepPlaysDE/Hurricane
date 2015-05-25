﻿namespace Hurricane.Model.AudioEngine
{
    class LocalFilePlaySource : IPlaySource
    {
        public PlaySourceType Type => PlaySourceType.LocalFile;

        public string Path { get; }

        public LocalFilePlaySource(string path)
        {
            Path = path;
        }
    }
}
