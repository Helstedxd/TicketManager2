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
using TicketManager2.Models;

namespace TicketManager2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 100000; i++)
            {
                Ticket t = new Ticket() { TicketID = "ticketid", Name = "Name", Mail = "mail", Purchased = DateTime.Now, Used = true, Valid = true };
                Tickets.Items.Add(t);
            }
        }
    }
}
