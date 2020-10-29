#pragma checksum "D:\Dev\Monetiza\Monetiza\Views\Contas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "613f31cad3c2c3e52ad08b5db740630809bbb3e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contas_Create), @"mvc.1.0.view", @"/Views/Contas/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"613f31cad3c2c3e52ad08b5db740630809bbb3e5", @"/Views/Contas/Create.cshtml")]
    public class Views_Contas_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Monetiza.Models.Conta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Dev\Monetiza\Monetiza\Views\Contas\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Conta</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""DscConta"" class=""control-label""></label>
                <input asp-for=""DscConta"" class=""form-control"" />
                <span asp-validation-for=""DscConta"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DataCompra"" class=""control-label""></label>
                <input asp-for=""DataCompra"" class=""form-control"" />
                <span asp-validation-for=""DataCompra"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ValorOriginal"" class=""control-label""></label>
                <input asp-for=""ValorOriginal"" class=""form-control"" />
                <span asp-validation-for=""ValorOriginal"" clas");
            WriteLiteral(@"s=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DataPagamento"" class=""control-label""></label>
                <input asp-for=""DataPagamento"" class=""form-control"" />
                <span asp-validation-for=""DataPagamento"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DiasAtraso"" class=""control-label""></label>
                <input asp-for=""DiasAtraso"" class=""form-control"" />
                <span asp-validation-for=""DiasAtraso"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PercMultaAtraso"" class=""control-label""></label>
                <input asp-for=""PercMultaAtraso"" class=""form-control"" />
                <span asp-validation-for=""PercMultaAtraso"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ValorMultaAtraso"" class=""co");
            WriteLiteral(@"ntrol-label""></label>
                <input asp-for=""ValorMultaAtraso"" class=""form-control"" />
                <span asp-validation-for=""ValorMultaAtraso"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PercJurosDia"" class=""control-label""></label>
                <input asp-for=""PercJurosDia"" class=""form-control"" />
                <span asp-validation-for=""PercJurosDia"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ValorJurosDia"" class=""control-label""></label>
                <input asp-for=""ValorJurosDia"" class=""form-control"" />
                <span asp-validation-for=""ValorJurosDia"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ValorCorrigido"" class=""control-label""></label>
                <input asp-for=""ValorCorrigido"" class=""form-control"" />
                <span asp-validation-fo");
            WriteLiteral(@"r=""ValorCorrigido"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ClienteId"" class=""control-label""></label>
                <select asp-for=""ClienteId"" class =""form-control"" asp-items=""ViewBag.ClienteId""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 81 "D:\Dev\Monetiza\Monetiza\Views\Contas\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
