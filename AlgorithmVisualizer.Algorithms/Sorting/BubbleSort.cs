using AlgorithmVisualizer.Core;

namespace AlgorithmVisualizer.Algorithms.Sorting;

public class BubbleSort : ISortingAlgorithm<int>
{
    public string Name => "Bubble Sort";
    
    public async Task Execute(int[] data, IVisualizer<int> visualizer, CancellationToken cancellationToken)
    {
        var n = data.Length;
        for (var i = 0; i < n - 1; i++)
        {
            for (var j = 0; j < n - i - 1; j++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }

                if (data[j] > data[j + 1])
                {
                    (data[j], data[j + 1]) = (data[j + 1], data[j]);
                }

                await visualizer.Update(data, [j, j + 1],
                    $"Comparing indices {j} and {j + 1}");
            }
        }
    }
}