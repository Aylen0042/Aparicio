<%@ Page Title="" Language="C#" MasterPageFile="~/Páginas/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Matriculados.aspx.cs" Inherits="aparicio_refrigeracion.com.ar.Páginas.Admin.Matriculados1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- BARRA DE UBICACIÓN EN EL SISTEMA -->
    <div class="alert alert-warning rounded mx-5 mt-2" role="alert">
        <h5 class="ms-2"> Gestión / Tecnicos</h5>
    </div>

    <!-- CONTENEDOR PRINCIPAL -->
    <div id="Contorno" class="m-5">
        <div class="bg-success bg-opacity-50 rounded-top p-2">
            <h5 class="text-white m-2">Tecnicos</h5>
        </div>
        <div class=" border border-success border-opacity-50">
            <div class="bg-light p-2">
                <div class="input-group mb-2">
                    <asp:Label ID="lblMatricula" runat="server" Text="Matricula Nº: " CssClass="input-group-text" ></asp:Label>
                    <asp:TextBox ID="txtMatricula" runat="server" class="form-control text-black-50 bg-warning bg-opacity-10" Text="Automático" ReadOnly="True"></asp:TextBox>

                    <asp:Label ID="lblDNI" runat="server" Text="DNI: " CssClass="input-group-text" ></asp:Label>
                    <asp:TextBox ID="txtDNI" runat="server" class="form-control"></asp:TextBox>

                </div>

                <div class="input-group mb-2">
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre: " CssClass="input-group-text" ></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>

                    <asp:Label ID="lblApellido" runat="server" Text="Apellido: " CssClass="input-group-text" ></asp:Label>
                    <asp:TextBox ID="txtApellido" runat="server" AutoCompleteType="None" class="form-control"></asp:TextBox>
                </div>

                <div class="input-group mb-2">
                    <asp:Label ID="lblDomicilio" runat="server" Text="Domicilio: " CssClass="input-group-text" ></asp:Label>
                    <asp:TextBox ID="txtDomicilio" runat="server" AutoCompleteType="None" class="form-control"></asp:TextBox>

                    <asp:Label ID="lblPais" runat="server" Text="Pais: " CssClass="input-group-text" Style="width: 100px;"></asp:Label>
                    <asp:DropDownList ID="ddlCodPais" runat="server" class="form-select">
                    </asp:DropDownList>

                    <asp:Label ID="lblProvincia" runat="server" Text="Provincia: " CssClass="input-group-text" Style="width: 100px;"></asp:Label>
                    <asp:DropDownList ID="ddlProvincia" runat="server" class="form-select">
                    </asp:DropDownList>

                    <asp:Label ID="lblLocalidad" runat="server" Text="Localidad: " CssClass="input-group-text" Style="width: 100px;"></asp:Label>
                    <asp:DropDownList ID="ddlLocalidad" runat="server" class="form-select">
                    </asp:DropDownList>
                </div>

                <div class="input-group mb-2">
                    <asp:Label ID="lblDDI" runat="server" Text="DDI: " CssClass="input-group-text" ></asp:Label>
                    <asp:TextBox ID="txtDDI" runat="server" class="form-control" ></asp:TextBox>

                    <asp:Label ID="lblDDN" runat="server" Text="DDN: " CssClass="input-group-text" ></asp:Label>
                    <asp:TextBox ID="txtDDN" runat="server" class="form-control" ></asp:TextBox>

                    <asp:Label ID="lblTelefono" runat="server" Text="Telefono: " CssClass="input-group-text" ></asp:Label>
                    <asp:TextBox ID="txtTelefono" runat="server" class="form-control" ></asp:TextBox>

                </div>
 
                <div class="input-group mb-2">
                    <asp:Label ID="lblCorreoElectronico" runat="server" Text="Correo Electronico: " CssClass="input-group-text" ></asp:Label>
                    <asp:TextBox ID="txtCorreoElectronico" runat="server" class="form-control" ></asp:TextBox>

                    <asp:Label ID="lblPaginaWeb" runat="server" Text="Página Web: " CssClass="input-group-text" ></asp:Label>
                    <asp:TextBox ID="txtPaginaWeb" runat="server" class="form-control" ></asp:TextBox>

                </div>
                
            </div>


            <div class="p-2">
                <asp:CheckBox ID="chkEsNuevo" runat="server" Visible="False" />
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass="btn btn-primary" Style="width: 120px;" OnClick="btnNuevo_Click" />
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" Style="width: 120px;" OnClick="btnGuardar_Click" Visible="False" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" Style="width: 120px;" OnClick="btnCancelar_Click" Visible="False" />
            </div>

            <div class="table-responsive  p-2">
                <asp:GridView ID="gvTecnicos" runat="server" class="table table-responsive table-sm table-striped table-bordered" AutoGenerateColumns="False" OnRowDeleting="gvTecnicos_RowDeleting" OnSelectedIndexChanging="gvTecnicos_SelectedIndexChanging" OnRowDataBound="gvTecnicos_RowDataBound" OnRowCreated="gvTecnicos_RowCreated" OnSelectedIndexChanged="gvTecnicos_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowCancelButton="False" ShowHeader="True" ShowSelectButton="True" ButtonType="Button">
                            <ControlStyle CssClass="btn btn-warning" Width="100px" />
                            <ItemStyle Width="120px" />
                        </asp:CommandField>
                        <asp:CommandField ButtonType="Button" HeaderText="Eliminar" ShowCancelButton="False" ShowDeleteButton="True" ShowHeader="True">
                            <ControlStyle CssClass="btn btn-danger" Width="80px" />
                            <ItemStyle Width="90px" />
                        </asp:CommandField>
                        <asp:BoundField DataField="Matricula" HeaderText="Matricula">
                            <ItemStyle Width="50px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DNI" HeaderText="DNI" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                        <asp:BoundField DataField="Domicilio" HeaderText="Domicilio" />
                        <asp:BoundField DataField="CorreoElectronico" HeaderText="Correo Electrónico" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />

                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>


</asp:Content>
