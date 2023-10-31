using DalUi.Models;

namespace DalUi.Views;

public partial class GenerationOptionView : ContentPage
{
    public List<string> Options { get; set; }
    public List<ArtStyle> Styles { get; set; }

    public GenerationOptionView()
    {
        InitializeComponent();
        FillOptions();
        BindingContext = this;
    }

    private void FillOptions()
    {
        Options = new List<string>()
        {
            "Trees", "Winter", "Wild", "Nature"
        };

        Styles = new List<ArtStyle>()
        {
            new ArtStyle() { Name = "Cartoon", ImageUrl = "cartoon.jpg" },
            new ArtStyle() { Name = "Realistic", ImageUrl = "realistic.jpg" },
            new ArtStyle() { Name = "Watercolor Art", ImageUrl = "watercolor.jpg" },
            new ArtStyle() { Name = "Isometric", ImageUrl = "isometric.jpg" },
            new ArtStyle() { Name = "Pop Art", ImageUrl = "popart.jpg" },
            new ArtStyle() { Name = "Surrealism", ImageUrl = "surrealism.jpg" },
            new ArtStyle() { Name = "Minimalism", ImageUrl = "minimalism.jpg" },
            new ArtStyle() { Name = "Funko", ImageUrl = "funko.jpg" },
            new ArtStyle() { Name = "Anime", ImageUrl = "anime.jpg" },
            new ArtStyle() { Name = "Storybook", ImageUrl = "storybook.jpg" },
        };
    }
}