using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace FirebaseDotNetCore.Interfaces
{
    internal interface IFirebaseHttpClient : IDisposable
    {
        Uri BaseAddress { get; }

        Task<IFirebaseHttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            HttpCompletionOption httpCompletionOption,
            CancellationToken cancellationToken);
    }
}