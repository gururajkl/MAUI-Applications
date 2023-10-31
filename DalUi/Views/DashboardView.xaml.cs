using DalUi.Models;
using System.Collections.ObjectModel;

namespace DalUi.Views;

public partial class DashboardView : ContentPage
{
    public ObservableCollection<Profile> Profiles { get; set; }
    public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }

    public DashboardView()
    {
        InitializeComponent();
        LoadDate();
        BindingContext = this;
    }

    private void LoadDate()
    {
        Profiles = new ObservableCollection<Profile>
          {
               new Profile
               {
                    Name = "Héctor",
                    ProfileImage = "profile1.jpg",
                    NoOfPhotos = 12
               },
               new Profile
               {
                    Name = "Maddy",
                    ProfileImage = "profile2.jpg",
                    NoOfPhotos= 5
               },
               new Profile
               {
                    Name = "Henry",
                    ProfileImage = "profile3.jpg",
                    NoOfPhotos = 25
               },
          };

        GeneratedImages = new ObservableCollection<GeneratedImage>
          {
               new GeneratedImage
               {
                    ImagePath = "dashboard1.jpg",
                    MainKeyword = "Castle",
                    Keywords = new List<string>{
                         "Epic, hill, mountain, trees, blue sky"
                    }
               },
               new GeneratedImage
               {
                    ImagePath = "dashboard2.jpg",
                    MainKeyword = "Mountains",
                    Keywords = new List<string>{
                         "Landscape, photorealistic, dawn, mountains, moon"
                    }
               },
               new GeneratedImage
               {
                    ImagePath = "dashboard3.jpg",
                    MainKeyword = "Robot",
                    Keywords = new List<string>{
                         "AI, robotic, human, light, metal"
                    }
               },
          };
    }
}