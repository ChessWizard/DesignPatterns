namespace DesignPatterns.Memento.Blazor.Models.Interfaces
{
    /// <summary>
    /// Geçmişi tutulan nesnenin işlendiği yer
    /// </summary>
    public interface IMemento<TMemento> where TMemento : class
    {
        public void AddMementoToMemory(TMemento memento);
        
        public TMemento GetCurrentMemento();
    }
}
