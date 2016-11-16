<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DisciplinaBuscar.ascx.cs" Inherits="TDE_TEC_PROG_ll.DisciplinaBuscar" %>

<link href="Content/bootstrap.css" rel="stylesheet" />
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<script src="Scripts/jquery-3.1.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>

<div class="container">
		<div class="row">
			<div class="panel panel-primary">
				<div class="panel-body">
						<div class="form-group">
							<h2>Buscar Disciplina</h2>
						</div>

						<div class="form-group">
							<label class="control-label" for="nomeDisciplina">Nome Disciplina</label>
							<input id="nomeDisciplina" type="text" maxlength="50" class="form-control" 
                                runat="server">
						</div>
						
						<div class="form-group">
                            <asp:Button ID="buscarDisciplina" runat="server" text="Buscar" 
                                class="btn btn-info btn-block" OnClick="buscarDisciplina_Click" />
						</div>

                        <div class="form-group">
                            <asp:DropDownList id="ddlSubject" AppendDataBoundItems="true" 
                                OnInit="ddlSubject_Load" runat="server"></asp:DropDownList>
                        </div>	

                        <asp:Panel ID="disciplinasEncontradas" runat="server" />
				</div>
			</div>
		</div>
	</div>