using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Windows.Input;
using AlgorithmVisualizer.Algorithms.Sorting;
using AlgorithmVisualizer.Avalonia.Shared;
using AlgorithmVisualizer.Avalonia.Shared.Commands;
using AlgorithmVisualizer.Avalonia.Shared.ObservableObjects;
using AlgorithmVisualizer.Avalonia.Visualizers;
using AlgorithmVisualizer.Core;

namespace AlgorithmVisualizer.Avalonia.ViewModels;

public class MainViewModel : ObservableObject
{
    private CancellationTokenSource _cts;
    
    public ObservableCollection<BarItem> Bars { get; } = [];
    public ObservableCollection<IAlgorithm<int>> Algorithms { get; } = [];
    public IAlgorithm<int> SelectedAlgorithm { get; set; }
    public ICommand StartCommand { get; private set; }
    
    public MainViewModel()
    {
        var rand = new Random();
        for (var i = 0; i < 50; i++)
        {
            Bars.Add(new BarItem
            {
                Value = rand.Next(10, 300),
            });
        }
        Algorithms.Add(new BubbleSort());
        StartCommand = new RelayCommand(async void (_) =>
        {
            _cts = new CancellationTokenSource();
            if (SelectedAlgorithm is null)
            {
                return;
            }
            
            var visualizer = new SortingVisualizer(Bars);
            var array = Bars.Select(bar => bar.Value).ToArray();
            await SelectedAlgorithm.Execute(array, visualizer, _cts.Token);
        });
    }
}