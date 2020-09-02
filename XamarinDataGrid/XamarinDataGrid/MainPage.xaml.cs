using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinDataGrid.Model;
using XamarinDataGrid.ViewModel;

namespace XamarinDataGrid
{
    public partial class MainPage : ContentPage
    {
        bool isNameSorted = true;
        List<Employee> Employees = new List<Employee>();

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new EmployeeListviewModel();
        }
       
        private void NameSort_Tapped(object sender, EventArgs e)
        {

            List<Employee> EmployeeList = new List<Employee>();
            Employees = new List<Employee>();
            //Sorry for this line of code :DD
            if (EmplooyeList.ItemsSource is ObservableCollection<Employee> empCollection)
                 EmployeeList.AddRange(empCollection);
            else if(EmplooyeList.ItemsSource is List<Employee> empList)
                EmployeeList.AddRange(empList);

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
            EmplooyeList.ItemsSource = Employees;
            isNameSorted = !isNameSorted;
        }
    }
}
