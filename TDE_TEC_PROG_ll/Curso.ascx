<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Curso.ascx.cs" Inherits="TDE_TEC_PROG_ll.Curso" %>


<link href="Content/bootstrap.css" rel="stylesheet" />
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<script src="Scripts/jquery-3.1.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>

<div class="container">
    <div class="row">
        <div class="panel panel-primary">
            <div class="panel-body">
                <div class="form-group">
                    <h2>Adicionar Curso</h2>
                </div>
                <div class="form-group">
                    <label class="control-label" for="nomeCurso">Nome Curso</label>
                    <input id="nomeCurso" type="text" maxlength="50" class="form-control" runat="server">
                </div>

                <div class="form-group">
                    <asp:Button ID="adicionarCurso" runat="server" Text="Cadastrar Curso" class="btn btn-info btn-block" OnClick="adicionarCurso_Click" />
                </div>
            </div>
        </div>
    </div>
</div>