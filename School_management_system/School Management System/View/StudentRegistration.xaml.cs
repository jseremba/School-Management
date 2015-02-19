using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace School_Management_System.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StudentRegistration : Page
    {
        public StudentRegistration()
        {
            this.InitializeComponent();
        }
        private async void Camera_Clicked(object sender, TappedRoutedEventArgs e)
        {
            CameraCaptureUI camera = new CameraCaptureUI();
            camera.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
            StorageFile photo = await camera.
                                   CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (photo != null)
            {
                var targetFile = await ApplicationData.Current.LocalFolder.CreateFileAsync("Profile.jpg");
                if (targetFile != null)
                {
                    await photo.MoveAndReplaceAsync(targetFile);
                }
            }
        }
        private async void GetPhoto()
        {
            Windows.Storage.Pickers.FileOpenPicker openPicker = new Windows.Storage.Pickers.FileOpenPicker();
            openPicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            openPicker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;

            // Filter to include a sample subset of file types.
            openPicker.FileTypeFilter.Clear();
            openPicker.FileTypeFilter.Add(".bmp");
            openPicker.FileTypeFilter.Add(".png");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".jpg");

            // Open the file picker.
            Windows.Storage.StorageFile file = await openPicker.PickSingleFileAsync();

            // file is null if user cancels the file picker.
            if (file != null)
            {
                // Open a stream for the selected file.
                Windows.Storage.Streams.IRandomAccessStream fileStream =
                    await file.OpenAsync(Windows.Storage.FileAccessMode.Read);

                // Set the image source to the selected bitmap.
                Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage =
                    new Windows.UI.Xaml.Media.Imaging.BitmapImage();

                bitmapImage.SetSource(fileStream);
                //displayImage.Source = bitmapImage;
                this.DataContext = file;
            }
        }

        private void btnStartCum_Click(object sender, RoutedEventArgs e)
        {
            GetPhoto();
        }

    }

}
