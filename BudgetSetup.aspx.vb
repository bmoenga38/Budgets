Imports System.Data.SqlClient

Public Class BudgetSetup
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not StaffManager.UserCanDo("Manage Finance") Then
            Response.Redirect("AccessDenied.aspx")
        End If
        If Not IsPostBack Then


        End If
    End Sub

    Protected Sub btnSaveBudgetCategories_OnClick(sender As Object, e As EventArgs) Handles btnSaveBudgetCategories.Click

        Dim msg As String = ""
        Try
            Dim ProjectAccountingCategories As String = Session("ProjectAccountingCategories")
            Dim ProjectID As String = ddlProject.SelectedValue
            Dim Title As String = txtTitle.Text
            Dim StatusID As String = ddlStatus.SelectedValue
            Dim Percentage As String = txtPercentage.Text
            Dim AddedBy As String = Utilityfunctions.GetLoggedOnStaffID()


            If ProjectID = "0" Then
                msg = "toastr.error('Please select the project.')"
                ScriptManager.RegisterStartupScript(Me, Page.GetType(), "msg", msg, True)
                Return
            End If

            If Title = "" Then
                msg = "toastr.error('Please specify the Title.')"
                ScriptManager.RegisterStartupScript(Me, Page.GetType(), "msg", msg, True)
                Return
            End If
            'If StatusID = "" Then
            '    msg = "toastr.error('Please specify the Status.')"
            '    ScriptManager.RegisterStartupScript(Me, Page.GetType(), "msg", msg, True)
            '    Return
            'End If

            If Percentage = "" Then
                msg = "toastr.error('Please specify the Percentage.')"
                ScriptManager.RegisterStartupScript(Me, Page.GetType(), "msg", msg, True)
                Return
            End If

            ProjectManager.SaveBudgetCategories(ProjectID, Title, StatusID, Percentage, AddedBy)
            Session("ProjectAccountingCategories") = "0"

            ddlProject.SelectedValue = "0"
            txtTitle.Text = ""
            ddlStatus.Text = ""
            txtPercentage.Text = ""

            msg = "toastr.success('Budget saved successfully.')"
            ScriptManager.RegisterStartupScript(Me, Page.GetType(), "msg", msg, True)

            dgvBudgetCategories.DataBind()
        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            msg = "toastr.error('" + ex.Message + "')"
            ScriptManager.RegisterStartupScript(Me, Page.GetType(), "msg", msg, True)
        End Try
    End Sub
    Protected Sub dgvBudgetCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvBudgetCategories.SelectedIndexChanged
        Try
            Session("ProjectAccountingCategories") = dgvBudgetCategories.DataKeys(dgvBudgetCategories.SelectedRow.RowIndex).Values("ID").ToString()

            ddlProject.SelectedValue = dgvBudgetCategories.DataKeys(dgvBudgetCategories.SelectedRow.RowIndex).Values("ProjectID").ToString()
            txtTitle.Text = dgvBudgetCategories.DataKeys(dgvBudgetCategories.SelectedRow.RowIndex).Values("Title").ToString()
            ddlStatus.SelectedValue = dgvBudgetCategories.DataKeys(dgvBudgetCategories.SelectedRow.RowIndex).Values("Status").ToString()
            txtPercentage.Text = dgvBudgetCategories.DataKeys(dgvBudgetCategories.SelectedRow.RowIndex).Values("Percentage").ToString()

        Catch ex As Exception

        End Try

    End Sub
End Class


