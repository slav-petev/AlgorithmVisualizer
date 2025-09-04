namespace AlgorithmVisualizer.Core;

public interface IAlgorithm<TItem>
{
    string Name { get; }
    Task Execute(TItem[] data, IVisualizer<TItem> visualizer, CancellationToken cancellationToken);
}