Imports System.IO

Public Class frmInventory
    Private InvItems As New Collection 'Collection of inventory objects

    Dim dataFile As StreamReader
    Dim inputFile As StreamWriter

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        inputFile = File.AppendText("inventory.txt") 'Inventory Object

        Dim item As New Inventory

        item.InvNum = txtInvNumber.Text
        item.Description = txtDescription.Text
        item.Cost = CDec(txtCost.Text)
        item.OnHand = CInt(txtOnHand.Text)
        item.Retail = CDec(txtRetailPrice.Text)
        Try
            InvItems.Add(item, item.InvNum) 'adds to collection as an item

            inputFile.WriteLine(item.InvNum.ToString())
            inputFile.WriteLine(item.Description.ToString())
            inputFile.WriteLine(item.Cost.ToString())
            inputFile.WriteLine(item.OnHand.ToString())
            inputFile.WriteLine(item.Retail.ToString())

            inputFile.Close()

            MessageBox.Show("Item successfully added to the collection", "Done")
            ClearFields()
            lbAllItems.Items.Add("ItemNo: " + item.InvNum.ToString() + ", dDescription:" + item.Description.ToString() + ", On hand: " + item.OnHand.ToString)
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ClearFields()
        txtCost.Clear()
        txtDescription.Clear()
        txtInvNumber.Clear()
        txtOnHand.Clear()
        txtRetailPrice.Clear()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Searches for the item with the given inventory number and displays if it is found
        If txtInvNumber.Text = " " Then
            MessageBox.Show("Please enter item number in the first text box.", "Warning")
        Else
            Dim num As String = txtInvNumber.Text
            Dim item As Inventory
            Dim found As Boolean = False
            For index = 1 To InvItems.Count
                item = CType(InvItems(index), Inventory)
                If num = item.InvNum Then
                    txtDescription.Text = item.Description
                    txtCost.Text = FormatCurrency(item.Cost, 2)
                    txtOnHand.Text = item.OnHand.ToString
                    txtRetailPrice.Text = FormatCurrency(item.Retail, 2)
                    found = True
                    Exit For
                End If
            Next
            If found = False Then
                MessageBox.Show("No item is found with this number", "No Item Found")
            End If
        End If
    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inventory form function.
        Try
            dataFile = File.OpenText("inventory.txt")
            Dim item As New Inventory

            While Not dataFile.EndOfStream
                item.InvNum = dataFile.ReadLine()
                item.Description = dataFile.ReadLine()
                item.Cost = CDec(dataFile.ReadLine())
                item.Retail = CDec(dataFile.ReadLine())
                item.OnHand = CInt(dataFile.ReadLine())
                InvItems.Add(item)
            End While

            dataFile.Close()

            For index = 1 To InvItems.Count
                item = CType(InvItems(index), Inventory)
                lbAllItems.Items.Add(CInt(item.InvNum + ", " + item.Description + ", ") + item.OnHand)
            Next
        Catch ex As Exception
            'Throws error if file could Not be created
            If ex.ToString().Equals("System.IO.FileNotFoundException") Then
                MessageBox.Show("Unable To Create File. Please Try Again", "Error In Saving")
            End If
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
        'clear button function
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim item As Inventory
        inputFile = New StreamWriter("inventory.txt")
        For index = 1 To InvItems.Count
            item = CType(InvItems(index), Inventory)

            inputFile.WriteLine(item.InvNum.ToString())
            inputFile.WriteLine(item.Description.ToString())
            inputFile.WriteLine(item.Cost.ToString())
            inputFile.WriteLine(item.OnHand.ToString())
            inputFile.WriteLine(item.Retail.ToString())

        Next
        inputFile.Close()
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim num As String = txtInvNumber.Text
        Dim item As Inventory
        inputFile = New StreamWriter("inventory.txt")

        If txtInvNumber.Text = " " Then
            MessageBox.Show("Please enter the item inventory number you wish to update", "Warning")
        Else
            For index = 1 To InvItems.Count
                item = CType(InvItems(index), Inventory)
                If num = item.InvNum Then

                    item.InvNum = txtInvNumber.Text
                    item.Description = txtDescription.Text
                    item.Cost = CDec(txtCost.Text)
                    item.OnHand = CInt(txtOnHand.Text)
                    item.Retail = CDec(txtRetailPrice.Text)

                    inputFile = File.AppendText("inventory.txt") 'Inventory Object

                    inputFile.WriteLine(item.InvNum.ToString())
                    inputFile.WriteLine(item.Description.ToString())
                    inputFile.WriteLine(item.Cost.ToString())
                    inputFile.WriteLine(item.OnHand.ToString())
                    inputFile.WriteLine(item.Retail.ToString())

                    inputFile.Close()

                    MessageBox.Show("Item successfully updated", "Done")
                    ClearFields()
                    lbAllItems.Items.Clear()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub btnShowItems_Click(sender As Object, e As EventArgs)
        Dim item As Inventory
        For Each item In InvItems
            lbAllItems.Items.Add(item.Description)
        Next

        If lbAllItems.Items.Count > 0 Then
            lbAllItems.SelectedIndex = 0
        Else
            ClearFields()
        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs)
        Dim intIndex As Integer
        If lbAllItems.SelectedIndex <> -1 Then
            If MessageBox.Show("Are you sure?", "Confirm Deletion", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                intIndex = lbAllItems.SelectedIndex
                Try
                    InvItems.Remove(lbAllItems.SelectedItem.ToString())
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
End Class

