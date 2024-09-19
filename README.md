# Bypassing WPF Prefix in XAML

To simplify the use of custom controls in XAML without needing to prefix them, I bypassed the standard WPF prefix requirement by adding an AssemblyInfo.cs file in the Properties folder. This allows direct usage of controls from custom namespaces within the XAML without extra namespace declarations.

`AssemblyInfo.cs` Content:

```cs
using System.Windows.Markup;

[assembly: XmlnsDefinition("http://schemas.microsoft.com/winfx/2006/xaml/presentation", "TestLibrary")]
[assembly: XmlnsDefinition("http://schemas.microsoft.com/winfx/2006/xaml/presentation", "TestLibrary.Controls")]
```

This configuration registers the namespaces `TestLibrary` and `TestLibrary.Controls` under the default WPF XML namespace `(http://schemas.microsoft.com/winfx/2006/xaml/presentation)`. As a result, you can reference custom controls directly in your XAML without the need to add a specific prefix.

![Screenshot 2024-09-20 004613](https://github.com/user-attachments/assets/f61c7c12-5cfe-4896-a6d7-1f49ed51167c)
