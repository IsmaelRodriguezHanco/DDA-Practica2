﻿<%@ Master Language="C#" AutoEventWireup="true" CodeBehind="Site.master.cs" Inherits="ConversorDeTemperturas.SiteMaster" %>

<!DOCTYPE html>
<html>
	<head>
		<title>Conversor de temperatura</title>
	</head>
	<body>
		<form id="Form1" runat="server" method="POST" oninput="resultado.value=(parseFloat(valor.value)-32)/1.8">
		<div>
			<h1>Conversor de temperatura</h1>
			Convertir: &nbsp;
			<input type="number" id="valor" runat="server"/>
			&nbsp;Fahrenheith a Centigrados.
			<br/><br/>
			<p>Resultado: </p>&nbsp;
			<output id="Convertir" runat="server" name="resultado" for="valor"></output>
		</div>
		</form>
	</body>
</html>
