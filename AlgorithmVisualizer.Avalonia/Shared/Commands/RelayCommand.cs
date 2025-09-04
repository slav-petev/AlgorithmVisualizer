using System;
using System.Windows.Input;

namespace AlgorithmVisualizer.Avalonia.Shared.Commands;

public class RelayCommand(Action<object?>? execute) : ICommand
{
    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter) => execute?.Invoke(parameter);
}