Public Class CompaniesAndEmployeesTables
    Dim dataBaseFetcher As DataBaseFetcher = New DataBaseFetcher

    Public ReadOnly Property ErrorMessage As String

    Public ReadOnly Property dataSet As DataSet


    Public Sub FetchBrowseDataSet(ByVal connString As String)
        _dataSet = dataBaseFetcher.getOleDataSet("SELECT LastName, FirstName, CompanyName,Companies.CompanyID FROM dbo.Employees JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID ORDER BY LastName", "dbo.Employees", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage

    End Sub

    Public Sub FetchLastNameDataSet(ByVal connString As String, ByVal lastName As String)
        _dataSet = dataBaseFetcher.getOleDataSet($"SELECT LastName, FirstName, CompanyName,Companies.CompanyID FROM dbo.Employees JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID WHERE LastName LIKE '{lastName.Trim()}%' ORDER BY LastName", "dbo.Employees", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage
    End Sub

    Public Sub FetchCompanyNameDataSet(ByVal connString As String, ByVal companyName As String)
        _dataSet = dataBaseFetcher.getOleDataSet($"SELECT LastName, FirstName, CompanyName,Companies.CompanyID FROM dbo.Employees JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID WHERE CompanyName LIKE '{companyName.Trim()}%' ORDER BY LastName", "dbo.Employees", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage
    End Sub

    Public Sub TestClick(ByVal connString As String, ByVal companyId As Integer)
        _dataSet = dataBaseFetcher.getOleDataSet($"SELECT CompanyName, LastName, FirstName, EmployeeTypes.Description, dbo.Phones.Phone, dbo.PhoneTypes.Description,
                                                 dbo.Addresses.Address1, Address2, City, State, PostalCode
                                                 FROM dbo.Employees JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID
                                                 JOIN	dbo.EmployeeTypes ON	EmployeeTypes.EmployeeTypeID = Employees.EmployeeTypeID 
                                                 JOIN dbo.Phones ON	Phones.CompanyID = Companies.CompanyID
                                                 JOIN dbo.PhoneTypes ON PhoneTypes.PhoneTypeID = Phones.PhoneTypeID
                                                 JOIN dbo.Addresses ON Addresses.CompanyID = Companies.CompanyID
                                                 WHERE Companies.CompanyID = {companyId} ORDER BY LastName", "dbo.Employees", connString)

        _ErrorMessage = dataBaseFetcher.ErrorMessage
    End Sub
End Class
