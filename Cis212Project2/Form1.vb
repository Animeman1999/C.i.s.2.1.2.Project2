Public Class Form1

    Dim companiesAndEmployeesTables As CompaniesAndEmployeesTables = New CompaniesAndEmployeesTables
    Dim employeesTable As EmployeesTable = New EmployeesTable
    Dim allContactRelatedTables As AllContactRelatedTables = New AllContactRelatedTables
    Dim connectionString As String = "Server=DESKTOP-MBULVCJ\JEFFONE;Integrated Security=SSPI;Database=ScubaDealers;"
    Dim editingContactInfo As Boolean = False

    Enum SearchByType
        CompanyName
        LastName
    End Enum

    Dim searchByChosen As SearchByType = SearchByType.CompanyName

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableSearchItems()
        DisableContactInfoLabels()
        SearchTextBox.Text = ""
        ErrorLabel.Text = ""
    End Sub

    Private Sub BrowseListButton_Click(sender As Object, e As EventArgs) Handles BrowseListButton.Click, SearchByCompanyNameButton.Click,
                                                                                 SearchByLastNameButton.Click, AddNewCompanyButton.Click,
                                                                                 TotalNumberOfContactsButton.Click
        Dim buttonSelected As Button = sender

        ErrorLabel.Text = ""
        resetFontsOnButtons()
        buttonSelected.ForeColor = Color.Yellow

        SearchTextBox.Text = ""

        Select Case (buttonSelected.Name)
            Case BrowseListButton.Name
                DisableSearchItems()
                BrowseDataGridView.Visible = True
                companiesAndEmployeesTables.FetchBrowseDataSet(connectionString)
                ErrorLabel.Text = companiesAndEmployeesTables.ErrorMessage
                Try
                    BrowseDataGridView.DataSource = companiesAndEmployeesTables.dataSet.Tables(0)
                Catch ex As Exception
                    ErrorLabel.Text += ex.Message.ToString() & " Error "
                End Try



            Case SearchByCompanyNameButton.Name
                SearchLabel.Text = "Enter Name of Company"
                EnableSeachItems()
                searchByChosen = SearchByType.CompanyName

            Case SearchByLastNameButton.Name
                SearchLabel.Text = "Enter Name of Name"
                EnableSeachItems()
                searchByChosen = SearchByType.LastName

            Case AddNewCompanyButton.Name
                DisableSearchItems()

            Case TotalNumberOfContactsButton.Name
                SearchLabel.Visible = True
                employeesTable.CreateCount(connectionString)
                SearchLabel.Text = "Number of Contacts: " & employeesTable.contactCount
                ErrorLabel.Text = employeesTable.ErrorMessage

        End Select

    End Sub


    Private Sub EnableSeachItems()
        SearchLabel.Visible = True
        SearchButton.Visible = True
        SearchTextBox.Visible = True
    End Sub

    Private Sub DisableSearchItems()
        SearchLabel.Visible = False
        SearchButton.Visible = False
        SearchTextBox.Visible = False
        BrowseDataGridView.Visible = False
    End Sub

    Private Sub resetFontsOnButtons()
        BrowseListButton.ForeColor = Color.White
        SearchByCompanyNameButton.ForeColor = Color.White
        SearchByLastNameButton.ForeColor = Color.White
        AddNewCompanyButton.ForeColor = Color.White
        TotalNumberOfContactsButton.ForeColor = Color.White
    End Sub

    Private Sub DisableContactInfoLabels()

        ContactInfoPanel.Visible = False
        EnableEditButton.Visible = False
        DeleteButton.Visible = False
        SaveAndExitEditingModeButton.Visible = False
        CancelButton.Visible = False

    End Sub

    Private Sub EnableContactInfoLabels()
        ContactInfoPanel.Visible = True
        EnableEditButton.Visible = True
        DeleteButton.Visible = True

    End Sub

    Private Sub DisableEditingContactInfo()
        editingContactInfo = False
        CompnayNameTextBox.ReadOnly = True
        LastNameTextBox.ReadOnly = True
        FirstNameTextBox.ReadOnly = True
        ContactTypeTextBox.ReadOnly = True
        PhoneNumberTextBox.ReadOnly = True
        PhoneTypeTextBox.ReadOnly = True
        Address1TextBox.ReadOnly = True
        Address2TextBox7.ReadOnly = True
        CityTextBox.ReadOnly = True
        StateTextBox.ReadOnly = True
        PostalCodeTextBox.ReadOnly = True
    End Sub

    Private Sub EnableEditingContactInfo()

        editingContactInfo = True
        CompnayNameTextBox.ReadOnly = False
        LastNameTextBox.ReadOnly = False
        FirstNameTextBox.ReadOnly = False
        ContactTypeTextBox.ReadOnly = False
        PhoneNumberTextBox.ReadOnly = False
        PhoneTypeTextBox.ReadOnly = False
        Address1TextBox.ReadOnly = False
        Address2TextBox7.ReadOnly = False
        CityTextBox.ReadOnly = False
        StateTextBox.ReadOnly = False
        PostalCodeTextBox.ReadOnly = False
    End Sub

    Private Sub BrowseDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BrowseDataGridView.CellClick
        Dim allowChangeOfContactInformation As Boolean = True
        ErrorLabel.Text = ""

        If editingContactInfo = True Then
            If MessageBox.Show("Editing has not been saved and all editing will be lost. Do you wish to continue?", "Loss of Data Warning",
                              MessageBoxButtons.YesNo) = DialogResult.No Then
                allowChangeOfContactInformation = False
            End If

        End If

        If allowChangeOfContactInformation = True Then
            SaveAndExitEditingModeButton.Visible = False
            CancelButton.Visible = False
            Dim companyId As Integer = BrowseDataGridView.CurrentRow.Cells(3).Value
            allContactRelatedTables.FetchSingleContactInclusiveData(connectionString, companyId)
            ErrorLabel.Text = allContactRelatedTables.ErrorMessage

            DisableEditingContactInfo()
            EnableContactInfoLabels()

            CompnayNameTextBox.Text = allContactRelatedTables.companyName
            LastNameTextBox.Text = allContactRelatedTables.lastName
            FirstNameTextBox.Text = allContactRelatedTables.firstName
            ContactTypeTextBox.Text = allContactRelatedTables.employeeTypesDescription
            PhoneNumberTextBox.Text = allContactRelatedTables.phoneNumber
            PhoneTypeTextBox.Text = allContactRelatedTables.phoneType
            Address1TextBox.Text = allContactRelatedTables.address1
            Address2TextBox7.Text = allContactRelatedTables.address2
            CityTextBox.Text = allContactRelatedTables.city
            StateTextBox.Text = allContactRelatedTables.state
            PostalCodeTextBox.Text = allContactRelatedTables.postalCode
        End If

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ErrorLabel.Text = ""

        If SearchTextBox.Text.Trim() <> "" Then
            DisableSearchItems()
            BrowseDataGridView.Visible = True
            Select Case (searchByChosen)
                Case SearchByType.CompanyName
                    companiesAndEmployeesTables.FetchCompanyNameDataSet(connectionString, SearchTextBox.Text)
                    Try
                        BrowseDataGridView.DataSource = companiesAndEmployeesTables.dataSet.Tables(0)
                    Catch ex As Exception
                        ErrorLabel.Text += ex.Message.ToString() & " Error "
                    End Try

                Case SearchByType.LastName
                    companiesAndEmployeesTables.FetchLastNameDataSet(connectionString, SearchTextBox.Text)
                    Try
                        BrowseDataGridView.DataSource = companiesAndEmployeesTables.dataSet.Tables(0)
                    Catch ex As Exception
                        ErrorLabel.Text += ex.Message.ToString() & " Error "
                    End Try

            End Select
            ErrorLabel.Text += companiesAndEmployeesTables.ErrorMessage
        Else
            MsgBox("You must enter text to search by.")

        End If


    End Sub

    Private Sub EnableEditButton_Click(sender As Object, e As EventArgs) Handles EnableEditButton.Click
        EnableEditingContactInfo()
        SaveAndExitEditingModeButton.Visible = True
        CancelButton.Visible = True
        EnableEditButton.Visible = False
        DeleteButton.Visible = False

    End Sub

    Private Sub SaveAndExitEditingModeButton_Click(sender As Object, e As EventArgs) Handles SaveAndExitEditingModeButton.Click
        ErrorLabel.Text = ""
        editingContactInfo = False
        SaveAndExitEditingModeButton.Visible = False
        CancelButton.Visible = False
        EnableEditButton.Visible = True
        DeleteButton.Visible = True
        DisableEditingContactInfo()
        allContactRelatedTables.companyName = CompnayNameTextBox.Text
        allContactRelatedTables.lastName = LastNameTextBox.Text
        allContactRelatedTables.firstName = FirstNameTextBox.Text
        allContactRelatedTables.employeeTypesDescription = ContactTypeTextBox.Text
        allContactRelatedTables.phoneNumber = PhoneNumberTextBox.Text
        allContactRelatedTables.phoneType = PhoneTypeTextBox.Text
        allContactRelatedTables.address1 = Address1TextBox.Text
        allContactRelatedTables.address2 = Address2TextBox7.Text
        allContactRelatedTables.city = CityTextBox.Text
        allContactRelatedTables.state = StateTextBox.Text
        allContactRelatedTables.postalCode = PostalCodeTextBox.Text
        allContactRelatedTables.UpdateContactInformation(connectionString)
        ErrorLabel.Text = allContactRelatedTables.ErrorMessage
        If ErrorLabel.Text = "" Then
            MsgBox("Contact information has been updated.")
            BrowseDataGridView.Visible = False
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        editingContactInfo = False
        SaveAndExitEditingModeButton.Visible = False
        CancelButton.Visible = False
        EnableEditButton.Visible = True
        DeleteButton.Visible = True
        DisableEditingContactInfo()
        CompnayNameTextBox.Text = allContactRelatedTables.companyName
        LastNameTextBox.Text = allContactRelatedTables.lastName
        FirstNameTextBox.Text = allContactRelatedTables.firstName
        ContactTypeTextBox.Text = allContactRelatedTables.employeeTypesDescription
        PhoneNumberTextBox.Text = allContactRelatedTables.phoneNumber
        PhoneTypeTextBox.Text = allContactRelatedTables.phoneType
        Address1TextBox.Text = allContactRelatedTables.address1
        Address2TextBox7.Text = allContactRelatedTables.address2
        CityTextBox.Text = allContactRelatedTables.city
        StateTextBox.Text = allContactRelatedTables.state
        PostalCodeTextBox.Text = allContactRelatedTables.postalCode
    End Sub
End Class
