<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebConsultUsuario.aspx.cs" Inherits="WebApplicationUsuario.Consultas.ConsultaUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Consulta Usuarios <span class="badge badge-secondary">New</span></h1>
    <div class="form-row justify-content-center">
        <%--Filtro--%>
        <div class="form-group col-md-2">
            Filtro<asp:DropDownList ID="FiltroDropDownList" CssClass="form-control" runat="server">
                <asp:ListItem>Seleccionar</asp:ListItem>
                <asp:ListItem>UsuarioId</asp:ListItem>
                <asp:ListItem>Email</asp:ListItem>
                <asp:ListItem>Nombres</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="ButtonBuscar" runat="server" ForeColor="#006666" Text="Buscar" />
        </div>
        <%--Criterio--%>
        <div class="form-group col-md-3">
            Criterio<asp:TextBox ID="tCriterio" AutoCompleteType="Disabled" class="form-control input-group" runat="server"></asp:TextBox>
        </div>
        <div class="col-lg-1 p-0">
        </div>
    </div>
    <%--GRID--%>
    <div class="form-row justify-content-center">
        <asp:GridView ID="UsuarioGridView" runat="server" class="table table-condensed table-bordered table-responsive" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Usuario ID" HeaderText="Usuario ID" />
                <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
             </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </div>
</asp:Content>
