Public Class MechanicManager
    Private ReadOnly mechanicRepository As New MechanicResponsitory()

    Public Function GetAllMechanics() As List(Of Mechanic)
        Return mechanicRepository.GetAllMechanics()
    End Function

    Public Function RegisterMechanic(mechanic As Mechanic) As Boolean
        Return mechanicRepository.RegisterMechanic(mechanic)
    End Function

    Public Function UpdateMechanic(mechanic As Mechanic) As Boolean
        Return mechanicRepository.UpdateMechanic(mechanic)
    End Function
End Class
