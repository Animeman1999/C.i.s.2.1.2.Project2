'Jeffrey Martin
'CIS 212 Project 2

''' <summary>
''' This class is the interface between the View and the Controler for the database.
''' Used with the dbo.Companies and dbo.Employees tables.
''' </summary>
Public Class CompaniesAndEmployeesTables

    'WORKING VARIABLES
    Dim dataBaseFetcher As DataBaseFetcher = New DataBaseFetcher

    'PROPERTIES
    Public ReadOnly Property ErrorMessage As String
    Public ReadOnly Property dataSet As DataSet

    ''' <summary>
    ''' Gets the Lastname, FirstName, CompanyName and CompanyID and sorts by LastName
    ''' in the form oa a DataSet
    ''' </summary>
    ''' <param name="connString">String</param>
    Public Sub FetchBrowseDataSet(ByVal connString As String)

        'Fetch the data, store it and get any error messages
        _ErrorMessage = ""
        _dataSet = dataBaseFetcher.getOleDataSet("SELECT LastName, FirstName, CompanyName,Companies.CompanyID 
                                                  FROM dbo.Employees 
                                                  JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID 
                                                  ORDER BY LastName", "dbo.Employees", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage

    End Sub


    ''' <summary>
    ''' Searches for last name passed in and returns the Lastname, FirstName, CompanyName and CompanyID and sorted by LastName as a string.
    ''' </summary>
    ''' <param name="connString">String</param>
    ''' <param name="lastName">String</param>
    Public Sub FetchLastNameDataSet(ByVal connString As String, ByVal lastName As String)

        'Fetch the data, store it and get any error messages
        _ErrorMessage = ""
        _dataSet = dataBaseFetcher.getOleDataSet($"SELECT LastName, FirstName, CompanyName,Companies.CompanyID 
                                                    FROM dbo.Employees JOIN dbo.Companies 
                                                    ON Companies.CompanyID = Employees.CompanyID 
                                                    WHERE LastName LIKE '{lastName.Trim().Replace("'", "''")}%'
                                                    ORDER BY LastName", "dbo.Employees", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage
    End Sub

    ''' <summary>
    ''' Searches for the company name passed in and returns the Lastname, FirstName, CompanyName and CompanyID, sorted by LastName as a string.
    ''' </summary>
    ''' <param name="connString">String</param>
    ''' <param name="companyName">String</param>
    Public Sub FetchCompanyNameDataSet(ByVal connString As String, ByVal companyName As String)

        'Fetch the data, store it and get any error messages
        _ErrorMessage = ""
        _dataSet = dataBaseFetcher.getOleDataSet($"SELECT LastName, FirstName, CompanyName,Companies.CompanyID 
                                                   FROM dbo.Employees 
                                                   JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID 
                                                   WHERE CompanyName LIKE '{companyName.Trim().Replace("'", "''")}%' 
                                                   ORDER BY LastName", "dbo.Employees", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage

    End Sub

    ''' <summary>
    ''' Searches by LastName and Company name to see if the record is in the database and returns true if so.
    ''' </summary>
    ''' <param name="connString">String</param>
    ''' <param name="companyName">String</param>
    ''' <param name="lastName">String</param>
    ''' <returns>Boolean</returns>
    Public Function CheckIfCompanyInDatabase(ByVal connString As String, ByVal companyName As String, ByVal lastName As String) As Boolean

        'Fetch the data, store it and get any error messages
        _ErrorMessage = ""
        Return dataBaseFetcher.ObjectFoundOleDbCommand($"SELECT LastName, CompanyName 
                                                        FROM dbo.Employees 
                                                        JOIN dbo.Companies  
                                                        ON Companies.CompanyID = Employees.CompanyID 
                                                        WHERE CompanyName = '{companyName.Trim().Replace("'", "''")}'
                                                            AND LastName = '{lastName.Trim().Replace("'", "''")}'", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage
    End Function
End Class '   
