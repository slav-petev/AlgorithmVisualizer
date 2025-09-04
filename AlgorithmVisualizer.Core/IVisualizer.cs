namespace AlgorithmVisualizer.Core;

public interface IVisualizer<in TItem>
{
    Task Update(TItem[] data, int[] highlightedIndices, string message);
}