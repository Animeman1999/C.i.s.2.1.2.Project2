Public Class BrowseCompaniesAndEmployees
    Dim dataBaseFetcher As DataBaseFetcher = New DataBaseFetcher

    Public Property dataSet As DataSet

    Public Sub FetchDataSet(ByVal connString As String)
        dataSet = dataBaseFetcher.getOleDataSet("SELECT LastName, FirstName, CompanyName FROM sd_header ORDER BY LastName", "sd_header", connString)
    End Sub

End Class
