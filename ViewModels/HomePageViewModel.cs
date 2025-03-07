using CommunityToolkit.Mvvm.ComponentModel;
using Models;
using Services;
using System.Collections.ObjectModel;


namespace ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        private readonly CategoryService _categoryService;

        public HomePageViewModel(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public ObservableCollection<Category> Categories { get; set; } = new();

        public async Task InitializeAsync()
        {
            foreach (var category in await _categoryService.GetCategoriesAsync())
            {
                Categories.Add(category);
            }
        }
    }
}
