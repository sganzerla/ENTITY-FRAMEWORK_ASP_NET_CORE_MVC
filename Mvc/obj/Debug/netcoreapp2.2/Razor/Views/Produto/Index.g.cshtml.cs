#pragma checksum "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a72492d61bb666ee51fa507a1bf94c9c56bb970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Index.cshtml", typeof(AspNetCore.Views_Produto_Index))]
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
#line 1 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\_ViewImports.cshtml"
using Mvc;

#line default
#line hidden
#line 2 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a72492d61bb666ee51fa507a1bf94c9c56bb970", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14c947c23ce1723f7843b90231a2951c10e8cb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Entidades.Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 362, true);
            WriteLiteral(@"
    <h2>Todos Produtos</h2>
    <a href=""/Produto/Salvar"" class=""btn"">Novo Produto</a>
    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Nome</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 14 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Produto\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(482, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(545, 9, false);
#line 17 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Produto\Index.cshtml"
                           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(554, 41, true);
            WriteLiteral("</td>\r\n                              <td>");
            EndContext();
            BeginContext(596, 19, false);
#line 18 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Produto\Index.cshtml"
                             Write(item.Categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(615, 41, true);
            WriteLiteral("</td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 656, "\"", 687, 2);
            WriteAttributeValue("", 663, "/Produto/Editar/", 663, 16, true);
#line 19 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Produto\Index.cshtml"
WriteAttributeValue("", 679, item.Id, 679, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(688, 93, true);
            WriteLiteral(" class=\"btn\">Editar</a></td>                             \r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 781, "\"", 813, 2);
            WriteAttributeValue("", 788, "/Produto/Deletar/", 788, 17, true);
#line 20 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Produto\Index.cshtml"
WriteAttributeValue("", 805, item.Id, 805, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(814, 62, true);
            WriteLiteral(" class=\"btn\">Deletar</a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 22 "C:\Users\alisson-pc\Documents\Cursos Udemy\aspnet-core-aprendendo-do-zero-ao-avancado\modulo4\Mvc\Views\Produto\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(899, 74, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.Entidades.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591