using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace De3WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<NhanVien> dsNhanVien = new ObservableCollection<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {


            if (txtMaNV.Text == "" || txtHoTen.Text == "" || txtSoTienBanHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin","Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning );
                return;
            }

            var nhanVienDaTonTai = dsNhanVien.FirstOrDefault((x)=>x.MaNV == txtMaNV.Text);

            if (nhanVienDaTonTai != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại.", "Thông báo", MessageBoxButton.OK,MessageBoxImage.Warning);
            }

            if (!decimal.TryParse(txtSoTienBanHang.Text, out decimal soTienBanHang) || soTienBanHang <= 0)
            {
                MessageBox.Show("Số tiền bán hàng phải là số và lớn hơn 0.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            string gioiTinh = rdoNam.IsChecked == true ? "Nam" : (rdoNu.IsChecked == true ? "Nữ" : "Khác");
            dsNhanVien.Add(new NhanVien()
            {
                MaNV = txtMaNV.Text,
                HoTen = txtHoTen.Text,
                GioiTinh = gioiTinh,
                SoTienBanHang = double.Parse(txtSoTienBanHang.Text)

            });

            dgNhanVien.ItemsSource = dsNhanVien;
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtSoTienBanHang.Text = "";

            MessageBox.Show("Nhân viên đã được thêm thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi {ex.Message}.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.SetData(dsNhanVien);
            w2.Show();

        }
    }
}