using System;

namespace FirebaseDotNetCore
{
    internal class JsonCacheUpdateEventArgs : EventArgs
    {
        public JsonCacheUpdateEventArgs(FirebasePath path)
        {
            Path = path;
        }

        public FirebasePath Path { get; private set; }
    }
}