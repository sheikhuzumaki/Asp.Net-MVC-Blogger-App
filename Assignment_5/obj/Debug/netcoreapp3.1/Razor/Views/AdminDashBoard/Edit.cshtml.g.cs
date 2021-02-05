#pragma checksum "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\AdminDashBoard\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00919ce0cb66d71ae0ed3100635bddea6cdca20b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminDashBoard_Edit), @"mvc.1.0.view", @"/Views/AdminDashBoard/Edit.cshtml")]
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
#line 1 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\AdminDashBoard\Edit.cshtml"
using Assignment_5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00919ce0cb66d71ae0ed3100635bddea6cdca20b", @"/Views/AdminDashBoard/Edit.cshtml")]
    public class Views_AdminDashBoard_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00919ce0cb66d71ae0ed3100635bddea6cdca20b2999", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">


    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1"" crossorigin=""anonymous"">

    <title>User DashBoard</title>
    <script type=""text/javascript"" language=""javascript"">
        function validate() {
            const errorElements = document.getElementsByClassName('error');
            for (var i = 0; i < errorElements.length; i++) {
                errorElements[i].innerHTML = '';
            }
            if (document.form.name.value == """") {
                document.getElementsByClassName('error')[0].innerHTML = 'Enter Name';
                return false;
            }
            if (document.form.uname.value == """") {
                document.getElementsByClassName('error')[1].innerHTML = 'Enter User Name';
                return false;
  ");
                WriteLiteral(@"          }
            if (document.form.email.value == """") {
                document.getElementsByClassName('error')[2].innerHTML = 'Enter Email';
                return false;
            }
            if (document.form.pass.value == """") {
                document.getElementsByClassName('error')[3].innerHTML = 'Enter Password';
                return false;
            }


        }

    </script>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00919ce0cb66d71ae0ed3100635bddea6cdca20b5467", async() => {
                WriteLiteral(@"

    <nav class=""navbar navbar-default bg-dark text-white"">
        <div class=""container-fluid"">
            <h1>Edit User Profile</h1>
            <a class=""btn btn-success float-right"" href=""/AdminCont/Index"">Back</a>
        </div>
    </nav>
    <br />
    <div class=""container"">
        <h1>Profile</h1>
        <div class=""container"">
            <form name=""form"" method=""post"" onsubmit=""return validate()"" action=""/AdminDashBoard/EditForm"">
                <div class=""form-group"">
                    <label class=""col-form-label-lg"">Name</label>
                    <input type=""text"" name=""name"" class=""form-control"">
                    <span style=""color: red"" class=""error""></span>
                </div>
                <div class=""form-group"">
                    <label class=""col-form-label-lg"">User Name</label>
                    <input type=""text"" name=""uname"" class=""form-control"">
                    <span style=""color: red"" class=""error""></span>
                </div>
   ");
                WriteLiteral(@"             <div class=""form-group"">
                    <label class=""col-form-label-lg"">Email</label>
                    <input type=""email"" name=""email"" class=""form-control"">
                    <span style=""color: red"" class=""error""></span>
                </div>
                <div class=""form-group"">
                    <label class=""col-form-label-lg"">Password</label>
                    <input type=""password"" name=""pass"" class=""form-control"">
                    <span style=""color: red"" class=""error""></span>
                </div>
                <br />
                <div class=""form-group"">
                    <input type=""hidden"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 3226, "\"", 3240, 1);
#nullable restore
#line 76 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\AdminDashBoard\Edit.cshtml"
WriteAttributeValue("", 3234, Model, 3234, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"submit\" class=\"btn btn-primary\" value=\"Update\" />\r\n                </div>\r\n            </form>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
