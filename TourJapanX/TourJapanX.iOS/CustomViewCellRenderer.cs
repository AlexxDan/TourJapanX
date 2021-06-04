using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourJapanX.CustomControls;
using TourJapanX.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomViewCellControl)
    , typeof(CustomViewCellRenderer))]
namespace TourJapanX.iOS
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            var view = item as CustomViewCellControl;
            cell.SelectedBackgroundView = new UIView
            {
                BackgroundColor = view.SelectedItemBackgroundColor.ToUIColor(),
            };

            return cell;
        }
    }
}