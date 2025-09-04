using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AlgorithmVisualizer.Avalonia.Shared.ObservableObjects;
using AlgorithmVisualizer.Core;

namespace AlgorithmVisualizer.Avalonia.Visualizers;

public class SortingVisualizer(ObservableCollection<BarItem> bars) : IVisualizer<int>
{
    
    
    public async Task Update(int[] data, int[] highlightedIndices, string message)
    {
        for (var i = 0; i < data.Length; i++)
        {
            bars[i].Value = data[i];
            bars[i].Highlighted = highlightedIndices.Contains(i);
        }

        await Task.Delay(100);
    }
}