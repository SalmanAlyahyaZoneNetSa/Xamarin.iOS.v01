using System;
using Xamarin.iOS.DGActivityIndicatorViewBinding;
using UIKit;
using Foundation;
using System.CodeDom.Compiler;
using CoreGraphics;
using System.Threading.Tasks;
using Bitaqati.Models;
using Bitaqati.Services;

namespace Bitaqati.iOS
{
    public partial class ViewController : UIViewController
    {
        //#region Private Variables
        //private bool imageHighlighted = false;
        //private bool touchStartedInside;
        //#endregion

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

        }

        ACProgressView loadPop;
        private void showActivityIndicator()
        {
                inputContainer.Hidden = true;
       
            var bounds = inputContainer.Frame;

            // show the loading overlay on the UI thread using the correct orientation sizing
            loadPop = new ACProgressView(bounds); // using field from step 2
            View.Add(loadPop);


        }
    

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);
            UITouch touch = touches.AnyObject as UITouch;
            if (touch != null)
            {
                loadPop.Hide();
                inputContainer.Hidden = false;
                PerformSegue("login", this);
                //code here to handle touch
              //  PresentViewController(View, animated: true, completionHandler: PresentationFinished);
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void ConnectButton_TouchUpInside(UIButton sender)   //CONNECT Button
        {
            // throw new NotImplementedException();
            showActivityIndicator();
            CheckService("");
        }

        partial void QrButton_TouchUpInside(UIButton sender)    //QR Button
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task CheckService(string url = null)
        {
            //// exit if we don't have a url
            //if (string.IsNullOrWhiteSpace(uiServiceURL.Text) && string.IsNullOrWhiteSpace(url))
            //    return;

            //// show Progress
            //uiConnectProgressText.Text = Resources.GetString(Resource.String.ServiceChecking);
            //uiConnectProgress.Visibility = ViewStates.Visible;
            //uiServiceInfo.Visibility = ViewStates.Gone;
            //uiConnectProgressCloud.SetImageDrawable(GetDrawable(Resource.Drawable.cloud_connect));

            //if (string.IsNullOrWhiteSpace(url))
            //{
            //    url = uiServiceURL.Text.Trim();
            //}
             url = "http://212.118.119.107:2020/BitaqatiWebAPI/Echo";
            Console.WriteLine("\n\nurl:\n" + url);

          //  bool errors = false;
            try
            {
                // check service url
                var result = await ClientDataService.CheckServiceAsync(url,"1.0.0");//+ "/Echo",  BitaqatiApp.GetAppVersion());

                if (result == null)
                    throw new HttpCustomException(System.Net.HttpStatusCode.ServiceUnavailable);
                Console.WriteLine("\n\n apiLinks:\n"+result.apiLinks);
                Console.WriteLine("\n\n ApiVersion:\n" + result.ApiVersion);
                Console.WriteLine("\n\n AppName:\n" + result.AppName);
                Console.WriteLine("\n\n ClientAccentColor:\n" + result.ClientAccentColor);
                Console.WriteLine("\n\n ClientAccentTextColor:\n" + result.ClientAccentTextColor);
                Console.WriteLine("\n\n ClientNameAR:\n" + result.ClientNameAR);
                Console.WriteLine("\n\n ClientNameEN:\n" + result.ClientNameEN);
                Console.WriteLine("\n\n ClientPrimaryColor:\n" + result.ClientPrimaryColor);
                Console.WriteLine("\n\n ClientPrimaryColorDark:\n" + result.ClientPrimaryColorDark);
                Console.WriteLine("\n\n ClientPrimaryTextColor:\n" + result.ClientPrimaryTextColor);

                Console.WriteLine("\n\nGetLinkUrl:\n" + Common.GetLinkUrl(result.apiLinks, "clientLogo"));
                loadPop.cloud.Image = UIImage.FromBundle("cloud_done");
                /*
                // we have a valid url and valid client info object
                Preferences.ServiceURL = url;

                // store a cached copy of client api info
                CachedDataObjects.CacheData("clientApiInfo", result);

                // show the user that the service was connected successfully
                uiConnectProgressCloud.SetImageDrawable(GetDrawable(Resource.Drawable.cloud_done));
                uiConnectProgressText.Text = Resources.GetString(Resource.String.ServiceCheckSuccess);

                // try to initialize the application, on successfull initialization the user will be redirected to home page, or login page
                await InitializeApplication(result);
                */
              //  ACProgressView.
            }
            catch (HttpCustomException httpEx)
            {
                Console.WriteLine("HttpCustomException");

           //     errors = true;

                if (httpEx.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                //    BitaqatiApp.HandleException(httpEx, this, AlertDisplayMode.Toast, GetString(Resource.String.AppApiVersionMismatch), false);
                }
                else
                {
                  //  BitaqatiApp.HandleException(httpEx, this, AlertDisplayMode.Toast, GetString(Resource.String.UnavailableService), false);
                }


            }
            //catch (InvalidOperationException opEx)
            //{
            //    Console.WriteLine("HttpCustomException");

            //    errors = true;

            //    BitaqatiApp.HandleException(opEx, this, AlertDisplayMode.Toast, GetString(Resource.String.InvalidUrl), false);
            //}
            //catch (Exception ex)
            //{
                
            //    errors = true;
            //   // BitaqatiApp.HandleException(ex, this, AlertDisplayMode.Toast, GetString(Resource.String.ErrorInitializingApplicationSettings), true);
            //}
            //finally
            //{
            //    Console.WriteLine("finally");

            //    /*
            //    if (errors)
            //    {
            //        // hide progress
            //        uiConnectProgress.Visibility = ViewStates.Gone;
            //        uiServiceInfo.Visibility = ViewStates.Visible;
            //    }
            //    else
            //    {
            //        Finish();
            //    }
            //    */
            //}
        }



    }
}
