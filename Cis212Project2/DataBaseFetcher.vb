Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class DataBaseFetcher

    Public ReadOnly Property ErrorMessage As String


    Function getOleDataReader(ByVal queryString As String, ByVal numberOfColums As Integer, ByVal connString As String) As String()

        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing
        Dim oleDataReader As OleDbDataReader = Nothing
        Dim returnString(numberOfColums) As String

        _ErrorMessage = ""
        connString += " Provider=SQLOLEDB;"

        Try
            Dim x As Int16 = 0
            oleDbConnection = New OleDbConnection(connString)
            oleDbCommand = New OleDbCommand(queryString, oleDbConnection)
            oleDbConnection.Open()
            oleDataReader = oleDbCommand.ExecuteReader()
            While oleDataReader.Read()
                For column As Integer = 0 To numberOfColums - 1
                    returnString(column) = oleDataReader(column).ToString()
                Next

            End While

        Catch ex As Exception
            _ErrorMessage = ex.Message.ToString() & " Error "
        Finally

            If oleDbConnection.State = ConnectionState.Open Then
                oleDbConnection.Close()
            End If

        End Try

        Return returnString

    End Function

    Function getOleDataSet(ByVal queryString As String, ByVal TableName As String, ByVal connString As String) As DataSet

        Dim dataAdapter As OleDbDataAdapter
        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing
        Dim dataSet As DataSet = New DataSet()

        _ErrorMessage = ""
        connString += " Provider=SQLOLEDB;"

        Try


            oleDbConnection = New OleDbConnection(connString)
            oleDbCommand = New OleDbCommand(queryString, oleDbConnection)
            dataAdapter = New OleDbDataAdapter(oleDbCommand)
            oleDbConnection.Open()
            dataAdapter.Fill(dataSet, TableName)

        Catch ex As Exception
            _ErrorMessage = ex.Message.ToString() & " Error "
        Finally

            If oleDbConnection.State = ConnectionState.Open Then
                oleDbConnection.Close()
            End If

        End Try
        Return dataSet
    End Function

    Public Function IntegerScalarOleDbCommand(queryString As String, connString As String) As Integer

        Dim integerResult As Integer = Nothing
        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing

        _ErrorMessage = ""
        connString += " Provider=SQLOLEDB;"

        Try

            oleDbConnection = New OleDbConnection(connString)
            oleDbCommand = New OleDbCommand(queryString, oleDbConnection)
            oleDbConnection.Open()
            integerResult = oleDbCommand.ExecuteScalar()

        Catch ex As Exception
            _ErrorMessage = ex.Message.ToString() & " Error "
        Finally

            If oleDbConnection.State = ConnectionState.Open Then
                oleDbConnection.Close()
            End If

        End Try

        Return integerResult
    End Function

    Public Sub CreateOleDbCommand(ByVal queryString As String, ByVal connString As String)
        _ErrorMessage = ""
        connString += " Provider=SQLOLEDB;"

        Try
            Using connection As New OleDbConnection(connString)
                connection.Open()
                Dim command As New OleDbCommand(queryString, connection)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            _ErrorMessage = ex.Message.ToString() & " Error "
        End Try

    End Sub

    Public Function ObjectFoundOleDbCommand(ByVal queryString As String, ByVal connString As String) As Boolean
        _ErrorMessage = ""
        Dim foundBool As Boolean = False

        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing

        connString += " Provider=SQLOLEDB;"

        Try

            oleDbConnection = New OleDbConnection(connString)
            oleDbCommand = New OleDbCommand(queryString, oleDbConnection)
            oleDbConnection.Open()
            foundBool = oleDbCommand.ExecuteNonQuery()

        Catch ex As Exception
            _ErrorMessage = ex.Message.ToString() & " Error "
        Finally

            If oleDbConnection.State = ConnectionState.Open Then
                oleDbConnection.Close()
            End If

        End Try

        Return foundBool
    End Function
End Class
