#pragma checksum "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "169407c73559e2f3ca62e1603ed87ed72863087c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserArea_Views_DCBImport_Index), @"mvc.1.0.view", @"/Areas/UserArea/Views/DCBImport/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/UserArea/Views/DCBImport/Index.cshtml", typeof(AspNetCore.Areas_UserArea_Views_DCBImport_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169407c73559e2f3ca62e1603ed87ed72863087c", @"/Areas/UserArea/Views/DCBImport/Index.cshtml")]
    public class Areas_UserArea_Views_DCBImport_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(54, 442, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b261627dbc49446bbbf4136858be478c", async() => {
                BeginContext(60, 101, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>双色球历史数据导入页</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 161, "\"", 208, 1);
#line 10 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml"
WriteAttributeValue("", 168, Url.Content("~/js/layui/css/layui.css"), 168, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(209, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 242, "\"", 282, 1);
#line 11 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml"
WriteAttributeValue("", 248, Url.Content("~/js/jquery.min.js"), 248, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(283, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 306, "\"", 347, 1);
#line 12 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml"
WriteAttributeValue("", 312, Url.Content("~/js/layui/layui.js"), 312, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(348, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 371, "\"", 407, 1);
#line 13 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml"
WriteAttributeValue("", 377, Url.Content("~/js/public.js"), 377, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(408, 21, true);
                WriteLiteral("></script>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 429, "\"", 466, 1);
#line 14 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml"
WriteAttributeValue("", 436, Url.Content("~/css/main.css"), 436, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(467, 22, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
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
            BeginContext(496, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(498, 2489, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e9b98e8e3bd44878aa60eab844d4dfe", async() => {
                BeginContext(504, 513, true);
                WriteLiteral(@"
    <fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
        <legend>双色球历史数据导入</legend>
    </fieldset>
    <fieldset class=""layui-elem-field"">
        <legend>导入说明</legend>
        <div class=""layui-field-box"">
            <span style=""color:red"">
                导入信息依次为：期号、开奖日期、红球1号码、红球2号码、红球3号码、红球4号码、红球5号码、红球6号码、蓝球号码；<br />
                注意事项：1、期号不能重复；2、开奖日期为日期格式；3、期号、红球、蓝球号码只能为数字，红球1~33，蓝球1~16；<br />
            </span>
            提供样表模版，请严格按照样表格式和注意事项进行填写。<a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1017, "\"", 1065, 1);
#line 27 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml"
WriteAttributeValue("", 1024, Url.Content("~/TempTable/双色球历史数据样表.xls"), 1024, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1066, 1914, true);
                WriteLiteral(@" style=""text-decoration:underline"">样表下载</a>
        </div>
    </fieldset>
    <fieldset class=""layui-elem-field"">
        <legend>上传导入文件</legend>
        <div class=""layui-field-box"">
            <div class=""layui-form"">
                <div class=""layui-form-item"">
                    <input type=""file"" name=""excelfile"" id=""importfile"" lay-title=""上传EXCEL表格文件"" lay-type=""file"" lay-ext=""xls|xlsx"">
                </div>
            </div>
        </div>
    </fieldset>
    <fieldset class=""layui-elem-field"" id=""previewfield"" style=""display:none"">
        <legend>
            导入信息预览  <span id=""dataStatSp"" style=""color:red""></span><button class=""layui-btn layui-btn-normal "" id=""checkBtn"" style=""margin-left:20px;display:none"" onclick=""checkClick()""><i class=""layui-icon"">&#xe63c;</i> 检测数据</button>
            <button class=""layui-btn layui-btn-normal"" id=""importBtn"" style=""margin-left: 20px; display: none"" onclick=""importClick()""><i class=""layui-icon"">&#xe62f;</i> 导入数据</button>
        </legend>
");
                WriteLiteral(@"        <div class=""layui-field-box"">
            <table class=""layui-table"" lay-even="""">
                <thead>
                    <tr>
                        <th style=""width:10%"">期号</th>
                        <th style=""width:15%"">开奖日期</th>
                        <th style=""width:8%"">红球1号码</th>
                        <th style=""width:8%"">红球2号码</th>
                        <th style=""width:8%"">红球3号码</th>
                        <th style=""width:8%"">红球4号码</th>
                        <th style=""width:8%"">红球5号码</th>
                        <th style=""width:8%"">红球6号码</th>
                        <th style=""width:8%"">蓝球号码</th>
                        <th id=""descriptionCell"">说明</th>
                    </tr>
                </thead>
                <tbody id=""tableBody""></tbody>
            </table>
        </div>
    </fieldset>
    <div>
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
            BeginContext(2987, 246, true);
            WriteLiteral("\r\n</html>\r\n<script>\r\n    var pagecount, form, layer, laypage;\r\n    var pagesize = 15;\r\n    layui.use([\'form\', \'layer\',\'upload\'], function () {\r\n        form = layui.form();\r\n        layer = layui.layer;\r\n        layui.upload({\r\n            url: \'");
            EndContext();
            BeginContext(3234, 62, false);
#line 76 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml"
             Write(Url.Action("GetExcelData", "DCBImport",new { area="UserArea"}));

#line default
#line hidden
            EndContext();
            BeginContext(3296, 721, true);
            WriteLiteral(@"',
            elem: '#importfile',
            method: 'post',
            before: function () {
                loadingFlag = layer.msg('正在读取数据，请稍候……', { icon: 16, shade: 0.01, shadeClose: false });
            },
            success: function (resdata,input) {
                $(""#previewfield"").show();
                $(""#checkBtn"").show();
                bindTable(resdata);
                layer.close(loadingFlag);
            }
        });
    });
    function queryCheckData() {
        loadingFlag = layer.msg('正在检测数据中，请稍候……', { icon: 16, shade: 0.01, shadeClose: false });
        $.ajax(
            {
                async: true,
                    type: 'POST',
                url: '");
            EndContext();
            BeginContext(4018, 65, false);
#line 96 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml"
                 Write(Url.Action("CheckImportData", "DCBImport",new { area="UserArea"}));

#line default
#line hidden
            EndContext();
            BeginContext(4083, 2583, true);
            WriteLiteral(@"',
                    success: function (datafield) {
                        bindCheckDataTable(JSON.parse(datafield));
                        layer.close(loadingFlag);
                    }
                }
                );
    }
    function bindTable(data) {
        $(""#descriptionCell"").hide();
        var tablehtml = """";
        var items = data;
        $.each(items, function (i) {
            tablehtml += ""<tr>""
                + ""<td>"" + parseValue(items[i].IssueNumber) + ""</td>""
                + ""<td>"" + parseValue(items[i].OpenDate) + ""</td>""
                + ""<td>"" + parseValue(items[i].RedNumber1) + ""</td>""
                + ""<td>"" + parseValue(items[i].RedNumber2) + ""</td>""
                + ""<td>"" + parseValue(items[i].RedNumber3) + ""</td>""
                + ""<td>"" + parseValue(items[i].RedNumber4) + ""</td>""
                + ""<td>"" + parseValue(items[i].RedNumber5) + ""</td>""
                + ""<td>"" + parseValue(items[i].RedNumber6) + ""</td>""
                + ""<td");
            WriteLiteral(@">"" + parseValue(items[i].BlueNumber) + ""</td>""
        + ""</tr>"";
        });
        $(""#tableBody"").html(tablehtml);
    }
    function parseValue(value) {
        if (value == null)
            return """";
        else
            return value;
    }
    function checkClick() {
        queryCheckData();
        $(""#importBtn"").show();
    }
    function bindCheckDataTable(data) {
        $(""#descriptionCell"").show();
        var tablehtml = """";
        var items = data;
        $.each(items, function (i) {
            tablehtml += ""<tr>""
                + ""<td>"" + parseValue(items[i].IssueNumber) + ""</td>""
                + ""<td>"" + parseValue(items[i].OpenDate) + ""</td>""
                + ""<td>"" + parseValue(items[i].RedNumber1) + ""</td>""
                + ""<td>"" + parseValue(items[i].RedNumber2) + ""</td>""
                + ""<td>"" + parseValue(items[i].RedNumber3) + ""</td>""
                + ""<td>"" + parseValue(items[i].RedNumber4) + ""</td>""
                + ""<td>"" + parseValue(");
            WriteLiteral(@"items[i].RedNumber5) + ""</td>""
                + ""<td>"" + parseValue(items[i].RedNumber6) + ""</td>""
                + ""<td>"" + parseValue(items[i].BlueNumber) + ""</td>""
                + ""<td style='color:red'>"" + parseValue(items[i].Remarks) + ""</td>""
        + ""</tr>"";
        });
        $(""#tableBody"").html(tablehtml);
        getDataStatCount();
    }
    function getDataStatCount() {
        $.ajax(
                {
                    async: false,
                    type: 'POST',
                    url: '");
            EndContext();
            BeginContext(6667, 66, false);
#line 159 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml"
                     Write(Url.Action("GetDataStatCount", "DCBImport",new { area="UserArea"}));

#line default
#line hidden
            EndContext();
            BeginContext(6733, 525, true);
            WriteLiteral(@"',
                success: function (datafield) {
                    $(""#dataStatSp"").text(""（有效数据："" + datafield.split('|')[0] + "" 条，不可导入数据："" + datafield.split('|')[1] + "" 条）"")
                    }
                }
                );
    }
    function importClick() {
        loadingFlag = layer.msg('正在导入数据中，请稍候……', { icon: 16, shade: 0.01, shadeClose: false });
        $.ajax(
                    {
                        async: false,
                        type: 'POST',
                        url: '");
            EndContext();
            BeginContext(7259, 60, false);
#line 172 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\UserArea\Views\DCBImport\Index.cshtml"
                         Write(Url.Action("ImportData", "DCBImport",new { area="UserArea"}));

#line default
#line hidden
            EndContext();
            BeginContext(7319, 1042, true);
            WriteLiteral(@"',
                        success: function (datafield) {
                            if (datafield == ""success"") {
                                $(""#checkBtn"").hide();
                                $(""#importBtn"").hide();
                                layer.msg(""导入数据成功"", {
                                    icon: 1, end: function () {
                                        window.location.href = window.location.href;
                                    }
                                });
                            } 
                            else {
                                layer.msg(datafield, {
                                    icon: 0, end: function () {
                                        window.location.href = window.location.href;
                                    }
                                });
                            }
                            layer.close(loadingFlag);
                        }
                    }
                    );");
            WriteLiteral("\r\n    }\r\n</script>");
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