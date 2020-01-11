using Foundation;
using System;
using UIKit;

namespace MPGCalculator
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        // This method is attached as an even handler to the calculate button
        partial void CalculateButton_TouchUpInside(UIButton sender)
        {
            try
            {
                // Get the two user inputs
                double miles = Double.Parse(milesTextField.Text);
                double gallons = Double.Parse(gallonsTextField.Text);

                if (gallons != 0) // Gallons cannot be zero
                    // Calculate the mpg and display it
                    mpgLabel.Text = Calculator.Mpg(miles, gallons).ToString() + " mpg";
            }
            catch
            {
                // If there is an error then do nothing
            }
        }
    }
}
