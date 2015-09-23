﻿namespace RadialMenuControl.Components
{
    using System;
    using System.Collections.ObjectModel;
    using Windows.UI;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public partial class RadialMenuButton : Button
    {
        // Label
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(RadialMenuButton), null);

        public static readonly DependencyProperty LabelSizeProperty =
            DependencyProperty.Register("LabelSize", typeof(int?), typeof(RadialMenuButton), null);

        public static readonly DependencyProperty HideLabelProperty =
            DependencyProperty.Register("HideLabel", typeof(bool), typeof(RadialMenuButton), null);

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(string), typeof(RadialMenuButton), null);

        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.Register("IconSize", typeof(int?), typeof(RadialMenuButton), null);

        public string Label
        {
            get { return (string)GetValue(LabelProperty) ?? ""; }
            set { SetValue(LabelProperty, value); }
        }
        public int? LabelSize
        {
            get { return (int?)GetValue(LabelSizeProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public bool HideLabel
        {
            get { return (bool)GetValue(HideLabelProperty); }
            set { SetValue(HideLabelProperty, value); }
        }

        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public int? IconSize
        {
            get { return (int?)GetValue(IconSizeProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Inner Arc Colors
        public static readonly DependencyProperty InnerNormalColorProperty =
            DependencyProperty.Register("InnerNormalColor", typeof(Color?), typeof(RadialMenuButton), null);

        public static readonly DependencyProperty InnerHoverColorProperty =
            DependencyProperty.Register("InnerHoverColor", typeof(Color?), typeof(RadialMenuButton), null);

        public static readonly DependencyProperty InnerTappedColorProperty =
            DependencyProperty.Register("InnerTappedColor", typeof(Color?), typeof(RadialMenuButton), null);

        public Color? InnerHoverColor
        {
            get { return (Color?)GetValue(InnerHoverColorProperty); }
            set { SetValue(InnerHoverColorProperty, value); }
        }

        public Color? InnerNormalColor
        {
            get { return (Color?)GetValue(InnerNormalColorProperty); }
            set { SetValue(InnerNormalColorProperty, value); }
        }

        public Color? InnerTappedColor
        {
            get { return (Color?)GetValue(InnerTappedColorProperty); }
            set { SetValue(InnerTappedColorProperty, value); }
        }

        // Outer Arc Colors
        public static readonly DependencyProperty OuterNormalColorProperty =
            DependencyProperty.Register("OuterNormalColor", typeof(Color?), typeof(RadialMenuButton), null);

        public static readonly DependencyProperty OuterHoverColorProperty =
            DependencyProperty.Register("OuterHoverColor", typeof(Color?), typeof(RadialMenuButton), null);

        public static readonly DependencyProperty OuterTappedColorProperty =
            DependencyProperty.Register("OuterTappedColor", typeof(Color?), typeof(RadialMenuButton), null);

        public Color? OuterHoverColor
        {
            get { return (Color?)GetValue(OuterHoverColorProperty); }
            set { SetValue(OuterHoverColorProperty, value); }
        }

        public Color? OuterNormalColor
        {
            get { return (Color?)GetValue(OuterNormalColorProperty); }
            set { SetValue(OuterNormalColorProperty, value); }
        }

        public Color? OuterTappedColor
        {
            get { return (Color?)GetValue(OuterTappedColorProperty); }
            set { SetValue(OuterTappedColorProperty, value); }
        }

        public RadialMenuButton()
        {
            InitializeComponent();
        }
    }
}