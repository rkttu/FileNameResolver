using System.Resources;
using System.Windows.Forms;

namespace FileNameResolver
{
    internal static class Extensions
    {
        public static string GetLocalizedString(this Control target, ResourceManager resourceManager)
        {
            if (target == null || resourceManager == null)
                return null;

            return resourceManager.GetString($"{target.Name}_{nameof(Control.Text)}");
        }

        public static void ApplyLocalization(this Control target, ResourceManager resourceManager)
        {
            if (target == null || resourceManager == null)
                return;

            target.SuspendLayout();
            var str = target.GetLocalizedString(resourceManager);

            if (str != null)
                target.Text = str;

            foreach (Control childControl in target.Controls)
                ApplyLocalization(childControl, resourceManager);

            target.ResumeLayout(false);
        }
    }
}
