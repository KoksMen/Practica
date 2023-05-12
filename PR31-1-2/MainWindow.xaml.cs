using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace PR31_1_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private DishViewModel dishViewModel;
        public MainWindow()
        {
            InitializeComponent();
            dishViewModel = new DishViewModel();
            DataContext = dishViewModel;
            dishViewModel.LoadDishes(); // Загрузка данных из базы данных при запуске
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    public class DishViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Dish> dishes;
        private string newDishType;
        private int newDishWeight;
        private string newPreparationOrder;
        private int newCaloryCount;
        private int newCarbCount;

        public ObservableCollection<Dish> Dishes
        {
            get { return dishes; }
            set
            {
                dishes = value;
                OnPropertyChanged("Dishes");
            }
        }

        public string NewDishType
        {
            get { return newDishType; }
            set
            {
                newDishType = value;
                OnPropertyChanged("NewDishType");
            }
        }

        public int NewDishWeight
        {
            get { return newDishWeight; }
            set
            {
                newDishWeight = value;
                OnPropertyChanged("NewDishWeight");
            }
        }

        public string NewPreparationOrder
        {
            get { return newPreparationOrder; }
            set
            {
                newPreparationOrder = value;
                OnPropertyChanged("NewPreparationOrder");
            }
        }

        public int NewCaloryCount
        {
            get { return newCaloryCount; }
            set
            {
                newCaloryCount = value;
                OnPropertyChanged("NewCaloryCount");
            }
        }

        public int NewCarbCount
        {
            get { return newCarbCount; }
            set
            {
                newCarbCount = value;
                OnPropertyChanged("NewCarbCount");
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public DishViewModel()
        {
            Dishes = new ObservableCollection<Dish>();
            AddCommand = new RelayCommand(AddDish);
            EditCommand = new RelayCommand(EditDish);
            DeleteCommand = new RelayCommand(DeleteDish);
        }

        public void LoadDishes()
        {
            // Загрузка блюд из базы данных и добавление их в коллекцию
            // ...

            // Пример загрузки данных
            Dishes.Add(new Dish { DishCode = 1, DishType = "Type1", DishWeight = 100, PreparationOrder = "Order1", CaloryCount = 200, CarbCount = 30 });
            Dishes.Add(new Dish { DishCode = 2, DishType = "Type2", DishWeight = 150, PreparationOrder = "Order2", CaloryCount = 300, CarbCount = 40 });
            Dishes.Add(new Dish { DishCode = 3, DishType = "Type3", DishWeight = 200, PreparationOrder = "Order3", CaloryCount = 400, CarbCount = 50 });
        }

        public void AddDish(object parameter)
        {
            // Добавление нового блюда в базу данных
            // ...

            // Пример добавления
            Dish newDish = new Dish
            {
                DishType = NewDishType,
                DishWeight = NewDishWeight,
                PreparationOrder = NewPreparationOrder,
                CaloryCount = NewCaloryCount,
                CarbCount = NewCarbCount
            };

            // Добавляем новое блюдо в коллекцию и базу данных
            Dishes.Add(newDish);
            // AddDish(newDish.DishType, newDish.DishWeight, newDish.PreparationOrder, newDish.CaloryCount, newDish.CarbCount);

            // Очищаем поля ввода
            NewDishType = string.Empty;
            NewDishWeight = 0;
            NewPreparationOrder = string.Empty;
            NewCaloryCount = 0;
            NewCarbCount = 0;
        }

        public void EditDish(object parameter)
        {
            // Редактирование выбранного блюда в базе данных
            // ...

            // Пример редактирования
            Dish selectedDish = parameter as Dish;
            if (selectedDish != null)
            {
                // Изменяем данные выбранного блюда в базе данных
                // UpdateDish(selectedDish.DishCode, selectedDish.DishType, selectedDish.DishWeight, selectedDish.PreparationOrder, selectedDish.CaloryCount, selectedDish.CarbCount);
            }
        }

        public void DeleteDish(object parameter)
        {
            // Удаление выбранного блюда из базы данных
            // ...

            // Пример удаления
            Dish selectedDish = parameter as Dish;
            if (selectedDish != null)
            {
                // Удаляем выбранное блюдо из коллекции и базы данных
                Dishes.Remove(selectedDish);
                // DeleteDish(selectedDish.DishCode);
            }
        }
    }

    public class Dish
    {
        public int DishCode { get; set; }
        public string DishType { get; set; }
        public int DishWeight { get; set; }
        public string PreparationOrder { get; set; }
        public int CaloryCount { get; set; }
        public int CarbCount { get; set; }
    }

    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
