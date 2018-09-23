using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace UiComponents
{
    public class LoadingDecorator : ContentControl
    {
        public static readonly DependencyProperty IsContentLoadingProperty = DependencyProperty.Register(
            "IsContentLoading", typeof(bool), typeof(LoadingDecorator),
            new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public static readonly DependencyProperty AnimationImageProperty = DependencyProperty.Register(
            "AnimationImage", typeof(ImageSource), typeof(LoadingDecorator), 
            new FrameworkPropertyMetadata(null,FrameworkPropertyMetadataOptions.AffectsArrange| FrameworkPropertyMetadataOptions.AffectsMeasure));

        public ImageSource AnimationImage
        {
            get { return (ImageSource) GetValue(AnimationImageProperty); }
            set { SetValue(AnimationImageProperty, value); }
        }
        public bool IsContentLoading
        {
            get { return (bool)GetValue(IsContentLoadingProperty); }
            set { SetValue(IsContentLoadingProperty, value); }
        }
    }
}
