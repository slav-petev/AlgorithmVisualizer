namespace AlgorithmVisualizer.Avalonia.Shared.ObservableObjects;

public class BarItem : ObservableObject
{
    private bool _highlighted;
    public bool Highlighted
    {
        get => _highlighted;
        set => SetProperty(ref _highlighted, value);
    }

    private int _value;
    public int Value
    {
        get => _value;
        set => SetProperty(ref _value, value);
    }
}