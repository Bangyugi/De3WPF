using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace De3WPF
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public ObservableCollection<NhanVien> dsNhanVienMax = new ObservableCollection<NhanVien>();
        public Window2()
        {
            InitializeComponent();
          

        }

        public void SetData (ObservableCollection<NhanVien> dsNhanVien)
        {

            try
            {
            double maxSoTienBanHang = dsNhanVien.Max((x) => x.SoTienBanHang);
            dsNhanVienMax = new ObservableCollection<NhanVien>(dsNhanVien.Where((x) => x.SoTienBanHang == maxSoTienBanHang));
            dgNhanVienMax.ItemsSource = dsNhanVienMax;
            }catch(Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButton.OK,MessageBoxImage.Error);
          
            }
        }

    
    }
}
