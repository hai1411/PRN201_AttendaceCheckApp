#pragma checksum "C:\Users\Admin\Desktop\StudentManagementWebApp-2\StudentManagementWebApp\Views\Teacher\AttendanceCheck.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "777e6a30ddc68ad3994a32c32d7fc5854af78fe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_AttendanceCheck), @"mvc.1.0.view", @"/Views/Teacher/AttendanceCheck.cshtml")]
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
#nullable restore
#line 4 "C:\Users\Admin\Desktop\StudentManagementWebApp-2\StudentManagementWebApp\Views\Teacher\AttendanceCheck.cshtml"
using StudentManagementWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"777e6a30ddc68ad3994a32c32d7fc5854af78fe5", @"/Views/Teacher/AttendanceCheck.cshtml")]
    #nullable restore
    public class Views_Teacher_AttendanceCheck : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<String>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777e6a30ddc68ad3994a32c32d7fc5854af78fe53102", async() => {
                WriteLiteral(@"
    <title>Attendance Check</title>
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"" />
    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        form {
            border: 3px solid #f1f1f1;
        }

        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        button:hover {
            opacity: 0.8;
        }

        .cnbtn {
            background-color: #ec3f3f;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 49%;
        }

        .lgnbtn {
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
");
                WriteLiteral(@"            border: none;
            cursor: pointer;
            width: 50%;
            transform: translateX(50%);
        }

        .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
        }

        img.avatar {
            width: 40%;
            border-radius: 50%;
        }

        .container {
            padding: 16px;
        }

        span.psw {
            float: right;
            padding-top: 16px;
        }

        .frmalg {
            margin: auto;
            width: 80%;
        }

        table, th, td {
            border:1px solid black;
            text-align: center;
        }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777e6a30ddc68ad3994a32c32d7fc5854af78fe55826", async() => {
                WriteLiteral(@"
    <div class=""frmalg"">
        <div class=""container"">
            <center>
                <h3>Attendance Check</h3>
            </center>
            <table style=""width:100%"">
                <tr>
                    <th>StudentID</th>
                    <th>StudentName</th>
                    <th>Attendace</th>
                    <th>Note</th>
                </tr>
                <tr>
                    <th>HE141045</th>
                    <th>Le Son Hai</th>
                    <th>
                        <input type=""radio"" name=""Attended"" value=""true"" />Attended
                        <input type=""radio"" name=""Absented"" value=""false""/>Absented
                    </th>
                    <th><input type = ""text""/></th>
                </tr>
                <tr>
                    <th>HE141045</th>
                    <th>Le Son Hai</th>
                    <th>
                        <input type=""radio"" name=""Attended"" value=""true"" />Attended
                   ");
                WriteLiteral(@"     <input type=""radio"" name=""Absented"" value=""false""/>Absented
                    </th>
                    <th><input type = ""text""/></th>
                </tr>
                <tr>
                    <th>HE141045</th>
                    <th>Le Son Hai</th>
                    <th>
                        <input type=""radio"" name=""Attended"" value=""true"" />Attended
                        <input type=""radio"" name=""Absented"" value=""false""/>Absented
                    </th>
                    <th><input type = ""text""/></th>
                </tr>
                <tr>
                    <th>HE141045</th>
                    <th>Le Son Hai</th>
                    <th>
                        <input type=""radio"" name=""Attended"" value=""true"" />Attended
                        <input type=""radio"" name=""Absented"" value=""false""/>Absented
                    </th>
                    <th><input type = ""text""/></th>
                </tr>
            </table>
             <input type=""submi");
                WriteLiteral("t\" value=\"Save\" ID=\"btn_Login\" class=\"lgnbtn\" />\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<String> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591