#pragma checksum "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "617cabf145b1b5c9ee4064d2b465200ab5f39de3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemFrame_Views_SysConfig_Index), @"mvc.1.0.view", @"/Areas/SystemFrame/Views/SysConfig/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SystemFrame/Views/SysConfig/Index.cshtml", typeof(AspNetCore.Areas_SystemFrame_Views_SysConfig_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"617cabf145b1b5c9ee4064d2b465200ab5f39de3", @"/Areas/SystemFrame/Views/SysConfig/Index.cshtml")]
    public class Areas_SystemFrame_Views_SysConfig_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(64, 626, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0920998b72cc48c3a277f2bfeae37e62", async() => {
                BeginContext(70, 150, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no\">\r\n    <title>");
                EndContext();
                BeginContext(221, 19, false);
#line 10 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
      Write(ViewBag.System_Name);

#line default
#line hidden
                EndContext();
                BeginContext(240, 19, true);
                WriteLiteral("</title>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 259, "\"", 306, 1);
#line 11 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 266, Url.Content("~/js/layui/css/layui.css"), 266, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(307, 33, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 340, "\"", 380, 1);
#line 12 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 346, Url.Content("~/js/jquery.min.js"), 346, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(381, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 404, "\"", 445, 1);
#line 13 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 410, Url.Content("~/js/layui/layui.js"), 410, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(446, 21, true);
                WriteLiteral("></script>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 467, "\"", 504, 1);
#line 14 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 474, Url.Content("~/css/main.css"), 474, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(505, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 536, "\"", 585, 1);
#line 15 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 543, Url.Content("~/css/ssi-uploader.min.css"), 543, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(586, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 617, "\"", 660, 1);
#line 16 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 624, Url.Content("~/css/viewer.min.css"), 624, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(661, 22, true);
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
            BeginContext(690, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(692, 3548, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a339e30adcf34b1b8882597f73497460", async() => {
                BeginContext(698, 521, true);
                WriteLiteral(@"
    <fieldset class=""layui-elem-field"" style=""margin-top: 20px;"">
        <legend>系统信息</legend>

        <div class=""layui-field-box"">
            <div class=""layui-form"">
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">系统名称</label>
                    <div class=""layui-input-block"">
                        <input type=""text"" id=""System_Name"" name=""System_Name"" lay-verify=""required"" autocomplete=""off"" placeholder=""请输入系统名称"" class=""layui-input"" maxlength=""32""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1219, "\"", 1247, 1);
#line 27 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 1227, ViewBag.System_Name, 1227, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1248, 399, true);
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">登录页页脚</label>
                    <div class=""layui-input-block"">
                        <input type=""text"" id=""LoginFooter"" name=""LoginFooter"" lay-verify=""required"" autocomplete=""off"" placeholder=""请输入登录页页脚"" class=""layui-input"" maxlength=""64""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1647, "\"", 1675, 1);
#line 33 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 1655, ViewBag.LoginFooter, 1655, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1676, 397, true);
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">主界面页脚</label>
                    <div class=""layui-input-block"">
                        <input type=""text"" id=""MainFooter"" name=""MainFooter"" lay-verify=""required"" autocomplete=""off"" placeholder=""请输入主页面页脚"" class=""layui-input"" maxlength=""64""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2073, "\"", 2100, 1);
#line 39 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 2081, ViewBag.MainFooter, 2081, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2101, 310, true);
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">手机App文件</label>
                    <div class=""layui-input-block"" style=""width:80%"">
                        <input type=""hidden"" id=""PhoneAddreesHidden""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2411, "\"", 2440, 1);
#line 45 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 2419, ViewBag.PhoneAddress, 2419, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2441, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 46 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
                          
                            string phoneaddrss = "";
                            if (!string.IsNullOrWhiteSpace(ViewBag.PhoneAddress))
                            {
                                phoneaddrss = ViewBag.PhoneAddress.Remove(0, ViewBag.PhoneAddress.LastIndexOf('/') + 1);
                            }
                        

#line default
#line hidden
                BeginContext(2822, 49, true);
                WriteLiteral("                        <a id=\"PhoneAddressField\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2871, "\"", 2915, 2);
#line 53 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 2878, ViewBag.SysDown, 2878, 16, false);

#line default
#line hidden
#line 53 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 2894, ViewBag.PhoneAddress, 2894, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2916, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2918, 11, false);
#line 53 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
                                                                                          Write(phoneaddrss);

#line default
#line hidden
                EndContext();
                BeginContext(2929, 379, true);
                WriteLiteral(@"</a>
                        <input type=""file"" multiple id=""PhoneAddress"">
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <label class=""layui-form-label"">手机端二维码</label>
                    <div class=""layui-input-block"" style=""width:80%"">
                        <input type=""hidden"" id=""PhoneQRHidden""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3308, "\"", 3332, 1);
#line 60 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 3316, ViewBag.PhoneQR, 3316, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3333, 106, true);
                WriteLiteral(" />\r\n                        <div>\r\n                            <img class=\"viewer-toggle\" data-original=\"");
                EndContext();
                BeginContext(3440, 15, false);
#line 62 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
                                                                 Write(ViewBag.SysDown);

#line default
#line hidden
                EndContext();
                BeginContext(3456, 15, false);
#line 62 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
                                                                                 Write(ViewBag.PhoneQR);

#line default
#line hidden
                EndContext();
                BeginContext(3471, 1, true);
                WriteLiteral("\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3472, "\"", 3510, 2);
#line 62 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 3478, ViewBag.SysDown, 3478, 16, false);

#line default
#line hidden
#line 62 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 3494, ViewBag.PhoneQR, 3494, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3511, 530, true);
                WriteLiteral(@" id=""PhoneQRField"" style=""width:100px;height:80px"" />
                        </div>
                        <input type=""file"" multiple id=""PhoneQR"">
                    </div>
                </div>
                <div class=""layui-form-item"">
                    <div class=""layui-input-block"">
                        <button class=""layui-btn layui-btn-normal"" onclick=""saveBtnClick()"">保  存</button>
                    </div>
                </div>
            </div>
            <input type=""hidden"" id=""IdField""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4041, "\"", 4060, 1);
#line 73 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 4049, ViewBag.Id, 4049, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4061, 172, true);
                WriteLiteral(" />\r\n        </div>\r\n    </fieldset>\r\n    <div id=\"ImgBox\" style=\"display:none;text-align:center\">\r\n        <img id=\"BigImg\" src=\"\" onclick=\"closeImgBox()\" />\r\n    </div>\r\n");
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
            BeginContext(4240, 18, true);
            WriteLiteral("\r\n</html>\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4258, "\"", 4300, 1);
#line 81 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 4264, Url.Content("~/js/ssi-uploader.js"), 4264, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4301, 19, true);
            WriteLiteral("></script>\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4320, "\"", 4360, 1);
#line 82 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
WriteAttributeValue("", 4326, Url.Content("~/js/viewer.min.js"), 4326, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4361, 464, true);
            WriteLiteral(@"></script>
<script type=""text/javascript"">
    var layer, form;
    var layindex;
    layui.use(['form', 'layer'], function () {
        form = layui.form();
        layer = layui.layer;
    });
    var viewer = new Viewer(document.getElementById('PhoneQRField'), {
        url: 'data-original',
        title: false,
        navbar: false,
        toolbar: false,
        zIndex: 2015
    });

    $('#PhoneAddress').ssi_uploader({
        url: '");
            EndContext();
            BeginContext(4826, 73, false);
#line 99 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
         Write(Url.Action("UploadSingleFile","FileUpload", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(4899, 826, true);
            WriteLiteral(@"',
        data: { ""type"": ""1"", ""folder"": ""SysConfig"", ""oldpath"": $(""#PhoneAddreesHidden"").val() },
        allowed: ['apk', 'dmg', 'jpg','rar','zip'],
        dropZone: false,
        locale: 'zh_CN',
        maxNumberOfFiles: 1,
        maxFileSize:100,
        errorHandler: {
            method: function (msg, type) {
                if (type == ""error"") {
                    layer.alert(msg, { icon: 2 });
                }
            },
            success: 'success',
            error: 'error'
        },
        onEachUpload: function (backdata) {
            if (backdata.uploadStatus == ""success"" && backdata.responseMsg != ""Error"" && backdata.responseMsg != ""Error0"") {
                $(""#PhoneAddreesHidden"").val(backdata.responseMsg);
                $(""#PhoneAddressField"").prop(""href"", """);
            EndContext();
            BeginContext(5726, 15, false);
#line 118 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
                                                 Write(ViewBag.SysDown);

#line default
#line hidden
            EndContext();
            BeginContext(5741, 193, true);
            WriteLiteral("\" + backdata.responseMsg);\r\n                $(\"#PhoneAddressField\").text(getFileName(backdata.responseMsg));\r\n            }\r\n        }\r\n    });\r\n    $(\'#PhoneQR\').ssi_uploader({\r\n        url: \'");
            EndContext();
            BeginContext(5935, 73, false);
#line 124 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
         Write(Url.Action("UploadSingleFile","FileUpload", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(6008, 772, true);
            WriteLiteral(@"',
        data: { ""type"": ""1"", ""folder"": ""SysConfig"", ""oldpath"": $(""#PhoneQRHidden"").val() },
        allowed: ['png', 'jpg', 'bmp'],
        dropZone: false,
        locale: 'zh_CN',
        maxNumberOfFiles: 1,
        errorHandler: {
            method: function (msg, type) {
                if (type == ""error"") {
                    layer.alert(msg, { icon: 2 });
                }
            },
            success: 'success',
            error: 'error'
        },
        onEachUpload: function (backdata) {
            if (backdata.uploadStatus == ""success"" && backdata.responseMsg != ""Error"" && backdata.responseMsg != ""Error0"") {
                $(""#PhoneQRHidden"").val(backdata.responseMsg);
                $(""#PhoneQRField"").prop(""src"", """);
            EndContext();
            BeginContext(6781, 15, false);
#line 142 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
                                           Write(ViewBag.SysDown);

#line default
#line hidden
            EndContext();
            BeginContext(6796, 332, true);
            WriteLiteral(@""" + backdata.responseMsg);

            }
        }
    });
    function saveBtnClick() {
        var loadingFlag = layer.load(1, {
            shade: [0.2, '#fff'] //0.1透明度的白色背景
        });
        $.ajax(
                {
                    async: false,
                    type: 'POST',
                    url: '");
            EndContext();
            BeginContext(7129, 67, false);
#line 155 "E:\VS2017\ASP.NET Core\BasicManage\BasicManage\Areas\SystemFrame\Views\SysConfig\Index.cshtml"
                     Write(Url.Action("UpdateData", "SysConfig", new { area = "SystemFrame" }));

#line default
#line hidden
            EndContext();
            BeginContext(7196, 1334, true);
            WriteLiteral(@"',
                    data:
                        {
                            Id: $(""#IdField"").val(),
                            System_Name: $(""#System_Name"").val(),
                            LoginFooter: $(""#LoginFooter"").val(),
                            MainFooter: $(""#MainFooter"").val(),
                            PhoneQR: $(""#PhoneQRHidden"").val(),
                            PhoneAddress: $(""#PhoneAddreesHidden"").val()
                        },
                    success: function (datafield) {
                    layer.close(loadingFlag);
                        if (datafield == ""success"") {
                            layer.msg('保存成功', { icon: 1 });
                        }
                    }
                }
                );
    }
    function imgBoxClick(obj) {
        $(""#BigImg"").prop(""src"", obj.src);
        layindex = layer.open({
            type: 1,
            title: false,
            closeBtn: 1,
            area: ['800', '600px'],
            ");
            WriteLiteral(@"shadeClose: true,
            content: $('#ImgBox'),
            shade: 0
        });
    }
    function closeImgBox() {
        layer.close(layindex);
    }
    function getFileName(filepath) {
        var str = filepath.substr(filepath.lastIndexOf('/') + 1);
        return str;
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
