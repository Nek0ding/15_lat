<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btn_doWhile = New Button()
        btn_hapus = New Button()
        btn_doUntil = New Button()
        btn_forNext = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        input_awal = New TextBox()
        input_akhir = New TextBox()
        output = New TextBox()
        SuspendLayout()
        ' 
        ' btn_doWhile
        ' 
        btn_doWhile.Location = New Point(626, 69)
        btn_doWhile.Name = "btn_doWhile"
        btn_doWhile.Size = New Size(112, 34)
        btn_doWhile.TabIndex = 1
        btn_doWhile.Text = "Do While"
        btn_doWhile.UseVisualStyleBackColor = True
        ' 
        ' btn_hapus
        ' 
        btn_hapus.Location = New Point(626, 310)
        btn_hapus.Name = "btn_hapus"
        btn_hapus.Size = New Size(112, 34)
        btn_hapus.TabIndex = 2
        btn_hapus.Text = "Clear"
        btn_hapus.UseVisualStyleBackColor = True
        ' 
        ' btn_doUntil
        ' 
        btn_doUntil.Location = New Point(626, 141)
        btn_doUntil.Name = "btn_doUntil"
        btn_doUntil.Size = New Size(112, 34)
        btn_doUntil.TabIndex = 3
        btn_doUntil.Text = "Do Until"
        btn_doUntil.UseVisualStyleBackColor = True
        ' 
        ' btn_forNext
        ' 
        btn_forNext.Location = New Point(626, 228)
        btn_forNext.Name = "btn_forNext"
        btn_forNext.Size = New Size(112, 34)
        btn_forNext.TabIndex = 4
        btn_forNext.Text = "For..Next"
        btn_forNext.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(125, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 25)
        Label1.TabIndex = 5
        Label1.Text = "Nilai Awal"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(125, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 6
        Label2.Text = "Nilai Akhir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(125, 276)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 25)
        Label3.TabIndex = 7
        Label3.Text = "Nilai Akhir"
        ' 
        ' input_awal
        ' 
        input_awal.Location = New Point(245, 71)
        input_awal.Name = "input_awal"
        input_awal.Size = New Size(211, 31)
        input_awal.TabIndex = 8
        ' 
        ' input_akhir
        ' 
        input_akhir.Location = New Point(245, 147)
        input_akhir.Name = "input_akhir"
        input_akhir.Size = New Size(211, 31)
        input_akhir.TabIndex = 9
        ' 
        ' output
        ' 
        output.Location = New Point(125, 313)
        output.Name = "output"
        output.Size = New Size(443, 31)
        output.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(output)
        Controls.Add(input_akhir)
        Controls.Add(input_awal)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_forNext)
        Controls.Add(btn_doUntil)
        Controls.Add(btn_hapus)
        Controls.Add(btn_doWhile)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn_doWhile As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_doUntil As Button
    Friend WithEvents btn_forNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents input_awal As TextBox
    Friend WithEvents input_akhir As TextBox
    Friend WithEvents output As TextBox

End Class
