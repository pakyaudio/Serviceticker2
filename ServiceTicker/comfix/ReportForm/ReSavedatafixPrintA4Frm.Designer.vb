﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReSavedatafixPrintA4Frm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MySQLReport = New ServiceTicker.MySQLReport()
        Me.companyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.companyTableAdapter = New ServiceTicker.MySQLReportTableAdapters.companyTableAdapter()
        Me.customerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.customerTableAdapter = New ServiceTicker.MySQLReportTableAdapters.customerTableAdapter()
        Me.comfixBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comfixTableAdapter = New ServiceTicker.MySQLReportTableAdapters.comfixTableAdapter()
        Me.snBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.snTableAdapter = New ServiceTicker.MySQLReportTableAdapters.snTableAdapter()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comfixBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.snBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "CompanyDataSet"
        ReportDataSource1.Value = Me.companyBindingSource
        ReportDataSource2.Name = "CustomerDataSet"
        ReportDataSource2.Value = Me.customerBindingSource
        ReportDataSource3.Name = "ComfixDataSet"
        ReportDataSource3.Value = Me.comfixBindingSource
        ReportDataSource4.Name = "snDataSet"
        ReportDataSource4.Value = Me.snBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ReSavedatafixReportA4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'MySQLReport
        '
        Me.MySQLReport.DataSetName = "MySQLReport"
        Me.MySQLReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'companyBindingSource
        '
        Me.companyBindingSource.DataMember = "company"
        Me.companyBindingSource.DataSource = Me.MySQLReport
        '
        'companyTableAdapter
        '
        Me.companyTableAdapter.ClearBeforeFill = True
        '
        'customerBindingSource
        '
        Me.customerBindingSource.DataMember = "customer"
        Me.customerBindingSource.DataSource = Me.MySQLReport
        '
        'customerTableAdapter
        '
        Me.customerTableAdapter.ClearBeforeFill = True
        '
        'comfixBindingSource
        '
        Me.comfixBindingSource.DataMember = "comfix"
        Me.comfixBindingSource.DataSource = Me.MySQLReport
        '
        'comfixTableAdapter
        '
        Me.comfixTableAdapter.ClearBeforeFill = True
        '
        'snBindingSource
        '
        Me.snBindingSource.DataMember = "sn"
        Me.snBindingSource.DataSource = Me.MySQLReport
        '
        'snTableAdapter
        '
        Me.snTableAdapter.ClearBeforeFill = True
        '
        'ReSavedatafixPrintA4Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReSavedatafixPrintA4Frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์ใบรับงานซ่อมย้อนหลัง ขนาด A4"
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comfixBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.snBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents companyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MySQLReport As ServiceTicker.MySQLReport
    Friend WithEvents customerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents comfixBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents snBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents companyTableAdapter As ServiceTicker.MySQLReportTableAdapters.companyTableAdapter
    Friend WithEvents customerTableAdapter As ServiceTicker.MySQLReportTableAdapters.customerTableAdapter
    Friend WithEvents comfixTableAdapter As ServiceTicker.MySQLReportTableAdapters.comfixTableAdapter
    Friend WithEvents snTableAdapter As ServiceTicker.MySQLReportTableAdapters.snTableAdapter
End Class
