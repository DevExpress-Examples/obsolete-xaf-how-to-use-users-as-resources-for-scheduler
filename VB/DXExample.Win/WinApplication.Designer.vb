Imports Microsoft.VisualBasic
Imports System
Namespace DXExample.Win
	Partial Public Class DXExampleWindowsFormsApplication
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
			Me.module3 = New DXExample.Module.DXExampleModule()
			Me.module4 = New DXExample.Module.Win.DXExampleWindowsFormsModule()
			Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
			Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
			Me.module7 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
			Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
			Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
			Me.schedulerWindowsFormsModule1 = New DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule()
			Me.schedulerModuleBase1 = New DevExpress.ExpressApp.Scheduler.SchedulerModuleBase()
			Me.authenticationStandard1 = New DevExpress.ExpressApp.Security.AuthenticationStandard()
			Me.securityComplex1 = New DevExpress.ExpressApp.Security.SecurityComplex()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' module5
			' 
			Me.module5.AllowValidationDetailsAccess = True
			' 
			' sqlConnection1
			' 
			Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=DXExample;Integrated Security=SSPI;Pooling=fa" & "lse"
			Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
			' 
			' authenticationStandard1
			' 
			Me.authenticationStandard1.LogonParametersType = GetType(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters)
			' 
			' securityComplex1
			' 
			Me.securityComplex1.Authentication = Me.authenticationStandard1
			Me.securityComplex1.IsGrantedForNonExistentPermission = False
			Me.securityComplex1.RoleType = GetType(DevExpress.Persistent.BaseImpl.Role)
			Me.securityComplex1.UserType = GetType(DXExample.Module.MyUser)
			' 
			' DXExampleWindowsFormsApplication
			' 
			Me.ApplicationName = "DXExample"
			Me.Connection = Me.sqlConnection1
			Me.Modules.Add(Me.module1)
			Me.Modules.Add(Me.module2)
			Me.Modules.Add(Me.module6)
			Me.Modules.Add(Me.module3)
			Me.Modules.Add(Me.module4)
			Me.Modules.Add(Me.module5)
			Me.Modules.Add(Me.module7)
			Me.Modules.Add(Me.securityModule1)
			Me.Modules.Add(Me.schedulerModuleBase1)
			Me.Modules.Add(Me.schedulerWindowsFormsModule1)
			Me.Security = Me.securityComplex1
'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.DXExampleWindowsFormsApplication_DatabaseVersionMismatch);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
		Private module3 As DXExample.Module.DXExampleModule
		Private module4 As DXExample.Module.Win.DXExampleWindowsFormsModule
		Private module5 As DevExpress.ExpressApp.Validation.ValidationModule
		Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
		Private module7 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
		Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
		Private sqlConnection1 As System.Data.SqlClient.SqlConnection
		Private schedulerWindowsFormsModule1 As DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule
		Private schedulerModuleBase1 As DevExpress.ExpressApp.Scheduler.SchedulerModuleBase
		Private authenticationStandard1 As DevExpress.ExpressApp.Security.AuthenticationStandard
		Private securityComplex1 As DevExpress.ExpressApp.Security.SecurityComplex
	End Class
End Namespace
