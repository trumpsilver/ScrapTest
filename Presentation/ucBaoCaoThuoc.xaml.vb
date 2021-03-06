﻿Imports Entities.Entities
Imports Business.Business
Imports System.Collections.ObjectModel
Public Class ucBaoCaoThuoc
    Dim list As ObservableCollection(Of BaoCaoThuocDTO)
    Private Sub tbNgayKham_SelectedDateChanged(sender As Object, e As SelectionChangedEventArgs)
        list = BaoCaoThuocBUS.GetBaoCaoThuoc(tbNgayKham.SelectedDate)
        'Thêm if để tránh việc dgChiTietThuoc chưa khởi tạo mà gán dữ liệu vào
        If dgChiTietThuoc IsNot Nothing Then
            dgChiTietThuoc.ItemsSource = list
        End If
    End Sub
    ''' <summary>
    ''' Thông báo ngày không hợp lệ 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DatePickerDateValidationError(sender As Object, e As DatePickerDateValidationErrorEventArgs)
        Dim dp As DatePicker = sender
        e.ThrowException = False
        Domain.Dialog.Show("Ngày không hợp lệ")
        dp.SelectedDate = Date.Now()
    End Sub
End Class
