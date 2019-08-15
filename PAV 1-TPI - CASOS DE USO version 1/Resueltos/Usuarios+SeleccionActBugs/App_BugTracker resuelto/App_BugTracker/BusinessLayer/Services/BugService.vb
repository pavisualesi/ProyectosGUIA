Public Class BugService
    Private oBugDao As BugDao
    Public Sub New()
        oBugDao = New BugDao
    End Sub

    Public Function create(ByVal oBug As Bug) As Boolean
        Return oBugDao.create(oBug)
    End Function

    Public Function consultarBugsConFiltros(ByVal params As Object()) As List(Of Bug)
        Return oBugDao.getBugByFilters(params)
    End Function

    Public Function consultarBugsPorId(ByVal id As Integer) As Bug
        Return oBugDao.getBugById(id)
    End Function

    Public Function actualizarBugConHistorial(ByVal lst As List(Of Bug)) As Boolean
        Return oBugDao.updateNewHistorial(lst)
    End Function

End Class
