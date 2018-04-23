using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Data.Filtering;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Helpers;
using DevExpress.Xpf.Grid.LookUp;

namespace SilverlightApplication34
{
    public class MyLookUpEdit : LookUpEdit
    {
        List<ColumnItem> columnsToFilter = new List<ColumnItem>();
        public List<ColumnItem> ColumnsToFilter
        {
            get
            {
                return columnsToFilter;
            }
            set
            {
                columnsToFilter = value;
            }
        }
        protected override EditStrategyBase CreateEditStrategy()
        {
            return new MyLookUpEditStrategy(this);
        }
    }
    public class ColumnItem
    {
        public string FieldName
        {
            get;
            set;
        }
    }
}
