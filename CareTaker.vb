Public Class CareTaker

    Private articleHistory As List(Of Memento)

    Sub New()
        articleHistory = New List(Of Memento)
        articleHistory.Add(New Memento(""))
    End Sub

    Public Sub addMemento(newMemento As Memento)
        articleHistory.Add(newMemento)
    End Sub

    Public Function getMememento(mementoIndex As Integer) As Memento
        Return articleHistory(mementoIndex)
    End Function

    Public Function mementoCount() As Integer
        Return Me.articleHistory.Count
    End Function

End Class
