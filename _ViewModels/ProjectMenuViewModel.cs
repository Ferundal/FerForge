using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FerForge._ViewModels
{
    public partial class ProjectMenuViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _maxButtonHeight;

        public ProjectMenuViewModel()
        {
            MaxButtonHeight = 5;  // Initialize the max button height to 0
        }
        
        [RelayCommand]
        public void OnButtonClick()
        {
            MaxButtonHeight += 1;
        }

        // Method to update the maximum button height
        private void OnButtonHeightChanged(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                double newHeight = button.Height;
                if (newHeight > MaxButtonHeight)
                {
                    MaxButtonHeight = newHeight;
                    Console.WriteLine($"Height changed to: {newHeight}");
                }
                else
                {

                }
            }
        }


    }
}
