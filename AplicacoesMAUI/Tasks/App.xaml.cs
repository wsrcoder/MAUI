using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Platform;
using Tasks.Views;

namespace Tasks
{
    public partial class App : Application
    {
        public App()
        {
            

            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }


        private void CustomHandler()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoBorder", (handler, view) => {

                #if ANDROID
                
                    handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
                #endif

                #if IOS || MACCATALYST
                
                    handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
                #endif

                #if WINDOWS        
                    handler.PlatformView.BorderThickness = new Thickness(0).ToPlatform();
                #endif
            });
        }
    }
}