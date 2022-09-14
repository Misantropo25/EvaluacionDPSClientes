<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="EvaluacionDPS.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="styles/Estilos.css" rel="stylesheet" />
    <p>
        .
    </p>
    
    <p>
        `
    </p>

    <div class="panel-body">
        <h3 class="Titulo1">Mantenimiento para Clientes</h3>


        <div id="columna1" class="columna1">
            <p class="p">
                Id Cliente :
                
            </p>
            <p>
                <asp:TextBox ID="txtCustomerId" runat="server" MaxLength="5" />
            </p>
            <p class="p">
                Nombre de la Empresa:
                
            </p>
            <p>
                <asp:TextBox runat="server" ID="txtCompanyName" />
            </p>
            <p class="p">
                Nombre de contacto:
                
            </p>
            <p>
                <asp:TextBox runat="server" ID="txtContactName" />
            </p>

        </div>

        <div id="columna2" class="columna2">
            <p class="p">
                Titulo de contacto:
                
            </p>
            <p>
                <asp:TextBox runat="server" ID="txtContactTitle" />
            </p>
            <p class="p">
                Direccion:
                
            </p>
            <p>
                <asp:TextBox runat="server" ID="txtAddress" />
            </p>
            <p class="p">
                Ciudad:
            </p>
            <p>
                <asp:TextBox runat="server" ID="txtCity" />
            </p>
        </div>

        <div id="columna4" class="columna4">
            <p class="p">
                Departamento:
                    
            </p>
            <p>
                <asp:TextBox runat="server" ID="txtRegion" />
            </p>
            <p class="p">
                Codigo Postal:
                    
            </p>
            <p>
                <asp:TextBox runat="server" ID="txtPostalCode" />
            </p>
            <p class="p">
                Pais:
                    
            </p>
            <p>
                <asp:TextBox runat="server" ID="txtCountry" />
            </p>
        </div>
        <div id="columna5" class="columna5">  
                <p class="p">
                    Telefono:
                    
                </p> 
            <p>
                <asp:TextBox runat="server" ID="txtPhone" />
            </p>
                <p class="p">
                    Fax:
                </p>
            <p>
                <asp:TextBox runat="server" ID="txtFax" />
            </p>
        </div>
        <div id="columna7" class="columna7">
            <p>
                <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" />
                <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click" />
                <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click" />
            </p>
        </div>
        <div id="columna8" class="columna8">
            <p>
                Buscar :
                <asp:TextBox runat="server" ID="buscar" />

                <asp:DropDownList runat="server" ID="ddBuscar">
                    <asp:ListItem Text="codCliente" />
                    <asp:ListItem Text="nombreCompania" />
                </asp:DropDownList>

                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />

                <asp:Button Text="Cargar" runat="server" ID="btnCargar" OnClick="btnCargar_Click" />
            </p>
            <p>
                <asp:GridView runat="server" ID="gvCliente"></asp:GridView>
            </p>


        </div>
    </div>
</asp:Content>
