using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iOS6Compat
{
	public partial class iOS6CompatViewController : UIViewController
	{
		public iOS6CompatViewController () : base ("iOS6CompatViewController", null)
		{
			this.Title = "iOS 6 Compat";
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			if (Util.IsiOS7) {
				EdgesForExtendedLayout = UIRectEdge.None;
			}

			var searchImage = UIImage.FromBundle (Util.GetIcon ("search"));
			if(Util.IsiOS7) {
				searchImage = searchImage.ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal);
				// The image should be always original so no tinting is applied
			}

			var barbutton = new UIBarButtonItem (searchImage,
				UIBarButtonItemStyle.Plain, null);


			NavigationItem.SetRightBarButtonItem (barbutton, true);

			//Entire bar tint to dark gray
			//Items tint red for iOS 7
			if (Util.IsiOS7) {
				NavigationController.NavigationBar.BarTintColor = UIColor.DarkGray;
				NavigationController.NavigationBar.TintColor = UIColor.Red;
			} else {
				NavigationController.NavigationBar.TintColor = UIColor.DarkGray;
			}

			if (Util.IsiOS7) {
				toolbar.BarTintColor = UIColor.DarkGray;
			} else {
				toolbar.TintColor = UIColor.DarkGray;
			}

			if (Util.IsiOS7) {
				button.BackgroundColor = UIColor.DarkGray;
				button.SetTitleColor (UIColor.White, UIControlState.Normal);
			}

		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

