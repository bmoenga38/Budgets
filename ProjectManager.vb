Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ProjectManager

    Friend Shared Sub SaveProject(ProjectID As String, Name As String, Code As String, WEF As String, WET As String, Description As String, TownID As String, CountyID As String, ManagerID As String, FileURL As String, AddedBy As String)
        Dim OrganizationID As String = Utilityfunctions.GetOrganizationID

        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SaveProject"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("ProjectID", ProjectID)
            cmd.Parameters.AddWithValue("Name", Name)
            cmd.Parameters.AddWithValue("Code", Code)
            cmd.Parameters.AddWithValue("Description", Description)
            cmd.Parameters.AddWithValue("OrganizationID", OrganizationID)
            cmd.Parameters.AddWithValue("ManagerID", ManagerID)
            cmd.Parameters.AddWithValue("FileURL", FileURL)
            cmd.Parameters.AddWithValue("WEF", WEF)
            cmd.Parameters.AddWithValue("WET", WET)
            cmd.Parameters.AddWithValue("CountyID", CountyID)
            cmd.Parameters.AddWithValue("TownID", TownID)
            cmd.Parameters.AddWithValue("AddedBy", AddedBy)

            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try

    End Sub

    Friend Shared Sub SaveBlock(BlockID As String, Name As String, Code As String, ProjectID As String, PropertyTypeID As String, FloorID As String, PhotoURL As String, AddedBy As String, ProjectDistrictID As String, PhaseID As String)
        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SaveBlock"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("BlockID", BlockID)
            cmd.Parameters.AddWithValue("Name", Name)
            cmd.Parameters.AddWithValue("Code", Code)
            cmd.Parameters.AddWithValue("ProjectID", ProjectID)
            cmd.Parameters.AddWithValue("PropertyTypeID", PropertyTypeID)
            cmd.Parameters.AddWithValue("ProjectDistrictID", ProjectDistrictID)
            cmd.Parameters.AddWithValue("PhaseID", PhaseID)
            cmd.Parameters.AddWithValue("FloorID", FloorID)
            cmd.Parameters.AddWithValue("PhotoURL", PhotoURL)
            cmd.Parameters.AddWithValue("AddedBy", AddedBy)

            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try

    End Sub

    Friend Shared Sub SaveReservation(ReservationID As String, CustomerID As String, UnitID As String, FundingSourceID As String, PaymentPlanID As String, AddedBy As String)
        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SaveReservation"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("ReservationID", ReservationID)
            cmd.Parameters.AddWithValue("CustomerID", CustomerID)
            cmd.Parameters.AddWithValue("UnitID", UnitID)
            cmd.Parameters.AddWithValue("FundingSourceID", FundingSourceID)
            cmd.Parameters.AddWithValue("PaymentPlanID", PaymentPlanID)
            cmd.Parameters.AddWithValue("AddedBy", AddedBy)

            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try

    End Sub
    Friend Shared Sub UpdateReservation(ReservationID As String, CustomerID As String, UnitID As String, FundingSourceID As String, PaymentPlanID As String, Reason As String, AddedBy As String)
        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "UpdateReservation"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("ReservationID", ReservationID)
            cmd.Parameters.AddWithValue("CustomerID", CustomerID)
            cmd.Parameters.AddWithValue("UnitID", UnitID)
            cmd.Parameters.AddWithValue("FundingSourceID", FundingSourceID)
            cmd.Parameters.AddWithValue("PaymentPlanID", PaymentPlanID)
            cmd.Parameters.AddWithValue("Reason", Reason)
            cmd.Parameters.AddWithValue("AddedBy", AddedBy)

            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try

    End Sub

    Friend Shared Sub SavePaymentPlan(PaymentPlanID As String, ProjectID As String, FrequencyID As String, ReservationAmount As String, PercentageDeposit As String, DiscountPercentage As String, AddedBy As String, Title As String)

        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SavePaymentPlan"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("PaymentPlanID", PaymentPlanID)
            cmd.Parameters.AddWithValue("ProjectID", ProjectID)
            cmd.Parameters.AddWithValue("FrequencyID", FrequencyID)
            cmd.Parameters.AddWithValue("ReservationAmount", ReservationAmount)
            cmd.Parameters.AddWithValue("PercentageDeposit", PercentageDeposit)
            cmd.Parameters.AddWithValue("DiscountPercentage", DiscountPercentage)
            cmd.Parameters.AddWithValue("Title", Title)
            cmd.Parameters.AddWithValue("AddedBy", AddedBy)

            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try

    End Sub

    Friend Shared Sub SaveUnitCosting(UnitCostingID As String, Code As String, ProjectID As String, PropertyTypeID As String,
                                      Bedrooms As String, Squarefeet As String, Bathrooms As String, Amount As String, AddedBy As String,
                                      Description As String, PaymentPlanID As String, FloorFrom As String, FloorTo As String)

        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SaveUnitCosting"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("UnitCostingID", UnitCostingID)
            cmd.Parameters.AddWithValue("ProjectID", ProjectID)
            cmd.Parameters.AddWithValue("PropertyTypeID", PropertyTypeID)
            cmd.Parameters.AddWithValue("Code", Code)
            cmd.Parameters.AddWithValue("Bedrooms", Bedrooms)
            cmd.Parameters.AddWithValue("Squarefeet", Squarefeet)
            cmd.Parameters.AddWithValue("Bathrooms", Bathrooms)
            cmd.Parameters.AddWithValue("Amount", Amount)
            cmd.Parameters.AddWithValue("AddedBy", AddedBy)
            cmd.Parameters.AddWithValue("Description", Description)
            cmd.Parameters.AddWithValue("PaymentPlanID", PaymentPlanID)
            cmd.Parameters.AddWithValue("FloorFrom", FloorFrom)
            cmd.Parameters.AddWithValue("FloorTo", FloorTo)

            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try

    End Sub

    Friend Shared Sub SaveUnit(UnitID As String, Name As String, Code As String, BlockID As String, FloorID As String, PropertyTypeID As String, UnitCostingID As String, Description As String, AddedBy As String)
        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SaveUnit"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("UnitID", UnitID)
            cmd.Parameters.AddWithValue("Name", Name)
            cmd.Parameters.AddWithValue("Code", Code)
            cmd.Parameters.AddWithValue("BlockID", BlockID)
            cmd.Parameters.AddWithValue("FloorID", FloorID)
            cmd.Parameters.AddWithValue("PropertyTypeID", PropertyTypeID)
            cmd.Parameters.AddWithValue("UnitCostingID", UnitCostingID)
            cmd.Parameters.AddWithValue("Description", Description)
            cmd.Parameters.AddWithValue("AddedBy", AddedBy)

            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try
    End Sub

    Friend Shared Sub SavePaymentPlanInstallments(PaymentPlanInstallmentsID As String, PaymentPlanID As String, InstallmentNo As String, PercentageAmount As String, AddedBy As String)

        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SavePaymentPlanInstallments"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("paymentPlanInstallmentsID", PaymentPlanInstallmentsID)
            cmd.Parameters.AddWithValue("paymentPlanID", PaymentPlanID)
            cmd.Parameters.AddWithValue("InstallmentNo", InstallmentNo)
            cmd.Parameters.AddWithValue("PercentageAmount", PercentageAmount)
            cmd.Parameters.AddWithValue("AddedBy", AddedBy)

            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try
    End Sub

    Friend Shared Sub SaveBlockAmenity(BlockID As String, AmenitiesID As String)
        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SaveBlockAmenity"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("BlockID", BlockID)
            cmd.Parameters.AddWithValue("AmenitiesID", AmenitiesID)

            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try
    End Sub
    Friend Shared Sub ImportUnits(Project As String, Name As String, Code As String, District As String, Phase As String, Block As String, Floor As String, Type As String, UnitCosting As String, TopFloor As String, Description As String)

        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "ImportUnits"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("Project", Project)
            cmd.Parameters.AddWithValue("Name", Name)
            cmd.Parameters.AddWithValue("Code", Code)
            cmd.Parameters.AddWithValue("District", District)
            cmd.Parameters.AddWithValue("Phase", Phase)
            cmd.Parameters.AddWithValue("Block", Block)
            cmd.Parameters.AddWithValue("Floor", Floor)
            cmd.Parameters.AddWithValue("Type", Type)
            cmd.Parameters.AddWithValue("UnitCosting", UnitCosting)
            cmd.Parameters.AddWithValue("TopFloor", TopFloor)
            cmd.Parameters.AddWithValue("Description", Description)
            cmd.Parameters.AddWithValue("AddedBy", Utilityfunctions.GetLoggedOnStaffID())

            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try
    End Sub

    Friend Shared Sub SaveProjectDistrict(DistrictID As String, ProjectID As String, Name As String, Isactive As String, AddedBy As String)
        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SaveProjectDistrict"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("DistrictID", DistrictID)
            cmd.Parameters.AddWithValue("ProjectID", ProjectID)
            cmd.Parameters.AddWithValue("Name", Name)
            cmd.Parameters.AddWithValue("Isactive", Isactive)
            cmd.Parameters.AddWithValue("AddedBy", AddedBy)
            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try
    End Sub

    Friend Shared Sub SaveChargeType(ChargeTypeID As String, Name As String, Priorty As String, DueDays As String, AddedBy As String)
        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SaveChargeType"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("ChargeTypeID", ChargeTypeID)
            cmd.Parameters.AddWithValue("Name", Name)
            cmd.Parameters.AddWithValue("Priority", Priorty)
            cmd.Parameters.AddWithValue("DueDays", DueDays)
            cmd.Parameters.AddWithValue("AddedBy", AddedBy)
            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try
    End Sub

    Friend Shared Sub SaveProjectPhase(projectPhaseID As String, districtID As String, name As String, isactive As String, addedBy As String)
        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SaveProjectPhase"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("projectPhaseID", projectPhaseID)
            cmd.Parameters.AddWithValue("districtID", districtID)
            cmd.Parameters.AddWithValue("Name", name)
            cmd.Parameters.AddWithValue("Isactive", isactive)
            cmd.Parameters.AddWithValue("AddedBy", addedBy)
            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try
    End Sub

    Friend Shared Sub SaveUnitBlockList(Unit As String)

        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SaveUnitBlockList"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("Unit", Unit)
            cmd.Parameters.AddWithValue("AddedBy", Utilityfunctions.GetLoggedOnStaffID())
            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try
    End Sub

    Friend Shared Sub SaveBudgetCategories(ProjectID As String, Title As String, StatusID As String, Percentage As String, AddedBy As String)

        Dim DBManager As New DatabaseConnectionManager()

        Try

            Dim query As String = "SaveProjectAccountingCategories"
            Dim cmd As New SqlCommand(query, DBManager.GetConnection)
            cmd.CommandType = CommandType.StoredProcedure

            'cmd.Parameters.AddWithValue("ProjectAccountingCategoriesID", ProjectAccountingCategoriesID)
            cmd.Parameters.AddWithValue("ProjectID", ProjectID)
            cmd.Parameters.AddWithValue("Title", Title)
            cmd.Parameters.AddWithValue("Status", StatusID)
            cmd.Parameters.AddWithValue("Percentage", Percentage)
            cmd.Parameters.AddWithValue("AddedBy", AddedBy)

            Utilityfunctions.LogSQLCommand(cmd)

            cmd.ExecuteNonQuery()

            cmd.Dispose()

        Catch ex As Exception
            Utilityfunctions.LogException(ex)
            Throw
        Finally
            DBManager.Disconnect()
        End Try

    End Sub
End Class
