#pragma checksum "D:\Dev\Monetiza\Monetiza\Views\Clientes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efdd4f4b96b3938729ba9ddb6095d86457a9da25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Create), @"mvc.1.0.view", @"/Views/Clientes/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efdd4f4b96b3938729ba9ddb6095d86457a9da25", @"/Views/Clientes/Create.cshtml")]
    public class Views_Clientes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Monetiza.Models.Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Dev\Monetiza\Monetiza\Views\Clientes\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Cliente</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""DscNome"" class=""control-label""></label>
                <input asp-for=""DscNome"" class=""form-control"" />
                <span asp-validation-for=""DscNome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NumDoc"" class=""control-label""></label>
                <input asp-for=""NumDoc"" class=""form-control"" />
                <span asp-validation-for=""NumDoc"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DscTelefone"" class=""control-label""></label>
                <input asp-for=""DscTelefone"" class=""form-control"" />
                <span asp-validation-for=""DscTelefone"" class=""text-danger""></s");
            WriteLiteral(@"pan>
            </div>
            <div class=""form-group"">
                <label asp-for=""DscEmail"" class=""control-label""></label>
                <input asp-for=""DscEmail"" class=""form-control"" />
                <span asp-validation-for=""DscEmail"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DscEndereco"" class=""control-label""></label>
                <input asp-for=""DscEndereco"" class=""form-control"" />
                <span asp-validation-for=""DscEndereco"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DscCidade"" class=""control-label""></label>
                <input asp-for=""DscCidade"" class=""form-control"" />
                <span asp-validation-for=""DscCidade"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SglEstado"" class=""control-label""></label>
                <input asp-for=""S");
            WriteLiteral(@"glEstado"" class=""form-control"" />
                <span asp-validation-for=""SglEstado"" class=""text-danger""></span>
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
#line 62 "D:\Dev\Monetiza\Monetiza\Views\Clientes\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Monetiza.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591