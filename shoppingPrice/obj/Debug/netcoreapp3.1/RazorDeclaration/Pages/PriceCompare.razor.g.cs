#pragma checksum "D:\pra\shoppingPrice\shoppingPrice\Pages\PriceCompare.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec6dec70bab073d11b0f2a90a0aef3a19ce45b56"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
