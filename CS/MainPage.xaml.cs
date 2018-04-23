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
using DevExpress.Xpf.Grid;
using DevExpress.Data.Filtering;
using DevExpress.Xpf.Grid.LookUp;

namespace SilverlightApplication34 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            editor.ItemsSource = new List<Test> {
                new Test() { ID = 0, Text1 = "test1", Text2 = "123" },
                new Test() { ID = 1, Text1 = "test2", Text2 = "234" },
                new Test() { ID = 2, Text1 = "test3", Text2 = "345" },
                new Test() { ID = 3, Text1 = "test4", Text2 = "456" },
                new Test() { ID = 4, Text1 = "test5", Text2 = "567" },
            };
        }
    }

    public class Test {
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public int ID { get; set; }
    }
}
