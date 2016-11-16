<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TDE_TEC_PROG_ll.Home" %>

<%@ Register Src="~/Disciplina.ascx" TagName="Disciplina" TagPrefix="DisciplinaForm" %>
<%@ Register Src="~/DisciplinaBuscar.ascx" TagName="DisciplinaBuscar" TagPrefix="DisciplinaBuscarForm" %>
<%@ Register Src="~/Periodo.ascx" TagName="Periodo" TagPrefix="PeriodoForm" %>
<%@ Register Src="~/Curso.ascx" TagName="Curso" TagPrefix="CursoForm" %>
<%@ Register Src="~/CursoBuscar.ascx" TagName="CursoBuscar" TagPrefix="CursoBuscarForm" %>
<%@ Register Src="~/GradeCurricular.ascx" TagName="GradeCurricular" TagPrefix="GradeCurricularGrid" %>

<link href="Content/bootstrap.css" rel="stylesheet" />
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<script src="Scripts/jquery-3.1.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="homeCadastrarCurso" runat="server" Text="Cadastrar Curso" class="btn btn-info btn-block" OnClick="homeCursoBloco_Click" />
            <asp:Button ID="homeCadastrarPeriodo" runat="server" Text="Cadastrar Periodo" class="btn btn-info btn-block" OnClick="homePeriodoBloco_Click" />
            <asp:Button ID="homeCadastrarDisciplina" runat="server" Text="Cadastrar Disciplina" class="btn btn-info btn-block" OnClick="homeDisciplinaBloco_Click" />
            <asp:Button ID="homeGradeCurricular" runat="server" Text="Grade Curricular" class="btn btn-info btn-block" OnClick="homeGradeCurricular_Click" />

            <hr />

            <div id="cursoBloco" Visible="false" runat="server">
                <div class="col-xs-12">
                    <div class="col-xs-6">
                        <asp:Button Text="Cadastrar curso" class="btn btn-info btn-block"
                            OnClick="homeCadastrarCurso_Click" runat="server" />
                    </div>
                    <div class="col-xs-6">
                        <asp:Button Text="Buscar curso" class="btn btn-info btn-block" 
                            OnClick="homeBuscarCurso_Click" runat="server" />
                    </div>
                </div>
            </div>

            <div id="periodoBloco" Visible="false" runat="server">
                <div class="col-xs-12">
                    <div class="col-xs-6">
                        <asp:Button Text="Cadastrar periodo" 
                            class="btn btn-info btn-block" OnClick="homeCadastrarPeriodo_Click" 
                            runat="server" />
                    </div>
                </div>
            </div>

            <div id="disciplinaBloco" Visible="false" runat="server">
                <div class="col-xs-12">
                    <div class="col-xs-6">
                        <asp:Button Text="Cadastrar disciplina" 
                            class="btn btn-info btn-block" OnClick="homeCadastrarDisciplina_Click" 
                            runat="server" />
                    </div>
                    <div class="col-xs-6">
                        <asp:Button Text="Buscar disciplina" 
                            class="btn btn-info btn-block" OnClick="homeBuscarDisciplina_Click" 
                            runat="server" />
                    </div>
                </div>
            </div>

            <DisciplinaForm:Disciplina ID="Disciplina" runat="server" Visible="false" />
            <PeriodoForm:Periodo ID="Periodo" runat="server" Visible="false" />
            <CursoForm:Curso ID="Curso" runat="server" Visible="false" />
            <GradeCurricularGrid:GradeCurricular ID="GradeCurricular" runat="server" Visible="false" />

            <CursoBuscarForm:CursoBuscar ID="CursoBuscar" runat="server" Visible="false" />
            <DisciplinaBuscarForm:DisciplinaBuscar ID="DisciplinaBuscar" runat="server" Visible="false" />
        </div>
    </form>
</body>
</html>
