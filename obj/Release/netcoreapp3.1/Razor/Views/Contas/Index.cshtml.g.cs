#pragma checksum "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e6e46480a916a29263ce638cb665952ce9bbf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contas_Index), @"mvc.1.0.view", @"/Views/Contas/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e6e46480a916a29263ce638cb665952ce9bbf6", @"/Views/Contas/Index.cshtml")]
    public class Views_Contas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Monetiza.Models.Conta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DscConta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ValorOriginal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataPagamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiasAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PercMultaAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ValorMultaAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PercJurosDia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ValorJurosDia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ValorCorrigido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 52 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DscConta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorOriginal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataPagamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiasAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PercMultaAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorMultaAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PercJurosDia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorJurosDia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorCorrigido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cliente.DscCidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2660, "\"", 2690, 1);
#nullable restore
#line 88 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
WriteAttributeValue("", 2675, item.CodCPagar, 2675, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2743, "\"", 2773, 1);
#nullable restore
#line 89 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
WriteAttributeValue("", 2758, item.CodCPagar, 2758, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2828, "\"", 2858, 1);
#nullable restore
#line 90 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
WriteAttributeValue("", 2843, item.CodCPagar, 2843, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 93 "D:\Dev\Monetiza\Monetiza\Views\Contas\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Monetiza.Models.Conta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
