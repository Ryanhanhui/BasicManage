#pragma checksum "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\RoleSetPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "302378fe29695a6f60e937403f2c1f7ed8091747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemFrame_Views_UserInfo_RoleSetPage), @"mvc.1.0.view", @"/Areas/SystemFrame/Views/UserInfo/RoleSetPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemFrame/Views/UserInfo/RoleSetPage.cshtml", typeof(AspNetCore.Areas_SystemFrame_Views_UserInfo_RoleSetPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302378fe29695a6f60e937403f2c1f7ed8091747", @"/Areas/SystemFrame/Views/UserInfo/RoleSetPage.cshtml")]
    public class Areas_SystemFrame_Views_UserInfo_RoleSetPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\RoleSetPage.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(56, 309, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dacef2482e2642d397d9757d76cc313c", async() => {
                BeginContext(62, 97, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>用户角色配置</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 159, "\"", 206, 1);
#line 11 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\RoleSetPage.cshtml"
WriteAttributeValue("", 166, Url.Content("~/js/layui/css/layui.css"), 166, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(207, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 240, "\"", 280, 1);
#line 12 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\RoleSetPage.cshtml"
WriteAttributeValue("", 246, Url.Content("~/js/jquery.min.js"), 246, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(281, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 304, "\"", 345, 1);
#line 13 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\RoleSetPage.cshtml"
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
            BeginContext(367, 1706, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4772a0bbfcde4d1d95641d98b4c090ea", async() => {
                BeginContext(373, 430, true);
                WriteLiteral(@"
    <div style=""margin-top:20px;"">
        <div class=""layui-form"">
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">用户名</label>
                <div class=""layui-input-block"">
                    <input type=""text"" disabled id=""UserId"" name=""UserId"" autocomplete=""off"" lay-verify=""required"" placeholder=""请输入用户名"" class=""layui-input layui-disabled"" style=""width:400px"" maxlength=""24""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 803, "\"", 832, 1);
#line 21 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\RoleSetPage.cshtml"
WriteAttributeValue("", 811, ViewBag.Model.UserId, 811, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(833, 407, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">昵称</label>
                <div class=""layui-input-block"">
                    <input type=""text"" disabled id=""NickName"" name=""NickName"" autocomplete=""off"" lay-verify=""required"" placeholder=""请输入昵称"" class=""layui-input layui-disabled"" style=""width:400px"" maxlength=""32""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1240, "\"", 1271, 1);
#line 27 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\RoleSetPage.cshtml"
WriteAttributeValue("", 1248, ViewBag.Model.NickName, 1248, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1272, 721, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">角色</label>
                <div class=""layui-input-inline"">
                    <select style=""width:400px"" name=""RoleType"" id=""RoleType"" lay-filter=""RoleType""></select>
                </div>
            </div>

            <div class=""layui-form-item"">
                <div style=""text-align:center"">
                    <button class=""layui-btn layui-btn-normal"" lay-submit>保  存</button>
                    <button class=""layui-btn layui-btn-warm"" onclick=""cancelBtnClick()"">关  闭</button>
                </div>
            </div>
            <input id=""Id"" name=""Id""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1993, "\"", 2018, 1);
#line 43 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\RoleSetPage.cshtml"
WriteAttributeValue("", 2001, ViewBag.Model.Id, 2001, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2019, 47, true);
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
            BeginContext(2073, 596, true);
            WriteLiteral(@"
</html>
<script>
    var form;
    layui.use(['layer', 'form'], function () {
        var layer = layui.layer;
        form = layui.form();
        form.render();

        form.on('submit', function (data) {
            saveBtnClick(data);
            return false;
        });
    });
    function bindRole(data) {
        var htmlobj = ""<option value=''></option>"";
        $.each(data, function (i) {
            htmlobj += ""<option value='"" + data[i].Id + ""'>"" + data[i].RoleName + ""</option>"";
        });
        $(""#RoleType"").html(htmlobj);

        var roletype = """);
            EndContext();
            BeginContext(2670, 22, false);
#line 67 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\RoleSetPage.cshtml"
                   Write(ViewBag.Model.RoleType);

#line default
#line hidden
            EndContext();
            BeginContext(2692, 330, true);
            WriteLiteral(@""";
        if (roletype != null && roletype != """")
            $(""#RoleType"").val(roletype);
        //form.render();
    }
    function getRoleList() {
        $.ajax(
                {
                    async: false,
                    type: 'POST',
                    dataType: 'json',
                    url: '");
            EndContext();
            BeginContext(3023, 66, false);
#line 78 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\RoleSetPage.cshtml"
                     Write(Url.Action("GetRoleList","UserInfo", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(3089, 465, true);
            WriteLiteral(@"',
                    success: function (datafield) {
                        bindRole(datafield);
                    }
                }
                );
    }
    getRoleList();
    
    function saveBtnClick(datafield) {
        var loadingFlag = layer.load(1, {
            shade: [0.2, '#fff'] //0.1透明度的白色背景
        });
        $.ajax(
            {
                async: true,
                    type: 'POST',
                    url: '");
            EndContext();
            BeginContext(3555, 67, false);
#line 95 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\UserInfo\RoleSetPage.cshtml"
                     Write(Url.Action("SetUserRole", "UserInfo", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(3622, 563, true);
            WriteLiteral(@"',
                    data: datafield.field,
                    success: function (datafield) {
                    layer.close(loadingFlag);
                        if (datafield == ""success"") {
                            layer.msg('保存成功', { icon: 1 });
                        }
                    }
                }
                );
    }
    function cancelBtnClick() {
        var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
        parent.initData();
        parent.layer.close(index); //再执行关闭
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
