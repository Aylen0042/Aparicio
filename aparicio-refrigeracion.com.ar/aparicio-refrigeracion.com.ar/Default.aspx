<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="aparicio.com.ar.Páginas.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">

        <div class="carousel-inner">
            

            <div class="carousel-item active">
                <img src="/Img/Inicio/fondo 1.png" class="d-block w-100" alt="..." style="/*opacity: 0.5; */" width="100%" height="100%" />
                <div class="carousel-caption d-md-block">
                    <h1 style="color: white;" class="<%--text-primary--%>"><strong>MANTENIMIENTO DE EQUIPOS DE AIRE ACONDICIONADO</strong></h1>
                    <h1>&nbsp;</h1>
                </div>
            </div>

            <div class="carousel-item">
                <img src="/Img/Inicio/refrigerados.png" class="d-block w-100" alt="..." style="/*opacity: 0.5; */">
                <div class="carousel-caption d-md-block">
                    <h1 style="color: white;" class="<%--text-primary--%>"><strong>CURSOS DE AIRE ACONDICIONADO SPLIT, AUTOMOTOR Y TRANSPORTES REFRIGERADOS</strong></h1>
                    <h1>&nbsp;</h1>
                </div>
            </div>

            <div class="carousel-item">
                <br />
                <img src="/Img/Inicio/fondo 3.jpeg" class="d-block w-100" alt="..." style="/*opacity: 0.5; */" >
                <div class="carousel-caption d-md-block">
                    <h1 style="color: white;" class="<%--text-primary--%>"><strong>DE TÉCNICOS EN REFRIGERACIÓN</strong></h1>
                    <h6 style="color: white;" class="<%--text-primary--%>"><strong>
                        <%--<img src="../Img/AAF.png" style="width:55px; height:70px;" />--%>&nbsp; ASOCIACIÓN ARGENTINA DEL FRÍO</strong></h6>
                </div>
            </div>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" id="prev" data-bs-slide="prev" aria-label="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" id="next" data-bs-slide="next" aria-label="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
        </button>
    </div>

    <div class="container marketing">

        <div class="card-body text-center mt-5">
            <p class="card-text"><a class="btn btn-primary" href="/Páginas/Cursos/prox_inicios.aspx">Próximos Inicios</a></p>
        </div>
      
    </div>
    
    <div class="text-center mt-5 mb-5">
        <h2><strong>ALGUNOS DE NUESTROS CURSOS</strong></h2>
    </div>

    <div class="container marketing">

        <div class="row row-cols-1 row-cols-md-2 g-4">
            <div class="col">
                <div class="card h-100">
                    <img src="/Img/Inicio/refrigerados.png" class="card-img-top" alt="..." width="100%" height="100%">
                    <div class="card-body text-center">
                        <h5 class="card-title"><strong>CURSO DE TRANSPORTES REFRIGERADOS</strong></h5>
                        <p class="card-text"><a class="btn  btn-primary" href="/Páginas/Cursos/transportes_refrigerados.aspx">Más información</a></p>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card h-100">
                    <%--<img src="/Img/Inicio/automotriz.png" class="card-img-top" alt="...">--%>
                    <img src="Img/Inicio/automotriz_misiones.jpg" width="100%" height="100%" alt="..."/>
                    <div class="card-body text-center">
                        <h5 class="card-title"><strong>CURSO DE AIRE ACONDICIONADO AUTOMOTRIZ</strong></h5>
                        <p class="card-text"><a class="btn btn-primary" href="/Páginas/Cursos/automotriz.aspx">Más información</a></p>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card h-100">
                    <img src="/Img/Inicio/heladera.png" class="card-img-top" alt="..." width="100%" height="100%">
                    <div class="card-body text-center">
                        <h5 class="card-title"><strong>CURSO DE HELADERAS CÍCLICA/NO FROST</strong></h5>
                        <p class="card-text"><a class="btn btn-primary" href="/Páginas/Cursos/heladera.aspx">Más información</a></p>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card h-100">
                    <img src="Img/Cursos/imagen_split.jpg" class="card-img-top" alt="..." width="100%" height="100%">
                    <div class="card-body text-center">
                        <h5 class="card-title"><strong>CURSO DE AIRE ACONDICIONADO SPLIT</strong></h5>
                        <p class="card-text"><a class="btn btn-primary" href="/Páginas/Cursos/split.aspx">Más información</a></p>
                    </div>
                </div>
            </div>
        </div>


        <div class="text-center mt-5 mb-5">
            <h2><strong>TESTIMONIOS DE NUESTROS ALUMNOS</strong></h2>
        </div>

        <div>
            <hr class="featurette-divider">
        </div>

        <div class="row row-cols-1 row-cols-md-2 g-4">
            <div class="col">
                <div class="card">
                    <video controls>
                        <source src="/Videos/video_01.mp4" type="video/mp4">
                    </video>
                </div>
            </div>
            <div class="col">
                <div class="card">
                    <video controls>
                        <source src="/Videos/video_02.mp4" type="video/mp4">
                    </video>
                </div>
            </div>
            <div class="col">
                <div class="card">
                    <video controls>
                        <source src="/Videos/video_03.mp4" type="video/mp4">
                    </video>
                </div>
            </div>
            <div class="col">
                <div class="card">
                    <video controls>
                        <source src="/Videos/video_04.mp4" type="video/mp4">
                    </video>
                </div>
            </div>
        </div>


        <div>
            <hr class="featurette-divider">
        </div>

        <div class="text-center mt-5 mb-5">
            <h2><strong>ALGUNOS DE NUESTROS SERVICIOS</strong></h2>
        </div>

        <div class="row row-cols-1 row-cols-md-3 g-4 pt-5 pb-5" style="background-color: #f0f3f6">
            <div class="col">
                <div class="card h-100">
                    <img src="/Img/Inicio/instalacion_de_aire.jpg" class="card-img-top" alt="..." width="100%" height="100%" />
                    <div class="card-footer text-center">
                        <p class=""><strong>Instalación de equipos de aire acondicionado</strong></p>
                        <p class="card-text"><a class="btn btn-primary" href="/Páginas/Servicios/instalación.aspx">Más información</a></p>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card h-100">
                    <img src="/Img/Inicio/mantenimiento.jpg" class="card-img-top" alt="..." width="100%" height="100%" />
                    <div class="card-footer text-center">
                        <p class=""><strong>Mantenimiento de equipos de aire acondicionado</strong></p>
                        <p class="card-text"><a class="btn btn-primary" href="/Páginas/Servicios/mantenimiento.aspx">Más información</a></p>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card h-100">
                    <img src="/Img/Inicio/carga_de_gas.png" class="card-img-top" alt="..." width="100%" height="100%">
                    <div class="card-footer text-center">
                        <p class=""><strong>Carga refrigerante</strong></p>
                        <p class="card-text"><a class="btn btn-primary" href="/Páginas/Servicios/carga_refrigerante.aspx">Más información</a></p>
                    </div>
                </div>
            </div>
        </div>


    </div>
    <!-- /.container -->


</asp:Content>
