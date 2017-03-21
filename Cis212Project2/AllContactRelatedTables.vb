Public Class AllContactRelatedTables

    Private COLUMN_NUMBER As Integer = 14
    Private databaseFetcher As DataBaseFetcher = New DataBaseFetcher
    Private _contactData(COLUMN_NUMBER) As String
    Private _employeeID As String
    Private _phoneID As String
    Private _addressID As String
    Private _companyID As Integer
    Public ReadOnly Property ErrorMessage As String

    Public Property companyName As String = ""
    Public Property lastName As String = ""
    Public Property firstName As String = ""
    Public Property employeeTypesDescription As String = ""
    Public Property phoneNumber As String = ""
    Public Property phoneType As String = ""
    Public Property address1 As String = ""
    Public Property address2 As String = ""
    Public Property city As String = ""
    Public Property state As String = ""
    Public Property postalCode As String = ""


    Public Sub FetchSingleContactInclusiveData(ByVal connectionString As String, ByVal companyId As Integer)
        _ErrorMessage = ""
        _contactData = databaseFetcher.getOleDataReader($"SELECT CompanyName, LastName, FirstName, EmployeeTypes.Description, dbo.Phones.Phone, dbo.PhoneTypes.Description,
                                                        dbo.Addresses.Address1, Address2, City, State, PostalCode, EmployeeID, PhoneID, AddressID
                                                        FROM dbo.Employees JOIN dbo.Companies ON Companies.CompanyID = Employees.CompanyID
                                                        JOIN	dbo.EmployeeTypes ON	EmployeeTypes.EmployeeTypeID = Employees.EmployeeTypeID 
                                                        JOIN dbo.Phones ON	Phones.CompanyID = Companies.CompanyID
                                                        JOIN dbo.PhoneTypes ON PhoneTypes.PhoneTypeID = Phones.PhoneTypeID
                                                        JOIN dbo.Addresses ON Addresses.CompanyID = Companies.CompanyID
                                                        WHERE Companies.CompanyID = {companyId} ORDER BY LastName", COLUMN_NUMBER, connectionString)
        companyName = _contactData(0)
        lastName = _contactData(1)
        firstName = _contactData(2)
        employeeTypesDescription = _contactData(3)
        phoneNumber = _contactData(4)
        phoneType = _contactData(5)
        address1 = _contactData(6)
        address2 = _contactData(7)
        city = _contactData(8)
        state = _contactData(9)
        postalCode = _contactData(10)
        _employeeID = _contactData(11)
        _phoneID = _contactData(12)
        _addressID = _contactData(13)
        _companyID = companyId

        _ErrorMessage = databaseFetcher.ErrorMessage
    End Sub

    Public Sub UpdateContactInformation(ByVal connectionString As String)
        _ErrorMessage = ""
        '_contactData(0) = companyName
        '_contactData(1) = lastName
        '_contactData(2) = firstName
        '_contactData(3) = employeeTypesDescription
        '_contactData(4) = phoneNumber
        '_contactData(5) = phoneType
        '_contactData(6) = address1
        '_contactData(7) = address2
        '_contactData(8) = city
        '_contactData(9) = state
        '_contactData(10) = postalCode

        databaseFetcher.CreateOleDbCommand($"BEGIN TRY
	                                            BEGIN TRANSACTION
		                                            UPDATE dbo.Employees
		                                            SET LastName = '{lastName}', FirstName = '{firstName}',EmployeeTypeID = 1
		                                            WHERE EmployeeID = {_employeeID}

		                                            UPDATE dbo.Companies
		                                            SET CompanyName = '{companyName}'
		                                            WHERE CompanyID = {_companyID}

		                                            UPDATE dbo.Phones
		                                            SET Phone = '{phoneNumber}',PhoneTypeID = 4
		                                            WHERE PhoneID = {_phoneID}

		                                            UPDATE dbo.Addresses
		                                            SET Address1 = '{address1}', Address2 = '{address2}',
			                                            City = '{city}', State = '{state}', PostalCode = '{postalCode}'
		                                            WHERE AddressID = {_addressID}
	                                            COMMIT
                                            END TRY
                                            BEGIN CATCH
	                                            IF @@TRANCOUNT > 0
	                                            ROLLBACK
                                            END CATCH", connectionString)

        _ErrorMessage = databaseFetcher.ErrorMessage
    End Sub

    Public Sub DeleteContact(ByVal connectionString As String)
        _ErrorMessage = ""
        databaseFetcher.CreateOleDbCommand($"BEGIN TRY
	                                            BEGIN TRANSACTION
		                                            DELETE FROM dbo.Employees
		                                            WHERE EmployeeID = {_employeeID}

		                                            DELETE FROM dbo.Companies
		                                            WHERE CompanyID = {_companyID}

		                                            DELETE FROM dbo.Phones
		                                            WHERE PhoneID = {_phoneID}

		                                            DELETE FROM dbo.Addresses
		                                            WHERE AddressID = {_addressID}
	                                            COMMIT
                                            END TRY
                                            BEGIN CATCH
	                                            IF @@TRANCOUNT > 0
	                                            ROLLBACK
                                            END CATCH", connectionString)

        _ErrorMessage = databaseFetcher.ErrorMessage
    End Sub

    Public Sub AddNewContact(ByVal connectionString As String)
        _ErrorMessage = ""

        databaseFetcher.CreateOleDbCommand($"BEGIN TRY
	                                        BEGIN TRANSACTION
		                                        DECLARE @companyId INT
		                                        INSERT INTO dbo.Companies
		                                        VALUES ('{companyName}')
		                                        SET	@companyId = @@Identity
		

		                                        INSERT INTO dbo.Employees
		                                        VALUES (@companyId, 1, '{firstName}', '{lastName}')

		                                        INSERT INTO dbo.Phones
		                                        VALUES (@companyId, 4, '{phoneNumber}')

		                                        INSERT INTO dbo.Addresses
		                                        VALUES (@companyId, 2,'{address1}', '{address2}',
			                                        '{city}', '{state}', '{postalCode}')
	                                        COMMIT
                                        END TRY
                                        BEGIN CATCH
	                                        IF @@TRANCOUNT > 0
	                                        ROLLBACK
                                        END CATCH", connectionString)

        _ErrorMessage = databaseFetcher.ErrorMessage

    End Sub

    Public Sub ClearData()
        companyName = ""
        lastName = ""
        firstName = ""
        employeeTypesDescription = ""
        phoneNumber = ""
        phoneType = ""
        address1 = ""
        city = ""
        state = ""
        postalCode = ""
        _employeeID = ""
        _phoneID = ""
        _addressID = ""
        _companyID = ""
    End Sub

End Class
