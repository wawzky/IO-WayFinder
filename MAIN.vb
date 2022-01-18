Imports System
Imports System.Threading.Tasks
Imports System.IO
Imports System.IO.Path
Imports System.IO.FileStream
Imports System.Reflection
Imports System.Drawing.Printing.PrintDocument
Imports System.Drawing.Printing.PaperSize
Imports System.Windows

Public Class MAIN
    Public file_id As Integer = 0
    Public idl As Integer
    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        idol.Start()
        PanelLOGO.Visible = True
        Dim myTempFile As String = Combine(GetTempPath, "main.pdf")
        My.Computer.FileSystem.WriteAllBytes(myTempFile, My.Resources.main, False)
        AxAcroPDF1.src = myTempFile
        AxAcroPDF1.setShowToolbar(False)
        AxAcroPDF1.setShowScrollbars(False)
        AxAcroPDF1.setLayoutMode("DontCare")
        AxAcroPDF1.setPageMode("none")
        AxAcroPDF1.setView("fitB")
    End Sub
    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        idl = 0
        If PanelLOGO.Visible = True Then
            PanelLOGO.Visible = False
            PanelLOGO.BringToFront()
        ElseIf PanelLOGO.Visible = False Then
            PanelView.Visible = True
            PanelLOGO.Visible = True
        End If
    End Sub
    Private Sub tap_Click(sender As Object, e As EventArgs) Handles tap.Click
        idl = 0
        If PanelLOGO.Visible = True Then
            PanelLOGO.SendToBack()
            PanelLOGO.Visible = False
        ElseIf PanelLOGO.Visible = False Then
            PanelView.Visible = True
            PanelLOGO.Visible = True
            PanelLOGO.BringToFront()
        End If
    End Sub
    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click
        idl = 0
        If PanelLOGO.Visible = True Then
            PanelLOGO.Visible = False
        ElseIf PanelLOGO.Visible = False Then
            PanelView.Visible = True
            PanelLOGO.Visible = True
        End If
    End Sub

    Private Sub MAIN_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub ROOM_Click(sender As Object, e As EventArgs) Handles ROOM.Click
        idl = 0
        PanelMain.Visible = False
        PanelRooms.Visible = True
    End Sub

    Private Sub FACULTIES_Click(sender As Object, e As EventArgs) Handles FACULTIES.Click
        idl = 0
        PanelMain.Visible = False
        PanelFaculty.Visible = True
    End Sub

    Private Sub FACILITIES_Click(sender As Object, e As EventArgs) Handles FACILITIES.Click
        idl = 0
        PanelMain.Visible = False
        PanelFacility.Visible = True
    End Sub

    Private Sub BckA_Click(sender As Object, e As EventArgs) Handles BckA.Click
        idl = 0
        PanelLOGO.Visible = False
        PanelRooms.Visible = False
        PanelMain.Visible = True
    End Sub

    Private Sub BckB_Click(sender As Object, e As EventArgs) Handles BckB.Click
        idl = 0
        PanelLOGO.Visible = False
        PanelFaculty.Visible = False
        PanelMain.Visible = True
    End Sub

    Private Sub BckC_Click(sender As Object, e As EventArgs) Handles BckC.Click
        idl = 0
        PanelLOGO.Visible = False
        PanelFacility.Visible = False
        PanelMain.Visible = True
    End Sub
    'CR---------------------------------------------------------------------------------------------------------------
    Private Sub CRooms_Click(sender As Object, e As EventArgs) Handles CRooms.Click
        If chooseM.Checked = True Then
            SHOWWAY.Show()
            Me.Hide()
            SHOWWAY.PATHVIEW.playlist.items.clear()
            SHOWWAY.PATHVIEW.playlist.add("file:///D:/IOvids/CR1M.mp4")
            SHOWWAY.PATHVIEW.playlist.play()
            SHOWWAY.Panelprint.BackgroundImage = My.Resources.cm
            SHOWWAY.Picmap.Image = My.Resources.cm1
        ElseIf chooseW.Checked = True Then
            SHOWWAY.Show()
            Me.Hide()
            SHOWWAY.PATHVIEW.playlist.items.clear()
            SHOWWAY.PATHVIEW.playlist.add("file:///D:/IOvids/CR1W.mp4")
            SHOWWAY.PATHVIEW.playlist.play()
            SHOWWAY.Panelprint.BackgroundImage = My.Resources.cw
            SHOWWAY.Picmap.Image = My.Resources.cw1
        End If
    End Sub
    '------------------------------------------------------------------------------------------------------------------
    'Classroom 1st floor-----------------------------------------------------------------------------------------------
    Private Sub Phys_Lab1_Click(sender As Object, e As EventArgs) Handles Phys_Lab1.Click
        file_id = 1
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Phys_Lab2_Click(sender As Object, e As EventArgs) Handles Phys_Lab2.Click
        file_id = 2
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ER_Lab_Click(sender As Object, e As EventArgs) Handles ER_Lab.Click
        file_id = 3
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Soil_Mech_Con_MTest_Surv_Click(sender As Object, e As EventArgs) Handles Soil_Mech_Con_MTest_Surv.Click
        file_id = 4
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub BioLab_Click(sender As Object, e As EventArgs) Handles BioLab.Click
        file_id = 5
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Ref_Aircon_Lab_Click(sender As Object, e As EventArgs) Handles Ref_Aircon_Lab.Click
        file_id = 6
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Machine_Wrkshp_Click(sender As Object, e As EventArgs) Handles Machine_Wrkshp.Click
        file_id = 7
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Power_Plant_Click(sender As Object, e As EventArgs) Handles Power_Plant.Click
        file_id = 8
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Hydraulics_Lab_Click(sender As Object, e As EventArgs) Handles Hydraulics_Lab.Click
        file_id = 9
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Metal_Workshop_Click(sender As Object, e As EventArgs) Handles Metal_Workshop.Click
        file_id = 10
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Chem_Lab1_Click(sender As Object, e As EventArgs) Handles Chem_Lab1.Click
        file_id = 11
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Chem_Lab2_Click(sender As Object, e As EventArgs) Handles Chem_Lab2.Click
        file_id = 12
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Chem_Lab3_Click(sender As Object, e As EventArgs) Handles Chem_Lab3.Click
        file_id = 13
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Chem_Lab4_Click(sender As Object, e As EventArgs) Handles Chem_Lab4.Click
        file_id = 14
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Chem_Lab5_Click(sender As Object, e As EventArgs) Handles Chem_Lab5.Click
        file_id = 15
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Forensic_Lab_Click(sender As Object, e As EventArgs) Handles Forensic_Lab.Click
        file_id = 16
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub Chem_Engr_Lab_Click(sender As Object, e As EventArgs) Handles Chem_Engr_Lab.Click
        file_id = 17
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub EE_Lab1_Click(sender As Object, e As EventArgs) Handles EE_Lab1.Click
        file_id = 19
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub EE_Lab2_Click(sender As Object, e As EventArgs) Handles EE_Lab2.Click
        file_id = 18
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------------
    'Other Facility 1st Floor-----------------------------------------------------------------------------------------------------
    Private Sub Cashier_Click(sender As Object, e As EventArgs) Handles Cashier.Click
        file_id = 20
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub SAO_Click(sender As Object, e As EventArgs) Handles SAO.Click
        file_id = 21
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub RAC_Click(sender As Object, e As EventArgs) Handles RAC.Click
        file_id = 22
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------
    'classroom 2nd floor----------------------------------------------------------------------------------------------------------
    Private Sub ClassRm1_Click(sender As Object, e As EventArgs) Handles ClassRm1.Click
        file_id = 23
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm2_Click(sender As Object, e As EventArgs) Handles ClassRm2.Click
        file_id = 24
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm3_Click(sender As Object, e As EventArgs) Handles ClassRm3.Click
        file_id = 25
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm4_Click(sender As Object, e As EventArgs) Handles ClassRm4.Click
        file_id = 26
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm5_Click(sender As Object, e As EventArgs) Handles ClassRm5.Click
        file_id = 27
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm6_Click(sender As Object, e As EventArgs) Handles ClassRm6.Click
        file_id = 28
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm7_Click(sender As Object, e As EventArgs) Handles ClassRm7.Click
        file_id = 29
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm8_Click(sender As Object, e As EventArgs) Handles ClassRm8.Click
        file_id = 30
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub AutoCAD_Lab_Click(sender As Object, e As EventArgs) Handles AutoCAD_Lab.Click
        file_id = 31
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ECE_Lab1_Click(sender As Object, e As EventArgs) Handles ECE_Lab1.Click
        file_id = 32
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub CpE_Lab1_Click(sender As Object, e As EventArgs) Handles CpE_Lab1.Click
        file_id = 33
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ECE_Lab2_Click(sender As Object, e As EventArgs) Handles ECE_Lab2.Click
        file_id = 34
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub CpE_Lab2_Click(sender As Object, e As EventArgs) Handles CpE_Lab2.Click
        file_id = 35
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub CpE_Lab3_Click(sender As Object, e As EventArgs) Handles CpE_Lab3.Click
        file_id = 36
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm9_Click(sender As Object, e As EventArgs) Handles ClassRm9.Click
        file_id = 37
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm10_Click(sender As Object, e As EventArgs) Handles ClassRm10.Click
        file_id = 38
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm11_Click(sender As Object, e As EventArgs) Handles ClassRm11.Click
        file_id = 39
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm12_Click(sender As Object, e As EventArgs) Handles ClassRm12.Click
        file_id = 40
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm13_Click(sender As Object, e As EventArgs) Handles ClassRm13.Click
        file_id = 41
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm14_Click(sender As Object, e As EventArgs) Handles ClassRm14.Click
        file_id = 42
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm15_Click(sender As Object, e As EventArgs) Handles ClassRm15.Click
        file_id = 43
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm16_Click(sender As Object, e As EventArgs) Handles ClassRm16.Click
        file_id = 44
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm17_Click(sender As Object, e As EventArgs) Handles ClassRm17.Click
        file_id = 45
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm18_Click(sender As Object, e As EventArgs) Handles ClassRm18.Click
        file_id = 46
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm19_Click(sender As Object, e As EventArgs) Handles ClassRm19.Click
        file_id = 47
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm20_Click(sender As Object, e As EventArgs) Handles ClassRm20.Click
        file_id = 48
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm21_Click(sender As Object, e As EventArgs) Handles ClassRm21.Click
        file_id = 49
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub ClassRm22_Click(sender As Object, e As EventArgs) Handles ClassRm22.Click
        file_id = 50
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    '-------------------------------------------------------------------------------------------
    'other facility 2nd floor-------------------------------------------------------------------
    Private Sub ICT_Click(sender As Object, e As EventArgs) Handles ICT.Click
        file_id = 51
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    '-------------------------------------------------------------------------------------------
    'faculty 2nd floor--------------------------------------------------------------------------
    Private Sub POffice_Click(sender As Object, e As EventArgs) Handles POffice.Click
        file_id = 52
        SHOWWAY.Show()
        Me.Hide()
    End Sub

    Private Sub AcPS_Click(sender As Object, e As EventArgs) Handles AcPS.Click
        file_id = 53
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub CEEFac_Click(sender As Object, e As EventArgs) Handles CEEFac.Click
        file_id = 54
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub Doffice_Click(sender As Object, e As EventArgs) Handles Doffice.Click
        file_id = 55
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    '-------------------------------------------------------------------------------------------
    '3rdfloor classrooms------------------------------------------------------------------------
    Private Sub ClassRm23_Click(sender As Object, e As EventArgs) Handles ClassRm23.Click
        file_id = 56
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm24_Click(sender As Object, e As EventArgs) Handles ClassRm24.Click
        file_id = 57
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm25_Click(sender As Object, e As EventArgs) Handles ClassRm25.Click
        file_id = 58
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm26_Click(sender As Object, e As EventArgs) Handles ClassRm26.Click
        file_id = 59
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm27_Click(sender As Object, e As EventArgs) Handles ClassRm27.Click
        file_id = 60
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm28_Click(sender As Object, e As EventArgs) Handles ClassRm28.Click
        file_id = 61
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm29_Click(sender As Object, e As EventArgs) Handles ClassRm29.Click
        file_id = 62
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm30_Click(sender As Object, e As EventArgs) Handles ClassRm30.Click
        file_id = 63
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm31_Click(sender As Object, e As EventArgs) Handles ClassRm31.Click
        file_id = 64
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm32_Click(sender As Object, e As EventArgs) Handles ClassRm32.Click
        file_id = 65
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm33_Click(sender As Object, e As EventArgs) Handles ClassRm33.Click
        file_id = 66
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm34_Click(sender As Object, e As EventArgs) Handles ClassRm34.Click
        file_id = 67
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm35_Click(sender As Object, e As EventArgs) Handles ClassRm35.Click
        file_id = 68
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm36_Click(sender As Object, e As EventArgs) Handles ClassRm36.Click
        file_id = 69
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm37_Click(sender As Object, e As EventArgs) Handles ClassRm37.Click
        file_id = 70
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm38_Click(sender As Object, e As EventArgs) Handles ClassRm38.Click
        file_id = 71
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub DynEd_Click(sender As Object, e As EventArgs) Handles DynEd.Click
        file_id = 72
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm39_Click(sender As Object, e As EventArgs) Handles ClassRm39.Click
        file_id = 73
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub Acc_Lab_Click(sender As Object, e As EventArgs) Handles Acc_Lab.Click
        file_id = 74
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub VacRoom_Click(sender As Object, e As EventArgs) Handles VacRoom.Click
        file_id = 75
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm40_Click(sender As Object, e As EventArgs) Handles ClassRm40.Click
        file_id = 76
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm41_Click(sender As Object, e As EventArgs) Handles ClassRm41.Click
        file_id = 77
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm42_Click(sender As Object, e As EventArgs) Handles ClassRm42.Click
        file_id = 78
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm43_Click(sender As Object, e As EventArgs) Handles ClassRm43.Click
        file_id = 79
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm44_Click(sender As Object, e As EventArgs) Handles ClassRm44.Click
        file_id = 80
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm45_Click(sender As Object, e As EventArgs) Handles ClassRm45.Click
        file_id = 81
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub DiscussRm_Click(sender As Object, e As EventArgs) Handles DiscussRm.Click
        file_id = 82
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm46_Click(sender As Object, e As EventArgs) Handles ClassRm46.Click
        file_id = 83
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm47_Click(sender As Object, e As EventArgs) Handles ClassRm47.Click
        file_id = 84
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm48_Click(sender As Object, e As EventArgs) Handles ClassRm48.Click
        file_id = 85
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm49_Click(sender As Object, e As EventArgs) Handles ClassRm49.Click
        file_id = 86
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm50_Click(sender As Object, e As EventArgs) Handles ClassRm50.Click
        file_id = 87
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm51_Click(sender As Object, e As EventArgs) Handles ClassRm51.Click
        file_id = 88
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm52_Click(sender As Object, e As EventArgs) Handles ClassRm52.Click
        file_id = 89
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm53_Click(sender As Object, e As EventArgs) Handles ClassRm53.Click
        file_id = 90
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    Private Sub ClassRm54_Click(sender As Object, e As EventArgs) Handles ClassRm54.Click
        file_id = 91
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    '-------------------------------------------------------------------------------------------
    '3rd faculty--------------------------------------------------------------------------------
    Private Sub CAEFac_Click(sender As Object, e As EventArgs) Handles CAEFac.Click
        file_id = 92
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    '-------------------------------------------------------------------------------------------
    '4th floor---------------------------------------------------------------------------------
    Private Sub LIC4th_Click(sender As Object, e As EventArgs) Handles LIC4th.Click
        file_id = 93
        SHOWWAY.Show()
        Me.Hide()
    End Sub
    '------------------------------------------------------------------------------------------
    Private Sub idol_Tick(sender As Object, e As EventArgs) Handles idol.Tick
        idl += Integer.Parse(idol.Interval)
        If idl >= 60000 Then
            PanelLOGO.Visible = True
            PanelLOGO.BringToFront()
        ElseIf idl = 0 Then
            PanelLOGO.Visible = False

        End If
    End Sub
End Class