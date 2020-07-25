Module mdlModule_Example
    Public Sub DrawEllipse(ByVal frm As Windows.Forms.Form)
        Dim objGraphics As Graphics
        Dim recDrawRectangle As Rectangle
        recDrawRectangle = frm.DisplayRectangle
        recDrawRectangle.Inflate(0.5, 0.5)
        objGraphics = frm.CreateGraphics
        objGraphics.Clear(System.Drawing.SystemColors.Control)
        objGraphics.DrawEllipse(System.Drawing.Pens.Black, recDrawRectangle)

    End Sub
    Public Sub ClearEllipse(ByVal frm As Windows.Forms.Form)
        frm.Refresh()
    End Sub
End Module
