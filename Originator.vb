Public Class Originator

    Private articleValue As String
    Public Property article() As String
        Get
            Return articleValue
        End Get
        Set(ByVal value As String)
            articleValue = value
        End Set
    End Property


    Public Function saveInMemento() As Memento
        Return New Memento(article)
    End Function

    Public Function restoreFromMemento(savedMemento As Memento) As String
        article = savedMemento.article
        Return article
    End Function


End Class
