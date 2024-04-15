Imports System.IO

Module Module1
    Sub Main()
        Dim logDirectory As String = "C:\Path\To\IIS\Logs"
        Dim outputFile As String = "C:\Path\To\Output\filtered_logs.csv"
        Dim robotsTxtIPs As New HashSet(Of String)()
        Dim linesToWrite As New List(Of String)()

        ' Read all files in the directory
        For Each file As String In Directory.GetFiles(logDirectory, "*.log")
            Dim lines As String() = File.ReadAllLines(file)

            For Each line As String In lines
                Dim parts As String() = line.Split(" ")

                ' Assuming IP address is the first part and the requested URL is somewhere in the line
                If parts.Length > 10 AndAlso parts.Any(Function(part) part.Contains("robots.txt")) Then
                    robotsTxtIPs.Add(parts(0)) ' Add the IP address to the exclusion list
                Else
                    If Not robotsTxtIPs.Contains(parts(0)) Then
                        linesToWrite.Add(line) ' Add line to output if IP not in exclusion list
                    End If
                End If
            Next
        Next

        ' Write filtered data to CSV
        Using writer As New StreamWriter(outputFile)
            For Each line As String In linesToWrite
                writer.WriteLine(line)
            Next
        End Using

        Console.WriteLine("Filtered logs have been written to " + outputFile)
    End Sub
End Module
