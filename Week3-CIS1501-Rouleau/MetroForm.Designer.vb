<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MetroForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.bmiTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.calulateButton = New MetroFramework.Controls.MetroButton()
        Me.exitButton = New MetroFramework.Controls.MetroButton()
        Me.weightTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.heightTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.metricButton = New MetroFramework.Controls.MetroRadioButton()
        Me.imperialButton = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 74)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(233, 415)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.UseSelectable = True
        Me.MetroTabControl1.SelectedTab = MetroTabPage1
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.Controls.Add(Me.bmiTextBox)
        Me.MetroTabPage1.Controls.Add(Me.calulateButton)
        Me.MetroTabPage1.Controls.Add(Me.exitButton)
        Me.MetroTabPage1.Controls.Add(Me.weightTextBox)
        Me.MetroTabPage1.Controls.Add(Me.heightTextBox)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(225, 373)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Calculator"
        Me.MetroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(150, 82)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(32, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "BMI"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(150, 56)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroLabel2.TabIndex = 6
        Me.MetroLabel2.Text = "Weight"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(150, 32)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroLabel1.TabIndex = 7
        Me.MetroLabel1.Text = "Height"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'bmiTextBox
        '
        '
        '
        '
        Me.bmiTextBox.CustomButton.Image = Nothing
        Me.bmiTextBox.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.bmiTextBox.CustomButton.Name = ""
        Me.bmiTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.bmiTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Lime
        Me.bmiTextBox.CustomButton.TabIndex = 1
        Me.bmiTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.bmiTextBox.CustomButton.UseSelectable = True
        Me.bmiTextBox.CustomButton.Visible = False
        Me.bmiTextBox.Lines = New String() {"BMI"}
        Me.bmiTextBox.Location = New System.Drawing.Point(3, 81)
        Me.bmiTextBox.MaxLength = 32767
        Me.bmiTextBox.Name = "bmiTextBox"
        Me.bmiTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.bmiTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.bmiTextBox.SelectedText = ""
        Me.bmiTextBox.SelectionLength = 0
        Me.bmiTextBox.SelectionStart = 0
        Me.bmiTextBox.ShortcutsEnabled = True
        Me.bmiTextBox.Size = New System.Drawing.Size(75, 20)
        Me.bmiTextBox.Style = MetroFramework.MetroColorStyle.Lime
        Me.bmiTextBox.TabIndex = 2
        Me.bmiTextBox.Text = "BMI"
        Me.bmiTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.bmiTextBox.UseSelectable = True
        Me.bmiTextBox.UseStyleColors = True
        Me.bmiTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.bmiTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'calulateButton
        '
        Me.calulateButton.Location = New System.Drawing.Point(3, 125)
        Me.calulateButton.Name = "calulateButton"
        Me.calulateButton.Size = New System.Drawing.Size(75, 51)
        Me.calulateButton.Style = MetroFramework.MetroColorStyle.Lime
        Me.calulateButton.TabIndex = 3
        Me.calulateButton.Text = "Calculate"
        Me.calulateButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.calulateButton.UseSelectable = True
        Me.calulateButton.UseStyleColors = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(150, 125)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(72, 51)
        Me.exitButton.Style = MetroFramework.MetroColorStyle.Lime
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.exitButton.UseSelectable = True
        Me.exitButton.UseStyleColors = True
        '
        'weightTextBox
        '
        '
        '
        '
        Me.weightTextBox.CustomButton.Image = Nothing
        Me.weightTextBox.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.weightTextBox.CustomButton.Name = ""
        Me.weightTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.weightTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Lime
        Me.weightTextBox.CustomButton.TabIndex = 1
        Me.weightTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.weightTextBox.CustomButton.UseSelectable = True
        Me.weightTextBox.CustomButton.Visible = False
        Me.weightTextBox.Lines = New String() {"LBs or KGs"}
        Me.weightTextBox.Location = New System.Drawing.Point(3, 55)
        Me.weightTextBox.MaxLength = 32767
        Me.weightTextBox.Name = "weightTextBox"
        Me.weightTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.weightTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.weightTextBox.SelectedText = ""
        Me.weightTextBox.SelectionLength = 0
        Me.weightTextBox.SelectionStart = 0
        Me.weightTextBox.ShortcutsEnabled = True
        Me.weightTextBox.Size = New System.Drawing.Size(75, 20)
        Me.weightTextBox.Style = MetroFramework.MetroColorStyle.Lime
        Me.weightTextBox.TabIndex = 1
        Me.weightTextBox.Text = "LBs or KGs"
        Me.weightTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.weightTextBox.UseSelectable = True
        Me.weightTextBox.UseStyleColors = True
        Me.weightTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.weightTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'heightTextBox
        '
        '
        '
        '
        Me.heightTextBox.CustomButton.Image = Nothing
        Me.heightTextBox.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.heightTextBox.CustomButton.Name = ""
        Me.heightTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.heightTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Lime
        Me.heightTextBox.CustomButton.TabIndex = 1
        Me.heightTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.heightTextBox.CustomButton.UseSelectable = True
        Me.heightTextBox.CustomButton.Visible = False
        Me.heightTextBox.Lines = New String() {"INs or CMs"}
        Me.heightTextBox.Location = New System.Drawing.Point(3, 29)
        Me.heightTextBox.MaxLength = 32767
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.heightTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.heightTextBox.SelectedText = ""
        Me.heightTextBox.SelectionLength = 0
        Me.heightTextBox.SelectionStart = 0
        Me.heightTextBox.ShortcutsEnabled = True
        Me.heightTextBox.Size = New System.Drawing.Size(75, 20)
        Me.heightTextBox.Style = MetroFramework.MetroColorStyle.Lime
        Me.heightTextBox.TabIndex = 0
        Me.heightTextBox.Text = "INs or CMs"
        Me.heightTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.heightTextBox.UseSelectable = True
        Me.heightTextBox.UseStyleColors = True
        Me.heightTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.heightTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.metricButton)
        Me.MetroTabPage2.Controls.Add(Me.imperialButton)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(225, 373)
        Me.MetroTabPage2.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Settings"
        Me.MetroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'metricButton
        '
        Me.metricButton.AutoSize = True
        Me.metricButton.Location = New System.Drawing.Point(21, 52)
        Me.metricButton.Name = "metricButton"
        Me.metricButton.Size = New System.Drawing.Size(57, 15)
        Me.metricButton.Style = MetroFramework.MetroColorStyle.Lime
        Me.metricButton.TabIndex = 3
        Me.metricButton.Text = "Metric"
        Me.metricButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.metricButton.UseSelectable = True
        '
        'imperialButton
        '
        Me.imperialButton.AutoSize = True
        Me.imperialButton.Checked = True
        Me.imperialButton.Location = New System.Drawing.Point(21, 30)
        Me.imperialButton.Name = "imperialButton"
        Me.imperialButton.Size = New System.Drawing.Size(66, 15)
        Me.imperialButton.Style = MetroFramework.MetroColorStyle.Lime
        Me.imperialButton.TabIndex = 2
        Me.imperialButton.TabStop = True
        Me.imperialButton.Text = "Imperial"
        Me.imperialButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.imperialButton.UseSelectable = True
        '
        'MetroForm
        '
        Me.ClientSize = New System.Drawing.Size(288, 320)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "MetroForm"
        Me.Style = MetroFramework.MetroColorStyle.Lime
        Me.Text = "BMI Calculator"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bmiTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
