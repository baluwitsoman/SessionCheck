<%@ Page Language="C#" AutoEventWireup="true" EnableSessionState="False" Codefile="NoSessionPage.aspx.cs" Inherits="WebApplicationTest.NoSessionPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.4.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <asp:Button ID="Button1" runat="server" Text="call 2 web methods"
    OnClientClick="TestFun();return false;" />

<br />
Web1: 
<asp:TextBox ID="txtWeb1" runat="server" ClientIDMode="Static">
</asp:TextBox>
<br />
Web2: 
<asp:TextBox ID="txtWeb2" runat="server" ClientIDMode="Static">
</asp:TextBox>

<script>

    function TestFun() {

        tb1 = $('#txtWeb1')
        tb2 = $('#txtWeb2')
        tb1.val('')
        tb2.val('')

        // call web 1
        $.ajax({
            type: "POST",
            url: "NoSessionPage.aspx/Web1",
            data: {},
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                tb1.val(response.d)
            },
            error: function (xhr, status, error) {
                // Handle the error response
                console.log(error, status, xhr);
            }
        });

        $.ajax({
            type: "POST",
            url: "NoSessionPage.aspx/Web2",
            data: {},
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                tb2.val(response.d)
            },
            error: function (xhr, status, error) {
                // Handle the error response
                console.log(error, status, xhr);
            }
        });
    }

</script>

    </form>
</body>
</html>
