#pragma checksum "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\AdminDashboard\AdminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a43c8b1b89f261073ab5d649ad287885b64dfbd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminDashboard_AdminDashboard), @"mvc.1.0.view", @"/Views/AdminDashboard/AdminDashboard.cshtml")]
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
#line 2 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\_ViewImports.cshtml"
using SmartHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\_ViewImports.cshtml"
using SmartHome.Database;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a43c8b1b89f261073ab5d649ad287885b64dfbd4", @"/Views/AdminDashboard/AdminDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffbb6578e3838bb4fa2541836239a894ce9a3f47", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminDashboard_AdminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kullanicilar>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\AdminDashboard\AdminDashboard.cshtml"
  
    ViewData["Title"] = "AdminDashboard";
    Layout = "~/Views/Shared/AdminDashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table id=\"table\">\r\n\r\n    <tr>\r\n        <th> Ad</th>\r\n        <th> E-Posta</th>\r\n        <th>Mesaj</th>\r\n        <th> Durum</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\AdminDashboard\AdminDashboard.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"veriler\">\r\n");
            WriteLiteral("\r\n            <td>");
#nullable restore
#line 21 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\AdminDashboard\AdminDashboard.cshtml"
           Write(item.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\AdminDashboard\AdminDashboard.cshtml"
           Write(item.Posta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\AdminDashboard\AdminDashboard.cshtml"
           Write(item.Mesaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 658, "\"", 698, 2);
            WriteAttributeValue("", 665, "/AdminDashboard/MesajSil/", 665, 25, true);
#nullable restore
#line 25 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\AdminDashboard\AdminDashboard.cshtml"
WriteAttributeValue("", 690, item.Id, 690, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTERİ\SmartHome\SmartHome\SmartHome\Views\AdminDashboard\AdminDashboard.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Kullanicilar>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
