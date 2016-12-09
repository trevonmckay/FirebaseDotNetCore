using System;

namespace FirebaseDotNetCore.Interfaces
{
    public interface IFirebaseStructure
    {
        IFirebase Child(string childPath);
        IFirebase Parent();
        IFirebase Root();
        string Key { get; }
        Uri AbsoluteUri { get; }
    }
}