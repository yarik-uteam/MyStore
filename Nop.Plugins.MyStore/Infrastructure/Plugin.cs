using Nop.Core.Plugins;
using Nop.Services.Localization;

namespace Nop.Plugins.MyStore.Infrastructure
{
    public class Plugin : BasePlugin
    {
        public override void Install()
        {
            this.AddOrUpdatePluginLocaleResource("Uteam.MyStore.Product.Heading","Heading");
            this.AddOrUpdatePluginLocaleResource("Uteam.MyStore.Product.Heading.Hint", "Heading");
            this.AddOrUpdatePluginLocaleResource("Uteam.MyStore.Product.MyCheck", "MyCheck");
            this.AddOrUpdatePluginLocaleResource("Uteam.MyStore.Product.MyCheck.Hint", "MyCheck");
            base.Install();
        }

        public override void Uninstall()
        {
            this.DeletePluginLocaleResource("Uteam.MyStore.Product.Heading");
            this.DeletePluginLocaleResource("Uteam.MyStore.Product.Heading.Hint");
            this.DeletePluginLocaleResource(" Uteam.MyStore.Product.MyCheck");
            this.DeletePluginLocaleResource(" Uteam.MyStore.Product.MyCheck.Hint");

            base.Uninstall();
        }
    }
}