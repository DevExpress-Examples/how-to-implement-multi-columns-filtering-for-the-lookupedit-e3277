Imports System
Imports System.Collections.Generic
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpf.Grid.LookUp

Namespace SilverlightApplication34
    Public Class MyLookUpEditStrategy
        Inherits LookUpEditStrategy

        Public Sub New(ByVal editor As LookUpEdit)
            MyBase.New(editor)
        End Sub

        Public Overrides Sub UpdateDisplayFilter()
            ItemsProvider.DisplayFilterCriteria = CreateDisplayFilterCriteria(AutoSearchText)
        End Sub
        Protected Overrides Function CreateDisplayFilterCriteria(ByVal text As String) As CriteriaOperator
            Dim lookUp As MyLookUpEdit = CType(Editor, MyLookUpEdit)
            Dim groupOperator As New GroupOperator() With {.OperatorType = GroupOperatorType.Or}
            For Each col As ColumnItem In lookUp.ColumnsToFilter
                Dim list As New List(Of CriteriaOperator)()
                list.Add(New OperandProperty() With {.PropertyName = col.FieldName})
                list.Add(New OperandValue() With {.Value = text})
                groupOperator.Operands.Add(New FunctionOperator(FunctionOperatorType.Contains, list))
            Next col
            Return groupOperator
        End Function
    End Class
End Namespace
