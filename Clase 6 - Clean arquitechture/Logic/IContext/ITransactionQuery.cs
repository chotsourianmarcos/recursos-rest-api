namespace Logic.IContext
{
    public interface ITransactionQuery
    {
        void BeginTransaction();
        string CreateTransactionSavepoint(string savePoint);
        void RollbackToSavepoint(string savePoint);
        void CommitTransaction();
        void RollbackTransaction();
        void ConfirmChanges();
    }
}