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
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ControlPanelGroupBox.SuspendLayout()
        CType(Me.BrowseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Cis212Project2.My.Resources.Resources.arrow_png_27
        Me.PictureBox3.Location = New System.Drawing.Point(1768, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(142, 109)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Cis212Project2.My.Resources.Resources.arrow_png_27___Copy
        Me.PictureBox2.Location = New System.Drawing.Point(579, -3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(142, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cis212Project2.My.Resources.Resources.Logo
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
        Me.SearchButton.Location = New System.Drawing.Point(29, 566)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(386, 50)
        Me.SearchButton.TabIndex = 8
        Me.SearchButton.Text = "SearchButton"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(29, 510)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(386, 37)
        Me.SearchTextBox.TabIndex = 7
        Me.SearchTextBox.Text = "SearchTextBox"
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(32, 460)
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
        Me.TotalNumberOfContactsButton.Location = New System.Drawing.Point(29, 391)
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
        Me.AddNewCompanyButton.Location = New System.Drawing.Point(29, 322)
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
        Me.SearchByLastNameButton.Location = New System.Drawing.Point(29, 220)
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
        Me.SearchByCompanyNameButton.Location = New System.Drawing.Point(29, 151)
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
        Me.BrowseDataGridView.Size = New System.Drawing.Size(730, 652)
        Me.BrowseDataGridView.TabIndex = 5
        '
        'ResultsLabel
        '
        Me.ResultsLabel.AutoSize = True
        Me.ResultsLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.ResultsLabel.Location = New System.Drawing.Point(34, 856)
        Me.ResultsLabel.Name = "ResultsLabel"
        Me.ResultsLabel.Size = New System.Drawing.Size(124, 25)
        Me.ResultsLabel.TabIndex = 6
        Me.ResultsLabel.Text = "ResultsLabel"
        '
        'DetailInformatinLabel
        '
        Me.DetailInformatinLabel.AutoSize = True
        Me.DetailInformatinLabel.Location = New System.Drawing.Point(1401, 185)
        Me.DetailInformatinLabel.Name = "DetailInformatinLabel"
        Me.DetailInformatinLabel.Size = New System.Drawing.Size(194, 25)
        Me.DetailInformatinLabel.TabIndex = 7
        Me.DetailInformatinLabel.Text = "DetailInformatinLabel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(2059, 921)
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
End Class
