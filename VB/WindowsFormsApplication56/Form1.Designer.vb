' Developer Express Code Central Example:
' PopupContainerEdit - How to always show size grip of the popup drop down on the right size
' 
' This example illustrates how to show the size grip of the PopupContainerEdit
' always on the right size regardless the location and closeness the drop down to
' screen edge
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T266695

Namespace WindowsFormsApplication56
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.customPopupContainerEdit1 = New WindowsFormsApplication56.CustomPopupContainerEdit()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemCustomPopupContainerEdit1 = New WindowsFormsApplication56.RepositoryItemCustomPopupContainerEdit()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
            Me.PopupContainerControl2 = New DevExpress.XtraEditors.PopupContainerControl()
            Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupContainerControl1.SuspendLayout()
            CType(Me.customPopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCustomPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PopupContainerControl2.SuspendLayout()
            Me.SuspendLayout()
            '
            'popupContainerControl1
            '
            Me.popupContainerControl1.Controls.Add(Me.simpleButton1)
            Me.popupContainerControl1.Location = New System.Drawing.Point(12, 108)
            Me.popupContainerControl1.Name = "popupContainerControl1"
            Me.popupContainerControl1.Size = New System.Drawing.Size(362, 139)
            Me.popupContainerControl1.TabIndex = 1
            '
            'simpleButton1
            '
            Me.simpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.simpleButton1.Location = New System.Drawing.Point(215, 113)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(144, 23)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Size Grip Is always here >"
            '
            'customPopupContainerEdit1
            '
            Me.customPopupContainerEdit1.Location = New System.Drawing.Point(12, 69)
            Me.customPopupContainerEdit1.Name = "customPopupContainerEdit1"
            Me.customPopupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.customPopupContainerEdit1.Properties.PopupControl = Me.popupContainerControl1
            Me.customPopupContainerEdit1.Size = New System.Drawing.Size(282, 20)
            Me.customPopupContainerEdit1.TabIndex = 0
            '
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barEditItem2})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 3
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1, Me.repositoryItemPopupContainerEdit1, Me.repositoryItemCustomPopupContainerEdit1})
            Me.barManager1.StatusBar = Me.bar3
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 1
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem2)})
            Me.bar1.Text = "Tools"
            '
            'barEditItem2
            '
            Me.barEditItem2.Caption = "barEditItem2"
            Me.barEditItem2.Edit = Me.repositoryItemCustomPopupContainerEdit1
            Me.barEditItem2.Id = 2
            Me.barEditItem2.Name = "barEditItem2"
            Me.barEditItem2.Width = 120
            '
            'repositoryItemCustomPopupContainerEdit1
            '
            Me.repositoryItemCustomPopupContainerEdit1.AutoHeight = False
            Me.repositoryItemCustomPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCustomPopupContainerEdit1.Name = "repositoryItemCustomPopupContainerEdit1"
            Me.repositoryItemCustomPopupContainerEdit1.PopupControl = Me.PopupContainerControl2
            '
            'bar2
            '
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            '
            'bar3
            '
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(517, 49)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 276)
            Me.barDockControlBottom.Size = New System.Drawing.Size(517, 23)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 227)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(517, 49)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 227)
            '
            'repositoryItemTextEdit1
            '
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            '
            'repositoryItemPopupContainerEdit1
            '
            Me.repositoryItemPopupContainerEdit1.AutoHeight = False
            Me.repositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1"
            '
            'PopupContainerControl2
            '
            Me.PopupContainerControl2.Controls.Add(Me.SimpleButton2)
            Me.PopupContainerControl2.Location = New System.Drawing.Point(402, 108)
            Me.PopupContainerControl2.Name = "PopupContainerControl2"
            Me.PopupContainerControl2.Size = New System.Drawing.Size(362, 139)
            Me.PopupContainerControl2.TabIndex = 1
            '
            'SimpleButton2
            '
            Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SimpleButton2.Location = New System.Drawing.Point(215, 113)
            Me.SimpleButton2.Name = "SimpleButton2"
            Me.SimpleButton2.Size = New System.Drawing.Size(144, 23)
            Me.SimpleButton2.TabIndex = 0
            Me.SimpleButton2.Text = "Size Grip Is always here >"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(517, 299)
            Me.Controls.Add(Me.PopupContainerControl2)
            Me.Controls.Add(Me.popupContainerControl1)
            Me.Controls.Add(Me.customPopupContainerEdit1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupContainerControl1.ResumeLayout(False)
            CType(Me.customPopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCustomPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PopupContainerControl2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private customPopupContainerEdit1 As CustomPopupContainerEdit
        Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private bar2 As DevExpress.XtraBars.Bar
        Private bar3 As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private repositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private barEditItem2 As DevExpress.XtraBars.BarEditItem
        Private repositoryItemCustomPopupContainerEdit1 As RepositoryItemCustomPopupContainerEdit
        Private WithEvents PopupContainerControl2 As DevExpress.XtraEditors.PopupContainerControl
        Private WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

