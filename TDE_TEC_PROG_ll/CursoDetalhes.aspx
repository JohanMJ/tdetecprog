<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CursoDetalhes.aspx.cs" Inherits="TDE_TEC_PROG_ll.CursoDetalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="container">
            <div class="row">
                <div class="panel panel-primary">
                    <div class="panel-body">
                        <div class="form-group">
                            <h2>Atualizar Curso</h2>
                        </div>
                        <div class="form-group">
                            <label class="control-label" for="nomeCurso">Nome Curso</label>
                            <input id="nomeCurso" type="text" maxlength="50" class="form-control" runat="server" />
                        </div>

                        <div class="form-group">
                            <asp:Button ID="atualizarCurso" runat="server" Text="Atualizar Curso" 
                                class="btn btn-info btn-block" OnClick="atualizarCurso_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
