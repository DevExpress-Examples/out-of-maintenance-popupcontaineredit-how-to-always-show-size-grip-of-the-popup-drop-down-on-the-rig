' Developer Express Code Central Example:
' PopupContainerEdit - How to always show size grip of the popup drop down on the right size
' 
' This example illustrates how to show the size grip of the PopupContainerEdit
' always on the right size regardless the location and closeness the drop down to
' screen edge
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T266695

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Popup

Namespace WindowsFormsApplication56

    <ToolboxItem(True)> _
    Public Class CustomPopupContainerEdit
        Inherits PopupContainerEdit

        Shared Sub New()
            RepositoryItemCustomPopupContainerEdit.RegisterCustomPopupContainerEdit()
        End Sub

        Public Sub New()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemCustomPopupContainerEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomPopupContainerEdit)
            End Get
        End Property

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemCustomPopupContainerEdit.CustomEditName
            End Get
        End Property

        Protected Overrides Function CreatePopupForm() As PopupBaseForm
            Return New CustomPopupContainerEditPopupForm(Me)
        End Function
    End Class
End Namespace
