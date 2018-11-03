<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Site.Master" AutoEventWireup="true" CodeBehind="cMoviesCar.aspx.cs" Inherits="MovieList.UI.cMoviesCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="page-header text-center">
            <h1 style="font-size: x-large; font-family: 'Times New Roman', Times, serif; font: bold; color:blue"><ins>Selected Movies</ins></h1>
        </div>

        <div class="form-group">
            <div class="offset-md-4">
                <asp:GridView ID="DatosGridView" AllowPaging="true" PageSize="5"
                    OnPageIndexChanging="DatosGridView_PageIndexChanging" runat="server" Width="100%"
                    class="table table-responsive text-center" AutoGenerateColumns="False"
                    CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />

                    <Columns>

                        <asp:BoundField DataField="IdDetalle" HeaderText="ID" />
                        <asp:BoundField DataField="IdCar" HeaderText="CarID" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" />
                        <asp:BoundField DataField="Importe" HeaderText="Importe" />
                  

                    </Columns>

                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="Blue" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="Blue" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="Blue" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="LightBlue" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>
        </div>
        <div class="form-group">
            <div class="row">
                <div class="col-md-1 offset-md-9">
                    <span class="font-weight-bold">Total:</span>
            <asp:TextBox ID="CantidadTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

            </div>
        </div>

        <div class="form-group">
            <div class="row">
                <div class="col-md-4 offset-md-6">
                    <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" CssClass="btn btn-primary" />
                </div>

            </div>

        </div>

    </div>

</asp:Content>
