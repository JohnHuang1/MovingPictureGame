Public Class Form1
    Dim Difficulty As String = "Easy"
    Dim secondsLeft As Double
    Dim score As Integer
    Dim startTime As Integer
    Dim moveMin, moveMax As Double
    Dim moveHoriz, moveVert As Integer
    Dim winningPoints As Integer = 100
    Dim gen As New Random()
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Select Case Difficulty
            Case "Easy"
                startTime = 30
                moveMin = 10
                moveMax = 20
            Case "Medium"
                startTime = 30
                moveMin = 30
                moveMax = 40
            Case "Hard"
                startTime = 20
                moveMin = 30
                moveMax = 40
            Case "Impossible"
                startTime = 15
                moveMin = 40
                moveMax = 50
        End Select
        secondsLeft = startTime
        If sender.text = "Start Game" Then
            tmrClock.Start()
            tmrMove.Start()
            sender.Enabled = False
            picDoggo.Enabled = True
            score = 0
            DifficultyToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub tmrMove_Tick(sender As Object, e As EventArgs) Handles tmrMove.Tick
        Dim newPt As Point = picDoggo.Location

        If secondsLeft = startTime Then
            moveHoriz = generateMovement()
            moveVert = moveHoriz
            Dim angle As Integer = gen.Next(0, 360)
            moveHoriz *= generateDirection(angle, True)
            moveVert *= generateDirection(angle, False)
        End If

#Region "Left & Right Border Collision"
        If newPt.X > 490 Then
            If Difficulty = "Easy" OrElse Difficulty = "Medium" Then
                moveHoriz = Math.Abs(generateMovement()) * -1
            ElseIf Difficulty = "Hard" OrElse Difficulty = "Impossible" Then
                moveHoriz = generateMovement()
                moveVert = moveHoriz
                Dim angle As Integer = gen.Next(190, 350)
                moveVert *= generateDirection(angle, False)
                moveHoriz *= generateDirection(angle, True)
            End If
        ElseIf newPt.X < 10 Then
            If Difficulty = "Easy" OrElse Difficulty = "Medium" Then
                moveHoriz = Math.Abs(generateMovement())
            ElseIf Difficulty = "Hard" OrElse Difficulty = "Impossible" Then
                moveHoriz = generateMovement()
                moveVert = moveHoriz
                Dim angle As Integer = gen.Next(10, 170)
                moveVert *= generateDirection(angle, False)
                moveHoriz *= generateDirection(angle, True)
            End If
        End If
#End Region

#Region "Top & Down Border Collision"
        If newPt.Y > 580 Then
            If Difficulty = "Easy" OrElse Difficulty = "Medium" Then
                moveVert = Math.Abs(generateMovement()) * -1
            ElseIf Difficulty = "Hard" OrElse Difficulty = "Impossible" Then
                moveHoriz = generateMovement()
                moveVert = moveHoriz
                Dim angle As Integer = gen.Next(100, 260)
                moveVert *= generateDirection(angle, False)
                moveHoriz *= generateDirection(angle, True)
            End If
        ElseIf newPt.Y < 85 Then
            If Difficulty = "Easy" OrElse Difficulty = "Medium" Then
                moveVert = Math.Abs(generateMovement())
            ElseIf Difficulty = "Hard" OrElse Difficulty = "Impossible" Then
                moveHoriz = generateMovement()
                moveVert = moveHoriz
                Dim angle As Integer = gen.Next(-80, 80)
                moveVert *= generateDirection(angle, False)
                moveHoriz *= generateDirection(angle, True)
            End If
        End If
        newPt.X += moveVert
        newPt.Y += moveHoriz
        picDoggo.Location = newPt
    End Sub
#End Region

#Region "Generators"
    Private Function generateMovement() As Integer
        Dim moveAmount As Integer = gen.Next(moveMin, moveMax)
        Console.WriteLine("Movement: " & moveAmount)
        Return moveAmount
    End Function

    Private Function generateDirection(ByVal directionAngle As Integer, ByVal cosine As Boolean) As Double
        Console.WriteLine("Angle: " & directionAngle)
        Dim angle As Double = directionAngle * Math.PI / 180
        Dim output As Double
        If cosine Then
            output = Math.Cos(angle)
            Console.WriteLine("Cosine: " & output)
        Else
            output = Math.Sin(angle)
            Console.WriteLine("Sine: " & output)
        End If
        Return output
    End Function
#End Region

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        If secondsLeft <= 0 Then
            tmrClock.Stop()
            tmrMove.Stop()
            picDoggo.Enabled = False
            btnStart.Enabled = True
            DifficultyToolStripMenuItem.Enabled = True
            picDoggo.Location = New Point(266, 329)
            If score >= winningPoints Then
                If Difficulty = "Impossible" Then
                    MsgBox("Congrats! " & vbCrLf & "You actually won..." & vbCrLf & "Wow...")
                Else
                    MsgBox("Congradulations! You have won.")
                End If
            Else
                MsgBox("Sorry! You did not win." & vbCrLf & "You had to get " & winningPoints & " to win." & vbCrLf & "You only got " & score & " points")
            End If
        End If
        secondsLeft -= 0.05
        lblTimer.Text = Math.Round(secondsLeft, 0).ToString("Time Left: 0# Seconds")
    End Sub

    Private Sub picDoggo_Click(sender As Object, e As EventArgs) Handles picDoggo.Click
        score += 1
        lblScore.Text = score.ToString("Score: #")
        If Difficulty = "Hard" Then
            Dim newPt As Point = sender.location
            If (Not newPt.X >= 490 OrElse Not newPt.X <= 10) And (Not newPt.Y >= 580 OrElse newPt.Y <= 85) Then
                moveHoriz = generateMovement()
                moveVert = moveHoriz
                Dim angle As Integer = gen.Next(0, 360)
                moveHoriz *= generateDirection(angle, True)
                moveVert *= generateDirection(angle, False)
            End If
        ElseIf Difficulty = "Impossible" Then
            Dim gen As New Random()
            Dim newPt As Point = sender.location
            Dim range As Integer = 50
            While ((newPt.X <= sender.location.X + range AndAlso newPt.X >= sender.location.X - 50) AndAlso
                (newPt.Y <= sender.location.Y + range AndAlso newPt.Y >= sender.location.Y - range))
                newPt = New Point(gen.Next(20, 480), gen.Next(95, 570))
            End While
            sender.location = newPt
        End If
    End Sub

#Region "Menu: Difficulty Changers"
    Private Sub EasyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasyToolStripMenuItem.Click
        Difficulty = "Easy"
        MsgBox("Difficulty was set to Easy." & vbCrLf & "You must get 100 points to win.")
        winningPoints = 100
    End Sub

    Private Sub Medium_Click(sender As Object, e As EventArgs) Handles Medium.Click
        Difficulty = "Medium"
        MsgBox("Difficulty was set to Medium." & vbCrLf & "You must get 50 points to win.")
        winningPoints = 50
    End Sub

    Private Sub HardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HardToolStripMenuItem.Click
        Difficulty = "Hard"
        MsgBox("Difficulty was set to Hard." & vbCrLf & "You must get 20 points to win.")
        winningPoints = 20
    End Sub

    Private Sub ImpossibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpossibleToolStripMenuItem.Click
        Difficulty = "Impossible"
        MsgBox("Difficulty was set to Impossible." & vbCrLf & "You must get 10 points to win.")
        winningPoints = 10
    End Sub
#End Region

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        secondsLeft = 1
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Choose a difficulty and start the game!" & vbCrLf & "Click the doggo to earn points.")
    End Sub
End Class
