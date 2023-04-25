<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TecnicosCertificados.aspx.cs" Inherits="aparicio_refrigeracion.com.ar.Páginas.Alumnos.TecnicosCertificados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <br />
    <br />

    <!-- CONTENEDOR PRINCIPAL -->
    <div id="Contorno" class="container my-3">

        <!-- TÍTULO BARRA DE BÚSQUEDA-->
        <div class="bg-success bg-opacity-50 text-center p-2">
            <h3 class="text-white m-2">TÉCNICOS CERTIFICADOS</h3>
        </div>

        <div class=" border border-success border-opacity-50">
            <div class="bg-light p-2">

                <div class="input-group mb-2 form-control-sm">
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido: " CssClass="input-group-text form-control-sm" Style="width: 100px;"></asp:Label>
                    <asp:TextBox ID="txtApellido" runat="server" AutoCompleteType="None" class="form-control form-control-sm"></asp:TextBox>

                </div>

                <div class="input-group mb-2 form-control-sm">
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre: " CssClass="input-group-text form-control-sm" Style="width: 100px;"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" class="form-control form-control-sm"></asp:TextBox>

                </div>

                <div class="input-group mb-2 form-control-sm">
                    <%--                    <asp:Label ID="lblPais" runat="server" Text="País: " CssClass="input-group-text" Style="width: 100px;"></asp:Label>
                    <asp:DropDownList ID="ddlCodPais" runat="server" class="form-select">
                    </asp:DropDownList>--%>

                    <asp:Label ID="lblCodProvincia" runat="server" Text="Provincia: " CssClass="input-group-text form-control-sm" Style="width: 100px;"></asp:Label>
                    <asp:DropDownList ID="ddlCodProvincia" runat="server" class="form-select form-control-sm">
                    </asp:DropDownList>

                    <asp:Label ID="lblLocalidad" runat="server" Text="Localidad: " CssClass="input-group-text form-control-sm" Style="width: 100px;"></asp:Label>
                    <asp:DropDownList ID="ddlCodLocalidad" runat="server" class="form-select form-control-sm">
                    </asp:DropDownList>
                </div>

                <div class="p-2">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-outline-success form-control-sm" Style="width: 120px;" OnClick="btnBuscar_Click" />
                    <asp:Button ID="btnQuitarFiltros" runat="server" Text="Quitar Filtros" CssClass="btn btn-outline-secondary form-control-sm" Style="width: 120px;" OnClick="btnQuitarFiltros_Click" />
                </div>

            </div>
        </div>
    </div>

    <!-- CONTENEDOR -->
    <div class="container container-fluid">

        <!-- CARDS -->
        <div class="row row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-lg-4 g-4">

            <asp:ListView ID="lvTecnicosCertificados" runat="server" OnItemDataBound="lvTecnicosCertificados_ItemDataBound">

                <ItemTemplate>
                    <div class="col">

                        <!-- CARD -->
                        <div class="card border-success h-100">

                            <!-- TÍTULO CARD -->
                            <div class="card-header bg-success text-center">
                                <h5 class="card-title text-bg-success"><%# Eval("Nombre")%> <%# Eval("Apellido")%></h5>
                            </div>

                            <!-- CUERPO CARD -->
                            <div class="card-body text-center">
                                <%--<h6 class="card-subtitle mb-2 text-muted"><%# Eval("Cursos")%></h6>--%>
                                <p class="card-text"><i class="bi bi-house-fill"></i>&nbsp;  <%# Eval("Domicilio")%> </p>
                                <p class="card-text"><i class="bi bi-telephone-fill"></i>&nbsp; (+<%# Eval("Tel_DDI")%>) (<%# Eval("Tel_DDN")%>) <%# Eval("Telefono")%> </p>
                                
                                <p class="card-text"><asp:Label ID="lblLocalidad" runat="server" Text="Localidad"></asp:Label></p>
                                <p class="card-text"><asp:Label ID="lblProvincia" runat="server" Text="Provincia"></asp:Label></p>

                                <asp:HyperLink ID="hlnkCorreoElectrónico" runat="server" > <%# Eval("CorreoElectrónico")%> </asp:HyperLink>
                                <asp:HyperLink ID="hlnkPáginaWeb" runat="server"><%# Eval("PáginaWeb")%></asp:HyperLink>
                            </div>

                        </div>
                    </div>
                </ItemTemplate>

            </asp:ListView>

        </div>
    </div>
</asp:Content>

