Public Class EmployeesTable

    Dim dataBaseFetcher As DataBaseFetcher = New DataBaseFetcher

    Public ReadOnly Property contactCount As Integer

    Public Sub CreateCount(ByVal connString As String)
        _contactCount = dataBaseFetcher.IntegerScalarOleDbCommand("SELECT COUNT(LastName) FROM dbo.Employees ", connString)
    End Sub
End Class
