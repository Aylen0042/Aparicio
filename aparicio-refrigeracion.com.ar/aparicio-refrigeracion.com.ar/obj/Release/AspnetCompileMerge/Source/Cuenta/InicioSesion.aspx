<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="aparicio_refrigeracion.com.ar.Cuenta.InicioSesion" %>

<!DOCTYPE html>

<html lang="es-ar" xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous" />

    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js" integrity="sha384-oBqDVmMz9ATKxIep9tiCxS/Z9fNfEXiDAYTujMAeBAsjFuCZSmKbSSUnQlmh/jp3" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.min.js" integrity="sha384-7VPbUDkoPSGFnVtYi0QogXtr74QeVeeIs99Qfg5YCF+TidwNdjvaKZX19NZ/e6oz" crossorigin="anonymous"></script>

    <!-- JQuery -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>

    <!-- FUNCIÓN JavaScript para mostrar MODAL-->
    <script type="text/javascript">
        function abrirModal() {
            $(document).ready(function () {
                // Show the Modal on load
                $("#Ventana_Mensaje_Modal").modal("show");
            });
        }
    </script>

    <!-- Hoja de estilo CSS -->
    <link href="../App_Themes/CSS_LogIn.css" rel="stylesheet" />


    <title>GAFI Login</title>

</head>

<body>

    <div class="login-page bg-light">
        <div class="container">
            <div class="row">
                <div class="col-lg-10 offset-lg-1">
                    <h3 class="mb-3">Inicio de Sesión en GAFI</h3>
                    <div class="bg-white shadow rounded">
                        <div class="row">
                            <div class="col-md-7 pe-0">
                                <div class="form-left h-100 py-5 px-5">

                                    <!-- FORMULARIO -->
                                    <form id="LogIn" runat="server" class="row g-4">
                                        <div class="col-12">
                                            <asp:Label ID="lblUsuario" Text="Usuario :" runat="server">Usuario<span class="text-danger">*</span></asp:Label>
                                            <div class="input-group">
                                                <div class="input-group-text"><i class="bi bi-person-fill"></i></div>
                                                <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="Ingrese Usuario" />
                                            </div>
                                        </div>

                                        <div class="col-12">
                                            <asp:Label ID="lblContraseña" Text="Contraseña :" runat="server">Contraseña<span class="text-danger">*</span></asp:Label>
                                            <div class="input-group">
                                                <div class="input-group-text"><i class="bi bi-lock-fill"></i></div>
                                                <asp:TextBox ID="txtContraseña" runat="server" class="form-control" placeholder="Ingrese Contraseña" TextMode="Password" />
                                            </div>
                                        </div>

                                        <div class="col-sm-6">
                                            <div class="form-check">
                                                <%--<input class="form-check-input" type="checkbox" id="inlineFormCheck" />--%>
                                                <%--<asp:label runat="server" class="form-check-label" for="chkRecuerdame">Recuerdame</asp:label>--%>
                                                <%--<asp:CheckBox ID="chkRecuerdame" Text="Recuerdame" runat="server" ></asp:CheckBox>--%>
                                            </div>
                                        </div>

                                        <div class="col-sm-6">
                                            <%--<a href="#" class="float-end text-primary">No recuerda su contraseña?</a>--%>
                                        </div>

                                        <div class="col-12">
                                            <asp:Button ID="btnIniciarSesion" Text="Iniciar Sesión" OnClick="BtnIniciarSesion_Click" runat="server" class="btn btn-primary px-4 float-end mt-4" />
                                        </div>
                                    </form>
                                    <!-- FIN FORMULARIO -->

                                </div>
                            </div>

                            <!-- IMAGEN LADO DERECHO -->
                            <div class="col-md-5 ps-0 d-none d-md-block">
                                <div class="form-right h-100 bg-primary text-white text-center pt-5" style="background-image: url('../img/informática-forense.jpg');">
                                </div>
                            </div>
                            <!-- FIN IMAGEN LADO DERECHO -->

                        </div>
                    </div>
                    <p class="text-end text-secondary mt-3">GAFI - Gestión de Análisis Forense Informático</p>
                </div>
            </div>
        </div>
    </div>



    <!-- Modal -->
    <div class="modal fade" id="Ventana_Mensaje_Modal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">
                        <asp:Label ID="lblTitulo" Text="Titulo" runat="server" />
                    </h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <asp:Label ID="lblMensaje" Text="Mensaje....." runat="server" />
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>



</body>

</html>
