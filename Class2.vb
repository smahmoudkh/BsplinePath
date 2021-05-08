Imports Microsoft.VisualBasic

Public Class Class2


    'Imports System.Math


    Inherits System.Windows.Forms.Form

    Dim S(10, 2) As Double
    Dim xk As Integer
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Dim tim As Integer = 0
    Dim x, y, wid, hgt As Integer
    Dim n1, n2 As Integer
    'Dim Linelength As Integer

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.MenuItem
    Friend WithEvents dlgOpenPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSavePicture As System.Windows.Forms.SaveFileDialog
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents TrackBar3 As System.Windows.Forms.TrackBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mnuDataReset As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.MenuItem()
        Me.mnuFileSave = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.mnuDataReset = New System.Windows.Forms.MenuItem()
        Me.dlgOpenPicture = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSavePicture = New System.Windows.Forms.SaveFileDialog()
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileOpen, Me.mnuFileSave})
        Me.MenuItem1.Text = "&File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Index = 0
        Me.mnuFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.mnuFileOpen.Text = "&Open"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Index = 1
        Me.mnuFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.mnuFileSave.Text = "&Save"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDataReset})
        Me.MenuItem2.Text = "&Data"
        '
        'mnuDataReset
        '
        Me.mnuDataReset.Index = 0
        Me.mnuDataReset.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.mnuDataReset.Text = "&Reset"
        '
        'dlgOpenPicture
        '
        Me.dlgOpenPicture.Filter = "Image Files|*.bmp;*.gif;*.jpg;*.jpe*;*.png;*.tif|All Files (*.*)|*.*"
        '
        'dlgSavePicture
        '
        Me.dlgSavePicture.Filter = "Image Files|*.bmp;*.gif;*.jpg;*.jpe*;*.png;*.tif|All Files (*.*)|*.*"
        '
        'picCanvas
        '
        Me.picCanvas.Location = New System.Drawing.Point(0, 0)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(599, 647)
        Me.picCanvas.TabIndex = 0
        Me.picCanvas.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(117, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ترسیم"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(58, 58)
        Me.TrackBar1.Maximum = 50
        Me.TrackBar1.Minimum = 3
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 5
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.Value = 10
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(58, 109)
        Me.TrackBar2.Maximum = 50
        Me.TrackBar2.Minimum = 3
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar2.TabIndex = 6
        Me.TrackBar2.TickFrequency = 10
        Me.TrackBar2.Value = 10
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(85, 27)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(114, 25)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "تساوی طول و عرض"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(45, 28)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(7, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(45, 28)
        Me.TextBox2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "فاصله :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "0"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(96, 48)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(103, 25)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.Text = "ترسیم مسیرخطی"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(82, 79)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(117, 25)
        Me.CheckBox3.TabIndex = 13
        Me.CheckBox3.Text = "ترسیم مسیر نقطه ای"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(11, 27)
        Me.TrackBar3.Minimum = 2
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(120, 45)
        Me.TrackBar3.TabIndex = 2
        Me.TrackBar3.TickFrequency = 2
        Me.TrackBar3.Value = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(192, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 40)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(120, 110)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(79, 25)
        Me.CheckBox4.TabIndex = 15
        Me.CheckBox4.Text = "مسیر قطری"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Controls.Add(Me.TrackBar2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(615, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(210, 195)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "شبکه بندی"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 32)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "نقشه اولیه"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "عرض :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "طول :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(615, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(210, 197)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "کوتاهترین مسیر"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "فاصله :"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(124, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "ترسیم"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.Location = New System.Drawing.Point(123, 63)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 32)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "ترسیم"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.TrackBar3)
        Me.GroupBox3.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(616, 458)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(210, 101)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "منحنی بی-اسپلاین"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 21)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "درجه منحنی"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.Location = New System.Drawing.Point(37, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 32)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "ورود نقشه"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(616, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(209, 57)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "نقشه"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(615, 565)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox5.Size = New System.Drawing.Size(210, 82)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "حرکت"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button7.Location = New System.Drawing.Point(27, 44)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 32)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "توقف"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("B Nazanin", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button6.Location = New System.Drawing.Point(124, 44)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 32)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "حرکت"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(837, 659)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picCanvas)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "ImagePixelator"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_OriginalBitmap As Bitmap
    Private m_CurrentBitmap As Bitmap
    Private m_TempBitmap As Bitmap
    Private m_Gr As Graphics
    Private m_Pen As Pen

    Private m_SelectingArea As Boolean
    Private m_X1 As Integer
    Private m_Y1 As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the initial directory for dialogs.
        Dim init_dir As String = Application.StartupPath
        If init_dir.EndsWith("\bin") Then init_dir = init_dir.Substring(0, init_dir.Length - 4)
        dlgOpenPicture.InitialDirectory = init_dir
        dlgSavePicture.InitialDirectory = init_dir

    End Sub

    ' Let the user open an image file.
    Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        If dlgOpenPicture.ShowDialog() = DialogResult.OK Then
            Try
                Dim bm As New Bitmap(dlgOpenPicture.FileName)
                m_OriginalBitmap = New Bitmap(bm)
                m_CurrentBitmap = New Bitmap(bm)
                m_TempBitmap = New Bitmap(m_CurrentBitmap)
                m_Gr = Graphics.FromImage(m_TempBitmap)

                bm.Dispose()
                picCanvas.Image = m_CurrentBitmap
                dlgSavePicture.InitialDirectory = dlgOpenPicture.FileName

                ' Make the form big enough.
                'Me.ClientSize = New Size(m_OriginalBitmap.Width , m_OriginalBitmap.Height)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    ' Save the current image.
    Private Sub mnuFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click
        If dlgSavePicture.ShowDialog() = DialogResult.OK Then
            Try
                m_CurrentBitmap.Save(dlgSavePicture.FileName)
                dlgOpenPicture.InitialDirectory = dlgSavePicture.FileName
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    ' Restore the original image.
    Private Sub mnuDataReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDataReset.Click
        If m_OriginalBitmap Is Nothing Then Exit Sub
        m_CurrentBitmap = New Bitmap(m_OriginalBitmap)
        picCanvas.Image = m_CurrentBitmap
    End Sub

    ' Start selecting an area.
    Private Sub picCanvas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        ' Make sure we have a picture loaded.
        If m_OriginalBitmap Is Nothing Then Exit Sub

        mnuDataReset.Enabled = False
        m_SelectingArea = True
        m_X1 = e.X
        m_Y1 = e.Y

        ' Make a copy of the current bitmap 
        'and prepare to draw.
        m_TempBitmap = New Bitmap(m_CurrentBitmap)
        m_Gr = Graphics.FromImage(m_TempBitmap)
        m_Pen = New Pen(Color.Yellow)
        m_Pen.DashStyle = Drawing2D.DashStyle.Dash
    End Sub

    ' Continue selecting the area.
    Private Sub picCanvas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        If Not m_SelectingArea Then Exit Sub

        ' Start with the current image.
        m_Gr.DrawImage(m_CurrentBitmap, 0, 0)

        ' Draw the new selection box.
        m_Gr.DrawRectangle(m_Pen, _
            Min(m_X1, e.X), _
            Min(m_Y1, e.Y), _
            Abs(e.X - m_X1), _
            Abs(e.Y - m_Y1))

        ' Display the result.
        picCanvas.Image = m_TempBitmap
    End Sub

    ' Finish selecting the area.
    Private Sub picCanvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        If Not m_SelectingArea Then Exit Sub
        m_SelectingArea = False

        ' Make sure this point is on the picture.
        'Dim x As Integer = e.X
        x = e.X
        If x < 0 Then x = 0
        If x > m_OriginalBitmap.Width - 1 Then x = m_OriginalBitmap.Width - 1

        'Dim y As Integer = e.Y
        y = e.Y
        If y < 0 Then y = 0
        If y > m_OriginalBitmap.Height - 1 Then y = m_OriginalBitmap.Height - 1


        hgt = m_OriginalBitmap.Height - 1
        wid = m_OriginalBitmap.Width - 1

        ' Pixelate the selected area.
        '  PixelateArea( _
        '        Min(m_X1, x), _
        '       Min(m_Y1, y), _
        '       Abs(x - m_X1), _
        '      Abs(y - m_Y1))


        PixelateArea(0, 0, m_OriginalBitmap.Width - 1, m_OriginalBitmap.Height - 1)


        ' We're done drawing for now.
        m_Pen.Dispose()
        m_Gr.Dispose()
        m_TempBitmap.Dispose()

        m_Pen = Nothing
        m_Gr = Nothing
        m_TempBitmap = Nothing

        mnuDataReset.Enabled = True
    End Sub

    ' Pixelate the area.
    Private Sub PixelateArea(ByVal x As Integer, ByVal y As Integer, ByVal wid As Integer, ByVal hgt As Integer)



        '------------------------------------------
        Dim cell_wid As Integer = TrackBar1.Value
        Dim cell_hgt As Integer = TrackBar2.Value

        ' Start with the current image.
        'm_Gr.DrawImage(m_CurrentBitmap, 0, 0)

        ' Make x and y multiples of cell_wid/cell_hgt
        ' from the origin.
        Dim new_x As Integer = cell_wid * Int(x \ cell_wid)
        Dim new_y As Integer = cell_hgt * Int(y \ cell_hgt)
        Dim i, j As Integer
        Dim o1, o2 As Integer

        Dim mymat(cell_wid + CInt(wid / cell_wid), cell_hgt + CInt(hgt / cell_hgt)) As Integer

        ' Pixelate the selected area.
        For x1 As Integer = new_x To x + wid Step cell_wid
            i = i + 1
            j = 0
            For y1 As Integer = new_y To y + hgt Step cell_hgt
                AverageRectangle(x1, y1, cell_wid, cell_hgt)

                'j = j + 1
                'mymat(i, j) = Matrix1(x1, y1, cell_wid, cell_hgt)
                'If mymat(i, j) = 3 Then
                '    o1 = i
                '    o2 = j
                '    Debug.WriteLine(i.ToString & "------start point (i,j)------- " & j.ToString)
                'End If
            Next y1
        Next x1
        ' MsgBox(i.ToString & "  " & j.ToString)

        'Dim k1 As Integer
        ''Dim ave_brush2 As New SolidBrush(Color.FromArgb(255, 255, 0, 0))
        'Dim pen2 As Pen
        'pen2 = New Pen(Color.Salmon, 2)
        'pen2.DashStyle = Drawing2D.DashStyle.DashDot
        '' Dim pen3 As Pen
        '' pen3 = New Pen(c3, controlline)
        ''pen3.DashStyle = Drawing2D.DashStyle.DashDotDot
        'For k1 = 1 To 1
        '    m_Gr.DrawLine(pen2, 1, 1, 50, 50)
        'Next



        '' Set the current bitmap to the result.
        'm_CurrentBitmap = New Bitmap(m_TempBitmap)

        '' Display the result.
        'picCanvas.Image = m_CurrentBitmap


        m_CurrentBitmap = New Bitmap(m_TempBitmap)
        picCanvas.Image = m_CurrentBitmap
        'aaaa(x, y, wid, hgt)
    End Sub
    Private Sub aaaa(ByVal x As Integer, ByVal y As Integer, ByVal wid As Integer, ByVal hgt As Integer)

        Dim x11(n1 * n2), y11(n1 * n2), i, j As Integer
        'Dim x11(100), y11(100), i, j, Linelength As Integer
        '================================= BSPLINE============================
        '=====================================================================
        Dim p(500, 2) As Double ', p0(300, 2)
        'p0 = {{1, 3}, {2, 3}, {2, 2}, {3, 2}, {4, 2}, {5, 2}, {5, 1}, {6, 1}, {6, 0}, {7, 0}, {8, 0}, {9, 0}, {10, 1}}
        'For i = 0 To Linelength
        '    p0(i, 0) = x11(i)
        '    p0(i, 1) = y11(i)
        'Next
        Dim nm, ax, bx, nx, tk As Integer
        'nm = 4
        nm = TrackBar3.Value
        Dim Linelength As Integer = 0
        tk = Linelength 'UBound(p0, 1)
        Debug.WriteLine(tk.ToString & "=tk,     " & (UBound(p, 1)).ToString)

        'For i = 0 To tk + 2 * (nm - 2)
        '    If i <= nm - 3 Then
        '        p(i, 0) = p0(0, 0)
        '        p(i, 1) = p0(0, 1)
        '    ElseIf i > nm - 3 + tk Then
        '        p(i, 0) = p0(tk, 0)
        '        p(i, 1) = p0(tk, 1)
        '    Else
        '        p(i, 0) = p0(i - nm + 2, 0)
        '        p(i, 1) = p0(i - nm + 2, 1)
        '    End If
        'Next

        For i = 0 To tk + 2 * (nm - 2)
            If i <= nm - 2 Then
                p(i, 0) = x11(0)
                p(i, 1) = y11(0)
            ElseIf i > nm - 2 + tk Then
                p(i, 0) = x11(tk)
                p(i, 1) = y11(tk)
            Else
                p(i, 0) = x11(i - nm + 2)
                p(i, 1) = y11(i - nm + 2)
            End If
        Next
        tk = tk + 2 * (nm - 2)
        'For i = 0 To 1
        '    For j = 0 To tk
        '        p(j, i) = p(j, i) * 60
        '    Next
        'Next
        For j = 0 To Linelength
            Debug.WriteLine(x11(j).ToString & "," & y11(j).ToString)
        Next
        Debug.WriteLine("END OF x11 y11")
        For j = 0 To tk
            Debug.WriteLine(p(j, 0).ToString & "," & p(j, 1).ToString)
        Next
        Debug.WriteLine("END OF P")



        ax = 0
        bx = tk + 2 * (nm - 1) - 1
        'bx = tk
        'nx = 200

        Dim h As Double = 0.1 '((bx - ax) / nx)
        nx = CInt((bx - ax + 1) / h) + 1
        Dim t(bx - ax + 1), xi(nx) As Double
        For i = 0 To (bx - ax + 1)
            t(i) = ax + (i)
        Next
        For i = 0 To (nx)
            xi(i) = ax + (i) * h
        Next

        Dim bs(nx, (bx - ax + 1), nm) As Double

        For j = 0 To nx
            For i = 0 To (bx - ax)
                If t(i) <= xi(j) And xi(j) < t(i + 1) Then
                    bs(j, i, 1) = 1
                Else
                    bs(j, i, 1) = 0
                End If
            Next
        Next


        'For j = 0 To nx - 1
        '    m_Gr.DrawLine(pen3, j, CInt(bs(j, 1, 1) * 100), (j + 1), CInt(100 * bs(j + 1, 1, 1)))
        '    'Debug.WriteLine(CInt(bs(j, 1, 1) * 100).ToString & " " & j.ToString)
        'Next
        'm_CurrentBitmap = New Bitmap(m_TempBitmap)
        'picCanvas.Image = m_CurrentBitmap
        '-------k orther basis-------------------------------------
        Dim e As Integer
        For e = 2 To nm
            For j = 0 To nx
                For i = 0 To ((bx - ax) - e + 1)
                    If t(i + e - 1) = t(i) Then
                        bs(j, i, e) = (t(i + e) - xi(j)) / (t(i + e) - t(i + 1)) * bs(j, i + 1, e - 1)
                    ElseIf t(i + e) = t(i + 1) Then
                        bs(j, i, e) = (xi(j) - t(i)) / (t(i + e - 1) - t(i)) * bs(j, i, e - 1)
                    Else
                        bs(j, i, e) = (t(i + e) - xi(j)) / (t(i + e) - t(i + 1)) * bs(j, i + 1, e - 1) + (xi(j) - t(i)) / (t(i + e - 1) - t(i)) * bs(j, i, e - 1)
                    End If
                Next
            Next
        Next


        'For j = 0 To nx - 1
        '    m_Gr.DrawLine(pen3, j, CInt(bs(j, 1, nm) * 100), (j + 1), CInt(100 * bs(j + 1, 1, nm)))
        '    'Debug.WriteLine(CInt(bs(j, 1, nm) * 100).ToString & " " & j.ToString)
        'Next
        'm_CurrentBitmap = New Bitmap(m_TempBitmap)
        'picCanvas.Image = m_CurrentBitmap

        '----------------------Curve-------------------------------------------------

        xk = CInt((tk - nm + 2) / h + 1)
        'Dim S(xk, 2) As Double
        Debug.WriteLine(tk.ToString & " " & xk.ToString & " " & nx.ToString)
        ReDim S(xk + 1, 2)
        For j = 0 To xk   '(size(x,2)-20)
            For i = 0 To tk '(size(t,2)-1)
                S(j, 0) = 0
                S(j, 1) = 0
            Next
        Next
        For j = 0 To xk - 1  '(size(x,2)-20)
            For i = 0 To tk '(size(t,2)-1)
                S(j, 0) = S(j, 0) + p(i, 0) * bs(CInt(j + (nm - 1) / h), i, nm)
                S(j, 1) = S(j, 1) + p(i, 1) * bs(CInt(j + (nm - 1) / h), i, nm)
                'S(j, 0) = S(j, 0) + p(i, 0) * bs(j, i, nm)
                'S(j, 1) = S(j, 1) + p(i, 1) * bs(j, i, nm)
            Next
        Next

        Dim pen3 As Pen
        pen3 = New Pen(Color.Red, 3)
        Dim pen4 As Pen
        pen4 = New Pen(Color.Red, 3)
        'pen4.DashStyle = Drawing2D.DashStyle.DashDot
        Dim cSize2 As Integer = 3
        If CheckBox2.Checked = True Then
            For j = 0 To xk - 2
                m_Gr.DrawLine(pen3, CInt(S(j, 0)), CInt(S(j, 1)), CInt(S(j + 1, 0)), CInt(S(j + 1, 1)))
            Next
        End If
        If CheckBox3.Checked = True Then
            For j = 0 To tk
                m_Gr.DrawEllipse(pen4, CInt(p(j, 0)) - cSize2, CInt(p(j, 1)) - cSize2, 2 * cSize2, 2 * cSize2)
            Next
        End If
        m_CurrentBitmap = New Bitmap(m_TempBitmap)
        picCanvas.Image = m_CurrentBitmap

        '-----------------------------------------------------
        Timer1.Interval = 1
        Timer1.Enabled = True
        Debug.WriteLine(xk.ToString & "=kx ")
    End Sub

    ' Fill this rectangle with the average of its pixel values.
    Private Sub AverageRectangle(ByVal x As Integer, ByVal y As Integer, ByVal wid As Integer, ByVal hgt As Integer)
        ' Make sure we don't exceed the image's bounds.
        If x < 0 Then x = 0
        If x + wid >= m_OriginalBitmap.Width Then
            wid = m_OriginalBitmap.Width - x - 1
        End If
        If wid <= 0 Then Exit Sub

        If y < 0 Then y = 0
        If y + hgt >= m_OriginalBitmap.Height Then
            hgt = m_OriginalBitmap.Height - y - 1
        End If
        If hgt <= 0 Then Exit Sub

        ' Get the total red, green, and blue values.
        Dim clr As Color
        Dim r As Integer
        Dim g As Integer
        Dim b As Integer
        r = 255
        g = 255
        b = 255
        For i As Integer = 0 To hgt - 1
            For j As Integer = 0 To wid - 1
                clr = m_CurrentBitmap.GetPixel(x + j, y + i)
                ' r += clr.R
                ' g += clr.G
                ' b += clr.B
                If clr.R < 150 And clr.G < 150 And clr.B < 150 Then
                    r = 0
                    g = 0
                    b = 0
                End If
                If clr.R > 200 And clr.G < 50 And clr.B < 50 Then
                    r = 255
                    g = 0
                    b = 0
                End If
                If clr.R < 200 And clr.G > 200 And clr.B < 50 Then
                    r = 0
                    g = 255
                    b = 0
                End If
            Next j
        Next i

        ' Calculate the averages.
        '    r \= wid * hgt
        '   g \= wid * hgt
        '  b \= wid * hgt


        ' Set the pixel values.
        Dim ave_brush As New SolidBrush(Color.FromArgb(255, r, g, b))
        m_Gr.FillRectangle(ave_brush, x, y, wid, hgt)
        ave_brush.Dispose()
    End Sub




    Function Matrix1(ByVal x As Integer, ByVal y As Integer, ByVal wid As Integer, ByVal hgt As Integer) As Integer

        ' Private Sub Matrix1(ByVal x As Integer, ByVal y As Integer, ByVal wid As Integer, ByVal hgt As Integer)
        ' Make sure we don't exceed the image's bounds.
        If x < 0 Then x = 0
        If x + wid >= m_OriginalBitmap.Width Then
            wid = m_OriginalBitmap.Width - x - 1
        End If
        If wid <= 0 Then Exit Function

        If y < 0 Then y = 0
        If y + hgt >= m_OriginalBitmap.Height Then
            hgt = m_OriginalBitmap.Height - y - 1
        End If
        If hgt <= 0 Then Exit Function

        ' Get the total red, green, and blue values.
        Dim clr As Color
        Dim M As Integer
        M = 0

        For i As Integer = 0 To hgt - 1
            For j As Integer = 0 To wid - 1
                clr = m_CurrentBitmap.GetPixel(x + j, y + i)
                If clr.R < 150 And clr.G < 150 And clr.B < 150 Then
                    M = 1
                End If
                If clr.R > 200 And clr.G < 50 And clr.B < 50 Then
                    M = -1
                End If
                If clr.R < 200 And clr.G > 200 And clr.B < 50 Then
                    M = 3
                End If
            Next j
        Next i

        Return M

    End Function


    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'reset
        If m_OriginalBitmap Is Nothing Then Exit Sub
        m_CurrentBitmap = New Bitmap(m_OriginalBitmap)
        picCanvas.Image = m_CurrentBitmap
        ' goo
        PixelateArea(0, 0, m_OriginalBitmap.Width - 1, m_OriginalBitmap.Height - 1)
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        If CheckBox1.Checked = True Then
            TrackBar2.Value = TrackBar1.Value
            TextBox2.Text = TrackBar2.Value.ToString
        End If
        TextBox1.Text = TrackBar1.Value.ToString

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.Enabled = False
            TrackBar2.Enabled = False
            TrackBar2.Value = TrackBar1.Value
            TextBox2.Text = TrackBar2.Value.ToString
        Else
            TextBox2.Enabled = True
            TrackBar2.Enabled = True
        End If
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        TextBox2.Text = TrackBar2.Value.ToString
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If tim <= xk - 1 Then
            PictureBox1.Left = CInt(S(xk - tim, 0))
            PictureBox1.Top = CInt(S(xk - tim, 1))
            'PictureBox1.Left = CInt(S(tim, 0))
            'PictureBox1.Top = CInt(S(tim, 1))
            Label3.Text = tim.ToString
        Else
            Timer1.Enabled = False
            tim = 0
        End If
        tim = tim + CInt(xk / 1000) + 1
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If m_OriginalBitmap Is Nothing Then Exit Sub
        m_CurrentBitmap = New Bitmap(m_OriginalBitmap)
        picCanvas.Image = m_CurrentBitmap
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If dlgOpenPicture.ShowDialog() = DialogResult.OK Then
            Try
                Dim bm As New Bitmap(dlgOpenPicture.FileName)
                m_OriginalBitmap = New Bitmap(bm)
                m_CurrentBitmap = New Bitmap(bm)
                m_TempBitmap = New Bitmap(m_CurrentBitmap)
                m_Gr = Graphics.FromImage(m_TempBitmap)

                bm.Dispose()
                picCanvas.Image = m_CurrentBitmap
                dlgSavePicture.InitialDirectory = dlgOpenPicture.FileName

                ' Make the form big enough.
                'Me.ClientSize = New Size(m_OriginalBitmap.Width , m_OriginalBitmap.Height)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cell_wid As Integer = TrackBar1.Value
        Dim cell_hgt As Integer = TrackBar2.Value

        ' Start with the current image.
        'm_Gr.DrawImage(m_CurrentBitmap, 0, 0)

        ' Make x and y multiples of cell_wid/cell_hgt
        ' from the origin.

        'Dim e2 As System.Windows.Forms.MouseEventArgs
        'Dim x As Integer = e2.X
        'If x < 0 Then x = 0
        'If x > m_OriginalBitmap.Width - 1 Then x = m_OriginalBitmap.Width - 1

        'Dim y As Integer = e2.Y
        'If y < 0 Then y = 0
        'If y > m_OriginalBitmap.Height - 1 Then y = m_OriginalBitmap.Height - 1

        Dim new_x As Integer = cell_wid * Int(x \ cell_wid)
        Dim new_y As Integer = cell_hgt * Int(y \ cell_hgt)
        Dim i, j As Integer
        Dim o1, o2 As Integer

        'wid = m_OriginalBitmap.Width - 1
        'hgt = m_OriginalBitmap.Height - 1


        Dim mymat(cell_wid + CInt(wid / cell_wid), cell_hgt + CInt(hgt / cell_hgt)) As Integer

        For x1 As Integer = new_x To x + wid Step cell_wid
            i = i + 1
            j = 0
            For y1 As Integer = new_y To y + hgt Step cell_hgt
                'AverageRectangle(x1, y1, cell_wid, cell_hgt)

                j = j + 1
                mymat(i, j) = Matrix1(x1, y1, cell_wid, cell_hgt)
                If mymat(i, j) = 3 Then
                    o1 = i
                    o2 = j
                    Debug.WriteLine(i.ToString & "------start point (i,j)------- " & j.ToString)
                End If
            Next y1
        Next x1

        'Test -==================================================
        Debug.WriteLine("===================== Start ======================")
        Dim q As New Queue
        q.Enqueue(1)
        'q.Enqueue(10)
        'q.Enqueue(20)
        'dequeue 5

        For Each element As Integer In q
            'Console.WriteLine(element)
            'MsgBox(element)
        Next
        ' While q.Count > 0
        ' q.Dequeue()
        'End While

        'MsgBox()

        '-------------test 2
        '' mymat(20, 20) = -1
        'Dim n1 As Integer = mymat.GetUpperBound(0) + 1
        'Dim n2 As Integer = mymat.GetUpperBound(1) + 1
        n1 = i
        n2 = j
        'n1 = mymat.GetUpperBound(0) + 1
        'n2 = mymat.GetUpperBound(1) + 1
        Dim o As Integer = 1

        Dim b(n1 * n2, 5) As Integer
        Dim nu As Integer
        'Dim nuo As Object
        'nuo = q.Dequeue()
        nu = 1
        Dim dir As Integer(,) = {{1, 0}, {0, -1}, {-1, 0}, {0, 1}, {1, 1}, {1, -1}, {-1, -1}, {-1, 1}}
        '{{0, 1}, {1, 0}, {0, -1}, {-1, 0}}


        b(1, 1) = 1
        b(1, 2) = 0
        b(1, 3) = 1
        b(1, 4) = o1
        b(1, 5) = o2
        Debug.WriteLine("n1=" & n1 & "  n2=" & n2)
        Dim diagCh As Integer
        If CheckBox4.Checked = True Then
            diagCh = 7
        Else
            diagCh = 3
        End If
        While (q.Count > 0)
            nu = DirectCast(q.Dequeue(), Integer)
            'Debug.WriteLine("Change nu=" & nu.ToString)
            For k As Integer = 0 To diagCh '7 '3
                i = dir(k, 0) + b(nu, 4)
                j = dir(k, 1) + b(nu, 5)
                '''''Debug.Write(i.ToString & " " & j.ToString & "")
                'Debug.WriteLine("(i,j)=(" & i.ToString & "," & j.ToString & ")    o=" & o.ToString)
                'For Each element As Integer In q
                '    Debug.WriteLine("q=" & element)
                'Next
                'Debug.WriteLine("nu=" & nu.ToString & "  k=" & k & "  i=" & i & "  j=" & j)
                If i > 0 And j > 0 And i <= n1 And j <= n2 Then
                    If mymat(i, j) < 1 Then


                        o = o + 1
                        b(o, 1) = o
                        b(o, 2) = nu
                        b(o, 3) = 2
                        b(o, 4) = i
                        b(o, 5) = j
                        'Debug.WriteLine(" safhe sefid----------- i=" & i & "  j=" & j)
                        If mymat(i, j) = -1 Then
                            'q=[];
                            q.Clear()
                            'break;
                            'Exit For
                            Exit While
                        End If
                        mymat(i, j) = 2
                        q.Enqueue(o)

                    End If
                End If
                'Debug.WriteLine(mymat(i, j))
            Next
            ' nu = DirectCast(q.Dequeue(), Integer)
            'If nu = 1 Then nu = DirectCast(q.Dequeue(), Integer)
            'Debug.WriteLine("Change nu=" & nu.ToString)
        End While



        Dim f As Integer = o
        Dim x11(n1 * n2), y11(n1 * n2) As Integer
        Dim Linelength As Integer = 0
        'Linelength = 0
        x11(0) = b(o, 4)
        y11(0) = b(o, 5)

        While (f <> 1)
            f = b(f, 2)
            Linelength = Linelength + 1
            x11(Linelength) = b(f, 4)
            y11(Linelength) = b(f, 5)

            Debug.WriteLine(" line=" & Linelength.ToString & " f=" & f.ToString & " x11=" & x11(Linelength) & " y11=" & y11(Linelength))
        End While


        'MsgBox(numbers.GetUpperBound(1))
        'Debug.WriteLine(Linelength.ToString & " " & f.ToString)


        Dim k1 As Integer
        'Dim ave_brush2 As New SolidBrush(Color.FromArgb(255, 255, 0, 0))
        Dim pen2 As Pen
        pen2 = New Pen(Color.Salmon, 2)
        pen2.DashStyle = Drawing2D.DashStyle.DashDot
        Dim pen3 As Pen
        pen3 = New Pen(Color.Blue, 2)
        'pen3.DashStyle = Drawing2D.DashStyle.DashDot
        ' Dim pen3 As Pen
        ' pen3 = New Pen(c3, controlline)
        'pen3.DashStyle = Drawing2D.DashStyle.DashDotDot
        ' Dim x12(50) As Integer = x11 * cell_wid
        Dim size As Integer = x11.GetLength(0)
        ' Dim x12(size),y12(size)

        For i = 0 To size - 1
            x11(i) = x11(i) * cell_wid - CInt(cell_wid / 2)
        Next
        For i = 0 To size - 1
            y11(i) = y11(i) * cell_hgt - CInt(cell_hgt / 2)
        Next


        '------Draw Lines
        Dim Linelength2 As Double
        For k1 = 0 To Linelength - 1
            Linelength2 = Linelength2 + Math.Sqrt((x11(k1 + 1) - x11(k1)) ^ 2 + (y11(k1 + 1) - y11(k1)) ^ 2)
        Next
        Label2.Text = (CInt(100 * Linelength2) / 100).ToString
        If CheckBox2.Checked = True Then
            For k1 = 0 To Linelength - 1
                m_Gr.DrawLine(pen2, x11(k1), y11(k1), x11(k1 + 1), y11(k1 + 1))
            Next
            '-----Draw circles
            Dim cSize As Integer = 3
            'For k1 = 0 To Linelength
            '    m_Gr.DrawEllipse(pen3, x11(k1) - cSize, y11(k1) - cSize, 2 * cSize, 2 * cSize)
            'Next

            m_CurrentBitmap = New Bitmap(m_TempBitmap)
            picCanvas.Image = m_CurrentBitmap
        End If


    End Sub





End Class
