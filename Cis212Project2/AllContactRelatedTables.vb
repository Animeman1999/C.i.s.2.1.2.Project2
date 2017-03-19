Public Class AllContactRelatedTables

    Private COLUMN_NUMBER As Integer = 11
    Private databaseFetcher As DataBaseFetcher = New DataBaseFetcher
    Dim _returnedData() As String

    Public Property companyName As String
    Public Property lastName As String
    Public Property firstName As String
    Public Property employeeTypesDescription As String
    Public Property phoneNumber As String
    Public Property phoneType As String
    Public Property address1 As String
    Public Property address2 As String
    Public Property city As String
    Public Property state As String
    Public Property postalCode As String


    Public Sub FetchSingleContactInclusiveData(ByVal connectionString As String, ByVal companyId As Integer)

        _returnedData = databaseFetcher.getOleDataReader($"SELECT CompanyName, LastName, FirstName, EmployeeTypes.Description, dbo.Phones.Phone, dbo.PhoneTypes.Description,
                                                        dbo.Addresses.Address1, Address2, City, State, PostalCode
                                                        FROM dbo.Employees JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID
                                                        JOIN	dbo.EmployeeTypes ON	EmployeeTypes.EmployeeTypeID = Employees.EmployeeTypeID 
                                                        JOIN dbo.Phones ON	Phones.CompanyID = Companies.CompanyID
                                                        JOIN dbo.PhoneTypes ON PhoneTypes.PhoneTypeID = Phones.PhoneTypeID
                                                        JOIN dbo.Addresses ON Addresses.CompanyID = Companies.CompanyID
                                                        WHERE Companies.CompanyID = {companyId} ORDER BY LastName", COLUMN_NUMBER, connectionString)
        companyName = _returnedData(0)
        lastName = _returnedData(1)
        firstName = _returnedData(2)
        employeeTypesDescription = _returnedData(3)
        phoneNumber = _returnedData(4)
        phoneType = _returnedData(5)
        address1 = _returnedData(6)
        address2 = _returnedData(7)
        city = _returnedData(8)
        state = _returnedData(9)
        postalCode = _returnedData(10)

    End Sub

End Class
