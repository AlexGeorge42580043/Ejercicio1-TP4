<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        btEjecutar = New Button()
        grMostrarVectorA = New DataGridView()
        grMostrarVectorB = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        lstMostrarPares = New ListBox()
        lstMostrarImpares = New ListBox()
        lstMostrarMoltiplosN = New ListBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblMostrarMayor = New Label()
        Label7 = New Label()
        lblMostrarPosicion = New Label()
        CType(grMostrarVectorA, ComponentModel.ISupportInitialize).BeginInit()
        CType(grMostrarVectorB, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btEjecutar
        ' 
        btEjecutar.BackColor = SystemColors.ControlDark
        btEjecutar.Location = New Point(12, 12)
        btEjecutar.Name = "btEjecutar"
        btEjecutar.Size = New Size(134, 71)
        btEjecutar.TabIndex = 0
        btEjecutar.Text = "Ejecutar"
        btEjecutar.UseVisualStyleBackColor = False
        ' 
        ' grMostrarVectorA
        ' 
        grMostrarVectorA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grMostrarVectorA.ColumnHeadersVisible = False
        grMostrarVectorA.Location = New Point(12, 119)
        grMostrarVectorA.Name = "grMostrarVectorA"
        grMostrarVectorA.RowHeadersVisible = False
        grMostrarVectorA.RowHeadersWidth = 51
        grMostrarVectorA.RowTemplate.Height = 29
        grMostrarVectorA.Size = New Size(413, 46)
        grMostrarVectorA.TabIndex = 1
        ' 
        ' grMostrarVectorB
        ' 
        grMostrarVectorB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grMostrarVectorB.ColumnHeadersVisible = False
        grMostrarVectorB.Location = New Point(12, 191)
        grMostrarVectorB.Name = "grMostrarVectorB"
        grMostrarVectorB.RowHeadersVisible = False
        grMostrarVectorB.RowHeadersWidth = 51
        grMostrarVectorB.RowTemplate.Height = 29
        grMostrarVectorB.Size = New Size(413, 45)
        grMostrarVectorB.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 20)
        Label1.TabIndex = 3
        Label1.Text = "VectorA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 4
        Label2.Text = "VectorB"
        ' 
        ' lstMostrarPares
        ' 
        lstMostrarPares.FormattingEnabled = True
        lstMostrarPares.ItemHeight = 20
        lstMostrarPares.Location = New Point(442, 119)
        lstMostrarPares.Name = "lstMostrarPares"
        lstMostrarPares.Size = New Size(87, 264)
        lstMostrarPares.TabIndex = 5
        ' 
        ' lstMostrarImpares
        ' 
        lstMostrarImpares.FormattingEnabled = True
        lstMostrarImpares.ItemHeight = 20
        lstMostrarImpares.Location = New Point(552, 119)
        lstMostrarImpares.Name = "lstMostrarImpares"
        lstMostrarImpares.Size = New Size(87, 264)
        lstMostrarImpares.TabIndex = 6
        ' 
        ' lstMostrarMoltiplosN
        ' 
        lstMostrarMoltiplosN.FormattingEnabled = True
        lstMostrarMoltiplosN.ItemHeight = 20
        lstMostrarMoltiplosN.Location = New Point(661, 119)
        lstMostrarMoltiplosN.Name = "lstMostrarMoltiplosN"
        lstMostrarMoltiplosN.Size = New Size(85, 264)
        lstMostrarMoltiplosN.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(458, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 8
        Label3.Text = "Pares"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(565, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 9
        Label4.Text = "Impares"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(650, 96)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 20)
        Label5.TabIndex = 10
        Label5.Text = "Multiplos de N"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 276)
        Label6.Name = "Label6"
        Label6.Size = New Size(276, 20)
        Label6.TabIndex = 11
        Label6.Text = "El mayor valor ingresado en el vector es:"
        ' 
        ' lblMostrarMayor
        ' 
        lblMostrarMayor.AutoSize = True
        lblMostrarMayor.Location = New Point(294, 276)
        lblMostrarMayor.Name = "lblMostrarMayor"
        lblMostrarMayor.Size = New Size(0, 20)
        lblMostrarMayor.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 305)
        Label7.Name = "Label7"
        Label7.Size = New Size(193, 20)
        Label7.TabIndex = 13
        Label7.Text = "Se encuentra en la posicion:"
        ' 
        ' lblMostrarPosicion
        ' 
        lblMostrarPosicion.AutoSize = True
        lblMostrarPosicion.Location = New Point(211, 305)
        lblMostrarPosicion.Name = "lblMostrarPosicion"
        lblMostrarPosicion.Size = New Size(0, 20)
        lblMostrarPosicion.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblMostrarPosicion)
        Controls.Add(Label7)
        Controls.Add(lblMostrarMayor)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lstMostrarMoltiplosN)
        Controls.Add(lstMostrarImpares)
        Controls.Add(lstMostrarPares)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(grMostrarVectorB)
        Controls.Add(grMostrarVectorA)
        Controls.Add(btEjecutar)
        Name = "Form1"
        Text = "Form1"
        CType(grMostrarVectorA, ComponentModel.ISupportInitialize).EndInit()
        CType(grMostrarVectorB, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btEjecutar As Button
    Friend WithEvents grMostrarVectorA As DataGridView
    Friend WithEvents grMostrarVectorB As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstMostrarPares As ListBox
    Friend WithEvents lstMostrarImpares As ListBox
    Friend WithEvents lstMostrarMoltiplosN As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblMostrarMayor As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblMostrarPosicion As Label
End Class
