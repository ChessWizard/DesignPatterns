namespace DesignPatterns.Memento.Blazor.Models.Interfaces
{
    /// <summary>
    /// Ana nesnenin geçmişini tutmaya yarayacak model nesne
    /// </summary>
    public interface ICareTaker<TOriginator> where TOriginator : class
    {
        public TOriginator Originator { get; set; }
    }
}
