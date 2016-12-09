namespace FirebaseDotNetCore.Interfaces
{
    public interface IFirebaseReadonlyQuery
    {
        void Off();
        IFirebase Ref();
    }
}