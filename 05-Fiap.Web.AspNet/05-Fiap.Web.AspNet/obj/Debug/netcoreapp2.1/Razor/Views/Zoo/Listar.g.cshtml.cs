#pragma checksum "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1bbe158cb5f1724061fc8deda8ff222eb6356b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zoo_Listar), @"mvc.1.0.view", @"/Views/Zoo/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Zoo/Listar.cshtml", typeof(AspNetCore.Views_Zoo_Listar))]
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
#line 1 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _05_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _05_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1bbe158cb5f1724061fc8deda8ff222eb6356b", @"/Views/Zoo/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"269873a930527f28ca0fb92f300679416b9399e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Zoo_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Zoo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::_05_Fiap.Web.AspNet.TagHelpers.MensagemTagHelper ___05_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(64, 21, true);
            WriteLiteral("\r\n<h2>Listar</h2>\r\n\r\n");
            EndContext();
            BeginContext(85, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("mensagem", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f7ac828c914497fb26d39d3fb62e9e8", async() => {
            }
            );
            ___05_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper = CreateTagHelper<global::_05_Fiap.Web.AspNet.TagHelpers.MensagemTagHelper>();
            __tagHelperExecutionContext.Add(___05_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper);
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
     WriteLiteral(TempData["msg"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            ___05_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper.Texto = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("texto", ___05_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper.Texto, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(131, 178, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Jaulas</th>\r\n        <th>Tipo</th>\r\n        <th>Data Abertura</th>\r\n        <th>Opções</th>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 20 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(350, 14, true);
            WriteLiteral("<tr>\r\n    <td>");
            EndContext();
            BeginContext(365, 9, false);
#line 23 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(374, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(390, 11, false);
#line 24 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
   Write(item.Jaulas);

#line default
#line hidden
            EndContext();
            BeginContext(401, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(417, 27, false);
#line 25 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
   Write(item.EntidadeAdministradora);

#line default
#line hidden
            EndContext();
            BeginContext(444, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(460, 37, false);
#line 26 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
   Write(item.DataAbertura.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(497, 25, true);
            WriteLiteral("</td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(522, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc1fedcfd742403aac1f39ced33aaa5e", async() => {
                BeginContext(571, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
                                 WriteLiteral(item.Zooo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(581, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(591, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7523be257f3746fa957b91a076290c6f", async() => {
                BeginContext(641, 7, true);
                WriteLiteral("Remover");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
                                  WriteLiteral(item.Zooo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(652, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(727, 20, true);
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
            EndContext();
#line 34 "C:\Users\logonrmlocal\Desktop\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"

    }

#line default
#line hidden
            BeginContext(756, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Zoo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
