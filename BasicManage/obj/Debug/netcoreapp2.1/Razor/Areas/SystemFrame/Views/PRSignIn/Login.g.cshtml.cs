#pragma checksum "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\PRSignIn\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb9a6bcb0b0298436c80aca2a20c5de7b80755a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemFrame_Views_PRSignIn_Login), @"mvc.1.0.view", @"/Areas/SystemFrame/Views/PRSignIn/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemFrame/Views/PRSignIn/Login.cshtml", typeof(AspNetCore.Areas_SystemFrame_Views_PRSignIn_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9a6bcb0b0298436c80aca2a20c5de7b80755a2", @"/Areas/SystemFrame/Views/PRSignIn/Login.cshtml")]
    public class Areas_SystemFrame_Views_PRSignIn_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onkeydown", new global::Microsoft.AspNetCore.Html.HtmlString("keyDownFunc()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("overflow:hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/md5.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sha1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\PRSignIn\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(56, 1432, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "836dede68f174cbbac6a4b4d8350276b", async() => {
                BeginContext(62, 339, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">
    <script type=""application/x-javascript""> addEventListener(""load"", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <link rel=""stylesheet""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 401, "\"", 439, 1);
#line 12 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\PRSignIn\Login.cshtml"
WriteAttributeValue("", 408, Url.Content("~/Css/style.css"), 408, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(440, 421, true);
                WriteLiteral(@" type=""text/css"" media=""all"">
    <title>登录</title>
    <style>
        html, body, .full {
            width: 100%;
            height: 100%;
            margin: 0;
            padding: 0;
        }

        .full {
            background: #aaa;
            position: absolute;
            top: 0;
            left: 0;
        }
    </style>
    <style>
        .banner {
            background: url(""");
                EndContext();
                BeginContext(862, 15, false);
#line 31 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\PRSignIn\Login.cshtml"
                        Write(ViewBag.SysDown);

#line default
#line hidden
                EndContext();
                BeginContext(878, 62, false);
#line 31 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\PRSignIn\Login.cshtml"
                                        Write(ViewBag.BgImgs[new Random().Next(ViewBag.BgImgs.Count)].ImgUrl);

#line default
#line hidden
                EndContext();
                BeginContext(940, 541, true);
                WriteLiteral(@""");
            position:fixed;
            top: 0;
            left: 0;
            width:100%;
            height:100%;
            min-width: 1000px;
            background-color: #fff;
            background-repeat: no-repeat;
            background-size: cover;
            -webkit-background-size: cover;
            -o-background-size: cover;
            background-position: center 0;
            color: #FFF;
            font-family: 'Quicksand', sans-serif;
            text-align: center;
        }
    </style>
");
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
            BeginContext(1488, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1490, 984, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3fef51eecf84b6d8cf0113ac730df2f", async() => {
                BeginContext(1546, 81, true);
                WriteLiteral("\r\n    <div class=\"banner\">\r\n        <div class=\"agileinfo-dot\">\r\n            <h1>");
                EndContext();
                BeginContext(1628, 19, false);
#line 53 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\PRSignIn\Login.cshtml"
           Write(ViewBag.System_Name);

#line default
#line hidden
                EndContext();
                BeginContext(1647, 673, true);
                WriteLiteral(@"</h1>
            <div class=""layoutscontainer"">
                <h2>登  录</h2>
                <form action=""#"" method=""post"">
                    <input type=""text"" name=""Username"" id=""Username"" placeholder=""用户名"" required="""">
                    <input type=""password"" name=""Password"" id=""Password"" placeholder=""密码"" required="""">
                    <div class=""aitssendbuttonw3ls"">
                        <input type=""button"" id=""loginBtn"" value=""登  录"" onclick=""mlogin();"">
                        <div class=""clear""></div>
                    </div>
                </form>
            </div>


            <div class=""w3footeragile"">
                <p> ");
                EndContext();
                BeginContext(2321, 19, false);
#line 68 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\PRSignIn\Login.cshtml"
               Write(ViewBag.LoginFooter);

#line default
#line hidden
                EndContext();
                BeginContext(2340, 127, true);
                WriteLiteral(" | Design by <a href=\"http://w3layouts.com\" target=\"_blank\">W3layouts</a></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2474, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
            BeginContext(2485, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48a6828343de41c6b4dce251c038d848", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2528, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2530, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c808c584a4ed4e458570066b5c4124cb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2572, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2574, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ba316ccd16548d7b59e77a1fff8ce99", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2609, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2611, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4c2e4345bd94e83a5eba40fab9e1cfe", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2647, 1465, true);
            WriteLiteral(@"
<script>
    var layer;
    var logincount = 0;
    //var bgurl = """";
    //$("".banner"").css({ ""background"": ""url("" + bgurl + "")"", ""background-repeat"": ""no-repeat"", ""background-attachment"": ""fixed"" });
    layui.use('layer', function () {
        layer = layui.layer;
    });

    function openPage() {
        layer.open({
            title: '',
            type: 2,
            content: '../../bb_checklogin.html',
            time: 30000,
            area: ['100%', '100%'],
            closeBtn: false
        });
        logincount = 0;
    }
    function mlogin() {
        if (logincount >= 3) {
            openPage();
        }
        else {
            var loadingFlag = layer.load(1, {
                shade: [0.2, '#fff'] //0.1透明度的白色背景
            });
            var username = $(""#Username"").val();
            var password = $(""#Password"").val();
            if (username == """") {
                layer.tips('请输入用户名', '#Username', {
                    tips: [2, '#ff0000'],");
            WriteLiteral(@"
                    time: 3000
                });
                return;
            }
            if (password == """") {
                layer.tips('请输入密码', '#Password', {
                    tips: [2, '#ff0000'],
                    time: 3000
                });
                return;
            }
            var encodestr = hex_md5(password);
            encodestr = hex_sha1(encodestr);
            var actionurl = """);
            EndContext();
            BeginContext(4113, 37, false);
#line 124 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\PRSignIn\Login.cshtml"
                        Write(Url.Action("LoginConfirm","PRSignIn"));

#line default
#line hidden
            EndContext();
            BeginContext(4150, 858, true);
            WriteLiteral(@""";
            $.ajax(
                {
                    async: false,
                    type: 'POST',
                    url: actionurl,
                    data:
                        {
                            username: username,
                            pwd: encodestr
                        },
                    success: function (datafield) {
                        layer.close(loadingFlag);
                        if (datafield == ""用户名或密码错误"") {
                            logincount++;
                            layer.alert(""用户名或密码错误"", {
                                icon: 2,
                                closeBtn: false,
                                title: '警告'
                            });
                        }
                        else {
                            location.href = """);
            EndContext();
            BeginContext(5009, 26, false);
#line 146 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\PRSignIn\Login.cshtml"
                                        Write(Url.Action("Index","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(5035, 563, true);
            WriteLiteral(@""";
                        }
                    },
                    error: function () {
                        layer.close(loadingFlag);
                        layer.alert(""网络连接超时"", {
                            icon: 2,
                            closeBtn: false,
                            title: '警告'
                        });
                    }
                }
                );
        }
    }
    function keyDownFunc() {
        if (event.keyCode == 13)  //回车键的键值为13
            mlogin(); //调用登录按钮的登录事件
    }
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
