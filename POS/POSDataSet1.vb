Partial Class POSDataSet1
    Partial Class POSDataTable

        Private Sub POSDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TotalColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
