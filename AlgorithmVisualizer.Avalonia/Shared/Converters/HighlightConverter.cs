using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace AlgorithmVisualizer.Avalonia.Shared.Converters;

public class HighlightConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return (bool)(value ?? false) ? Brushes.Red : Brushes.Blue;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}