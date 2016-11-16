<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisciplinaDetalhes.aspx.cs" Inherits="TDE_TEC_PROG_ll.DisciplinaDetalhes" %>

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
							<h2>Atualizar Disciplina</h2>
						</div>
						<div class="form-group">
							<label class="control-label" for="nomeDisciplina">Nome Disciplina</label>
							<input id="nomeDisciplina" type="text" maxlength="50" class="form-control" runat="server" />
						</div>
						<div class="form-group">
							<label class="control-label" for="horaRelogio;">Hora Relogio</label>
							<input id="horaRelogio" type="text" class="form-control" runat="server" />
						</div>	
                        <div class="form-group">
							<label class="control-label" for="numeroCredito;">Num. Credito</label>
							<input id="numeroCredito" type="text" class="form-control" runat="server" />
						</div>	
                        <div class="form-group">
							<label class="control-label" for="numeroAulasTeoricas;">Num. Aulas Teoricas</label>
							<input id="numeroAulasTeoricas" type="text" class="form-control" runat="server" />
						</div>	
                         <div class="form-group">
							<label class="control-label" for="numeroAulasPraticas;">Num. Aulas Praticas</label>
							<input id="numeroAulasPraticas" type="text" class="form-control" runat="server" />
						</div>	
						<div class="form-group">
                            <asp:Button ID="AtualizarDisciplina" runat="server" text="Atualizar Disciplina"  
                                class="btn btn-info btn-block" OnClick="AtualizarDisciplina_Click" />
						</div>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    </form>
</body>
</html>
