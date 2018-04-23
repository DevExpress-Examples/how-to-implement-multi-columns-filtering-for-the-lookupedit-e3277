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
using DevExpress.Xpf.Grid.LookUp;

namespace SilverlightApplication34
{
    public class MyLookUpEditStrategy : LookUpEditStrategy
    {
        public MyLookUpEditStrategy(LookUpEdit editor)
            : base(editor)
        {
        }

        public override void UpdateDisplayFilter()
        {
            ItemsProvider.DisplayFilterCriteria = CreateDisplayFilterCriteria(AutoSearchText);
        }
        protected override CriteriaOperator CreateDisplayFilterCriteria(string text)
        {
            MyLookUpEdit lookUp = (MyLookUpEdit)Editor;
            GroupOperator groupOperator = new GroupOperator() { OperatorType = GroupOperatorType.Or };
            foreach (ColumnItem col in lookUp.ColumnsToFilter)
            {
                List<CriteriaOperator> list = new List<CriteriaOperator>();
                list.Add(new OperandProperty() { PropertyName = col.FieldName });
                list.Add(new OperandValue() { Value = text });
                groupOperator.Operands.Add(new FunctionOperator(FunctionOperatorType.Contains, list));
            }
            return groupOperator;
        }
    }
}
