#pragma checksum "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27190c090dc966c1db2f452b276e0c150d5f7ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Banner2Index), @"mvc.1.0.view", @"/Views/Home/Banner2Index.cshtml")]
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
#line 1 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\_ViewImports.cshtml"
using SmartHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\_ViewImports.cshtml"
using SmartHome.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
using SmartHome.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27190c090dc966c1db2f452b276e0c150d5f7ec9", @"/Views/Home/Banner2Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffbb6578e3838bb4fa2541836239a894ce9a3f47", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Banner2Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Banner2>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n  <section class=\"banner2\">\r\n      <div class=\"container\">\r\n          \r\n\r\n");
#nullable restore
#line 8 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
           foreach (var x in Model)
          {


#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"bn2text\">");
#nullable restore
#line 11 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
                              Write(x.Bn2text);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n");
            WriteLiteral("              <div class=\"ust\">\r\n                  <div class=\"card-a\">\r\n                      <div class=\"a1 tumicon\">\r\n                          <img src=\"img/m1.jpg\" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 420, "\"", 426, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                      </div>\r\n                      <div class=\"card-body\">\r\n                          <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
                                          Write(x.CardText1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                      </div>\r\n                  </div>\r\n\r\n\r\n                  <div class=\"card-a\">\r\n                      <div class=\"b1 tumicon\">\r\n                          <img src=\"img/m2.jpg\" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 788, "\"", 794, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                      </div>\r\n                      <div class=\"card-body\">\r\n                          <p class=\"card-text\">");
#nullable restore
#line 29 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
                                          Write(x.CardText2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                      </div>\r\n                  </div>\r\n\r\n                  <div class=\"card-a\">\r\n                      <div class=\"c1 tumicon\">\r\n                          <img src=\"img/m3.jpg\" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 1154, "\"", 1160, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                      </div>\r\n                      <div class=\"card-body\">\r\n                          <p class=\"card-text\">");
#nullable restore
#line 38 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
                                          Write(x.CardText3);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                      </div>\r\n                  </div>\r\n\r\n                  <div class=\"card-a\">\r\n                      <div class=\"d1 tumicon\">\r\n                          <img src=\"img/m4.jpg\" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 1521, "\"", 1527, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                      </div>\r\n                      <div class=\"card-body\">\r\n                          <p class=\"card-text\">");
#nullable restore
#line 47 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
                                          Write(x.CardText4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n              </div>\r\n\r\n\r\n          </div>\r\n");
            WriteLiteral("          <div class=\"alt\">\r\n\r\n              <div class=\"card-a\">\r\n                  <div class=\"e1 tumicon\">\r\n                      <img src=\"img/m5.jpg\" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 1922, "\"", 1928, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                  </div>\r\n                  <div class=\"card-body\">\r\n                      <p class=\"card-text\">");
#nullable restore
#line 62 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
                                      Write(x.CardText5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n              </div>\r\n\r\n\r\n              <div class=\"card-a\">\r\n                  <div class=\"f1 tumicon\">\r\n                      <img src=\"img/m6.jpg\" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 2258, "\"", 2264, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                  </div>\r\n                  <div class=\"card-body\">\r\n                      <p class=\"card-text\">");
#nullable restore
#line 72 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
                                      Write(x.CardText6);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n              </div>\r\n              <div class=\"card-a\">\r\n                  <div class=\"g1 tumicon\">\r\n                      <img src=\"img/m7.jpg\" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 2590, "\"", 2596, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                  </div>\r\n                  <div class=\"card-body\">\r\n                      <p class=\"card-text\">");
#nullable restore
#line 80 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
                                      Write(x.CardText7);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n              </div>\r\n              <div class=\"card-a\">\r\n                  <div class=\"h1 tumicon\">\r\n                      <img src=\"img/m8.jpg\" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 2922, "\"", 2928, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                  </div>\r\n                  <div class=\"card-body\">\r\n                      <p class=\"card-text\">");
#nullable restore
#line 88 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
                                      Write(x.CardText8);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n              </div>\r\n\r\n          </div>\r\n");
#nullable restore
#line 93 "C:\Users\lenovo\Desktop\DALISTO\YAZIIMSTAJPROJE\YAZILIMSTAJdEFTER─░\SmartHome\SmartHome\SmartHome\Views\Home\Banner2Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n        \r\n    </section>\r\n   \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Banner2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
