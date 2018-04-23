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
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Popup

Namespace WindowsFormsApplication56
    Public Class CustomCustomBlobPopupFormViewInfo
        Inherits CustomBlobPopupFormViewInfo

        Public Sub New(ByVal form As PopupBaseForm)
            MyBase.New(form)

        End Sub
        Protected Overrides ReadOnly Property IsLeftSizeGrip() As Boolean
            Get
                Return False 'base.IsLeftSizeGrip;
            End Get
        End Property
    End Class
End Namespace
