Imports System
Imports System.Threading.Tasks
Imports System.IO
Imports AxAXVLC.AxVLCPlugin2
'Imports System.IO.FileStream
Imports System.Reflection
Imports System.Drawing.Printing.PrintDocument
Imports System.Drawing.Printing.PaperSize
Imports System.Windows
Public Class SHOWWAY
    Dim WithEvents Printdoc As New Printing.PrintDocument
    Private TmpFiles As New List(Of String)
    Public Filepath As String
    Dim filp
    Sub PlayVideo()
        PATHVIEW.BaseURL = Filepath
        PATHVIEW.playlist.play()
    End Sub
    Private Sub FACILITY_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim a As Integer = Screen.PrimaryScreen.Bounds.Top
        Dim b As Integer = Screen.PrimaryScreen.Bounds.Left
        Me.Width = x
        Me.Height = y
        Me.Top = a
        Me.Left = b
    End Sub
    Private Sub PLAYVID_Load(sender As Object, e As EventArgs) Handles Me.Load
        'classrooms first floor-----------------------------------------------
        If MAIN.file_id = 1 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE105.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._1a
            Picmap.Image = My.Resources._1
        End If
        If MAIN.file_id = 2 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE106.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._2a
            Picmap.Image = My.Resources._2
        End If
        If MAIN.file_id = 3 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE107.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._3a
            Picmap.Image = My.Resources._3
        End If
        If MAIN.file_id = 4 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE108.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._4a
            Picmap.Image = My.Resources._4
        End If
        If MAIN.file_id = 5 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE109.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._5a
            Picmap.Image = My.Resources._5
        End If
        If MAIN.file_id = 6 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE110.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._6a
            Picmap.Image = My.Resources._6
        End If
        If MAIN.file_id = 7 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE111.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._7a
            Picmap.Image = My.Resources._7
        End If
        If MAIN.file_id = 8 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE112.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._8a
            Picmap.Image = My.Resources._8
        End If
        If MAIN.file_id = 9 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE113.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._9a
            Picmap.Image = My.Resources._9
        End If
        If MAIN.file_id = 10 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE114.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._10a
            Picmap.Image = My.Resources._10
        End If
        If MAIN.file_id = 11 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE115.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._11a
            Picmap.Image = My.Resources._11
        End If
        If MAIN.file_id = 12 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE116.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._12a
            Picmap.Image = My.Resources._12
        End If
        If MAIN.file_id = 13 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE117.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._13a
            Picmap.Image = My.Resources._13
        End If
        If MAIN.file_id = 14 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE118.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._14a
            Picmap.Image = My.Resources._14
        End If
        If MAIN.file_id = 15 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE119.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._15a
            Picmap.Image = My.Resources._15
        End If
        If MAIN.file_id = 16 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE120.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._16a
            Picmap.Image = My.Resources._16
        End If
        If MAIN.file_id = 17 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE121.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._17a
            Picmap.Image = My.Resources._17
        End If
        If MAIN.file_id = 19 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE122.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._19a
            Picmap.Image = My.Resources._19
        End If
        If MAIN.file_id = 18 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE123.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._18a
            Picmap.Image = My.Resources._18
        End If
        '---------------------------------------------------------
        'Other Facilities 1st-------------------------------------
        If MAIN.file_id = 20 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE103.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._20a
            Picmap.Image = My.Resources._20
        End If
        If MAIN.file_id = 21 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE102.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._21a
            Picmap.Image = My.Resources._21
        End If
        If MAIN.file_id = 22 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE101.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._22a
            Picmap.Image = My.Resources._22
        End If
        '---------------------------------------------------------
        'classroom 2nd floor--------------------------------------
        If MAIN.file_id = 23 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE204.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._23b
            Picmap.Image = My.Resources._23
        End If
        If MAIN.file_id = 24 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE205.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._24b
            Picmap.Image = My.Resources._24
        End If
        If MAIN.file_id = 25 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE206.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._25b
            Picmap.Image = My.Resources._25
        End If
        If MAIN.file_id = 26 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE207.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._26b
            Picmap.Image = My.Resources._26
        End If
        If MAIN.file_id = 27 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE208.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._27b
            Picmap.Image = My.Resources._27
        End If
        If MAIN.file_id = 28 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE209.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._28b
            Picmap.Image = My.Resources._28
        End If
        If MAIN.file_id = 29 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE210.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._29b
            Picmap.Image = My.Resources._29
        End If
        If MAIN.file_id = 30 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE211.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._30b
            Picmap.Image = My.Resources._30
        End If
        If MAIN.file_id = 31 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE212.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._31b
            Picmap.Image = My.Resources._31
        End If
        If MAIN.file_id = 32 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE213.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._32b
            Picmap.Image = My.Resources._32
        End If
        If MAIN.file_id = 33 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE214.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._33b
            Picmap.Image = My.Resources._33
        End If
        If MAIN.file_id = 34 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE215.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._34b
            Picmap.Image = My.Resources._34
        End If
        If MAIN.file_id = 35 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE216.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._35b
            Picmap.Image = My.Resources._35
        End If
        If MAIN.file_id = 36 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE217.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._36b
            Picmap.Image = My.Resources._36
        End If
        If MAIN.file_id = 37 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE218.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._37b
            Picmap.Image = My.Resources._37
        End If
        If MAIN.file_id = 38 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE219.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._38b
            Picmap.Image = My.Resources._38
        End If
        If MAIN.file_id = 39 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE220.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._39b
            Picmap.Image = My.Resources._39
        End If
        If MAIN.file_id = 40 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE221.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._40b
            Picmap.Image = My.Resources._40
        End If
        If MAIN.file_id = 41 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE222.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._41b
            Picmap.Image = My.Resources._41
        End If
        If MAIN.file_id = 42 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE223.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._42b
            Picmap.Image = My.Resources._42
        End If
        If MAIN.file_id = 43 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE224.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._43b
            Picmap.Image = My.Resources._43
        End If
        If MAIN.file_id = 44 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE225.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._44b
            Picmap.Image = My.Resources._44
        End If
        If MAIN.file_id = 45 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE226.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._45b
            Picmap.Image = My.Resources._45
        End If
        If MAIN.file_id = 46 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE227.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._46b
            Picmap.Image = My.Resources._46
        End If
        If MAIN.file_id = 47 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE228.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._47b
            Picmap.Image = My.Resources._47
        End If
        If MAIN.file_id = 48 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE229.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._48b
            Picmap.Image = My.Resources._48
        End If
        If MAIN.file_id = 49 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE230.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._49b
            Picmap.Image = My.Resources._49
        End If
        If MAIN.file_id = 50 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE231.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._50b
            Picmap.Image = My.Resources._50
        End If
        '-------------------------------------------------------
        'other facility 2nd floor-------------------------------
        If MAIN.file_id = 51 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BEICT.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._51b
            Picmap.Image = My.Resources._51
        End If
        '-------------------------------------------------------
        'faculty 2nd floor--------------------------------------
        If MAIN.file_id = 52 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE201.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._52b
            Picmap.Image = My.Resources._52
        End If
        If MAIN.file_id = 53 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE202.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._53b
            Picmap.Image = My.Resources._53
        End If
        If MAIN.file_id = 54 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE232.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._54b
            Picmap.Image = My.Resources._54
        End If
        If MAIN.file_id = 55 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE203.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._55b
            Picmap.Image = My.Resources._55
        End If
        '-------------------------------------------------------
        '3rd floor classroom -----------------------------------
        If MAIN.file_id = 56 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE301.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._56c
            Picmap.Image = My.Resources._56
        End If
        If MAIN.file_id = 57 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE302.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._57c
            Picmap.Image = My.Resources._57
        End If
        If MAIN.file_id = 58 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE303.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._58c
            Picmap.Image = My.Resources._58
        End If
        If MAIN.file_id = 59 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE304.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._59c
            Picmap.Image = My.Resources._59
        End If
        If MAIN.file_id = 60 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE305.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._60c
            Picmap.Image = My.Resources._60
        End If
        If MAIN.file_id = 61 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE306.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._61c
            Picmap.Image = My.Resources._61
        End If
        If MAIN.file_id = 62 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE307.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._62c
            Picmap.Image = My.Resources._62
        End If
        If MAIN.file_id = 63 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE308.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._63c
            Picmap.Image = My.Resources._63
        End If
        If MAIN.file_id = 64 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE309.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._64c
            Picmap.Image = My.Resources._64
        End If
        If MAIN.file_id = 65 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE310.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._65c
            Picmap.Image = My.Resources._65
        End If
        If MAIN.file_id = 66 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE311.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._66c
            Picmap.Image = My.Resources._66
        End If
        If MAIN.file_id = 67 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE312.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._67c
            Picmap.Image = My.Resources._67
        End If
        If MAIN.file_id = 68 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE313.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._68c
            Picmap.Image = My.Resources._68
        End If
        If MAIN.file_id = 69 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE314.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._69c
            Picmap.Image = My.Resources._69
        End If
        If MAIN.file_id = 70 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE315.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._70c
            Picmap.Image = My.Resources._70
        End If
        If MAIN.file_id = 71 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE316.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._71c
            Picmap.Image = My.Resources._71
        End If
        If MAIN.file_id = 72 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE317.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._72c
            Picmap.Image = My.Resources._72
        End If
        If MAIN.file_id = 73 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE318.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._73c
            Picmap.Image = My.Resources._73
        End If
        If MAIN.file_id = 74 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE319.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._74c
            Picmap.Image = My.Resources._74
        End If
        If MAIN.file_id = 75 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE320.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._75c
            Picmap.Image = My.Resources._75
        End If
        If MAIN.file_id = 76 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE321.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._76c
            Picmap.Image = My.Resources._76
        End If
        If MAIN.file_id = 77 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE322.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._77c
            Picmap.Image = My.Resources._77
        End If
        If MAIN.file_id = 78 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE323.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._78c
            Picmap.Image = My.Resources._78
        End If
        If MAIN.file_id = 79 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE324.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._79c
        End If
        If MAIN.file_id = 80 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE325.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._80c
            Picmap.Image = My.Resources._80
        End If
        If MAIN.file_id = 81 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE326.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._81c
            Picmap.Image = My.Resources._81
        End If
        If MAIN.file_id = 82 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE327.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._82c
            Picmap.Image = My.Resources._82
        End If
        If MAIN.file_id = 83 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE328.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._83c
            Picmap.Image = My.Resources._83
        End If
        If MAIN.file_id = 84 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE329.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._84c
            Picmap.Image = My.Resources._84
        End If
        If MAIN.file_id = 85 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE330.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._85c
            Picmap.Image = My.Resources._85
        End If
        If MAIN.file_id = 86 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE331.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._86c
            Picmap.Image = My.Resources._86
        End If
        If MAIN.file_id = 87 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE332.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._87c
            Picmap.Image = My.Resources._87
        End If
        If MAIN.file_id = 88 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE333.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._88c
            Picmap.Image = My.Resources._88
        End If
        If MAIN.file_id = 89 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE334.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._89c
            Picmap.Image = My.Resources._89
        End If
        If MAIN.file_id = 90 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE335.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._90c
            Picmap.Image = My.Resources._90
        End If
        If MAIN.file_id = 91 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE336.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._91c
            Picmap.Image = My.Resources._91
        End If
        '-------------------------------------------------------------------------
        '3rd floor faculty -------------------------------------------------------
        If MAIN.file_id = 92 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BE337.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._92c
            Picmap.Image = My.Resources._92
        End If
        '-------------------------------------------------------------------------
        '4th floor -------------------------------------------------------
        If MAIN.file_id = 93 Then
            PATHVIEW.playlist.items.clear()
            PATHVIEW.playlist.add("file:///D:/IOvids/BELIC.mp4")
            PATHVIEW.playlist.play()
            Panelprint.BackgroundImage = My.Resources._93d
            Picmap.Image = My.Resources._93
        End If
        '-------------------------------------------------------------------------
    End Sub
    Private Sub BckD_Click(sender As Object, e As EventArgs) Handles BckD.Click
        MAIN.idl = 0
        Printdoc.Dispose()
        PATHVIEW.playlist.stop()
        MAIN.file_id = 0
        MAIN.Show()
        Me.Close()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PATHVIEW.playlist.stop()
        Dim ran As Integer = 0
        Dim patnm As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop)
        Dim filnm As String = Path.GetFileNameWithoutExtension("Receipt")
        Try
            If Directory.Exists(patnm) And (Not File.Exists(filnm)) Then
                ran = ran + 1
                Printdoc.PrinterSettings.PrintToFile = True
                filnm = Path.Combine(patnm, (filnm) & ran & ".pdf")
                Printdoc.PrinterSettings.PrintFileName = filnm
                Printdoc.PrinterSettings.PrinterName = "Microsoft Print to PDF"
                Printdoc.Print()
                Panel1.Visible = True
            End If
        Catch

        End Try
        Timer1.Start()
    End Sub
    Private Sub Replay_Click(sender As Object, e As EventArgs) Handles Replay.Click
        Printdoc.Dispose()
        PanelVid.Visible = True
        Panelprint.Visible = False
        Panel1.Visible = True
        PATHVIEW.playlist.prev()
    End Sub
    Private Sub PrintRec_Click(sender As Object, e As EventArgs) Handles PrintRec.Click
        PATHVIEW.playlist.stop()
        PanelVid.Visible = False
        Panelprint.Visible = True
        Panelbig.Visible = True
        Panel1.Visible = False
    End Sub
    Private Sub PrintDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Printdoc.PrintPage
        Dim dm As New Bitmap(Me.Panelsmall.Width, Me.Panelsmall.Height)

        Panelsmall.DrawToBitmap(dm, New Rectangle(0, 0, Me.Panelsmall.Width, Me.Panelsmall.Height))
        e.Graphics.DrawImage(dm, 0, 0)
        e.Graphics.DrawRectangle(Pens.Black, 0, 0, 224, Me.Panelsmall.Height)

        Dim aPS As New PageSetupDialog
        aPS.Document = Printdoc
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panelbig.Visible = False
        Timer1.Stop()
    End Sub
End Class