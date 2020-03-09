<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mi Youtube</title>
</head>
<body>
    <div>
        <h1> Opciones </h1>
        <hr />
        <a href="/Video/Index">Ver Video</a>
        <hr />
        <a href="/Agregar/create">Agregar Videos</a>
        <hr />
        <a href="/Eliminar/delete">Eliminar Video</a>
        <hr />
        <a href="/Modificar/edit">Modificar Videos</a>
    </div>
</body>
</html>
