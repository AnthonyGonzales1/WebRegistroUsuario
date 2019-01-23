<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormUsuario.aspx.cs" Inherits="WebApplicationUsuario.Registros.WebFormUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="margin-left: 17px">Registro Usuarios </h1>
        <div class="col-md-6 col md-offset-3">
            <div class="form-group">
                <label for="exampleInputID1">Usuario ID</label>&nbsp;&nbsp;<asp:Button ID="ButtonBuscar" runat="server" ForeColor="#006666" OnClick="Button1_Click" Text="Buscar" />
                <input type="email" class="form-control" id="tUsuarioID" aria-describedby="IdHelp" placeholder="Usuario ID">&nbsp;
                    
                            <label for="exampleInputEmail1">Nombres</label>
                            <input type="email" class="form-control" id="tNombre" aria-describedby="emailHelp" placeholder="Nombres">&nbsp;
                            
                                    <label for="exampleInputEmail1">Email</label>
                                    <input type="email" class="form-control" id="tEmail" aria-describedby="emailHelp" placeholder="Entrar email">
                                
                                            <label for="exampleInputPassword1">Clave</label>
                                            <input type="password" class="form-control" id="tPassword" placeholder="Password">
                                        
                                                <label for="exampleInputPassword1">Confirmar Clave</label>
                                                <input type="password" class="form-control" id="tConfirmarPassword" placeholder="Confirmar Password">
                                            </div>  
            </div>  
    <p>
        <asp:Button ID="ButtonNuevo" runat="server" ForeColor="#006666" OnClick="Button2_Click" Text="Nuevo" />
        <asp:Button ID="ButtonGuardar" runat="server" ForeColor="#006666" OnClick="Button3_Click" Text="Guardar" />
        <asp:Button ID="ButtonEliminar" runat="server" ForeColor="#006666" OnClick="Button4_Click" Text="Eliminar" />
        <br>
    
    </p>
</asp:Content>
