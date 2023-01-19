using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmHelpers.Commands;
using PropertyChanged;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace FirstMauiAPP.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public partial class MainViewModel : ObservableObject
    {
        public bool IsRefresh { get; set; }
        //public AsyncCommand RefreshCommand { get; }
        //public AsyncCommand ClearAllCommand { get; }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [ObservableProperty]
        bool isRefreshing;

        public MainViewModel()
        {
            //RefreshCommand = new AsyncCommand(Refresh);
            //ClearAllCommand = new RelayCommand(ClearAll);
            Items = new ObservableCollection<string>();
        }

        public async Task<ObservableCollection<string>> GetTodoItems()
        {
            if (Items?.Count > 0)
                return Items;

            return Items;
        }

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            Items.Add(text);
            //add our item
            Text = string.Empty;
        }

        [RelayCommand]
        void Remove(string s)
        {
            if (Items.Contains(s))
                Items.Remove(s);
        }

        [RelayCommand]
        void ClearAllItems()
        {
            if (Items.Count > 0)
                Items.Clear();
        }

        [RelayCommand]
        async Task Refresh()
        {
            isRefreshing = true;
            await Task.Delay(1000);
            isRefreshing = false;
        }
    }
}
