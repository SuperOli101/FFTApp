using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows; //WindowsBase.dll and PresentationCore.dll


 //<TabControl prism:RegionManager.RegionName="{x:Static rn:RegionNames.ContentRegionTab}" Width="Auto" Height="Auto" HorizontalAlignment="Stretch"  VerticalAlignment="Stretch"
 //                       behavior:ReadOnlyProperty1ToModelBindingBehavior.ReadOnlyDependencyProperty="{Binding ActualWidth, RelativeSource={RelativeSource Self}}"
 //                       behavior:ReadOnlyProperty1ToModelBindingBehavior.ModelProperty="{Binding WidthTab}"
 //                       behavior:ReadOnlyProperty2ToModelBindingBehavior.ReadOnlyDependencyProperty="{Binding ActualHeight, RelativeSource={RelativeSource Self}}"
 //                       behavior:ReadOnlyProperty2ToModelBindingBehavior.ModelProperty="{Binding HeightTab}"      
 //                       >


namespace FFTApp.UI.Infrastructure.Behaviors
{
    public class ReadOnlyProperty1ToModelBindingBehavior
    {
        public static readonly DependencyProperty ReadOnlyDependencyPropertyProperty = DependencyProperty.RegisterAttached(
                                                        "ReadOnlyDependencyProperty",
                                                        typeof(object),
                                                        typeof(ReadOnlyProperty1ToModelBindingBehavior),
                                                        new PropertyMetadata(OnReadOnlyDependencyPropertyPropertyChanged));

        public static void SetReadOnlyDependencyProperty(DependencyObject element, object value)
        {
            element.SetValue(ReadOnlyDependencyPropertyProperty, value);
        }

        public static object GetReadOnlyDependencyProperty(DependencyObject element)
        {
            return element.GetValue(ReadOnlyDependencyPropertyProperty);
        }

        private static void OnReadOnlyDependencyPropertyPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            SetModelProperty(obj, e.NewValue);
        }

        public static readonly DependencyProperty ModelPropertyProperty = DependencyProperty.RegisterAttached(
                                                         "ModelProperty",
                                                         typeof(object),
                                                         typeof(ReadOnlyProperty1ToModelBindingBehavior),
                                                         new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public static void SetModelProperty(DependencyObject element, object value)
        {
            element.SetValue(ModelPropertyProperty, value);
        }

        public static object GetModelProperty(DependencyObject element)
        {
            return element.GetValue(ModelPropertyProperty);
        }
    }

    public class ReadOnlyProperty2ToModelBindingBehavior
    {
        public static readonly DependencyProperty ReadOnlyDependencyPropertyProperty = DependencyProperty.RegisterAttached(
                                                        "ReadOnlyDependencyProperty",
                                                        typeof(object),
                                                        typeof(ReadOnlyProperty2ToModelBindingBehavior),
                                                        new PropertyMetadata(OnReadOnlyDependencyPropertyPropertyChanged));

        public static void SetReadOnlyDependencyProperty(DependencyObject element, object value)
        {
            element.SetValue(ReadOnlyDependencyPropertyProperty, value);
        }

        public static object GetReadOnlyDependencyProperty(DependencyObject element)
        {
            return element.GetValue(ReadOnlyDependencyPropertyProperty);
        }

        private static void OnReadOnlyDependencyPropertyPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            SetModelProperty(obj, e.NewValue);
        }

        public static readonly DependencyProperty ModelPropertyProperty = DependencyProperty.RegisterAttached(
                                                         "ModelProperty",
                                                         typeof(object),
                                                         typeof(ReadOnlyProperty2ToModelBindingBehavior),
                                                         new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public static void SetModelProperty(DependencyObject element, object value)
        {
            element.SetValue(ModelPropertyProperty, value);
        }

        public static object GetModelProperty(DependencyObject element)
        {
            return element.GetValue(ModelPropertyProperty);
        }
    }
}
