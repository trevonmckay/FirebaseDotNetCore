using FirebaseDotNetCore.Interfaces;

namespace FirebaseDotNetCore
{
    public interface IFirebase : IFirebaseStructure, IFirebaseUpdate, IFirebaseQueryExecutorAny
    {
        IFirebaseApp GetApp();
    }
}