#pragma checksum "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBInfo\HistoryNumberStatistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ed9c629e287ed0f13e410530479aee3ed5bac8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserArea_Views_DCBInfo_HistoryNumberStatistics), @"mvc.1.0.view", @"/Areas/UserArea/Views/DCBInfo/HistoryNumberStatistics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/UserArea/Views/DCBInfo/HistoryNumberStatistics.cshtml", typeof(AspNetCore.Areas_UserArea_Views_DCBInfo_HistoryNumberStatistics))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed9c629e287ed0f13e410530479aee3ed5bac8c", @"/Areas/UserArea/Views/DCBInfo/HistoryNumberStatistics.cshtml")]
    public class Areas_UserArea_Views_DCBInfo_HistoryNumberStatistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBInfo\HistoryNumberStatistics.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 439, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b755fd5c4cd54a0691df0f70f9282b4e", async() => {
                BeginContext(64, 97, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>历史号码统计</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 161, "\"", 208, 1);
#line 12 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBInfo\HistoryNumberStatistics.cshtml"
WriteAttributeValue("", 168, Url.Content("~/js/layui/css/layui.css"), 168, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(209, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 242, "\"", 282, 1);
#line 13 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBInfo\HistoryNumberStatistics.cshtml"
WriteAttributeValue("", 248, Url.Content("~/js/jquery.min.js"), 248, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(283, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 306, "\"", 347, 1);
#line 14 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBInfo\HistoryNumberStatistics.cshtml"
WriteAttributeValue("", 312, Url.Content("~/js/layui/layui.js"), 312, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(348, 21, true);
                WriteLiteral("></script>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 369, "\"", 406, 1);
#line 15 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBInfo\HistoryNumberStatistics.cshtml"
WriteAttributeValue("", 376, Url.Content("~/css/main.css"), 376, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(407, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 440, "\"", 477, 1);
#line 16 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBInfo\HistoryNumberStatistics.cshtml"
WriteAttributeValue("", 446, Url.Content("~/js/echarts.js"), 446, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(478, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(497, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(499, 1628, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec13b915fc78466b882d50f596aa3424", async() => {
                BeginContext(505, 1615, true);
                WriteLiteral(@"
    <div>
        <div class=""layui-form"">
            <div class=""layui-form-item"">
                <div class=""layui-inline"">
                    <label class=""layui-form-label"" style=""width:auto"">统计数据：</label>
                    <div class=""layui-input-block"">
                        <select name=""statType"" id=""statType"" lay-verify=""required"">
                            <option value=""1"">号码总体出现平均次数</option>
                            <option value=""2"">中奖号码平均次数</option>
                            <option value=""3"">号码总体出现平均次数差值</option>
                            <option value=""4"">中奖号码平均次数差值</option>
                            <option value=""5"">中奖号码次数平均值与总体差值</option>
                        </select>
                    </div>
                </div>
                <div class=""layui-inline"" style=""margin-right:0px;"">
                    <label class=""layui-form-label"" style=""width:auto"">统计期数（最近）：</label>
                    <div class=""layui-input-inline"" style=""width: 150px;"">
   ");
                WriteLiteral(@"                     <input type=""text"" name=""StatNum"" id=""StatNum"" lay-verify=""title"" autocomplete=""off"" class=""layui-input"" value=""100"">
                    </div>
                </div>
                <div class=""layui-inline"">
                    <div class=""layui-input-inline"">
                        <button class=""layui-btn"" id=""searchBtn"" onclick=""initData();""><i class=""layui-icon"">&#xe615;</i> 查 询</button>
                    </div>
                </div>
            </div>
        </div>
        <div id=""main"" style=""width: auto;height:800px;""></div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2127, 1827, true);
            WriteLiteral(@"
</html>
<script type=""text/javascript"">
    // 基于准备好的dom，初始化echarts实例
    var myChart = echarts.init(document.getElementById('main'));

    // 指定图表的配置项和数据
    var option = {
        title: {
            text: '双色球历史号码总体平均值分析图'
        },
        tooltip: {},
        legend: {
            data: [{
                name: '红球',
                textStyle: { color: ""red"" },
            },
            {
                name: '蓝球',
                textStyle: { color: ""blue"" }
            }
            ]
        }, 
        xAxis: {
            data: []
        },
        yAxis: {},
        series: [{
            name: '红球',
            type: 'line',
            itemStyle: {
                normal: {
                    color: 'red',
                    lineStyle: {
                        color: 'red'
                    }
                }
            },    
            data: []
        },
            {
                name: '蓝球',
                type: 'line',
            ");
            WriteLiteral(@"    itemStyle: {
                    normal: {
                        color: 'blue',
                        lineStyle: {
                            color: 'blue'
                        }
                    }
                },    
                data: []
            }
        ],
        dataZoom: [
        {   // 这个dataZoom组件，默认控制x轴。
            type: 'inside', // 这个 dataZoom 组件是 slider 型 dataZoom 组件
            start: 0,      // 左边在 10% 的位置。
            end: 100         // 右边在 60% 的位置。
        }
        ]
    };

    // 使用刚指定的配置项和数据显示图表。
    myChart.setOption(option);
    var dataoption;
    function initData() {
        myChart.showLoading();
        $.ajax(
             {
                 async: true,
                 type: 'POST',
                 url: '");
            EndContext();
            BeginContext(3955, 63, false);
#line 121 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBInfo\HistoryNumberStatistics.cshtml"
                  Write(Url.Action("GetAllAvgAppear", "DCBInfo",new { area="UserArea"}));

#line default
#line hidden
            EndContext();
            BeginContext(4018, 1571, true);
            WriteLiteral(@"',
                 data: {
                     StatNum: $(""#StatNum"").val(),
                     StatType: $(""#statType"").val()
                 },
                 dataType: 'json',
                 success: function (datafield) {
                     buildOption(datafield);
                 }
             }
             );
    }
    function buildOption(datamodel) {
        var categories = [];
        var redavgNums = [];
        var blueavgNums = [];
        $.each(datamodel, function (i) {
            categories.push(datamodel[i].IssueNumber);
            redavgNums.push(datamodel[i].RedAvgNum);
            blueavgNums.push(datamodel[i].BlueAvgNum);
        });
        dataoption = ({
            categorie: categories,
            redavgNum: redavgNums,
            blueavgNum: blueavgNums,
        });
        myChart.hideLoading();
        myChart.setOption({
            xAxis: {
                data: dataoption.categorie
            },
            series: [{
          ");
            WriteLiteral(@"      name: '红球',
                smooth: true,
                data: dataoption.redavgNum
            },
                {
                    name: '蓝球',
                    smooth: true,
                    data: dataoption.blueavgNum
                }
            ]
        });
    }
    $(document).ready(function () {
        layui.use(['layer', 'form'], function () {
            var layer = layui.layer;
            form = layui.form();
            form.render();
            initData();
        });
    });
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
