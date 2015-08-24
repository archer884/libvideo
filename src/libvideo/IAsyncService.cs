﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLibrary
{
    public interface IAsyncService
    {
        Task<Video> GetVideoAsync(string videoUri);
        Task<IEnumerable<Video>> GetAllVideosAsync(string videoUri);
    }
}
