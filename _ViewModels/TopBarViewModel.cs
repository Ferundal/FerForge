using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FerForge._ViewModels
{
    public partial class TopBarViewModel : ObservableObject
    {
        private IExpandable currentActiveTopBarElement;

        [ObservableProperty]
        public partial bool IsOverlayActive { get; set; } = false;

        [RelayCommand]
        public void OnOverlayPressed()
        {
            Collapce();
        }

        public void Expand(IExpandable newActiveTopBatElement)
        {
            IsOverlayActive = true;
            if(newActiveTopBatElement != currentActiveTopBarElement)
            {
                currentActiveTopBarElement?.Collapse();
                currentActiveTopBarElement = newActiveTopBatElement;
            }
            currentActiveTopBarElement.Expand();
        }

        public void Collapce()
        {
            currentActiveTopBarElement.Collapse();
            IsOverlayActive = false;
        }
    }
}
