using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin.Forms.Samples.Controls
{
    public class NavigationTopBar : Grid
    {
        public NavigationTopBar()
        {
            BackgroundColor = Color.Transparent;
            ColumnSpacing = 0;

            this.RowDefinitions.Add(new RowDefinition() { Height = Device.OnPlatform(44, 56, 44) });
            this.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            this.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Auto) });
            this.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });

            ///<summary>
            /// Top bar Left Button
            /// </summary>
            var leftImage = new Image()
            {
                BindingContext = this,
                VerticalOptions = LayoutOptions.Center
            };
            leftImage.SetBinding(Image.SourceProperty, LeftImageProperty.PropertyName);

            var leftLabel = new Label()
            {
                BindingContext = this,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.White,
                FontSize = 13
            };
            leftLabel.SetBinding(Label.TextProperty, LeftLabelProperty.PropertyName);

            var leftStack = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 8
            };
            leftStack.Children.Add(leftImage);
            leftStack.Children.Add(leftLabel);

            var leftClickableContent = new ClickableContentView()
            {
                BindingContext = this,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(5, 10, 5, 10)
            };
            leftClickableContent.SetBinding(ClickableContentView.CommandProperty, LeftCommandProperty.PropertyName);
            leftClickableContent.Content = leftStack;

            ///<summary>
            /// Top bar Title
            /// </summary>
            var title = new Label()
            {
                BindingContext = this,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                LineBreakMode = LineBreakMode.TailTruncation
            };

            title.SetBinding(Label.TextProperty, TitleLabelProperty.PropertyName);
            title.SetDynamicResource(Label.TextColorProperty, "NavigationBarTitleColor");
            title.SetDynamicResource(Label.FontSizeProperty, "FontSize_16");

            ///<summary>
            /// Top bar Right Button
            /// </summary>
            var rightImage = new Image()
            {
                BindingContext = this,
                VerticalOptions = LayoutOptions.Center
            };
            rightImage.SetBinding(Image.SourceProperty, RightImageProperty.PropertyName);

            var rightLabel = new Label()
            {
                BindingContext = this,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.White
            };
            rightLabel.SetBinding(Label.TextProperty, RightLabelProperty.PropertyName);

            var rightStack = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 8
            };
            rightStack.Children.Add(rightLabel);
            rightStack.Children.Add(rightImage);

            var rightClickableContent = new ClickableContentView()
            {
                BindingContext = this,
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(5, 10, 16, 10)
            };
            rightClickableContent.SetBinding(ClickableContentView.CommandProperty, RightCommandProperty.PropertyName);
            rightClickableContent.Content = rightStack;

            this.Children.Add(leftClickableContent, 0, 0);
            this.Children.Add(title, 1, 0);
            this.Children.Add(rightClickableContent, 2, 0);
        }

        ///<summary>
        /// Top bar Left Button bindings
        /// </summary>
        public static readonly BindableProperty LeftImageProperty =
            BindableProperty.Create(nameof(LeftImage), typeof(ImageSource), typeof(NavigationTopBar), default(ImageSource));

        public ImageSource LeftImage
        {
            get { return (ImageSource)GetValue(LeftImageProperty); }
            set { SetValue(LeftImageProperty, value); }
        }

        public static readonly BindableProperty LeftLabelProperty =
            BindableProperty.Create(nameof(LeftLabel), typeof(string), typeof(NavigationTopBar), default(string));

        public string LeftLabel
        {
            get { return (string)GetValue(LeftLabelProperty); }
            set { SetValue(LeftLabelProperty, value); }
        }

        public static readonly BindableProperty LeftCommandProperty =
            BindableProperty.Create(nameof(LeftCommand), typeof(ICommand), typeof(NavigationTopBar), default(ICommand));

        public ICommand LeftCommand
        {
            get
            {
                return (ICommand)GetValue(LeftCommandProperty);
            }
            set
            {
                SetValue(LeftCommandProperty, value);
            }
        }

        ///<summary>
        /// Top bar Title binding
        /// </summary>
        public static readonly BindableProperty TitleLabelProperty =
            BindableProperty.Create(nameof(TitleLabel), typeof(string), typeof(NavigationTopBar), default(string));

        public string TitleLabel
        {
            get { return (string)GetValue(TitleLabelProperty); }
            set { SetValue(TitleLabelProperty, value); }
        }

        ///<summary>
        /// Top bar Right Button bindings
        /// </summary>
        public static readonly BindableProperty RightImageProperty =
            BindableProperty.Create(nameof(RightImage), typeof(ImageSource), typeof(NavigationTopBar), default(ImageSource));

        public ImageSource RightImage
        {
            get { return (ImageSource)GetValue(RightImageProperty); }
            set { SetValue(RightImageProperty, value); }
        }

        public static readonly BindableProperty RightLabelProperty =
            BindableProperty.Create(nameof(RightLabel), typeof(string), typeof(NavigationTopBar), default(string));

        public string RightLabel
        {
            get { return (string)GetValue(RightLabelProperty); }
            set { SetValue(RightLabelProperty, value); }
        }

        public static readonly BindableProperty RightCommandProperty =
            BindableProperty.Create(nameof(RightCommand), typeof(ICommand), typeof(NavigationTopBar), default(ICommand));

        public ICommand RightCommand
        {
            get
            {
                return (ICommand)GetValue(RightCommandProperty);
            }
            set
            {
                SetValue(RightCommandProperty, value);
            }
        }
    }
}
