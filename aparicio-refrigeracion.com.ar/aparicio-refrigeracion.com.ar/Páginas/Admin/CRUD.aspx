<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="aparicio_refrigeracion.com.ar.Páginas.Admin.CRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous">
</head>
<body>

<form id="form1" runat="server">
    <div class="container marketing">
  
    <div class="row mt-3">
      <div class="col-sm-6">
        <div class="card border-success">
          <div class="card-body">
              <p class="text-center"><strong> MATRÍCULA</strong></p>
                <div class="card border border-success">
                  <div class="card-body">
            
                    <asp:Label ID="lblMatricula" runat="server" Text="Label"><strong>Número de matrícula: </strong></asp:Label>
                    <asp:TextBox ID="txtMatricula" runat="server"></asp:TextBox>
                    <asp:Label ID="lblValidacionMatricula" class="alert alert-danger mt-3" Enabled="false" runat="server" Text=""></asp:Label>
                    <br />            
                    <br />            
                
                    <asp:Label ID="lblFechaAlta" runat="server" Text="Label"><strong>Fecha de alta: </strong></asp:Label>
                    <asp:TextBox ID="txtFechaAlta" runat="server" Enabled="false"></asp:TextBox>
                    <br />            
                    <br />  
                
                    <asp:Label ID="lblFechaVto" runat="server" Text="Label"><strong>Fecha de vencimiento: </strong></asp:Label>
                    <asp:TextBox ID="txtFechaVto" runat="server" Enabled="false"></asp:TextBox>
                    <br /> 

                  </div>
                </div>
          </div>
        </div>
      </div>
      <div class="col-sm-6">
        <div class="card border-success">
          <div class="card-body">
              <p class="text-center"><strong> DATOS DEL CLIENTE</strong></p>
                <div class="card mt-3 border border-success">
                  <div class="card-body"> 
              
                      <asp:Label ID="lblDNI" runat="server" Text="Label"><strong>DNI: </strong></asp:Label>
                      <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
                      <asp:Label ID="lblValidacionDNI" class="alert alert-danger mt-3" Enabled="false" runat="server" Text=""></asp:Label>
                      <br />  
                      <br />  

                      <asp:Label ID="lblNombre" runat="server" Text="Label"><strong>Nombre: </strong></asp:Label>
                      <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                      <asp:Label ID="lblValidacionNombre" class="alert alert-danger mt-3" Enabled="false" runat="server" Text=""></asp:Label>
                      <br />  
                      <br />  
                
                      <asp:Label ID="lblApellido" runat="server" Text="Label"><strong>Apellido: </strong></asp:Label>
                      <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                      <asp:Label ID="lblValidacionApellido" class="alert alert-danger mt-3" Enabled="false" runat="server" Text=""></asp:Label>
                
                    </div>
                </div>
          </div>
        </div>
      </div>
    </div>        

    <div class="row mt-3">
      <div class="col-sm-6">
        <div class="card border-success">
          <div class="card-body">
              <p class="text-center"><strong> UBICACIÓN</strong></p>
                <div class="card mt-3 border border-success">
                  <div class="card-body">

                    <asp:Label ID="lblDomicilio" runat="server" Text="Label"><strong>Domicilio: </strong></asp:Label>
                    <asp:TextBox ID="txtDomicilio" runat="server"></asp:TextBox>
                    <asp:Label ID="lblValidacionDomicilio" class="alert alert-danger mt-3" Enabled="false" runat="server" Text=""></asp:Label>
                    <br />
                    <br />

                    <asp:Label ID="lblCodLocalDropDownList" runat="server" Text="Label"><strong>Código de localidad: </strong></asp:Label>
                    <asp:DropDownList ID="DropDownListCodLocal" runat="server"></asp:DropDownList>
                    <asp:Label ID="lblValidacionCodLocal" class="alert alert-danger mt-3" Enabled="false" runat="server" Text=""></asp:Label>
                    <br />
                    <br />

                    <asp:Label ID="lblCodProvDropDownList" runat="server" Text="Label"><strong>Código de provincia: </strong></asp:Label>
                    <asp:DropDownList ID="DropDownListCodProv" runat="server"></asp:DropDownList>
                    <asp:Label ID="lblValidacionCodProv" class="alert alert-danger" Enabled="false" runat="server" Text=""></asp:Label>
                    <br />
                    <br />
              
                    <asp:Label ID="lblCodPaisDropDownList" runat="server" Text="Label"><strong>Código de país: </strong></asp:Label>
                    <asp:DropDownList ID="DropDownListCodPais" runat="server"></asp:DropDownList>
                    <asp:Label ID="lblValidacionCodPais" class="alert alert-danger" Enabled="false" runat="server" Text=""></asp:Label>
                  </div>
                </div>
          </div>
        </div>
      </div>
      <div class="col-sm-6">
        <div class="card border-success">
          <div class="card-body">
              <p class="text-center"><strong> TELÉFONO</strong></p>
                <div class="card mt-3 border border-success">
                  <div class="card-body">
              
                      <asp:Label ID="lblTelDDI" runat="server" Text="Label"><strong>Discado Directo Internacional: </strong></asp:Label>
                      <asp:TextBox ID="txtTelDDI" runat="server"></asp:TextBox>
                      <asp:Label ID="lblValidacionTelDDI" class="alert alert-danger mt-3" Enabled="false" runat="server" Text=""></asp:Label>
                      <br />
                      <br />

                      <asp:Label ID="lblTelDDN" runat="server" Text="Label"><strong>Discado Directo Nacional: </strong></asp:Label>
                      <asp:TextBox ID="txtTelDDN" runat="server"></asp:TextBox>
                      <asp:Label ID="lblValidacionTelDDN" class="alert alert-danger mt-3" Enabled="false" runat="server" Text=""></asp:Label>
                      <br />
                      <br />
                
                      <asp:Label ID="lblTelefono" runat="server" Text="Label"><strong>Teléfono: </strong></asp:Label>
                      <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                      <asp:Label ID="lblValidacionTelefono" runat="server" Text=""></asp:Label>
                      <br />            
                      <br />   
                
                      <asp:Label ID="lblCelular" runat="server" Text="Label"><strong>¿Es celular? </strong></asp:Label>
                      <asp:CheckBox ID="CheckBoxCelular" runat="server" />
                
                  </div>
                </div>
          </div>
        </div>
      </div>
    </div>        

    <div class="row mt-3 mb-3">
      <div class="col-sm-6">
        <div class="card border-success">
          <div class="card-body">
              <p class="text-center"><strong> OTROS DATOS</strong></p>
                <div class="card mt-3 border border-success">
                  <div class="card-body">

                    <asp:Label ID="lblCorreo" runat="server" Text="Label"><strong>Correo electrónico: </strong></asp:Label>
                    <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                    <br />            
                    <br /> 
                
                    <asp:Label ID="lblPaginaWeb" runat="server" Text="Label"><strong>Página web: </strong></asp:Label>
                    <asp:TextBox ID="txtPaginaWeb" runat="server"></asp:TextBox>
                    <brs />

                  </div>
                </div>
          </div>
        </div>
      </div>
      <div class="col-sm-6">
        <div class="mt-3">
          <div class="card-body">        
            <div class="mt-3 text-center">
            <asp:Button ID="btnGuardar" class="btn btn-success" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
            <asp:Button ID="btnActualizar" class="btn btn-warning" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
            <asp:Button ID="btnBorrar" class="btn btn-danger" runat="server" OnClick="btnBorrar_Click" Text="Borrar" />
            <asp:Button ID="btnLeerDatos" class="btn btn-primary" runat="server" OnClick="btnLeerDatos_Click" Text="Leer Datos" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" class="alert alert-secondary mt-3" Enabled="false" runat="server" Text=""></asp:Label>
        </div>
          </div>
        </div>
      </div>
    </div>        

        
    </div> <!-- container marketing !-->
</form>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>

</body>
</html>
