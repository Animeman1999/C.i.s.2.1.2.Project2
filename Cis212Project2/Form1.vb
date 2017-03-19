Public Class Form1

    Dim companiesAndEmployeesTables As CompaniesAndEmployeesTables = New CompaniesAndEmployeesTables
    Dim employeesTable As EmployeesTable = New EmployeesTable
    Dim allContactRelatedTables As AllContactRelatedTables = New AllContactRelatedTables
    Dim connectionString As String = "Server=DESKTOP-MBULVCJ\JEFFONE;Integrated Security=SSPI;Database=ScubaDealers;"

    Enum SearchByType
        CompanyName
        LastName
    End Enum

    Dim searchByChosen As SearchByType = SearchByType.CompanyName

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableSearchItems()
        DisableContactInfoLabels()
        SearchTextBox.Text = ""
        ResultsLabel.Text = ""
    End Sub

    Private Sub BrowseListButton_Click(sender As Object, e As EventArgs) Handles BrowseListButton.Click, SearchByCompanyNameButton.Click,
                                                                                 SearchByLastNameButton.Click, AddNewCompanyButton.Click,
                                                                                 TotalNumberOfContactsButton.Click
        Dim buttonSelected As Button = sender

        resetFontsOnButtons()
        buttonSelected.ForeColor = Color.Yellow

        SearchTextBox.Text = ""

        Select Case (buttonSelected.Name)
            Case BrowseListButton.Name
                ResultsLabel.Text = "Last Name List"
                DisableSearchItems()
                BrowseDataGridView.Visible = True
                companiesAndEmployeesTables.FetchBrowseDataSet(connectionString)
                BrowseDataGridView.DataSource = companiesAndEmployeesTables.dataSet.Tables(0)

            Case SearchByCompanyNameButton.Name
                SearchLabel.Text = "Enter Name of Company"
                EnableSeachItems()
                searchByChosen = SearchByType.CompanyName

            Case SearchByLastNameButton.Name
                SearchLabel.Text = "Enter Name of Name"
                EnableSeachItems()
                searchByChosen = SearchByType.LastName

            Case AddNewCompanyButton.Name
                ResultsLabel.Text = "Add a new phone number"
                DisableSearchItems()

            Case TotalNumberOfContactsButton.Name
                ResultsLabel.Text = "Number of contacts"
                SearchLabel.Visible = True
                employeesTable.CreateCount(connectionString)
                SearchLabel.Text = "Number of Contacts: " & employeesTable.contactCount

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
        CompanyNameLabel.Visible = False
        CampanyNameTitle.Visible = False
        LastNameLabel.Visible = False
        LastNameTitle.Visible = False
        FirstNameLabel.Visible = False
        FirstNameTitle.Visible = False
        ContactTypeLabel.Visible = False
        ContactTypeTitle.Visible = False
        PhoneNumberLabel.Visible = False
        PhoneNumberTitle.Visible = False
        PhoneTypeLabel.Visible = False
        PhoneTypeTitle.Visible = False
        Address1Label.Visible = False
        Address1Ttile.Visible = False
        Address2Label.Visible = False
        Address2Title.Visible = False
        CityLabel.Visible = False
        CityTitle.Visible = False
        StateLabel.Visible = False
        StateTitle.Visible = False
        PostalCodeLabel.Visible = False
        PostalCodeTitle.Visible = False
        ContactInfoPanel.Visible = False
    End Sub

    Private Sub EnableContactInfoLabels()
        ContactInfoPanel.Visible = True
        CompanyNameLabel.Visible = True
        CampanyNameTitle.Visible = True
        LastNameLabel.Visible = True
        LastNameTitle.Visible = True
        FirstNameLabel.Visible = True
        FirstNameTitle.Visible = True
        ContactTypeLabel.Visible = True
        ContactTypeTitle.Visible = True
        PhoneNumberLabel.Visible = True
        PhoneNumberTitle.Visible = True
        PhoneTypeLabel.Visible = True
        PhoneTypeTitle.Visible = True
        Address1Label.Visible = True
        Address1Ttile.Visible = True
        Address2Label.Visible = True
        Address2Title.Visible = True
        CityLabel.Visible = True
        CityTitle.Visible = True
        StateLabel.Visible = True
        StateTitle.Visible = True
        PostalCodeLabel.Visible = True
        PostalCodeTitle.Visible = True
    End Sub

    Private Sub BrowseDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BrowseDataGridView.CellClick
        Dim companyId As Integer = BrowseDataGridView.CurrentRow.Cells(3).Value
        allContactRelatedTables.FetchSingleContactInclusiveData(connectionString, companyId)

        EnableContactInfoLabels()

        CompanyNameLabel.Text = allContactRelatedTables.companyName
        LastNameLabel.Text = allContactRelatedTables.lastName
        FirstNameLabel.Text = allContactRelatedTables.firstName
        ContactTypeLabel.Text = allContactRelatedTables.employeeTypesDescription
        PhoneNumberLabel.Text = allContactRelatedTables.phoneNumber
        PhoneTypeLabel.Text = allContactRelatedTables.phoneNumber
        Address1Label.Text = allContactRelatedTables.address1
        Address2Label.Text = allContactRelatedTables.address2
        CityLabel.Text = allContactRelatedTables.city
        StateLabel.Text = allContactRelatedTables.state
        PostalCodeLabel.Text = allContactRelatedTables.postalCode

        'DetailInformatinLabel.Text = BrowseDataGridView.SelectedCells(0).Value.ToString() & " " & BrowseDataGridView.CurrentCell.RowIndex.ToString
        'DetailInformatinLabel.Text += "Cell Value: " & companyId
        'companiesAndEmployeesTables.TestClick(connectionString, companyId)
        'BrowseDataGridView.DataSource = companiesAndEmployeesTables.dataSet.Tables(0)
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        If SearchTextBox.Text.Trim() <> "" Then
            DisableSearchItems()
            BrowseDataGridView.Visible = True
            Select Case (searchByChosen)
                Case SearchByType.CompanyName
                    companiesAndEmployeesTables.FetchCompanyNameDataSet(connectionString, SearchTextBox.Text)
                    BrowseDataGridView.DataSource = companiesAndEmployeesTables.dataSet.Tables(0)
                Case SearchByType.LastName
                    companiesAndEmployeesTables.FetchLastNameDataSet(connectionString, SearchTextBox.Text)
                    BrowseDataGridView.DataSource = companiesAndEmployeesTables.dataSet.Tables(0)
            End Select
        Else
            MsgBox("You must enter text to search by.")

        End If


    End Sub

End Class
