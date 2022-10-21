using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dapper;

namespace Licitatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlDataReader reader;

        public MainWindow()
        {
            InitializeComponent();
            FillList();
        }
        
        public void Countdown()
        {
            this.Dispatcher.Invoke(() =>
                {
                for (int i = 100; i >= 0; i--)
                {
                    CountdownLabel.Content = i;
                    Thread.Sleep(1000);
                }
            });
        }

        public void InsertPerson(string productname, double initialprice, string otherinfo, bool isavailable)
        {
            using (IDbConnection connection = new SqlConnection(Helper.cnnVal("ConnString")))
            {
                List<Product> products = new List<Product>();

                products.Add(new Product { productName=productname, initialPrice=initialprice, otherInfo=otherinfo, isAvailable=isavailable });

                connection.Execute("dbo.Products_AddProduct @productName, @initialPrice, @otherInfo, @isAvailable", products);

            }
        }

        public void DeletePerson(string productname)
        {
            using (IDbConnection connection = new SqlConnection(Helper.cnnVal("ConnString")))
            {
                connection.Execute("dbo.Products_DeleteProduct @productName", new { productName = productname });
            }
        }

        public void FillList()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Helper.cnnVal("ConnString");
                con.Open();
                cmd = new SqlCommand("SELECT productName, initialPrice, otherInfo, isAvailable from products", con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "products");
                Product prod = new Product();
                IList<Product> prods = new List<Product>();

                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    prods.Add(new Product
                    {
                        productName = dr[0].ToString(),
                        initialPrice = Convert.ToDouble(dr[1].ToString()),
                        otherInfo = dr[2].ToString(),
                        isAvailable = Convert.ToBoolean(dr[3].ToString())
                    });
                }
                lstBox.ItemsSource = prods;

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void StartBidButton_Click(object sender, RoutedEventArgs e)
        {
                Thread t = new Thread(Countdown);
                t.Start();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            String productNameVar = ProductNameTxt.Text;
            double initialPriceVar=-1;
            try
            {
                initialPriceVar = double.Parse(InitialPriceTxt.Text);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Enter a number in the price section");
            }
            String InfoVar = InfoTxt.Text;
            if(initialPriceVar!=-1)
            {
                InsertPerson(productNameVar, initialPriceVar, InfoVar, true);
            }
           
        }

        private void DeleteProduct(object sender, RoutedEventArgs e)
        {
            DeletePerson(DeleteProductNameTxt.Text);
        }
    }
}
