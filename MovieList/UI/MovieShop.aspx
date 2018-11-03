<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Site.Master" AutoEventWireup="true" CodeBehind="MovieShop.aspx.cs" Inherits="MovieList.UI.MovieShop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="=container">
          <%--LinkButton--%>
            <div class="form-group">
                <asp:LinkButton ID="ItemLinkButton" Font-Size="X-Large" runat="server" Text="Items" OnClick="ItemLinkButton_Click"></asp:LinkButton>
            </div>
        <%--Datalist--%>
        <div class="form-group">
            <asp:DataList ID="DatosDataList" CssClass="form-control" CellPadding="12" GridLines="Both" AlternatingItemStyle-CssClass="form-control"  
                RepeatDirection="Horizontal" RepeatColumns="5" OnItemCommand="DatosDataList_ItemCommand" runat="server">
                <ItemTemplate>
                    <a href='<%# Eval("Photo") %>'>
                        <h3 class="text-capitalize; "><%# Eval("Descripcion") %></h3>
                    </a>
                    <img src='<%# Eval("Photo") %> ' width="220" height="200" />
                    
                    <p>Precio: <b><%# Eval("Precio") %></b></p>
                    Cantidad:
                        <div class="row">
                            <div class="col-6">
                                <asp:TextBox ID="CantidadTextBox" Text="0" type="number" placeholder="Cantidad" CssClass="form-control" runat="server"></asp:TextBox>
                               
                               
                            </div>

                            <div class="col-4">
                                <asp:Button ID="AgregarButton" CommandName="Agregar" ValidationGroup="Agregar" CssClass="btn btn-primary" runat="server" Text="Agregar" />
                            </div>
                        </div
                </ItemTemplate>
            </asp:DataList>
        </div>


    </div>
</asp:Content>
