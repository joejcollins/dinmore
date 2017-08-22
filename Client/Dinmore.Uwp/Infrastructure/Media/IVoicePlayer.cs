﻿using System.Collections.Generic;
using Dinmore.Uwp.Models;

namespace Dinmore.Uwp.Infrastructure.Media
{
    internal interface IVoicePlayer
    {
        void Dispose();
        bool IsCurrentlyPlaying { get; set; }
        void Play(DetectionState currentState);
        void PlayIntroduction(PlayListGroup playlistGroup);
        void PlayWav(List<PlayListItem> list);
        void Stop();
    }
}