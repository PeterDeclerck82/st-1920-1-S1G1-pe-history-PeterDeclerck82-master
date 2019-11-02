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

namespace pe2.wpf
{
    //// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            List<string> fillItemsWhen = new List<string>();
            List<string> fillItemsWhat = new List<string>();
            List<string> fillItemsWhere = new List<string>();


        public MainWindow()
        {
            InitializeComponent();
            /////
        }

        private void WinPE2_Loaded(object sender, RoutedEventArgs e)
        {
            FillStartUp();
            lblFout.Visibility = Visibility.Hidden;
        }

        private void FillStartUp()
        {

            fillItemsWhen.Add("1302");
            fillItemsWhen.Add("1830");
            fillItemsWhen.Add("1492");
            fillItemsWhen.Add("1815");
            fillItemsWhen.Add("1066");
            fillItemsWhat.Add("Slag der gulden sporen");
            fillItemsWhat.Add("Onafhankelijkheid");
            fillItemsWhat.Add("Ontdekking Amerika Christoffel Colombus");
            fillItemsWhat.Add("Slag bij Waterloo");
            fillItemsWhat.Add("Slag bij Hastings");
            fillItemsWhere.Add("België");
            fillItemsWhere.Add("België");
            fillItemsWhere.Add("USA");
            fillItemsWhere.Add("België");
            fillItemsWhere.Add("UK");
            cmbLand.Items.Add("België");
            cmbLand.Items.Add("USA");
            cmbLand.Items.Add("UK");

            LusListGeschiedenis();

        }

        private void LusListGeschiedenis()
        {
            for (int i = 0; i < fillItemsWhat.Count; i++)
            {
                string feedbackListWhen = (fillItemsWhen.ElementAt(i));
                string feedbackListWhat = (fillItemsWhat.ElementAt(i));
                string feedbackListWhere = (fillItemsWhere.ElementAt(i));

                lstGeschiedenis.Items.Add($" {feedbackListWhen} : {feedbackListWhat}  ({feedbackListWhere})");

            }
        }


        private void AddNewLineLstGeschiedenis()
        {
            string what = txtGebeurtenis.Text;
            string when = txtJaartal.Text;
            string where = txtLand.Text;

            fillItemsWhen.Add(when);
            addWhat(what);
            addWhere(where);

            lstGeschiedenis.Items.Clear();
            LusListGeschiedenis();

        }

        private void addWhere(string where)
        {
            if (!fillItemsWhere.Contains(where))
            {
                 fillItemsWhere.Add(where);
                 cmbLand.Items.Add(where);
            }
            else
            {
                fillItemsWhere.Add(where);
            }
        }

        private void addWhat(string what)
        {
            if (!fillItemsWhat.Contains(what))
            {
                fillItemsWhat.Add(what);
            }
            else
            {
                fillItemsWhat.Add(what);
                lblFout.Content += " deze gebeurtenis staat reeds geregistreerd ... \n";
                lblFout.Visibility = Visibility.Visible;

            }
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            AddCommentLabelError();
            AddNewLineLstGeschiedenis();
        }

        private void BtnLandGebruiken_Click(object sender, RoutedEventArgs e)
        {
            string useCountry = cmbLand.SelectedItem.ToString();
            txtLand.Text = useCountry;
        }

        private void AddCommentLabelError()
        {
            if ((txtGebeurtenis.Text) == "" || (txtGebeurtenis.Text) == null)

            {
                lblFout.Content += " vul uw gebeurtenis in a.u.b. \n";
                lblFout.Visibility = Visibility.Visible;
                return;
            }

            if ((txtJaartal.Text) == "" || (txtJaartal.Text) == null)

            {
                lblFout.Content += " vul het jaartal in a.u.b. \n";
                lblFout.Visibility = Visibility.Visible;
                return;
            }

            if ((txtLand.Text) == "" || (txtLand.Text) == null)

            {
                lblFout.Content += " vul het land in a.u.b. \n";
                lblFout.Visibility = Visibility.Visible;
                return;
            }

            else
            {
                lblFout.Visibility = Visibility.Hidden;
                lblFout.Content = "";
            }
        }


    }
}
