Public Class UsuarioService
    Private oUsuarioDao As UsuarioDao

    Public Sub New()
        oUsuarioDao = New UsuarioDao
    End Sub

    Public Function validarUsuario(ByVal nombre As String, ByVal password As String) As Usuario
        Return oUsuarioDao.getUserByNamePass(nombre, password)
    End Function

    Public Function validarNombreUsuario(ByVal nombre As String) As Usuario
        Return oUsuarioDao.getUserByName(nombre)
    End Function

    Public Function consultarUsuariosConFiltros(ByVal params As Object()) As List(Of Usuario)
        Return oUsuarioDao.getByFilters(params)
    End Function

    Public Function consultarUsuarios() As List(Of Usuario)
        Return oUsuarioDao.getAll()
    End Function


    Public Function consultarDesarrolladores() As List(Of Usuario)
        Dim params As Object() = {3, Nothing} 'Id_perfil: 3, usuarios desarrolladores
        Return oUsuarioDao.getByFilters(params)
    End Function

    Public Function crearUsuario(ByVal oUsuario As Usuario) As Boolean
        Return oUsuarioDao.create(oUsuario)
    End Function

    Public Function actualizarUsuario(ByVal oUsuario As Usuario) As Boolean
        Return oUsuarioDao.update(oUsuario)
    End Function

    Public Function modificarEstadoUsuario(ByVal oUsuario As Usuario) As Boolean
        Return oUsuarioDao.update(oUsuario)
    End Function

End Class
