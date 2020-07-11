﻿using Xamarin.Forms;

namespace SoundCloudClone.Controls
{
    public partial class ItemView : FlexLayout
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(ItemView),
            string.Empty,
            propertyChanged: OnTextChanged
        );

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        private static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as ItemView).TextLabel.Text = (string)newValue;
        }

        public static readonly BindableProperty HasVisibleArrowProperty = BindableProperty.Create(
            nameof(HasVisibleArrow),
            typeof(bool),
            typeof(ItemView),
            false,
            propertyChanged: OnHasVisiableArrowChanged);

        public bool HasVisibleArrow
        {
            get => (bool)GetValue(HasVisibleArrowProperty);
            set => SetValue(HasVisibleArrowProperty, value);
        }

        private static void OnHasVisiableArrowChanged(BindableObject bindable, object oldValue, object newValue)
        {
            (bindable as ItemView).ArrowImage.IsVisible = (bool)newValue;
        }

        public static readonly BindableProperty DetailProperty = BindableProperty.Create(
            nameof(Detail),
            typeof(string),
            typeof(ItemView),
            string.Empty,
            propertyChanged: OnDetailChanged
        );

        public string Detail
        {
            get => (string)GetValue(DetailProperty);
            set => SetValue(DetailProperty, value);
        }

        private static void OnDetailChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((bindable as ItemView).DetailLabel is Label label)
            {
                label.Text = (string)newValue;
                label.IsVisible = !string.IsNullOrWhiteSpace(label.Text);
            }
        }

        public ItemView()
        {
            InitializeComponent();
        }
    }
}
