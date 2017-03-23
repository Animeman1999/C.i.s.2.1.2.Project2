Public Class CompaniesAndEmployeesTables
    Dim dataBaseFetcher As DataBaseFetcher = New DataBaseFetcher

    Public ReadOnly Property ErrorMessage As String

    Public ReadOnly Property dataSet As DataSet


    Public Sub FetchBrowseDataSet(ByVal connString As String)
        _ErrorMessage = ""
        _dataSet = dataBaseFetcher.getOleDataSet("SELECT LastName, FirstName, CompanyName,Companies.CompanyID 
                                                  FROM dbo.Employees 
                                                  JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID 
                                                  ORDER BY LastName", "dbo.Employees", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage

    End Sub

    Public Sub FetchLastNameDataSet(ByVal connString As String, ByVal lastName As String)
        _ErrorMessage = ""
        _dataSet = dataBaseFetcher.getOleDataSet($"SELECT LastName, FirstName, CompanyName,Companies.CompanyID 
                                                    FROM dbo.Employees JOIN dbo.Companies 
                                                    ON Companies.CompanyID = Employees.CompanyID 
                                                    WHERE LastName LIKE '{lastName.Trim()}%'
                                                    ORDER BY LastName", "dbo.Employees", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage
    End Sub

    Public Sub FetchCompanyNameDataSet(ByVal connString As String, ByVal companyName As String)
        _ErrorMessage = ""
        _dataSet = dataBaseFetcher.getOleDataSet($"SELECT LastName, FirstName, CompanyName,Companies.CompanyID 
                                                   FROM dbo.Employees 
                                                   JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID 
                                                   WHERE CompanyName LIKE '{companyName.Trim()}%' 
                                                   ORDER BY LastName", "dbo.Employees", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage
    End Sub

    Public Function CheckIfCompanyInDatabase(ByVal connString As String, ByVal companyName As String, ByVal lastName As String) As Boolean
        _ErrorMessage = ""
        Return dataBaseFetcher.ObjectFoundOleDbCommand($"SELECT LastName, CompanyName 
                                                        FROM dbo.Employees 
                                                        JOIN dbo.Companies  
                                                        ON Companies.CompanyID = Employees.CompanyID 
                                                        WHERE CompanyName = '{companyName.Trim()}'
                                                            AND LastName = '{lastName.Trim()}'", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage
    End Function
End Class '   
