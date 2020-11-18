<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="databaseservices.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Database Services API Site</title>
</head>
<body>
    <form id="form1" runat="server">
        <div><H>
            Welcome <%=UserName%>

            UserID <%=HttpContext.Current.User.Identity.Name %>
            </H>
        </div>
    </form>
</body>
</html>
