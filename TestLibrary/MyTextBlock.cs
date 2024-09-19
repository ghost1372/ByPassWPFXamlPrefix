using System.Windows.Controls;

namespace TestLibrary;

public class MyTextBlock : TextBlock
{
    public MyTextBlock()
    {
        Text = "Hello, World!";
        Background = System.Windows.Media.Brushes.LightBlue;
    }
}
