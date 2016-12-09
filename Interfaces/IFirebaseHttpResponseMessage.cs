﻿using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FirebaseDotNetCore.Interfaces
{
    internal interface IFirebaseHttpResponseMessage : IDisposable
    {
        void EnsureSuccessStatusCode();

        Task<Stream> ReadAsStreamAsync(CancellationToken cancellationToken);

        Task<string> ReadAsStringAsync(CancellationToken cancellationToken);
    }
}