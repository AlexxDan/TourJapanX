﻿using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TourJapanX.CustomControls;
using TourJapanX.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomViewCellControl)
    , typeof(CustomViewCellRenderer))]
namespace TourJapanX.Droid
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        private Android.Views.View _cellCore;
        private Drawable _unselectedBackground;
        private bool _selected;

        protected override Android.Views.View GetCellCore(Cell item,
                                                          Android.Views.View convertView,
                                                          ViewGroup parent,
                                                          Context context)
        {
            _cellCore = base.GetCellCore(item, convertView, parent, context);

            _selected = false;
            _unselectedBackground = _cellCore.Background;

            return _cellCore;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnCellPropertyChanged(sender, args);

            if (args.PropertyName == "IsSelected")
            {
                _selected = !_selected;

                if (_selected)
                {
                    var extendedViewCell = sender as CustomViewCellControl;
                    _cellCore.SetBackgroundColor(extendedViewCell.SelectedItemBackgroundColor.ToAndroid());
                }
                else
                {
                    _cellCore.SetBackground(_unselectedBackground);
                }
            }
        }
    }
}