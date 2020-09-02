using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinDataGrid.Model;

namespace XamarinDataGrid.ViewModel
{
    public class EmployeeListviewModel : BaseViewModel
    {
        #region Inits
        public ObservableCollection<Employee> _employees;
        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;
                OnPropertyChanged(nameof(_employees));
            }
        }
        #endregion

        #region Ctor
        public EmployeeListviewModel()
        {
            Employees = new ObservableCollection<Employee>()
            {
                 new Employee(){ Id=1, Name= "Ayberk", Quantity=100, Total=99999},
                 new Employee(){ Id=2, Name= "Arthas", Quantity=98, Total=9599},
                 new Employee(){ Id=3, Name= "Lux", Quantity=23, Total=1099},
                 new Employee(){ Id=4, Name= "Subzero", Quantity=1, Total=799},
                 new Employee(){ Id=5, Name= "Ezreal", Quantity=95, Total=9659},
                 new Employee(){ Id=6, Name= "Karthus", Quantity=93, Total=12399},
                 new Employee(){ Id=7, Name= "MasterYi", Quantity=73, Total=2999},
                 new Employee(){ Id=8, Name= "Kayn", Quantity=82, Total=3999},
                 new Employee(){ Id=11, Name= "Canberk", Quantity=100, Total=99999},
                 new Employee(){ Id=22, Name= "Illidan", Quantity=97, Total=6499},
                 new Employee(){ Id=33, Name= "Nunu", Quantity=23, Total=1099},
                 new Employee(){ Id=44, Name= "Scorpion", Quantity=1, Total=799},
                 new Employee(){ Id=55, Name= "Rex", Quantity=95, Total=9659},
                 new Employee(){ Id=66, Name= "Juggernaut", Quantity=93, Total=99991},
                 new Employee(){ Id=77, Name= "Rexxar", Quantity=73, Total=2999},
                 new Employee(){ Id=88, Name= "Lol", Quantity=2, Total=523},
                 new Employee(){ Id=19, Name= "Omp", Quantity=100, Total=99999},
                 new Employee(){ Id=20, Name= "Amp", Quantity=98, Total=9599},
                 new Employee(){ Id=13, Name= "Lil", Quantity=23, Total=1099},
                 new Employee(){ Id=24, Name= "IsThatIt", Quantity=1, Total=799},
                 new Employee(){ Id=35, Name= "Otk", Quantity=95, Total=9659},
                 new Employee(){ Id=46, Name= "Monster", Quantity=93, Total=12399},
                 new Employee(){ Id=57, Name= "Luffy", Quantity=73, Total=2999},
                 new Employee(){ Id=68, Name= "Zoro", Quantity=82, Total=3999},
                 new Employee(){ Id=71, Name= "Nami", Quantity=100, Total=99999},
                 new Employee(){ Id=82, Name= "Lili", Quantity=98, Total=9599},
                 new Employee(){ Id=93, Name= "Katakuri", Quantity=101, Total=99999},
                 new Employee(){ Id=114, Name= "BigMom", Quantity=1, Total=799},
                 new Employee(){ Id=523, Name= "Kaido", Quantity=95, Total=9659},
                 new Employee(){ Id=612, Name= "Shanks", Quantity=93, Total=99998},
                 new Employee(){ Id=723, Name= "Kaido", Quantity=99, Total=99998},
                 new Employee(){ Id=824, Name= "WhiteBeard", Quantity=100, Total=99999},
                  new Employee(){ Id=22, Name= "Illidan", Quantity=97, Total=6499},
                 new Employee(){ Id=33, Name= "Nunu", Quantity=23, Total=1099},
                 new Employee(){ Id=44, Name= "Scorpion", Quantity=1, Total=799},
                 new Employee(){ Id=55, Name= "Rex", Quantity=95, Total=9659},
                 new Employee(){ Id=66, Name= "Juggernaut", Quantity=93, Total=99991},
                 new Employee(){ Id=77, Name= "Rexxar", Quantity=73, Total=2999},
                 new Employee(){ Id=88, Name= "Lol", Quantity=2, Total=523},
                 new Employee(){ Id=19, Name= "Omp", Quantity=100, Total=99999},
                 new Employee(){ Id=20, Name= "Amp", Quantity=98, Total=9599},
                 new Employee(){ Id=13, Name= "Lil", Quantity=23, Total=1099},
                 new Employee(){ Id=24, Name= "IsThatIt", Quantity=1, Total=799},
                 new Employee(){ Id=35, Name= "Otk", Quantity=95, Total=9659},
                 new Employee(){ Id=46, Name= "Monster", Quantity=93, Total=12399},
                 new Employee(){ Id=57, Name= "Luffy", Quantity=73, Total=2999},
                 new Employee(){ Id=68, Name= "Zoro", Quantity=82, Total=3999},
                 new Employee(){ Id=71, Name= "Nami", Quantity=100, Total=99999},
                 new Employee(){ Id=82, Name= "Lili", Quantity=98, Total=9599},
                 new Employee(){ Id=93, Name= "Katakuri", Quantity=101, Total=99999},
                 new Employee(){ Id=114, Name= "BigMom", Quantity=1, Total=799},
                 new Employee(){ Id=523, Name= "Kaido", Quantity=95, Total=9659},
                 new Employee(){ Id=612, Name= "Shanks", Quantity=93, Total=99998},
                 new Employee(){ Id=723, Name= "Kaido", Quantity=99, Total=99998},
                 new Employee(){ Id=824, Name= "WhiteBeard", Quantity=100, Total=99999}
            };
        }
        #endregion

        #region Sort
        bool isNameSorted = true;    


        public ICommand NameSortCommand => new Command(() =>
        {
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.AddRange(Employees);
            Employees = new ObservableCollection<Employee>();
            if (isNameSorted)
            {
                EmployeeList = EmployeeList.OrderBy(x => x.Name).ToList();
                foreach (var item in EmployeeList)
                {
                    Employees.Add(item);
                }
            }
            else
            {
                EmployeeList = EmployeeList.OrderByDescending(x => x.Name).ToList();
                foreach (var item in EmployeeList)
                {
                    Employees.Add(item);
                }
            }
            isNameSorted = !isNameSorted;
        });
        #endregion       
    }
}
