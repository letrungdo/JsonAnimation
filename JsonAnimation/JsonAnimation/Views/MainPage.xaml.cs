using Xamarin.Forms;

namespace JsonAnimation.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            playButton.Clicked += (sender, e) => animationView.Play();
            playSegmentsButton.Clicked += (sender, e) => animationView.PlayProgressSegment(0.65f, 0.0f);
            playFramesButton.Clicked += (sender, e) => animationView.PlayFrameSegment(50, 1);
            pauseButton.Clicked += (sender, e) => animationView.Pause();
        }

        private void Handle_OnFinish(object sender, System.EventArgs e)
        {
            DisplayAlert($"{nameof(animationView.OnFinish)} invoked!");
        }

        private void DisplayAlert(string message)
        {
            DisplayAlert(string.Empty, message, "OK");
        }
    }
}