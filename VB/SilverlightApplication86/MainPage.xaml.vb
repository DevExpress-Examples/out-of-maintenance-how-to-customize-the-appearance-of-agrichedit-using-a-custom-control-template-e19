Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls

Namespace SilverlightApplication86
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			richeditor.ApplyTemplate()
			AddHandler richeditor.Loaded, AddressOf richeditor_Loaded
		End Sub

		Private Sub richeditor_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			richeditor.RichControl.Text = "Use control template to selectively hide AgRichEdit elements." & ControlChars.CrLf & "In this example the Zoom slider in the status bar is hidden."

		End Sub
	End Class
End Namespace
