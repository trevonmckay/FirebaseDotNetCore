using System;
using FirebaseDotNetCore.Messages;

namespace FirebaseDotNetCore.Interfaces
{
    internal class FirebaseEventReceivedEventArgs : EventArgs
    {
        public FirebaseEventReceivedEventArgs(FirebaseMessage message)
        {
            Message = message;
        }

        public FirebaseMessage Message { get; private set; }
    }

    internal interface IFirebaseNetworkConnection : IDisposable
    {
        void Send(FirebaseMessage message);

        event EventHandler<FirebaseEventReceivedEventArgs> Received;

        void Disconnect();
        void Connect();
    }
}