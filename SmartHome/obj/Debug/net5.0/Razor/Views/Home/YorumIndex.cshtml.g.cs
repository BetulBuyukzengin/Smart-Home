#pragma checksum "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\Home\YorumIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4e057c8a1f1e5207bafb53f99521d3078ba9582"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_YorumIndex), @"mvc.1.0.view", @"/Views/Home/YorumIndex.cshtml")]
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
#line 1 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\_ViewImports.cshtml"
using SmartHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\_ViewImports.cshtml"
using SmartHome.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\Home\YorumIndex.cshtml"
using SmartHome.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e057c8a1f1e5207bafb53f99521d3078ba9582", @"/Views/Home/YorumIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffbb6578e3838bb4fa2541836239a894ce9a3f47", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_YorumIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Yorum>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\Home\YorumIndex.cshtml"
 foreach (var n in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"yorum\">\r\n\r\n    <div class=\"etiket\">");
#nullable restore
#line 9 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\Home\YorumIndex.cshtml"
                   Write(n.Etiket);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n    <div class=\"etiketbaslik\">");
#nullable restore
#line 10 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\Home\YorumIndex.cshtml"
                         Write(n.Etiketbaslik);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n\r\n    <div class=\"yorumcard\">\r\n\r\n        <div class=\"card-b1\">\r\n            <span class=\"fa\"></span>\r\n            <div class=\"card-text\">\r\n                <p class=\"card-text1\">");
#nullable restore
#line 17 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\Home\YorumIndex.cshtml"
                                 Write(n.Cardtext1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"sahibi\">");
#nullable restore
#line 18 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\Home\YorumIndex.cshtml"
                             Write(n.Sahibi1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"card-b1\">\r\n            <span class=\"fa\"></span>\r\n            <p class=\"card-text2\">");
#nullable restore
#line 26 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\Home\YorumIndex.cshtml"
                             Write(n.Cardtext2);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"sahibi\">");
#nullable restore
#line 26 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\Home\YorumIndex.cshtml"
                                                           Write(n.Sahibi2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </p>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n");
#nullable restore
#line 34 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\Home\YorumIndex.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Yorum>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591