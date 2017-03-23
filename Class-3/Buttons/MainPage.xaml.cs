using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace xaml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int count=0;// δηλώση του μετρητή μας
        public MainPage()
        {
            this.InitializeComponent();

            TBCounter.Text = "counter: " + count; // εμφανισουμε στο textblock τον counter για πρώτη φορά.
        }

        //click event γίνεται μόνο οταν ο χρήστης κάνει κλικ πάνω στο συγκεκριμένο button
        private void ClickHellowWorld_Click(object sender, RoutedEventArgs e)
        {
            HellowWorldText.Text = "Hellow World"; // (ονομα textblock).text = συμβολοσειρά
        }

        //click event γίνεται μόνο οταν ο χρήστης κάνει κλικ πάνω στο συγκεκριμένο button
        private void ColorBlue_Click(object sender, RoutedEventArgs e)
        {
            BGColor.Fill = new SolidColorBrush(Colors.Blue); // δινουμέ χρώμα στο rectangle
        }

        //click event γίνεται μόνο οταν ο χρήστης κάνει κλικ πάνω στο συγκεκριμένο button
        private void ColorRed_Click(object sender, RoutedEventArgs e)
        {
            BGColor.Fill = new SolidColorBrush(Colors.Red);
        }

        //click event γίνεται μόνο οταν ο χρήστης κάνει κλικ πάνω στο συγκεκριμένο button
        private void Clicks_Click(object sender, RoutedEventArgs e)
        {
            count++; // αυξανουμε τον μετρητη του count
            TBCounter.Text = "counter: " + count; // εμφανισουμε στο textblock τον counter
        }
    }
}
