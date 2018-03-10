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

namespace Receiver_TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Receiver txtBoxContent = new Receiver();
        Invoker invoker;
        public MainWindow()
        {
            InitializeComponent();
           
            invoker =  new Invoker(new CommandOneExe(txtBoxContent),
                                    new CommandOneUnExe(txtBoxContent),
                                    new CommandTwoExe(txtBoxContent),
                                    new CommandTwoUnExe(txtBoxContent)); 

            txtBoxContent.content = string.Empty;
        }
        
        private void CMD1Execute(object sender, RoutedEventArgs e)
        {

            invoker.ClickCMD1Execute();
            this.Receiver.Text = txtBoxContent.content;
        }


        private void CMD1UnExceute(object sender, RoutedEventArgs e)
        {
            invoker.ClickCMD1UnExecute();
            this.Receiver.Text = txtBoxContent.content;
        }

        private void CMD2Exceute(object sender, RoutedEventArgs e)
        {
            //ICommand CMD2Exe = new CommandTwoExe(txtBoxContent);
            //CMD2Exe.Execute();
            //this.Receiver.Text = txtBoxContent.content;

            invoker.ClickCMD2Execute();
            this.Receiver.Text = txtBoxContent.content;
        }

        private void CMD2UnExceute(object sender, RoutedEventArgs e)
        {
            invoker.ClickCMD2UnExecute();
            this.Receiver.Text = txtBoxContent.content;
        }
    }
}
