<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLatteSelection
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
        picPumpkin = New PictureBox()
        picMocha = New PictureBox()
        lblLatte = New Label()
        lblInstructions = New Label()
        lblConfirmation = New Label()
        btnPumpkin = New Button()
        btnSelect = New Button()
        btnMocha = New Button()
        btnExit = New Button()
        CType(picPumpkin, ComponentModel.ISupportInitialize).BeginInit()
        CType(picMocha, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picPumpkin
        ' 
        picPumpkin.Image = My.Resources.Resources.pumpkin
        picPumpkin.Location = New Point(164, 33)
        picPumpkin.Name = "picPumpkin"
        picPumpkin.Size = New Size(137, 192)
        picPumpkin.TabIndex = 0
        picPumpkin.TabStop = False
        picPumpkin.Visible = False
        ' 
        ' picMocha
        ' 
        picMocha.Image = My.Resources.Resources.Mocha
        picMocha.Location = New Point(500, 33)
        picMocha.Name = "picMocha"
        picMocha.Size = New Size(137, 192)
        picMocha.TabIndex = 1
        picMocha.TabStop = False
        picMocha.Visible = False
        ' 
        ' lblLatte
        ' 
        lblLatte.AutoSize = True
        lblLatte.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLatte.ForeColor = Color.SaddleBrown
        lblLatte.Location = New Point(341, 9)
        lblLatte.Name = "lblLatte"
        lblLatte.Size = New Size(132, 19)
        lblLatte.TabIndex = 2
        lblLatte.Text = "Latte Selection"
        ' 
        ' lblInstructions
        ' 
        lblInstructions.AutoSize = True
        lblInstructions.Location = New Point(282, 304)
        lblInstructions.Name = "lblInstructions"
        lblInstructions.Size = New Size(287, 15)
        lblInstructions.TabIndex = 3
        lblInstructions.Text = "Choose a latte flavor and click the Select Latte button"
        ' 
        ' lblConfirmation
        ' 
        lblConfirmation.AutoSize = True
        lblConfirmation.Location = New Point(341, 342)
        lblConfirmation.Name = "lblConfirmation"
        lblConfirmation.Size = New Size(143, 15)
        lblConfirmation.TabIndex = 4
        lblConfirmation.Text = "Enjoy your Latte Selection"
        lblConfirmation.Visible = False
        ' 
        ' btnPumpkin
        ' 
        btnPumpkin.BackColor = Color.Bisque
        btnPumpkin.Location = New Point(178, 246)
        btnPumpkin.Name = "btnPumpkin"
        btnPumpkin.Size = New Size(110, 23)
        btnPumpkin.TabIndex = 5
        btnPumpkin.Text = "Pumpkin Spice"
        btnPumpkin.UseVisualStyleBackColor = False
        ' 
        ' btnSelect
        ' 
        btnSelect.BackColor = Color.Bisque
        btnSelect.Enabled = False
        btnSelect.Location = New Point(359, 246)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(110, 23)
        btnSelect.TabIndex = 6
        btnSelect.Text = "Select Latte"
        btnSelect.UseVisualStyleBackColor = False
        ' 
        ' btnMocha
        ' 
        btnMocha.BackColor = Color.Bisque
        btnMocha.Location = New Point(518, 246)
        btnMocha.Name = "btnMocha"
        btnMocha.Size = New Size(110, 23)
        btnMocha.TabIndex = 7
        btnMocha.Text = "Mocha"
        btnMocha.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Bisque
        btnExit.Enabled = False
        btnExit.Location = New Point(359, 390)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(111, 23)
        btnExit.TabIndex = 8
        btnExit.Text = "Exit Window"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmLatteSelection
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnMocha)
        Controls.Add(btnSelect)
        Controls.Add(btnPumpkin)
        Controls.Add(lblConfirmation)
        Controls.Add(lblInstructions)
        Controls.Add(lblLatte)
        Controls.Add(picMocha)
        Controls.Add(picPumpkin)
        Name = "frmLatteSelection"
        Text = "Latte Selection"
        CType(picPumpkin, ComponentModel.ISupportInitialize).EndInit()
        CType(picMocha, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picPumpkin As PictureBox
    Friend WithEvents picMocha As PictureBox
    Friend WithEvents lblLatte As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnPumpkin As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnMocha As Button
    Friend WithEvents btnExit As Button

End Class
