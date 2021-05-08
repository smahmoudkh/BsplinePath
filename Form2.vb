Imports System.Math
Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Public Class Form1
  Inherits System.Windows.Forms.Form
  Dim S(10, 2) As Double
  Dim xk As Integer
  Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
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
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox

  Dim tim As Integer = 0
  Dim x, y, wid, hgt As Integer
  Dim Linelength As Integer = 0
  Dim x11(1), y11(1) As Integer
  Private picture As Image = Image.FromFile("..\car00.png")
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Button8 As System.Windows.Forms.Button
  Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
  Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Private angle As Integer



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
  Friend WithEvents dlgOpenPicture As System.Windows.Forms.OpenFileDialog
  Friend WithEvents dlgSavePicture As System.Windows.Forms.SaveFileDialog
  Public WithEvents picCanvas As System.Windows.Forms.PictureBox
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
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim MainMenu1 As System.Windows.Forms.MainMenu

	
	
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
    Me.Button3 = New System.Windows.Forms.Button()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Button4 = New System.Windows.Forms.Button()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.CheckBox5 = New System.Windows.Forms.CheckBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Button5 = New System.Windows.Forms.Button()
    Me.GroupBox4 = New System.Windows.Forms.GroupBox()
    Me.GroupBox5 = New System.Windows.Forms.GroupBox()
    Me.Button7 = New System.Windows.Forms.Button()
    Me.Button6 = New System.Windows.Forms.Button()
    Me.Button8 = New System.Windows.Forms.Button()
    Me.GroupBox6 = New System.Windows.Forms.GroupBox()
    Me.MenuItem1 = New System.Windows.Forms.MenuItem()
    Me.MenuItem2 = New System.Windows.Forms.MenuItem()
    Me.MenuItem3 = New System.Windows.Forms.MenuItem()
    MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
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
    Me.GroupBox6.SuspendLayout()
    Me.SuspendLayout()
    '
    'MainMenu1
    '
    MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
    MainMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    '
    'MenuItem1
    '
    Me.MenuItem1.Index = 0
    Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3})
    Me.MenuItem1.Text = "File"
    '
    'MenuItem2
    '
    Me.MenuItem2.Index = 0
    Me.MenuItem2.Text = "Save Figure"
    '
    'MenuItem3
    '
    Me.MenuItem3.Index = 1
    Me.MenuItem3.Text = "About"
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
    Me.picCanvas.AccessibleRole = System.Windows.Forms.AccessibleRole.None
    Me.picCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
    Me.picCanvas.Enabled = False
    Me.picCanvas.ErrorImage = Nothing
    Me.picCanvas.InitialImage = Nothing
    Me.picCanvas.Location = New System.Drawing.Point(0, 0)
    Me.picCanvas.Margin = New System.Windows.Forms.Padding(0)
    Me.picCanvas.Name = "picCanvas"
    Me.picCanvas.Size = New System.Drawing.Size(558, 647)
    Me.picCanvas.TabIndex = 0
    Me.picCanvas.TabStop = False
    '
    'Button1
    '
    Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Button1.Location = New System.Drawing.Point(13, 128)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(100, 32)
    Me.Button1.TabIndex = 100
    Me.Button1.Text = "Draw"
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
    Me.TrackBar2.Location = New System.Drawing.Point(59, 96)
    Me.TrackBar2.Maximum = 50
    Me.TrackBar2.Minimum = 3
    Me.TrackBar2.Name = "TrackBar2"
    Me.TrackBar2.Size = New System.Drawing.Size(104, 45)
    Me.TrackBar2.TabIndex = 6
    Me.TrackBar2.TickFrequency = 10
    Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft
    Me.TrackBar2.Value = 10
    '
    'CheckBox1
    '
    Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CheckBox1.AutoSize = True
    Me.CheckBox1.Checked = True
    Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.CheckBox1.Location = New System.Drawing.Point(97, 27)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(143, 17)
    Me.CheckBox1.TabIndex = 7
    Me.CheckBox1.Text = "Equals  width and height"
    Me.CheckBox1.UseVisualStyleBackColor = True
    '
    'TextBox1
    '
    Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.TextBox1.Location = New System.Drawing.Point(187, 58)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(45, 21)
    Me.TextBox1.TabIndex = 8
    '
    'TextBox2
    '
    Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.TextBox2.Location = New System.Drawing.Point(187, 99)
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(45, 21)
    Me.TextBox2.TabIndex = 9
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Label1.Location = New System.Drawing.Point(93, 126)
    Me.Label1.Name = "Label1"
    Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label1.Size = New System.Drawing.Size(47, 13)
    Me.Label1.TabIndex = 10
    Me.Label1.Text = "Length :"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Label2.Location = New System.Drawing.Point(186, 127)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(13, 13)
    Me.Label2.TabIndex = 11
    Me.Label2.Text = "0"
    '
    'CheckBox2
    '
    Me.CheckBox2.AutoSize = True
    Me.CheckBox2.Checked = True
    Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.CheckBox2.Location = New System.Drawing.Point(22, 27)
    Me.CheckBox2.Name = "CheckBox2"
    Me.CheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.CheckBox2.Size = New System.Drawing.Size(99, 17)
    Me.CheckBox2.TabIndex = 12
    Me.CheckBox2.Text = "Draw guide line"
    Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.CheckBox2.UseVisualStyleBackColor = True
    '
    'CheckBox3
    '
    Me.CheckBox3.AutoSize = True
    Me.CheckBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.CheckBox3.Location = New System.Drawing.Point(22, 58)
    Me.CheckBox3.Name = "CheckBox3"
    Me.CheckBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.CheckBox3.Size = New System.Drawing.Size(107, 17)
    Me.CheckBox3.TabIndex = 13
    Me.CheckBox3.Text = "Draw guide point"
    Me.CheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.CheckBox3.UseVisualStyleBackColor = True
    '
    'TrackBar3
    '
    Me.TrackBar3.Location = New System.Drawing.Point(90, 52)
    Me.TrackBar3.Minimum = 2
    Me.TrackBar3.Name = "TrackBar3"
    Me.TrackBar3.Size = New System.Drawing.Size(120, 45)
    Me.TrackBar3.TabIndex = 26
    Me.TrackBar3.TickFrequency = 2
    Me.TrackBar3.TickStyle = System.Windows.Forms.TickStyle.TopLeft
    Me.TrackBar3.Value = 8
    '
    'Timer1
    '
    Me.Timer1.Interval = 30
    '
    'PictureBox1
    '
    Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
    Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PictureBox1.ErrorImage = Nothing
    Me.PictureBox1.InitialImage = Nothing
    Me.PictureBox1.Location = New System.Drawing.Point(-90, -90)
    Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
    Me.PictureBox1.TabIndex = 14
    Me.PictureBox1.TabStop = False
    '
    'CheckBox4
    '
    Me.CheckBox4.AutoSize = True
    Me.CheckBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.CheckBox4.Location = New System.Drawing.Point(22, 89)
    Me.CheckBox4.Name = "CheckBox4"
    Me.CheckBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.CheckBox4.Size = New System.Drawing.Size(92, 17)
    Me.CheckBox4.TabIndex = 15
    Me.CheckBox4.Text = "Diagonal path"
    Me.CheckBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.CheckBox4.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Label3.Location = New System.Drawing.Point(183, 17)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(15, 17)
    Me.Label3.TabIndex = 16
    Me.Label3.Text = "0"
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.Button2)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.TextBox1)
    Me.GroupBox1.Controls.Add(Me.CheckBox1)
    Me.GroupBox1.Controls.Add(Me.Button1)
    Me.GroupBox1.Controls.Add(Me.TrackBar1)
    Me.GroupBox1.Controls.Add(Me.TrackBar2)
    Me.GroupBox1.Controls.Add(Me.TextBox2)
    Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.GroupBox1.Location = New System.Drawing.Point(6, 26)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.GroupBox1.Size = New System.Drawing.Size(251, 160)
    Me.GroupBox1.TabIndex = 17
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Grids"
    '
    'Button2
    '
    Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Button2.Location = New System.Drawing.Point(143, 128)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(90, 32)
    Me.Button2.TabIndex = 12
    Me.Button2.Text = "Reset"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Label5.Location = New System.Drawing.Point(3, 107)
    Me.Label5.Name = "Label5"
    Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label5.Size = New System.Drawing.Size(45, 13)
    Me.Label5.TabIndex = 11
    Me.Label5.Text = "Height :"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Label4.Location = New System.Drawing.Point(3, 58)
    Me.Label4.Name = "Label4"
    Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label4.Size = New System.Drawing.Size(42, 13)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Width :"
    '
    'GroupBox2
    '
    Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox2.Controls.Add(Me.Button3)
    Me.GroupBox2.Controls.Add(Me.CheckBox4)
    Me.GroupBox2.Controls.Add(Me.CheckBox3)
    Me.GroupBox2.Controls.Add(Me.CheckBox2)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.GroupBox2.Location = New System.Drawing.Point(7, 192)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.GroupBox2.Size = New System.Drawing.Size(250, 159)
    Me.GroupBox2.TabIndex = 18
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Shortest path"
    '
    'Button3
    '
    Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Button3.Location = New System.Drawing.Point(12, 120)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(75, 32)
    Me.Button3.TabIndex = 17
    Me.Button3.Text = "Draw"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Label7.Location = New System.Drawing.Point(92, 17)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(41, 13)
    Me.Label7.TabIndex = 18
    Me.Label7.Text = "Angle :"
    '
    'Button4
    '
    Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Button4.Location = New System.Drawing.Point(9, 92)
    Me.Button4.Name = "Button4"
    Me.Button4.Size = New System.Drawing.Size(75, 32)
    Me.Button4.TabIndex = 18
    Me.Button4.Text = "Draw"
    Me.Button4.UseVisualStyleBackColor = True
    '
    'GroupBox3
    '
    Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox3.Controls.Add(Me.Label9)
    Me.GroupBox3.Controls.Add(Me.Label8)
    Me.GroupBox3.Controls.Add(Me.CheckBox5)
    Me.GroupBox3.Controls.Add(Me.Label6)
    Me.GroupBox3.Controls.Add(Me.Button4)
    Me.GroupBox3.Controls.Add(Me.TrackBar3)
    Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.GroupBox3.Location = New System.Drawing.Point(7, 357)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.GroupBox3.Size = New System.Drawing.Size(251, 133)
    Me.GroupBox3.TabIndex = 19
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "B-Spline"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Label9.Location = New System.Drawing.Point(90, 100)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(47, 13)
    Me.Label9.TabIndex = 22
    Me.Label9.Text = "Length :"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Label8.Location = New System.Drawing.Point(183, 100)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(13, 13)
    Me.Label8.TabIndex = 21
    Me.Label8.Text = "0"
    '
    'CheckBox5
    '
    Me.CheckBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CheckBox5.AutoSize = True
    Me.CheckBox5.Checked = True
    Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.CheckBox5.Location = New System.Drawing.Point(75, 25)
    Me.CheckBox5.Name = "CheckBox5"
    Me.CheckBox5.Size = New System.Drawing.Size(83, 17)
    Me.CheckBox5.TabIndex = 20
    Me.CheckBox5.Text = "Draw Curve"
    Me.CheckBox5.UseVisualStyleBackColor = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Label6.Location = New System.Drawing.Point(5, 62)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(65, 13)
    Me.Label6.TabIndex = 19
    Me.Label6.Text = "Curve order"
    '
    'Button5
    '
    Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Button5.Location = New System.Drawing.Point(6, 24)
    Me.Button5.Name = "Button5"
    Me.Button5.Size = New System.Drawing.Size(113, 32)
    Me.Button5.TabIndex = 1
    Me.Button5.Text = "Import map"
    Me.Button5.UseVisualStyleBackColor = True
    '
    'GroupBox4
    '
    Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox4.BackColor = System.Drawing.SystemColors.ControlLight
    Me.GroupBox4.Controls.Add(Me.Button8)
    Me.GroupBox4.Controls.Add(Me.Button7)
    Me.GroupBox4.Controls.Add(Me.Button5)
    Me.GroupBox4.Controls.Add(Me.Button6)
    Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.GroupBox4.Location = New System.Drawing.Point(599, 0)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.GroupBox4.Size = New System.Drawing.Size(265, 105)
    Me.GroupBox4.TabIndex = 1
    Me.GroupBox4.TabStop = False
    Me.GroupBox4.Text = "Main"
    '
    'Button8
    '
    Me.Button8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Button8.Location = New System.Drawing.Point(6, 62)
    Me.Button8.Name = "Button8"
    Me.Button8.Size = New System.Drawing.Size(112, 32)
    Me.Button8.TabIndex = 2
    Me.Button8.Text = "Draw path"
    Me.Button8.UseVisualStyleBackColor = True
    '
    'Button7
    '
    Me.Button7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Button7.Location = New System.Drawing.Point(144, 62)
    Me.Button7.Name = "Button7"
    Me.Button7.Size = New System.Drawing.Size(112, 32)
    Me.Button7.TabIndex = 4
    Me.Button7.Text = "Pause"
    Me.Button7.UseVisualStyleBackColor = True
    '
    'Button6
    '
    Me.Button6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Button6.Location = New System.Drawing.Point(144, 24)
    Me.Button6.Name = "Button6"
    Me.Button6.Size = New System.Drawing.Size(113, 32)
    Me.Button6.TabIndex = 3
    Me.Button6.Text = "Move"
    Me.Button6.UseVisualStyleBackColor = True
    '
    'GroupBox5
    '
    Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox5.Controls.Add(Me.Label7)
    Me.GroupBox5.Controls.Add(Me.Label3)
    Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.GroupBox5.Location = New System.Drawing.Point(7, 496)
    Me.GroupBox5.Name = "GroupBox5"
    Me.GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.GroupBox5.Size = New System.Drawing.Size(251, 40)
    Me.GroupBox5.TabIndex = 22
    Me.GroupBox5.TabStop = False
    Me.GroupBox5.Text = "Move"
    '
    'GroupBox6
    '
    Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox6.Controls.Add(Me.GroupBox5)
    Me.GroupBox6.Controls.Add(Me.GroupBox1)
    Me.GroupBox6.Controls.Add(Me.GroupBox2)
    Me.GroupBox6.Controls.Add(Me.GroupBox3)
    Me.GroupBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.GroupBox6.Location = New System.Drawing.Point(599, 111)
    Me.GroupBox6.Name = "GroupBox6"
    Me.GroupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.GroupBox6.Size = New System.Drawing.Size(264, 542)
    Me.GroupBox6.TabIndex = 23
    Me.GroupBox6.TabStop = False
    Me.GroupBox6.Text = "Sub-list"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
    Me.ClientSize = New System.Drawing.Size(875, 653)
    Me.Controls.Add(Me.GroupBox4)
    Me.Controls.Add(Me.PictureBox1)
    Me.Controls.Add(Me.picCanvas)
    Me.Controls.Add(Me.GroupBox6)
    Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Me.Menu = MainMenu1
    Me.Name = "Form1"
    Me.Text = "Shortest smooth path"
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
    Me.GroupBox5.PerformLayout()
    Me.GroupBox6.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private m_OriginalBitmap As Bitmap
  Private m_CurrentBitmap As Bitmap
  Private m_CurrentBitmap1 As Bitmap
  Private m_CurrentBitmap2 As Bitmap
  Private m_TempBitmap As Bitmap
  Private m_Gr As Graphics
  Private m_Pen As Pen

  Private m_SelectingArea As Boolean
  Private m_X1 As Integer
  Private m_Y1 As Integer

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '' Set the initial directory for dialogs.
    picCanvas.Width = Me.Width - 300


    Dim f As Integer = 8
    Dim fn As String = "tahoma"
    'Dim fn As String = "vazir"

    Me.Label1.Font = setFont(Me.Label1.Font, fn, f)
    Me.Button1.Font = setFont(Me.Button1.Font, fn, f)
    Me.Button6.Font = setFont(Me.Button6.Font, fn, f)
    Me.CheckBox4.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Label3.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.GroupBox1.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Button2.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Label5.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Label4.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.GroupBox2.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Button3.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.GroupBox3.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Label6.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Label7.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Button5.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.GroupBox4.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.GroupBox5.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Button7.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Button6.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.CheckBox5.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Label8.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Button4.Font = setFont(Me.CheckBox4.Font, fn, f)
    Me.Button8.Font = setFont(Me.Button8.Font, fn, f)
    Me.GroupBox6.Font = setFont(Me.Button8.Font, fn, f)


    '-----------------------
  End Sub

  Private Function setFont(ByVal myFont As Font, Optional ByVal fontFamily As String = "", Optional ByVal fontSize As Single = 0) As Font

    If fontFamily = "" Then
      fontFamily = myFont.FontFamily.ToString()
    End If

    If fontSize = 0 Then
      fontSize = myFont.Size
    End If

    Return New Font(fontFamily, fontSize)
  End Function
  Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    picCanvas.Width = Me.Width - 300
  End Sub


  ' Start selecting an area.
  Private Sub picCanvas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
    ' Make sure we have a picture loaded.

    Debug.WriteLine(CStr(CInt(180 / PI * (Atan((-1) / (0))))))
  End Sub

  ' Continue selecting the area.
  Private Sub picCanvas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
    If Not m_SelectingArea Then Exit Sub


  End Sub

  ' Finish selecting the area.
  Private Sub picCanvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
    If Not m_SelectingArea Then Exit Sub
    m_SelectingArea = False

    ' Make sure this point is on the picture.
    Dim x As Integer = e.X
    If x < 0 Then x = 0
    If x > m_OriginalBitmap.Width - 1 Then x = m_OriginalBitmap.Width - 1

    Dim y As Integer = e.Y
    If y < 0 Then y = 0
    If y > m_OriginalBitmap.Height - 1 Then y = m_OriginalBitmap.Height - 1

    PixelateArea()


    ' We're done drawing for now.
    m_Pen.Dispose()
    m_Gr.Dispose()
    m_TempBitmap.Dispose()

    m_Pen = Nothing
    m_Gr = Nothing
    m_TempBitmap = Nothing

  End Sub

  ' Pixelate the area.
  'Private Sub PixelateArea(ByVal x As Integer, ByVal y As Integer, ByVal wid As Integer, ByVal hgt As Integer)
  Private Sub PixelateArea()



    '------------------------------------------
    Dim cell_wid As Integer = TrackBar1.Value
    Dim cell_hgt As Integer = TrackBar2.Value
    m_CurrentBitmap = New Bitmap(m_OriginalBitmap)
    m_Gr = Graphics.FromImage(m_CurrentBitmap)

    ' Start with the current image.

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

      Next y1
    Next x1


    picCanvas.Image = m_CurrentBitmap
    'aaaa(x, y, wid, hgt)
    m_CurrentBitmap1 = m_CurrentBitmap

  End Sub
  Private Sub aaaa()
    'Private Sub aaaa(ByVal x As Integer, ByVal y As Integer, ByVal wid As Integer, ByVal hgt As Integer)
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  a   %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    'bbb(x, y, wid, hgt)



    Dim cell_wid As Integer = TrackBar1.Value
    Dim cell_hgt As Integer = TrackBar2.Value

    '' Start with the current image.

    '' Make x and y multiples of cell_wid/cell_hgt
    '' from the origin.
    Dim new_x As Integer = cell_wid * Int(x \ cell_wid)
    Dim new_y As Integer = cell_hgt * Int(y \ cell_hgt)
    Dim i, j As Integer
    Dim o1, o2 As Integer

    Dim mymat(cell_wid + CInt(wid / cell_wid), cell_hgt + CInt(hgt / cell_hgt)) As Integer
    i = 0
    For x1 As Integer = new_x To x + wid Step cell_wid
      i = i + 1
      j = 0
      For y1 As Integer = new_y To y + hgt Step cell_hgt

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


    For Each element As Integer In q
      'Console.WriteLine(element)
      'MsgBox(element)
    Next

    '-------------test 2
    '' mymat(20, 20) = -1
    Dim n1 As Integer = mymat.GetUpperBound(0) + 1
    Dim n2 As Integer = mymat.GetUpperBound(1) + 1
    n1 = i
    n2 = j

    Dim o As Integer = 1

    Dim b(n1 * n2, 5) As Integer
    Dim nu As Integer

    nu = 1
    Dim dir As Integer(,) = {{1, 0}, {0, -1}, {-1, 0}, {0, 1}, {1, 1}, {1, -1}, {-1, -1}, {-1, 1}}
    '' Just direct     {{0, 1}, {1, 0}, {0, -1}, {-1, 0}}


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
        '''' check values
        'Debug.Write(i.ToString & " " & j.ToString & "")
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
    End While



    Dim f As Integer = o
    'Dim x11(n1 * n2), y11(n1 * n2) As Integer
    ReDim x11(n1 * n2), y11(n1 * n2)
    'Dim Linelength As Integer = 0

    x11(0) = b(o, 4)
    y11(0) = b(o, 5)
    Linelength = 0
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
    pen3 = New Pen(Color.Brown, 3)

    Dim size As Integer = x11.GetLength(0)
    ' Dim x12(size),y12(size)

    For i = 0 To size - 1
      x11(i) = x11(i) * cell_wid - CInt(cell_wid / 2)
    Next
    For i = 0 To size - 1
      y11(i) = y11(i) * cell_hgt - CInt(cell_hgt / 2)
    Next

    m_CurrentBitmap1 = New Bitmap(m_CurrentBitmap)
    m_Gr = Graphics.FromImage(m_CurrentBitmap1)
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
    End If
    '-----Draw circles
    If CheckBox3.Checked = True Then
      Dim cSize As Integer = 3
      For k1 = 0 To Linelength
        m_Gr.DrawEllipse(pen3, x11(k1) - cSize, y11(k1) - cSize, 2 * cSize, 2 * cSize)
      Next
    End If

    picCanvas.Image = m_CurrentBitmap1




  End Sub
  Private Sub bbbb()

    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  b   %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Dim i, j As Integer

    'Dim x11(n1 * n2), y11(n1 * n2) As Integer
    'Dim x11(100), y11(100), Linelength As Integer
    '================================= BSPLINE============================
    '=====================================================================
    Dim p(1000, 2) As Double ', p0(300, 2)
    'p0 = {{1, 3}, {2, 3}, {2, 2}, {3, 2}, {4, 2}, {5, 2}, {5, 1}, {6, 1}, {6, 0}, {7, 0}, {8, 0}, {9, 0}, {10, 1}}
    Dim nm, ax, bx, nx, tk As Integer
    'nm = 4
    nm = TrackBar3.Value
    tk = Linelength 'UBound(p0, 1)
    Debug.WriteLine(tk.ToString & "=tk,     " & (UBound(p, 1)).ToString)


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

    '----------------------Curve-------------------------------------------------

    xk = CInt((tk - nm + 2) / h + 1)

    Debug.WriteLine("tk=" & tk.ToString & " xk=" & xk.ToString & " nk=" & nx.ToString)
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
      Next
    Next

    Dim pen3 As Pen
    pen3 = New Pen(Color.Blue, 1)
    m_CurrentBitmap2 = New Bitmap(m_CurrentBitmap1)
    m_Gr = Graphics.FromImage(m_CurrentBitmap2)
    Dim Linelength3 As Double

    Dim cSize2 As Integer = 3
    If CheckBox5.Checked = True Then
      For j = 0 To xk - 2
        m_Gr.DrawLine(pen3, CInt(S(j, 0)), CInt(S(j, 1)), CInt(S(j + 1, 0)), CInt(S(j + 1, 1)))
        Linelength3 = Linelength3 + Math.Sqrt((CInt(S(j + 1, 0)) - CInt(S(j, 0))) ^ 2 + (CInt(S(j + 1, 1)) - CInt(S(j, 1))) ^ 2)
      Next
    End If

    Label8.Text = (CInt(Linelength3 * 100) / 100).ToString

    picCanvas.Image = m_CurrentBitmap2


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
        If clr.R < 75 And clr.G < 75 And clr.B > 200 Then
          r = 0
          g = 0
          b = 255
        End If
        If clr.R > 200 And clr.G < 50 And clr.B < 50 Then
          r = 255
          g = 0
          b = 0
        End If
        If clr.R < 50 And clr.G > 170 And clr.B < 80 Then
          r = 0
          g = 255
          b = 0
        End If
      Next j
    Next i

    ' Set the pixel values.
    If r <> 255 Or g <> 255 Or b <> 255 Then
      Dim ave_brush As New SolidBrush(Color.FromArgb(255, r, g, b))
      m_Gr.FillRectangle(ave_brush, x, y, wid, hgt)
      ave_brush.Dispose()
    End If

  End Sub




  Function Matrix1(ByVal x As Integer, ByVal y As Integer, ByVal wid As Integer, ByVal hgt As Integer) As Integer

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
        If clr.R < 75 And clr.G < 75 And clr.B > 200 Then
          M = 1
        End If
        If clr.R > 200 And clr.G < 50 And clr.B < 50 Then
          M = -1
        End If
        If clr.R < 50 And clr.G > 170 And clr.B < 80 Then
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
    wid = m_OriginalBitmap.Width - 1
    hgt = m_OriginalBitmap.Height - 1
    PixelateArea()
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

    PictureBox1.Parent = picCanvas
    'maketransparent()
    PictureBox1.BackColor = Color.Transparent

    If tim <= xk - 1 Then
      Me.angle = CInt(180 / PI * (Atan((S(xk - tim, 1) - S(xk - tim - 1, 1)) / (S(xk - tim, 0) - S(xk - tim - 1, 0)))))

      If (S(xk - tim, 0) - S(xk - tim - 1, 0)) < 0 Then
        If Me.angle <> 90 Then
          Me.angle = Me.angle + 180
        End If
      End If
      If Me.angle = 0 Or Me.angle = 180 Then
        If (S(xk - tim, 0) - S(xk - tim - 1, 0)) > 0 Then
          Me.angle = 0
        ElseIf (S(xk - tim, 0) - S(xk - tim - 1, 0)) < 0 Then
          Me.angle = 180
        End If
      End If
      If Me.angle = 90 Or Me.angle = 270 Then
        If (S(xk - tim, 1) - S(xk - tim - 1, 1)) > 0 Then
          Me.angle = 90
        ElseIf (S(xk - tim, 1) - S(xk - tim - 1, 1)) < 0 Then
          Me.angle = 270
        End If
      End If

      Me.angle = Me.angle + 90

      PictureBox1.Left = CInt(S(xk - tim, 0)) - PictureBox1.Width \ 2
      PictureBox1.Top = CInt(S(xk - tim, 1)) - PictureBox1.Height \ 2

      Label3.Text = CStr(Me.angle)   'tim.ToString
    Else
      Timer1.Enabled = False
      tim = 0
    End If
    tim = tim + CInt(xk / 1000) + 1
  End Sub

  Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles PictureBox1.Paint


    With e.Graphics
      'Move the origin to the centre of the PictureBox.
      .TranslateTransform(Me.PictureBox1.Width \ 2, Me.PictureBox1.Height \ 2)
      '.TranslateTransform(0, 0)

      'Rotate the world.
      .RotateTransform(Me.angle)

      'Draw the image so its centre coincides with the origin.
      .DrawImage(Me.picture, -Me.picture.Width \ 2, -Me.picture.Height \ 2)

    End With

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
    aaaa()
  End Sub

  Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    bbbb()
  End Sub

  Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
    '-----------------------------------------------------
    'Timer1.Interval = 1
    Timer1.Enabled = True
    Debug.WriteLine(xk.ToString & "=kx ")
  End Sub

  Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
    Timer1.Enabled = False
  End Sub


  Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
    If m_OriginalBitmap Is Nothing Then Exit Sub
    m_CurrentBitmap = New Bitmap(m_OriginalBitmap)
    picCanvas.Image = m_CurrentBitmap
    ' goo
    'PixelateArea(0, 0, m_OriginalBitmap.Width - 1, m_OriginalBitmap.Height - 1)
    wid = m_OriginalBitmap.Width - 1
    hgt = m_OriginalBitmap.Height - 1
    PixelateArea()

    m_CurrentBitmap = New Bitmap(m_OriginalBitmap)
    picCanvas.Image = m_CurrentBitmap

    aaaa()
    bbbb()


  End Sub

  Private Sub mnuDataReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub

  Private Sub mnuFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub

  Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub

  Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
    If dlgSavePicture.ShowDialog() = DialogResult.OK Then
      Try
        m_CurrentBitmap2.Save(dlgSavePicture.FileName)
        dlgOpenPicture.InitialDirectory = dlgSavePicture.FileName
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try
    End If
  End Sub

  Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
    MessageBox.Show("This project find shortest path through obstacles for an autonomous movement. For instance, since an atonomus needs to counitious in speed and acceleration, it needs to a continuous derivative path of order 2 and 3 (C2, C3) to can move. Therefore, this program joint the Quadtree algorithm with the B-spline curve algorithm.", "About This program")

  End Sub


  Private Sub picCanvas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCanvas.Click

  End Sub
End Class
