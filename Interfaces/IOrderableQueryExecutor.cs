﻿namespace FirebaseDotNetCore.Interfaces
{
    public interface IOrderableQueryExecutor : IFirebaseQueryExecutor
    {
        IFilterableQueryExecutor OrderByChild(string key);
        IFilterableQueryExecutor OrderByKey();
        IFilterableQueryExecutor OrderByValue();
        IFilterableQueryExecutor OrderByPriority();
    }
}