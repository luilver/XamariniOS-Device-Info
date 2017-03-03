using System;
using System.IO;
using System.Xml;
usi

using UIKit;

namespace XamariniOSDeviceInfo.iOS
{
	public partial class ViewController : UIViewController
	{
		

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			lblName.Text = UIDevice.CurrentDevice.Name;
			lblVersion.Text = UIDevice.CurrentDevice.SystemVersion;
			lblDeviceName.Text = UIDevice.CurrentDevice.Model;
			lblUDID.Text = UIDevice.CurrentDevice.IdentifierForVendor.ToString();

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
