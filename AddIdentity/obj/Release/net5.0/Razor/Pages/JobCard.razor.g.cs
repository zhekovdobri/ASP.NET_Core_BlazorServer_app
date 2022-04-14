#pragma checksum "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\JobCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "587fe302326bdba0372b9b3f19d83a9d85f7e264"
// <auto-generated/>
#pragma warning disable 1591
namespace AddIdentity.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/jobcard")]
    public partial class JobCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.OpenElement(2, "img");
            __builder.AddAttribute(3, "src", 
#nullable restore
#line 4 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\JobCard.razor"
               Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "class", "card-img-top");
            __builder.AddAttribute(5, "alt", "employ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenElement(9, "h5");
            __builder.AddAttribute(10, "class", "card-title font-weight-bold");
#nullable restore
#line 6 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\JobCard.razor"
__builder.AddContent(11, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "list-group list-group-flush");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "list-group-item");
            __builder.AddContent(17, "Place:");
#nullable restore
#line 8 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\JobCard.razor"
__builder.AddContent(18, Place);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "list-group-item");
            __builder.AddContent(22, "Number of positions:");
#nullable restore
#line 9 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\JobCard.razor"
__builder.AddContent(23, Count);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "list-group-item");
            __builder.AddContent(27, "Application deadline:");
#nullable restore
#line 10 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\JobCard.razor"
__builder.AddContent(28, Deadline);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col text-center pt-2");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", 
#nullable restore
#line 13 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\JobCard.razor"
                      Link

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "btn btn-danger w-100");
            __builder.AddContent(35, "Learn More");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\JobCard.razor"
       

    [Parameter]
    public string Image { get; set; }

    [Parameter] 
    public string Title { get; set; }

    [Parameter] 
    public string Place { get; set; }

    [Parameter] 
    public int Count { get; set; }

    [Parameter] 
    public string Deadline { get; set; }

    [Parameter]
    public string Link { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591