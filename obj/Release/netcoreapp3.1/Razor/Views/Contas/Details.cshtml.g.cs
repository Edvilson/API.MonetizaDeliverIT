#pragma checksum "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ffabe6c86c8a78c887041998ba294abc51abcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contas_Details), @"mvc.1.0.view", @"/Views/Contas/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ffabe6c86c8a78c887041998ba294abc51abcb", @"/Views/Contas/Details.cshtml")]
    public class Views_Contas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Monetiza.Models.Conta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Conta</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DscConta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayFor(model => model.DscConta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorOriginal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValorOriginal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataPagamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataPagamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiasAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiasAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PercMultaAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayFor(model => model.PercMultaAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorMultaAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValorMultaAtraso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PercJurosDia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayFor(model => model.PercJurosDia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorJurosDia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValorJurosDia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorCorrigido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValorCorrigido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cliente.DscCidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2625, "\"", 2656, 1);
#nullable restore
#line 82 "D:\Dev\Monetiza\Monetiza\Views\Contas\Details.cshtml"
WriteAttributeValue("", 2640, Model.CodCPagar, 2640, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Monetiza.Models.Conta> Html { get; private set; }
    }
}
#pragma warning restore 1591