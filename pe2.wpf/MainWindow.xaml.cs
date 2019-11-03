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
            List<int> listWhen = new List<int>();
            List<string> listWhat = new List<string>();
            List<string> listWhere = new List<string>();

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

            listWhen.Add(1302);
            listWhen.Add(1830);
            listWhen.Add(1492);
            listWhen.Add(1815);
            listWhen.Add(1066);
            listWhat.Add("Slag der gulden sporen");
            listWhat.Add("Onafhankelijkheid");
            listWhat.Add("Ontdekking Amerika Christoffel Colombus");
            listWhat.Add("Slag bij Waterloo");
            listWhat.Add("Slag bij Hastings");
            listWhere.Add("België");
            listWhere.Add("België");
            listWhere.Add("USA");
            listWhere.Add("België");
            listWhere.Add("UK");
            cmbLand.Items.Add("België");
            cmbLand.Items.Add("USA");
            cmbLand.Items.Add("UK");

            LusListGeschiedenis();

        }

        private void LusListGeschiedenis()
        {
            for (int i = 0; i < listWhat.Count; i++)
            {
                int feedbackListWhen = (listWhen.ElementAt(i));
                string feedbackListWhat = (listWhat.ElementAt(i));
                string feedbackListWhere = (listWhere.ElementAt(i));

                lstGeschiedenis.Items.Add($" {feedbackListWhen} : {feedbackListWhat}  ({feedbackListWhere})");

            }
        }


        private void AddNewLineLstGeschiedenis()
        {
            string what = txtGebeurtenis.Text;
            int when = Convert.ToInt32(txtJaartal.Text);
            string where = txtLand.Text;

            addWhen(when);
            addWhat(what);
            addWhere(where);

            lstGeschiedenis.Items.Clear();
            LusListGeschiedenis();

        }

        private void addWhen(int when)
        {
            if (!listWhen.Contains(when))
            {
                listWhen.Add(when);
            }
            else
            {
                listWhen.Add(when);
            }
        }

        private void addWhere(string where)
        {
            if (!listWhere.Contains(where))
            {
                 listWhere.Add(where);
                 cmbLand.Items.Add(where);
            }
            else
            {
                listWhere.Add(where);
            }
        }

        private void addWhat(string what)
        {
            if (!listWhat.Contains(what))
            {
                listWhat.Add(what);
            }
            else
            {
                listWhat.Add(what);
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

        // gebruik van de Bubble Sort methode
        private void SortLists()
        {

            for (int i = 1; i < listWhen.Count; i++)
            {
                for (int j = 0; j < (listWhen.Count - i); j++)
                {
                    if (listWhen[j] > listWhen[j + 1])
                    {
                        int tempWhen = listWhen[j];
                        listWhen[j] = listWhen[j + 1];
                        listWhen[j + 1] = tempWhen;

                        string tempWhat = listWhat[j];
                        listWhat[j] = listWhat[j + 1];
                        listWhat[j + 1] = tempWhat;

                        string tempWhere = listWhere[j];
                        listWhere[j] = listWhere[j + 1];
                        listWhere[j + 1] = tempWhere;
                    }
                }
            }

           

        }

        private void BtnSortUp_Click(object sender, RoutedEventArgs e)
        {
            SortLists();
        }
    }
}
