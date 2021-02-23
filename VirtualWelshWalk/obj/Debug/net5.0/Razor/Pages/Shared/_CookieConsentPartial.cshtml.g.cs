#pragma checksum "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\Shared\_CookieConsentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4ec87aa80459c944e1e05a19a20457eefa16f7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared__CookieConsentPartial), @"mvc.1.0.view", @"/Pages/Shared/_CookieConsentPartial.cshtml")]
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
#line 1 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\_ViewImports.cshtml"
using VirtualWelshWalk.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\Shared\_CookieConsentPartial.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4ec87aa80459c944e1e05a19a20457eefa16f7a", @"/Pages/Shared/_CookieConsentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f16930aa5d558e3a093c308e0cec7a00ac4d90b4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__CookieConsentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\Shared\_CookieConsentPartial.cshtml"
  
    var consentFeature = Context.Features.Get<ITrackingConsentFeature>();
    var showBanner = !consentFeature?.CanTrack ?? false;
    var cookieString = consentFeature?.CreateConsentCookie();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\Shared\_CookieConsentPartial.cshtml"
 if (showBanner)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"cookieConsent\" class=\"alert alert-info alert-dismissible fade show m-0\" role=\"alert\">\r\n        <p style=\"padding-right:3em;\">");
#nullable restore
#line 12 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\Shared\_CookieConsentPartial.cshtml"
                                 Write(Localizer["This website uses cookies and requires your consent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"privacy-policy\">");
#nullable restore
#line 12 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\Shared\_CookieConsentPartial.cshtml"
                                                                                                                            Write(Localizer["Learn More"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>.</p>\r\n        <button type=\"button\" class=\"accept-policy close\" data-dismiss=\"alert\" aria-label=\"Close\" data-cookie-string=\"");
#nullable restore
#line 13 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\Shared\_CookieConsentPartial.cshtml"
                                                                                                                 Write(cookieString);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
            <span aria-hidden=""true"">Accept</span>
        </button>
    </div>
    <script>
        (function () {
            var button = document.querySelector(""#cookieConsent button[data-cookie-string]"");
            button.addEventListener(""click"", function (event) {
                document.cookie = button.dataset.cookieString;
            }, false);
        })();
    </script>
");
#nullable restore
#line 25 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\VirtualWelshWalk\Pages\Shared\_CookieConsentPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<VirtualWelshWalk.App> Localizer { get; private set; }
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