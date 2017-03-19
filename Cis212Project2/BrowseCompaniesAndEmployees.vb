Public Class BrowseCompaniesAndEmployees
    Dim dataBaseFetcher As DataBaseFetcher = New DataBaseFetcher

    Public ReadOnly Property dataSet As DataSet

    Public Sub FetchDataSet(ByVal connString As String)
        _dataSet = dataBaseFetcher.getOleDataSet("SELECT LastName, FirstName, CompanyName,Companies.CompanyID FROM dbo.Employees JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID ORDER BY LastName", "dbo.Employees", connString)
    End Sub

End Class
