<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Periodo.ascx.cs" Inherits="TDE_TEC_PROG_ll.Periodo" %>


<link href="Content/bootstrap.css" rel="stylesheet" />
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<script src="Scripts/jquery-3.1.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>



<div class="container">
    <div class="row">
        <div class="panel panel-primary">
            <div class="panel-body">
                <div class="form-group">
                    <h2>Adicionar Periodo</h2>
                </div>
                <div class="form-group">
                    <label class="control-label" for="numeroPeriodo">Numero Periodo</label>
                    <input id="numeroPeriodo" type="text" maxlength="50" class="form-control" runat="server">
                </div>

                <asp:DropDownList ID="ddlSubject" runat="server" AppendDataBoundItems="true" OnLoad="ddlSubject_Load">
                </asp:DropDownList>

                <div class="form-group">
                    <asp:Button ID="adicionarPeriodo" runat="server" Text="Cadastrar Periodo" class="btn btn-info btn-block" OnClick="adicionarPeriodo_Click" />
                </div>
            </div>
        </div>
    </div>
</div>
