'Jeffrey Martin
'CIS 212 Project 2

''' <summary>
''' This class is the interface between the View and the Controler for the database.
''' It is used when data needs to be fetched from dbo.Employees table.
''' </summary>
Public Class EmployeesTable

    'The hook up to the database controler
    Dim dataBaseFetcher As DataBaseFetcher = New DataBaseFetcher

    'PROPERTIES

    Public ReadOnly Property ErrorMessage As String
    Public ReadOnly Property contactCount As Integer

    ''' <summary>
    ''' The SQL command used count the number of LastNames in the dbo.Employees table that is placed 
    ''' into the contactCount property.
    ''' </summary>
    ''' <param name="connString"></param>
    Public Sub CreateCount(ByVal connString As String)

        'Fetch the data, store it and get any error messages
        _ErrorMessage = ""
        _contactCount = dataBaseFetcher.IntegerScalarOleDbCommand("SELECT COUNT(LastName) FROM dbo.Employees ", connString)
        _ErrorMessage = dataBaseFetcher.ErrorMessage

    End Sub
End Class
