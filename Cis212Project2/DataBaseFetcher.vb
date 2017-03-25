'Jeffrey Martin
'CIS 212 Project 2


Imports System.Data.SqlClient
Imports System.Data.OleDb

''' <summary>
''' Class to take SQL Commands and hook up to a database and return a value.
''' These are generic and should work with any OleDataBase
''' </summary>
Public Class DataBaseFetcher

    'CONSTANTS
    Private Const PROVIDER As String = " Provider=SQLOLEDB;"

#Region "Properties"

    'Used to pass back last error message generated in this class
    Public ReadOnly Property ErrorMessage As String

#End Region

#Region "Functions"

    ''' <summary>
    ''' Uses a oleDataReader to fetch the data from a database and returns it as a string.
    ''' </summary>
    ''' <param name="queryString">String</param>
    ''' <param name="numberOfColums">String</param>
    ''' <param name="connString">String</param>
    ''' <returns></returns>
    Function getOleDataReader(ByVal queryString As String, ByVal numberOfColums As Integer, ByVal connString As String) As String()

        'Working Variables
        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing
        Dim oleDataReader As OleDbDataReader = Nothing
        Dim returnString(numberOfColums) As String

        _ErrorMessage = ""
        connString += PROVIDER

        Try

            'Create the connectin and place the data into the reader
            Dim x As Int16 = 0
            oleDbConnection = New OleDbConnection(connString)
            oleDbCommand = New OleDbCommand(queryString, oleDbConnection)
            oleDbConnection.Open()
            oleDataReader = oleDbCommand.ExecuteReader()

            'Take the data out of the reader one line at a time than one collumn at a time and add to the string to be returned.
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

    ''' <summary>
    ''' Get the data from a database and return it as a Dataset.
    ''' </summary>
    ''' <param name="queryString">String</param>
    ''' <param name="TableName">String</param>
    ''' <param name="connString">String</param>
    ''' <returns>DataSet</returns>
    Function getOleDataSet(ByVal queryString As String, ByVal TableName As String, ByVal connString As String) As DataSet

        'Working Variables
        Dim dataAdapter As OleDbDataAdapter
        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing
        Dim dataSet As DataSet = New DataSet()

        _ErrorMessage = ""
        connString += PROVIDER

        Try

            'Create the connection to the database and place the data in the DataSet
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

    ''' <summary>
    ''' Get the data from a database and return it as a Integer Scalar.
    ''' </summary>
    ''' <param name="queryString"></param>
    ''' <param name="connString"></param>
    ''' <returns></returns>
    Public Function IntegerScalarOleDbCommand(queryString As String, connString As String) As Integer

        'Working Variables
        Dim integerResult As Integer = Nothing
        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing

        _ErrorMessage = ""
        connString += PROVIDER

        Try

            'Create the connection to the database and place the results in the integerResult that will be returned.
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


    ''' <summary>
    ''' Search a database and return if found. The queryString sent in needs to be one that will return
    ''' a boolean.
    ''' </summary>
    ''' <param name="queryString">String</param>
    ''' <param name="connString">String</param>
    ''' <returns>Boolean</returns>
    Public Function ObjectFoundOleDbCommand(ByVal queryString As String, ByVal connString As String) As Boolean
        _ErrorMessage = ""
        Dim foundBool As Boolean = False

        Dim oleDbConnection As OleDbConnection = Nothing
        Dim oleDbCommand As OleDbCommand = Nothing

        connString += PROVIDER

        Try

            'Create the connection to the database place the boolean value into foudBool that will be returned.
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

#End Region

#Region "Methods"

    ''' <summary>
    ''' Method to add a new record to a table, delete a record, or update a record.
    ''' </summary>
    ''' <param name="queryString"></param>
    ''' <param name="connString"></param>
    Public Sub CreateOleDbCommand(ByVal queryString As String, ByVal connString As String)
        _ErrorMessage = ""
        connString += PROVIDER

        Try

            'Create the connection to the database
            Using connection As New OleDbConnection(connString)

                connection.Open()
                'Load the command with the SqlQuery and the connection
                Dim command As New OleDbCommand(queryString, connection)
                'Execute the command. This SQL commands  works for every type except for SELECT queries
                command.ExecuteNonQuery()

                'Close the connection
            End Using

        Catch ex As Exception

            _ErrorMessage = ex.Message.ToString() & " Error "

        End Try

    End Sub

#End Region

End Class
