<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>edit</title>
</head>
<body>
    <form action="/Video/edit" method ="post" >
    <fieldset>
    <h1>EDITAR VIDEO</h1>
    <legend> DATOS DEL VIDEO PARA EDITAR</legend>
    <label for ="idVideo">idVideo</label>
    <input type="text" name ="idVideo"/>

     <label for ="titulo">Titulo</label>
    <input type="text" name ="titulo"/>

     <label for ="repro">Reproduciones</label>
    <input type="text" name ="repro"/>

     <label for ="url">url</label>
    <input type="text" name ="url"/> 

     <input type="submit" value ="Modificar"/>

    </fieldset>
    </form>
</body>
</html>
