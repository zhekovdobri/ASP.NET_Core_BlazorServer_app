#pragma checksum "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bce00e2ca1c9400f2c21c301a34d8dc179a1a3ad"
// <auto-generated/>
#pragma warning disable 1591
namespace AddIdentity.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using AddIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using AddIdentity.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using AddIdentity.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using AddIdentity.Pages;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-p8w0xi74x4");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-p8w0xi74x4");
            __builder.OpenComponent<AddIdentity.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-p8w0xi74x4");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-p8w0xi74x4");
            __builder.AddMarkupContent(14, "<img class=\"navbar-brand logo\" src=\"/images/logo.png\" b-p8w0xi74x4>\r\n            ");
            __builder.OpenComponent<AddIdentity.Shared.LoginDisplay>(15);
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, " \r\n            ");
            __builder.AddMarkupContent(17, "<a href=\"https://jobzone.no/en/om-oss/organization/\" target=\"_blank\" b-p8w0xi74x4>About 🕮</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "content px-4");
            __builder.AddAttribute(21, "b-p8w0xi74x4");
#nullable restore
#line 15 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Shared\MainLayout.razor"
__builder.AddContent(22, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591