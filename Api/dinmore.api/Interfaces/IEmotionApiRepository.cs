﻿using dinmore.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinmore.api.Interfaces
{
    public interface IEmotionApiRepository
    {
        Task<IEnumerable<FaceWithEmotion>> GetFacesWithEmotion(byte[] image);
    }
}
