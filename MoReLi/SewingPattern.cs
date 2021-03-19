using System.IO;
using System.Windows;
using System.Windows.Media;

namespace MoReLi
{
    class SewingPattern : DependencyObject
    {
        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
        DependencyProperty.Register("Image", typeof(ImageSource), typeof(SewingPattern), new UIPropertyMetadata(null));

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public static readonly DependencyProperty NameProperty =
        DependencyProperty.Register("Name", typeof(string), typeof(SewingPattern), new PropertyMetadata(""));

        public FileInfo[] Files
        {
            get { return (FileInfo[])GetValue(FilesProperty); }
            set { SetValue(FilesProperty, value); }
        }

        public static readonly DependencyProperty FilesProperty =
        DependencyProperty.Register("Files", typeof(FileInfo[]), typeof(SewingPattern), new UIPropertyMetadata(null));

        public string[] Tags
        {
            get { return (string[])GetValue(TagsProperty); }
            set { SetValue(TagsProperty, value); }
        }

        public static readonly DependencyProperty TagsProperty =
        DependencyProperty.Register("Tags", typeof(string[]), typeof(SewingPattern), new UIPropertyMetadata(null));
    }
}
