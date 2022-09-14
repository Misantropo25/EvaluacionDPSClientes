<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="Proveedores.aspx.cs" Inherits="EvaluacionDPS.Proveedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/Estilos.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        .
    </p>
    <p>
        `
    </p>
    <div class="panel-body">

    <h3 class="Titulo1">Mantenimiento para Proveedores</h3>

    <div id="columna1" class="columna1">
    <p class="p">
        Id Proveedor : 
    </p>
        <p>
            <asp:Label ID="txtSupplierId" runat="server" Text=""></asp:Label>
        </p>
    <p class="p">
        Nombre de la Empresa: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtCompanyName"/>
        </p>
    <p class="p">
        Nombre de contacto: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtContactName" />
        </p>
    </div>
        <div id="columna2" class="columna2">
    <p class="p">
        Titulo de contacto: 
    </p>
            <p>
                <asp:TextBox runat="server" Id ="txtContactTitle"/>
            </p>
    <p class="p">
        Direccion: 
    </p>
            <p>
                <asp:TextBox runat="server" Id ="txtAddress"/>
            </p>
    <p class="p">
        Ciudad: 
    </p>
            <p>
                <asp:TextBox runat="server" Id ="txtCity"/>
            </p>
    </div>
        <div id="columna4" class="columna4">
    <p class="p">
        Departamento: 
    </p>
            <p>
                <asp:TextBox runat="server" Id ="txtRegion"/>
            </p>
    <p class="p">
        Codigo Postal: 
    </p>
            <p>
                <asp:TextBox runat="server" Id ="txtPostalCode" />
            </p>
    <p class="p">
        Pais: 
    </p>
            <p>
                <asp:TextBox runat="server" Id ="txtCountry" />
            </p>
    </div>

        <div id="columna5" class="columna5">  
    <p class="p">
        Telefono: 
    </p>
            <p>
                <asp:TextBox runat="server" Id ="txtPhone" />
            </p>
    <p class="p">
        Fax: 
    </p>
            <p>
                <asp:TextBox runat="server" Id ="txtFax" />
            </p>
    <p class="p">
        Direccion Web: 
    </p>
            <p>
                <asp:TextBox runat="server" Id ="txtHomePage" />
            </p>
</div>
        <div id="columna7" class="columna7">
    <p>
        <asp:Button  Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click" />
        <asp:Button  Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click" />
        <asp:Button  Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click" />
    </p>
            </div>
        <div id="columna8" class="columna8">
    <p>
        Buscar : <asp:TextBox runat="server" ID="buscar" />

        <asp:DropDownList runat="server" ID="ddBuscar">
            <asp:ListItem Text="codProveedor"/>
            <asp:ListItem Text="nombreCompania"/>
        </asp:DropDownList>

        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />

        <asp:Button Text="Cargar" runat="server" Id="btnCargar" OnClick="btnCargar_Click"/>
    </p>
    <p>
        <asp:GridView runat="server" ID="gvProveedor"></asp:GridView>
    </p>
            </div>
</div>

</asp:Content>
