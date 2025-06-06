using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Utility;

namespace Content.Client.FlavorText
{
    [GenerateTypedNameReferences]
    public sealed partial class FlavorText : Control
    {
        public Action<string>? OnFlavorTextChanged;
        public Action<string>? OnOocTextChanged; // WL-OOCText

        public FlavorText()
        {
            RobustXamlLoader.Load(this);
            IoCManager.InjectDependencies(this);

            var loc = IoCManager.Resolve<ILocalizationManager>();
            CFlavorTextInput.Placeholder = new Rope.Leaf(loc.GetString("flavor-text-placeholder"));

            // WL-OOCText-Start
            COocTextInput.Placeholder = new Rope.Leaf(loc.GetString("flavor-tab-ooc-placeholder"));
            COocTextInput.OnTextChanged += _ => OocTextChanged();
            // WL-OOCText-End

            CFlavorTextInput.OnTextChanged  += _ => FlavorTextChanged();
        }

        public void FlavorTextChanged()
        {
            OnFlavorTextChanged?.Invoke(Rope.Collapse(CFlavorTextInput.TextRope).Trim());
        }

        // WL-OOCText-Start
        public void OocTextChanged()
        {
            OnOocTextChanged?.Invoke(Rope.Collapse(COocTextInput.TextRope).Trim());
        }
        // WL-OOCText-End
    }
}
