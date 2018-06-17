Public Class Memento

    Private articleValue As String
    Public Property article() As String
        Get
            Return articleValue
        End Get
        Set(ByVal value As String)
            articleValue = value
        End Set
    End Property

    Sub New(articleToSave As String)
        Me.articleValue = articleToSave
    End Sub

End Class
