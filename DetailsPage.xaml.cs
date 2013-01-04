using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace Student_Assistant
{
    public partial class DetailsPage : PhoneApplicationPage
    {
        // Constructor
        public DetailsPage()
        {
            InitializeComponent();
        }

        // When page is navigated to set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            {
                int index = int.Parse(selectedIndex);
                DataContext = App.ViewModel.Items[index];
            }
        }

        private void buttonFind_Click(object sender, RoutedEventArgs e)
        {
            DisplaySynonyms();
        }

        private void textBoxQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                DisplaySynonyms();
            }
        }

        private void DisplaySynonyms()
        {
            SynonymsList.Focus();
            SynonymsList.ItemsSource = null;

            string query = textBoxQuery.Text;
            if (!string.IsNullOrWhiteSpace(query))
            {
                BingSynonymsData synonymsData = new BingSynonymsData();
                synonymsData.GetSynonyms(query);

                SynonymsList.ItemsSource = synonymsData.SynonymsList;
            }
        }
    }
}