﻿using System;
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

namespace ListViewApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel vm;

        public MainWindow()
        {
            InitializeComponent();

            vm = new ViewModel();
            DataContext = vm;

            var person1 = new PersonInfo();
            person1.name = "東京太郎";
            person1.birthday = "19XX/01/01";
            person1.seibetu = "男";
            person1.address = "東京都XX区YY 〇-〇-〇";
            person1.phone = "090-XXXX-YYYY";
            person1.mail = "hoge@hoge.com";

            var person2 = new PersonInfo();
            person2.name = "大阪花子";
            person2.birthday = "20XX/02/02";
            person2.seibetu = "女";
            person2.address = "大阪府XX市YY 〇-〇-〇";
            person2.phone = "080-XXXX-YYYY";
            person2.mail = "sample@sample.com";

            var person3 = new PersonInfo();
            person3.name = "北海道次郎";
            person3.birthday = "20XX/02/02";
            person3.seibetu = "男";
            person3.address = "沖縄県XX市YY 〇-〇-〇";
            person3.phone = "080-XXXX-YYYY";
            person3.mail = "hogo@hogo.com";

            vm.PersonDataAdd = person1;
            vm.PersonDataAdd = person2;
            vm.PersonDataAdd = person3;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            FrameworkElement frameworkElement = Content as FrameworkElement;
            vm.ClientWidth = frameworkElement.ActualWidth;
            vm.ClientHeight = frameworkElement.ActualHeight;
        }
    }
}
