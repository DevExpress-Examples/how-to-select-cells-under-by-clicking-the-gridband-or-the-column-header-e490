﻿Namespace Q130069
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
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.bandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
            Me.colFirstName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colSecondName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colAge = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.bindingSource1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.bandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(954, 452)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.bandedGridView1})
            ' 
            ' bandedGridView1
            ' 
            Me.bandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand4})
            Me.bandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colFirstName, Me.colSecondName, Me.colAge, Me.colID})
            Me.bandedGridView1.GridControl = Me.gridControl1
            Me.bandedGridView1.Name = "bandedGridView1"
            Me.bandedGridView1.OptionsSelection.MultiSelect = True
            Me.bandedGridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
            ' 
            ' colFirstName
            ' 
            Me.colFirstName.Caption = "FirstName"
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.Visible = True
            ' 
            ' colSecondName
            ' 
            Me.colSecondName.Caption = "SecondName"
            Me.colSecondName.FieldName = "SecondName"
            Me.colSecondName.Name = "colSecondName"
            Me.colSecondName.Visible = True
            ' 
            ' colAge
            ' 
            Me.colAge.Caption = "Age"
            Me.colAge.FieldName = "Age"
            Me.colAge.Name = "colAge"
            Me.colAge.Visible = True
            ' 
            ' colID
            ' 
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            ' 
            ' gridBand1
            ' 
            Me.gridBand1.Caption = "General Info"
            Me.gridBand1.Columns.Add(Me.colFirstName)
            Me.gridBand1.Columns.Add(Me.colSecondName)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.Width = 150
            ' 
            ' gridBand4
            ' 
            Me.gridBand4.Caption = "Additional Info"
            Me.gridBand4.Columns.Add(Me.colAge)
            Me.gridBand4.Columns.Add(Me.colID)
            Me.gridBand4.Name = "gridBand4"
            Me.gridBand4.Width = 150
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(954, 452)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private bindingSource1 As System.Windows.Forms.BindingSource
        Private WithEvents bandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Private colFirstName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colSecondName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Private colAge As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Private colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    End Class
End Namespace

