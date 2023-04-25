<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="mantenimiento.aspx.cs" Inherits="aparicio.com.ar.Páginas.Servicios.mantenimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <br />
    <br />

    <div class="container marketing mt-3 w-75">
        <div class="card border-primary">
            <div class="card-header bg-primary">
                <strong class="text-bg-primary">MANTENIMIENTO DE EQUIPOS DE AIRE ACONDICIONADO Y HELADERAS</strong>
            </div>
            <div class="card-body">
                <p class="card-text">Mantenimiento de equipos de aire acondicionado en viviendas, comercios, industriales, cámaras frigoríficas.</p>
                <p class="card-text">Limpieza unidad interior, unidad exterior, control de presiones, rendimiento del compresor.</p>
            </div>
        </div>
    </div>

    <div style="display:flex; justify-content:center; align-content:center; margin: 3.25rem;">
        <div class="card-group w-75">
        <div class="card border-primary">

            <img class="card-img-top h-60 p-5" src="/Img/Servicios/mantenimiento_split.png" />
            <div class="card-body">
                <h5 class="card-title"><strong>AIRE ACONDICIONADO SPLIT</strong></h5>
                <p class="card-text">
                    Se realiza un chequeo general del equipo, se busca la pérdida, 
                    se repara y luego se realiza la carga de acuerdo al gas refrigerante que lleva el equipo,
                    ya sea R22 como R410a.
                </p>
            </div>
        </div>
        <div class="card border-primary">
            <img class="card-img-top h-60 p-5" src="/Img/Servicios/carga_refrigerante_Automotriz.jpg" />
            <div class="card-body">
                <h5 class="card-title"><strong>AIRE ACONDICIONADO AUTOMOTRIZ</strong></h5>
                <p class="card-text">
                    Antes de realizar la carga del gas refrigerante, es importante hallar y reparar la pérdida. 
                    También procedemos a realizar el cambio de los óvulos y luego se realiza la carga.
                </p>
            </div>
        </div>
        <div class="card border-primary">
            <img class="card-img-top h-60 p-5" src="/Img/Servicios/carga_refrigerante_heladera.jpg" />
            <div class="card-body">
                    <br />
                <h5 class="card-title"><strong>HELADERAS</strong></h5>
                <p class="card-text">
                    Procedemos a realizar un chequeo general de la heladera, reparamos la pérdida y la carga de gas refrigerante
                    de la misma.
                </p>
            </div>
        </div>
    </div>
    </div>


</asp:Content>
