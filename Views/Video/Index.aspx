﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Videos</title>
</head>
<body>
    <div>

         <h1>Lista de videos encontrados</h1>
        <hr />
         <a href="/Home/Index">Volver</a>
         Hay  <%: ((System.Data.DataTable)ViewData["video"]).Rows.Count %>   videos
    <br />
    <%
        foreach (System.Data.DataRow ren in ((System.Data.DataTable)ViewData["video"]).Rows)
        { %>

        <p>    <%: ren ["titulo"].ToString() %>     </p>
        <iframe width="560" height="315" src="<%: ren["url"].ToString() %>"
        frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope;
        picture-in-picture" allowfullscreen></iframe>

     <%   }
     %>
    </div>
</body>
</html>
