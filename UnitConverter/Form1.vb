Public Class Form1


    Private Sub cboSelectTypeOfUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectTypeOfUnit.SelectedIndexChanged
        SetItemsForComboBox(cboSelectTypeOfUnit.SelectedIndex)
        calculate()
    End Sub


    Private Sub SetItemsForComboBox(index As Integer)
        If index = 0 Then
            cboSelectUnitFrom.Items.Clear()
            cboSelectUnitTo.Items.Clear()
            cboSelectUnitFrom.Items.AddRange({"Segundos", "Minutos", "Horas", "Dias"})
            cboSelectUnitTo.Items.AddRange({"Segundos", "Minutos", "Horas", "Dias"})
            cboSelectUnitFrom.SelectedIndex = 1
            cboSelectUnitTo.SelectedIndex = 2

        ElseIf index = 1 Then
            cboSelectUnitFrom.Items.Clear()
            cboSelectUnitTo.Items.Clear()
            cboSelectUnitFrom.Items.AddRange({"Mililitros", "Litros", "Galones", "Centimetro Cubico"})
            cboSelectUnitTo.Items.AddRange({"Mililitros", "Litros", "Galones", "Centimetro Cubico"})
            cboSelectUnitFrom.SelectedIndex = 1
            cboSelectUnitTo.SelectedIndex = 2

        ElseIf index = 2 Then
            cboSelectUnitFrom.Items.Clear()
            cboSelectUnitTo.Items.Clear()
            cboSelectUnitFrom.Items.AddRange({"Centimetros", "Pulgadas", "Pies"})
            cboSelectUnitTo.Items.AddRange({"Centimetros", "Pulgadas", "Pies"})
            cboSelectUnitFrom.SelectedIndex = 1
            cboSelectUnitTo.SelectedIndex = 2

        End If
    End Sub

    Private Sub calculate2()
        'Codigos para TIEMPO
        'Codigo para cambiar de SEGUNDOS a cualquier unidad de tiempo
        If (cboSelectUnitFrom.SelectedItem = "Segundos" And cboSelectUnitTo.SelectedItem = "Segundos") Then
            valorAConvertir.Text = Val(txtResultado.Text)

        ElseIf (cboSelectUnitFrom.SelectedItem = "Segundos" And cboSelectUnitTo.SelectedItem = "Minutos") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 60

        ElseIf (cboSelectUnitFrom.SelectedItem = "Segundos" And cboSelectUnitTo.SelectedItem = "Horas") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 3600

        ElseIf (cboSelectUnitFrom.SelectedItem = "Segundos" And cboSelectUnitTo.SelectedItem = "Dias") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 86400

            'Codigo para cambiar de MINUTOS a cualquier unidad de tiempo
        ElseIf (cboSelectUnitFrom.SelectedItem = "Minutos" And cboSelectUnitTo.SelectedItem = "Segundos") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 60

        ElseIf (cboSelectUnitFrom.SelectedItem = "Minutos" And cboSelectUnitTo.SelectedItem = "Minutos") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Minutos" And cboSelectUnitTo.SelectedItem = "Horas") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 60

        ElseIf (cboSelectUnitFrom.SelectedItem = "Minutos" And cboSelectUnitTo.SelectedItem = "Dias") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 1440

            'Codigo para cambiar de HORAS a cualquier unidad de tiempo
        ElseIf (cboSelectUnitFrom.SelectedItem = "Horas" And cboSelectUnitTo.SelectedItem = "Segundos") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 3600

        ElseIf (cboSelectUnitFrom.SelectedItem = "Horas" And cboSelectUnitTo.SelectedItem = "Minutos") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 60

        ElseIf (cboSelectUnitFrom.SelectedItem = "Horas" And cboSelectUnitTo.SelectedItem = "Horas") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Horas" And cboSelectUnitTo.SelectedItem = "Dias") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 24

            'Codigo para cambiar de DIAS a cualquier unidad de tiempo
        ElseIf (cboSelectUnitFrom.SelectedItem = "Dias" And cboSelectUnitTo.SelectedItem = "Segundos") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 86400

        ElseIf (cboSelectUnitFrom.SelectedItem = "Dias" And cboSelectUnitTo.SelectedItem = "Minutos") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1440

        ElseIf (cboSelectUnitFrom.SelectedItem = "Dias" And cboSelectUnitTo.SelectedItem = "Horas") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 24

        ElseIf (cboSelectUnitFrom.SelectedItem = "Dias" And cboSelectUnitTo.SelectedItem = "Segundos") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1



            'Codigos para VOLUMEN
            'Codigo para cambiar de MILILITROS a cualquier unidad de tiempo
        ElseIf (cboSelectUnitFrom.SelectedItem = "Mililitros" And cboSelectUnitTo.SelectedItem = "Mililitros") Then
            valorAConvertir.Text = Val(txtResultado.Text)

        ElseIf (cboSelectUnitFrom.SelectedItem = "Mililitros" And cboSelectUnitTo.SelectedItem = "Litros") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 1000

        ElseIf (cboSelectUnitFrom.SelectedItem = "Mililitros" And cboSelectUnitTo.SelectedItem = "Galones") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 3785.41

        ElseIf (cboSelectUnitFrom.SelectedItem = "Mililitros" And cboSelectUnitTo.SelectedItem = "Centimetro Cubico") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Litros" And cboSelectUnitTo.SelectedItem = "Mililitros") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1000

        ElseIf (cboSelectUnitFrom.SelectedItem = "Litros" And cboSelectUnitTo.SelectedItem = "Litros") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Litros" And cboSelectUnitTo.SelectedItem = "Galones") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 3.7854

        ElseIf (cboSelectUnitFrom.SelectedItem = "Litros" And cboSelectUnitTo.SelectedItem = "Centimetro Cubico") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1000

            'Codigo de GALONES
        ElseIf (cboSelectUnitFrom.SelectedItem = "Galones" And cboSelectUnitTo.SelectedItem = "Mililitros") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 3785.41

        ElseIf (cboSelectUnitFrom.SelectedItem = "Galones" And cboSelectUnitTo.SelectedItem = "Litros") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 3.7854

        ElseIf (cboSelectUnitFrom.SelectedItem = "Galones" And cboSelectUnitTo.SelectedItem = "Galones") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Galones" And cboSelectUnitTo.SelectedItem = "Centimetro Cubico") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 3785.41



            'Codigo de CENTIMETROS CUBICOS
        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetro Cubico" And cboSelectUnitTo.SelectedItem = "Mililitros") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetro Cubico" And cboSelectUnitTo.SelectedItem = "Litros") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 1000

        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetro Cubico" And cboSelectUnitTo.SelectedItem = "Galones") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 3785.412

        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetro Cubico" And cboSelectUnitTo.SelectedItem = "Centimetro Cubico") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1



            'Codigo para LONGITUD
            'Codigo para CENTIMETROS
        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetros" And cboSelectUnitTo.SelectedItem = "Centimetros") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetro" And cboSelectUnitTo.SelectedItem = "Pulgadas") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 2.54

        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetros" And cboSelectUnitTo.SelectedItem = "Pies") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 30.48

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pulgadas" And cboSelectUnitTo.SelectedItem = "Centimetros") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 2.54

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pulgadas" And cboSelectUnitTo.SelectedItem = "Pulgadas") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pulgadas" And cboSelectUnitTo.SelectedItem = "Pies") Then
            valorAConvertir.Text = Val(txtResultado.Text) * 12

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pies" And cboSelectUnitTo.SelectedItem = "Centimetros") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 30.48

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pies" And cboSelectUnitTo.SelectedItem = "Pulgadas") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 12

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pies" And cboSelectUnitTo.SelectedItem = "Pies") Then
            valorAConvertir.Text = Val(txtResultado.Text) / 1

        End If

    End Sub


    Private Sub calculate()
        'Codigos para TIEMPO
        'Codigo para cambiar de SEGUNDOS a cualquier unidad de tiempo
        If (cboSelectUnitFrom.SelectedItem = "Segundos" And cboSelectUnitTo.SelectedItem = "Segundos") Then
            txtResultado.Text = Val(valorAConvertir.Text)

        ElseIf (cboSelectUnitFrom.SelectedItem = "Segundos" And cboSelectUnitTo.SelectedItem = "Minutos") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 60

        ElseIf (cboSelectUnitFrom.SelectedItem = "Segundos" And cboSelectUnitTo.SelectedItem = "Horas") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 3600

        ElseIf (cboSelectUnitFrom.SelectedItem = "Segundos" And cboSelectUnitTo.SelectedItem = "Dias") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 86400

            'Codigo para cambiar de MINUTOS a cualquier unidad de tiempo
        ElseIf (cboSelectUnitFrom.SelectedItem = "Minutos" And cboSelectUnitTo.SelectedItem = "Segundos") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 60

        ElseIf (cboSelectUnitFrom.SelectedItem = "Minutos" And cboSelectUnitTo.SelectedItem = "Minutos") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Minutos" And cboSelectUnitTo.SelectedItem = "Horas") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 60

        ElseIf (cboSelectUnitFrom.SelectedItem = "Minutos" And cboSelectUnitTo.SelectedItem = "Dias") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 1440

            'Codigo para cambiar de HORAS a cualquier unidad de tiempo
        ElseIf (cboSelectUnitFrom.SelectedItem = "Horas" And cboSelectUnitTo.SelectedItem = "Segundos") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 3600

        ElseIf (cboSelectUnitFrom.SelectedItem = "Horas" And cboSelectUnitTo.SelectedItem = "Minutos") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 60

        ElseIf (cboSelectUnitFrom.SelectedItem = "Horas" And cboSelectUnitTo.SelectedItem = "Horas") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Horas" And cboSelectUnitTo.SelectedItem = "Dias") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 24

            'Codigo para cambiar de DIAS a cualquier unidad de tiempo
        ElseIf (cboSelectUnitFrom.SelectedItem = "Dias" And cboSelectUnitTo.SelectedItem = "Segundos") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 86400

        ElseIf (cboSelectUnitFrom.SelectedItem = "Dias" And cboSelectUnitTo.SelectedItem = "Minutos") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1440

        ElseIf (cboSelectUnitFrom.SelectedItem = "Dias" And cboSelectUnitTo.SelectedItem = "Horas") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 24

        ElseIf (cboSelectUnitFrom.SelectedItem = "Dias" And cboSelectUnitTo.SelectedItem = "Segundos") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1



            'Codigos para VOLUMEN
            'Codigo para cambiar de MILILITROS a cualquier unidad de tiempo
        ElseIf (cboSelectUnitFrom.SelectedItem = "Mililitros" And cboSelectUnitTo.SelectedItem = "Mililitros") Then
            txtResultado.Text = Val(valorAConvertir.Text)

        ElseIf (cboSelectUnitFrom.SelectedItem = "Mililitros" And cboSelectUnitTo.SelectedItem = "Litros") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 1000

        ElseIf (cboSelectUnitFrom.SelectedItem = "Mililitros" And cboSelectUnitTo.SelectedItem = "Galones") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 3785.41

        ElseIf (cboSelectUnitFrom.SelectedItem = "Mililitros" And cboSelectUnitTo.SelectedItem = "Centimetro Cubico") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Litros" And cboSelectUnitTo.SelectedItem = "Mililitros") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1000

        ElseIf (cboSelectUnitFrom.SelectedItem = "Litros" And cboSelectUnitTo.SelectedItem = "Litros") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Litros" And cboSelectUnitTo.SelectedItem = "Galones") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 3.7854

        ElseIf (cboSelectUnitFrom.SelectedItem = "Litros" And cboSelectUnitTo.SelectedItem = "Centimetro Cubico") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1000

            'Codigo de GALONES
        ElseIf (cboSelectUnitFrom.SelectedItem = "Galones" And cboSelectUnitTo.SelectedItem = "Mililitros") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 3785.41

        ElseIf (cboSelectUnitFrom.SelectedItem = "Galones" And cboSelectUnitTo.SelectedItem = "Litros") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 3.7854

        ElseIf (cboSelectUnitFrom.SelectedItem = "Galones" And cboSelectUnitTo.SelectedItem = "Galones") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Galones" And cboSelectUnitTo.SelectedItem = "Centimetro Cubico") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 3785.41



            'Codigo de CENTIMETROS CUBICOS
        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetro Cubico" And cboSelectUnitTo.SelectedItem = "Mililitros") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetro Cubico" And cboSelectUnitTo.SelectedItem = "Litros") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 1000

        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetro Cubico" And cboSelectUnitTo.SelectedItem = "Galones") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 3785.412

        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetro Cubico" And cboSelectUnitTo.SelectedItem = "Centimetro Cubico") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1


            'Codigo para LONGITUD
            'Codigo para CENTIMETROS
        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetros" And cboSelectUnitTo.SelectedItem = "Centimetros") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetro" And cboSelectUnitTo.SelectedItem = "Pulgadas") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 2.54

        ElseIf (cboSelectUnitFrom.SelectedItem = "Centimetros" And cboSelectUnitTo.SelectedItem = "Pies") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 30.48

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pulgadas" And cboSelectUnitTo.SelectedItem = "Centimetros") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 2.54

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pulgadas" And cboSelectUnitTo.SelectedItem = "Pulgadas") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pulgadas" And cboSelectUnitTo.SelectedItem = "Pies") Then
            txtResultado.Text = Val(valorAConvertir.Text) / 12

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pies" And cboSelectUnitTo.SelectedItem = "Centimetros") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 30.48

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pies" And cboSelectUnitTo.SelectedItem = "Pulgadas") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 12

        ElseIf (cboSelectUnitFrom.SelectedItem = "Pies" And cboSelectUnitTo.SelectedItem = "Pies") Then
            txtResultado.Text = Val(valorAConvertir.Text) * 1



        End If

    End Sub





    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        calculate()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub AboutUnitConverterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUnitConverterToolStripMenuItem.Click
        About.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub txtResultado_Click(sender As Object, e As EventArgs) Handles txtResultado.Click



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSelectTypeOfUnit.SelectedIndex = 0
        cboSelectUnitFrom.SelectedIndex = 1
        cboSelectUnitTo.SelectedIndex = 2

    End Sub

    Private Sub valorAConvertir_KeyDown(sender As Object, e As KeyEventArgs) Handles valorAConvertir.KeyDown
        calculate()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub valorAConvertir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valorAConvertir.KeyPress
        calculate()
    End Sub

    Private Sub valorAConvertir_KeyUp(sender As Object, e As KeyEventArgs) Handles valorAConvertir.KeyUp
        calculate()
    End Sub

    Private Sub txtResultado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtResultado.KeyDown
        calculate2()
    End Sub

    Private Sub txtResultado_KeyUp(sender As Object, e As KeyEventArgs) Handles txtResultado.KeyUp
        calculate2()
    End Sub

    Private Sub cboSelectUnitFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectUnitFrom.SelectedIndexChanged
        calculate()

    End Sub

    Private Sub cboSelectUnitTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectUnitTo.SelectedIndexChanged
        calculate2()
    End Sub
End Class
