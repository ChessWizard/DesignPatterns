namespace DesignPatterns.Memento.Blazor.Models.Interfaces
{
    /// <summary>
    /// Geçmişi tutulan nesnenin işlendiği yer
    /// </summary>
    public interface IMemento<TMemento> where TMemento : class
    {
        public Stack<TMemento> memory { get; set; }

        public void AddMementoToMemory(TMemento memento);
        
        public TMemento GetCurrentMemento();
    }
}
