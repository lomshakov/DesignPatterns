namespace ChainOfResponsibility
{
    /// <summary>
    /// Абстрактный менеджер. Все унаследованные менеджеры будут отвечать
    /// за закупки в зависимости от общей суммы сделки
    /// </summary>
    abstract class Approver
    {
        protected Approver Supervisor;

        public void SetSupervisor(Approver supervisor)
        {
            Supervisor = supervisor;
        }

        public abstract void ProcessRequest(PurchaseOrder purchase);
    }
}