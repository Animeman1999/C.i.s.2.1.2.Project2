<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ControlPanelGroupBox = New System.Windows.Forms.GroupBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.TotalNumberOfContactsButton = New System.Windows.Forms.Button()
        Me.AddNewCompanyButton = New System.Windows.Forms.Button()
        Me.SearchByLastNameButton = New System.Windows.Forms.Button()
        Me.SearchByCompanyNameButton = New System.Windows.Forms.Button()
        Me.BrowseListButton = New System.Windows.Forms.Button()
        Me.BrowseDataGridView = New System.Windows.Forms.DataGridView()
        Me.CampanyNameTitle = New System.Windows.Forms.Label()
        Me.LastNameTitle = New System.Windows.Forms.Label()
        Me.FirstNameTitle = New System.Windows.Forms.Label()
        Me.ContactTypeTitle = New System.Windows.Forms.Label()
        Me.PhoneNumberTitle = New System.Windows.Forms.Label()
        Me.PhoneTypeTitle = New System.Windows.Forms.Label()
        Me.Address1Ttile = New System.Windows.Forms.Label()
        Me.Address2Title = New System.Windows.Forms.Label()
        Me.CityTitle = New System.Windows.Forms.Label()
        Me.StateTitle = New System.Windows.Forms.Label()
        Me.PostalCodeTitle = New System.Windows.Forms.Label()
        Me.ContactInfoPanel = New System.Windows.Forms.Panel()
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Address2TextBox7 = New System.Windows.Forms.TextBox()
        Me.Address1TextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTypeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTypeTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.CompnayNameTextBox = New System.Windows.Forms.TextBox()
        Me.EnableEditButton = New System.Windows.Forms.Button()
        Me.SaveAndExitEditingModeButton = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ControlPanelGroupBox.SuspendLayout()
        CType(Me.BrowseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContactInfoPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1805, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(142, 109)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(591, -3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(142, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(518, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Lucida Calligraphy", 26.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TitleLabel.Location = New System.Drawing.Point(727, 26)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(1035, 80)
        Me.TitleLabel.TabIndex = 3
        Me.TitleLabel.Text = "Contact Information Look Up"
        '
        'ControlPanelGroupBox
        '
        Me.ControlPanelGroupBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ControlPanelGroupBox.Controls.Add(Me.SearchButton)
        Me.ControlPanelGroupBox.Controls.Add(Me.SearchTextBox)
        Me.ControlPanelGroupBox.Controls.Add(Me.SearchLabel)
        Me.ControlPanelGroupBox.Controls.Add(Me.TotalNumberOfContactsButton)
        Me.ControlPanelGroupBox.Controls.Add(Me.AddNewCompanyButton)
        Me.ControlPanelGroupBox.Controls.Add(Me.SearchByLastNameButton)
        Me.ControlPanelGroupBox.Controls.Add(Me.SearchByCompanyNameButton)
        Me.ControlPanelGroupBox.Controls.Add(Me.BrowseListButton)
        Me.ControlPanelGroupBox.Location = New System.Drawing.Point(34, 185)
        Me.ControlPanelGroupBox.Name = "ControlPanelGroupBox"
        Me.ControlPanelGroupBox.Size = New System.Drawing.Size(450, 652)
        Me.ControlPanelGroupBox.TabIndex = 4
        Me.ControlPanelGroupBox.TabStop = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.SteelBlue
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.SystemColors.Window
        Me.SearchButton.Location = New System.Drawing.Point(29, 560)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(386, 50)
        Me.SearchButton.TabIndex = 8
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(29, 495)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(386, 37)
        Me.SearchTextBox.TabIndex = 7
        Me.SearchTextBox.Text = "SearchTextBox"
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(32, 436)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(166, 31)
        Me.SearchLabel.TabIndex = 6
        Me.SearchLabel.Text = "SearchLabel"
        '
        'TotalNumberOfContactsButton
        '
        Me.TotalNumberOfContactsButton.BackColor = System.Drawing.Color.SteelBlue
        Me.TotalNumberOfContactsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TotalNumberOfContactsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalNumberOfContactsButton.ForeColor = System.Drawing.SystemColors.Window
        Me.TotalNumberOfContactsButton.Location = New System.Drawing.Point(29, 358)
        Me.TotalNumberOfContactsButton.Name = "TotalNumberOfContactsButton"
        Me.TotalNumberOfContactsButton.Size = New System.Drawing.Size(386, 50)
        Me.TotalNumberOfContactsButton.TabIndex = 5
        Me.TotalNumberOfContactsButton.Text = "Total Number of Contacts"
        Me.TotalNumberOfContactsButton.UseVisualStyleBackColor = False
        '
        'AddNewCompanyButton
        '
        Me.AddNewCompanyButton.BackColor = System.Drawing.Color.SteelBlue
        Me.AddNewCompanyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNewCompanyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewCompanyButton.ForeColor = System.Drawing.SystemColors.Window
        Me.AddNewCompanyButton.Location = New System.Drawing.Point(29, 280)
        Me.AddNewCompanyButton.Name = "AddNewCompanyButton"
        Me.AddNewCompanyButton.Size = New System.Drawing.Size(386, 50)
        Me.AddNewCompanyButton.TabIndex = 4
        Me.AddNewCompanyButton.Text = "Add a New Company"
        Me.AddNewCompanyButton.UseVisualStyleBackColor = False
        '
        'SearchByLastNameButton
        '
        Me.SearchByLastNameButton.BackColor = System.Drawing.Color.SteelBlue
        Me.SearchByLastNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SearchByLastNameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByLastNameButton.ForeColor = System.Drawing.SystemColors.Window
        Me.SearchByLastNameButton.Location = New System.Drawing.Point(29, 202)
        Me.SearchByLastNameButton.Name = "SearchByLastNameButton"
        Me.SearchByLastNameButton.Size = New System.Drawing.Size(386, 50)
        Me.SearchByLastNameButton.TabIndex = 2
        Me.SearchByLastNameButton.Text = "Search By Last Name"
        Me.SearchByLastNameButton.UseVisualStyleBackColor = False
        '
        'SearchByCompanyNameButton
        '
        Me.SearchByCompanyNameButton.BackColor = System.Drawing.Color.SteelBlue
        Me.SearchByCompanyNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SearchByCompanyNameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByCompanyNameButton.ForeColor = System.Drawing.SystemColors.Window
        Me.SearchByCompanyNameButton.Location = New System.Drawing.Point(29, 124)
        Me.SearchByCompanyNameButton.Name = "SearchByCompanyNameButton"
        Me.SearchByCompanyNameButton.Size = New System.Drawing.Size(386, 50)
        Me.SearchByCompanyNameButton.TabIndex = 1
        Me.SearchByCompanyNameButton.Text = "Search By Company Name"
        Me.SearchByCompanyNameButton.UseVisualStyleBackColor = False
        '
        'BrowseListButton
        '
        Me.BrowseListButton.BackColor = System.Drawing.Color.SteelBlue
        Me.BrowseListButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrowseListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseListButton.ForeColor = System.Drawing.SystemColors.Window
        Me.BrowseListButton.Location = New System.Drawing.Point(29, 46)
        Me.BrowseListButton.Name = "BrowseListButton"
        Me.BrowseListButton.Size = New System.Drawing.Size(386, 50)
        Me.BrowseListButton.TabIndex = 0
        Me.BrowseListButton.Text = "Browse List"
        Me.BrowseListButton.UseVisualStyleBackColor = False
        '
        'BrowseDataGridView
        '
        Me.BrowseDataGridView.AllowUserToAddRows = False
        Me.BrowseDataGridView.AllowUserToDeleteRows = False
        Me.BrowseDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.BrowseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BrowseDataGridView.Location = New System.Drawing.Point(522, 185)
        Me.BrowseDataGridView.Name = "BrowseDataGridView"
        Me.BrowseDataGridView.ReadOnly = True
        Me.BrowseDataGridView.RowTemplate.Height = 31
        Me.BrowseDataGridView.Size = New System.Drawing.Size(838, 652)
        Me.BrowseDataGridView.TabIndex = 5
        '
        'CampanyNameTitle
        '
        Me.CampanyNameTitle.AutoSize = True
        Me.CampanyNameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CampanyNameTitle.Location = New System.Drawing.Point(7, 25)
        Me.CampanyNameTitle.Name = "CampanyNameTitle"
        Me.CampanyNameTitle.Size = New System.Drawing.Size(217, 31)
        Me.CampanyNameTitle.TabIndex = 9
        Me.CampanyNameTitle.Text = "Campany Name:"
        Me.CampanyNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LastNameTitle
        '
        Me.LastNameTitle.AutoSize = True
        Me.LastNameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTitle.Location = New System.Drawing.Point(71, 81)
        Me.LastNameTitle.Name = "LastNameTitle"
        Me.LastNameTitle.Size = New System.Drawing.Size(153, 31)
        Me.LastNameTitle.TabIndex = 11
        Me.LastNameTitle.Text = "Last Name:"
        Me.LastNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FirstNameTitle
        '
        Me.FirstNameTitle.AutoSize = True
        Me.FirstNameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTitle.Location = New System.Drawing.Point(69, 137)
        Me.FirstNameTitle.Name = "FirstNameTitle"
        Me.FirstNameTitle.Size = New System.Drawing.Size(155, 31)
        Me.FirstNameTitle.TabIndex = 13
        Me.FirstNameTitle.Text = "First Name:"
        Me.FirstNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactTypeTitle
        '
        Me.ContactTypeTitle.AutoSize = True
        Me.ContactTypeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTypeTitle.Location = New System.Drawing.Point(39, 193)
        Me.ContactTypeTitle.Name = "ContactTypeTitle"
        Me.ContactTypeTitle.Size = New System.Drawing.Size(185, 31)
        Me.ContactTypeTitle.TabIndex = 15
        Me.ContactTypeTitle.Text = "Contact Type:"
        Me.ContactTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneNumberTitle
        '
        Me.PhoneNumberTitle.AutoSize = True
        Me.PhoneNumberTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberTitle.Location = New System.Drawing.Point(21, 249)
        Me.PhoneNumberTitle.Name = "PhoneNumberTitle"
        Me.PhoneNumberTitle.Size = New System.Drawing.Size(203, 31)
        Me.PhoneNumberTitle.TabIndex = 17
        Me.PhoneNumberTitle.Text = "Phone Number:"
        Me.PhoneNumberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PhoneTypeTitle
        '
        Me.PhoneTypeTitle.AutoSize = True
        Me.PhoneTypeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTypeTitle.Location = New System.Drawing.Point(56, 305)
        Me.PhoneTypeTitle.Name = "PhoneTypeTitle"
        Me.PhoneTypeTitle.Size = New System.Drawing.Size(168, 31)
        Me.PhoneTypeTitle.TabIndex = 19
        Me.PhoneTypeTitle.Text = "Phone Type:"
        Me.PhoneTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Address1Ttile
        '
        Me.Address1Ttile.AutoSize = True
        Me.Address1Ttile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address1Ttile.Location = New System.Drawing.Point(80, 361)
        Me.Address1Ttile.Name = "Address1Ttile"
        Me.Address1Ttile.Size = New System.Drawing.Size(144, 31)
        Me.Address1Ttile.TabIndex = 21
        Me.Address1Ttile.Text = "Address 1:"
        Me.Address1Ttile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Address2Title
        '
        Me.Address2Title.AutoSize = True
        Me.Address2Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address2Title.Location = New System.Drawing.Point(80, 417)
        Me.Address2Title.Name = "Address2Title"
        Me.Address2Title.Size = New System.Drawing.Size(144, 31)
        Me.Address2Title.TabIndex = 23
        Me.Address2Title.Text = "Address 2:"
        Me.Address2Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CityTitle
        '
        Me.CityTitle.AutoSize = True
        Me.CityTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTitle.Location = New System.Drawing.Point(154, 473)
        Me.CityTitle.Name = "CityTitle"
        Me.CityTitle.Size = New System.Drawing.Size(70, 31)
        Me.CityTitle.TabIndex = 25
        Me.CityTitle.Text = "City:"
        Me.CityTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StateTitle
        '
        Me.StateTitle.AutoSize = True
        Me.StateTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateTitle.Location = New System.Drawing.Point(138, 529)
        Me.StateTitle.Name = "StateTitle"
        Me.StateTitle.Size = New System.Drawing.Size(86, 31)
        Me.StateTitle.TabIndex = 27
        Me.StateTitle.Text = "State:"
        Me.StateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PostalCodeTitle
        '
        Me.PostalCodeTitle.AutoSize = True
        Me.PostalCodeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostalCodeTitle.Location = New System.Drawing.Point(54, 585)
        Me.PostalCodeTitle.Name = "PostalCodeTitle"
        Me.PostalCodeTitle.Size = New System.Drawing.Size(170, 31)
        Me.PostalCodeTitle.TabIndex = 28
        Me.PostalCodeTitle.Text = "Postal Code:"
        Me.PostalCodeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ContactInfoPanel
        '
        Me.ContactInfoPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ContactInfoPanel.Controls.Add(Me.PostalCodeTextBox)
        Me.ContactInfoPanel.Controls.Add(Me.StateTextBox)
        Me.ContactInfoPanel.Controls.Add(Me.CityTextBox)
        Me.ContactInfoPanel.Controls.Add(Me.Address2TextBox7)
        Me.ContactInfoPanel.Controls.Add(Me.Address1TextBox)
        Me.ContactInfoPanel.Controls.Add(Me.PhoneTypeTextBox)
        Me.ContactInfoPanel.Controls.Add(Me.PhoneNumberTextBox)
        Me.ContactInfoPanel.Controls.Add(Me.ContactTypeTextBox)
        Me.ContactInfoPanel.Controls.Add(Me.FirstNameTextBox)
        Me.ContactInfoPanel.Controls.Add(Me.LastNameTextBox)
        Me.ContactInfoPanel.Controls.Add(Me.CompnayNameTextBox)
        Me.ContactInfoPanel.Controls.Add(Me.FirstNameTitle)
        Me.ContactInfoPanel.Controls.Add(Me.PostalCodeTitle)
        Me.ContactInfoPanel.Controls.Add(Me.CampanyNameTitle)
        Me.ContactInfoPanel.Controls.Add(Me.StateTitle)
        Me.ContactInfoPanel.Controls.Add(Me.LastNameTitle)
        Me.ContactInfoPanel.Controls.Add(Me.CityTitle)
        Me.ContactInfoPanel.Controls.Add(Me.Address2Title)
        Me.ContactInfoPanel.Controls.Add(Me.ContactTypeTitle)
        Me.ContactInfoPanel.Controls.Add(Me.Address1Ttile)
        Me.ContactInfoPanel.Controls.Add(Me.PhoneNumberTitle)
        Me.ContactInfoPanel.Controls.Add(Me.PhoneTypeTitle)
        Me.ContactInfoPanel.Location = New System.Drawing.Point(1385, 185)
        Me.ContactInfoPanel.Name = "ContactInfoPanel"
        Me.ContactInfoPanel.Size = New System.Drawing.Size(770, 652)
        Me.ContactInfoPanel.TabIndex = 30
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(221, 579)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(534, 37)
        Me.PostalCodeTextBox.TabIndex = 40
        '
        'StateTextBox
        '
        Me.StateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateTextBox.Location = New System.Drawing.Point(221, 523)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(534, 37)
        Me.StateTextBox.TabIndex = 39
        '
        'CityTextBox
        '
        Me.CityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(221, 467)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(534, 37)
        Me.CityTextBox.TabIndex = 38
        '
        'Address2TextBox7
        '
        Me.Address2TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address2TextBox7.Location = New System.Drawing.Point(221, 411)
        Me.Address2TextBox7.Name = "Address2TextBox7"
        Me.Address2TextBox7.Size = New System.Drawing.Size(534, 37)
        Me.Address2TextBox7.TabIndex = 37
        '
        'Address1TextBox
        '
        Me.Address1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address1TextBox.Location = New System.Drawing.Point(221, 355)
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.Size = New System.Drawing.Size(534, 37)
        Me.Address1TextBox.TabIndex = 36
        '
        'PhoneTypeTextBox
        '
        Me.PhoneTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTypeTextBox.Location = New System.Drawing.Point(221, 293)
        Me.PhoneTypeTextBox.Name = "PhoneTypeTextBox"
        Me.PhoneTypeTextBox.Size = New System.Drawing.Size(534, 37)
        Me.PhoneTypeTextBox.TabIndex = 35
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(221, 243)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(534, 37)
        Me.PhoneNumberTextBox.TabIndex = 34
        '
        'ContactTypeTextBox
        '
        Me.ContactTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTypeTextBox.Location = New System.Drawing.Point(221, 187)
        Me.ContactTypeTextBox.Name = "ContactTypeTextBox"
        Me.ContactTypeTextBox.Size = New System.Drawing.Size(534, 37)
        Me.ContactTypeTextBox.TabIndex = 33
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(221, 134)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(534, 37)
        Me.FirstNameTextBox.TabIndex = 32
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(221, 75)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(534, 37)
        Me.LastNameTextBox.TabIndex = 31
        '
        'CompnayNameTextBox
        '
        Me.CompnayNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompnayNameTextBox.Location = New System.Drawing.Point(221, 19)
        Me.CompnayNameTextBox.Name = "CompnayNameTextBox"
        Me.CompnayNameTextBox.Size = New System.Drawing.Size(534, 37)
        Me.CompnayNameTextBox.TabIndex = 30
        '
        'EnableEditButton
        '
        Me.EnableEditButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.EnableEditButton.Location = New System.Drawing.Point(1385, 835)
        Me.EnableEditButton.Name = "EnableEditButton"
        Me.EnableEditButton.Size = New System.Drawing.Size(148, 74)
        Me.EnableEditButton.TabIndex = 31
        Me.EnableEditButton.Text = "Edit this Information"
        Me.EnableEditButton.UseVisualStyleBackColor = False
        '
        'SaveAndExitEditingModeButton
        '
        Me.SaveAndExitEditingModeButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.SaveAndExitEditingModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveAndExitEditingModeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAndExitEditingModeButton.Location = New System.Drawing.Point(1529, 835)
        Me.SaveAndExitEditingModeButton.Name = "SaveAndExitEditingModeButton"
        Me.SaveAndExitEditingModeButton.Size = New System.Drawing.Size(281, 54)
        Me.SaveAndExitEditingModeButton.TabIndex = 32
        Me.SaveAndExitEditingModeButton.Text = "Save and Exit Editing"
        Me.SaveAndExitEditingModeButton.UseVisualStyleBackColor = False
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.BackColor = System.Drawing.Color.Pink
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.Location = New System.Drawing.Point(517, 864)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(150, 31)
        Me.ErrorLabel.TabIndex = 33
        Me.ErrorLabel.Text = "ErrorLabel"
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DeleteButton.Location = New System.Drawing.Point(2007, 835)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(148, 74)
        Me.DeleteButton.TabIndex = 34
        Me.DeleteButton.Text = "Delete this Information"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(1876, 835)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(138, 54)
        Me.CancelButton.TabIndex = 35
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(2299, 921)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.SaveAndExitEditingModeButton)
        Me.Controls.Add(Me.EnableEditButton)
        Me.Controls.Add(Me.ContactInfoPanel)
        Me.Controls.Add(Me.BrowseDataGridView)
        Me.Controls.Add(Me.ControlPanelGroupBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ControlPanelGroupBox.ResumeLayout(False)
        Me.ControlPanelGroupBox.PerformLayout()
        CType(Me.BrowseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContactInfoPanel.ResumeLayout(False)
        Me.ContactInfoPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents ControlPanelGroupBox As GroupBox
    Friend WithEvents TotalNumberOfContactsButton As Button
    Friend WithEvents AddNewCompanyButton As Button
    Friend WithEvents SearchByLastNameButton As Button
    Friend WithEvents SearchByCompanyNameButton As Button
    Friend WithEvents BrowseListButton As Button
    Friend WithEvents BrowseDataGridView As DataGridView
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchLabel As Label
    Friend WithEvents CampanyNameTitle As Label
    Friend WithEvents LastNameTitle As Label
    Friend WithEvents FirstNameTitle As Label
    Friend WithEvents ContactTypeTitle As Label
    Friend WithEvents PhoneNumberTitle As Label
    Friend WithEvents PhoneTypeTitle As Label
    Friend WithEvents Address1Ttile As Label
    Friend WithEvents Address2Title As Label
    Friend WithEvents CityTitle As Label
    Friend WithEvents StateTitle As Label
    Friend WithEvents PostalCodeTitle As Label
    Friend WithEvents ContactInfoPanel As Panel
    Friend WithEvents EnableEditButton As Button
    Friend WithEvents CompnayNameTextBox As TextBox
    Friend WithEvents PostalCodeTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Address2TextBox7 As TextBox
    Friend WithEvents Address1TextBox As TextBox
    Friend WithEvents PhoneTypeTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents ContactTypeTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents SaveAndExitEditingModeButton As Button
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents CancelButton As Button
End Class
