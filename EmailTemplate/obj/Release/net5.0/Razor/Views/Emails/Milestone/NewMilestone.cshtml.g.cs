#pragma checksum "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b2ce972577c36ce0b652558b1930b689d54bba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emails_Milestone_NewMilestone), @"mvc.1.0.view", @"/Views/Emails/Milestone/NewMilestone.cshtml")]
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
#line 1 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
using EmailTemplate.Views.Emails.Milestone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
using EmailTemplate.Views.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b2ce972577c36ce0b652558b1930b689d54bba0", @"/Views/Emails/Milestone/NewMilestone.cshtml")]
    public class Views_Emails_Milestone_NewMilestone : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewMilestoneModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
  
    ViewData["EmailTitle"] = "Llongyfarchaiadau! Congratulations!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<p style=\"font-weight:bold\">\r\n    Helo ");
#nullable restore
#line 15 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
    Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n</p>\r\n\r\n<p>\r\n    Llongyfarchaiadau! Rydych wedi cyflawni ");
#nullable restore
#line 19 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
                                       Write(Model.Miles);

#line default
#line hidden
#nullable disable
            WriteLiteral(" milltir, ");
#nullable restore
#line 19 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
                                                             Write(Model.Steps);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cam, o gyfanswm o ");
#nullable restore
#line 19 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
                                                                                            Write(Model.HistoricalPlaceNameWelsh);

#line default
#line hidden
#nullable disable
            WriteLiteral(" milltir/cam o daith gerdded arfordir Cymru.\r\n</p>\r\n\r\n<p>\r\n    Croeso i ");
#nullable restore
#line 23 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
        Write(Model.TownNameWelsh);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 23 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
                              Write(Model.HistoricalPlaceNameWelsh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p style=\"font-weight:bold\">\r\n    Hanes:\r\n</p>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 31 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
Write(Model.TownInfoWelsh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<br />\r\n\r\n<p>\r\n    Mwynhewch gam nesaf eich taith gerdded ac arhoswch yn saff.\r\n</p>\r\n\r\n");
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<p style=\"font-weight:bold\">\r\n    Hello ");
#nullable restore
#line 46 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
     Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n</p>\r\n\r\n<p>\r\n    You have achieved ");
#nullable restore
#line 50 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
                 Write(Model.Miles);

#line default
#line hidden
#nullable disable
            WriteLiteral(" miles, ");
#nullable restore
#line 50 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
                                     Write(Model.Steps);

#line default
#line hidden
#nullable disable
            WriteLiteral(" steps, of the Gr8 Welsh walk goal of ");
#nullable restore
#line 50 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
                                                                                       Write(Model.HistoricalPlaceNameEnglish);

#line default
#line hidden
#nullable disable
            WriteLiteral(" miles/steps.\r\n</p>\r\n\r\n<p>\r\n    Welcome to ");
#nullable restore
#line 54 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
          Write(Model.TownNameEnglish);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 54 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
                                  Write(Model.HistoricalPlaceNameEnglish);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p style=\"font-weight:bold\">\r\n    History:\r\n</p>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 62 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
Write(Model.TownInfoEnglish);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<br />\r\n\r\n<p>\r\n    Enjoy the next stage of your walk and stay safe\r\n</p>\r\n\r\n<br />\r\n<br />\r\n\r\n<img");
            BeginWriteAttribute("src", " src=\"", 1308, "\"", 1314, 0);
            EndWriteAttribute();
            WriteLiteral(" cid:{0}\"\" alt=\"Milestone\" id=\"Milestone\" class=\"img-fluid\" style=\"display:block;\">\r\n\r\n<br />\r\n<br />\r\n\r\n<p style=\"font-weight:bold\">\r\n    Manylion / Details\r\n</p>\r\n\r\n<p>Cyfeiriad / Address:</p>\r\n\r\n");
#nullable restore
#line 85 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
 foreach (var addressDetails in Model.Address)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"Address\" style=\"margin:0px;\">");
#nullable restore
#line 87 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
                                      Write(addressDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 88 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 90 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
 if (Model.OpeningTimes != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"Opening\">Amseroedd agor / Opening Times:</p>\r\n");
#nullable restore
#line 93 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"

    for (int i = 0; i < Model.OpeningTimes.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"Opening\">");
#nullable restore
#line 96 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
                      Write(Model.OpeningTimes[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 97 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 100 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
 if (Model.Tel != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Ffôn / Tel: ");
#nullable restore
#line 102 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
              Write(Model.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 103 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 105 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
 if (Model.Email != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>E-bost / Email: ");
#nullable restore
#line 107 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 108 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 110 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
 if (Model.WebsiteLink != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Gwe / Web: ");
#nullable restore
#line 112 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
             Write(Model.WebsiteLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 113 "D:\Zaib\Documents\Areca Design\VirtualWelshWalk\EmailTemplate\Views\Emails\Milestone\NewMilestone.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewMilestoneModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
