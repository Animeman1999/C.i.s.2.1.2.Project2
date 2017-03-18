Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class DataBaseFetcher
    Function getDataTable(ByVal TheSQLQueryStatement As String, ByVal connectionString As String) As DataTable

        Dim connection As New SqlConnection
        Dim sqlCommand As SqlCommand
        Dim dataAdapter As SqlDataAdapter
        Dim dataTable As New DataTable
        Dim dataString As String = ""
        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing


        Try
            connection.ConnectionString = connectionString
            sqlCommand = New SqlCommand(TheSQLQueryStatement, connection)
            sqlCommand.CommandTimeout = 3000

            dataAdapter = New SqlDataAdapter(sqlCommand)
            dataAdapter.Fill(dataTable)



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally

            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        Return dataTable
    End Function

    'Function getSqlDataReader(ByVal TheSQLQueryStatement As String, ByVal connectionString As String) As BusinessContactInformation
    '    Dim connection As New SqlConnection
    '    Dim sqlCommand As SqlCommand
    '    Dim sqlDataReader As SqlDataReader
    '    Dim businessContactInformation As BusinessContactInformation

    '    Try
    '        connection.ConnectionString = connectionString
    '        sqlCommand = New SqlCommand(TheSQLQueryStatement, connection)
    '        sqlCommand.CommandTimeout = 3000

    '        sqlDataReader = sqlCommand.ExecuteReader


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error")
    '    Finally
    '        If connection.State = ConnectionState.Open Then
    '            connection.Close()
    '        End If
    '    End Try
    '    Return businessContactInformation

    'End Function

    Function getSqlDataSet(ByVal TheSQLQueryStatement As String, ByVal TableName As String, ByVal connectionString As String) As DataSet

        Dim dataAdapter As OleDbDataAdapter
        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing
        Dim dataSet As DataSet = New DataSet()

        connectionString += " Provider=SQLOLEDB;"

        Try


            oleDbConnection = New OleDbConnection(connectionString)
            oleDbCommand = New OleDbCommand(TheSQLQueryStatement, oleDbConnection)
            dataAdapter = New OleDbDataAdapter(oleDbCommand)
            oleDbConnection.Open()
            dataAdapter.Fill(dataSet, TableName)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally

            If oleDbConnection.State = ConnectionState.Open Then
                oleDbConnection.Close()
            End If

        End Try
        Return dataSet
    End Function

    Public Function IntegerScalarOleDbCommand(queryString As String, connectionString As String) As Integer

        Dim integerResult As Integer = Nothing
        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing
        Dim dataSet As DataSet = New DataSet()

        connectionString += " Provider=SQLOLEDB;"

        Try

            oleDbConnection = New OleDbConnection(connectionString)
            oleDbCommand = New OleDbCommand(queryString, oleDbConnection)
            oleDbConnection.Open()
            integerResult = oleDbCommand.ExecuteScalar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally

            If oleDbConnection.State = ConnectionState.Open Then
                oleDbConnection.Close()
            End If

        End Try

        Return integerResult
    End Function
End Class
