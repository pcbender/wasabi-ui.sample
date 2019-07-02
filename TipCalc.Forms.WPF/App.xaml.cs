using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace TipCalc.Forms.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        protected override void RegisterSetup()
        {
            this.RegisterSetupType<PlatformSetup>();
        }

    }

}
