#pragma checksum "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "026c13df1a460288e5b2f8669d3f13911ba76958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_getindBookings), @"mvc.1.0.view", @"/Views/Customer/getindBookings.cshtml")]
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
#line 1 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\_ViewImports.cshtml"
using FlightTicketReservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\_ViewImports.cshtml"
using FlightTicketReservation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"026c13df1a460288e5b2f8669d3f13911ba76958", @"/Views/Customer/getindBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"613e8586e4e155261a2894d4dd9498f4a304183a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_getindBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FlightTicketReservation.Models.BookingDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
  
    ViewData["Title"] = "getindBookings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>getindBookings</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Bookingid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Routeid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Doj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Numberofpassengers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Totalvalue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Customerid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bookingid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Routeid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Doj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Numberofpassengers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Totalvalue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customerid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\h.a.cme5\Desktop\FlightTicketReservation\Views\Customer\getindBookings.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FlightTicketReservation.Models.BookingDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
