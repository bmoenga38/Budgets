<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/HomeDashboardMaster.Master" CodeBehind="BudgetSetup.aspx.vb" Inherits="MziziERP.BudgetSetup" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel runat="server" ID="upnlPropertyManager">
        <ContentTemplate>
            <div class="content-wrapper wrapper">
                <div class="content">

                    <div class="container-fluid">
                        <div class="row">
                            <div class="card col-12 col-sm-12">
                                <div id="tabs" class="nav-tabs-custom">
                                    <div class="tab-content">
                                        <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Width="100%"
                                            CssClass="ajax__tab_yuitabview-theme">
                                            <asp:TabPanel runat="server" CssClass="tab-pane" HeaderText="Unit Costing" ID="TabPanel2">
                                                <HeaderTemplate>
                                                    <h5>Categories</h5>
                                                </HeaderTemplate>
                                                <ContentTemplate>
                                                    <div class="row card-body">
                                                        <div class="col-12 col-sm-6">
                                                            <div class="form-group">
                                                                <div class="form-group ">
                                                                    <label>
                                                                        <h6>Project</h6>
                                                                    </label>
                                                                    <asp:DropDownList ID="ddlProject" runat="server" CssClass="form-control select2bs4" AutoPostBack="true"
                                                                        DataSourceID="SqlDataSourceProject" DataTextField="Name" DataValueField="ID" Style="width: 100%;">
                                                                    </asp:DropDownList>
                                                                    <asp:SqlDataSource ID="SqlDataSourceProject" runat="server"
                                                                        ConnectionString="<%$ ConnStringExpression:AppDB %>"
                                                                        SelectCommand="EXEC GetProjects @OrganizationID, 0, NULL, @LoggedOnStaffID">
                                                                        <SelectParameters>
                                                                            <asp:SessionParameter Name="OrganizationID" SessionField="OrganizationID" />
                                                                            <asp:SessionParameter Name="LoggedOnStaffID" SessionField="LoggedOnStaffID" />
                                                                        </SelectParameters>
                                                                    </asp:SqlDataSource>
                                                                </div>

                                                                <%-- status dropdown--%>
                                                                <div class="col-12 col-sm-12">
                                                                    <div class="form-group">
                                                                        <div class="form-group">
                                                                            <label>
                                                                                <h6>Status</h6>
                                                                            </label>
                                                                            <asp:DropDownList CssClass="form-control" ID="ddlStatus" runat="server">
                                                                                <asp:ListItem Text="ACTIVE" Value="1"></asp:ListItem>
                                                                                <asp:ListItem Text="INACTIVE" Value="0"></asp:ListItem>
                                                                            </asp:DropDownList>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="col-12 col-sm-6">
                                                            <div class="form-group">
                                                                <label>
                                                                    <h6> Title</h6>
                                                                </label>
                                                                <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control" placeholder="Title"></asp:TextBox>
                                                            </div>
                                                            <div class="form-group">
                                                                <label>
                                                                    <h6>Percentage</h6>
                                                                </label>
                                                                <asp:TextBox runat="server" ID="txtPercentage" CssClass="form-control" placeholder="Percentage"></asp:TextBox>

                                                            </div>

                                                        </div>

                                                        <div class="col-12 col-sm-6">
                                                            <div class="form-group">
                                                                <div class="form-group">
                                                                    <div class="form-group">
                                                                        <asp:Button runat="server" ID="btnSaveBudgetCategories" CssClass="btn btn-info" Text="Save Details" />
                                                                    </div>
                                                                </div>
                                                            </div>

                                                        </div>

                                                        <div class="table-responsive">

                                                            <asp:GridView ID="dgvBudgetCategories" runat="server" AllowSorting="True"
                                                                AutoGenerateColumns="false" EmptyDataText="No records found"
                                                                DataKeyNames="ID, ProjectID, Title, Status, Percentage" DataSourceID="SqlDataSourceschedule" Font-Size="13px"
                                                                UseAccessibleHeader="true" CssClass="table no-margin table-resp table-hover" GridLines="None" CellSpacing="-1">
                                                                <Columns>
                                                                    <asp:TemplateField ShowHeader="true" ItemStyle-Width="10px">
                                                                        <ItemTemplate>
                                                                            <asp:ImageButton ID="ImageButton2" runat="server" AlternateText="Edit" ForeColor="Green"
                                                                                CausesValidation="False" CommandName="Select" ImageUrl="~/icons/pencil3.png" />
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                    <asp:BoundField DataField="Project" HeaderText="Project" SortExpression="Project">
                                                                        <HeaderStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title">
                                                                        <HeaderStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="StatusDec" HeaderText="Status" SortExpression="StatusDec">
                                                                        <HeaderStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="Percentage" HeaderText="% Percentage" SortExpression="Percentage">
                                                                        <HeaderStyle HorizontalAlign="Left" />
                                                                    </asp:BoundField>
                                                                    <asp:TemplateField ShowHeader="true">
                                                                        <ItemTemplate>
                                                                            <asp:ImageButton ID="ImageButton1" runat="server" AlternateText="Remove" ForeColor="Red"
                                                                                CausesValidation="False" CommandName="Delete" ImageUrl="icons/deletered.png"
                                                                                OnClientClick="return confirm('Are you sure you want to delete?');" />

                                                                        </ItemTemplate>
                                                                        <ItemStyle ForeColor="Red" />
                                                                    </asp:TemplateField>

                                                                </Columns>
                                                                <FooterStyle Font-Bold="True" />
                                                                <HeaderStyle Font-Bold="True" HorizontalAlign="Left" />
                                                                <PagerStyle HorizontalAlign="Center" />
                                                                <SelectedRowStyle Font-Bold="True" />
                                                                <RowStyle HorizontalAlign="Left" />
                                                            </asp:GridView>
                                                            <asp:SqlDataSource ID="SqlDataSourceschedule" runat="server" ConnectionString="<%$ ConnStringExpression:AppDB %>"
                                                                SelectCommand="EXEC GetProjectAccountingCategories"
                                                                DeleteCommand="DELETE FROM [ProjectAccountingCategories] WHERE [ID] = @ID">
                                                               <DeleteParameters>
                                                                    <asp:Parameter Name="ID" Type="Int32" />
                                                                </DeleteParameters>
                                                            </asp:SqlDataSource>
                                                        </div>

                                                    </div>
                                                </ContentTemplate>
                                            </asp:TabPanel>

                                        </asp:TabContainer>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <!-- /.row -->
                    </div>
                    <!-- /.container-fluid -->
                </div>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdatePanelAnimationExtender ID="UpdatePanelAnimationExtender1" runat="server"
        TargetControlID="upnlPropertyManager" Enabled="True">
        <Animations>
                            <OnUpdating>
                                <Parallel duration=".25" Fps="30">
                                    <FadeOut MinimumOpacity=".2" />
                                </Parallel>
                            </OnUpdating>
                            <OnUpdated>
                                <Parallel duration=".25" Fps="30">
                                    <FadeIn MinimumOpacity=".2" />
                                </Parallel>                    
                            </OnUpdated></Animations>
    </asp:UpdatePanelAnimationExtender>

    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
            <div style="position: absolute; top: 50%; left: 50%">
                <img src="icons/loading9.gif" alt="Loading..." />
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>


</asp:Content>

