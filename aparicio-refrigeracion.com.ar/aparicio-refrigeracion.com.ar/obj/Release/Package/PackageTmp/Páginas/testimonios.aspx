<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testimonios.aspx.cs" Inherits="aparicio.com.ar.Páginas.testimonios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <br />
    <br />

    <div class="container marketing">

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
                        <source src="/Videos/video_05.mp4" type="video/mp4">
                    </video>
                </div>
            </div>
            <div class="col">
                <div class="card">
                    <video controls>
                        <source src="/Videos/video_06.mp4" type="video/mp4">
                    </video>
                </div>
            </div>
            <div class="col">
                <div class="card">
                    <video controls>
                        <source src="/Videos/video_07.mp4" type="video/mp4">
                    </video>
                </div>
            </div>
            <div class="col">
                <div class="card">
                    <video controls>
                        <source src="/Videos/video_08.mp4" type="video/mp4">
                    </video>
                </div>
            </div>
        </div>


    </div>

</asp:Content>
