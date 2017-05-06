﻿Imports System.ComponentModel
Imports System.Data

Public Module KhamBenhBUS
#Region "1. Inserting"
    Public Function InsertKhamBenhBus(ByVal khamBenh As KhamBenh) As Boolean
        Return insertKhamBenh(khamBenh)
    End Function

    Public Function InsertOrUpdateKhamBenhBus(ByVal khamBenh As KhamBenh) As Boolean
        Return insertOrUpdateKhamBenh(khamBenh)
    End Function

#End Region
#Region "3. Delete"
    Public Function DeleteKhamBenhByIdBus(ByVal maKhamBenh As String) As Boolean
        Return DeleteKhamBenhById(maKhamBenh)
    End Function
#End Region
#Region "4. Get"
    Public Function GetKhamBenhByDateBus(ByVal ngayKham As Date) As BindingList(Of KhamBenh)
        Return GetKhamBenhByDate(ngayKham)
    End Function

    Public Function GetMaKhamBenhBus() As String
        Return GetMaKhamBenh()
    End Function
#End Region

#Region "5.Valild"
    Public Function IsVaildNamSinhBus(ByVal namSinh As String, ByRef iNamSinh As Integer)
        If (Integer.TryParse(namSinh, iNamSinh)) Then
            If (iNamSinh > 0) Then
                Return True
            End If
        End If
        Return False
    End Function
#End Region
End Module
