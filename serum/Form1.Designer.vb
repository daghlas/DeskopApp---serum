<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM1
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
        Me.components = New System.ComponentModel.Container()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_jname = New System.Windows.Forms.TextBox()
        Me.dtp_dob = New System.Windows.Forms.DateTimePicker()
        Me.cb_ftype = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.lbl_jname = New System.Windows.Forms.Label()
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.lbl_dss = New System.Windows.Forms.Label()
        Me.lbl_dob = New System.Windows.Forms.Label()
        Me.lbl_ftype = New System.Windows.Forms.Label()
        Me.lbl_fnum = New System.Windows.Forms.Label()
        Me.lbl_int = New System.Windows.Forms.Label()
        Me.lbl_expected = New System.Windows.Forms.Label()
        Me.dtp_int = New System.Windows.Forms.DateTimePicker()
        Me.nup_visit = New System.Windows.Forms.NumericUpDown()
        Me.dtp_expected = New System.Windows.Forms.DateTimePicker()
        Me.lbl_intf = New System.Windows.Forms.TextBox()
        Me.lbl_expectedf = New System.Windows.Forms.TextBox()
        Me.lbl_taken = New System.Windows.Forms.Label()
        Me.cmb_taken = New System.Windows.Forms.ComboBox()
        Me.lbl_ifno = New System.Windows.Forms.Label()
        Me.cmb_ifno = New System.Windows.Forms.ComboBox()
        Me.lbl_other = New System.Windows.Forms.Label()
        Me.txt_other = New System.Windows.Forms.TextBox()
        Me.lbl_ifyes = New System.Windows.Forms.Label()
        Me.lbl_convserum = New System.Windows.Forms.Label()
        Me.dtp_convserum = New System.Windows.Forms.DateTimePicker()
        Me.lbl_convserumf = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.lbl_csl = New System.Windows.Forms.Label()
        Me.txt_csl = New System.Windows.Forms.TextBox()
        Me.txt_dss = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.dgv_details = New System.Windows.Forms.DataGridView()
        Me.VisitidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtpdobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtpintDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtpexpectedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConvtakenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmbifnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtotherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtpconvserumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblserumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DssDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConvserumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConvserumDataSet = New serum.convserumDataSet()
        Me.lbl_from = New System.Windows.Forms.Label()
        Me.lbl_to = New System.Windows.Forms.Label()
        Me.Conv_serumTableAdapter = New serum.convserumDataSetTableAdapters.conv_serumTableAdapter()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.btn_display = New System.Windows.Forms.Button()
        CType(Me.nup_visit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConvserumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConvserumDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(152, 100)
        Me.txt_fname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(392, 22)
        Me.txt_fname.TabIndex = 4
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(152, 162)
        Me.txt_lname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(392, 22)
        Me.txt_lname.TabIndex = 5
        '
        'txt_jname
        '
        Me.txt_jname.Location = New System.Drawing.Point(152, 132)
        Me.txt_jname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_jname.Name = "txt_jname"
        Me.txt_jname.Size = New System.Drawing.Size(392, 22)
        Me.txt_jname.TabIndex = 6
        '
        'dtp_dob
        '
        Me.dtp_dob.CustomFormat = "yyyy/m/dd"
        Me.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dob.Location = New System.Drawing.Point(244, 196)
        Me.dtp_dob.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_dob.Name = "dtp_dob"
        Me.dtp_dob.Size = New System.Drawing.Size(300, 22)
        Me.dtp_dob.TabIndex = 10
        '
        'cb_ftype
        '
        Me.cb_ftype.FormattingEnabled = True
        Me.cb_ftype.Items.AddRange(New Object() {"HMS Adult", "HMS Child"})
        Me.cb_ftype.Location = New System.Drawing.Point(144, 228)
        Me.cb_ftype.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_ftype.Name = "cb_ftype"
        Me.cb_ftype.Size = New System.Drawing.Size(160, 24)
        Me.cb_ftype.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "1.0 Name of the participant"
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Location = New System.Drawing.Point(62, 108)
        Me.lbl_fname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(72, 16)
        Me.lbl_fname.TabIndex = 14
        Me.lbl_fname.Text = "First Name"
        '
        'lbl_jname
        '
        Me.lbl_jname.AutoSize = True
        Me.lbl_jname.Location = New System.Drawing.Point(62, 135)
        Me.lbl_jname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_jname.Name = "lbl_jname"
        Me.lbl_jname.Size = New System.Drawing.Size(76, 16)
        Me.lbl_jname.TabIndex = 15
        Me.lbl_jname.Text = "Juok Name"
        '
        'lbl_lname
        '
        Me.lbl_lname.AutoSize = True
        Me.lbl_lname.Location = New System.Drawing.Point(62, 165)
        Me.lbl_lname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(72, 16)
        Me.lbl_lname.TabIndex = 16
        Me.lbl_lname.Text = "Last Name"
        '
        'lbl_dss
        '
        Me.lbl_dss.AutoSize = True
        Me.lbl_dss.Location = New System.Drawing.Point(349, 34)
        Me.lbl_dss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_dss.Name = "lbl_dss"
        Me.lbl_dss.Size = New System.Drawing.Size(119, 16)
        Me.lbl_dss.TabIndex = 17
        Me.lbl_dss.Text = "DSS Permanent ID"
        '
        'lbl_dob
        '
        Me.lbl_dob.AutoSize = True
        Me.lbl_dob.Location = New System.Drawing.Point(36, 197)
        Me.lbl_dob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_dob.Name = "lbl_dob"
        Me.lbl_dob.Size = New System.Drawing.Size(183, 16)
        Me.lbl_dob.TabIndex = 18
        Me.lbl_dob.Text = "2.0 Date of birth (dd/mm/yyyy)"
        '
        'lbl_ftype
        '
        Me.lbl_ftype.AutoSize = True
        Me.lbl_ftype.Location = New System.Drawing.Point(36, 231)
        Me.lbl_ftype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ftype.Name = "lbl_ftype"
        Me.lbl_ftype.Size = New System.Drawing.Size(93, 16)
        Me.lbl_ftype.TabIndex = 19
        Me.lbl_ftype.Text = "3.0 Form Type"
        '
        'lbl_fnum
        '
        Me.lbl_fnum.AutoSize = True
        Me.lbl_fnum.Location = New System.Drawing.Point(27, 34)
        Me.lbl_fnum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_fnum.Name = "lbl_fnum"
        Me.lbl_fnum.Size = New System.Drawing.Size(117, 16)
        Me.lbl_fnum.TabIndex = 20
        Me.lbl_fnum.Text = "4.0 Original Visit ID"
        '
        'lbl_int
        '
        Me.lbl_int.AutoSize = True
        Me.lbl_int.Location = New System.Drawing.Point(36, 266)
        Me.lbl_int.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_int.Name = "lbl_int"
        Me.lbl_int.Size = New System.Drawing.Size(125, 16)
        Me.lbl_int.TabIndex = 21
        Me.lbl_int.Text = "5.0 Date of interview"
        '
        'lbl_expected
        '
        Me.lbl_expected.AutoSize = True
        Me.lbl_expected.Location = New System.Drawing.Point(36, 306)
        Me.lbl_expected.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_expected.Name = "lbl_expected"
        Me.lbl_expected.Size = New System.Drawing.Size(253, 16)
        Me.lbl_expected.TabIndex = 22
        Me.lbl_expected.Text = "6.0 Expected date of Convalescent serum"
        '
        'dtp_int
        '
        Me.dtp_int.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_int.Location = New System.Drawing.Point(200, 266)
        Me.dtp_int.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_int.Name = "dtp_int"
        Me.dtp_int.Size = New System.Drawing.Size(265, 22)
        Me.dtp_int.TabIndex = 24
        '
        'nup_visit
        '
        Me.nup_visit.Location = New System.Drawing.Point(163, 30)
        Me.nup_visit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nup_visit.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nup_visit.Name = "nup_visit"
        Me.nup_visit.Size = New System.Drawing.Size(160, 22)
        Me.nup_visit.TabIndex = 25
        '
        'dtp_expected
        '
        Me.dtp_expected.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_expected.Location = New System.Drawing.Point(313, 306)
        Me.dtp_expected.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_expected.Name = "dtp_expected"
        Me.dtp_expected.Size = New System.Drawing.Size(265, 22)
        Me.dtp_expected.TabIndex = 26
        '
        'lbl_intf
        '
        Me.lbl_intf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_intf.Location = New System.Drawing.Point(475, 266)
        Me.lbl_intf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_intf.Name = "lbl_intf"
        Me.lbl_intf.ReadOnly = True
        Me.lbl_intf.Size = New System.Drawing.Size(184, 15)
        Me.lbl_intf.TabIndex = 27
        Me.lbl_intf.Text = "(dd/mm/yyyy)"
        '
        'lbl_expectedf
        '
        Me.lbl_expectedf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_expectedf.Location = New System.Drawing.Point(588, 306)
        Me.lbl_expectedf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_expectedf.Name = "lbl_expectedf"
        Me.lbl_expectedf.ReadOnly = True
        Me.lbl_expectedf.Size = New System.Drawing.Size(184, 15)
        Me.lbl_expectedf.TabIndex = 28
        Me.lbl_expectedf.Text = "(dd/mm/yyyy)"
        '
        'lbl_taken
        '
        Me.lbl_taken.AutoSize = True
        Me.lbl_taken.Location = New System.Drawing.Point(36, 350)
        Me.lbl_taken.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_taken.Name = "lbl_taken"
        Me.lbl_taken.Size = New System.Drawing.Size(226, 16)
        Me.lbl_taken.TabIndex = 29
        Me.lbl_taken.Text = "9.0 Was Convalescent serum taken ?"
        '
        'cmb_taken
        '
        Me.cmb_taken.FormattingEnabled = True
        Me.cmb_taken.Items.AddRange(New Object() {"Yes", "No", "Dont Know"})
        Me.cmb_taken.Location = New System.Drawing.Point(291, 347)
        Me.cmb_taken.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_taken.Name = "cmb_taken"
        Me.cmb_taken.Size = New System.Drawing.Size(160, 24)
        Me.cmb_taken.TabIndex = 30
        '
        'lbl_ifno
        '
        Me.lbl_ifno.AutoSize = True
        Me.lbl_ifno.Location = New System.Drawing.Point(62, 377)
        Me.lbl_ifno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ifno.Name = "lbl_ifno"
        Me.lbl_ifno.Size = New System.Drawing.Size(384, 16)
        Me.lbl_ifno.TabIndex = 31
        Me.lbl_ifno.Text = "a) If No, state reason why convalescent serum was not collected"
        '
        'cmb_ifno
        '
        Me.cmb_ifno.Enabled = False
        Me.cmb_ifno.FormattingEnabled = True
        Me.cmb_ifno.Items.AddRange(New Object() {"Paticipant did not return within 14 weeks after date of collection of acute serum" &
                ".", "Paticipant refused specimen collection.", "Surveilance officer failed to get a vein.", "Participant is known to be dead.", "Other"})
        Me.cmb_ifno.Location = New System.Drawing.Point(487, 373)
        Me.cmb_ifno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_ifno.Name = "cmb_ifno"
        Me.cmb_ifno.Size = New System.Drawing.Size(370, 24)
        Me.cmb_ifno.TabIndex = 32
        '
        'lbl_other
        '
        Me.lbl_other.AutoSize = True
        Me.lbl_other.Location = New System.Drawing.Point(76, 407)
        Me.lbl_other.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_other.Name = "lbl_other"
        Me.lbl_other.Size = New System.Drawing.Size(95, 16)
        Me.lbl_other.TabIndex = 33
        Me.lbl_other.Text = "Other (Specify)"
        '
        'txt_other
        '
        Me.txt_other.Enabled = False
        Me.txt_other.Location = New System.Drawing.Point(187, 404)
        Me.txt_other.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_other.Name = "txt_other"
        Me.txt_other.Size = New System.Drawing.Size(392, 22)
        Me.txt_other.TabIndex = 34
        '
        'lbl_ifyes
        '
        Me.lbl_ifyes.AutoSize = True
        Me.lbl_ifyes.Location = New System.Drawing.Point(62, 432)
        Me.lbl_ifyes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ifyes.Name = "lbl_ifyes"
        Me.lbl_ifyes.Size = New System.Drawing.Size(156, 16)
        Me.lbl_ifyes.TabIndex = 35
        Me.lbl_ifyes.Text = "b) If Yes, continue below ;"
        '
        'lbl_convserum
        '
        Me.lbl_convserum.AutoSize = True
        Me.lbl_convserum.Location = New System.Drawing.Point(76, 462)
        Me.lbl_convserum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_convserum.Name = "lbl_convserum"
        Me.lbl_convserum.Size = New System.Drawing.Size(175, 16)
        Me.lbl_convserum.TabIndex = 36
        Me.lbl_convserum.Text = "Date of Convalescent serum"
        '
        'dtp_convserum
        '
        Me.dtp_convserum.Enabled = False
        Me.dtp_convserum.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_convserum.Location = New System.Drawing.Point(272, 462)
        Me.dtp_convserum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_convserum.Name = "dtp_convserum"
        Me.dtp_convserum.Size = New System.Drawing.Size(265, 22)
        Me.dtp_convserum.TabIndex = 37
        '
        'lbl_convserumf
        '
        Me.lbl_convserumf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_convserumf.Location = New System.Drawing.Point(547, 462)
        Me.lbl_convserumf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_convserumf.Name = "lbl_convserumf"
        Me.lbl_convserumf.ReadOnly = True
        Me.lbl_convserumf.Size = New System.Drawing.Size(184, 15)
        Me.lbl_convserumf.TabIndex = 38
        Me.lbl_convserumf.Text = "(dd/mm/yyyy)"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(759, 510)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 28)
        Me.btn_save.TabIndex = 39
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'lbl_csl
        '
        Me.lbl_csl.AutoSize = True
        Me.lbl_csl.Location = New System.Drawing.Point(36, 500)
        Me.lbl_csl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_csl.Name = "lbl_csl"
        Me.lbl_csl.Size = New System.Drawing.Size(162, 16)
        Me.lbl_csl.TabIndex = 40
        Me.lbl_csl.Text = "Convalescent serum label"
        '
        'txt_csl
        '
        Me.txt_csl.Enabled = False
        Me.txt_csl.Location = New System.Drawing.Point(215, 496)
        Me.txt_csl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_csl.Name = "txt_csl"
        Me.txt_csl.Size = New System.Drawing.Size(132, 22)
        Me.txt_csl.TabIndex = 41
        '
        'txt_dss
        '
        Me.txt_dss.Location = New System.Drawing.Point(487, 30)
        Me.txt_dss.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_dss.Name = "txt_dss"
        Me.txt_dss.Size = New System.Drawing.Size(129, 22)
        Me.txt_dss.TabIndex = 42
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(504, 510)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(100, 28)
        Me.btn_delete.TabIndex = 43
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(631, 510)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(100, 28)
        Me.btn_update.TabIndex = 44
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'dgv_details
        '
        Me.dgv_details.AllowUserToAddRows = False
        Me.dgv_details.AllowUserToDeleteRows = False
        Me.dgv_details.AutoGenerateColumns = False
        Me.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_details.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VisitidDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.JnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.DtpdobDataGridViewTextBoxColumn, Me.FtypeDataGridViewTextBoxColumn, Me.DtpintDataGridViewTextBoxColumn, Me.DtpexpectedDataGridViewTextBoxColumn, Me.ConvtakenDataGridViewTextBoxColumn, Me.CmbifnoDataGridViewTextBoxColumn, Me.TxtotherDataGridViewTextBoxColumn, Me.DtpconvserumDataGridViewTextBoxColumn, Me.LblserumDataGridViewTextBoxColumn, Me.DssDataGridViewTextBoxColumn})
        Me.dgv_details.DataSource = Me.ConvserumBindingSource
        Me.dgv_details.Location = New System.Drawing.Point(631, 30)
        Me.dgv_details.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_details.Name = "dgv_details"
        Me.dgv_details.ReadOnly = True
        Me.dgv_details.RowHeadersWidth = 62
        Me.dgv_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_details.Size = New System.Drawing.Size(494, 268)
        Me.dgv_details.TabIndex = 45
        '
        'VisitidDataGridViewTextBoxColumn
        '
        Me.VisitidDataGridViewTextBoxColumn.DataPropertyName = "visit_id"
        Me.VisitidDataGridViewTextBoxColumn.HeaderText = "visit_id"
        Me.VisitidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.VisitidDataGridViewTextBoxColumn.Name = "VisitidDataGridViewTextBoxColumn"
        Me.VisitidDataGridViewTextBoxColumn.ReadOnly = True
        Me.VisitidDataGridViewTextBoxColumn.Width = 150
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "fname"
        Me.FnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FnameDataGridViewTextBoxColumn.Width = 150
        '
        'JnameDataGridViewTextBoxColumn
        '
        Me.JnameDataGridViewTextBoxColumn.DataPropertyName = "jname"
        Me.JnameDataGridViewTextBoxColumn.HeaderText = "jname"
        Me.JnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JnameDataGridViewTextBoxColumn.Name = "JnameDataGridViewTextBoxColumn"
        Me.JnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.JnameDataGridViewTextBoxColumn.Width = 150
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "lname"
        Me.LnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        Me.LnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LnameDataGridViewTextBoxColumn.Width = 150
        '
        'DtpdobDataGridViewTextBoxColumn
        '
        Me.DtpdobDataGridViewTextBoxColumn.DataPropertyName = "dtp_dob"
        Me.DtpdobDataGridViewTextBoxColumn.HeaderText = "dtp_dob"
        Me.DtpdobDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DtpdobDataGridViewTextBoxColumn.Name = "DtpdobDataGridViewTextBoxColumn"
        Me.DtpdobDataGridViewTextBoxColumn.ReadOnly = True
        Me.DtpdobDataGridViewTextBoxColumn.Width = 150
        '
        'FtypeDataGridViewTextBoxColumn
        '
        Me.FtypeDataGridViewTextBoxColumn.DataPropertyName = "ftype"
        Me.FtypeDataGridViewTextBoxColumn.HeaderText = "ftype"
        Me.FtypeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FtypeDataGridViewTextBoxColumn.Name = "FtypeDataGridViewTextBoxColumn"
        Me.FtypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.FtypeDataGridViewTextBoxColumn.Width = 150
        '
        'DtpintDataGridViewTextBoxColumn
        '
        Me.DtpintDataGridViewTextBoxColumn.DataPropertyName = "dtp_int"
        Me.DtpintDataGridViewTextBoxColumn.HeaderText = "dtp_int"
        Me.DtpintDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DtpintDataGridViewTextBoxColumn.Name = "DtpintDataGridViewTextBoxColumn"
        Me.DtpintDataGridViewTextBoxColumn.ReadOnly = True
        Me.DtpintDataGridViewTextBoxColumn.Width = 150
        '
        'DtpexpectedDataGridViewTextBoxColumn
        '
        Me.DtpexpectedDataGridViewTextBoxColumn.DataPropertyName = "dtp_expected"
        Me.DtpexpectedDataGridViewTextBoxColumn.HeaderText = "dtp_expected"
        Me.DtpexpectedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DtpexpectedDataGridViewTextBoxColumn.Name = "DtpexpectedDataGridViewTextBoxColumn"
        Me.DtpexpectedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DtpexpectedDataGridViewTextBoxColumn.Width = 150
        '
        'ConvtakenDataGridViewTextBoxColumn
        '
        Me.ConvtakenDataGridViewTextBoxColumn.DataPropertyName = "conv_taken"
        Me.ConvtakenDataGridViewTextBoxColumn.HeaderText = "conv_taken"
        Me.ConvtakenDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ConvtakenDataGridViewTextBoxColumn.Name = "ConvtakenDataGridViewTextBoxColumn"
        Me.ConvtakenDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConvtakenDataGridViewTextBoxColumn.Width = 150
        '
        'CmbifnoDataGridViewTextBoxColumn
        '
        Me.CmbifnoDataGridViewTextBoxColumn.DataPropertyName = "cmb_ifno"
        Me.CmbifnoDataGridViewTextBoxColumn.HeaderText = "cmb_ifno"
        Me.CmbifnoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CmbifnoDataGridViewTextBoxColumn.Name = "CmbifnoDataGridViewTextBoxColumn"
        Me.CmbifnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CmbifnoDataGridViewTextBoxColumn.Width = 150
        '
        'TxtotherDataGridViewTextBoxColumn
        '
        Me.TxtotherDataGridViewTextBoxColumn.DataPropertyName = "txt_other"
        Me.TxtotherDataGridViewTextBoxColumn.HeaderText = "txt_other"
        Me.TxtotherDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TxtotherDataGridViewTextBoxColumn.Name = "TxtotherDataGridViewTextBoxColumn"
        Me.TxtotherDataGridViewTextBoxColumn.ReadOnly = True
        Me.TxtotherDataGridViewTextBoxColumn.Width = 150
        '
        'DtpconvserumDataGridViewTextBoxColumn
        '
        Me.DtpconvserumDataGridViewTextBoxColumn.DataPropertyName = "dtp_convserum"
        Me.DtpconvserumDataGridViewTextBoxColumn.HeaderText = "dtp_convserum"
        Me.DtpconvserumDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DtpconvserumDataGridViewTextBoxColumn.Name = "DtpconvserumDataGridViewTextBoxColumn"
        Me.DtpconvserumDataGridViewTextBoxColumn.ReadOnly = True
        Me.DtpconvserumDataGridViewTextBoxColumn.Width = 150
        '
        'LblserumDataGridViewTextBoxColumn
        '
        Me.LblserumDataGridViewTextBoxColumn.DataPropertyName = "lbl_serum"
        Me.LblserumDataGridViewTextBoxColumn.HeaderText = "lbl_serum"
        Me.LblserumDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LblserumDataGridViewTextBoxColumn.Name = "LblserumDataGridViewTextBoxColumn"
        Me.LblserumDataGridViewTextBoxColumn.ReadOnly = True
        Me.LblserumDataGridViewTextBoxColumn.Width = 150
        '
        'DssDataGridViewTextBoxColumn
        '
        Me.DssDataGridViewTextBoxColumn.DataPropertyName = "dss"
        Me.DssDataGridViewTextBoxColumn.HeaderText = "dss"
        Me.DssDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DssDataGridViewTextBoxColumn.Name = "DssDataGridViewTextBoxColumn"
        Me.DssDataGridViewTextBoxColumn.ReadOnly = True
        Me.DssDataGridViewTextBoxColumn.Width = 150
        '
        'ConvserumBindingSource
        '
        Me.ConvserumBindingSource.DataMember = "conv_serum"
        Me.ConvserumBindingSource.DataSource = Me.ConvserumDataSet
        '
        'ConvserumDataSet
        '
        Me.ConvserumDataSet.DataSetName = "convserumDataSet"
        Me.ConvserumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_from
        '
        Me.lbl_from.AutoSize = True
        Me.lbl_from.Location = New System.Drawing.Point(900, 310)
        Me.lbl_from.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_from.Name = "lbl_from"
        Me.lbl_from.Size = New System.Drawing.Size(38, 16)
        Me.lbl_from.TabIndex = 46
        Me.lbl_from.Text = "From"
        '
        'lbl_to
        '
        Me.lbl_to.AutoSize = True
        Me.lbl_to.Location = New System.Drawing.Point(917, 331)
        Me.lbl_to.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(24, 16)
        Me.lbl_to.TabIndex = 47
        Me.lbl_to.Text = "To"
        '
        'Conv_serumTableAdapter
        '
        Me.Conv_serumTableAdapter.ClearBeforeFill = True
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(878, 510)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(100, 28)
        Me.btn_search.TabIndex = 51
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'dtp_from
        '
        Me.dtp_from.CustomFormat = ""
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(948, 306)
        Me.dtp_from.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(178, 22)
        Me.dtp_from.TabIndex = 52
        '
        'dtp_to
        '
        Me.dtp_to.CustomFormat = ""
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(948, 331)
        Me.dtp_to.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(178, 22)
        Me.dtp_to.TabIndex = 53
        '
        'btn_display
        '
        Me.btn_display.Location = New System.Drawing.Point(1059, 367)
        Me.btn_display.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_display.Name = "btn_display"
        Me.btn_display.Size = New System.Drawing.Size(67, 26)
        Me.btn_display.TabIndex = 54
        Me.btn_display.Text = "Display"
        Me.btn_display.UseVisualStyleBackColor = True
        '
        'FORM1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 554)
        Me.Controls.Add(Me.btn_display)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.lbl_to)
        Me.Controls.Add(Me.lbl_from)
        Me.Controls.Add(Me.dgv_details)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txt_dss)
        Me.Controls.Add(Me.txt_csl)
        Me.Controls.Add(Me.lbl_csl)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.lbl_convserumf)
        Me.Controls.Add(Me.dtp_convserum)
        Me.Controls.Add(Me.lbl_convserum)
        Me.Controls.Add(Me.lbl_ifyes)
        Me.Controls.Add(Me.txt_other)
        Me.Controls.Add(Me.lbl_other)
        Me.Controls.Add(Me.cmb_ifno)
        Me.Controls.Add(Me.lbl_ifno)
        Me.Controls.Add(Me.cmb_taken)
        Me.Controls.Add(Me.lbl_taken)
        Me.Controls.Add(Me.lbl_expectedf)
        Me.Controls.Add(Me.lbl_intf)
        Me.Controls.Add(Me.dtp_expected)
        Me.Controls.Add(Me.nup_visit)
        Me.Controls.Add(Me.dtp_int)
        Me.Controls.Add(Me.lbl_expected)
        Me.Controls.Add(Me.lbl_int)
        Me.Controls.Add(Me.lbl_fnum)
        Me.Controls.Add(Me.lbl_ftype)
        Me.Controls.Add(Me.lbl_dob)
        Me.Controls.Add(Me.lbl_dss)
        Me.Controls.Add(Me.lbl_lname)
        Me.Controls.Add(Me.lbl_jname)
        Me.Controls.Add(Me.lbl_fname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_ftype)
        Me.Controls.Add(Me.dtp_dob)
        Me.Controls.Add(Me.txt_jname)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.txt_fname)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FORM1"
        CType(Me.nup_visit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConvserumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConvserumDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_jname As TextBox
    Friend WithEvents dtp_dob As DateTimePicker
    Friend WithEvents cb_ftype As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_fname As Label
    Friend WithEvents lbl_jname As Label
    Friend WithEvents lbl_lname As Label
    Friend WithEvents lbl_dss As Label
    Friend WithEvents lbl_dob As Label
    Friend WithEvents lbl_ftype As Label
    Friend WithEvents lbl_fnum As Label
    Friend WithEvents lbl_int As Label
    Friend WithEvents lbl_expected As Label
    Friend WithEvents dtp_int As DateTimePicker
    Friend WithEvents nup_visit As NumericUpDown
    Friend WithEvents dtp_expected As DateTimePicker
    Friend WithEvents lbl_intf As TextBox
    Friend WithEvents lbl_expectedf As TextBox
    Friend WithEvents lbl_taken As Label
    Friend WithEvents cmb_taken As ComboBox
    Friend WithEvents lbl_ifno As Label
    Friend WithEvents cmb_ifno As ComboBox
    Friend WithEvents lbl_other As Label
    Friend WithEvents txt_other As TextBox
    Friend WithEvents lbl_ifyes As Label
    Friend WithEvents lbl_convserum As Label
    Friend WithEvents dtp_convserum As DateTimePicker
    Friend WithEvents lbl_convserumf As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents lbl_csl As Label
    Friend WithEvents txt_csl As TextBox
    Friend WithEvents txt_dss As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents dgv_details As DataGridView
    Friend WithEvents ConvserumDataSet As convserumDataSet
    Friend WithEvents ConvserumBindingSource As BindingSource
    Friend WithEvents Conv_serumTableAdapter As convserumDataSetTableAdapters.conv_serumTableAdapter
    Friend WithEvents lbl_from As Label
    Friend WithEvents lbl_to As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents VisitidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DtpdobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DtpintDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DtpexpectedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConvtakenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CmbifnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TxtotherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DtpconvserumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LblserumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DssDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dtp_from As DateTimePicker
    Friend WithEvents dtp_to As DateTimePicker
    Friend WithEvents btn_display As Button
End Class
