<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderId" runat="server" Style="z-index: 1; top: 15px; position: absolute; width: 128px;" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" Style="z-index: 1; left: 96px; top: 15px; position: absolute; width: 128px; margin-bottom: 10px;"></asp:TextBox>

            <asp:Label ID="lblProductId" runat="server" Style="z-index: 1; top: 55px; position: absolute;" Text="Product ID"></asp:Label>
            <asp:TextBox ID="txtProdcutId" runat="server" Style="z-index: 1; left: 96px; top: 55px; position: absolute"></asp:TextBox>

            <asp:Label ID="lblCustomer" runat="server" Style="z-index: 1; top: 95px; position: absolute" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" Style="z-index: 1; left: 106px; top: 95px; position: absolute"></asp:TextBox>

            <asp:Label ID="lblProductQuantity" runat="server" Style="z-index: 1; top: 135px; position: absolute" Text="Product Quantity"></asp:Label>
            <asp:TextBox ID="txtProductQuantity" runat="server" Style="z-index: 1; left: 120px; top: 135px; position: absolute"></asp:TextBox>

            <asp:Label ID="lblStatus" runat="server" Style="z-index: 1; top: 175px; position: absolute" Text="Status"></asp:Label>
            <asp:TextBox ID="txtStatus" runat="server" Style="z-index: 1; left: 120px; top: 175px; position: absolute"></asp:TextBox>

            <asp:Label ID="lblOrderDate" runat="server" Style="z-index: 1; top: 215px; position: absolute" Text="Order Date"></asp:Label>
            <asp:TextBox ID="dateOrderDate" type="date" runat="server" Style="z-index: 1; left: 120px; top: 215px; position: absolute" ></asp:TextBox>


               <asp:CheckBox ID="chkIsCancelled" runat="server" Style="z-index: 1;  top: 255px; position: absolute" Text="Cancelled" />

                        <asp:Label ID="lblError" runat="server" Style="z-index: 1; top: 295px; position: absolute" Text=""></asp:Label>

                                    <asp:Button ID="btnOK" runat="server" Style="z-index: 1; top: 335px; position: absolute" Text="OK"></asp:Button>
                                                <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; top: 335px; left:50px; position: absolute" Text="Cancel"></asp:Button>




            
        </div>






    </form>
</body>
</html>
