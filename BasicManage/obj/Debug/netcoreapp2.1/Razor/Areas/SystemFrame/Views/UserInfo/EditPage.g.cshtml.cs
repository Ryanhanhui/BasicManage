#pragma checksum "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14924b804d036eb2f9821315d646ba2de5dbb655"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemFrame_Views_UserInfo_EditPage), @"mvc.1.0.view", @"/Areas/SystemFrame/Views/UserInfo/EditPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemFrame/Views/UserInfo/EditPage.cshtml", typeof(AspNetCore.Areas_SystemFrame_Views_UserInfo_EditPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14924b804d036eb2f9821315d646ba2de5dbb655", @"/Areas/SystemFrame/Views/UserInfo/EditPage.cshtml")]
    public class Areas_SystemFrame_Views_UserInfo_EditPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9d49dc8b6e041db87285eafa60d13df", async() => {
                BeginContext(64, 95, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>用户信息</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 159, "\"", 206, 1);
#line 12 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
WriteAttributeValue("", 166, Url.Content("~/js/layui/css/layui.css"), 166, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(207, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 240, "\"", 280, 1);
#line 13 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
WriteAttributeValue("", 246, Url.Content("~/js/jquery.min.js"), 246, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(281, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 304, "\"", 345, 1);
#line 14 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
WriteAttributeValue("", 310, Url.Content("~/js/layui/layui.js"), 310, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(346, 12, true);
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
            BeginContext(365, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(367, 2905, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0cb5b1e8f9c4d759eb24e5a0a53d6d9", async() => {
                BeginContext(373, 406, true);
                WriteLiteral(@"
    <div style=""margin-top:20px;"">
        <div class=""layui-form"">
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">用户名</label>
                <div class=""layui-input-block"">
                    <input type=""text"" id=""UserId"" name=""UserId"" autocomplete=""off"" lay-verify=""required"" placeholder=""请输入用户名"" class=""layui-input"" style=""width:400px"" maxlength=""24""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 779, "\"", 808, 1);
#line 22 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
WriteAttributeValue("", 787, ViewBag.Model.UserId, 787, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(809, 383, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">昵称</label>
                <div class=""layui-input-block"">
                    <input type=""text"" id=""NickName"" name=""NickName"" autocomplete=""off"" lay-verify=""required"" placeholder=""请输入昵称"" class=""layui-input"" style=""width:400px"" maxlength=""32""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1192, "\"", 1223, 1);
#line 28 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
WriteAttributeValue("", 1200, ViewBag.Model.NickName, 1200, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1224, 375, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">姓名</label>
                <div class=""layui-input-block"">
                    <input type=""text"" id=""Name"" name=""Name"" autocomplete=""off"" lay-verify=""required"" placeholder=""请输入姓名"" class=""layui-input"" style=""width:400px"" maxlength=""32""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1599, "\"", 1626, 1);
#line 34 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
WriteAttributeValue("", 1607, ViewBag.Model.Name, 1607, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1627, 744, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">性别</label>
                <div class=""layui-input-inline"">
                    <input type=""radio"" name=""Sex"" id=""Sex1"" value=""1"" title=""男"" checked="""">
                    <input type=""radio"" name=""Sex"" id=""Sex0"" value=""0"" title=""女"">
                </div>
            </div>
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">年龄</label>
                <div class=""layui-input-block"">
                    <input type=""text"" id=""Age"" name=""Age"" autocomplete=""off"" lay-verify=""number"" placeholder=""请输入年龄"" class=""layui-input"" style=""width:150px"" maxlength=""3""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2371, "\"", 2397, 1);
#line 47 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
WriteAttributeValue("", 2379, ViewBag.Model.Age, 2379, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2398, 352, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">备注</label>
                <div class=""layui-input-block"">
                    <input type=""text"" id=""Remark"" name=""Remark"" autocomplete=""off"" placeholder="""" class=""layui-input"" style=""width:400px"" maxlength=""64""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2750, "\"", 2779, 1);
#line 53 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
WriteAttributeValue("", 2758, ViewBag.Model.Remark, 2758, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2780, 412, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""layui-form-item"">
                <div style=""text-align:center"">
                    <button class=""layui-btn layui-btn-normal"" lay-submit >保  存</button>
                    <button class=""layui-btn layui-btn-warm"" onclick=""cancelBtnClick()"">关  闭</button>
                </div>
            </div>
            <input id=""Id"" name=""Id""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3192, "\"", 3217, 1);
#line 62 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
WriteAttributeValue("", 3200, ViewBag.Model.Id, 3200, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3218, 47, true);
                WriteLiteral(" type=\"hidden\" />\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(3272, 40, true);
            WriteLiteral("\r\n</html>\r\n<script>\r\n    var rstatus = \"");
            EndContext();
            BeginContext(3313, 15, false);
#line 68 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
              Write(ViewBag.RStatus);

#line default
#line hidden
            EndContext();
            BeginContext(3328, 49, true);
            WriteLiteral("\";\r\n    if (rstatus == \"edit\") {\r\n        rid = \"");
            EndContext();
            BeginContext(3378, 11, false);
#line 70 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
          Write(ViewBag.RId);

#line default
#line hidden
            EndContext();
            BeginContext(3389, 130, true);
            WriteLiteral("\";\r\n        $(\"#UserId\").prop(\"class\", \"layui-input layui-disabled\");\r\n        $(\"#UserId\").prop(\"disabled\", true);\r\n        if (\"");
            EndContext();
            BeginContext(3520, 17, false);
#line 73 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
        Write(ViewBag.Model.Sex);

#line default
#line hidden
            EndContext();
            BeginContext(3537, 196, true);
            WriteLiteral("\" == \"0\") {\r\n            document.getElementById(\"Sex1\").removeAttribute(\"checked\");\r\n            document.getElementById(\"Sex0\").setAttribute(\"checked\", \"checked\");\r\n        }\r\n        else if (\"");
            EndContext();
            BeginContext(3734, 17, false);
#line 77 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
             Write(ViewBag.Model.Sex);

#line default
#line hidden
            EndContext();
            BeginContext(3751, 1040, true);
            WriteLiteral(@""" == ""1"") {
            document.getElementById(""Sex0"").removeAttribute(""checked"");
            document.getElementById(""Sex1"").setAttribute(""checked"", ""checked"");
        }
    }
    $(document).ready(function () {
        layui.use(['layer', 'form'], function () {
            var layer = layui.layer;
            form = layui.form();
            form.render();

            form.on('submit', function (data) {
                saveBtnClick(data);
                return false;
            });

        });
    });
    function cancelBtnClick() {
        var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
        parent.initData();
        parent.layer.close(index); //再执行关闭
    }

    function saveBtnClick(datafield) {
        var loadingFlag = layer.load(1, {
            shade: [0.2, '#fff'] //0.1透明度的白色背景
        });
        if (rstatus == ""add"") {
            $.ajax(
                {
                    async: true,
                    type: 'POST',
          ");
            WriteLiteral("          url: \'");
            EndContext();
            BeginContext(4792, 59, false);
#line 110 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
                     Write(Url.Action("AddData", "UserInfo",new { area="SystemFrame"}));

#line default
#line hidden
            EndContext();
            BeginContext(4851, 1156, true);
            WriteLiteral(@"',
                    data: datafield.field,
                    success: function (datafield) {
                        layer.close(loadingFlag);
                        if (datafield == ""success"") {
                            layer.msg('保存成功', { icon: 1 });
                            //do something
                            $(""#UserId"").val("""");
                            $(""#NickName"").val("""");
                            $(""#Name"").val("""");
                            $(""#Age"").val("""");
                            $(""#Remark"").val("""");
                        }
                        else if (datafield == ""exists"") {
                            layer.msg('用户名重复，请重新输入！', { icon: 2 });
                            layer.tips('请输入用户名', '#UserId', {
                                tips: [2, '#ff0000'],
                                time: 3000
                            });
                        }
                    }
                }
                );
        } else {
   ");
            WriteLiteral("         $.ajax(\r\n                {\r\n                    async: true,\r\n                    type: \'POST\',\r\n                    url: \'");
            EndContext();
            BeginContext(6008, 66, false);
#line 138 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\EditPage.cshtml"
                     Write(Url.Action("UpdateData", "UserInfo", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(6074, 492, true);
            WriteLiteral(@"',
                    data:datafield.field,
                    success: function (datafield) {
                        layer.close(loadingFlag);
                        if (datafield == ""success"") {
                            layer.msg('保存成功', { icon: 1 });
                        }
                    }
                }
                );
        }
    }
    function VerifyValid(obj,checkstr) {
        
    }
    function clearValue() {
        
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
