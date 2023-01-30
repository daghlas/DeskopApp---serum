Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.WindowsRuntime
Imports serum.convserumDataSetTableAdapters

Public Class FORM1
    Dim db As New DataClasses1DataContext
    Dim i As Integer
    Dim return_date As Date

    Private Sub cmb_taken_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_taken.SelectedIndexChanged
        If cmb_taken.Text = "No" Then
            return_date = "1999-09-09"
            dtp_convserum.Value = return_date
            cmb_ifno.Enabled = True
            dtp_convserum.Enabled = False
            txt_other.Enabled = False
            txt_csl.Enabled = False
            txt_other.Clear()
            txt_csl.Clear()
        ElseIf cmb_taken.Text = "Yes" Then
            cmb_ifno.Enabled = False
            dtp_convserum.Enabled = True
            txt_other.Enabled = False
            txt_csl.Enabled = True
            cmb_ifno.SelectedIndex = -1
            txt_other.Clear()
        ElseIf cmb_taken.Text = "Dont Know" Then
            return_date = "1999-09-09"
            dtp_convserum.Value = return_date
            cmb_ifno.Enabled = False
            dtp_convserum.Enabled = False
            txt_other.Enabled = False
            txt_csl.Enabled = False
            cmb_ifno.SelectedIndex = -1
            txt_csl.Clear()
            txt_other.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub cmb_ifno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ifno.SelectedIndexChanged
        If cmb_ifno.Text = "Other" Then
            txt_other.Enabled = True
        Else
            txt_other.Enabled = False
            txt_other.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub cb_ftype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_ftype.SelectedIndexChanged
        If dtp_int.Value < DateAdd(DateInterval.Year, 5, dtp_dob.Value) Then
            cb_ftype.Text = "HMS Child"
        ElseIf dtp_int.Value > DateAdd(DateInterval.Year, 5, dtp_dob.Value) Then
            cb_ftype.Text = "HMS Adult"
            Exit Sub
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If nup_visit.Value < 44680 Then
            MsgBox("Enter valid original visit id")
            Exit Sub
        End If
        If txt_fname.Text = "" Then
            MsgBox("Enter First Name")
            txt_fname.Focus()
            Exit Sub
        End If
        If txt_jname.Text = "" Then
            MsgBox("Enter Juok Name")
            txt_jname.Focus()
            Exit Sub
        End If
        If txt_lname.Text = "" Then
            MsgBox("Enter Last Name")
            txt_lname.Focus()
            Exit Sub
        End If
        If txt_dss.Text = "" Then
            MsgBox("Enter DSS")
            txt_dss.Focus()
            Exit Sub
        End If
        If dtp_dob.Value > Date.Today Then
            MsgBox("Enter Valid date of birth")
            Exit Sub
        End If
        If cb_ftype.Text = "" Then
            MsgBox("Enter form type.")
        ElseIf dtp_int.Value > DateAdd(DateInterval.Year, 5, dtp_dob.Value) And cb_ftype.Text = "HMS Child" Then
            MsgBox("Enter Valid form type")
            Exit Sub
        ElseIf dtp_int.Value < DateAdd(DateInterval.Year, 5, dtp_dob.Value) And cb_ftype.Text = "HMS Adult" Then
            MsgBox("Enter Valid form type")
            Exit Sub
        End If
        If dtp_int.Value < DateAdd(DateInterval.Day, 0, dtp_dob.Value) Then
            MsgBox("Enter valid date of interview")
            Exit Sub
        End If
        If dtp_expected.Value < DateAdd(DateInterval.Day, 2, dtp_int.Value) Then
            MsgBox("Enter valid expected date")
            Exit Sub
        ElseIf dtp_expected.Value > DateAdd(DateInterval.Day, 60, dtp_int.Value) Then
            MsgBox("Enter valid expected date")
            Exit Sub
        End If
        If dtp_convserum.Value < DateAdd(DateInterval.Day, 2, dtp_int.Value) Then
            MsgBox("Enter valid  Serum date")
            Exit Sub
        ElseIf dtp_convserum.Value > DateAdd(DateInterval.Day, 60, dtp_int.Value) Then
            MsgBox("Enter valid Serum date")
            Exit Sub
        End If
        If cmb_taken.Text = "" Then
            MsgBox("Enter if serum was taken or not.")
            Exit Sub
        End If
        If cmb_ifno.Text = "" And cmb_taken.Text = "No" Then
            MsgBox("Enter valid reason")
            Exit Sub
        End If
        If txt_other.Text = "" And cmb_ifno.Text = "Other" Then
            MsgBox("Specify other reason")
            Exit Sub
        ElseIf cmb_taken.Text = "Yes" Or cmb_taken.Text = "Dont Know" Then
            cmb_ifno.Text = ""
        End If
        If txt_csl.Text = "" And cmb_taken.Text = "Yes" Then
            MsgBox("Enter Serum Label")
            Exit Sub
        ElseIf cmb_taken.Text = "No" Or cmb_taken.Text = "Dont Know" Then
            txt_csl.Text = ""
            Exit Sub
        End If

        Try
            db.conv_serum1(nup_visit.Value, txt_fname.Text, txt_jname.Text,
                           txt_lname.Text, dtp_dob.Value.Date, cb_ftype.Text,
                           dtp_int.Value.Date, dtp_expected.Value.Date,
                           cmb_taken.Text, cmb_ifno.Text, txt_other.Text,
                           dtp_convserum.Value, txt_csl.Text, txt_dss.Text, 1)
            MsgBox("Successfully Saved")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim query As String = "SELECT* FROM conv_serum WHERE visit_id = '" & nup_visit.Value & "'"
        FillMyGrid(Me.dgv_details, query)
        ClearFormEntries()

    End Sub

    Public Sub ClearFormEntries()
        nup_visit.Value = 0
        txt_fname.Text = ""
        txt_jname.Text = ""
        txt_lname.Text = ""
        dtp_dob.Value = Date.Today
        cb_ftype.Text = ""
        dtp_int.Value = Date.Today
        dtp_expected.Value = Date.Today
        cmb_taken.Text = ""
        cmb_ifno.Text = ""
        txt_other.Text = ""
        dtp_convserum.Value = Date.Today
        txt_csl.Text = ""
        txt_dss.Text = ""
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        If cmb_ifno.Text = "" And cmb_taken.Text = "No" Then
            MsgBox("Enter valid reason")
            Exit Sub
        End If
        If txt_other.Text = "" And cmb_ifno.Text = "Other" Then
            MsgBox("Specify other reason")
            Exit Sub
        ElseIf cmb_taken.Text = "Yes" Or cmb_taken.Text = "Dont Know" Then
            cmb_ifno.Text = ""
        End If
        If txt_csl.Text = "" And cmb_taken.Text = "Yes" Then
            MsgBox("Enter Serum Label")
            Exit Sub
        ElseIf cmb_taken.Text = "No" Or cmb_taken.Text = "Dont Know" Then
            txt_csl.Clear()
        End If
        If dtp_convserum.Value < DateAdd(DateInterval.Day, 2, dtp_int.Value) And
            cmb_taken.Text = "Yes" Then
            MsgBox("Enter valid  Serum date")
            Exit Sub
        ElseIf dtp_convserum.Value > DateAdd(DateInterval.Day, 60, dtp_int.Value) Then
            MsgBox("Enter valid Serum date")
            Exit Sub
        End If

        Try
            db.conv_serum1(nup_visit.Value, txt_fname.Text, txt_jname.Text,
                           txt_lname.Text, dtp_dob.Value.Date, cb_ftype.Text,
                           dtp_int.Value.Date, dtp_expected.Value.Date,
                           cmb_taken.Text, cmb_ifno.Text, txt_other.Text,
                           dtp_convserum.Value.Date, txt_csl.Text, txt_dss.Text, 2)
            MsgBox("Successfully Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim query As String = "SELECT* FROM conv_serum WHERE visit_id = '" & nup_visit.Value & "'"
        FillMyGrid(Me.dgv_details, query)

        ClearFormEntries()
        btn_save.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            db.conv_serum1(nup_visit.Value, txt_fname.Text, txt_jname.Text,
                           txt_lname.Text, dtp_dob.Value.Date, cb_ftype.Text,
                           dtp_int.Value.Date, dtp_expected.Value.Date,
                           cmb_taken.Text, cmb_ifno.Text, txt_other.Text,
                           dtp_convserum.Value.Date, txt_csl.Text, txt_dss.Text, 3)
            MsgBox("Successfully Deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim query As String = "SELECT* FROM conv_serum"
        FillMyGrid(Me.dgv_details, query)

        ClearFormEntries()
        btn_save.Enabled = True

    End Sub

    Private Sub FORM1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Qconn.ConnectionString = "Data Source=.;Initial Catalog=convserum;Integrated Security=True"
        OpenCon()
        btn_delete.Enabled = False
        btn_update.Enabled = False
    End Sub


    Private Sub dgv_details_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_details.CellClick

        Try
            OpenCon()

            'i = Convert.ToInt32(dgv_details.SelectedCells.Item(0).Value.ToString())

            Dim dr As DataGridViewRow = dgv_details.SelectedRows(0)

            nup_visit.Value = dr.Cells(0).Value.ToString()
            txt_fname.Text = dr.Cells(1).Value.ToString()
            txt_jname.Text = dr.Cells(2).Value.ToString()
            txt_lname.Text = dr.Cells(3).Value.ToString()
            dtp_dob.Value = dr.Cells(4).Value.ToString()
            cb_ftype.Text = dr.Cells(5).Value.ToString()
            dtp_int.Value = dr.Cells(6).Value.ToString()
            dtp_expected.Value = dr.Cells(7).Value
            cmb_taken.Text = dr.Cells(8).Value.ToString()
            cmb_ifno.Text = dr.Cells(9).Value.ToString()
            txt_other.Text = dr.Cells(10).Value.ToString()
            dtp_convserum.Value = dr.Cells(11).Value
            txt_csl.Text = dr.Cells(12).Value.ToString()
            txt_dss.Text = dr.Cells(13).Value.ToString()

        Catch ex As Exception

        End Try
        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_update.Enabled = True

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Try
            If nup_visit.Value < 44680 Then
                MsgBox("Enter valid visit ID")
                Exit Sub
            End If
            Dim query As String = "SELECT* FROM conv_serum WHERE visit_id = '" & nup_visit.Value & "'"
            FillMyGrid(Me.dgv_details, query)

            If dgv_details.Rows.Count() < 1 Then
                MsgBox("No Data")
                nup_visit.Value = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        btn_save.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False
        ClearFormEntries()
    End Sub

    Private Sub dtp_convserum_ValueChanged(sender As Object, e As EventArgs) Handles dtp_convserum.ValueChanged
        If dtp_convserum.Format = DateTimePickerFormat.Custom AndAlso dtp_convserum.CustomFormat = " " Then
            dtp_convserum.Value = return_date
            'Enter a Null value to the database
        Else
            'Enter DateTimePicker1.Value into the database
        End If
    End Sub

    Private Sub btn_display_Click(sender As Object, e As EventArgs) Handles btn_display.Click
        Try
            Dim query As String = "SELECT* FROM conv_serum WHERE dtp_int BETWEEN '" & dtp_from.Value.Date & "'
            AND '" & dtp_to.Value.Date & "'"
            FillMyGrid(Me.dgv_details, query)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtp_to_ValueChanged(sender As Object, e As EventArgs) Handles dtp_to.ValueChanged

    End Sub
End Class