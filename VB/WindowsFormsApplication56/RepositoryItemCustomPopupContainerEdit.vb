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
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository

Namespace WindowsFormsApplication56
    <UserRepositoryItem("RegisterCustomPopupContainerEdit")> _
    Public Class RepositoryItemCustomPopupContainerEdit
        Inherits RepositoryItemPopupContainerEdit

        Shared Sub New()
            RegisterCustomPopupContainerEdit()
        End Sub

        Public Const CustomEditName As String = "CustomPopupContainerEdit"

        Public Sub New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return CustomEditName
            End Get
        End Property

        Public Shared Sub RegisterCustomPopupContainerEdit()
            Dim img As Image = Nothing
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomPopupContainerEdit), GetType(RepositoryItemCustomPopupContainerEdit), GetType(CustomPopupContainerEditViewInfo), New ButtonEditPainter(), True, img))
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source As RepositoryItemCustomPopupContainerEdit = TryCast(item, RepositoryItemCustomPopupContainerEdit)
                If source Is Nothing Then
                    Return
                End If
                '
            Finally
                EndUpdate()
            End Try
        End Sub
    End Class

End Namespace
