using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MadeIn.Resources.layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeMaster : ContentPage
    {
        public ListView ListView;

        public HomeMaster()
        {
            InitializeComponent();

            BindingContext = new HomeMasterViewModel();
            ListView = MenuItemsListView;
        }

        class HomeMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomeMenuItem> MenuItems { get; set; }

            public HomeMasterViewModel()
            {
                MenuItems = new ObservableCollection<HomeMenuItem>(new[]
                {
                    new HomeMenuItem { Id = 0, Title = "Catalogue", Icon = "icon.png", TargetType = typeof(Login) },
                    new HomeMenuItem { Id = 1, Title = "Calendar", Icon = "icon.png", TargetType = typeof(Register) },
                    new HomeMenuItem { Id = 2, Title = "Turism", Icon = "icon.png", TargetType = typeof(Register)},
                    new HomeMenuItem { Id = 3, Title = "Documents", Icon = "icon.png", TargetType = typeof(Register) },
                    new HomeMenuItem { Id = 4, Title = "Classifieds", Icon = "icon.png", TargetType = typeof(Register) },
                    new HomeMenuItem { Id = 5, Title = "Contact us", Icon = "icon.png", TargetType = typeof(Register) },
                    new HomeMenuItem { Id = 6, Title = "Account", Icon = "icon.png", TargetType = typeof(Register) },
                    new HomeMenuItem { Id = 7, Title = "Exit", Icon = "icon.png", TargetType = typeof(Register) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}