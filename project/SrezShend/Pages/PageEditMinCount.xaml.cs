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
using SrezShend.Moduel;

namespace SrezShend.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEditMinCount.xaml
    /// </summary>
    public partial class PageEditMinCount : Page
    {
        Material[] _materials;
        public PageEditMinCount(params Material[] materials)
        {
            this._materials = materials;
            InitializeComponent();
            tbMinCount.Text = materials.Max(x => x.MinCount).ToString();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            foreach(var mat in _materials)
            {
                mat.MinCount = Convert.ToDouble(tbMinCount.Text);
            }
            DB.db.SaveChanges();
            NavigationService.Navigate(new PageMaterials());
        }
    }
}
