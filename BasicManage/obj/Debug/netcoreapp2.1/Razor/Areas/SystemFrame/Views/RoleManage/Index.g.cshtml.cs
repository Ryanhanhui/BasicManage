#pragma checksum "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dbe63f7acbfdbcc312ddec507505355666728c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemFrame_Views_RoleManage_Index), @"mvc.1.0.view", @"/Areas/SystemFrame/Views/RoleManage/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemFrame/Views/RoleManage/Index.cshtml", typeof(AspNetCore.Areas_SystemFrame_Views_RoleManage_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dbe63f7acbfdbcc312ddec507505355666728c2", @"/Areas/SystemFrame/Views/RoleManage/Index.cshtml")]
    public class Areas_SystemFrame_Views_RoleManage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(64, 470, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5e2c0fade9f4a3a8ea5b867c8db70d5", async() => {
                BeginContext(70, 150, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no\">\r\n    <title>");
                EndContext();
                BeginContext(221, 19, false);
#line 10 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
      Write(ViewBag.System_Name);

#line default
#line hidden
                EndContext();
                BeginContext(240, 19, true);
                WriteLiteral("</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 259, "\"", 306, 1);
#line 11 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
WriteAttributeValue("", 266, Url.Content("~/js/layui/css/layui.css"), 266, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(307, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 340, "\"", 380, 1);
#line 12 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
WriteAttributeValue("", 346, Url.Content("~/js/jquery.min.js"), 346, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(381, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 404, "\"", 445, 1);
#line 13 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
WriteAttributeValue("", 410, Url.Content("~/js/layui/layui.js"), 410, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(446, 21, true);
                WriteLiteral("></script>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 467, "\"", 504, 1);
#line 14 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
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
            BeginContext(536, 859, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e183c180499468b8e4c0773b43dcc41", async() => {
                BeginContext(542, 734, true);
                WriteLiteral(@"
    <fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
        <legend>角色管理 <button class=""layui-btn layui-btn-normal"" style=""margin-left:20px;"" onclick=""addClick()""><i class=""layui-icon"">&#xe654;</i> 新 增</button></legend>
    </fieldset>
    <table class=""layui-table"" lay-even="""">
        <thead>
            <tr>
                <th style=""width:30%"">角色名称</th>
                <th>角色说明</th>
                <th style=""width:10%"">权限操作</th>
                <th style=""width:20%"">更改操作</th>
            </tr>
        </thead>
        <tbody id=""tableBody""></tbody>
    </table>
    <div style=""float: left; margin-left: 15px;"">
        <div class=""layuipagecount""><span id=""mypagecount"">共 ");
                EndContext();
                BeginContext(1277, 17, false);
#line 32 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
                                                        Write(ViewBag.PageCount);

#line default
#line hidden
                EndContext();
                BeginContext(1294, 94, true);
                WriteLiteral(" 条</span></div>\r\n    </div>\r\n    <div id=\"mypage\" style=\"margin-left:10px;float:left\"></div>\r\n");
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
            BeginContext(1395, 375, true);
            WriteLiteral(@"
</html>
<script>
    var pagecount, form, layer, laypage;
    var pagesize = 15;
    layui.use(['form', 'layer'], function () {
        form = layui.form();
        layer = layui.layer;
        initData();
    });
    function initData() {
        var loadingFlag = layer.load(0, {
            shade: [0.2, '#fff'] //0.1透明度的白色背景
        });
        pagecount =");
            EndContext();
            BeginContext(1771, 17, false);
#line 49 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
              Write(ViewBag.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(1788, 691, true);
            WriteLiteral(@"
        $(""#mypagecount"").text(""共 "" + pagecount + "" 条 每页 "" + pagesize + "" 条"");
        layui.use('laypage', function () {
            laypage = layui.laypage;
            laypage({
                cont: 'mypage'
                , pages: Math.ceil(pagecount / pagesize)
                , skip: true
                , curr: 1
                , jump: function (obj, first) {
                    //得到了当前页，用于向服务端请求对应数据
                    var curr = obj.curr;
                    $.ajax(
                        {
                            async: false,
                            type: 'POST',
                            dataType: 'json',
                            url: '");
            EndContext();
            BeginContext(2480, 64, false);
#line 66 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
                             Write(Url.Action("GetData","RoleManage", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(2544, 1755, true);
            WriteLiteral(@"',
                            data:
                                {
                                    currpage: curr,
                                    pagesize: pagesize
                                },
                            success: function (datafield) {
                                bindTable(datafield);
                                layer.close(loadingFlag);
                            }
                        }
                        );
                }
            });
        });
    }
    function bindTable(data) {
        var tablehtml = """";
        var items = data;
        $.each(items, function (i) {
            var psc = items[i].RoleName + ""|"" + items[i].Id;
            tablehtml += ""<tr>""
            + ""<td>"" + items[i].RoleName + ""</td>""
            + ""<td>"" + items[i].RoleDesc + ""</td>""
            + ""<td><button class='layui-btn layui-btn-normal layui-btn-small' onclick='powerSetClick(&quot;"" + items[i].RoleName + ""&quot;,&quot;"" + items[i].Id + ");
            WriteLiteral(@"""&quot;)'><i class='layui-icon'>&#xe620;</i>权限分配</button></td>""
            + ""<td><button class='layui-btn layui-btn-warm layui-btn-small' onclick='editClick(&quot;"" + items[i].Id + ""&quot;)'><i class='layui-icon'>&#xe642;</i>编辑</button><button class='layui-btn layui-btn-danger layui-btn-small' onclick='deleteClick(&quot;"" + items[i].Id + ""&quot;)'><i class='layui-icon'>&#xe640;</i>删除</button></td>""
        + ""</tr>"";
        });
        $(""#tableBody"").html(tablehtml);
    }
    function powerSetClick(rolename, id) {
        layer.open({
            type: 2,
            title: '为' + rolename + '分配权限',
            shade: 0.8,
            closeBtn: 0,
            area: ['400px', '90%'],
            content: '");
            EndContext();
            BeginContext(4300, 67, false);
#line 103 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
                 Write(Url.Action("PowerPage", "RoleManage", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(4367, 251, true);
            WriteLiteral("?id=\' + id + \'\'\r\n        });\r\n    }\r\n    function editClick(id) {\r\n        layer.open({\r\n            type: 2,\r\n            title: \'角色信息\',\r\n            shade: 0.8,\r\n            closeBtn: 0,\r\n            area: [\'500px\', \'300px\'],\r\n            content: \'");
            EndContext();
            BeginContext(4619, 67, false);
#line 113 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
                 Write(Url.Action("DetialPage","RoleManage", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(4686, 362, true);
            WriteLiteral(@"?status=edit&id=' + id + ''
        });
    }
    function deleteClick(id) {
        layer.confirm('确定删除么？', {
            btn: ['确定', '取消'], //按钮
            icon: 3,
            closeBtn: 0
        }, function () {
            $.ajax(
                {
                    async: false,
                    type: 'POST',
                    url: '");
            EndContext();
            BeginContext(5049, 68, false);
#line 126 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
                     Write(Url.Action("DeleteData", "RoleManage", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(5117, 674, true);
            WriteLiteral(@"',
                    data:
                        {
                            Id: id
                        },
                    success: function (datafield) {
                        if (datafield == ""success"") {
                            initData();
                            layer.closeAll('dialog');
                        }
                    }
                }
                );
        }, function () {

        });
    }
    function addClick() {
        layer.open({
            type: 2,
            title: '角色信息',
            shade: 0.8,
            closeBtn: 0,
            area: ['500px', '300px'],
            content: '");
            EndContext();
            BeginContext(5792, 67, false);
#line 150 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\RoleManage\Index.cshtml"
                 Write(Url.Action("DetialPage","RoleManage", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(5859, 47, true);
            WriteLiteral("?status=add\'\r\n        });\r\n    }\r\n</script>\r\n\r\n");
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
