Public Class CompaniesAndEmployeesTables
    Dim dataBaseFetcher As DataBaseFetcher = New DataBaseFetcher

    Public ReadOnly Property dataSet As DataSet


    Public Sub FetchBrowseDataSet(ByVal connString As String)
        _dataSet = dataBaseFetcher.getOleDataSet("SELECT LastName, FirstName, CompanyName,Companies.CompanyID FROM dbo.Employees JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID ORDER BY LastName", "dbo.Employees", connString)
    End Sub

    Public Sub FetchLastNameDataSet(ByVal connString As String, ByVal lastName As String)
        _dataSet = dataBaseFetcher.getOleDataSet($"SELECT LastName, FirstName, CompanyName,Companies.CompanyID FROM dbo.Employees JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID WHERE LastName LIKE '{lastName.Trim()}%' ORDER BY LastName", "dbo.Employees", connString)
    End Sub

    Public Sub FetchCompanyNameDataSet(ByVal connString As String, ByVal companyName As String)
        _dataSet = dataBaseFetcher.getOleDataSet($"SELECT LastName, FirstName, CompanyName,Companies.CompanyID FROM dbo.Employees JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID WHERE CompanyName LIKE '{companyName.Trim()}%' ORDER BY LastName", "dbo.Employees", connString)
    End Sub
End Class
