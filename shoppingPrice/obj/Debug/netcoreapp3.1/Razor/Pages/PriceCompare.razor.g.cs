#pragma checksum "D:\pra\shoppingPrice\shoppingPrice\Pages\PriceCompare.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec6dec70bab073d11b0f2a90a0aef3a19ce45b56"
// <auto-generated/>
#pragma warning disable 1591
namespace shoppingPrice.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\pra\shoppingPrice\shoppingPrice\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pra\shoppingPrice\shoppingPrice\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\pra\shoppingPrice\shoppingPrice\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\pra\shoppingPrice\shoppingPrice\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\pra\shoppingPrice\shoppingPrice\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\pra\shoppingPrice\shoppingPrice\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\pra\shoppingPrice\shoppingPrice\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\pra\shoppingPrice\shoppingPrice\_Imports.razor"
using shoppingPrice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\pra\shoppingPrice\shoppingPrice\_Imports.razor"
using shoppingPrice.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\pra\shoppingPrice\shoppingPrice\_Imports.razor"
using OpenQA.Selenium;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\pra\shoppingPrice\shoppingPrice\_Imports.razor"
using OpenQA.Selenium.Chrome;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/priceCompare")]
    public partial class PriceCompare : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>PriceCompare</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\pra\shoppingPrice\shoppingPrice\Pages\PriceCompare.razor"
                           IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<span class=\"btn btn-dark\">click</span>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, "<thead>\r\n        <tr>\r\n            <th>Product Name</th>\r\n            <th>Weight</th>\r\n            <th>ShopName</th>\r\n            <th>Rate</th>\r\n            <th>Total Payment</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n\r\n\r\n        ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\pra\shoppingPrice\shoppingPrice\Pages\PriceCompare.razor"
                              ProductName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ProductName = __value, ProductName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "D:\pra\shoppingPrice\shoppingPrice\Pages\PriceCompare.razor"
                              Weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Weight = __value, Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\pra\shoppingPrice\shoppingPrice\Pages\PriceCompare.razor"
                              ShopName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShopName = __value, ShopName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\pra\shoppingPrice\shoppingPrice\Pages\PriceCompare.razor"
                              Rate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Rate = __value, Rate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\pra\shoppingPrice\shoppingPrice\Pages\PriceCompare.razor"
                              Payment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Payment = __value, Payment));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\pra\shoppingPrice\shoppingPrice\Pages\PriceCompare.razor"
       
    private String ProductName = "";
    private Double Weight = 20;
    private String ShopName = "";
    private Double Rate = 0.02;
    private double Payment;

    void IncrementCount()
    {
        ChromeDriver ChromeDriver = new OpenQA.Selenium.Chrome.ChromeDriver();

        ChromeDriver.Navigate().GoToUrl("https://www.woolworths.com.au/");
        System.Threading.Thread.Sleep(4000);
        ChromeDriver.FindElement(By.Id("headerSearch")).Clear();
        System.Threading.Thread.Sleep(100);
        ChromeDriver.FindElement(By.Id("headerSearch")).SendKeys(ProductName);
        System.Threading.Thread.Sleep(100);
        ChromeDriver.FindElement(By.ClassName("search-button-icon")).Click();

        //ChromeDriver.Navigate().GoToUrl("https://www.coles.com.au/");
        //System.Threading.Thread.Sleep(4000);
        //ChromeDriver.FindElement(By.ClassName("search-toggle")).Click();
        //System.Threading.Thread.Sleep(100);
        //ChromeDriver.FindElement(By.ClassName("search-input")).Clear();
        //ChromeDriver.FindElement(By.ClassName("search-input")).SendKeys(ProductName);
        //System.Threading.Thread.Sleep(100);
        //ChromeDriver.FindElement(By.ClassName("search-button")).Click();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
