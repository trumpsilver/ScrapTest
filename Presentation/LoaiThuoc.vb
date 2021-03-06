﻿Imports System.Data

Namespace Entities
    Public Class LoaiThuoc
        Private _MaThuoc As String
        Private _TenThuoc As String

        Public Property MaThuoc As String
            Get
                Return _MaThuoc
            End Get
            Set(value As String)
                _MaThuoc = value
            End Set
        End Property

        Public Property TenThuoc As String
            Get
                Return _TenThuoc
            End Get
            Set(value As String)
                _TenThuoc = value
            End Set
        End Property

        Public Sub New(ByVal MaThuoc As String, ByVal TenThuoc As String)
            _MaThuoc = MaThuoc
            _TenThuoc = TenThuoc
        End Sub

        Public Sub New(ByVal row As DataRow)
            _MaThuoc = row.Field(Of String)("mathuoc")
            _TenThuoc = row.Field(Of String)("tenthuoc")
        End Sub
    End Class
End Namespace

