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
        Me.ResultsLabel = New System.Windows.Forms.Label()
        Me.DetailInformatinLabel = New System.Windows.Forms.Label()
        Me.CompanyNameLabel = New System.Windows.Forms.Label()
        Me.CampanyNameTitle = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.LastNameTitle = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTitle = New System.Windows.Forms.Label()
        Me.ContactTypeLabel = New System.Windows.Forms.Label()
        Me.ContactTypeTitle = New System.Windows.Forms.Label()
        Me.PhoneNumberLabel = New System.Windows.Forms.Label()
        Me.PhoneNumberTitle = New System.Windows.Forms.Label()
        Me.PhoneTypeLabel = New System.Windows.Forms.Label()
        Me.PhoneTypeTitle = New System.Windows.Forms.Label()
        Me.Addres1Label = New System.Windows.Forms.Label()
        Me.Adress1Ttile = New System.Windows.Forms.Label()
        Me.Address2Label = New System.Windows.Forms.Label()
        Me.Address2Title = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.CityTitle = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.StateTitle = New System.Windows.Forms.Label()
        Me.PostalCodeTitle = New System.Windows.Forms.Label()
        Me.PopstalCodeLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ControlPanelGroupBox.SuspendLayout()
        CType(Me.BrowseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1768, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(142, 109)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(579, -3)
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
        Me.ControlPanelGroupBox.Text = "ControlPanelGroupBox"
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
        Me.SearchButton.Text = "SearchButton"
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
        Me.TotalNumberOfContactsButton.Text = "TotalNumberOfContactsButton"
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
        Me.AddNewCompanyButton.Text = "AddNewCompanyButton"
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
        Me.SearchByLastNameButton.Text = "SearchByLastNameButton"
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
        Me.SearchByCompanyNameButton.Text = "SearchByCompanyNameButton"
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
        Me.BrowseListButton.Text = "BrowseListButton"
        Me.BrowseListButton.UseVisualStyleBackColor = False
        '
        'BrowseDataGridView
        '
        Me.BrowseDataGridView.AllowUserToAddRows = False
        Me.BrowseDataGridView.AllowUserToDeleteRows = False
        Me.BrowseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BrowseDataGridView.Location = New System.Drawing.Point(540, 185)
        Me.BrowseDataGridView.Name = "BrowseDataGridView"
        Me.BrowseDataGridView.ReadOnly = True
        Me.BrowseDataGridView.RowTemplate.Height = 31
        Me.BrowseDataGridView.Size = New System.Drawing.Size(838, 652)
        Me.BrowseDataGridView.TabIndex = 5
        '
        'ResultsLabel
        '
        Me.ResultsLabel.AutoSize = True
        Me.ResultsLabel.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ResultsLabel.Location = New System.Drawing.Point(34, 856)
        Me.ResultsLabel.Name = "ResultsLabel"
        Me.ResultsLabel.Size = New System.Drawing.Size(124, 25)
        Me.ResultsLabel.TabIndex = 6
        Me.ResultsLabel.Text = "ResultsLabel"
        '
        'DetailInformatinLabel
        '
        Me.DetailInformatinLabel.AutoSize = True
        Me.DetailInformatinLabel.Location = New System.Drawing.Point(1454, 151)
        Me.DetailInformatinLabel.Name = "DetailInformatinLabel"
        Me.DetailInformatinLabel.Size = New System.Drawing.Size(194, 25)
        Me.DetailInformatinLabel.TabIndex = 7
        Me.DetailInformatinLabel.Text = "DetailInformatinLabel"
        '
        'CompanyNameLabel
        '
        Me.CompanyNameLabel.AutoSize = True
        Me.CompanyNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyNameLabel.Location = New System.Drawing.Point(1768, 221)
        Me.CompanyNameLabel.Name = "CompanyNameLabel"
        Me.CompanyNameLabel.Size = New System.Drawing.Size(268, 31)
        Me.CompanyNameLabel.TabIndex = 8
        Me.CompanyNameLabel.Text = "CompanyNameLabel"
        '
        'CampanyNameTitle
        '
        Me.CampanyNameTitle.AutoSize = True
        Me.CampanyNameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CampanyNameTitle.Location = New System.Drawing.Point(1453, 221)
        Me.CampanyNameTitle.Name = "CampanyNameTitle"
        Me.CampanyNameTitle.Size = New System.Drawing.Size(254, 31)
        Me.CampanyNameTitle.TabIndex = 9
        Me.CampanyNameTitle.Text = "CampanyNameTitle"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLabel.Location = New System.Drawing.Point(1768, 277)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(204, 31)
        Me.LastNameLabel.TabIndex = 10
        Me.LastNameLabel.Text = "LastNameLabel"
        '
        'LastNameTitle
        '
        Me.LastNameTitle.AutoSize = True
        Me.LastNameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTitle.Location = New System.Drawing.Point(1517, 277)
        Me.LastNameTitle.Name = "LastNameTitle"
        Me.LastNameTitle.Size = New System.Drawing.Size(190, 31)
        Me.LastNameTitle.TabIndex = 11
        Me.LastNameTitle.Text = "LastNameTitle"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel.Location = New System.Drawing.Point(1768, 333)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(206, 31)
        Me.FirstNameLabel.TabIndex = 12
        Me.FirstNameLabel.Text = "FirstNameLabel"
        '
        'FirstNameTitle
        '
        Me.FirstNameTitle.AutoSize = True
        Me.FirstNameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTitle.Location = New System.Drawing.Point(1515, 333)
        Me.FirstNameTitle.Name = "FirstNameTitle"
        Me.FirstNameTitle.Size = New System.Drawing.Size(192, 31)
        Me.FirstNameTitle.TabIndex = 13
        Me.FirstNameTitle.Text = "FirstNameTitle"
        '
        'ContactTypeLabel
        '
        Me.ContactTypeLabel.AutoSize = True
        Me.ContactTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTypeLabel.Location = New System.Drawing.Point(1768, 389)
        Me.ContactTypeLabel.Name = "ContactTypeLabel"
        Me.ContactTypeLabel.Size = New System.Drawing.Size(236, 31)
        Me.ContactTypeLabel.TabIndex = 14
        Me.ContactTypeLabel.Text = "ContactTypeLabel"
        '
        'ContactTypeTitle
        '
        Me.ContactTypeTitle.AutoSize = True
        Me.ContactTypeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTypeTitle.Location = New System.Drawing.Point(1485, 389)
        Me.ContactTypeTitle.Name = "ContactTypeTitle"
        Me.ContactTypeTitle.Size = New System.Drawing.Size(222, 31)
        Me.ContactTypeTitle.TabIndex = 15
        Me.ContactTypeTitle.Text = "ContactTypeTitle"
        '
        'PhoneNumberLabel
        '
        Me.PhoneNumberLabel.AutoSize = True
        Me.PhoneNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberLabel.Location = New System.Drawing.Point(1768, 445)
        Me.PhoneNumberLabel.Name = "PhoneNumberLabel"
        Me.PhoneNumberLabel.Size = New System.Drawing.Size(254, 31)
        Me.PhoneNumberLabel.TabIndex = 16
        Me.PhoneNumberLabel.Text = "PhoneNumberLabel"
        '
        'PhoneNumberTitle
        '
        Me.PhoneNumberTitle.AutoSize = True
        Me.PhoneNumberTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberTitle.Location = New System.Drawing.Point(1467, 445)
        Me.PhoneNumberTitle.Name = "PhoneNumberTitle"
        Me.PhoneNumberTitle.Size = New System.Drawing.Size(240, 31)
        Me.PhoneNumberTitle.TabIndex = 17
        Me.PhoneNumberTitle.Text = "PhoneNumberTitle"
        '
        'PhoneTypeLabel
        '
        Me.PhoneTypeLabel.AutoSize = True
        Me.PhoneTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTypeLabel.Location = New System.Drawing.Point(1768, 501)
        Me.PhoneTypeLabel.Name = "PhoneTypeLabel"
        Me.PhoneTypeLabel.Size = New System.Drawing.Size(219, 31)
        Me.PhoneTypeLabel.TabIndex = 18
        Me.PhoneTypeLabel.Text = "PhoneTypeLabel"
        '
        'PhoneTypeTitle
        '
        Me.PhoneTypeTitle.AutoSize = True
        Me.PhoneTypeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTypeTitle.Location = New System.Drawing.Point(1502, 501)
        Me.PhoneTypeTitle.Name = "PhoneTypeTitle"
        Me.PhoneTypeTitle.Size = New System.Drawing.Size(205, 31)
        Me.PhoneTypeTitle.TabIndex = 19
        Me.PhoneTypeTitle.Text = "PhoneTypeTitle"
        '
        'Addres1Label
        '
        Me.Addres1Label.AutoSize = True
        Me.Addres1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addres1Label.Location = New System.Drawing.Point(1768, 557)
        Me.Addres1Label.Name = "Addres1Label"
        Me.Addres1Label.Size = New System.Drawing.Size(181, 31)
        Me.Addres1Label.TabIndex = 20
        Me.Addres1Label.Text = "Addres1Label"
        '
        'Adress1Ttile
        '
        Me.Adress1Ttile.AutoSize = True
        Me.Adress1Ttile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adress1Ttile.Location = New System.Drawing.Point(1541, 557)
        Me.Adress1Ttile.Name = "Adress1Ttile"
        Me.Adress1Ttile.Size = New System.Drawing.Size(166, 31)
        Me.Adress1Ttile.TabIndex = 21
        Me.Adress1Ttile.Text = "Adress1Ttile"
        '
        'Address2Label
        '
        Me.Address2Label.AutoSize = True
        Me.Address2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address2Label.Location = New System.Drawing.Point(1768, 613)
        Me.Address2Label.Name = "Address2Label"
        Me.Address2Label.Size = New System.Drawing.Size(195, 31)
        Me.Address2Label.TabIndex = 22
        Me.Address2Label.Text = "Address2Label"
        '
        'Address2Title
        '
        Me.Address2Title.AutoSize = True
        Me.Address2Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address2Title.Location = New System.Drawing.Point(1526, 613)
        Me.Address2Title.Name = "Address2Title"
        Me.Address2Title.Size = New System.Drawing.Size(181, 31)
        Me.Address2Title.TabIndex = 23
        Me.Address2Title.Text = "Address2Title"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityLabel.Location = New System.Drawing.Point(1768, 669)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(128, 31)
        Me.CityLabel.TabIndex = 24
        Me.CityLabel.Text = "CityLabel"
        '
        'CityTitle
        '
        Me.CityTitle.AutoSize = True
        Me.CityTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTitle.Location = New System.Drawing.Point(1593, 669)
        Me.CityTitle.Name = "CityTitle"
        Me.CityTitle.Size = New System.Drawing.Size(114, 31)
        Me.CityTitle.TabIndex = 25
        Me.CityTitle.Text = "CityTitle"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateLabel.Location = New System.Drawing.Point(1768, 725)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(144, 31)
        Me.StateLabel.TabIndex = 26
        Me.StateLabel.Text = "StateLabel"
        '
        'StateTitle
        '
        Me.StateTitle.AutoSize = True
        Me.StateTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateTitle.Location = New System.Drawing.Point(1577, 725)
        Me.StateTitle.Name = "StateTitle"
        Me.StateTitle.Size = New System.Drawing.Size(130, 31)
        Me.StateTitle.TabIndex = 27
        Me.StateTitle.Text = "StateTitle"
        '
        'PostalCodeTitle
        '
        Me.PostalCodeTitle.AutoSize = True
        Me.PostalCodeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostalCodeTitle.Location = New System.Drawing.Point(1500, 781)
        Me.PostalCodeTitle.Name = "PostalCodeTitle"
        Me.PostalCodeTitle.Size = New System.Drawing.Size(207, 31)
        Me.PostalCodeTitle.TabIndex = 28
        Me.PostalCodeTitle.Text = "PostalCodeTitle"
        '
        'PopstalCodeLabel
        '
        Me.PopstalCodeLabel.AutoSize = True
        Me.PopstalCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopstalCodeLabel.Location = New System.Drawing.Point(1768, 781)
        Me.PopstalCodeLabel.Name = "PopstalCodeLabel"
        Me.PopstalCodeLabel.Size = New System.Drawing.Size(236, 31)
        Me.PopstalCodeLabel.TabIndex = 29
        Me.PopstalCodeLabel.Text = "PopstalCodeLabel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(2059, 921)
        Me.Controls.Add(Me.PopstalCodeLabel)
        Me.Controls.Add(Me.PostalCodeTitle)
        Me.Controls.Add(Me.StateTitle)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityTitle)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.Address2Title)
        Me.Controls.Add(Me.Address2Label)
        Me.Controls.Add(Me.Adress1Ttile)
        Me.Controls.Add(Me.Addres1Label)
        Me.Controls.Add(Me.PhoneTypeTitle)
        Me.Controls.Add(Me.PhoneTypeLabel)
        Me.Controls.Add(Me.PhoneNumberTitle)
        Me.Controls.Add(Me.PhoneNumberLabel)
        Me.Controls.Add(Me.ContactTypeTitle)
        Me.Controls.Add(Me.ContactTypeLabel)
        Me.Controls.Add(Me.FirstNameTitle)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.LastNameTitle)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.CampanyNameTitle)
        Me.Controls.Add(Me.CompanyNameLabel)
        Me.Controls.Add(Me.DetailInformatinLabel)
        Me.Controls.Add(Me.ResultsLabel)
        Me.Controls.Add(Me.BrowseDataGridView)
        Me.Controls.Add(Me.ControlPanelGroupBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PictureBox3)
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
    Friend WithEvents ResultsLabel As Label
    Friend WithEvents DetailInformatinLabel As Label
    Friend WithEvents CompanyNameLabel As Label
    Friend WithEvents CampanyNameTitle As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents LastNameTitle As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents FirstNameTitle As Label
    Friend WithEvents ContactTypeLabel As Label
    Friend WithEvents ContactTypeTitle As Label
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents PhoneNumberTitle As Label
    Friend WithEvents PhoneTypeLabel As Label
    Friend WithEvents PhoneTypeTitle As Label
    Friend WithEvents Addres1Label As Label
    Friend WithEvents Adress1Ttile As Label
    Friend WithEvents Address2Label As Label
    Friend WithEvents Address2Title As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents CityTitle As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents StateTitle As Label
    Friend WithEvents PostalCodeTitle As Label
    Friend WithEvents PopstalCodeLabel As Label
End Class
