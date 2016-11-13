<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TDE_TEC_PROG_ll.Home" %>

<%@ Register Src="~/Disciplina.ascx" TagName="Disciplina" TagPrefix="DisciplinaForm" %>
<%@ Register Src="~/Periodo.ascx" TagName="Periodo" TagPrefix="PeriodoForm" %>
<%@ Register Src="~/Curso.ascx" TagName="Curso" TagPrefix="CursoForm" %>
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

            <asp:Button ID="homeCadastrarCurso" runat="server" Text="Cadastrar Curso" class="btn btn-info btn-block" OnClick="homeCadastrarCurso_Click" />
            <asp:Button ID="homeCadastrarPeriodo" runat="server" Text="Cadastrar Periodo" class="btn btn-info btn-block" OnClick="homeCadastrarPeriodo_Click" />
            <asp:Button ID="homeCadastrarDisciplina" runat="server" Text="Cadastrar Disciplina" class="btn btn-info btn-block" OnClick="homeCadastrarDisciplina_Click" />
            <asp:Button ID="homeGradeCurricular" runat="server" Text="Grade Curricular" class="btn btn-info btn-block" OnClick="homeGradeCurricular_Click" />

            <DisciplinaForm:Disciplina ID="Disciplina" runat="server" Visible="false" />
            <PeriodoForm:Periodo ID="Periodo" runat="server" Visible="false" />
            <CursoForm:Curso ID="Curso" runat="server" Visible="false" />
            <GradeCurricularGrid:GradeCurricular ID="GradeCurricular" runat="server" Visible="false" />
        </div>
    </form>
</body>
</html>
