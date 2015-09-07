using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Lab01
{
    public partial class Listado : PhoneApplicationPage
    {
        public Listado()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MyDataContex db = new MyDataContex(MyDataContex.cadena);

            lstParticipantes.ItemsSource = db.listaParticipantes;
        }
    }
}