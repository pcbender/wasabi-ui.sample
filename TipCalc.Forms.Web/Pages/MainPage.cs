using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Layouts;
using TipCalc.Forms.UI;
using WasabiUI.MvvmCross.Forms.Core;

namespace TipCalc.Forms.Web.Pages
{
    [Layout(typeof(TipCalc.Forms.Web.Shared.MainLayout))]
    [Route("/")]
    public class MainPage : MvxFormsWasabiUIApplication<PlatformSetup, Core.App, FormsApp>
    {

    }
}
