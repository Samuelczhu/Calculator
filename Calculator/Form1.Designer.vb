<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblTop = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAngleMode = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.lblAnsDisplay = New System.Windows.Forms.Label()
        Me.tblMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.btnLeftParen = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRightParen = New System.Windows.Forms.Button()
        Me.btnAbs = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btnFact = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.tblBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.Button42 = New System.Windows.Forms.Button()
        Me.btnPow10 = New System.Windows.Forms.Button()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAC = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblTop.SuspendLayout()
        Me.tblMiddle.SuspendLayout()
        Me.tblBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 688)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tblTop, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tblMiddle, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tblBottom, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(686, 682)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tblTop
        '
        Me.tblTop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblTop.BackColor = System.Drawing.Color.SteelBlue
        Me.tblTop.ColumnCount = 1
        Me.tblTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTop.Controls.Add(Me.lblAngleMode, 0, 0)
        Me.tblTop.Controls.Add(Me.tbInput, 0, 1)
        Me.tblTop.Controls.Add(Me.lblAnsDisplay, 0, 2)
        Me.tblTop.Location = New System.Drawing.Point(3, 2)
        Me.tblTop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblTop.Name = "tblTop"
        Me.tblTop.RowCount = 3
        Me.tblTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTop.Size = New System.Drawing.Size(680, 132)
        Me.tblTop.TabIndex = 0
        '
        'lblAngleMode
        '
        Me.lblAngleMode.AutoSize = True
        Me.lblAngleMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngleMode.ForeColor = System.Drawing.Color.White
        Me.lblAngleMode.Location = New System.Drawing.Point(3, 0)
        Me.lblAngleMode.Name = "lblAngleMode"
        Me.lblAngleMode.Size = New System.Drawing.Size(170, 29)
        Me.lblAngleMode.TabIndex = 0
        Me.lblAngleMode.Text = "Mode: Radian"
        '
        'tbInput
        '
        Me.tbInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInput.Location = New System.Drawing.Point(3, 32)
        Me.tbInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(674, 45)
        Me.tbInput.TabIndex = 1
        '
        'lblAnsDisplay
        '
        Me.lblAnsDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnsDisplay.AutoSize = True
        Me.lblAnsDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnsDisplay.ForeColor = System.Drawing.Color.White
        Me.lblAnsDisplay.Location = New System.Drawing.Point(677, 93)
        Me.lblAnsDisplay.Name = "lblAnsDisplay"
        Me.lblAnsDisplay.Size = New System.Drawing.Size(0, 39)
        Me.lblAnsDisplay.TabIndex = 2
        '
        'tblMiddle
        '
        Me.tblMiddle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblMiddle.ColumnCount = 6
        Me.tblMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tblMiddle.Controls.Add(Me.Button12, 5, 1)
        Me.tblMiddle.Controls.Add(Me.btnLeftParen, 2, 0)
        Me.tblMiddle.Controls.Add(Me.btnRight, 1, 0)
        Me.tblMiddle.Controls.Add(Me.btnLeft, 0, 0)
        Me.tblMiddle.Controls.Add(Me.btnRightParen, 3, 0)
        Me.tblMiddle.Controls.Add(Me.btnAbs, 4, 0)
        Me.tblMiddle.Controls.Add(Me.btnPower, 5, 0)
        Me.tblMiddle.Controls.Add(Me.btnSqrt, 0, 1)
        Me.tblMiddle.Controls.Add(Me.btnFact, 1, 1)
        Me.tblMiddle.Controls.Add(Me.Button10, 2, 1)
        Me.tblMiddle.Controls.Add(Me.Button11, 3, 1)
        Me.tblMiddle.Controls.Add(Me.Button18, 4, 1)
        Me.tblMiddle.Controls.Add(Me.Button19, 0, 2)
        Me.tblMiddle.Controls.Add(Me.Button20, 1, 2)
        Me.tblMiddle.Controls.Add(Me.Button21, 2, 2)
        Me.tblMiddle.Controls.Add(Me.Button22, 3, 2)
        Me.tblMiddle.Controls.Add(Me.Button23, 4, 2)
        Me.tblMiddle.Controls.Add(Me.Button24, 5, 2)
        Me.tblMiddle.Controls.Add(Me.Button25, 0, 3)
        Me.tblMiddle.Controls.Add(Me.Button26, 1, 3)
        Me.tblMiddle.Controls.Add(Me.Button27, 2, 3)
        Me.tblMiddle.Controls.Add(Me.Button28, 3, 3)
        Me.tblMiddle.Controls.Add(Me.Button29, 4, 3)
        Me.tblMiddle.Controls.Add(Me.Button30, 5, 3)
        Me.tblMiddle.Location = New System.Drawing.Point(3, 138)
        Me.tblMiddle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblMiddle.Name = "tblMiddle"
        Me.tblMiddle.RowCount = 4
        Me.tblMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblMiddle.Size = New System.Drawing.Size(680, 268)
        Me.tblMiddle.TabIndex = 1
        '
        'Button12
        '
        Me.Button12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button12.AutoSize = True
        Me.Button12.BackColor = System.Drawing.Color.ForestGreen
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button12.Location = New System.Drawing.Point(568, 69)
        Me.Button12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(109, 63)
        Me.Button12.TabIndex = 14
        Me.Button12.Text = "e"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'btnLeftParen
        '
        Me.btnLeftParen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLeftParen.AutoSize = True
        Me.btnLeftParen.BackColor = System.Drawing.Color.ForestGreen
        Me.btnLeftParen.FlatAppearance.BorderSize = 0
        Me.btnLeftParen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeftParen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeftParen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLeftParen.Location = New System.Drawing.Point(229, 2)
        Me.btnLeftParen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLeftParen.Name = "btnLeftParen"
        Me.btnLeftParen.Size = New System.Drawing.Size(107, 63)
        Me.btnLeftParen.TabIndex = 6
        Me.btnLeftParen.Text = "("
        Me.btnLeftParen.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRight.AutoSize = True
        Me.btnRight.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRight.FlatAppearance.BorderSize = 0
        Me.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRight.Location = New System.Drawing.Point(116, 2)
        Me.btnRight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(107, 63)
        Me.btnRight.TabIndex = 5
        Me.btnRight.Text = "→"
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'btnLeft
        '
        Me.btnLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLeft.AutoSize = True
        Me.btnLeft.BackColor = System.Drawing.Color.ForestGreen
        Me.btnLeft.FlatAppearance.BorderSize = 0
        Me.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLeft.Location = New System.Drawing.Point(3, 2)
        Me.btnLeft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(107, 63)
        Me.btnLeft.TabIndex = 4
        Me.btnLeft.Text = "←"
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'btnRightParen
        '
        Me.btnRightParen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRightParen.AutoSize = True
        Me.btnRightParen.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRightParen.FlatAppearance.BorderSize = 0
        Me.btnRightParen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRightParen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRightParen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRightParen.Location = New System.Drawing.Point(342, 2)
        Me.btnRightParen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRightParen.Name = "btnRightParen"
        Me.btnRightParen.Size = New System.Drawing.Size(107, 63)
        Me.btnRightParen.TabIndex = 3
        Me.btnRightParen.Text = ")"
        Me.btnRightParen.UseVisualStyleBackColor = False
        '
        'btnAbs
        '
        Me.btnAbs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbs.AutoSize = True
        Me.btnAbs.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAbs.FlatAppearance.BorderSize = 0
        Me.btnAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbs.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAbs.Location = New System.Drawing.Point(455, 2)
        Me.btnAbs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbs.Name = "btnAbs"
        Me.btnAbs.Size = New System.Drawing.Size(107, 63)
        Me.btnAbs.TabIndex = 9
        Me.btnAbs.Text = "abs"
        Me.btnAbs.UseVisualStyleBackColor = False
        '
        'btnPower
        '
        Me.btnPower.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPower.AutoSize = True
        Me.btnPower.BackColor = System.Drawing.Color.ForestGreen
        Me.btnPower.FlatAppearance.BorderSize = 0
        Me.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPower.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPower.Location = New System.Drawing.Point(568, 2)
        Me.btnPower.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(109, 63)
        Me.btnPower.TabIndex = 10
        Me.btnPower.Text = "^"
        Me.btnPower.UseVisualStyleBackColor = False
        '
        'btnSqrt
        '
        Me.btnSqrt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSqrt.AutoSize = True
        Me.btnSqrt.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSqrt.FlatAppearance.BorderSize = 0
        Me.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSqrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSqrt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSqrt.Location = New System.Drawing.Point(3, 69)
        Me.btnSqrt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(107, 63)
        Me.btnSqrt.TabIndex = 15
        Me.btnSqrt.Text = "√"
        Me.btnSqrt.UseVisualStyleBackColor = False
        '
        'btnFact
        '
        Me.btnFact.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFact.AutoSize = True
        Me.btnFact.BackColor = System.Drawing.Color.ForestGreen
        Me.btnFact.FlatAppearance.BorderSize = 0
        Me.btnFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFact.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFact.Location = New System.Drawing.Point(116, 69)
        Me.btnFact.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFact.Name = "btnFact"
        Me.btnFact.Size = New System.Drawing.Size(107, 63)
        Me.btnFact.TabIndex = 17
        Me.btnFact.Text = "x!"
        Me.btnFact.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.AutoSize = True
        Me.Button10.BackColor = System.Drawing.Color.ForestGreen
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button10.Location = New System.Drawing.Point(229, 69)
        Me.Button10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(107, 63)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "log"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.AutoSize = True
        Me.Button11.BackColor = System.Drawing.Color.ForestGreen
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button11.Location = New System.Drawing.Point(342, 69)
        Me.Button11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(107, 63)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "ln"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button18.AutoSize = True
        Me.Button18.BackColor = System.Drawing.Color.ForestGreen
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Marlett", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button18.Location = New System.Drawing.Point(455, 69)
        Me.Button18.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(107, 63)
        Me.Button18.TabIndex = 20
        Me.Button18.Text = "π"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button19.AutoSize = True
        Me.Button19.BackColor = System.Drawing.Color.ForestGreen
        Me.Button19.FlatAppearance.BorderSize = 0
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button19.Location = New System.Drawing.Point(3, 136)
        Me.Button19.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(107, 63)
        Me.Button19.TabIndex = 21
        Me.Button19.Text = "sin"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button20.AutoSize = True
        Me.Button20.BackColor = System.Drawing.Color.ForestGreen
        Me.Button20.FlatAppearance.BorderSize = 0
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button20.Location = New System.Drawing.Point(116, 136)
        Me.Button20.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(107, 63)
        Me.Button20.TabIndex = 22
        Me.Button20.Text = "cos"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button21.AutoSize = True
        Me.Button21.BackColor = System.Drawing.Color.ForestGreen
        Me.Button21.FlatAppearance.BorderSize = 0
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button21.Location = New System.Drawing.Point(229, 136)
        Me.Button21.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(107, 63)
        Me.Button21.TabIndex = 23
        Me.Button21.Text = "tan"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button22.AutoSize = True
        Me.Button22.BackColor = System.Drawing.Color.ForestGreen
        Me.Button22.FlatAppearance.BorderSize = 0
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button22.Location = New System.Drawing.Point(342, 136)
        Me.Button22.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(107, 63)
        Me.Button22.TabIndex = 24
        Me.Button22.Text = "asin"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button23.AutoSize = True
        Me.Button23.BackColor = System.Drawing.Color.ForestGreen
        Me.Button23.FlatAppearance.BorderSize = 0
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button23.Location = New System.Drawing.Point(455, 136)
        Me.Button23.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(107, 63)
        Me.Button23.TabIndex = 25
        Me.Button23.Text = "acos"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button24.AutoSize = True
        Me.Button24.BackColor = System.Drawing.Color.ForestGreen
        Me.Button24.FlatAppearance.BorderSize = 0
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button24.Location = New System.Drawing.Point(568, 136)
        Me.Button24.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(109, 63)
        Me.Button24.TabIndex = 26
        Me.Button24.Text = "atan"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button25.AutoSize = True
        Me.Button25.BackColor = System.Drawing.Color.ForestGreen
        Me.Button25.FlatAppearance.BorderSize = 0
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button25.Location = New System.Drawing.Point(3, 203)
        Me.Button25.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(107, 63)
        Me.Button25.TabIndex = 27
        Me.Button25.Text = "sinh"
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button26.AutoSize = True
        Me.Button26.BackColor = System.Drawing.Color.ForestGreen
        Me.Button26.FlatAppearance.BorderSize = 0
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button26.Location = New System.Drawing.Point(116, 203)
        Me.Button26.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(107, 63)
        Me.Button26.TabIndex = 28
        Me.Button26.Text = "cosh"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button27.AutoSize = True
        Me.Button27.BackColor = System.Drawing.Color.ForestGreen
        Me.Button27.FlatAppearance.BorderSize = 0
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button27.Location = New System.Drawing.Point(229, 203)
        Me.Button27.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(107, 63)
        Me.Button27.TabIndex = 29
        Me.Button27.Text = "tanh"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button28.AutoSize = True
        Me.Button28.BackColor = System.Drawing.Color.ForestGreen
        Me.Button28.FlatAppearance.BorderSize = 0
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button28.Location = New System.Drawing.Point(342, 203)
        Me.Button28.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(107, 63)
        Me.Button28.TabIndex = 30
        Me.Button28.Text = "asinh"
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button29.AutoSize = True
        Me.Button29.BackColor = System.Drawing.Color.ForestGreen
        Me.Button29.FlatAppearance.BorderSize = 0
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button29.Location = New System.Drawing.Point(455, 203)
        Me.Button29.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(107, 63)
        Me.Button29.TabIndex = 31
        Me.Button29.Text = "acosh"
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button30.AutoSize = True
        Me.Button30.BackColor = System.Drawing.Color.ForestGreen
        Me.Button30.FlatAppearance.BorderSize = 0
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button30.Location = New System.Drawing.Point(568, 203)
        Me.Button30.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(109, 63)
        Me.Button30.TabIndex = 32
        Me.Button30.Text = "atanh"
        Me.Button30.UseVisualStyleBackColor = False
        '
        'tblBottom
        '
        Me.tblBottom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblBottom.ColumnCount = 5
        Me.tblBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblBottom.Controls.Add(Me.Button42, 0, 3)
        Me.tblBottom.Controls.Add(Me.btnPow10, 0, 3)
        Me.tblBottom.Controls.Add(Me.Button40, 0, 3)
        Me.tblBottom.Controls.Add(Me.btnEqual, 0, 3)
        Me.tblBottom.Controls.Add(Me.Button1, 0, 0)
        Me.tblBottom.Controls.Add(Me.Button2, 1, 0)
        Me.tblBottom.Controls.Add(Me.Button3, 2, 0)
        Me.tblBottom.Controls.Add(Me.btnDel, 3, 0)
        Me.tblBottom.Controls.Add(Me.btnAC, 4, 0)
        Me.tblBottom.Controls.Add(Me.Button6, 0, 1)
        Me.tblBottom.Controls.Add(Me.Button7, 1, 1)
        Me.tblBottom.Controls.Add(Me.Button8, 2, 1)
        Me.tblBottom.Controls.Add(Me.Button31, 3, 1)
        Me.tblBottom.Controls.Add(Me.Button32, 4, 1)
        Me.tblBottom.Controls.Add(Me.Button33, 0, 2)
        Me.tblBottom.Controls.Add(Me.Button34, 1, 2)
        Me.tblBottom.Controls.Add(Me.Button35, 2, 2)
        Me.tblBottom.Controls.Add(Me.Button36, 3, 2)
        Me.tblBottom.Controls.Add(Me.Button37, 4, 2)
        Me.tblBottom.Controls.Add(Me.Button38, 0, 3)
        Me.tblBottom.Location = New System.Drawing.Point(3, 410)
        Me.tblBottom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblBottom.Name = "tblBottom"
        Me.tblBottom.RowCount = 4
        Me.tblBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblBottom.Size = New System.Drawing.Size(680, 270)
        Me.tblBottom.TabIndex = 2
        '
        'Button42
        '
        Me.Button42.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button42.AutoSize = True
        Me.Button42.BackColor = System.Drawing.Color.DarkViolet
        Me.Button42.FlatAppearance.BorderSize = 0
        Me.Button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button42.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button42.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button42.Location = New System.Drawing.Point(411, 203)
        Me.Button42.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button42.Name = "Button42"
        Me.Button42.Size = New System.Drawing.Size(130, 65)
        Me.Button42.TabIndex = 49
        Me.Button42.Text = ","
        Me.Button42.UseVisualStyleBackColor = False
        '
        'btnPow10
        '
        Me.btnPow10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPow10.AutoSize = True
        Me.btnPow10.BackColor = System.Drawing.Color.DarkViolet
        Me.btnPow10.FlatAppearance.BorderSize = 0
        Me.btnPow10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPow10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPow10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPow10.Location = New System.Drawing.Point(275, 203)
        Me.btnPow10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPow10.Name = "btnPow10"
        Me.btnPow10.Size = New System.Drawing.Size(130, 65)
        Me.btnPow10.TabIndex = 48
        Me.btnPow10.Text = "×10^"
        Me.btnPow10.UseVisualStyleBackColor = False
        '
        'Button40
        '
        Me.Button40.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button40.AutoSize = True
        Me.Button40.BackColor = System.Drawing.Color.DarkViolet
        Me.Button40.FlatAppearance.BorderSize = 0
        Me.Button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button40.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button40.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button40.Location = New System.Drawing.Point(139, 203)
        Me.Button40.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(130, 65)
        Me.Button40.TabIndex = 47
        Me.Button40.Text = "."
        Me.Button40.UseVisualStyleBackColor = False
        '
        'btnEqual
        '
        Me.btnEqual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEqual.AutoSize = True
        Me.btnEqual.BackColor = System.Drawing.Color.DarkViolet
        Me.btnEqual.FlatAppearance.BorderSize = 0
        Me.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEqual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEqual.Location = New System.Drawing.Point(547, 203)
        Me.btnEqual.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(130, 65)
        Me.btnEqual.TabIndex = 46
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.DarkViolet
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(3, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 63)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "7"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.DarkViolet
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(139, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 63)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "8"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.DarkViolet
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(275, 2)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 63)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "9"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.AutoSize = True
        Me.btnDel.BackColor = System.Drawing.Color.DarkOrange
        Me.btnDel.FlatAppearance.BorderSize = 0
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDel.Location = New System.Drawing.Point(411, 2)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(130, 63)
        Me.btnDel.TabIndex = 33
        Me.btnDel.Text = "DEL"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnAC
        '
        Me.btnAC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAC.AutoSize = True
        Me.btnAC.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAC.FlatAppearance.BorderSize = 0
        Me.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAC.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAC.Location = New System.Drawing.Point(547, 2)
        Me.btnAC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAC.Name = "btnAC"
        Me.btnAC.Size = New System.Drawing.Size(130, 63)
        Me.btnAC.TabIndex = 34
        Me.btnAC.Text = "AC"
        Me.btnAC.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.DarkViolet
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(3, 69)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(130, 63)
        Me.Button6.TabIndex = 35
        Me.Button6.Text = "4"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.AutoSize = True
        Me.Button7.BackColor = System.Drawing.Color.DarkViolet
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button7.Location = New System.Drawing.Point(139, 69)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 63)
        Me.Button7.TabIndex = 36
        Me.Button7.Text = "5"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.AutoSize = True
        Me.Button8.BackColor = System.Drawing.Color.DarkViolet
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button8.Location = New System.Drawing.Point(275, 69)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(130, 63)
        Me.Button8.TabIndex = 37
        Me.Button8.Text = "6"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button31.AutoSize = True
        Me.Button31.BackColor = System.Drawing.Color.DarkViolet
        Me.Button31.FlatAppearance.BorderSize = 0
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button31.Location = New System.Drawing.Point(411, 69)
        Me.Button31.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(130, 63)
        Me.Button31.TabIndex = 38
        Me.Button31.Text = "×"
        Me.Button31.UseVisualStyleBackColor = False
        '
        'Button32
        '
        Me.Button32.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button32.AutoSize = True
        Me.Button32.BackColor = System.Drawing.Color.DarkViolet
        Me.Button32.FlatAppearance.BorderSize = 0
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button32.Location = New System.Drawing.Point(547, 69)
        Me.Button32.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(130, 63)
        Me.Button32.TabIndex = 39
        Me.Button32.Text = "÷"
        Me.Button32.UseVisualStyleBackColor = False
        '
        'Button33
        '
        Me.Button33.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button33.AutoSize = True
        Me.Button33.BackColor = System.Drawing.Color.DarkViolet
        Me.Button33.FlatAppearance.BorderSize = 0
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button33.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button33.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button33.Location = New System.Drawing.Point(3, 136)
        Me.Button33.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(130, 63)
        Me.Button33.TabIndex = 40
        Me.Button33.Text = "1"
        Me.Button33.UseVisualStyleBackColor = False
        '
        'Button34
        '
        Me.Button34.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button34.AutoSize = True
        Me.Button34.BackColor = System.Drawing.Color.DarkViolet
        Me.Button34.FlatAppearance.BorderSize = 0
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button34.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button34.Location = New System.Drawing.Point(139, 136)
        Me.Button34.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(130, 63)
        Me.Button34.TabIndex = 41
        Me.Button34.Text = "2"
        Me.Button34.UseVisualStyleBackColor = False
        '
        'Button35
        '
        Me.Button35.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button35.AutoSize = True
        Me.Button35.BackColor = System.Drawing.Color.DarkViolet
        Me.Button35.FlatAppearance.BorderSize = 0
        Me.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button35.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button35.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button35.Location = New System.Drawing.Point(275, 136)
        Me.Button35.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(130, 63)
        Me.Button35.TabIndex = 42
        Me.Button35.Text = "3"
        Me.Button35.UseVisualStyleBackColor = False
        '
        'Button36
        '
        Me.Button36.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button36.AutoSize = True
        Me.Button36.BackColor = System.Drawing.Color.DarkViolet
        Me.Button36.FlatAppearance.BorderSize = 0
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button36.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button36.Location = New System.Drawing.Point(411, 136)
        Me.Button36.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(130, 63)
        Me.Button36.TabIndex = 43
        Me.Button36.Text = "+"
        Me.Button36.UseVisualStyleBackColor = False
        '
        'Button37
        '
        Me.Button37.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button37.AutoSize = True
        Me.Button37.BackColor = System.Drawing.Color.DarkViolet
        Me.Button37.FlatAppearance.BorderSize = 0
        Me.Button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button37.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button37.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button37.Location = New System.Drawing.Point(547, 136)
        Me.Button37.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(130, 63)
        Me.Button37.TabIndex = 44
        Me.Button37.Text = "-"
        Me.Button37.UseVisualStyleBackColor = False
        '
        'Button38
        '
        Me.Button38.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button38.AutoSize = True
        Me.Button38.BackColor = System.Drawing.Color.DarkViolet
        Me.Button38.FlatAppearance.BorderSize = 0
        Me.Button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button38.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button38.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button38.Location = New System.Drawing.Point(3, 203)
        Me.Button38.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(130, 65)
        Me.Button38.TabIndex = 45
        Me.Button38.Text = "0"
        Me.Button38.UseVisualStyleBackColor = False
        '
        'CalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 688)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CalculatorForm"
        Me.Text = "Scientific Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblTop.ResumeLayout(False)
        Me.tblTop.PerformLayout()
        Me.tblMiddle.ResumeLayout(False)
        Me.tblMiddle.PerformLayout()
        Me.tblBottom.ResumeLayout(False)
        Me.tblBottom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tblTop As TableLayoutPanel
    Friend WithEvents lblAngleMode As Label
    Friend WithEvents tblMiddle As TableLayoutPanel
    Friend WithEvents tblBottom As TableLayoutPanel
    Friend WithEvents tbInput As TextBox
    Friend WithEvents lblAnsDisplay As Label
    Friend WithEvents btnRightParen As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents btnFact As Button
    Friend WithEvents btnSqrt As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnAbs As Button
    Friend WithEvents btnLeftParen As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button42 As Button
    Friend WithEvents btnPow10 As Button
    Friend WithEvents Button40 As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAC As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Button32 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents Button34 As Button
    Friend WithEvents Button35 As Button
    Friend WithEvents Button36 As Button
    Friend WithEvents Button37 As Button
    Friend WithEvents Button38 As Button
End Class
