<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GradeCurricular.ascx.cs" Inherits="TDE_TEC_PROG_ll.GradeCurricular" %>

     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="nome_curso"  HeaderText="Nome Curso"/>
            <asp:BoundField DataField="numero_periodo" HeaderText="Numero Periodo"/>
            <asp:BoundField DataField="nome_disciplina" HeaderText="Nome Disciplina"/>
             <asp:BoundField DataField="total" HeaderText="Total horas aulas teoricas"/>
        </Columns>
        </asp:GridView>
