#pragma checksum "D:\PROJETOS\.net\aueba\Views\Home\City.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "046b82b101a37f26101b850307977ab826ce57d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_City), @"mvc.1.0.view", @"/Views/Home/City.cshtml")]
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
#line 1 "D:\PROJETOS\.net\aueba\Views\_ViewImports.cshtml"
using aueba;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJETOS\.net\aueba\Views\_ViewImports.cshtml"
using aueba.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"046b82b101a37f26101b850307977ab826ce57d4", @"/Views/Home/City.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e9e631277dfb18a18fb0979e924e9e908040bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_City : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PROJETOS\.net\aueba\Views\Home\City.cshtml"
  
    string[] Cidades = new string [3];
    Cidades[0] = "São Paulo";
    Cidades[1] = "Rio de Janeiro";
    Cidades[2] = "Porto Alegre";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 7 "D:\PROJETOS\.net\aueba\Views\Home\City.cshtml"
          
            foreach(var Cidade in Cidades){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 9 "D:\PROJETOS\.net\aueba\Views\Home\City.cshtml"
               Write(Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 10 "D:\PROJETOS\.net\aueba\Views\Home\City.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
