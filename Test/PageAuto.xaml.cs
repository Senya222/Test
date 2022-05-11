using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для PageAuto.xaml
    /// </summary>
    public partial class PageAuto : Page
    {
        MainWindow mainWindow;
        public PageAuto(MainWindow main)
        {
            mainWindow = main;
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(LogB.Text))
            {
                if (!String.IsNullOrEmpty(PassB.Password))
                {
                    IQueryable<Authorization> authorizations = TestEntities.GetContext().Authorization.Where(p => p.Логин == LogB.Text && p.Пароль == PassB.Password);
                    if (authorizations.Count() != 0)
                    {
                        IQueryable<Authorization> teacher = TestEntities.GetContext().Authorization.Where(p => p.Логин == LogB.Text && p.Пароль == PassB.Password && p.Роль == "Преподаватель");
                        if (teacher.Count() != 0)
                        {
                            mainWindow.Container.Navigate(new PageTeacher());
                        }
                        IQueryable<Authorization> student = TestEntities.GetContext().Authorization.Where(p => p.Логин == LogB.Text && p.Пароль == PassB.Password && p.Роль == "Ученик");
                        if (student.Count() != 0)
                        {

                        }
                    }
                }
            }
        }
    }
}
