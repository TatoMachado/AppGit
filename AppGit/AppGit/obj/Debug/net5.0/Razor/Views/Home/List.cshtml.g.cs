#pragma checksum "C:\Users\Xeon\Documents\GitHub\AppGit\AppGit\AppGit\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f6e21a6f879f369cd96f014eb3abc918e02cf91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Xeon\Documents\GitHub\AppGit\AppGit\AppGit\Views\_ViewImports.cshtml"
using AppGit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Xeon\Documents\GitHub\AppGit\AppGit\AppGit\Views\_ViewImports.cshtml"
using AppGit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f6e21a6f879f369cd96f014eb3abc918e02cf91", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fc1708e880faf236f4f4aec37c60d40e1afac8b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Search>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Xeon\Documents\GitHub\AppGit\AppGit\AppGit\Views\Home\List.cshtml"
  
    ViewData["Title"] = "Home Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""h3 mb-2 text-gray-800"">Resultados</h1>
                    <p class=""mb-4"">Exibindo os resultados iniciais.</p>

                    <!-- DataTales Example -->
                    <div class=""card shadow mb-4"">
                        <div class=""card-header py-3"">
                            <h6 class=""m-0 font-weight-bold text-primary"">Total de Resultados</h6>
                            <h6 class=""m-0 font-weight-bold text-primary"">");
#nullable restore
#line 15 "C:\Users\Xeon\Documents\GitHub\AppGit\AppGit\AppGit\Views\Home\List.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => modelItem.total_count));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                        </div>
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                    <thead>
                                        <tr>
                                            <th>Name</th>
                                            <th>Owner</th>
                                            <th>Html Url</th>
                                            <th>Description</th>
                                        </tr>
                                    </thead>
                                    <tfoot>
                                        <tr>
                                            <th>Name</th>
                                            <th>Owner</th>
                                            <th>Html Url</th>
                                            <th>Descripti");
            WriteLiteral("on</th>\r\n                                        </tr>\r\n                                    </tfoot>\r\n                                    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Xeon\Documents\GitHub\AppGit\AppGit\AppGit\Views\Home\List.cshtml"
                                     foreach (var item in Model.items) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 39 "C:\Users\Xeon\Documents\GitHub\AppGit\AppGit\AppGit\Views\Home\List.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 40 "C:\Users\Xeon\Documents\GitHub\AppGit\AppGit\AppGit\Views\Home\List.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.owner.login));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 41 "C:\Users\Xeon\Documents\GitHub\AppGit\AppGit\AppGit\Views\Home\List.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.html_url));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 42 "C:\Users\Xeon\Documents\GitHub\AppGit\AppGit\AppGit\Views\Home\List.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Xeon\Documents\GitHub\AppGit\AppGit\AppGit\Views\Home\List.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Search> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
