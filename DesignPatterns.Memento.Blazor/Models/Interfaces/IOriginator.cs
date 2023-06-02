namespace DesignPatterns.Memento.Blazor.Models.Interfaces
{
    /// <summary>
    /// History'si tutulup geçmişine dönülecek ana nesne
    /// </summary>
    public interface IOriginator<TMomento> where TMomento : class
    {
        public TMomento CreateMemento();

        public void UndoChanges(TMomento mementoModel);
    }
}
