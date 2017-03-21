Public Class Form1

    Dim companiesAndEmployeesTables As CompaniesAndEmployeesTables = New CompaniesAndEmployeesTables
    Dim employeesTable As EmployeesTable = New EmployeesTable
    Dim allContactRelatedTables As AllContactRelatedTables = New AllContactRelatedTables
    Dim connString As String = "Server=DESKTOP-MBULVCJ\JEFFONE;Integrated Security=SSPI;Database=ScubaDealers;"
    Dim editingContactInfo As Boolean = False
    Dim addingNewContact As Boolean = False

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
        EditAddLabel.Text = ""
    End Sub

    Private Sub BrowseListButton_Click(sender As Object, e As EventArgs) Handles BrowseListButton.Click, SearchByCompanyNameButton.Click,
                                                                                 SearchByLastNameButton.Click, AddNewCompanyButton.Click,
                                                                                 TotalNumberOfContactsButton.Click
        Dim buttonSelected As Button = sender

        ErrorLabel.Text = ""
        resetFontColorOnButtons()
        buttonSelected.ForeColor = Color.Yellow

        SearchTextBox.Text = ""

        Select Case (buttonSelected.Name)
            Case BrowseListButton.Name
                DisableSearchItems()
                BrowseDataGridView.Visible = True
                companiesAndEmployeesTables.FetchBrowseDataSet(connString)
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
                Dim allowChangeOfContactInformation As Boolean = True
                ErrorLabel.Text = ""

                If editingContactInfo = True Then
                    If MessageBox.Show("Editing has not been saved and all editing will be lost. Do you wish to continue?", "Loss of Data Warning",
                              MessageBoxButtons.YesNo) = DialogResult.No Then
                        allowChangeOfContactInformation = False
                    End If

                End If
                If allowChangeOfContactInformation = True Then
                    DisableSearchItems()
                    ClearAcontactRelatedATablesInfo()
                    EnableContactInfoLabels()
                    EnableEditingContactInfo()
                    EnableEditingButtions()
                    addingNewContact = True
                    EditAddLabel.Text = "Add New Contact Information"
                End If


            Case TotalNumberOfContactsButton.Name
                SearchLabel.Visible = True
                employeesTable.CreateCount(connString)
                SearchLabel.Text = "Number of Contacts: " & employeesTable.contactCount
                ErrorLabel.Text = employeesTable.ErrorMessage

        End Select

    End Sub

    Private Sub ClearAcontactRelatedATablesInfo()
        CompanyNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        FirstNameTextBox.Text = ""
        ContactTypeTextBox.Text = ""
        PhoneNumberTextBox.Text = ""
        PhoneTypeTextBox.Text = ""
        Address1TextBox.Text = ""
        Address2TextBox7.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        PostalCodeTextBox.Text = ""
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

    Private Sub resetFontColorOnButtons()
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
        EditAddLabel.Visible = True
        ContactInfoPanel.Visible = True
        EnableEditButton.Visible = True
        DeleteButton.Visible = True

    End Sub

    Private Sub DisableEditingContactInfo()
        editingContactInfo = False
        CompanyNameTextBox.ReadOnly = True
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
        CompanyNameTextBox.ReadOnly = False
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

    Private Sub EnableEditingButtions()
        SaveAndExitEditingModeButton.Visible = True
        CancelButton.Visible = True
        EnableEditButton.Visible = False
        DeleteButton.Visible = False
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
            allContactRelatedTables.FetchSingleContactInclusiveData(connString, companyId)
            ErrorLabel.Text = allContactRelatedTables.ErrorMessage

            DisableEditingContactInfo()
            EnableContactInfoLabels()

            UpdateAllContactRelatedInfo()
        End If

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ErrorLabel.Text = ""

        If SearchTextBox.Text.Trim() <> "" Then
            DisableSearchItems()
            BrowseDataGridView.Visible = True
            Select Case (searchByChosen)
                Case SearchByType.CompanyName
                    companiesAndEmployeesTables.FetchCompanyNameDataSet(connString, SearchTextBox.Text)
                    Try
                        BrowseDataGridView.DataSource = companiesAndEmployeesTables.dataSet.Tables(0)
                    Catch ex As Exception
                        ErrorLabel.Text += ex.Message.ToString() & " Error "
                    End Try

                Case SearchByType.LastName
                    companiesAndEmployeesTables.FetchLastNameDataSet(connString, SearchTextBox.Text)
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
        EditAddLabel.Text = "Edit Contact Information"

    End Sub

    Private Sub SaveAndExitEditingModeButton_Click(sender As Object, e As EventArgs) Handles SaveAndExitEditingModeButton.Click
        ErrorLabel.Text = ""



        If CompanyNameTextBox.Text = "" Then
            MsgBox("Need to have a Company Name to save a contact.")
        Else

            If addingNewContact = True Then

                UpdateAllContactRelatedTablesFields()
                allContactRelatedTables.AddNewContact(connString)
                If companiesAndEmployeesTables.CheckIfCompanyInDatabase(connString, CompanyNameTextBox.Text, LastNameTextBox.Text) Then
                    ErrorLabel.Text = "Error could not update database"
                Else
                    addingNewContact = False
                    SaveAndExitEditingModeButton.Visible = False
                    CancelButton.Visible = False
                    ContactInfoPanel.Visible = False
                    DisableEditingContactInfo()
                End If

            Else
                editingContactInfo = False
                SaveAndExitEditingModeButton.Visible = False
                CancelButton.Visible = False
                EnableEditButton.Visible = True
                DeleteButton.Visible = True
                DisableEditingContactInfo()
                UpdateAllContactRelatedTablesFields()
                allContactRelatedTables.UpdateContactInformation(connString)
                ErrorLabel.Text = allContactRelatedTables.ErrorMessage
            End If

            If ErrorLabel.Text = "" Then

                If addingNewContact = True Then
                    MsgBox("New Contact has been added.")
                Else
                        MsgBox("Contact information has been updated.")

                End If
                BrowseDataGridView.Visible = False
            End If

        End If

    End Sub

    Private Sub UpdateAllContactRelatedInfo()
        CompanyNameTextBox.Text = allContactRelatedTables.companyName
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
    Private Sub UpdateAllContactRelatedTablesFields()
        allContactRelatedTables.companyName = CompanyNameTextBox.Text
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

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ErrorLabel.Text = ""
        If MessageBox.Show("All of this contact information will be deleted. Do you wish to continue?", "Loss of Data Warning",
                              MessageBoxButtons.YesNo) = DialogResult.Yes Then
            allContactRelatedTables.DeleteContact(connString)
            ErrorLabel.Text = allContactRelatedTables.ErrorMessage
            If ErrorLabel.Text = "" Then
                MsgBox("Contact information has been deleted.")
                BrowseDataGridView.Visible = False
                ContactInfoPanel.Visible = False
                resetFontColorOnButtons()
                DisableContactInfoLabels()
            End If
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        editingContactInfo = False

        EditAddLabel.Text = ""
        If addingNewContact = True Then
            addingNewContact = False
            ContactInfoPanel.Visible = False
            CancelButton.Visible = False
            SaveAndExitEditingModeButton.Visible = False
            resetFontColorOnButtons()
        Else
            EnableEditingButtions()
            DisableEditingContactInfo()
            UpdateAllContactRelatedInfo()
        End If

    End Sub
End Class
