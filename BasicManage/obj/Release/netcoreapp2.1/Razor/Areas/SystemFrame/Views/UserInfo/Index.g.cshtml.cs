#pragma checksum "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f7382f8397bd3627e46d99f850486ef61beae15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemFrame_Views_UserInfo_Index), @"mvc.1.0.view", @"/Areas/SystemFrame/Views/UserInfo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemFrame/Views/UserInfo/Index.cshtml", typeof(AspNetCore.Areas_SystemFrame_Views_UserInfo_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7382f8397bd3627e46d99f850486ef61beae15", @"/Areas/SystemFrame/Views/UserInfo/Index.cshtml")]
    public class Areas_SystemFrame_Views_UserInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(64, 470, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9391d49db5e94a758921bfd4e6955fc1", async() => {
                BeginContext(70, 150, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no\">\r\n    <title>");
                EndContext();
                BeginContext(221, 19, false);
#line 10 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
      Write(ViewBag.System_Name);

#line default
#line hidden
                EndContext();
                BeginContext(240, 19, true);
                WriteLiteral("</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 259, "\"", 306, 1);
#line 11 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 266, Url.Content("~/js/layui/css/layui.css"), 266, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(307, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 340, "\"", 380, 1);
#line 12 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 346, Url.Content("~/js/jquery.min.js"), 346, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(381, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 404, "\"", 445, 1);
#line 13 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 410, Url.Content("~/js/layui/layui.js"), 410, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(446, 21, true);
                WriteLiteral("></script>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 467, "\"", 504, 1);
#line 14 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
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
            BeginContext(536, 2197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b631fba3816b4682a3bc7607b339c1c4", async() => {
                BeginContext(542, 2184, true);
                WriteLiteral(@"
    <fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
        <legend>用户管理<button class=""layui-btn layui-btn-normal"" style=""margin-left:20px;"" onclick=""addClick()""><i class=""layui-icon"">&#xe654;</i> 新 增</button></legend>
    </fieldset>
    <div class=""layui-form"">
        <div class=""layui-form-item"">
            <div class=""layui-inline"" style=""margin-right:0px;"">
                <label class=""layui-form-label"" style=""width:auto"">用户名：</label>
                <div class=""layui-input-inline"" style=""width: 150px;"">
                    <input type=""text"" name=""UserId"" id=""UserId"" lay-verify=""title"" autocomplete=""off"" class=""layui-input"">
                </div>
            </div>
            <div class=""layui-inline"">
                <label class=""layui-form-label"" style=""width:auto"">姓名：</label>
                <div class=""layui-input-inline"" style=""width: 150px;"">
                    <input type=""text"" name=""Name"" id=""Name"" lay-verify=""title"" autocomplete=""off"" clas");
                WriteLiteral(@"s=""layui-input"">
                </div>
            </div>
            <div class=""layui-inline"">
                <div class=""layui-input-inline"">
                    <button class=""layui-btn"" id=""searchBtn"" onclick=""queryData();""><i class=""layui-icon"">&#xe615;</i> 查 询</button>
                </div>
            </div>
        </div>
    </div>
    <table class=""layui-table"" lay-even="""">
        <thead>
            <tr>
                <th style=""width:10%"">用户名</th>
                <th style=""width:15%"">昵称</th>
                <th style=""width:15%"">姓名</th>
                <th style=""width:10%"">性别</th>
                <th style=""width:10%"">年龄</th>
                <th style=""width:10%"">用户角色</th>
                <th>操作</th>
            </tr>
        </thead>
        <tbody id=""tableBody""></tbody>
    </table>
    <div style=""float: left; margin-left: 15px;"">
        <div class=""layuipagecount""><span id=""mypagecount"">共 1000 条</span></div>
    </div>
    <div id=""mypage"" style=""margin-le");
                WriteLiteral("ft:10px;float:left\"></div>\r\n    <input id=\"hide_UserId\" type=\"hidden\" value=\"\" />\r\n    <input id=\"hide_Name\" type=\"hidden\" value=\"\" />\r\n");
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
            BeginContext(2733, 1441, true);
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
    function queryData() {
        var loadingFlag = layer.load(0, {
            shade: [0.2, '#fff'] //0.1透明度的白色背景
        });
        $(""#hide_UserId"").val($(""#UserId"").val());
        $(""#hide_Name"").val($(""#Name"").val());
        pagecount = getPageCount();
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
                    var datajson = {
                        cu");
            WriteLiteral(@"rrpage: curr,
                        pagesize: pagesize,
                        UserId: $(""#hide_UserId"").val(),
                        Name: $(""#hide_Name"").val()
                    };
                    $.ajax(
                        {
                            async: true,
                            type: 'POST',
                            dataType: 'json',
                            url: '");
            EndContext();
            BeginContext(4175, 62, false);
#line 100 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
                             Write(Url.Action("GetData","UserInfo", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(4237, 2019, true);
            WriteLiteral(@"',
                            data: datajson,
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
    function initData() {
        queryData();
    }

    function bindTable(data) {
        var tablehtml = """";
        var items = data;
        $.each(items, function (i) {
            var sex = items[i].Sex == ""1"" ? ""男"" : ""女"";
            var rolename = items[i].RoleName == null ? """" : items[i].RoleName;
            tablehtml += ""<tr>""
            + ""<td>"" + items[i].UserId + ""</td>""
            + ""<td>"" + items[i].NickName + ""</td>""
            + ""<td>"" + items[i].Name + ""</td>""
            + ""<td>"" + sex + ""</td>""
            + ""<td>"" + items[i].Age + ""</td>""
            + ""<td>"" + rolename + ""</td>""
            + ""<td><button ");
            WriteLiteral(@"class='layui-btn layui-btn-primary layui-btn-small' onclick='roleSet(&quot;"" + items[i].UserId + ""&quot;)'><i class='layui-icon'>&#xe614;</i> 分配角色</button>""
            + ""<button class='layui-btn layui-btn-warm layui-btn-small' onclick='editClick(&quot;"" + items[i].UserId + ""&quot;)'><i class='layui-icon'>&#xe642;</i> 编辑</button>""
            + ""<button class='layui-btn layui-btn-danger layui-btn-small' onclick='pwdReset(&quot;"" + items[i].Id + ""&quot;)'><i class='layui-icon'>&#xe628;</i> 重置密码</button>""
            +""<button class='layui-btn layui-btn-danger layui-btn-small' onclick='deleteClick(&quot;"" + items[i].Id + ""&quot;)'><i class='layui-icon'>&#xe640;</i> 删除</button></td>""
        + ""</tr>"";
        });
        $(""#tableBody"").html(tablehtml);
    }
    function roleSet(userid) {
        layer.open({
            type: 2,
            title: '用户角色配置',
            shade: 0.8,
            closeBtn: 0,
            area: ['600px', '500px'],
            content: '");
            EndContext();
            BeginContext(6257, 67, false);
#line 144 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
                 Write(Url.Action("RoleSetPage", "UserInfo", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(6324, 265, true);
            WriteLiteral(@"?UserId=' + userid + ''
        });
    }
    function editClick(userid) {
        layer.open({
            type: 2,
            title: '用户信息维护',
            shade: 0.8,
            closeBtn: 0,
            area: ['600px', '500px'],
            content: '");
            EndContext();
            BeginContext(6590, 64, false);
#line 154 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
                 Write(Url.Action("EditPage", "UserInfo", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(6654, 358, true);
            WriteLiteral(@"?UserId=' + userid + ''
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
            BeginContext(7013, 66, false);
#line 167 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
                     Write(Url.Action("DeleteData", "UserInfo", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(7079, 891, true);
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
    function pwdReset(id) {
        layer.confirm('确定重置密码么？', {
            btn: ['确定', '取消'], //按钮
            icon: 3,
            closeBtn: 0
        }, function () {
            var loadingFlag = layer.load(0, {
                shade: [0.2, '#fff'] //0.1透明度的白色背景
            });
            $.ajax(
                {
                    async: false,
                    type: 'POST',
                    url: '");
            EndContext();
            BeginContext(7971, 69, false);
#line 197 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
                     Write(Url.Action("ResetPassword", "UserInfo", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(8040, 790, true);
            WriteLiteral(@"',
                    data:
                        {
                            Id: id
                        },
                    success: function (datafield) {
                        layer.close(loadingFlag);
                        if (datafield == ""success"") {
                            initData();
                            layer.closeAll('dialog');
                            layer.msg('重置密码成功', { icon: 1 });
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
            title: '用户信息维护',
            shade: 0.8,
            closeBtn: 0,
            area: ['600px', '500px'],
            content: '");
            EndContext();
            BeginContext(8831, 64, false);
#line 223 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
                 Write(Url.Action("EditPage", "UserInfo", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(8895, 340, true);
            WriteLiteral(@"'
        });
    }
    function getPageCount() {
        var ret = 0;
        var datajson = {
            UserId: $(""#hide_UserId"").val(),
            Name: $(""#hide_Name"").val()
        };
        $.ajax(
            {
                        async: true,
                        type: 'POST',
                        url: '");
            EndContext();
            BeginContext(9236, 67, false);
#line 236 "E:\VS2017\ASP.NET Core\LotteryAnalysisManage\LotteryAnalysisManage\Areas\SystemFrame\Views\UserInfo\Index.cshtml"
                         Write(Url.Action("GetDataCount","UserInfo", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(9303, 261, true);
            WriteLiteral(@"',
                        data: datajson,
                        success: function (datafield) {
                            ret=datafield;
                        }
                    }
                    );
        return ret;
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
