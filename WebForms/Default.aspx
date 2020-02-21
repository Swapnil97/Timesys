<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function getProducts() {
            $.getJSON("api/products",
                function (data) {
                    $('#products').empty(); // Clear the table body.

                    // Loop through the list of products.
                    $.each(data, function (key, val) {
                        // Add a table row for the product.
                        var row = '<td>' + val.Name + '</td><td>' + val.Salary + '</td><td>' + val.Category +'</td>';
                        $('<tr/>', { html: row })
                            // Append the name.
                            .appendTo($('#products'));
                    });
                });
        }
        $(document).ready(getProducts);
    </script>
    <h2>Products of Ness</h2>
    <table border="1">
        <thead>
            <tr>
                <th>Name</th>
                <th>Salary(In Lakhs)</th>
                <th>Category</th>
            </tr>
        </thead>
        <tbody id="products">
        </tbody>
    </table>
</asp:Content>
