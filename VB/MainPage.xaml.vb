Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Grid
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpf.Grid.LookUp

Namespace SilverlightApplication34
    Partial Public Class MainPage
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            editor.ItemsSource = New List(Of Test) From { _
                New Test() With {.ID = 0, .Text1 = "test1", .Text2 = "123"}, _
                New Test() With {.ID = 1, .Text1 = "test2", .Text2 = "234"}, _
                New Test() With {.ID = 2, .Text1 = "test3", .Text2 = "345"}, _
                New Test() With {.ID = 3, .Text1 = "test4", .Text2 = "456"}, _
                New Test() With {.ID = 4, .Text1 = "test5", .Text2 = "567"} _
            }
        End Sub
    End Class

    Public Class Test
        Public Property Text1() As String
        Public Property Text2() As String
        Public Property ID() As Integer
    End Class
End Namespace
