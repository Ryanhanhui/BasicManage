#pragma checksum "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fec7d0089526d6b0da806db33705bcff1be5f350"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemFrame_Views_NodeManage_Index), @"mvc.1.0.view", @"/Areas/SystemFrame/Views/NodeManage/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemFrame/Views/NodeManage/Index.cshtml", typeof(AspNetCore.Areas_SystemFrame_Views_NodeManage_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec7d0089526d6b0da806db33705bcff1be5f350", @"/Areas/SystemFrame/Views/NodeManage/Index.cshtml")]
    public class Areas_SystemFrame_Views_NodeManage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(64, 470, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbbb50d2ce784ef6a2707632c1fedc3b", async() => {
                BeginContext(70, 150, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no\">\r\n    <title>");
                EndContext();
                BeginContext(221, 19, false);
#line 10 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml"
      Write(ViewBag.System_Name);

#line default
#line hidden
                EndContext();
                BeginContext(240, 19, true);
                WriteLiteral("</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 259, "\"", 306, 1);
#line 11 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml"
WriteAttributeValue("", 266, Url.Content("~/js/layui/css/layui.css"), 266, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(307, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 340, "\"", 380, 1);
#line 12 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml"
WriteAttributeValue("", 346, Url.Content("~/js/jquery.min.js"), 346, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(381, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 404, "\"", 445, 1);
#line 13 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml"
WriteAttributeValue("", 410, Url.Content("~/js/layui/layui.js"), 410, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(446, 21, true);
                WriteLiteral("></script>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 467, "\"", 504, 1);
#line 14 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml"
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
            BeginContext(536, 4048, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b3fe75c44f74760804e10be4001f4dd", async() => {
                BeginContext(542, 4035, true);
                WriteLiteral(@"
    <fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
        <legend>功能节点信息设置</legend>
    </fieldset>
    <div class=""contentdiv-text contentdiv-block contentdiv-block-left"">
        <div style=""display: inline-block; width: 180px; padding: 10px; border: 1px solid #ddd; overflow: auto;"">
            <ul id=""NodeTree""></ul>
        </div>
    </div>
    <div class=""contentdiv-text contentdiv-block contentdiv-block-right"">
        <div id=""AddDiv"" onclick=""addBtnClick();"">
            <button class=""layui-btn layui-btn-normal"">
                <i class=""layui-icon"">&#xe608;</i> 添加
            </button>
        </div>
        <div id=""ContentDiv"" style=""display:none"">
            <div class=""layui-form"">
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">节点名称</label>
                    <div class=""layui-input-block"">
                        <input type=""text"" id=""NodeName"" name=""NodeName"" lay-verify=""required"" au");
                WriteLiteral(@"tocomplete=""off"" placeholder=""请输入节点名称"" class=""layui-input"" maxlength=""32"">
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">节点链接</label>
                    <div class=""layui-input-block"">
                        <input type=""text"" id=""NodeUrl"" name=""NodeUrl"" lay-verify=""required"" autocomplete=""off"" placeholder=""请输入节点链接|父节点不填写此项"" class=""layui-input"" maxlength=""128"">
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">序号</label>
                    <div class=""layui-input-block"">
                        <input type=""text"" id=""NodeNum"" name=""NodeNum"" lay-verify=""required|numberverify"" autocomplete=""off"" placeholder=""请输入序号"" class=""layui-input"" maxlength=""128"" style=""width:100px"">
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label clas");
                WriteLiteral(@"s=""layui-form-label"">父节点</label>
                    <div class=""layui-input-inline"">
                        <select name=""ParentNode"" id=""ParentNode"" lay-filter=""ParentNode""></select>
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">节点类型</label>
                    <div class=""layui-input-inline"">
                        <input type=""radio"" name=""NodeType"" id=""NodeType0"" value=""0"" title=""业务"" checked="""">
                        <input type=""radio"" name=""NodeType"" id=""NodeType1"" value=""1"" title=""系统"">
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">是否开启</label>
                    <div class=""layui-input-block"">
                        <input type=""checkbox"" checked="""" id=""Status"" name=""open"" lay-skin=""switch"" lay-filter=""Status"" value=""1"" lay-text=""开启|关闭"">
                    </div>
              ");
                WriteLiteral(@"  </div>
                <div class=""layui-form-item"">
                    <div class=""layui-input-block"">
                        <button class=""layui-btn layui-btn-normal"" onclick=""saveBtnClick()"">保  存</button>
                        <button class=""layui-btn layui-btn-warm"" onclick=""cancelBtnClick()"">取  消</button>
                        <button class=""layui-btn layui-btn-danger"" id=""DelBtn"" onclick=""delBtnClick()"">删  除</button>
                    </div>
                </div>
            </div>

        </div>
        <input type=""hidden"" id=""IdField"" value="""" />
        <input type=""hidden"" id=""NodeNameField"" value="""" />
        <input type=""hidden"" id=""NodeUrlField"" value="""" />
        <input type=""hidden"" id=""NodeTypeField"" value="""" />
        <input type=""hidden"" id=""ParentNodeField"" value="""" />
        <input type=""hidden"" id=""NodeNumField"" value="""" />
        <input type=""hidden"" id=""StatusField"" value="""" />
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
            BeginContext(4584, 821, true);
            WriteLiteral(@"
</html>
<script type=""text/javascript"">
    var form;
    layui.use('form', function () {
        form = layui.form();
        //var layer = layui.layer;
        form.on('select(ParentNode)', function (data) {
            $(""#ParentNodeField"").val(data.value);
        });
        form.on('switch(Status)', function (data) {
            if (data.elem.checked == true) {
                $(""#StatusField"").val(""1"");
            }
            else {
                $(""#StatusField"").val(""0"");
            }

        });
        form.on('radio', function (data) {
            if (data.elem.name == ""NodeType"") {
                $(""#NodeTypeField"").val(data.value);
            }
        });
        form.render();

    });
    GetNode();
    //请求树节点数据
    function GetNode() {
        $.post(""");
            EndContext();
            BeginContext(5406, 72, false);
#line 118 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml"
           Write(Url.Action("GetNodeTreeData","NodeManage", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(5478, 1987, true);
            WriteLiteral(@""",
    {},
    function (data, status) {
        if (status == ""success"") {
            loadTree(data);
        }
        else {
            layer.alert(""网络连接超时"", {
                icon: 2,
                closeBtn: false,
                title: '警告'
            });
        }
    },
            ""json""
            );
    }
    //创建树节点
    var createNode = function (data) {
        var treearr = [];
        $.each(data, function (i) {
            if (data[i].ParentNode == null || data[i].ParentNode == """") {
                var child = [];
                $.each(data, function (j) {
                    if (data[j].ParentNode == data[i].Id) {
                        child.push({
                            name: data[j].NodeName,
                            Id: data[j].Id
                        });
                    }
                });
                treearr.push({
                    name: data[i].NodeName,
                    Id: data[i].Id,
                    children: ");
            WriteLiteral(@"child
                });
            }
        });
        return treearr;
    }
    //绑定节点选择框
    function bindNodeParent(data) {
        var htmlobj = ""<option value=''></option>"";
        $.each(data, function (i) {
            if (data[i].ParentNode == null || data[i].ParentNode == """") {
                htmlobj += ""<option value='"" + data[i].Id + ""'>"" + data[i].NodeName + ""</option>"";
            }
        });
        $(""#ParentNode"").html(htmlobj);
    }
    function loadTree(data) {//初始化树节点
        layui.use('tree', function () {
            layui.tree({
                elem: '#NodeTree' //指定元素
            , target: '_blank' //是否新选项卡打开（比如节点返回href才有效）
            , click: function (item) { //点击节点回调
                treeClickBack(item);
            }
            , nodes: createNode(data)
            });
        });
        bindNodeParent(data);
    }
    //树节点点击处理
    function treeClickBack(item) {
        $.post(""");
            EndContext();
            BeginContext(7466, 71, false);
#line 183 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml"
           Write(Url.Action("GetSingleData", "NodeManage", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(7537, 3279, true);
            WriteLiteral(@""",
            {
                Id: item.Id
            },
            function (data, status) {
                if (status == ""success"") {
                    $(""#IdField"").val(data.Id);

                    $(""#NodeName"").val(data.NodeName);
                    $(""#NodeNameField"").val(data.NodeName);

                    $(""#NodeUrl"").val(data.NodeUrl);
                    $(""#NodeUrlField"").val(data.NodeUrl);

                    $(""#NodeNum"").val(data.NodeNum);
                    $(""#NodeNumField"").val(data.NodeNum);

                    $(""#ParentNode"").val(data.ParentNode);
                    $(""#ParentNode"").attr(""disabled"", """");
                    $(""#ParentNodeField"").val(data.ParentNode);

                    if (data.NodeType == ""0"") {
                        document.getElementById(""NodeType1"").removeAttribute(""checked"");
                        document.getElementById(""NodeType0"").setAttribute(""checked"", ""checked"");
                    }
                    else if (d");
            WriteLiteral(@"ata.NodeType == ""1"") {
                        document.getElementById(""NodeType0"").removeAttribute(""checked"");
                        document.getElementById(""NodeType1"").setAttribute(""checked"", ""checked"");
                    }
                    $(""#NodeTypeField"").val(data.NodeType);

                    if (data.Status == ""1"") {
                        document.getElementById(""Status"").setAttribute(""checked"", ""checked"");
                    }
                    else {
                        document.getElementById(""Status"").removeAttribute(""checked"");
                    }
                    $(""#StatusField"").val(data.Status);

                    form.render();
                }
            },
            ""json""
            );
        $(""#AddDiv"").hide();
        $(""#DelBtn"").show();
        $(""#ContentDiv"").show();
    }
    function clearField() {
        $(""#IdField"").val("""");
        $(""#NodeNameField"").val("""");
        $(""#NodeUrlField"").val("""");
        $(""#NodeNumF");
            WriteLiteral(@"ield"").val("""");
        $(""#ParentNodeField"").val("""");
        $(""#NodeTypeField"").val(""0"");
        $(""#StatusField"").val(""1"");
    }
    function clearValue() {
        $(""#NodeName"").val("""");
        $(""#NodeUrl"").val("""");
        $(""#NodeNum"").val("""");
        $(""#ParentNode"").val("""");
        $(""#NodeType"").val(""0"");
        document.getElementById(""NodeType1"").removeAttribute(""checked"");
        document.getElementById(""NodeType0"").setAttribute(""checked"", ""checked"");
        //$(""#Status"").val(""1"");
        document.getElementById(""Status"").setAttribute(""checked"", ""checked"");
        form.render();
    }
    //新增
    function addBtnClick() {
        clearField();
        clearValue();
        $(""#ContentDiv"").show();
        $(""#AddDiv"").hide();
        $(""#DelBtn"").hide();
    }
    //取消
    function cancelBtnClick() {
        clearField();
        clearValue();
        $(""#ParentNode"").removeAttr(""disabled"", """");
        $(""#ContentDiv"").hide();
        $(""#AddDiv"").show");
            WriteLiteral("();\r\n        form.render();\r\n    }\r\n    //保存\r\n    function saveBtnClick() {\r\n        if (VerifyValid() == false)\r\n            return false;\r\n        if ($(\"#IdField\").val() == \"\") {//新增\r\n            $.post(\"");
            EndContext();
            BeginContext(10817, 65, false);
#line 274 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml"
               Write(Url.Action("AddNode", "NodeManage", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(10882, 775, true);
            WriteLiteral(@""",
                {
                    NodeName: $(""#NodeName"").val(),
                    NodeUrl: $(""#NodeUrl"").val(),
                    NodeNum: $(""#NodeNum"").val(),
                    ParentNode: $(""#ParentNodeField"").val(),
                    NodeType: $(""#NodeTypeField"").val(),
                    Status: $(""#StatusField"").val()
                },
                function (data, status) {
                    if (status == ""success"" && data != """") {
                        layer.msg('保存成功', { icon: 1 });
                        cancelBtnClick();
                        $(""#NodeTree"").html("""");
                        GetNode();
                    }
                }
                );
        }
        else {//更新
            $.post(""");
            EndContext();
            BeginContext(11658, 67, false);
#line 294 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml"
               Write(Url.Action("UpdateData","NodeManage", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(11725, 907, true);
            WriteLiteral(@""",
                {
                    Id: $(""#IdField"").val(),
                    NodeName: $(""#NodeName"").val(),
                    NodeUrl: $(""#NodeUrl"").val(),
                    NodeNum: $(""#NodeNum"").val(),
                    ParentNode: $(""#ParentNodeField"").val(),
                    NodeType: $(""#NodeTypeField"").val(),
                    Status: $(""#StatusField"").val()
                },
                function (data, status) {
                    if (status == ""success"" && data != """") {
                        layer.msg('保存成功', { icon: 1 });
                        cancelBtnClick();
                    }
                }
                );
        }
    }
    //删除
    function delBtnClick() {
        layer.confirm('确定删除么？', {
            btn: ['确定', '取消'], //按钮
            icon: 3,
            closeBtn: 0
        }, function () {
            $.post(""");
            EndContext();
            BeginContext(12633, 68, false);
#line 320 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\NodeManage\Index.cshtml"
               Write(Url.Action("DeleteNode", "NodeManage", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(12701, 939, true);
            WriteLiteral(@""",
            {
                Id: $(""#IdField"").val()
            },
            function (data, status) {
                if (status == ""success"" && data != """") {
                    layer.msg('删除成功', { icon: 1 });
                    cancelBtnClick();
                    $(""#NodeTree"").html("""");
                    GetNode();
                }
            }
          );
        }, function () {

        });
    }

    function VerifyValid() {
        if ($(""#NodeName"").val() == """") {
            layer.tips('请输入节点名称', '#NodeName', {
                tips: [2, '#ff0000'],
                time: 3000
            });
            return false;
        }
        if ($(""#NodeNum"").val() == """") {
            layer.tips('请输入节点序号', '#NodeNum', {
                tips: [2, '#ff0000'],
                time: 3000
            });
            return false;
        }
        return true;
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
