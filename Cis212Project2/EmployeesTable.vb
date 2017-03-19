Public Class EmployeesTable

    Dim dataBaseFetcher As DataBaseFetcher = New DataBaseFetcher
    Public ReadOnly Property ErrorMessage As String
    Public ReadOnly Property contactCount As Integer

    Public Sub CreateCount(ByVal connString As String)
        _contactCount = dataBaseFetcher.IntegerScalarOleDbCommand("SELECT COUNT(LastName) FROM dbo.Employees ", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage
    End Sub
End Class
