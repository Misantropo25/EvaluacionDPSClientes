<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="EvaluacionDPS.Empleados" %>
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
    <h3 class="Titulo1">Mantenimiento para Empleados</h3>
    <div id="columna1" class="columna1">
        <p class="p">
            Id Empleado : 
        </p>
        <p>
            <asp:Label ID="textEmployeeId" runat="server" Text=""></asp:Label>
        </p>
        <p class="p">
            Primer Apellido: 
        </p>
        <p>
            <asp:TextBox runat="server" Id ="txtLastName" />
        </p>
        <p class="p">
        Nombre : 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtFirstName" />
        </p>
        <p class="p">
        Titulo: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtTitle"/>
        </p>
        <p class="p">
        Codigo Postal: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtPostalCode" />
        </p>
    </div>
    <div id="columna2x" class="columna2x">
   
    <p class="p">
        Titulo de cortesia: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtTitleOfCourtesy"/>
        </p>
    <p class="p">
        Fecha de Nacimiento: 
    </p>
        <p>
            <asp:Button ID="btnAsignarFechaNac" runat="server" Text="Asignar fecha" OnClick="btnAsignarFecha_Click" /> 
        </p>
    <p>
        <asp:Calendar runat="server" Id ="calBirthDate" OnSelectionChanged="btnAsignarFechaNac_SelectionChanged" />
    </p>
    <p>
        <asp:TextBox runat="server" Id ="txtBirthDate"/>
    </p>
    <p class="p">
        Fecha de Contrato:  
    </p>
        <p>
            <asp:Button ID="btnAsignarContrato" runat="server" Text="Asignar fecha contrato" OnClick="btnAsignarFechaContrato_Click" />
        </p>
    <p>
        <asp:Calendar runat="server" Id ="calHireDate" OnSelectionChanged="btnAsignarContrato_SelectionChanged"/>
    </p>
    <p>
        <asp:TextBox runat="server" Id ="txtHireDate"/>
    </p>
        
    </div>
    <div id="columna4" class="columna4">
        <p class="p">
        Departamento: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtRegion" />
        </p>
    <p class="p">
        Direccion: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtAddress" />
        </p>
    <p class="p">
        Ciudad: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtCity" />
        </p>
     </div>
        
    <div id="columna5" class="columna5"> 
    
    
    
    </div>
    <div id="columna6" class="columna6"> 
        <p class="p">
        Pais: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtCountry" />
        </p>
    <p class="p">
        Telefono: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtHomePhone" />
        </p>
    <p class="p">
        Extension: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtExtension" />
        </p>
    </div>

    <div id="columna3" class="columna3">  
    <p class="p">
        Foto: 
    </p>
        <p>
            <asp:Image runat="server" Id ="imgPhoto"/>
        </p>
    <p class="p">
        Referencia de foto: 
    </p>    
        <p>
            <asp:TextBox runat="server" Id ="EnlaceFoto" />
        </p>
    <p>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
    <p class="p">
        Notas: 
    </p>
        <p>
            <asp:TextBox runat="server" Id ="txtNotes" />
        </p>
    <p>
        Reporta a: 
        <asp:DropDownList runat="server" Id="txtReportsTo">
            <asp:ListItem Text="1" />
            <asp:ListItem Text="2"/>
            <asp:ListItem Text="3"/>
            <asp:ListItem Text="4"/>
            <asp:ListItem Text="5"/>
            <asp:ListItem Text="6"/>
            <asp:ListItem Text="7"/>
            <asp:ListItem Text="8"/>
            <asp:ListItem Text="9"/>
            <asp:ListItem Text="10"/>
        </asp:DropDownList>
    </p>
    </div>
    <div id="columna8" class="columna8">
    <p>
        <asp:Button  Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click" />
        <asp:Button  Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click" />
        <asp:Button  Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click" />
    </p>
    <p>
        Buscar : <asp:TextBox runat="server" ID="buscar" />

        <asp:DropDownList runat="server" ID="ddBuscar">
            <asp:ListItem Text="codEmpleado"/>
            <asp:ListItem Text="nombreEmpleado"/>
        </asp:DropDownList>

        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />

        <asp:Button Text="Cargar" runat="server" Id="btnCargar" OnClick="btnCargar_Click"/>
    </p>
    <p>
        <asp:GridView runat="server" ID="gvEmpleado"></asp:GridView>
    </p>
    </div>
    </div>
</asp:Content>
