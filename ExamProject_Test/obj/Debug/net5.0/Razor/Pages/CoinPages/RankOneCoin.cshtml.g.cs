#pragma checksum "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c4cfab5e0a795b16f7fb3f96b51f73aadab8ca3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_CoinPages_RankOneCoin), @"mvc.1.0.razor-page", @"/Pages/CoinPages/RankOneCoin.cshtml")]
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
#line 2 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
using ExamProject_Test.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4cfab5e0a795b16f7fb3f96b51f73aadab8ca3", @"/Pages/CoinPages/RankOneCoin.cshtml")]
    public class Pages_CoinPages_RankOneCoin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
  
    CoinGeckoController CGC = new();
    var topTenCoins = await CGC.GetTopTenCoins();
    var topOneCoin = await CGC.GetTopNCoin(topTenCoins[0].Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c4cfab5e0a795b16f7fb3f96b51f73aadab8ca33173", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 10 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
      Write(topOneCoin.Name);

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
#line 13 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
                    Write(topOneCoin.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Rank of the coin: ");
#nullable restore
#line 14 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
                    Write(topOneCoin.MarketCapRank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Price of the coin: ");
#nullable restore
#line 15 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
                     Write(topTenCoins[0].CurrentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 16 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
  Write(topOneCoin.MarketData.PriceChangePercentage7DInCurrency["usd"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    <div class=""CoinPageContent"">
        <div class=""TopGrid"">

            <div class=""TopGridItem"">
                <div class=""BasicInfo"">
                    <p class=""CoinRank"">Rank #2</p>
                    <div class=""CoinImageName"">
                        <img class=""CoinImage""");
            BeginWriteAttribute("src", " src=", 858, "", 886, 1);
#nullable restore
#line 24 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
WriteAttributeValue("", 863, topOneCoin.Image.Small, 863, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p class=\"CoinName\">");
#nullable restore
#line 24 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
                                                                                          Write(topOneCoin.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 24 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
                                                                                                            Write(topOneCoin.Symbol.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n                    </div>\r\n                    <div class=\"CoinPriceAndChange\">\r\n                        <p class=\"CoinPrice\">$");
#nullable restore
#line 27 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
                                         Write(topOneCoin.MarketData.CurrentPrice["usd"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"CoinPriceChange\">");
#nullable restore
#line 27 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
                                                                                                                 Write(topOneCoin.MarketData.MarketCapChange24HInCurrency["usd"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span></p>
                    </div>

                    <div>
                        
                    </div>
                    
                </div>
            </div>

            <div class=""TopGridItem"">
                <div class=""InfoGrid"">
                    <div class=""InfoGridItem"">Info</div>
                    <div class=""InfoGridItem""></div>


                    <div class=""InfoGridItem"">
                        <div class=""InfoCategory"">
                            Website
                        </div>
                    </div>
                    <div class=""InfoGridItem"">
                        <div class=""InfoItem"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1929, "\"", 1970, 1);
#nullable restore
#line 50 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
WriteAttributeValue("", 1936, topOneCoin.Links.Homepage.First(), 1936, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">ethereum.org</a>
                        </div>
                    </div>


                    <div class=""InfoGridItem"">
                        <div class=""InfoCategory"">
                            Explorers
                        </div>
                    </div>
                    <div class=""InfoGridItem"">
                        <div class=""InfoItem"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 2379, "\"", 2420, 1);
#nullable restore
#line 62 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
WriteAttributeValue("", 2386, topOneCoin.Links.Homepage.First(), 2386, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Etherscan</a>
                        </div>
                    </div>


                    <div class=""InfoGridItem"">
                        <div class=""InfoCategory"">
                            Wallets
                        </div>
                    </div>
                    <div class=""InfoGridItem"">
                        <div class=""InfoItem"">
                            <a href=""https://www.ledger.com/"">Ledger</a>
                        </div>
                        <div class=""InfoItem"">
                            <a href=""https://trezor.io/"">Trezor</a>
                        </div>
                        <div class=""InfoItem"">
                            <a href=""https://metamask.io/"">Metamask</a>
                        </div>
                        <div class=""InfoItem"">
                            <a href=""https://www.xdefi.io/"">Xdefi</a>
                        </div>
                        <div class=""InfoItem"">
                            <a href=""https:/");
            WriteLiteral(@"/coin98.net/"">Coin98</a>
                        </div>
                    </div>


                    <div class=""InfoGridItem"">
                        <div class=""InfoCategory"">
                            Community
                        </div>
                    </div>
                    <div class=""InfoGridItem"">
                        <div class=""InfoItem"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 3860, "\"", 3897, 1);
#nullable restore
#line 98 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
WriteAttributeValue("", 3867, topOneCoin.Links.SubredditUrl, 3867, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Reddit</a>\r\n                        </div>\r\n                        <div class=\"InfoItem\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4021, "\"", 4083, 2);
            WriteAttributeValue("", 4028, "https://twitter.com/", 4028, 20, true);
#nullable restore
#line 101 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
WriteAttributeValue("", 4048, topOneCoin.Links.TwitterScreenName, 4048, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Twitter</a>\r\n                        </div>\r\n                        <div class=\"InfoItem\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4208, "\"", 4274, 2);
            WriteAttributeValue("", 4215, "https://www.facebook.com/", 4215, 25, true);
#nullable restore
#line 104 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
WriteAttributeValue("", 4240, topOneCoin.Links.FacebookUsername, 4240, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Facebook</a>
                        </div>
                        <div class=""InfoItem"">
                            <a href=""https://discord.com/invite/CetY6Y4"">Discord</a>
                        </div>
                    </div>

                    <div class=""InfoGridItem"">
                        <div class=""InfoCategory"">
                            Source Code
                        </div>
                    </div>
                    <div class=""InfoGridItem"">
                        <div class=""InfoItem"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 4845, "\"", 4893, 1);
#nullable restore
#line 118 "D:\Work\School\Software develpoment\ExamProject\ExamProject_Test\ExamProject_Test\Pages\CoinPages\RankOneCoin.cshtml"
WriteAttributeValue("", 4852, topOneCoin.Links.ReposUrl.Github.First(), 4852, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Github</a>
                        </div>
                    </div>

                    <div class=""InfoGridItem"">
                        <div class=""InfoCategory"">
                            API id
                        </div>
                    </div>
                    <div class=""InfoGridItem"">
                        <div class=""InfoItem"">
                            ethereum
                        </div>
                    </div>
                </div>
            </div>
            <div class=""TopGridItem"">3</div>
            <div class=""TopGridItem"">4</div>
            <div class=""TopGridItem"">5</div>
            <div class=""TopGridItem"">6</div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamProject_Test.Pages.CoinPages.RankOneCoinModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExamProject_Test.Pages.CoinPages.RankOneCoinModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExamProject_Test.Pages.CoinPages.RankOneCoinModel>)PageContext?.ViewData;
        public ExamProject_Test.Pages.CoinPages.RankOneCoinModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
