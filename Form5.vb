Imports System.IO
Imports System.Drawing

Public Class Form5

    Dim roomNames As New List(Of String)
    Dim roomImagePath As String = "C:\Users\user\lakbay map"

    Private Sub RoomSearchApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoomNames()
        SetupAutocomplete()
    End Sub

    Private Sub LoadRoomNames()
        roomNames.AddRange({"Finance Office", "Supreme Student Council", "Office of Student Affairs", "NTSP Paraya Office",
                           "Purchasing Office", "Graduate School Office", "General Service Office", "Room 101", "Registrar Office",
                           "Accounting Office", "Management System Office", "Human Resource Office", "Room 102", "Room 103", "Room 104",
                           "Room 105", "Room 201", "Room 202", "Room 203", "Room 204", "Room 205", "College of Accountancy", "College of Arts",
                           "College of Education", "College of Psychology", "College of Business Administration", "College of Computer Studies",
                           "Audio Visual Room", "College of Health Sciences", "Guidance Office", "Health and Wellness Clinic", "School Canteen",
                           "Center for Research and Development Office", "St.Carlo Acutis Chapel", "Huddle Room", "Scientia Hall 1", "Scientia Hall 2",
                           "Science Laboratories", "Psychology Laboratory", "Arete Hall", "College Library", "Office of VP for Academic Affairs",
                           "Lecture Room", "Sandbox", "EdTech", "Nexus", "Inspire Robotics", "Server Room", "Lecture Room AM 103",
                           "Lecture Room AM 102", "Lecture Room AM 101", "Lecture Room AM 105", "Lecture Room AM 106", "Simulation Room", "Credo", "Utility Room", "Discussion Room",
                           "Anatomy", "Physics", "Microbiology", "Chemistry", "Ampheather", "Skills Lab", "Student Park"})

        If cbRoom IsNot Nothing Then
            cbRoom.Items.AddRange(roomNames.ToArray())
        End If
    End Sub

    Private Sub SetupAutocomplete()
        If txtSearch IsNot Nothing Then
            Dim autoComplete As New AutoCompleteStringCollection()
            autoComplete.AddRange(roomNames.ToArray())

            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtSearch.AutoCompleteCustomSource = autoComplete
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchRoom()
        End If
    End Sub

    Private Sub cbRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRoom.SelectedIndexChanged
        If cbRoom.SelectedItem IsNot Nothing Then
            Dim selectedRoom As String = cbRoom.SelectedItem.ToString()
            DisplayRoomImage(selectedRoom)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        SearchRoom()
    End Sub

    Private Sub SearchRoom()
        Dim roomName As String = txtSearch.Text.Trim()
        If String.IsNullOrWhiteSpace(roomName) Then
            MessageBox.Show("Please enter a room name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If roomNames.Contains(roomName) Then
            DisplayRoomImage(roomName)
        Else
            MessageBox.Show("Room not found. Please check the name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DisplayRoomImage(roomName As String)
        Try
            
            If Not Directory.Exists(roomImagePath) Then
                MessageBox.Show("The image directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            
            Dim imageFiles As String() = Directory.GetFiles(roomImagePath, roomName & "_*.png")

            
            flpMap.Controls.Clear()

            If imageFiles.Length > 0 Then
                For Each filePath In imageFiles
                   
                    Dim img As Image = Image.FromFile(filePath)

                    
                    Dim aspectRatio As Double = img.Width / img.Height
                    Dim pbWidth As Integer = flpMap.ClientSize.Width - 20 
                    Dim pbHeight As Integer = CInt(pbWidth / aspectRatio)

                    
                    Dim pb As New PictureBox With {
                        .Image = img,
                        .SizeMode = PictureBoxSizeMode.StretchImage,
                        .Width = pbWidth,
                        .Height = pbHeight
                    }

                    flpMap.Controls.Add(pb)
                Next

                
                flpMap.AutoScroll = True
                flpMap.FlowDirection = FlowDirection.TopDown
                flpMap.WrapContents = False
            Else
                MessageBox.Show("No images found for " & roomName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub flpMap_Resize(sender As Object, e As EventArgs) Handles flpMap.Resize
        
        For Each ctrl As Control In flpMap.Controls
            If TypeOf ctrl Is PictureBox Then
                Dim pb As PictureBox = DirectCast(ctrl, PictureBox)
                Dim img As Image = pb.Image
                If img IsNot Nothing Then
                    Dim aspectRatio As Double = img.Width / img.Height
                    pb.Width = flpMap.ClientSize.Width - 20
                    pb.Height = CInt(pb.Width / aspectRatio)
                End If
            End If
        Next
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnBACK_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        
    End Sub
End Class
