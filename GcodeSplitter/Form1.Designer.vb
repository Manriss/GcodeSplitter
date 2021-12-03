<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGcode
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGcode))
        Me.lboxCodigo = New System.Windows.Forms.ListBox()
        Me.tboxHeader = New System.Windows.Forms.TextBox()
        Me.tboxEnd = New System.Windows.Forms.TextBox()
        Me.tboxCut = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnCut = New System.Windows.Forms.Button()
        Me.btnRenum = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FinalDeCabeceraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioDeFinalDeBloqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lboxCodigo
        '
        Me.lboxCodigo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lboxCodigo.FormattingEnabled = True
        Me.lboxCodigo.Location = New System.Drawing.Point(12, 108)
        Me.lboxCodigo.Name = "lboxCodigo"
        Me.lboxCodigo.Size = New System.Drawing.Size(775, 420)
        Me.lboxCodigo.TabIndex = 0
        '
        'tboxHeader
        '
        Me.tboxHeader.Location = New System.Drawing.Point(238, 14)
        Me.tboxHeader.Name = "tboxHeader"
        Me.tboxHeader.Size = New System.Drawing.Size(372, 20)
        Me.tboxHeader.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.tboxHeader, "Separados por punto y coma")
        '
        'tboxEnd
        '
        Me.tboxEnd.Location = New System.Drawing.Point(238, 43)
        Me.tboxEnd.Name = "tboxEnd"
        Me.tboxEnd.Size = New System.Drawing.Size(372, 20)
        Me.tboxEnd.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tboxEnd, "Separados por punto y coma")
        '
        'tboxCut
        '
        Me.tboxCut.Location = New System.Drawing.Point(238, 72)
        Me.tboxCut.Name = "tboxCut"
        Me.tboxCut.Size = New System.Drawing.Size(372, 20)
        Me.tboxCut.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tboxCut, "Separados por punto y coma." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La linea indicada será la ultima linea incluida en e" &
        "l archivo.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lineas a repetir al principio (separados por ; )"
        Me.ToolTip1.SetToolTip(Me.Label1, "Separados por punto y coma")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lineas a repetir al final (separados por ; )"
        Me.ToolTip1.SetToolTip(Me.Label2, "Separados por punto y coma")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Lineas de corte (separados por ; )"
        Me.ToolTip1.SetToolTip(Me.Label3, "Separados por punto y coma")
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(625, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(162, 23)
        Me.btnOpen.TabIndex = 7
        Me.btnOpen.Text = "Abrir archivo"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnCut
        '
        Me.btnCut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCut.Location = New System.Drawing.Point(625, 41)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(162, 23)
        Me.btnCut.TabIndex = 8
        Me.btnCut.Text = "Cortar archivo"
        Me.btnCut.UseVisualStyleBackColor = True
        '
        'btnRenum
        '
        Me.btnRenum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRenum.Location = New System.Drawing.Point(625, 70)
        Me.btnRenum.Name = "btnRenum"
        Me.btnRenum.Size = New System.Drawing.Size(162, 23)
        Me.btnRenum.TabIndex = 9
        Me.btnRenum.Text = "Solo renumerar"
        Me.btnRenum.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "h files|*.h|Text Files |*.txt|All Files (*.*)|*.*"""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinalDeCabeceraToolStripMenuItem, Me.InicioDeFinalDeBloqueToolStripMenuItem, Me.CorteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(202, 70)
        '
        'FinalDeCabeceraToolStripMenuItem
        '
        Me.FinalDeCabeceraToolStripMenuItem.Name = "FinalDeCabeceraToolStripMenuItem"
        Me.FinalDeCabeceraToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.FinalDeCabeceraToolStripMenuItem.Text = "Final de cabecera"
        '
        'InicioDeFinalDeBloqueToolStripMenuItem
        '
        Me.InicioDeFinalDeBloqueToolStripMenuItem.Name = "InicioDeFinalDeBloqueToolStripMenuItem"
        Me.InicioDeFinalDeBloqueToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.InicioDeFinalDeBloqueToolStripMenuItem.Text = "Inicio de final de bloque"
        '
        'CorteToolStripMenuItem
        '
        Me.CorteToolStripMenuItem.Name = "CorteToolStripMenuItem"
        Me.CorteToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CorteToolStripMenuItem.Text = "Corte"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 540)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(884, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Ready"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(794, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(78, 514)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculos"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(7, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(65, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 26)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Numero lineas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "subprograma"
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 110)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(65, 394)
        Me.ListBox1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cortes"
        '
        'frmGcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 562)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnRenum)
        Me.Controls.Add(Me.btnCut)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tboxCut)
        Me.Controls.Add(Me.tboxEnd)
        Me.Controls.Add(Me.tboxHeader)
        Me.Controls.Add(Me.lboxCodigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(900, 600)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frmGcode"
        Me.Text = "Gcode Splitter v2.1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lboxCodigo As ListBox
    Friend WithEvents tboxHeader As TextBox
    Friend WithEvents tboxEnd As TextBox
    Friend WithEvents tboxCut As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnCut As Button
    Friend WithEvents btnRenum As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FinalDeCabeceraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioDeFinalDeBloqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
