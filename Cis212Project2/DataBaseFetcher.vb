Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class DataBaseFetcher

    Public Property ErrorMessage As String


    Function getOleDataReader(ByVal TheSQLQueryStatement As String, ByVal connectionString As String) As String

        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing
        Dim oleDataReader As OleDbDataReader = Nothing
        Dim returnString As String = ""

        connectionString += " Provider=SQLOLEDB;"

        Try


            oleDbConnection = New OleDbConnection(connectionString)
            oleDbCommand = New OleDbCommand(TheSQLQueryStatement, oleDbConnection)
            oleDbConnection.Open()
            oleDataReader = oleDbCommand.ExecuteReader()
            While oleDataReader.Read()
                returnString += oleDataReader(0).ToString() & Environment.NewLine()
            End While

        Catch ex As Exception
            ErrorMessage = ex.Message.ToString() & " Error"
        Finally

            If oleDbConnection.State = ConnectionState.Open Then
                oleDbConnection.Close()
            End If

        End Try



        Return returnString

    End Function

    Function getOleDataSet(ByVal TheSQLQueryStatement As String, ByVal TableName As String, ByVal connectionString As String) As DataSet

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
            ErrorMessage = ex.Message.ToString() & " Error"
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
            ErrorMessage = ex.Message.ToString() & " Error"
        Finally

            If oleDbConnection.State = ConnectionState.Open Then
                oleDbConnection.Close()
            End If

        End Try

        Return integerResult
    End Function
End Class
