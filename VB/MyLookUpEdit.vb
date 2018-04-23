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
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Editors.Helpers
Imports DevExpress.Xpf.Grid.LookUp

Namespace SilverlightApplication34
    Public Class MyLookUpEdit
        Inherits LookUpEdit


        Private columnsToFilter_Renamed As New List(Of ColumnItem)()
        Public Property ColumnsToFilter() As List(Of ColumnItem)
            Get
                Return columnsToFilter_Renamed
            End Get
            Set(ByVal value As List(Of ColumnItem))
                columnsToFilter_Renamed = value
            End Set
        End Property
        Protected Overrides Function CreateEditStrategy() As EditStrategyBase
            Return New MyLookUpEditStrategy(Me)
        End Function
    End Class
    Public Class ColumnItem
        Public Property FieldName() As String
    End Class
End Namespace
