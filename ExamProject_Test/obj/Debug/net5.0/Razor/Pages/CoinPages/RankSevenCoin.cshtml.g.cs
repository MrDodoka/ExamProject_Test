#pragma checksum "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankSevenCoin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "059423afa071112bfb7a370df3442056654ee96e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_CoinPages_RankSevenCoin), @"mvc.1.0.razor-page", @"/Pages/CoinPages/RankSevenCoin.cshtml")]
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
#line 2 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankSevenCoin.cshtml"
using ExamProject_Test.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"059423afa071112bfb7a370df3442056654ee96e", @"/Pages/CoinPages/RankSevenCoin.cshtml")]
    public class Pages_CoinPages_RankSevenCoin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankSevenCoin.cshtml"
  
    CoinGeckoController CGC = new();
    var topTenCoins = await CGC.GetTopTenCoins();
    var topSevenCoin = await CGC.GetTopNCoin(topTenCoins[6].Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "059423afa071112bfb7a370df3442056654ee96e3189", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 10 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankSevenCoin.cshtml"
      Write(topSevenCoin.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div>\r\n    <p>Name of the coin: ");
#nullable restore
#line 13 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankSevenCoin.cshtml"
                    Write(topSevenCoin.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Rank of the coin: ");
#nullable restore
#line 14 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankSevenCoin.cshtml"
                    Write(topSevenCoin.MarketCapRank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Price of the coin: ");
#nullable restore
#line 15 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankSevenCoin.cshtml"
                     Write(topTenCoins[6].CurrentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamProject_Test.Pages.CoinPages.RankSevenCoinModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExamProject_Test.Pages.CoinPages.RankSevenCoinModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExamProject_Test.Pages.CoinPages.RankSevenCoinModel>)PageContext?.ViewData;
        public ExamProject_Test.Pages.CoinPages.RankSevenCoinModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
