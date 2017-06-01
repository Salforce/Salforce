<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.EMPCOMPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPFIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPBIRTHDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPDEPARTMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPSTARTDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPENDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPSALARYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPPOSITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPSEXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPCEDULANRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPDPWDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPUPWDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPUURLOONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridMain = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.ToolStripUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.cmbCompanySelection = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel_COUNTRY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pctLogo = New System.Windows.Forms.PictureBox()
        Me.EMPTABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAB06 = New System.Windows.Forms.TabPage()
        Me.DGBerekening = New System.Windows.Forms.DataGridView()
        Me.TAB05 = New System.Windows.Forms.TabPage()
        Me.DGVergoedingenB = New System.Windows.Forms.DataGridView()
        Me.DGVergoedingen = New System.Windows.Forms.DataGridView()
        Me.TAB04 = New System.Windows.Forms.TabPage()
        Me.txtEmpNotities = New System.Windows.Forms.RichTextBox()
        Me.TAB03 = New System.Windows.Forms.TabPage()
        Me.txtVerwervingskosten = New System.Windows.Forms.TextBox()
        Me.lblVerwervingsKosten = New System.Windows.Forms.Label()
        Me.txtZOG_PERC = New System.Windows.Forms.MaskedTextBox()
        Me.txtZOGPREMIE = New System.Windows.Forms.TextBox()
        Me.txtBVZ_Amount = New System.Windows.Forms.TextBox()
        Me.txtOnkostenVergoeding = New System.Windows.Forms.TextBox()
        Me.txtTotalIncome = New System.Windows.Forms.TextBox()
        Me.txtValuta = New System.Windows.Forms.TextBox()
        Me.txtZV_Amount = New System.Windows.Forms.TextBox()
        Me.txtAOV_AWW = New System.Windows.Forms.TextBox()
        Me.txtAVBZ_AMOUNT = New System.Windows.Forms.TextBox()
        Me.txtPeriode = New System.Windows.Forms.TextBox()
        Me.txtUurloon = New System.Windows.Forms.TextBox()
        Me.txtAnderloon = New System.Windows.Forms.TextBox()
        Me.txtPensioenfonds = New System.Windows.Forms.TextBox()
        Me.txtAutoZaak = New System.Windows.Forms.TextBox()
        Me.txtKindToeslag = New System.Windows.Forms.TextBox()
        Me.txtAlleenVerdienerT = New System.Windows.Forms.TextBox()
        Me.txtOuderenToeslag = New System.Windows.Forms.TextBox()
        Me.txtBesInsp = New System.Windows.Forms.TextBox()
        Me.TXTSALARY = New System.Windows.Forms.TextBox()
        Me.txtZV_PERC = New System.Windows.Forms.MaskedTextBox()
        Me.lblTotalIncome = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkZV = New System.Windows.Forms.CheckBox()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.cmbPeriod = New System.Windows.Forms.ComboBox()
        Me.lblUurloon = New System.Windows.Forms.Label()
        Me.txtDagenPerWeek = New System.Windows.Forms.MaskedTextBox()
        Me.lblDagenPerweek = New System.Windows.Forms.Label()
        Me.txtUrenPerDag = New System.Windows.Forms.MaskedTextBox()
        Me.lblUrenPerweek = New System.Windows.Forms.Label()
        Me.txtLeeftijd1jan = New System.Windows.Forms.MaskedTextBox()
        Me.lblAgeOnfirstjan = New System.Windows.Forms.Label()
        Me.lblBelPlicht = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPensioen = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbvaluta = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBVZ_PERC = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOudtoeslag = New System.Windows.Forms.Label()
        Me.lblBeslInsp = New System.Windows.Forms.Label()
        Me.txtAVBZ_PERC = New System.Windows.Forms.MaskedTextBox()
        Me.txtAOVAWW_PERC = New System.Windows.Forms.MaskedTextBox()
        Me.lblZV = New System.Windows.Forms.Label()
        Me.lblAVBZ = New System.Windows.Forms.Label()
        Me.lblAOVAWW = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TAB02 = New System.Windows.Forms.TabPage()
        Me.txtPartnerBelInkomen = New System.Windows.Forms.TextBox()
        Me.TotalKtoeslag = New System.Windows.Forms.TextBox()
        Me.txtPartnerBirthDate = New System.Windows.Forms.TextBox()
        Me.txtChildrowcount = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.txtPartnerEmployer = New System.Windows.Forms.TextBox()
        Me.txtPartnerMidname = New System.Windows.Forms.TextBox()
        Me.txtPartnerLastname = New System.Windows.Forms.TextBox()
        Me.txtPartnerFirstname = New System.Windows.Forms.TextBox()
        Me.lblBelInkomen = New System.Windows.Forms.Label()
        Me.DatePickerPartnerBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.lblSpouseBirthDate = New System.Windows.Forms.Label()
        Me.lblSpouseEmployer = New System.Windows.Forms.Label()
        Me.lblSpouseMiddenName = New System.Windows.Forms.Label()
        Me.lblPartnerLastName = New System.Windows.Forms.Label()
        Me.lblspouseName = New System.Windows.Forms.Label()
        Me.TAB01 = New System.Windows.Forms.TabPage()
        Me.chk = New System.Windows.Forms.CheckBox()
        Me.cmbIsland = New System.Windows.Forms.ComboBox()
        Me.lblIsland = New System.Windows.Forms.Label()
        Me.txtDepartmentNr = New System.Windows.Forms.TextBox()
        Me.txtCompanyNr = New System.Windows.Forms.TextBox()
        Me.txtBirthdate = New System.Windows.Forms.TextBox()
        Me.txtDateEnd = New System.Windows.Forms.TextBox()
        Me.txtDateBegin = New System.Windows.Forms.TextBox()
        Me.txtEmployeeEmail2 = New System.Windows.Forms.TextBox()
        Me.txtEmployeeEmail1 = New System.Windows.Forms.TextBox()
        Me.txtEmployeefunction = New System.Windows.Forms.TextBox()
        Me.txtemployeeAddress = New System.Windows.Forms.TextBox()
        Me.txtemployeeLastName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeFirstName = New System.Windows.Forms.TextBox()
        Me.cmbSelectDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbSelectCompany = New System.Windows.Forms.ComboBox()
        Me.calEmployeeDateBegin = New System.Windows.Forms.DateTimePicker()
        Me.txtEmployeeMobile = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmployeeCel = New System.Windows.Forms.Label()
        Me.txtEmployeeHomePhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmployeeHomePhone = New System.Windows.Forms.Label()
        Me.lblEmployeeEmial2 = New System.Windows.Forms.Label()
        Me.lblEmployeeMail = New System.Windows.Forms.Label()
        Me.txtEmployeeVRW = New System.Windows.Forms.CheckBox()
        Me.txtEmployeeMAN = New System.Windows.Forms.CheckBox()
        Me.lblEmployeeSex = New System.Windows.Forms.Label()
        Me.txtEmployeeStatus = New System.Windows.Forms.NumericUpDown()
        Me.txtEmployeeNr = New System.Windows.Forms.MaskedTextBox()
        Me.lblemployeeNr = New System.Windows.Forms.Label()
        Me.lblEmployeePicture = New System.Windows.Forms.Label()
        Me.txtEmployeePicture = New System.Windows.Forms.MaskedTextBox()
        Me.EmpPictBox = New System.Windows.Forms.PictureBox()
        Me.lblEmployeeFunction = New System.Windows.Forms.Label()
        Me.CalendarPickerBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.lblEmployeeAdres = New System.Windows.Forms.Label()
        Me.lblEmployeeStatus = New System.Windows.Forms.Label()
        Me.lblEmployeeDepartment = New System.Windows.Forms.Label()
        Me.calEmployeeDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblEmployeeEnddate = New System.Windows.Forms.Label()
        Me.lblEmployeestartdate = New System.Windows.Forms.Label()
        Me.lblEmployeeGebDatum = New System.Windows.Forms.Label()
        Me.txtEmployeeCedulaNr = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmployeecedulaNr = New System.Windows.Forms.Label()
        Me.lblEmployeeLastname = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblEmployeeBedrijf = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TAB07 = New System.Windows.Forms.TabPage()
        Me.DGEmpDeductions = New System.Windows.Forms.DataGridView()
        Me.lblSpaarFondsNaam = New System.Windows.Forms.Label()
        Me.txtSpaarFondsNaam = New System.Windows.Forms.TextBox()
        Me.lblWerkgeversBijdrage = New System.Windows.Forms.Label()
        Me.txtSpaarFondsWGPerc = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSpaarFondsWNPerc = New System.Windows.Forms.MaskedTextBox()
        Me.lblPensioenfondsNaam = New System.Windows.Forms.Label()
        Me.txtPensioenfondsNaam = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPensWGPerc = New System.Windows.Forms.MaskedTextBox()
        Me.txtPensWNPerc = New System.Windows.Forms.MaskedTextBox()
        Me.CheckBoxSpaarfonds = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPensioen = New System.Windows.Forms.CheckBox()
        Me.txtVastBedragSpF = New System.Windows.Forms.TextBox()
        Me.txtVastBedragPF = New System.Windows.Forms.TextBox()
        Me.btnAddDD = New System.Windows.Forms.Button()
        Me.txtHourWage = New System.Windows.Forms.TextBox()
        CType(Me.DataGridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPTABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB06.SuspendLayout()
        CType(Me.DGBerekening, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB05.SuspendLayout()
        CType(Me.DGVergoedingenB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVergoedingen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB04.SuspendLayout()
        Me.TAB03.SuspendLayout()
        Me.TAB02.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB01.SuspendLayout()
        CType(Me.txtEmployeeStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpPictBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TAB07.SuspendLayout()
        CType(Me.DGEmpDeductions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.LightGray
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(538, 632)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(77, 24)
        Me.btnEdit.TabIndex = 53
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'EMPCOMPIDDataGridViewTextBoxColumn
        '
        Me.EMPCOMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMP_COMPID"
        Me.EMPCOMPIDDataGridViewTextBoxColumn.HeaderText = "EMP_COMPID"
        Me.EMPCOMPIDDataGridViewTextBoxColumn.Name = "EMPCOMPIDDataGridViewTextBoxColumn"
        Me.EMPCOMPIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPFIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.EMPFIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMP_FIRSTNAME"
        Me.EMPFIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "EMP_FIRSTNAME"
        Me.EMPFIRSTNAMEDataGridViewTextBoxColumn.Name = "EMPFIRSTNAMEDataGridViewTextBoxColumn"
        Me.EMPFIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPLASTNAMEDataGridViewTextBoxColumn
        '
        Me.EMPLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMP_LASTNAME"
        Me.EMPLASTNAMEDataGridViewTextBoxColumn.HeaderText = "EMP_LASTNAME"
        Me.EMPLASTNAMEDataGridViewTextBoxColumn.Name = "EMPLASTNAMEDataGridViewTextBoxColumn"
        Me.EMPLASTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPBIRTHDATEDataGridViewTextBoxColumn
        '
        Me.EMPBIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "EMP_BIRTHDATE"
        Me.EMPBIRTHDATEDataGridViewTextBoxColumn.HeaderText = "EMP_BIRTHDATE"
        Me.EMPBIRTHDATEDataGridViewTextBoxColumn.Name = "EMPBIRTHDATEDataGridViewTextBoxColumn"
        Me.EMPBIRTHDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPDEPARTMENTDataGridViewTextBoxColumn
        '
        Me.EMPDEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "EMP_DEPARTMENT"
        Me.EMPDEPARTMENTDataGridViewTextBoxColumn.HeaderText = "EMP_DEPARTMENT"
        Me.EMPDEPARTMENTDataGridViewTextBoxColumn.Name = "EMPDEPARTMENTDataGridViewTextBoxColumn"
        Me.EMPDEPARTMENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPSTARTDATEDataGridViewTextBoxColumn
        '
        Me.EMPSTARTDATEDataGridViewTextBoxColumn.DataPropertyName = "EMP_STARTDATE"
        Me.EMPSTARTDATEDataGridViewTextBoxColumn.HeaderText = "EMP_STARTDATE"
        Me.EMPSTARTDATEDataGridViewTextBoxColumn.Name = "EMPSTARTDATEDataGridViewTextBoxColumn"
        Me.EMPSTARTDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPENDDATEDataGridViewTextBoxColumn
        '
        Me.EMPENDDATEDataGridViewTextBoxColumn.DataPropertyName = "EMP_ENDDATE"
        Me.EMPENDDATEDataGridViewTextBoxColumn.HeaderText = "EMP_ENDDATE"
        Me.EMPENDDATEDataGridViewTextBoxColumn.Name = "EMPENDDATEDataGridViewTextBoxColumn"
        Me.EMPENDDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPSALARYDataGridViewTextBoxColumn
        '
        Me.EMPSALARYDataGridViewTextBoxColumn.DataPropertyName = "EMP_SALARY"
        Me.EMPSALARYDataGridViewTextBoxColumn.HeaderText = "EMP_SALARY"
        Me.EMPSALARYDataGridViewTextBoxColumn.Name = "EMPSALARYDataGridViewTextBoxColumn"
        Me.EMPSALARYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPSTATUSDataGridViewTextBoxColumn
        '
        Me.EMPSTATUSDataGridViewTextBoxColumn.DataPropertyName = "EMP_STATUS"
        Me.EMPSTATUSDataGridViewTextBoxColumn.HeaderText = "EMP_STATUS"
        Me.EMPSTATUSDataGridViewTextBoxColumn.Name = "EMPSTATUSDataGridViewTextBoxColumn"
        Me.EMPSTATUSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPPOSITIONDataGridViewTextBoxColumn
        '
        Me.EMPPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "EMP_POSITION"
        Me.EMPPOSITIONDataGridViewTextBoxColumn.HeaderText = "EMP_POSITION"
        Me.EMPPOSITIONDataGridViewTextBoxColumn.Name = "EMPPOSITIONDataGridViewTextBoxColumn"
        Me.EMPPOSITIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPSEXDataGridViewTextBoxColumn
        '
        Me.EMPSEXDataGridViewTextBoxColumn.DataPropertyName = "EMP_SEX"
        Me.EMPSEXDataGridViewTextBoxColumn.HeaderText = "EMP_SEX"
        Me.EMPSEXDataGridViewTextBoxColumn.Name = "EMPSEXDataGridViewTextBoxColumn"
        Me.EMPSEXDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPCEDULANRDataGridViewTextBoxColumn
        '
        Me.EMPCEDULANRDataGridViewTextBoxColumn.DataPropertyName = "EMP_CEDULANR"
        Me.EMPCEDULANRDataGridViewTextBoxColumn.HeaderText = "EMP_CEDULANR"
        Me.EMPCEDULANRDataGridViewTextBoxColumn.Name = "EMPCEDULANRDataGridViewTextBoxColumn"
        Me.EMPCEDULANRDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPDPWDataGridViewTextBoxColumn
        '
        Me.EMPDPWDataGridViewTextBoxColumn.DataPropertyName = "EMP_DPW"
        Me.EMPDPWDataGridViewTextBoxColumn.HeaderText = "EMP_DPW"
        Me.EMPDPWDataGridViewTextBoxColumn.Name = "EMPDPWDataGridViewTextBoxColumn"
        Me.EMPDPWDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPUPWDataGridViewTextBoxColumn
        '
        Me.EMPUPWDataGridViewTextBoxColumn.DataPropertyName = "EMP_UPW"
        Me.EMPUPWDataGridViewTextBoxColumn.HeaderText = "EMP_UPW"
        Me.EMPUPWDataGridViewTextBoxColumn.Name = "EMPUPWDataGridViewTextBoxColumn"
        Me.EMPUPWDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPUURLOONDataGridViewTextBoxColumn
        '
        Me.EMPUURLOONDataGridViewTextBoxColumn.DataPropertyName = "EMP_UURLOON"
        Me.EMPUURLOONDataGridViewTextBoxColumn.HeaderText = "EMP_UURLOON"
        Me.EMPUURLOONDataGridViewTextBoxColumn.Name = "EMPUURLOONDataGridViewTextBoxColumn"
        Me.EMPUURLOONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridMain
        '
        Me.DataGridMain.AllowUserToAddRows = False
        Me.DataGridMain.AllowUserToDeleteRows = False
        Me.DataGridMain.AllowUserToResizeColumns = False
        Me.DataGridMain.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.BurlyWood
        Me.DataGridMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridMain.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.DataGridMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridMain.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridMain.EnableHeadersVisualStyles = False
        Me.DataGridMain.Location = New System.Drawing.Point(0, 333)
        Me.DataGridMain.MultiSelect = False
        Me.DataGridMain.Name = "DataGridMain"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridMain.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridMain.RowHeadersVisible = False
        Me.DataGridMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Tan
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridMain.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DataGridMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.OrangeRed
        Me.DataGridMain.RowTemplate.Height = 18
        Me.DataGridMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMain.ShowCellErrors = False
        Me.DataGridMain.ShowCellToolTips = False
        Me.DataGridMain.Size = New System.Drawing.Size(965, 274)
        Me.DataGridMain.TabIndex = 1
        Me.DataGridMain.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Silver
        Me.btnClear.Enabled = False
        Me.btnClear.Location = New System.Drawing.Point(298, 631)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 24)
        Me.btnClear.TabIndex = 34
        Me.btnClear.Text = "Schonen"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Silver
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(413, 631)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "Bewaren"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Silver
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(128, 632)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 24)
        Me.btnDelete.TabIndex = 37
        Me.btnDelete.Text = "Verwijderen"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape10, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(968, 702)
        Me.ShapeContainer1.TabIndex = 40
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.Color.OrangeRed
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 5
        Me.LineShape10.X2 = 836
        Me.LineShape10.Y1 = 623
        Me.LineShape10.Y2 = 623
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.OrangeRed
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 5
        Me.LineShape2.X2 = 836
        Me.LineShape2.Y1 = 664
        Me.LineShape2.Y2 = 664
        '
        'btnRetrieve
        '
        Me.btnRetrieve.BackColor = System.Drawing.Color.Silver
        Me.btnRetrieve.Enabled = False
        Me.btnRetrieve.Location = New System.Drawing.Point(18, 632)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(77, 24)
        Me.btnRetrieve.TabIndex = 30
        Me.btnRetrieve.Text = "Ophalen"
        Me.btnRetrieve.UseVisualStyleBackColor = False
        '
        'ToolStripUserName
        '
        Me.ToolStripUserName.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripUserName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripUserName.Name = "ToolStripUserName"
        Me.ToolStripUserName.Size = New System.Drawing.Size(38, 19)
        Me.ToolStripUserName.Text = "USER"
        Me.ToolStripUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatus
        '
        Me.ToolStripStatus.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatus.Name = "ToolStripStatus"
        Me.ToolStripStatus.Size = New System.Drawing.Size(51, 19)
        Me.ToolStripStatus.Text = "INT:NO"
        Me.ToolStripStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.BackColor = System.Drawing.Color.White
        Me.ToolStripProgressBar1.ForeColor = System.Drawing.Color.Crimson
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 18)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(41, 19)
        Me.ToolStripStatusLabel1.Text = "Bedrijf"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowItemReorder = True
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightGray
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripUserName, Me.ToolStripStatus, Me.ToolStripStatusLabel1, Me.cmbCompanySelection, Me.ToolStripStatusLabel2, Me.StatusLabel_COUNTRY, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 678)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(968, 24)
        Me.StatusStrip1.Stretch = False
        Me.StatusStrip1.TabIndex = 55
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'cmbCompanySelection
        '
        Me.cmbCompanySelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.cmbCompanySelection.Image = CType(resources.GetObject("cmbCompanySelection.Image"), System.Drawing.Image)
        Me.cmbCompanySelection.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbCompanySelection.Name = "cmbCompanySelection"
        Me.cmbCompanySelection.Size = New System.Drawing.Size(13, 22)
        Me.cmbCompanySelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(50, 19)
        Me.ToolStripStatusLabel2.Text = "EILAND:"
        '
        'StatusLabel_COUNTRY
        '
        Me.StatusLabel_COUNTRY.Name = "StatusLabel_COUNTRY"
        Me.StatusLabel_COUNTRY.Size = New System.Drawing.Size(59, 19)
        Me.StatusLabel_COUNTRY.Text = "NO DATA"
        Me.StatusLabel_COUNTRY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(664, 632)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 24)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Belasting Variabelen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pctLogo
        '
        Me.pctLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctLogo.Enabled = False
        Me.pctLogo.Image = CType(resources.GetObject("pctLogo.Image"), System.Drawing.Image)
        Me.pctLogo.Location = New System.Drawing.Point(0, 3)
        Me.pctLogo.Name = "pctLogo"
        Me.pctLogo.Size = New System.Drawing.Size(965, 57)
        Me.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLogo.TabIndex = 31
        Me.pctLogo.TabStop = False
        '
        'EMPTABLEBindingSource
        '
        Me.EMPTABLEBindingSource.DataMember = "EMPTABLE"
        '
        'TAB06
        '
        Me.TAB06.Controls.Add(Me.DGBerekening)
        Me.TAB06.Location = New System.Drawing.Point(4, 25)
        Me.TAB06.Name = "TAB06"
        Me.TAB06.Size = New System.Drawing.Size(957, 235)
        Me.TAB06.TabIndex = 5
        Me.TAB06.UseVisualStyleBackColor = True
        '
        'DGBerekening
        '
        Me.DGBerekening.AllowUserToAddRows = False
        Me.DGBerekening.AllowUserToDeleteRows = False
        Me.DGBerekening.AllowUserToResizeColumns = False
        Me.DGBerekening.AllowUserToResizeRows = False
        Me.DGBerekening.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGBerekening.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGBerekening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGBerekening.ColumnHeadersVisible = False
        Me.DGBerekening.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGBerekening.Enabled = False
        Me.DGBerekening.Location = New System.Drawing.Point(0, 0)
        Me.DGBerekening.Name = "DGBerekening"
        Me.DGBerekening.RowHeadersVisible = False
        Me.DGBerekening.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGBerekening.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGBerekening.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGBerekening.Size = New System.Drawing.Size(957, 218)
        Me.DGBerekening.TabIndex = 6
        '
        'TAB05
        '
        Me.TAB05.BackColor = System.Drawing.Color.Maroon
        Me.TAB05.Controls.Add(Me.DGVergoedingenB)
        Me.TAB05.Controls.Add(Me.DGVergoedingen)
        Me.TAB05.Location = New System.Drawing.Point(4, 25)
        Me.TAB05.Name = "TAB05"
        Me.TAB05.Size = New System.Drawing.Size(957, 235)
        Me.TAB05.TabIndex = 4
        '
        'DGVergoedingenB
        '
        Me.DGVergoedingenB.AllowUserToAddRows = False
        Me.DGVergoedingenB.AllowUserToDeleteRows = False
        Me.DGVergoedingenB.AllowUserToResizeColumns = False
        Me.DGVergoedingenB.AllowUserToResizeRows = False
        Me.DGVergoedingenB.BackgroundColor = System.Drawing.Color.White
        Me.DGVergoedingenB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVergoedingenB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVergoedingenB.Enabled = False
        Me.DGVergoedingenB.Location = New System.Drawing.Point(468, 3)
        Me.DGVergoedingenB.Name = "DGVergoedingenB"
        Me.DGVergoedingenB.RowHeadersVisible = False
        Me.DGVergoedingenB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGVergoedingenB.Size = New System.Drawing.Size(486, 229)
        Me.DGVergoedingenB.TabIndex = 1
        '
        'DGVergoedingen
        '
        Me.DGVergoedingen.AllowUserToAddRows = False
        Me.DGVergoedingen.AllowUserToDeleteRows = False
        Me.DGVergoedingen.AllowUserToResizeColumns = False
        Me.DGVergoedingen.AllowUserToResizeRows = False
        Me.DGVergoedingen.BackgroundColor = System.Drawing.Color.White
        Me.DGVergoedingen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVergoedingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVergoedingen.Enabled = False
        Me.DGVergoedingen.Location = New System.Drawing.Point(3, 3)
        Me.DGVergoedingen.MultiSelect = False
        Me.DGVergoedingen.Name = "DGVergoedingen"
        Me.DGVergoedingen.ReadOnly = True
        Me.DGVergoedingen.RowHeadersVisible = False
        Me.DGVergoedingen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGVergoedingen.Size = New System.Drawing.Size(459, 229)
        Me.DGVergoedingen.TabIndex = 0
        '
        'TAB04
        '
        Me.TAB04.BackColor = System.Drawing.Color.Maroon
        Me.TAB04.Controls.Add(Me.txtEmpNotities)
        Me.TAB04.Location = New System.Drawing.Point(4, 25)
        Me.TAB04.Name = "TAB04"
        Me.TAB04.Size = New System.Drawing.Size(957, 235)
        Me.TAB04.TabIndex = 3
        '
        'txtEmpNotities
        '
        Me.txtEmpNotities.BackColor = System.Drawing.Color.White
        Me.txtEmpNotities.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmpNotities.CausesValidation = False
        Me.txtEmpNotities.DetectUrls = False
        Me.txtEmpNotities.Enabled = False
        Me.txtEmpNotities.Location = New System.Drawing.Point(3, 3)
        Me.txtEmpNotities.MaxLength = 1500
        Me.txtEmpNotities.Name = "txtEmpNotities"
        Me.txtEmpNotities.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtEmpNotities.ShowSelectionMargin = True
        Me.txtEmpNotities.Size = New System.Drawing.Size(951, 229)
        Me.txtEmpNotities.TabIndex = 0
        Me.txtEmpNotities.Text = ""
        '
        'TAB03
        '
        Me.TAB03.BackColor = System.Drawing.Color.Maroon
        Me.TAB03.Controls.Add(Me.txtVerwervingskosten)
        Me.TAB03.Controls.Add(Me.lblVerwervingsKosten)
        Me.TAB03.Controls.Add(Me.txtZOG_PERC)
        Me.TAB03.Controls.Add(Me.txtZOGPREMIE)
        Me.TAB03.Controls.Add(Me.txtBVZ_Amount)
        Me.TAB03.Controls.Add(Me.txtOnkostenVergoeding)
        Me.TAB03.Controls.Add(Me.txtTotalIncome)
        Me.TAB03.Controls.Add(Me.txtValuta)
        Me.TAB03.Controls.Add(Me.txtZV_Amount)
        Me.TAB03.Controls.Add(Me.txtAOV_AWW)
        Me.TAB03.Controls.Add(Me.txtAVBZ_AMOUNT)
        Me.TAB03.Controls.Add(Me.txtPeriode)
        Me.TAB03.Controls.Add(Me.txtUurloon)
        Me.TAB03.Controls.Add(Me.txtAnderloon)
        Me.TAB03.Controls.Add(Me.txtPensioenfonds)
        Me.TAB03.Controls.Add(Me.txtAutoZaak)
        Me.TAB03.Controls.Add(Me.txtKindToeslag)
        Me.TAB03.Controls.Add(Me.txtAlleenVerdienerT)
        Me.TAB03.Controls.Add(Me.txtOuderenToeslag)
        Me.TAB03.Controls.Add(Me.txtBesInsp)
        Me.TAB03.Controls.Add(Me.TXTSALARY)
        Me.TAB03.Controls.Add(Me.txtZV_PERC)
        Me.TAB03.Controls.Add(Me.lblTotalIncome)
        Me.TAB03.Controls.Add(Me.Label5)
        Me.TAB03.Controls.Add(Me.chkZV)
        Me.TAB03.Controls.Add(Me.lblPeriod)
        Me.TAB03.Controls.Add(Me.cmbPeriod)
        Me.TAB03.Controls.Add(Me.lblUurloon)
        Me.TAB03.Controls.Add(Me.txtDagenPerWeek)
        Me.TAB03.Controls.Add(Me.lblDagenPerweek)
        Me.TAB03.Controls.Add(Me.txtUrenPerDag)
        Me.TAB03.Controls.Add(Me.lblUrenPerweek)
        Me.TAB03.Controls.Add(Me.txtLeeftijd1jan)
        Me.TAB03.Controls.Add(Me.lblAgeOnfirstjan)
        Me.TAB03.Controls.Add(Me.lblBelPlicht)
        Me.TAB03.Controls.Add(Me.Label11)
        Me.TAB03.Controls.Add(Me.lblPensioen)
        Me.TAB03.Controls.Add(Me.Label2)
        Me.TAB03.Controls.Add(Me.cmbvaluta)
        Me.TAB03.Controls.Add(Me.Label9)
        Me.TAB03.Controls.Add(Me.Label8)
        Me.TAB03.Controls.Add(Me.txtBVZ_PERC)
        Me.TAB03.Controls.Add(Me.Label7)
        Me.TAB03.Controls.Add(Me.Label6)
        Me.TAB03.Controls.Add(Me.Label4)
        Me.TAB03.Controls.Add(Me.lblOudtoeslag)
        Me.TAB03.Controls.Add(Me.lblBeslInsp)
        Me.TAB03.Controls.Add(Me.txtAVBZ_PERC)
        Me.TAB03.Controls.Add(Me.txtAOVAWW_PERC)
        Me.TAB03.Controls.Add(Me.lblZV)
        Me.TAB03.Controls.Add(Me.lblAVBZ)
        Me.TAB03.Controls.Add(Me.lblAOVAWW)
        Me.TAB03.Controls.Add(Me.ShapeContainer2)
        Me.TAB03.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TAB03.Location = New System.Drawing.Point(4, 25)
        Me.TAB03.Name = "TAB03"
        Me.TAB03.Size = New System.Drawing.Size(957, 235)
        Me.TAB03.TabIndex = 2
        '
        'txtVerwervingskosten
        '
        Me.txtVerwervingskosten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVerwervingskosten.Enabled = False
        Me.txtVerwervingskosten.Location = New System.Drawing.Point(126, 203)
        Me.txtVerwervingskosten.Name = "txtVerwervingskosten"
        Me.txtVerwervingskosten.Size = New System.Drawing.Size(84, 20)
        Me.txtVerwervingskosten.TabIndex = 84
        Me.txtVerwervingskosten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVerwervingskosten.WordWrap = False
        '
        'lblVerwervingsKosten
        '
        Me.lblVerwervingsKosten.BackColor = System.Drawing.Color.Chocolate
        Me.lblVerwervingsKosten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVerwervingsKosten.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerwervingsKosten.ForeColor = System.Drawing.Color.White
        Me.lblVerwervingsKosten.Location = New System.Drawing.Point(7, 203)
        Me.lblVerwervingsKosten.Name = "lblVerwervingsKosten"
        Me.lblVerwervingsKosten.Size = New System.Drawing.Size(112, 20)
        Me.lblVerwervingsKosten.TabIndex = 83
        Me.lblVerwervingsKosten.Text = "Verwervings Kosten"
        '
        'txtZOG_PERC
        '
        Me.txtZOG_PERC.AllowPromptAsInput = False
        Me.txtZOG_PERC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZOG_PERC.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txtZOG_PERC.Enabled = False
        Me.txtZOG_PERC.Location = New System.Drawing.Point(126, 174)
        Me.txtZOG_PERC.Mask = "#.#"
        Me.txtZOG_PERC.Name = "txtZOG_PERC"
        Me.txtZOG_PERC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtZOG_PERC.Size = New System.Drawing.Size(35, 20)
        Me.txtZOG_PERC.TabIndex = 82
        Me.txtZOG_PERC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtZOGPREMIE
        '
        Me.txtZOGPREMIE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZOGPREMIE.CausesValidation = False
        Me.txtZOGPREMIE.Enabled = False
        Me.txtZOGPREMIE.Location = New System.Drawing.Point(167, 173)
        Me.txtZOGPREMIE.Name = "txtZOGPREMIE"
        Me.txtZOGPREMIE.Size = New System.Drawing.Size(89, 20)
        Me.txtZOGPREMIE.TabIndex = 10
        Me.txtZOGPREMIE.TabStop = False
        Me.txtZOGPREMIE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBVZ_Amount
        '
        Me.txtBVZ_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBVZ_Amount.CausesValidation = False
        Me.txtBVZ_Amount.Enabled = False
        Me.txtBVZ_Amount.Location = New System.Drawing.Point(167, 143)
        Me.txtBVZ_Amount.Name = "txtBVZ_Amount"
        Me.txtBVZ_Amount.Size = New System.Drawing.Size(89, 20)
        Me.txtBVZ_Amount.TabIndex = 81
        Me.txtBVZ_Amount.TabStop = False
        Me.txtBVZ_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOnkostenVergoeding
        '
        Me.txtOnkostenVergoeding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOnkostenVergoeding.Enabled = False
        Me.txtOnkostenVergoeding.Location = New System.Drawing.Point(705, 142)
        Me.txtOnkostenVergoeding.Name = "txtOnkostenVergoeding"
        Me.txtOnkostenVergoeding.Size = New System.Drawing.Size(84, 20)
        Me.txtOnkostenVergoeding.TabIndex = 17
        Me.txtOnkostenVergoeding.Text = "0.00"
        Me.txtOnkostenVergoeding.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalIncome
        '
        Me.txtTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalIncome.Enabled = False
        Me.txtTotalIncome.Location = New System.Drawing.Point(706, 173)
        Me.txtTotalIncome.Name = "txtTotalIncome"
        Me.txtTotalIncome.Size = New System.Drawing.Size(84, 20)
        Me.txtTotalIncome.TabIndex = 78
        Me.txtTotalIncome.TabStop = False
        Me.txtTotalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalIncome.WordWrap = False
        '
        'txtValuta
        '
        Me.txtValuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValuta.Enabled = False
        Me.txtValuta.Location = New System.Drawing.Point(124, 35)
        Me.txtValuta.Name = "txtValuta"
        Me.txtValuta.Size = New System.Drawing.Size(84, 20)
        Me.txtValuta.TabIndex = 76
        Me.txtValuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtZV_Amount
        '
        Me.txtZV_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZV_Amount.CausesValidation = False
        Me.txtZV_Amount.Enabled = False
        Me.txtZV_Amount.Location = New System.Drawing.Point(166, 116)
        Me.txtZV_Amount.Name = "txtZV_Amount"
        Me.txtZV_Amount.Size = New System.Drawing.Size(89, 20)
        Me.txtZV_Amount.TabIndex = 72
        Me.txtZV_Amount.TabStop = False
        Me.txtZV_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAOV_AWW
        '
        Me.txtAOV_AWW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAOV_AWW.CausesValidation = False
        Me.txtAOV_AWW.Enabled = False
        Me.txtAOV_AWW.Location = New System.Drawing.Point(166, 66)
        Me.txtAOV_AWW.Name = "txtAOV_AWW"
        Me.txtAOV_AWW.Size = New System.Drawing.Size(89, 20)
        Me.txtAOV_AWW.TabIndex = 71
        Me.txtAOV_AWW.TabStop = False
        Me.txtAOV_AWW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAVBZ_AMOUNT
        '
        Me.txtAVBZ_AMOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAVBZ_AMOUNT.CausesValidation = False
        Me.txtAVBZ_AMOUNT.Enabled = False
        Me.txtAVBZ_AMOUNT.Location = New System.Drawing.Point(166, 90)
        Me.txtAVBZ_AMOUNT.Name = "txtAVBZ_AMOUNT"
        Me.txtAVBZ_AMOUNT.Size = New System.Drawing.Size(89, 20)
        Me.txtAVBZ_AMOUNT.TabIndex = 70
        Me.txtAVBZ_AMOUNT.TabStop = False
        Me.txtAVBZ_AMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPeriode
        '
        Me.txtPeriode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPeriode.Enabled = False
        Me.txtPeriode.Location = New System.Drawing.Point(502, 8)
        Me.txtPeriode.Name = "txtPeriode"
        Me.txtPeriode.Size = New System.Drawing.Size(63, 20)
        Me.txtPeriode.TabIndex = 68
        Me.txtPeriode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUurloon
        '
        Me.txtUurloon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUurloon.Enabled = False
        Me.txtUurloon.Location = New System.Drawing.Point(412, 35)
        Me.txtUurloon.Name = "txtUurloon"
        Me.txtUurloon.Size = New System.Drawing.Size(84, 20)
        Me.txtUurloon.TabIndex = 65
        Me.txtUurloon.Text = "0.00"
        Me.txtUurloon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAnderloon
        '
        Me.txtAnderloon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnderloon.Enabled = False
        Me.txtAnderloon.Location = New System.Drawing.Point(705, 116)
        Me.txtAnderloon.Name = "txtAnderloon"
        Me.txtAnderloon.Size = New System.Drawing.Size(84, 20)
        Me.txtAnderloon.TabIndex = 16
        Me.txtAnderloon.Text = "0.00"
        Me.txtAnderloon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPensioenfonds
        '
        Me.txtPensioenfonds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPensioenfonds.Enabled = False
        Me.txtPensioenfonds.Location = New System.Drawing.Point(705, 91)
        Me.txtPensioenfonds.Name = "txtPensioenfonds"
        Me.txtPensioenfonds.Size = New System.Drawing.Size(84, 20)
        Me.txtPensioenfonds.TabIndex = 54
        Me.txtPensioenfonds.TabStop = False
        Me.txtPensioenfonds.Text = "0.00"
        Me.txtPensioenfonds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAutoZaak
        '
        Me.txtAutoZaak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAutoZaak.Enabled = False
        Me.txtAutoZaak.Location = New System.Drawing.Point(705, 65)
        Me.txtAutoZaak.Name = "txtAutoZaak"
        Me.txtAutoZaak.Size = New System.Drawing.Size(84, 20)
        Me.txtAutoZaak.TabIndex = 15
        Me.txtAutoZaak.Text = "0.00"
        Me.txtAutoZaak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKindToeslag
        '
        Me.txtKindToeslag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKindToeslag.Enabled = False
        Me.txtKindToeslag.Location = New System.Drawing.Point(412, 142)
        Me.txtKindToeslag.Name = "txtKindToeslag"
        Me.txtKindToeslag.Size = New System.Drawing.Size(84, 20)
        Me.txtKindToeslag.TabIndex = 14
        Me.txtKindToeslag.Text = "0.00"
        Me.txtKindToeslag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAlleenVerdienerT
        '
        Me.txtAlleenVerdienerT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlleenVerdienerT.Enabled = False
        Me.txtAlleenVerdienerT.Location = New System.Drawing.Point(412, 117)
        Me.txtAlleenVerdienerT.Name = "txtAlleenVerdienerT"
        Me.txtAlleenVerdienerT.Size = New System.Drawing.Size(84, 20)
        Me.txtAlleenVerdienerT.TabIndex = 13
        Me.txtAlleenVerdienerT.Text = "0.00"
        Me.txtAlleenVerdienerT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOuderenToeslag
        '
        Me.txtOuderenToeslag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOuderenToeslag.Enabled = False
        Me.txtOuderenToeslag.Location = New System.Drawing.Point(413, 90)
        Me.txtOuderenToeslag.Name = "txtOuderenToeslag"
        Me.txtOuderenToeslag.Size = New System.Drawing.Size(83, 20)
        Me.txtOuderenToeslag.TabIndex = 12
        Me.txtOuderenToeslag.Text = "0.00"
        Me.txtOuderenToeslag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBesInsp
        '
        Me.txtBesInsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBesInsp.Enabled = False
        Me.txtBesInsp.Location = New System.Drawing.Point(413, 64)
        Me.txtBesInsp.Name = "txtBesInsp"
        Me.txtBesInsp.Size = New System.Drawing.Size(83, 20)
        Me.txtBesInsp.TabIndex = 11
        Me.txtBesInsp.Text = "0.00"
        Me.txtBesInsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTSALARY
        '
        Me.TXTSALARY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTSALARY.Enabled = False
        Me.TXTSALARY.Location = New System.Drawing.Point(124, 8)
        Me.TXTSALARY.Name = "TXTSALARY"
        Me.TXTSALARY.Size = New System.Drawing.Size(84, 20)
        Me.TXTSALARY.TabIndex = 1
        Me.TXTSALARY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TXTSALARY.WordWrap = False
        '
        'txtZV_PERC
        '
        Me.txtZV_PERC.AllowPromptAsInput = False
        Me.txtZV_PERC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZV_PERC.Enabled = False
        Me.txtZV_PERC.Location = New System.Drawing.Point(125, 116)
        Me.txtZV_PERC.Mask = "0.0"
        Me.txtZV_PERC.Name = "txtZV_PERC"
        Me.txtZV_PERC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtZV_PERC.Size = New System.Drawing.Size(35, 20)
        Me.txtZV_PERC.TabIndex = 8
        Me.txtZV_PERC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalIncome
        '
        Me.lblTotalIncome.BackColor = System.Drawing.Color.Chocolate
        Me.lblTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalIncome.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalIncome.ForeColor = System.Drawing.Color.White
        Me.lblTotalIncome.Location = New System.Drawing.Point(583, 173)
        Me.lblTotalIncome.Name = "lblTotalIncome"
        Me.lblTotalIncome.Size = New System.Drawing.Size(112, 20)
        Me.lblTotalIncome.TabIndex = 77
        Me.lblTotalIncome.Text = "Totaal Inkomen"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Chocolate
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(583, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Bel.Onkosten "
        '
        'chkZV
        '
        Me.chkZV.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkZV.AutoSize = True
        Me.chkZV.BackColor = System.Drawing.Color.LawnGreen
        Me.chkZV.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkZV.Location = New System.Drawing.Point(97, 123)
        Me.chkZV.Name = "chkZV"
        Me.chkZV.Size = New System.Drawing.Size(6, 6)
        Me.chkZV.TabIndex = 69
        Me.chkZV.TabStop = False
        Me.chkZV.UseVisualStyleBackColor = False
        Me.chkZV.Visible = False
        '
        'lblPeriod
        '
        Me.lblPeriod.BackColor = System.Drawing.Color.Chocolate
        Me.lblPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPeriod.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriod.ForeColor = System.Drawing.Color.White
        Me.lblPeriod.Location = New System.Drawing.Point(295, 9)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(112, 20)
        Me.lblPeriod.TabIndex = 67
        Me.lblPeriod.Text = "Periode"
        '
        'cmbPeriod
        '
        Me.cmbPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPeriod.FormattingEnabled = True
        Me.cmbPeriod.Location = New System.Drawing.Point(413, 8)
        Me.cmbPeriod.Name = "cmbPeriod"
        Me.cmbPeriod.Size = New System.Drawing.Size(83, 21)
        Me.cmbPeriod.TabIndex = 3
        '
        'lblUurloon
        '
        Me.lblUurloon.BackColor = System.Drawing.Color.Chocolate
        Me.lblUurloon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUurloon.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUurloon.ForeColor = System.Drawing.Color.White
        Me.lblUurloon.Location = New System.Drawing.Point(294, 35)
        Me.lblUurloon.Name = "lblUurloon"
        Me.lblUurloon.Size = New System.Drawing.Size(112, 20)
        Me.lblUurloon.TabIndex = 64
        Me.lblUurloon.Text = "UurLoon"
        '
        'txtDagenPerWeek
        '
        Me.txtDagenPerWeek.AllowPromptAsInput = False
        Me.txtDagenPerWeek.BeepOnError = True
        Me.txtDagenPerWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDagenPerWeek.Enabled = False
        Me.txtDagenPerWeek.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txtDagenPerWeek.Location = New System.Drawing.Point(705, 34)
        Me.txtDagenPerWeek.Mask = "99"
        Me.txtDagenPerWeek.Name = "txtDagenPerWeek"
        Me.txtDagenPerWeek.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtDagenPerWeek.Size = New System.Drawing.Size(84, 20)
        Me.txtDagenPerWeek.TabIndex = 5
        Me.txtDagenPerWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDagenPerWeek.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblDagenPerweek
        '
        Me.lblDagenPerweek.BackColor = System.Drawing.Color.Chocolate
        Me.lblDagenPerweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDagenPerweek.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDagenPerweek.ForeColor = System.Drawing.Color.White
        Me.lblDagenPerweek.Location = New System.Drawing.Point(583, 35)
        Me.lblDagenPerweek.Name = "lblDagenPerweek"
        Me.lblDagenPerweek.Size = New System.Drawing.Size(112, 20)
        Me.lblDagenPerweek.TabIndex = 62
        Me.lblDagenPerweek.Text = "Dagen Per Week"
        '
        'txtUrenPerDag
        '
        Me.txtUrenPerDag.AllowPromptAsInput = False
        Me.txtUrenPerDag.BeepOnError = True
        Me.txtUrenPerDag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUrenPerDag.Enabled = False
        Me.txtUrenPerDag.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txtUrenPerDag.Location = New System.Drawing.Point(705, 8)
        Me.txtUrenPerDag.Mask = "99"
        Me.txtUrenPerDag.Name = "txtUrenPerDag"
        Me.txtUrenPerDag.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtUrenPerDag.Size = New System.Drawing.Size(84, 20)
        Me.txtUrenPerDag.TabIndex = 4
        Me.txtUrenPerDag.Text = "0"
        Me.txtUrenPerDag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUrenPerDag.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblUrenPerweek
        '
        Me.lblUrenPerweek.BackColor = System.Drawing.Color.Chocolate
        Me.lblUrenPerweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUrenPerweek.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUrenPerweek.ForeColor = System.Drawing.Color.White
        Me.lblUrenPerweek.Location = New System.Drawing.Point(583, 8)
        Me.lblUrenPerweek.Name = "lblUrenPerweek"
        Me.lblUrenPerweek.Size = New System.Drawing.Size(112, 20)
        Me.lblUrenPerweek.TabIndex = 60
        Me.lblUrenPerweek.Text = "Uren Per Dag"
        '
        'txtLeeftijd1jan
        '
        Me.txtLeeftijd1jan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeeftijd1jan.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txtLeeftijd1jan.Enabled = False
        Me.txtLeeftijd1jan.Location = New System.Drawing.Point(413, 174)
        Me.txtLeeftijd1jan.Mask = "99"
        Me.txtLeeftijd1jan.Name = "txtLeeftijd1jan"
        Me.txtLeeftijd1jan.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtLeeftijd1jan.Size = New System.Drawing.Size(83, 20)
        Me.txtLeeftijd1jan.TabIndex = 59
        Me.txtLeeftijd1jan.TabStop = False
        Me.txtLeeftijd1jan.Text = "00"
        Me.txtLeeftijd1jan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLeeftijd1jan.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblAgeOnfirstjan
        '
        Me.lblAgeOnfirstjan.BackColor = System.Drawing.Color.Chocolate
        Me.lblAgeOnfirstjan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAgeOnfirstjan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeOnfirstjan.ForeColor = System.Drawing.Color.White
        Me.lblAgeOnfirstjan.Location = New System.Drawing.Point(294, 173)
        Me.lblAgeOnfirstjan.Name = "lblAgeOnfirstjan"
        Me.lblAgeOnfirstjan.Size = New System.Drawing.Size(112, 20)
        Me.lblAgeOnfirstjan.TabIndex = 58
        Me.lblAgeOnfirstjan.Text = "Leeftijd 1 januari"
        '
        'lblBelPlicht
        '
        Me.lblBelPlicht.BackColor = System.Drawing.Color.Chocolate
        Me.lblBelPlicht.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBelPlicht.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBelPlicht.ForeColor = System.Drawing.Color.White
        Me.lblBelPlicht.Location = New System.Drawing.Point(8, 173)
        Me.lblBelPlicht.Name = "lblBelPlicht"
        Me.lblBelPlicht.Size = New System.Drawing.Size(112, 20)
        Me.lblBelPlicht.TabIndex = 56
        Me.lblBelPlicht.Text = "ZOG Premie"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Chocolate
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(583, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 20)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Andere Loon"
        '
        'lblPensioen
        '
        Me.lblPensioen.BackColor = System.Drawing.Color.Chocolate
        Me.lblPensioen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPensioen.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPensioen.ForeColor = System.Drawing.Color.White
        Me.lblPensioen.Location = New System.Drawing.Point(583, 91)
        Me.lblPensioen.Name = "lblPensioen"
        Me.lblPensioen.Size = New System.Drawing.Size(112, 20)
        Me.lblPensioen.TabIndex = 37
        Me.lblPensioen.Text = "Pensioen Fonds"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Chocolate
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(583, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Auto v.d Zaak"
        '
        'cmbvaluta
        '
        Me.cmbvaluta.Enabled = False
        Me.cmbvaluta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbvaluta.FormattingEnabled = True
        Me.cmbvaluta.Items.AddRange(New Object() {"NAF", "AFL", "EUR", "USD"})
        Me.cmbvaluta.Location = New System.Drawing.Point(125, 35)
        Me.cmbvaluta.MaxDropDownItems = 3
        Me.cmbvaluta.Name = "cmbvaluta"
        Me.cmbvaluta.Size = New System.Drawing.Size(83, 21)
        Me.cmbvaluta.TabIndex = 2
        Me.cmbvaluta.Text = "NAF"
        Me.cmbvaluta.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Chocolate
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 20)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Valuta"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Chocolate
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(294, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Kinderen TSLG"
        '
        'txtBVZ_PERC
        '
        Me.txtBVZ_PERC.AllowPromptAsInput = False
        Me.txtBVZ_PERC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBVZ_PERC.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txtBVZ_PERC.Enabled = False
        Me.txtBVZ_PERC.Location = New System.Drawing.Point(126, 143)
        Me.txtBVZ_PERC.Mask = "#.#"
        Me.txtBVZ_PERC.Name = "txtBVZ_PERC"
        Me.txtBVZ_PERC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtBVZ_PERC.Size = New System.Drawing.Size(35, 20)
        Me.txtBVZ_PERC.TabIndex = 9
        Me.txtBVZ_PERC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Chocolate
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Basis Verzekering"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Chocolate
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Salaris"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Chocolate
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(294, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Alleen verdiener Toeslag"
        '
        'lblOudtoeslag
        '
        Me.lblOudtoeslag.BackColor = System.Drawing.Color.Chocolate
        Me.lblOudtoeslag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOudtoeslag.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOudtoeslag.ForeColor = System.Drawing.Color.White
        Me.lblOudtoeslag.Location = New System.Drawing.Point(294, 90)
        Me.lblOudtoeslag.Name = "lblOudtoeslag"
        Me.lblOudtoeslag.Size = New System.Drawing.Size(112, 20)
        Me.lblOudtoeslag.TabIndex = 9
        Me.lblOudtoeslag.Text = "Ouderen TSLG"
        '
        'lblBeslInsp
        '
        Me.lblBeslInsp.BackColor = System.Drawing.Color.Chocolate
        Me.lblBeslInsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBeslInsp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeslInsp.ForeColor = System.Drawing.Color.White
        Me.lblBeslInsp.Location = New System.Drawing.Point(294, 65)
        Me.lblBeslInsp.Name = "lblBeslInsp"
        Me.lblBeslInsp.Size = New System.Drawing.Size(112, 20)
        Me.lblBeslInsp.TabIndex = 8
        Me.lblBeslInsp.Text = "Beschikking Insp"
        '
        'txtAVBZ_PERC
        '
        Me.txtAVBZ_PERC.AllowPromptAsInput = False
        Me.txtAVBZ_PERC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAVBZ_PERC.Enabled = False
        Me.txtAVBZ_PERC.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txtAVBZ_PERC.Location = New System.Drawing.Point(125, 91)
        Me.txtAVBZ_PERC.Mask = "0.0"
        Me.txtAVBZ_PERC.Name = "txtAVBZ_PERC"
        Me.txtAVBZ_PERC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtAVBZ_PERC.Size = New System.Drawing.Size(35, 20)
        Me.txtAVBZ_PERC.TabIndex = 7
        Me.txtAVBZ_PERC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAOVAWW_PERC
        '
        Me.txtAOVAWW_PERC.AllowPromptAsInput = False
        Me.txtAOVAWW_PERC.AsciiOnly = True
        Me.txtAOVAWW_PERC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAOVAWW_PERC.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txtAOVAWW_PERC.Enabled = False
        Me.txtAOVAWW_PERC.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtAOVAWW_PERC.Location = New System.Drawing.Point(125, 65)
        Me.txtAOVAWW_PERC.Mask = "0.0"
        Me.txtAOVAWW_PERC.Name = "txtAOVAWW_PERC"
        Me.txtAOVAWW_PERC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtAOVAWW_PERC.ResetOnPrompt = False
        Me.txtAOVAWW_PERC.ShortcutsEnabled = False
        Me.txtAOVAWW_PERC.Size = New System.Drawing.Size(35, 20)
        Me.txtAOVAWW_PERC.TabIndex = 6
        Me.txtAOVAWW_PERC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblZV
        '
        Me.lblZV.BackColor = System.Drawing.Color.Chocolate
        Me.lblZV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblZV.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZV.ForeColor = System.Drawing.Color.White
        Me.lblZV.Location = New System.Drawing.Point(7, 116)
        Me.lblZV.Name = "lblZV"
        Me.lblZV.Size = New System.Drawing.Size(112, 20)
        Me.lblZV.TabIndex = 4
        Me.lblZV.Text = "ZV (SVB) %"
        '
        'lblAVBZ
        '
        Me.lblAVBZ.BackColor = System.Drawing.Color.Chocolate
        Me.lblAVBZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAVBZ.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAVBZ.ForeColor = System.Drawing.Color.White
        Me.lblAVBZ.Location = New System.Drawing.Point(7, 90)
        Me.lblAVBZ.Name = "lblAVBZ"
        Me.lblAVBZ.Size = New System.Drawing.Size(112, 20)
        Me.lblAVBZ.TabIndex = 3
        Me.lblAVBZ.Text = "AVBZ %"
        '
        'lblAOVAWW
        '
        Me.lblAOVAWW.BackColor = System.Drawing.Color.Chocolate
        Me.lblAOVAWW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAOVAWW.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAOVAWW.ForeColor = System.Drawing.Color.White
        Me.lblAOVAWW.Location = New System.Drawing.Point(7, 65)
        Me.lblAOVAWW.Name = "lblAOVAWW"
        Me.lblAOVAWW.Size = New System.Drawing.Size(112, 20)
        Me.lblAOVAWW.TabIndex = 2
        Me.lblAOVAWW.Text = "AOV/AWW %"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape9, Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(957, 235)
        Me.ShapeContainer2.TabIndex = 23
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape9
        '
        Me.LineShape9.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 9
        Me.LineShape9.X2 = 789
        Me.LineShape9.Y1 = 31
        Me.LineShape9.Y2 = 31
        '
        'LineShape8
        '
        Me.LineShape8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 7
        Me.LineShape8.X2 = 787
        Me.LineShape8.Y1 = 113
        Me.LineShape8.Y2 = 113
        '
        'LineShape7
        '
        Me.LineShape7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 7
        Me.LineShape7.X2 = 787
        Me.LineShape7.Y1 = 167
        Me.LineShape7.Y2 = 167
        '
        'LineShape6
        '
        Me.LineShape6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 8
        Me.LineShape6.X2 = 788
        Me.LineShape6.Y1 = 140
        Me.LineShape6.Y2 = 140
        '
        'LineShape5
        '
        Me.LineShape5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 8
        Me.LineShape5.X2 = 788
        Me.LineShape5.Y1 = 196
        Me.LineShape5.Y2 = 196
        '
        'LineShape4
        '
        Me.LineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 7
        Me.LineShape4.X2 = 787
        Me.LineShape4.Y1 = 88
        Me.LineShape4.Y2 = 88
        '
        'LineShape3
        '
        Me.LineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 8
        Me.LineShape3.X2 = 788
        Me.LineShape3.Y1 = 60
        Me.LineShape3.Y2 = 60
        '
        'TAB02
        '
        Me.TAB02.BackColor = System.Drawing.Color.Maroon
        Me.TAB02.Controls.Add(Me.txtPartnerBelInkomen)
        Me.TAB02.Controls.Add(Me.TotalKtoeslag)
        Me.TAB02.Controls.Add(Me.txtPartnerBirthDate)
        Me.TAB02.Controls.Add(Me.txtChildrowcount)
        Me.TAB02.Controls.Add(Me.DataGridView2)
        Me.TAB02.Controls.Add(Me.txtPartnerEmployer)
        Me.TAB02.Controls.Add(Me.txtPartnerMidname)
        Me.TAB02.Controls.Add(Me.txtPartnerLastname)
        Me.TAB02.Controls.Add(Me.txtPartnerFirstname)
        Me.TAB02.Controls.Add(Me.lblBelInkomen)
        Me.TAB02.Controls.Add(Me.DatePickerPartnerBirthdate)
        Me.TAB02.Controls.Add(Me.lblSpouseBirthDate)
        Me.TAB02.Controls.Add(Me.lblSpouseEmployer)
        Me.TAB02.Controls.Add(Me.lblSpouseMiddenName)
        Me.TAB02.Controls.Add(Me.lblPartnerLastName)
        Me.TAB02.Controls.Add(Me.lblspouseName)
        Me.TAB02.Location = New System.Drawing.Point(4, 25)
        Me.TAB02.Name = "TAB02"
        Me.TAB02.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB02.Size = New System.Drawing.Size(957, 235)
        Me.TAB02.TabIndex = 1
        '
        'txtPartnerBelInkomen
        '
        Me.txtPartnerBelInkomen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartnerBelInkomen.Enabled = False
        Me.txtPartnerBelInkomen.Location = New System.Drawing.Point(484, 53)
        Me.txtPartnerBelInkomen.Name = "txtPartnerBelInkomen"
        Me.txtPartnerBelInkomen.Size = New System.Drawing.Size(86, 20)
        Me.txtPartnerBelInkomen.TabIndex = 6
        Me.txtPartnerBelInkomen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPartnerBelInkomen.WordWrap = False
        '
        'TotalKtoeslag
        '
        Me.TotalKtoeslag.Location = New System.Drawing.Point(768, 29)
        Me.TotalKtoeslag.Name = "TotalKtoeslag"
        Me.TotalKtoeslag.Size = New System.Drawing.Size(41, 20)
        Me.TotalKtoeslag.TabIndex = 19
        Me.TotalKtoeslag.Visible = False
        '
        'txtPartnerBirthDate
        '
        Me.txtPartnerBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartnerBirthDate.Enabled = False
        Me.txtPartnerBirthDate.Location = New System.Drawing.Point(484, 29)
        Me.txtPartnerBirthDate.Name = "txtPartnerBirthDate"
        Me.txtPartnerBirthDate.Size = New System.Drawing.Size(86, 20)
        Me.txtPartnerBirthDate.TabIndex = 5
        Me.txtPartnerBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChildrowcount
        '
        Me.txtChildrowcount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChildrowcount.Location = New System.Drawing.Point(786, 6)
        Me.txtChildrowcount.Name = "txtChildrowcount"
        Me.txtChildrowcount.Size = New System.Drawing.Size(23, 13)
        Me.txtChildrowcount.TabIndex = 16
        Me.txtChildrowcount.Text = "0"
        Me.txtChildrowcount.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Maroon
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView2.Location = New System.Drawing.Point(4, 88)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView2.RowHeadersWidth = 5
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(947, 126)
        Me.DataGridView2.TabIndex = 14
        '
        'txtPartnerEmployer
        '
        Me.txtPartnerEmployer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartnerEmployer.Enabled = False
        Me.txtPartnerEmployer.Location = New System.Drawing.Point(123, 53)
        Me.txtPartnerEmployer.Name = "txtPartnerEmployer"
        Me.txtPartnerEmployer.Size = New System.Drawing.Size(235, 20)
        Me.txtPartnerEmployer.TabIndex = 4
        '
        'txtPartnerMidname
        '
        Me.txtPartnerMidname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartnerMidname.Enabled = False
        Me.txtPartnerMidname.Location = New System.Drawing.Point(484, 6)
        Me.txtPartnerMidname.Name = "txtPartnerMidname"
        Me.txtPartnerMidname.Size = New System.Drawing.Size(235, 20)
        Me.txtPartnerMidname.TabIndex = 2
        '
        'txtPartnerLastname
        '
        Me.txtPartnerLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartnerLastname.Enabled = False
        Me.txtPartnerLastname.Location = New System.Drawing.Point(123, 29)
        Me.txtPartnerLastname.Name = "txtPartnerLastname"
        Me.txtPartnerLastname.Size = New System.Drawing.Size(235, 20)
        Me.txtPartnerLastname.TabIndex = 3
        '
        'txtPartnerFirstname
        '
        Me.txtPartnerFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartnerFirstname.Enabled = False
        Me.txtPartnerFirstname.Location = New System.Drawing.Point(123, 6)
        Me.txtPartnerFirstname.Name = "txtPartnerFirstname"
        Me.txtPartnerFirstname.Size = New System.Drawing.Size(235, 20)
        Me.txtPartnerFirstname.TabIndex = 1
        '
        'lblBelInkomen
        '
        Me.lblBelInkomen.BackColor = System.Drawing.Color.Chocolate
        Me.lblBelInkomen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBelInkomen.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBelInkomen.ForeColor = System.Drawing.Color.White
        Me.lblBelInkomen.Location = New System.Drawing.Point(364, 53)
        Me.lblBelInkomen.Name = "lblBelInkomen"
        Me.lblBelInkomen.Size = New System.Drawing.Size(112, 20)
        Me.lblBelInkomen.TabIndex = 20
        Me.lblBelInkomen.Text = "Bel.Inkomen"
        '
        'DatePickerPartnerBirthdate
        '
        Me.DatePickerPartnerBirthdate.AccessibleName = ""
        Me.DatePickerPartnerBirthdate.CalendarMonthBackground = System.Drawing.Color.Tan
        Me.DatePickerPartnerBirthdate.CustomFormat = "dd-MM-yyyy"
        Me.DatePickerPartnerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePickerPartnerBirthdate.Location = New System.Drawing.Point(484, 27)
        Me.DatePickerPartnerBirthdate.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.DatePickerPartnerBirthdate.Name = "DatePickerPartnerBirthdate"
        Me.DatePickerPartnerBirthdate.Size = New System.Drawing.Size(86, 20)
        Me.DatePickerPartnerBirthdate.TabIndex = 13
        Me.DatePickerPartnerBirthdate.Value = New Date(2010, 12, 25, 0, 0, 0, 0)
        Me.DatePickerPartnerBirthdate.Visible = False
        '
        'lblSpouseBirthDate
        '
        Me.lblSpouseBirthDate.BackColor = System.Drawing.Color.Chocolate
        Me.lblSpouseBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSpouseBirthDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpouseBirthDate.ForeColor = System.Drawing.Color.White
        Me.lblSpouseBirthDate.Location = New System.Drawing.Point(365, 29)
        Me.lblSpouseBirthDate.Name = "lblSpouseBirthDate"
        Me.lblSpouseBirthDate.Size = New System.Drawing.Size(112, 20)
        Me.lblSpouseBirthDate.TabIndex = 12
        Me.lblSpouseBirthDate.Text = "Geb.Datum"
        '
        'lblSpouseEmployer
        '
        Me.lblSpouseEmployer.BackColor = System.Drawing.Color.Chocolate
        Me.lblSpouseEmployer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSpouseEmployer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpouseEmployer.ForeColor = System.Drawing.Color.White
        Me.lblSpouseEmployer.Location = New System.Drawing.Point(6, 53)
        Me.lblSpouseEmployer.Name = "lblSpouseEmployer"
        Me.lblSpouseEmployer.Size = New System.Drawing.Size(112, 20)
        Me.lblSpouseEmployer.TabIndex = 10
        Me.lblSpouseEmployer.Text = "Werkgever"
        '
        'lblSpouseMiddenName
        '
        Me.lblSpouseMiddenName.BackColor = System.Drawing.Color.Chocolate
        Me.lblSpouseMiddenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSpouseMiddenName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpouseMiddenName.ForeColor = System.Drawing.Color.White
        Me.lblSpouseMiddenName.Location = New System.Drawing.Point(365, 6)
        Me.lblSpouseMiddenName.Name = "lblSpouseMiddenName"
        Me.lblSpouseMiddenName.Size = New System.Drawing.Size(112, 20)
        Me.lblSpouseMiddenName.TabIndex = 8
        Me.lblSpouseMiddenName.Text = "Meisjesnaam"
        '
        'lblPartnerLastName
        '
        Me.lblPartnerLastName.BackColor = System.Drawing.Color.Chocolate
        Me.lblPartnerLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPartnerLastName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartnerLastName.ForeColor = System.Drawing.Color.White
        Me.lblPartnerLastName.Location = New System.Drawing.Point(6, 29)
        Me.lblPartnerLastName.Name = "lblPartnerLastName"
        Me.lblPartnerLastName.Size = New System.Drawing.Size(112, 20)
        Me.lblPartnerLastName.TabIndex = 6
        Me.lblPartnerLastName.Text = "Achternaam"
        '
        'lblspouseName
        '
        Me.lblspouseName.BackColor = System.Drawing.Color.Chocolate
        Me.lblspouseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblspouseName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblspouseName.ForeColor = System.Drawing.Color.White
        Me.lblspouseName.Location = New System.Drawing.Point(6, 5)
        Me.lblspouseName.Name = "lblspouseName"
        Me.lblspouseName.Size = New System.Drawing.Size(112, 20)
        Me.lblspouseName.TabIndex = 2
        Me.lblspouseName.Text = "Voornaam Partner"
        '
        'TAB01
        '
        Me.TAB01.BackColor = System.Drawing.Color.Maroon
        Me.TAB01.Controls.Add(Me.chk)
        Me.TAB01.Controls.Add(Me.cmbIsland)
        Me.TAB01.Controls.Add(Me.lblIsland)
        Me.TAB01.Controls.Add(Me.txtDepartmentNr)
        Me.TAB01.Controls.Add(Me.txtCompanyNr)
        Me.TAB01.Controls.Add(Me.txtBirthdate)
        Me.TAB01.Controls.Add(Me.txtDateEnd)
        Me.TAB01.Controls.Add(Me.txtDateBegin)
        Me.TAB01.Controls.Add(Me.txtEmployeeEmail2)
        Me.TAB01.Controls.Add(Me.txtEmployeeEmail1)
        Me.TAB01.Controls.Add(Me.txtEmployeefunction)
        Me.TAB01.Controls.Add(Me.txtemployeeAddress)
        Me.TAB01.Controls.Add(Me.txtemployeeLastName)
        Me.TAB01.Controls.Add(Me.txtEmployeeFirstName)
        Me.TAB01.Controls.Add(Me.cmbSelectDepartment)
        Me.TAB01.Controls.Add(Me.cmbSelectCompany)
        Me.TAB01.Controls.Add(Me.calEmployeeDateBegin)
        Me.TAB01.Controls.Add(Me.txtEmployeeMobile)
        Me.TAB01.Controls.Add(Me.lblEmployeeCel)
        Me.TAB01.Controls.Add(Me.txtEmployeeHomePhone)
        Me.TAB01.Controls.Add(Me.lblEmployeeHomePhone)
        Me.TAB01.Controls.Add(Me.lblEmployeeEmial2)
        Me.TAB01.Controls.Add(Me.lblEmployeeMail)
        Me.TAB01.Controls.Add(Me.txtEmployeeVRW)
        Me.TAB01.Controls.Add(Me.txtEmployeeMAN)
        Me.TAB01.Controls.Add(Me.lblEmployeeSex)
        Me.TAB01.Controls.Add(Me.txtEmployeeStatus)
        Me.TAB01.Controls.Add(Me.txtEmployeeNr)
        Me.TAB01.Controls.Add(Me.lblemployeeNr)
        Me.TAB01.Controls.Add(Me.lblEmployeePicture)
        Me.TAB01.Controls.Add(Me.txtEmployeePicture)
        Me.TAB01.Controls.Add(Me.EmpPictBox)
        Me.TAB01.Controls.Add(Me.lblEmployeeFunction)
        Me.TAB01.Controls.Add(Me.CalendarPickerBirthdate)
        Me.TAB01.Controls.Add(Me.lblEmployeeAdres)
        Me.TAB01.Controls.Add(Me.lblEmployeeStatus)
        Me.TAB01.Controls.Add(Me.lblEmployeeDepartment)
        Me.TAB01.Controls.Add(Me.calEmployeeDateEnd)
        Me.TAB01.Controls.Add(Me.lblEmployeeEnddate)
        Me.TAB01.Controls.Add(Me.lblEmployeestartdate)
        Me.TAB01.Controls.Add(Me.lblEmployeeGebDatum)
        Me.TAB01.Controls.Add(Me.txtEmployeeCedulaNr)
        Me.TAB01.Controls.Add(Me.lblEmployeecedulaNr)
        Me.TAB01.Controls.Add(Me.lblEmployeeLastname)
        Me.TAB01.Controls.Add(Me.lblEmployeeName)
        Me.TAB01.Controls.Add(Me.lblEmployeeBedrijf)
        Me.TAB01.Location = New System.Drawing.Point(4, 25)
        Me.TAB01.Name = "TAB01"
        Me.TAB01.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB01.Size = New System.Drawing.Size(957, 235)
        Me.TAB01.TabIndex = 0
        '
        'chk
        '
        Me.chk.AutoSize = True
        Me.chk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk.Location = New System.Drawing.Point(599, 57)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(12, 11)
        Me.chk.TabIndex = 55
        Me.chk.UseVisualStyleBackColor = True
        '
        'cmbIsland
        '
        Me.cmbIsland.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbIsland.DropDownWidth = 180
        Me.cmbIsland.Enabled = False
        Me.cmbIsland.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbIsland.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIsland.FormattingEnabled = True
        Me.cmbIsland.Location = New System.Drawing.Point(546, 8)
        Me.cmbIsland.Name = "cmbIsland"
        Me.cmbIsland.Size = New System.Drawing.Size(72, 21)
        Me.cmbIsland.TabIndex = 54
        Me.cmbIsland.TabStop = False
        '
        'lblIsland
        '
        Me.lblIsland.BackColor = System.Drawing.Color.Chocolate
        Me.lblIsland.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIsland.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsland.ForeColor = System.Drawing.Color.White
        Me.lblIsland.Location = New System.Drawing.Point(430, 7)
        Me.lblIsland.Name = "lblIsland"
        Me.lblIsland.Size = New System.Drawing.Size(112, 20)
        Me.lblIsland.TabIndex = 53
        Me.lblIsland.Text = "Island"
        '
        'txtDepartmentNr
        '
        Me.txtDepartmentNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepartmentNr.Enabled = False
        Me.txtDepartmentNr.Location = New System.Drawing.Point(336, 7)
        Me.txtDepartmentNr.MaxLength = 3
        Me.txtDepartmentNr.Name = "txtDepartmentNr"
        Me.txtDepartmentNr.Size = New System.Drawing.Size(86, 20)
        Me.txtDepartmentNr.TabIndex = 52
        Me.txtDepartmentNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCompanyNr
        '
        Me.txtCompanyNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompanyNr.Enabled = False
        Me.txtCompanyNr.Location = New System.Drawing.Point(125, 8)
        Me.txtCompanyNr.Name = "txtCompanyNr"
        Me.txtCompanyNr.Size = New System.Drawing.Size(87, 20)
        Me.txtCompanyNr.TabIndex = 51
        Me.txtCompanyNr.Text = "0"
        Me.txtCompanyNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBirthdate
        '
        Me.txtBirthdate.BackColor = System.Drawing.Color.White
        Me.txtBirthdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBirthdate.Enabled = False
        Me.txtBirthdate.Location = New System.Drawing.Point(337, 104)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.ReadOnly = True
        Me.txtBirthdate.Size = New System.Drawing.Size(87, 20)
        Me.txtBirthdate.TabIndex = 50
        Me.txtBirthdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDateEnd
        '
        Me.txtDateEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDateEnd.Enabled = False
        Me.txtDateEnd.Location = New System.Drawing.Point(126, 175)
        Me.txtDateEnd.MaxLength = 8
        Me.txtDateEnd.Name = "txtDateEnd"
        Me.txtDateEnd.Size = New System.Drawing.Size(88, 20)
        Me.txtDateEnd.TabIndex = 49
        Me.txtDateEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDateBegin
        '
        Me.txtDateBegin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDateBegin.Enabled = False
        Me.txtDateBegin.Location = New System.Drawing.Point(126, 153)
        Me.txtDateBegin.MaxLength = 8
        Me.txtDateBegin.Name = "txtDateBegin"
        Me.txtDateBegin.Size = New System.Drawing.Size(88, 20)
        Me.txtDateBegin.TabIndex = 48
        Me.txtDateBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployeeEmail2
        '
        Me.txtEmployeeEmail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeEmail2.Enabled = False
        Me.txtEmployeeEmail2.Location = New System.Drawing.Point(336, 176)
        Me.txtEmployeeEmail2.Name = "txtEmployeeEmail2"
        Me.txtEmployeeEmail2.Size = New System.Drawing.Size(282, 20)
        Me.txtEmployeeEmail2.TabIndex = 39
        '
        'txtEmployeeEmail1
        '
        Me.txtEmployeeEmail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeEmail1.Enabled = False
        Me.txtEmployeeEmail1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeEmail1.Location = New System.Drawing.Point(336, 152)
        Me.txtEmployeeEmail1.Name = "txtEmployeeEmail1"
        Me.txtEmployeeEmail1.Size = New System.Drawing.Size(282, 21)
        Me.txtEmployeeEmail1.TabIndex = 37
        '
        'txtEmployeefunction
        '
        Me.txtEmployeefunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeefunction.Enabled = False
        Me.txtEmployeefunction.Location = New System.Drawing.Point(125, 127)
        Me.txtEmployeefunction.Name = "txtEmployeefunction"
        Me.txtEmployeefunction.Size = New System.Drawing.Size(299, 20)
        Me.txtEmployeefunction.TabIndex = 11
        '
        'txtemployeeAddress
        '
        Me.txtemployeeAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemployeeAddress.Enabled = False
        Me.txtemployeeAddress.Location = New System.Drawing.Point(126, 77)
        Me.txtemployeeAddress.Name = "txtemployeeAddress"
        Me.txtemployeeAddress.Size = New System.Drawing.Size(298, 20)
        Me.txtemployeeAddress.TabIndex = 5
        '
        'txtemployeeLastName
        '
        Me.txtemployeeLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemployeeLastName.Enabled = False
        Me.txtemployeeLastName.Location = New System.Drawing.Point(126, 54)
        Me.txtemployeeLastName.Name = "txtemployeeLastName"
        Me.txtemployeeLastName.Size = New System.Drawing.Size(297, 20)
        Me.txtemployeeLastName.TabIndex = 4
        '
        'txtEmployeeFirstName
        '
        Me.txtEmployeeFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeFirstName.Enabled = False
        Me.txtEmployeeFirstName.Location = New System.Drawing.Point(126, 31)
        Me.txtEmployeeFirstName.Name = "txtEmployeeFirstName"
        Me.txtEmployeeFirstName.Size = New System.Drawing.Size(87, 20)
        Me.txtEmployeeFirstName.TabIndex = 3
        '
        'cmbSelectDepartment
        '
        Me.cmbSelectDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbSelectDepartment.DropDownWidth = 180
        Me.cmbSelectDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSelectDepartment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectDepartment.FormattingEnabled = True
        Me.cmbSelectDepartment.Location = New System.Drawing.Point(337, 7)
        Me.cmbSelectDepartment.Name = "cmbSelectDepartment"
        Me.cmbSelectDepartment.Size = New System.Drawing.Size(84, 21)
        Me.cmbSelectDepartment.TabIndex = 47
        Me.cmbSelectDepartment.TabStop = False
        Me.cmbSelectDepartment.Visible = False
        '
        'cmbSelectCompany
        '
        Me.cmbSelectCompany.DropDownWidth = 160
        Me.cmbSelectCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSelectCompany.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectCompany.FormattingEnabled = True
        Me.cmbSelectCompany.ItemHeight = 13
        Me.cmbSelectCompany.Location = New System.Drawing.Point(126, 8)
        Me.cmbSelectCompany.Name = "cmbSelectCompany"
        Me.cmbSelectCompany.Size = New System.Drawing.Size(45, 21)
        Me.cmbSelectCompany.TabIndex = 46
        Me.cmbSelectCompany.Visible = False
        '
        'calEmployeeDateBegin
        '
        Me.calEmployeeDateBegin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calEmployeeDateBegin.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.calEmployeeDateBegin.CalendarMonthBackground = System.Drawing.Color.RosyBrown
        Me.calEmployeeDateBegin.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod
        Me.calEmployeeDateBegin.CustomFormat = "dd-MM-yyyy"
        Me.calEmployeeDateBegin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calEmployeeDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.calEmployeeDateBegin.Location = New System.Drawing.Point(126, 152)
        Me.calEmployeeDateBegin.MaxDate = New Date(2030, 1, 1, 0, 0, 0, 0)
        Me.calEmployeeDateBegin.MinDate = New Date(1930, 1, 1, 0, 0, 0, 0)
        Me.calEmployeeDateBegin.Name = "calEmployeeDateBegin"
        Me.calEmployeeDateBegin.Size = New System.Drawing.Size(87, 21)
        Me.calEmployeeDateBegin.TabIndex = 45
        Me.calEmployeeDateBegin.Visible = False
        '
        'txtEmployeeMobile
        '
        Me.txtEmployeeMobile.AllowPromptAsInput = False
        Me.txtEmployeeMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeMobile.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txtEmployeeMobile.Enabled = False
        Me.txtEmployeeMobile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeMobile.HidePromptOnLeave = True
        Me.txtEmployeeMobile.Location = New System.Drawing.Point(543, 102)
        Me.txtEmployeeMobile.Mask = "##########"
        Me.txtEmployeeMobile.Name = "txtEmployeeMobile"
        Me.txtEmployeeMobile.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtEmployeeMobile.Size = New System.Drawing.Size(75, 21)
        Me.txtEmployeeMobile.TabIndex = 43
        Me.txtEmployeeMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmployeeMobile.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblEmployeeCel
        '
        Me.lblEmployeeCel.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeCel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeCel.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeCel.Location = New System.Drawing.Point(429, 126)
        Me.lblEmployeeCel.Name = "lblEmployeeCel"
        Me.lblEmployeeCel.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeCel.TabIndex = 42
        '
        'txtEmployeeHomePhone
        '
        Me.txtEmployeeHomePhone.AllowPromptAsInput = False
        Me.txtEmployeeHomePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeHomePhone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txtEmployeeHomePhone.Enabled = False
        Me.txtEmployeeHomePhone.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeHomePhone.HidePromptOnLeave = True
        Me.txtEmployeeHomePhone.Location = New System.Drawing.Point(543, 126)
        Me.txtEmployeeHomePhone.Mask = "##########"
        Me.txtEmployeeHomePhone.Name = "txtEmployeeHomePhone"
        Me.txtEmployeeHomePhone.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtEmployeeHomePhone.Size = New System.Drawing.Size(75, 21)
        Me.txtEmployeeHomePhone.TabIndex = 41
        Me.txtEmployeeHomePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmployeeHomePhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblEmployeeHomePhone
        '
        Me.lblEmployeeHomePhone.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeHomePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeHomePhone.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeHomePhone.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeHomePhone.Location = New System.Drawing.Point(429, 102)
        Me.lblEmployeeHomePhone.Name = "lblEmployeeHomePhone"
        Me.lblEmployeeHomePhone.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeHomePhone.TabIndex = 40
        '
        'lblEmployeeEmial2
        '
        Me.lblEmployeeEmial2.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeEmial2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeEmial2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeEmial2.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeEmial2.Location = New System.Drawing.Point(222, 175)
        Me.lblEmployeeEmial2.Name = "lblEmployeeEmial2"
        Me.lblEmployeeEmial2.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeEmial2.TabIndex = 38
        '
        'lblEmployeeMail
        '
        Me.lblEmployeeMail.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeMail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeMail.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeMail.Location = New System.Drawing.Point(222, 152)
        Me.lblEmployeeMail.Name = "lblEmployeeMail"
        Me.lblEmployeeMail.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeMail.TabIndex = 36
        '
        'txtEmployeeVRW
        '
        Me.txtEmployeeVRW.BackColor = System.Drawing.Color.Chocolate
        Me.txtEmployeeVRW.Enabled = False
        Me.txtEmployeeVRW.Location = New System.Drawing.Point(519, 55)
        Me.txtEmployeeVRW.Name = "txtEmployeeVRW"
        Me.txtEmployeeVRW.Size = New System.Drawing.Size(13, 16)
        Me.txtEmployeeVRW.TabIndex = 1
        Me.txtEmployeeVRW.UseVisualStyleBackColor = False
        '
        'txtEmployeeMAN
        '
        Me.txtEmployeeMAN.BackColor = System.Drawing.Color.Chocolate
        Me.txtEmployeeMAN.Checked = True
        Me.txtEmployeeMAN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.txtEmployeeMAN.Enabled = False
        Me.txtEmployeeMAN.Location = New System.Drawing.Point(501, 55)
        Me.txtEmployeeMAN.Name = "txtEmployeeMAN"
        Me.txtEmployeeMAN.Size = New System.Drawing.Size(12, 17)
        Me.txtEmployeeMAN.TabIndex = 0
        Me.txtEmployeeMAN.UseVisualStyleBackColor = False
        '
        'lblEmployeeSex
        '
        Me.lblEmployeeSex.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeSex.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeSex.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeSex.Location = New System.Drawing.Point(429, 54)
        Me.lblEmployeeSex.Name = "lblEmployeeSex"
        Me.lblEmployeeSex.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeSex.TabIndex = 35
        '
        'txtEmployeeStatus
        '
        Me.txtEmployeeStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeStatus.Enabled = False
        Me.txtEmployeeStatus.Location = New System.Drawing.Point(547, 30)
        Me.txtEmployeeStatus.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtEmployeeStatus.Name = "txtEmployeeStatus"
        Me.txtEmployeeStatus.Size = New System.Drawing.Size(37, 20)
        Me.txtEmployeeStatus.TabIndex = 9
        Me.txtEmployeeStatus.TabStop = False
        Me.txtEmployeeStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmployeeStatus.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtEmployeeNr
        '
        Me.txtEmployeeNr.AllowPromptAsInput = False
        Me.txtEmployeeNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeNr.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txtEmployeeNr.Enabled = False
        Me.txtEmployeeNr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeNr.HidePromptOnLeave = True
        Me.txtEmployeeNr.Location = New System.Drawing.Point(336, 31)
        Me.txtEmployeeNr.Mask = "######"
        Me.txtEmployeeNr.Name = "txtEmployeeNr"
        Me.txtEmployeeNr.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtEmployeeNr.Size = New System.Drawing.Size(87, 21)
        Me.txtEmployeeNr.TabIndex = 2
        Me.txtEmployeeNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmployeeNr.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblemployeeNr
        '
        Me.lblemployeeNr.BackColor = System.Drawing.Color.Chocolate
        Me.lblemployeeNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblemployeeNr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemployeeNr.ForeColor = System.Drawing.Color.White
        Me.lblemployeeNr.Location = New System.Drawing.Point(222, 32)
        Me.lblemployeeNr.Name = "lblemployeeNr"
        Me.lblemployeeNr.Size = New System.Drawing.Size(108, 20)
        Me.lblemployeeNr.TabIndex = 2
        '
        'lblEmployeePicture
        '
        Me.lblEmployeePicture.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeePicture.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeePicture.ForeColor = System.Drawing.Color.White
        Me.lblEmployeePicture.Location = New System.Drawing.Point(429, 77)
        Me.lblEmployeePicture.Name = "lblEmployeePicture"
        Me.lblEmployeePicture.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeePicture.TabIndex = 6
        '
        'txtEmployeePicture
        '
        Me.txtEmployeePicture.AllowPromptAsInput = False
        Me.txtEmployeePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeePicture.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.txtEmployeePicture.Enabled = False
        Me.txtEmployeePicture.HidePromptOnLeave = True
        Me.txtEmployeePicture.Location = New System.Drawing.Point(543, 77)
        Me.txtEmployeePicture.Mask = "##########"
        Me.txtEmployeePicture.Name = "txtEmployeePicture"
        Me.txtEmployeePicture.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtEmployeePicture.Size = New System.Drawing.Size(75, 20)
        Me.txtEmployeePicture.TabIndex = 6
        Me.txtEmployeePicture.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmployeePicture.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'EmpPictBox
        '
        Me.EmpPictBox.BackColor = System.Drawing.Color.DarkSalmon
        Me.EmpPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EmpPictBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPictBox.ErrorImage = Nothing
        Me.EmpPictBox.ImageLocation = "CurDir"
        Me.EmpPictBox.InitialImage = Nothing
        Me.EmpPictBox.Location = New System.Drawing.Point(652, 9)
        Me.EmpPictBox.Name = "EmpPictBox"
        Me.EmpPictBox.Size = New System.Drawing.Size(151, 186)
        Me.EmpPictBox.TabIndex = 26
        Me.EmpPictBox.TabStop = False
        '
        'lblEmployeeFunction
        '
        Me.lblEmployeeFunction.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeFunction.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeFunction.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeFunction.Location = New System.Drawing.Point(8, 127)
        Me.lblEmployeeFunction.Name = "lblEmployeeFunction"
        Me.lblEmployeeFunction.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeFunction.TabIndex = 11
        '
        'CalendarPickerBirthdate
        '
        Me.CalendarPickerBirthdate.CalendarFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.CalendarPickerBirthdate.Checked = False
        Me.CalendarPickerBirthdate.CustomFormat = "dd-MM-yyyy"
        Me.CalendarPickerBirthdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalendarPickerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CalendarPickerBirthdate.Location = New System.Drawing.Point(336, 102)
        Me.CalendarPickerBirthdate.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.CalendarPickerBirthdate.Name = "CalendarPickerBirthdate"
        Me.CalendarPickerBirthdate.Size = New System.Drawing.Size(88, 21)
        Me.CalendarPickerBirthdate.TabIndex = 8
        Me.CalendarPickerBirthdate.TabStop = False
        Me.CalendarPickerBirthdate.Value = New Date(2010, 7, 24, 0, 0, 0, 0)
        Me.CalendarPickerBirthdate.Visible = False
        '
        'lblEmployeeAdres
        '
        Me.lblEmployeeAdres.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeAdres.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeAdres.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeAdres.Location = New System.Drawing.Point(8, 77)
        Me.lblEmployeeAdres.Name = "lblEmployeeAdres"
        Me.lblEmployeeAdres.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeAdres.TabIndex = 5
        '
        'lblEmployeeStatus
        '
        Me.lblEmployeeStatus.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeStatus.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeStatus.Location = New System.Drawing.Point(429, 31)
        Me.lblEmployeeStatus.Name = "lblEmployeeStatus"
        Me.lblEmployeeStatus.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeStatus.TabIndex = 9
        Me.lblEmployeeStatus.Text = "Status (1=Aktief)"
        '
        'lblEmployeeDepartment
        '
        Me.lblEmployeeDepartment.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeDepartment.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeDepartment.Location = New System.Drawing.Point(222, 8)
        Me.lblEmployeeDepartment.Name = "lblEmployeeDepartment"
        Me.lblEmployeeDepartment.Size = New System.Drawing.Size(108, 20)
        Me.lblEmployeeDepartment.TabIndex = 10
        '
        'calEmployeeDateEnd
        '
        Me.calEmployeeDateEnd.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calEmployeeDateEnd.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.calEmployeeDateEnd.CalendarMonthBackground = System.Drawing.Color.RosyBrown
        Me.calEmployeeDateEnd.CustomFormat = "dd-MM-yyyy"
        Me.calEmployeeDateEnd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calEmployeeDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.calEmployeeDateEnd.Location = New System.Drawing.Point(126, 175)
        Me.calEmployeeDateEnd.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.calEmployeeDateEnd.Name = "calEmployeeDateEnd"
        Me.calEmployeeDateEnd.Size = New System.Drawing.Size(87, 21)
        Me.calEmployeeDateEnd.TabIndex = 13
        Me.calEmployeeDateEnd.TabStop = False
        Me.calEmployeeDateEnd.Value = New Date(2011, 12, 16, 0, 0, 0, 0)
        '
        'lblEmployeeEnddate
        '
        Me.lblEmployeeEnddate.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeEnddate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeEnddate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeEnddate.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeEnddate.Location = New System.Drawing.Point(8, 175)
        Me.lblEmployeeEnddate.Name = "lblEmployeeEnddate"
        Me.lblEmployeeEnddate.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeEnddate.TabIndex = 13
        '
        'lblEmployeestartdate
        '
        Me.lblEmployeestartdate.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeestartdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeestartdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeestartdate.ForeColor = System.Drawing.Color.White
        Me.lblEmployeestartdate.Location = New System.Drawing.Point(8, 152)
        Me.lblEmployeestartdate.Name = "lblEmployeestartdate"
        Me.lblEmployeestartdate.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeestartdate.TabIndex = 12
        '
        'lblEmployeeGebDatum
        '
        Me.lblEmployeeGebDatum.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeGebDatum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeGebDatum.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeGebDatum.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeGebDatum.Location = New System.Drawing.Point(222, 103)
        Me.lblEmployeeGebDatum.Name = "lblEmployeeGebDatum"
        Me.lblEmployeeGebDatum.Size = New System.Drawing.Size(108, 20)
        Me.lblEmployeeGebDatum.TabIndex = 8
        '
        'txtEmployeeCedulaNr
        '
        Me.txtEmployeeCedulaNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeCedulaNr.Enabled = False
        Me.txtEmployeeCedulaNr.Location = New System.Drawing.Point(126, 102)
        Me.txtEmployeeCedulaNr.Mask = "##########"
        Me.txtEmployeeCedulaNr.Name = "txtEmployeeCedulaNr"
        Me.txtEmployeeCedulaNr.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtEmployeeCedulaNr.Size = New System.Drawing.Size(88, 20)
        Me.txtEmployeeCedulaNr.TabIndex = 7
        Me.txtEmployeeCedulaNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmployeeCedulaNr.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblEmployeecedulaNr
        '
        Me.lblEmployeecedulaNr.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeecedulaNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeecedulaNr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeecedulaNr.ForeColor = System.Drawing.Color.White
        Me.lblEmployeecedulaNr.Location = New System.Drawing.Point(8, 102)
        Me.lblEmployeecedulaNr.Name = "lblEmployeecedulaNr"
        Me.lblEmployeecedulaNr.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeecedulaNr.TabIndex = 7
        '
        'lblEmployeeLastname
        '
        Me.lblEmployeeLastname.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeLastname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeLastname.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeLastname.Location = New System.Drawing.Point(8, 54)
        Me.lblEmployeeLastname.Name = "lblEmployeeLastname"
        Me.lblEmployeeLastname.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeLastname.TabIndex = 4
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeName.Location = New System.Drawing.Point(8, 30)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeName.TabIndex = 3
        '
        'lblEmployeeBedrijf
        '
        Me.lblEmployeeBedrijf.BackColor = System.Drawing.Color.Chocolate
        Me.lblEmployeeBedrijf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeBedrijf.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeBedrijf.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeBedrijf.Location = New System.Drawing.Point(8, 8)
        Me.lblEmployeeBedrijf.Name = "lblEmployeeBedrijf"
        Me.lblEmployeeBedrijf.Size = New System.Drawing.Size(112, 20)
        Me.lblEmployeeBedrijf.TabIndex = 1
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.TAB01)
        Me.TabControl.Controls.Add(Me.TAB02)
        Me.TabControl.Controls.Add(Me.TAB03)
        Me.TabControl.Controls.Add(Me.TAB04)
        Me.TabControl.Controls.Add(Me.TAB05)
        Me.TabControl.Controls.Add(Me.TAB06)
        Me.TabControl.Controls.Add(Me.TAB07)
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.HotTrack = True
        Me.TabControl.Location = New System.Drawing.Point(0, 66)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(965, 264)
        Me.TabControl.TabIndex = 0
        '
        'TAB07
        '
        Me.TAB07.BackColor = System.Drawing.Color.Maroon
        Me.TAB07.Controls.Add(Me.DGEmpDeductions)
        Me.TAB07.Location = New System.Drawing.Point(4, 25)
        Me.TAB07.Name = "TAB07"
        Me.TAB07.Size = New System.Drawing.Size(957, 235)
        Me.TAB07.TabIndex = 6
        '
        'DGEmpDeductions
        '
        Me.DGEmpDeductions.BackgroundColor = System.Drawing.Color.White
        Me.DGEmpDeductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEmpDeductions.Location = New System.Drawing.Point(3, 3)
        Me.DGEmpDeductions.Name = "DGEmpDeductions"
        Me.DGEmpDeductions.Size = New System.Drawing.Size(951, 229)
        Me.DGEmpDeductions.TabIndex = 0
        '
        'lblSpaarFondsNaam
        '
        Me.lblSpaarFondsNaam.BackColor = System.Drawing.Color.Chocolate
        Me.lblSpaarFondsNaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSpaarFondsNaam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpaarFondsNaam.ForeColor = System.Drawing.Color.White
        Me.lblSpaarFondsNaam.Location = New System.Drawing.Point(113, 16)
        Me.lblSpaarFondsNaam.Name = "lblSpaarFondsNaam"
        Me.lblSpaarFondsNaam.Size = New System.Drawing.Size(112, 20)
        Me.lblSpaarFondsNaam.TabIndex = 26
        '
        'txtSpaarFondsNaam
        '
        Me.txtSpaarFondsNaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSpaarFondsNaam.Enabled = False
        Me.txtSpaarFondsNaam.Location = New System.Drawing.Point(231, 16)
        Me.txtSpaarFondsNaam.Name = "txtSpaarFondsNaam"
        Me.txtSpaarFondsNaam.Size = New System.Drawing.Size(315, 20)
        Me.txtSpaarFondsNaam.TabIndex = 27
        Me.txtSpaarFondsNaam.WordWrap = False
        '
        'lblWerkgeversBijdrage
        '
        Me.lblWerkgeversBijdrage.BackColor = System.Drawing.Color.Chocolate
        Me.lblWerkgeversBijdrage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWerkgeversBijdrage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWerkgeversBijdrage.ForeColor = System.Drawing.Color.White
        Me.lblWerkgeversBijdrage.Location = New System.Drawing.Point(113, 45)
        Me.lblWerkgeversBijdrage.Name = "lblWerkgeversBijdrage"
        Me.lblWerkgeversBijdrage.Size = New System.Drawing.Size(112, 20)
        Me.lblWerkgeversBijdrage.TabIndex = 28
        '
        'txtSpaarFondsWGPerc
        '
        Me.txtSpaarFondsWGPerc.BeepOnError = True
        Me.txtSpaarFondsWGPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSpaarFondsWGPerc.Enabled = False
        Me.txtSpaarFondsWGPerc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txtSpaarFondsWGPerc.Location = New System.Drawing.Point(231, 45)
        Me.txtSpaarFondsWGPerc.Mask = "9.9"
        Me.txtSpaarFondsWGPerc.Name = "txtSpaarFondsWGPerc"
        Me.txtSpaarFondsWGPerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtSpaarFondsWGPerc.Size = New System.Drawing.Size(23, 20)
        Me.txtSpaarFondsWGPerc.TabIndex = 28
        Me.txtSpaarFondsWGPerc.Text = "00"
        Me.txtSpaarFondsWGPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Chocolate
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(113, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 30
        '
        'txtSpaarFondsWNPerc
        '
        Me.txtSpaarFondsWNPerc.AllowPromptAsInput = False
        Me.txtSpaarFondsWNPerc.BeepOnError = True
        Me.txtSpaarFondsWNPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSpaarFondsWNPerc.Enabled = False
        Me.txtSpaarFondsWNPerc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txtSpaarFondsWNPerc.Location = New System.Drawing.Point(231, 74)
        Me.txtSpaarFondsWNPerc.Mask = "9.9"
        Me.txtSpaarFondsWNPerc.Name = "txtSpaarFondsWNPerc"
        Me.txtSpaarFondsWNPerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtSpaarFondsWNPerc.ResetOnPrompt = False
        Me.txtSpaarFondsWNPerc.Size = New System.Drawing.Size(23, 20)
        Me.txtSpaarFondsWNPerc.TabIndex = 29
        Me.txtSpaarFondsWNPerc.Text = "00"
        Me.txtSpaarFondsWNPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPensioenfondsNaam
        '
        Me.lblPensioenfondsNaam.BackColor = System.Drawing.Color.Chocolate
        Me.lblPensioenfondsNaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPensioenfondsNaam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPensioenfondsNaam.ForeColor = System.Drawing.Color.White
        Me.lblPensioenfondsNaam.Location = New System.Drawing.Point(113, 115)
        Me.lblPensioenfondsNaam.Name = "lblPensioenfondsNaam"
        Me.lblPensioenfondsNaam.Size = New System.Drawing.Size(112, 20)
        Me.lblPensioenfondsNaam.TabIndex = 32
        '
        'txtPensioenfondsNaam
        '
        Me.txtPensioenfondsNaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPensioenfondsNaam.Enabled = False
        Me.txtPensioenfondsNaam.Location = New System.Drawing.Point(231, 115)
        Me.txtPensioenfondsNaam.Name = "txtPensioenfondsNaam"
        Me.txtPensioenfondsNaam.Size = New System.Drawing.Size(315, 20)
        Me.txtPensioenfondsNaam.TabIndex = 30
        Me.txtPensioenfondsNaam.WordWrap = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Chocolate
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(113, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 20)
        Me.Label10.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Chocolate
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(113, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 20)
        Me.Label12.TabIndex = 35
        '
        'txtPensWGPerc
        '
        Me.txtPensWGPerc.AllowPromptAsInput = False
        Me.txtPensWGPerc.BeepOnError = True
        Me.txtPensWGPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPensWGPerc.Enabled = False
        Me.txtPensWGPerc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txtPensWGPerc.Location = New System.Drawing.Point(231, 144)
        Me.txtPensWGPerc.Mask = "9.9"
        Me.txtPensWGPerc.Name = "txtPensWGPerc"
        Me.txtPensWGPerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPensWGPerc.ResetOnPrompt = False
        Me.txtPensWGPerc.Size = New System.Drawing.Size(23, 20)
        Me.txtPensWGPerc.TabIndex = 31
        Me.txtPensWGPerc.Text = "00"
        Me.txtPensWGPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPensWNPerc
        '
        Me.txtPensWNPerc.AllowPromptAsInput = False
        Me.txtPensWNPerc.BeepOnError = True
        Me.txtPensWNPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPensWNPerc.Enabled = False
        Me.txtPensWNPerc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txtPensWNPerc.Location = New System.Drawing.Point(231, 174)
        Me.txtPensWNPerc.Mask = "9.9"
        Me.txtPensWNPerc.Name = "txtPensWNPerc"
        Me.txtPensWNPerc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPensWNPerc.ResetOnPrompt = False
        Me.txtPensWNPerc.Size = New System.Drawing.Size(23, 20)
        Me.txtPensWNPerc.TabIndex = 32
        Me.txtPensWNPerc.Text = "00"
        Me.txtPensWNPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBoxSpaarfonds
        '
        Me.CheckBoxSpaarfonds.AutoSize = True
        Me.CheckBoxSpaarfonds.Enabled = False
        Me.CheckBoxSpaarfonds.Location = New System.Drawing.Point(358, 45)
        Me.CheckBoxSpaarfonds.Name = "CheckBoxSpaarfonds"
        Me.CheckBoxSpaarfonds.Size = New System.Drawing.Size(95, 17)
        Me.CheckBoxSpaarfonds.TabIndex = 38
        Me.CheckBoxSpaarfonds.TabStop = False
        Me.CheckBoxSpaarfonds.Text = "Vast Bedrag"
        Me.CheckBoxSpaarfonds.UseVisualStyleBackColor = True
        '
        'CheckBoxPensioen
        '
        Me.CheckBoxPensioen.AutoSize = True
        Me.CheckBoxPensioen.Enabled = False
        Me.CheckBoxPensioen.Location = New System.Drawing.Point(358, 147)
        Me.CheckBoxPensioen.Name = "CheckBoxPensioen"
        Me.CheckBoxPensioen.Size = New System.Drawing.Size(95, 17)
        Me.CheckBoxPensioen.TabIndex = 39
        Me.CheckBoxPensioen.TabStop = False
        Me.CheckBoxPensioen.Text = "Vast Bedrag"
        Me.CheckBoxPensioen.UseVisualStyleBackColor = True
        '
        'txtVastBedragSpF
        '
        Me.txtVastBedragSpF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVastBedragSpF.Enabled = False
        Me.txtVastBedragSpF.Location = New System.Drawing.Point(492, 45)
        Me.txtVastBedragSpF.Name = "txtVastBedragSpF"
        Me.txtVastBedragSpF.Size = New System.Drawing.Size(54, 20)
        Me.txtVastBedragSpF.TabIndex = 52
        Me.txtVastBedragSpF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVastBedragPF
        '
        Me.txtVastBedragPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVastBedragPF.Enabled = False
        Me.txtVastBedragPF.Location = New System.Drawing.Point(492, 146)
        Me.txtVastBedragPF.Name = "txtVastBedragPF"
        Me.txtVastBedragPF.Size = New System.Drawing.Size(54, 20)
        Me.txtVastBedragPF.TabIndex = 53
        Me.txtVastBedragPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAddDD
        '
        Me.btnAddDD.Location = New System.Drawing.Point(877, 631)
        Me.btnAddDD.Name = "btnAddDD"
        Me.btnAddDD.Size = New System.Drawing.Size(75, 23)
        Me.btnAddDD.TabIndex = 62
        Me.btnAddDD.Text = "Button4"
        Me.btnAddDD.UseVisualStyleBackColor = True
        '
        'txtHourWage
        '
        Me.txtHourWage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHourWage.Location = New System.Drawing.Point(862, 36)
        Me.txtHourWage.Name = "txtHourWage"
        Me.txtHourWage.Size = New System.Drawing.Size(89, 13)
        Me.txtHourWage.TabIndex = 63
        Me.txtHourWage.TabStop = False
        Me.txtHourWage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(968, 702)
        Me.Controls.Add(Me.txtHourWage)
        Me.Controls.Add(Me.btnAddDD)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.pctLogo)
        Me.Controls.Add(Me.DataGridMain)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEmployee"
        Me.Text = "Employee Data"
        CType(Me.DataGridMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPTABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB06.ResumeLayout(False)
        CType(Me.DGBerekening, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB05.ResumeLayout(False)
        CType(Me.DGVergoedingenB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVergoedingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB04.ResumeLayout(False)
        Me.TAB03.ResumeLayout(False)
        Me.TAB03.PerformLayout()
        Me.TAB02.ResumeLayout(False)
        Me.TAB02.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB01.ResumeLayout(False)
        Me.TAB01.PerformLayout()
        CType(Me.txtEmployeeStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpPictBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TAB07.ResumeLayout(False)
        CType(Me.DGEmpDeductions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EMPCOMPIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPFIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPLASTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPBIRTHDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPDEPARTMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPSTARTDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPENDDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPSALARYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPSTATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPPOSITIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPSEXDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPCEDULANRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPDPWDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPUPWDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPUURLOONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecordNrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPNRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridMain As System.Windows.Forms.DataGridView
    Friend WithEvents pctLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnRetrieve As System.Windows.Forms.Button
    Friend WithEvents ToolStripUserName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel_COUNTRY As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents EMPTABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewSalforceDataSet As SalForce.NewSalforceDataSet
    Friend WithEvents EMPTABLETableAdapter As SalForce.NewSalforceDataSetTableAdapters.EMPTABLETableAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents LineShape2 As PowerPacks.LineShape
    Private WithEvents LineShape10 As PowerPacks.LineShape
    Friend WithEvents TAB06 As TabPage
    Friend WithEvents DGBerekening As DataGridView
    Friend WithEvents TAB05 As TabPage
    Friend WithEvents DGVergoedingenB As DataGridView
    Friend WithEvents DGVergoedingen As DataGridView
    Friend WithEvents TAB04 As TabPage
    Friend WithEvents txtEmpNotities As RichTextBox
    Friend WithEvents TAB03 As TabPage
    Friend WithEvents txtZOG_PERC As MaskedTextBox
    Friend WithEvents txtZOGPREMIE As TextBox
    Friend WithEvents txtBVZ_Amount As TextBox
    Friend WithEvents txtOnkostenVergoeding As TextBox
    Friend WithEvents txtTotalIncome As TextBox
    Friend WithEvents txtValuta As TextBox
    Friend WithEvents txtZV_Amount As TextBox
    Friend WithEvents txtAOV_AWW As TextBox
    Friend WithEvents txtAVBZ_AMOUNT As TextBox
    Friend WithEvents txtPeriode As TextBox
    Friend WithEvents txtUurloon As TextBox
    Friend WithEvents txtAnderloon As TextBox
    Friend WithEvents txtPensioenfonds As TextBox
    Friend WithEvents txtAutoZaak As TextBox
    Friend WithEvents txtKindToeslag As TextBox
    Friend WithEvents txtAlleenVerdienerT As TextBox
    Friend WithEvents txtOuderenToeslag As TextBox
    Friend WithEvents txtBesInsp As TextBox
    Friend WithEvents TXTSALARY As TextBox
    Friend WithEvents txtZV_PERC As MaskedTextBox
    Friend WithEvents lblTotalIncome As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chkZV As CheckBox
    Friend WithEvents lblPeriod As Label
    Friend WithEvents cmbPeriod As ComboBox
    Friend WithEvents lblUurloon As Label
    Friend WithEvents txtDagenPerWeek As MaskedTextBox
    Friend WithEvents lblDagenPerweek As Label
    Friend WithEvents txtUrenPerDag As MaskedTextBox
    Friend WithEvents lblUrenPerweek As Label
    Friend WithEvents txtLeeftijd1jan As MaskedTextBox
    Friend WithEvents lblAgeOnfirstjan As Label
    Friend WithEvents lblBelPlicht As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblPensioen As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbvaluta As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBVZ_PERC As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOudtoeslag As Label
    Friend WithEvents lblBeslInsp As Label
    Friend WithEvents txtAVBZ_PERC As MaskedTextBox
    Friend WithEvents txtAOVAWW_PERC As MaskedTextBox
    Friend WithEvents lblZV As Label
    Friend WithEvents lblAVBZ As Label
    Friend WithEvents lblAOVAWW As Label
    Private WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Private WithEvents LineShape9 As PowerPacks.LineShape
    Private WithEvents LineShape8 As PowerPacks.LineShape
    Private WithEvents LineShape7 As PowerPacks.LineShape
    Private WithEvents LineShape6 As PowerPacks.LineShape
    Private WithEvents LineShape5 As PowerPacks.LineShape
    Private WithEvents LineShape4 As PowerPacks.LineShape
    Private WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents TAB02 As TabPage
    Friend WithEvents txtPartnerBelInkomen As TextBox
    Friend WithEvents TotalKtoeslag As TextBox
    Friend WithEvents txtPartnerBirthDate As TextBox
    Friend WithEvents txtChildrowcount As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtPartnerEmployer As TextBox
    Friend WithEvents txtPartnerMidname As TextBox
    Friend WithEvents txtPartnerLastname As TextBox
    Friend WithEvents txtPartnerFirstname As TextBox
    Friend WithEvents lblBelInkomen As Label
    Friend WithEvents DatePickerPartnerBirthdate As DateTimePicker
    Friend WithEvents lblSpouseBirthDate As Label
    Friend WithEvents lblSpouseEmployer As Label
    Friend WithEvents lblSpouseMiddenName As Label
    Friend WithEvents lblPartnerLastName As Label
    Friend WithEvents lblspouseName As Label
    Friend WithEvents TAB01 As TabPage
    Friend WithEvents chk As CheckBox
    Friend WithEvents cmbIsland As ComboBox
    Friend WithEvents lblIsland As Label
    Friend WithEvents txtDepartmentNr As TextBox
    Friend WithEvents txtCompanyNr As TextBox
    Friend WithEvents txtBirthdate As TextBox
    Friend WithEvents txtDateEnd As TextBox
    Friend WithEvents txtDateBegin As TextBox
    Friend WithEvents txtEmployeeEmail2 As TextBox
    Friend WithEvents txtEmployeeEmail1 As TextBox
    Friend WithEvents txtEmployeefunction As TextBox
    Friend WithEvents txtemployeeAddress As TextBox
    Friend WithEvents txtemployeeLastName As TextBox
    Friend WithEvents txtEmployeeFirstName As TextBox
    Friend WithEvents cmbSelectDepartment As ComboBox
    Friend WithEvents cmbSelectCompany As ComboBox
    Friend WithEvents calEmployeeDateBegin As DateTimePicker
    Friend WithEvents txtEmployeeMobile As MaskedTextBox
    Friend WithEvents lblEmployeeCel As Label
    Friend WithEvents txtEmployeeHomePhone As MaskedTextBox
    Friend WithEvents lblEmployeeHomePhone As Label
    Friend WithEvents lblEmployeeEmial2 As Label
    Friend WithEvents lblEmployeeMail As Label
    Friend WithEvents txtEmployeeVRW As CheckBox
    Friend WithEvents txtEmployeeMAN As CheckBox
    Friend WithEvents lblEmployeeSex As Label
    Friend WithEvents txtEmployeeStatus As NumericUpDown
    Friend WithEvents txtEmployeeNr As MaskedTextBox
    Friend WithEvents lblemployeeNr As Label
    Friend WithEvents lblEmployeePicture As Label
    Friend WithEvents txtEmployeePicture As MaskedTextBox
    Friend WithEvents EmpPictBox As PictureBox
    Friend WithEvents lblEmployeeFunction As Label
    Friend WithEvents CalendarPickerBirthdate As DateTimePicker
    Friend WithEvents lblEmployeeAdres As Label
    Friend WithEvents lblEmployeeStatus As Label
    Friend WithEvents lblEmployeeDepartment As Label
    Friend WithEvents calEmployeeDateEnd As DateTimePicker
    Friend WithEvents lblEmployeeEnddate As Label
    Friend WithEvents lblEmployeestartdate As Label
    Friend WithEvents lblEmployeeGebDatum As Label
    Friend WithEvents txtEmployeeCedulaNr As MaskedTextBox
    Friend WithEvents lblEmployeecedulaNr As Label
    Friend WithEvents lblEmployeeLastname As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblEmployeeBedrijf As Label
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TAB07 As TabPage
    Friend WithEvents lblSpaarFondsNaam As Label
    Friend WithEvents txtSpaarFondsNaam As TextBox
    Friend WithEvents lblWerkgeversBijdrage As Label
    Friend WithEvents txtSpaarFondsWGPerc As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSpaarFondsWNPerc As MaskedTextBox
    Friend WithEvents lblPensioenfondsNaam As Label
    Friend WithEvents txtPensioenfondsNaam As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPensWGPerc As MaskedTextBox
    Friend WithEvents txtPensWNPerc As MaskedTextBox
    Friend WithEvents CheckBoxSpaarfonds As CheckBox
    Friend WithEvents CheckBoxPensioen As CheckBox
    Friend WithEvents txtVastBedragSpF As TextBox
    Friend WithEvents txtVastBedragPF As TextBox
    Friend WithEvents DGEmpDeductions As DataGridView
    Friend WithEvents btnAddDD As Button
    Friend WithEvents cmbCompanySelection As ToolStripDropDownButton
    Friend WithEvents txtHourWage As TextBox
    Friend WithEvents lblVerwervingsKosten As Label
    Friend WithEvents txtVerwervingskosten As TextBox
End Class