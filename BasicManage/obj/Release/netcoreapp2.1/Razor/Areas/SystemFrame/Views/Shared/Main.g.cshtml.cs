#pragma checksum "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e22a9c3a8475bd1a7df4bae807d568448e86225"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemFrame_Views_Shared_Main), @"mvc.1.0.view", @"/Areas/SystemFrame/Views/Shared/Main.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemFrame/Views/Shared/Main.cshtml", typeof(AspNetCore.Areas_SystemFrame_Views_Shared_Main))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e22a9c3a8475bd1a7df4bae807d568448e86225", @"/Areas/SystemFrame/Views/Shared/Main.cshtml")]
    public class Areas_SystemFrame_Views_Shared_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(64, 470, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1627c499c5114e2ebd62dc2ebe333cca", async() => {
                BeginContext(70, 150, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no\">\r\n    <title>");
                EndContext();
                BeginContext(221, 19, false);
#line 10 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
      Write(ViewBag.System_Name);

#line default
#line hidden
                EndContext();
                BeginContext(240, 19, true);
                WriteLiteral("</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 259, "\"", 306, 1);
#line 11 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
WriteAttributeValue("", 266, Url.Content("~/js/layui/css/layui.css"), 266, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(307, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 340, "\"", 380, 1);
#line 12 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
WriteAttributeValue("", 346, Url.Content("~/js/jquery.min.js"), 346, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(381, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 404, "\"", 445, 1);
#line 13 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
WriteAttributeValue("", 410, Url.Content("~/js/layui/layui.js"), 410, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(446, 21, true);
                WriteLiteral("></script>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 467, "\"", 504, 1);
#line 14 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
WriteAttributeValue("", 474, Url.Content("~/css/main.css"), 474, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(505, 22, true);
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
            BeginContext(534, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(536, 2510, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1941449bc29f4f9cbe14e905406fb3fb", async() => {
                BeginContext(542, 287, true);
                WriteLiteral(@"
    <!-- 布局容器 -->
    <div class=""layui-layout layui-layout-admin"">
        <!-- 头部 -->
        <div class=""layui-header"">
            <div class=""layui-main "">
                <!-- logo -->
                <a href=""#"" style=""color: #c2c2c2; font-size: 18px; line-height: 60px;"">");
                EndContext();
                BeginContext(830, 19, false);
#line 23 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
                                                                                   Write(ViewBag.System_Name);

#line default
#line hidden
                EndContext();
                BeginContext(849, 216, true);
                WriteLiteral("</a>\r\n                <!-- 水平导航 -->\r\n                <ul class=\"layui-nav\" style=\"position: absolute; top: 0; right: 0; background: none;\">\r\n                    <li class=\"layui-nav-item\">\r\n                        <a");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1065, "\"", 1119, 3);
                WriteAttributeValue("", 1075, "topClick(&quot;", 1075, 15, true);
#line 27 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
WriteAttributeValue("", 1090, ViewBag.RoleIndexPage, 1090, 22, false);

#line default
#line hidden
                WriteAttributeValue("", 1112, "&quot;)", 1112, 7, true);
                EndWriteAttribute();
                BeginContext(1120, 240, true);
                WriteLiteral(" href=\"javascript:;\">\r\n                            返回首页\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"layui-nav-item\">\r\n                        <a href=\"javascript:;\">\r\n                            ");
                EndContext();
                BeginContext(1361, 58, false);
#line 33 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
                       Write(LotteryAnalysisManage.Tool.UserInfo.GetInstance().NickName);

#line default
#line hidden
                EndContext();
                BeginContext(1419, 174, true);
                WriteLiteral("\r\n                        </a>\r\n                        <dl class=\"layui-nav-child\">\r\n                            <dd>\r\n                                <a href=\"javascript:;\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1593, "\"", 1670, 3);
                WriteAttributeValue("", 1603, "myInfo(\'", 1603, 8, true);
#line 37 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
WriteAttributeValue("", 1611, LotteryAnalysisManage.Tool.UserInfo.GetInstance().UserId, 1611, 57, false);

#line default
#line hidden
                WriteAttributeValue("", 1668, "\')", 1668, 2, true);
                EndWriteAttribute();
                BeginContext(1671, 206, true);
                WriteLiteral(">\r\n                                    个人信息\r\n                                </a>\r\n                            </dd>\r\n                            <dd>\r\n                                <a href=\"javascript:;\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1877, "\"", 1955, 3);
                WriteAttributeValue("", 1887, "editPwd(\'", 1887, 9, true);
#line 42 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
WriteAttributeValue("", 1896, LotteryAnalysisManage.Tool.UserInfo.GetInstance().UserId, 1896, 57, false);

#line default
#line hidden
                WriteAttributeValue("", 1953, "\')", 1953, 2, true);
                EndWriteAttribute();
                BeginContext(1956, 1034, true);
                WriteLiteral(@">
                                    修改密码
                                </a>
                            </dd>
                            <dd>
                                <a href=""javascript:;"" onclick=""signOut();"">
                                    退出登录
                                </a>
                            </dd>
                        </dl>
                    </li>
                </ul>
            </div>
        </div>
        <!-- 侧边栏 -->
        <div class=""layui-side layui-bg-black"">
            <div class=""layui-side-scroll"">
                <ul class=""layui-nav layui-nav-tree"" id=""MainNode"">
                   
                </ul>
            </div>
        </div>
        <!-- 主体 -->
        <div class=""layui-body"" id=""MainBody"">
            <iframe id=""MainFrame"" frameborder=""0"" scrolling=""auto"" width=""100%"" height=""99%"" ></iframe>
        </div>
        <!-- 底部 -->
        <div class=""layui-footer"" style=""text-align: center; line-height: 44px;"">
  ");
                WriteLiteral("          ");
                EndContext();
                BeginContext(2991, 18, false);
#line 70 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
       Write(ViewBag.MainFooter);

#line default
#line hidden
                EndContext();
                BeginContext(3009, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(3046, 235, true);
            WriteLiteral("\r\n</html>\r\n<script>\r\n    var layer;\r\n    function loadPower() {\r\n        $.ajax(\r\n                {\r\n                    async: false,\r\n                    type: \'POST\',\r\n                    dataType:\'json\',\r\n                    url: \'");
            EndContext();
            BeginContext(3282, 60, false);
#line 83 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
                     Write(Url.Action("GetPower", "Home", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(3342, 1779, true);
            WriteLiteral(@"',
                    data:{},
                    success: function (datafield) {
                        bindPower(datafield);
                        layui.use('element', function () {
                            var element = layui.element();

                        });
                        }
                }
                );
    }
    
    function bindPower(data) {
        var htmlstr = """";
        $.each(data, function (i) {
            if (data[i].ParentNode == null || data[i].ParentNode == """") {
                htmlstr += ""<li class='layui-nav-item'>""
                    + ""<a href='javascript:;' >"" + data[i].NodeName + ""<span class='layui-nav-more'></span></a>""
                    + ""<dl class='layui-nav-child'>"";
                $.each(data, function (j) {
                    if (data[j].ParentNode == data[i].NodeId) {
                        htmlstr += ""<dd><a href='javascript:;' onclick='LoadMainBody(&quot;"" + data[j].NodeUrl + ""&quot;)'>"" + data[j].NodeName + ""</a><");
            WriteLiteral(@"/dd>"";
                    }
                });
                htmlstr += ""</dl>""
                    + ""</li>"";
            }
        });
        $(""#MainNode"").html(htmlstr);
    }
    function LoadMainBody(strurl) {
        if (strurl == """") {
            return;
        }
        //var lindex = layer.load(0, {
        //    shade: [0.2, '#fff'] //0.1透明度的白色背景
        //});
        htmlobj = $.ajax({ url: strurl, async: false });
        //$(""#MainBody"").html(htmlobj.responseText);
        $(""#MainFrame"").prop(""src"", strurl);
        //layer.close(lindex);
    }
    $(document).ready(function () {
        layui.use('layer', function () {
            layer = layui.layer;
            loadPower();
            topClick(""");
            EndContext();
            BeginContext(5122, 21, false);
#line 130 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
                 Write(ViewBag.RoleIndexPage);

#line default
#line hidden
            EndContext();
            BeginContext(5143, 244, true);
            WriteLiteral("\");\r\n        });\r\n    });\r\n    function myInfo(userid) {\r\n        layer.open({\r\n            type: 2,\r\n            title: \'用户信息维护\',\r\n            shade: 0.8,\r\n            closeBtn: 0,\r\n            area: [\'600px\', \'500px\'],\r\n            content: \'");
            EndContext();
            BeginContext(5388, 60, false);
#line 140 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
                 Write(Url.Action("EditPage", "UserInfo",new { area="SystemFrame"}));

#line default
#line hidden
            EndContext();
            BeginContext(5448, 263, true);
            WriteLiteral(@"?UserId=' + userid + ''
        });
    }
    function editPwd(userid) {
        layer.open({
            type: 2,
            title: '用户密码维护',
            shade: 0.8,
            closeBtn: 0,
            area: ['600px', '300px'],
            content: '");
            EndContext();
            BeginContext(5712, 63, false);
#line 150 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
                 Write(Url.Action("PwdPage", "UserInfo", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(5775, 234, true);
            WriteLiteral("?UserId=\' + userid + \'\'\r\n        });\r\n    }\r\n    function initData() { }\r\n\r\n    function signOut() {\r\n        $.ajax(\r\n                {\r\n                    async: false,\r\n                    type: \'POST\',\r\n                    url: \'");
            EndContext();
            BeginContext(6010, 59, false);
#line 160 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
                     Write(Url.Action("SignOut", "Home", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(6069, 136, true);
            WriteLiteral("\',\r\n                    data: {},\r\n                    success: function (datafield) {\r\n                        window.location.href = \"");
            EndContext();
            BeginContext(6206, 60, false);
#line 163 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
                                           Write(Url.Action("Login","PRSignIn", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(6266, 163, true);
            WriteLiteral("\";  \r\n                    }\r\n                }\r\n                );\r\n    }\r\n    function topClick(strurl) {\r\n        if (strurl == \"\") {\r\n            LoadMainBody(\"");
            EndContext();
            BeginContext(6430, 63, false);
#line 170 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\Shared\Main.cshtml"
                     Write(Url.Action("NormalIndex","OverView", new { area = "UserArea" }));

#line default
#line hidden
            EndContext();
            BeginContext(6493, 96, true);
            WriteLiteral("\");\r\n        }\r\n        else {\r\n            LoadMainBody(strurl);\r\n        }\r\n    }\r\n</script>\r\n");
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
