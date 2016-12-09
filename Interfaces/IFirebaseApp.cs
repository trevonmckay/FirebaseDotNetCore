using System;

namespace FirebaseDotNetCore
{
    public interface IFirebaseApp : IDisposable
    {
        void GoOnline();
        void GoOffline();
        IFirebase Child(string path);
    }
}