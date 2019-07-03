using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.Plugin.Messenger;
using TipCalc.Forms.UI;
using WasabiUI.MvvmCross.Forms.Core;

namespace TipCalc.Forms.Web
{
    public class PlatformSetup : MvxFormsWasabiUISetup<Core.App, FormsApp>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IMvxMessenger, MvxMessengerHub>();
        }

    }
}
