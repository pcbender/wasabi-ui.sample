using MvvmCross.Forms.Platforms.Uap.Views;
using TipCalc.Forms.UI;

namespace TipCalc.Forms.UWP
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App 
    {
        public App()
        {
            InitializeComponent(); 
            DebugSettings.FailFastOnErrors = false;
        }
    }

    public abstract class MsbAnywhereApp : MvxWindowsApplication<PlatformSetup, Core.App, FormsApp, MainPage>
    {

    }
}
