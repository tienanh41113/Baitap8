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

namespace cv_dt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int dem = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            lst_hv.Items.Add("STT" + "\t\t Cạnh" + "\t Chu vi" + "\t Diện tích");
            HinhVuong[] hv = new HinhVuong[5];
            hv[0] = new HinhVuong(3);
            hv[1] = new HinhVuong(4);
            hv[2] = new HinhVuong(5);
            hv[3] = new HinhVuong(6);
            hv[4] = new HinhVuong(7);
            for (int i = 0; i < 5; i++)
            {
                hv[i].Cv();
                hv[i].Dt();
                dem += 1;
                lst_hv.Items.Add("\nHình Vuông: " + dem.ToString() + "\t" + hv[i].Canh + "cm" + "  \t " + hv[i].chuvi.ToString() + "cm²" + "\t " + hv[i].dientich.ToString() + "cm³");
            }
        }
        private void ok1_Click(object sender, RoutedEventArgs e)
        {
            lst_ht.Items.Add("STT" + "\t\t Bán kính" + "\t Chu vi" + "\t Diện tích");
            List<HinhTron> ht = new List<HinhTron>();
            ht.Add(new HinhTron(3));
            ht.Add(new HinhTron(4));
            ht.Add(new HinhTron(5));
            ht.Add(new HinhTron(6));
            ht.Add(new HinhTron(7));
            foreach (HinhTron st in ht)
            {
                dem += 1;
                st.Cv();
                st.Dt();
                lst_ht.Items.Add("\nHình tròn: " + dem.ToString() + "\t " + (st.bankinh) + "   \t\t " +   st.chuvi.ToString() + "    \t " +   st.dientich.ToString());
            }
        }

        private void thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void hinhvuong_Click(object sender, RoutedEventArgs e)
        {
            txb_hinhvuong.IsEnabled = true;
        }

        private void hinhtron_Click(object sender, RoutedEventArgs e)
        {
            txb_hinhtron.IsEnabled = true;
        }
    }
}
