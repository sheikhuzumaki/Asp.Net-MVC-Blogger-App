#pragma checksum "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\AdminDashBoard\AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1554a3f20faecd2f6c5f07741bef73dc8efb915"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminDashBoard_AddUser), @"mvc.1.0.view", @"/Views/AdminDashBoard/AddUser.cshtml")]
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
#line 1 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\AdminDashBoard\AddUser.cshtml"
using Assignment_5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1554a3f20faecd2f6c5f07741bef73dc8efb915", @"/Views/AdminDashBoard/AddUser.cshtml")]
    public class Views_AdminDashBoard_AddUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1554a3f20faecd2f6c5f07741bef73dc8efb9153017", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">


    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1"" crossorigin=""anonymous"">

    <title>User DashBoard</title>
    <script type=""text/javascript"" language=""javascript"">
	function validate() {
		const errorElements = document.getElementsByClassName('error');
		for(var i = 0; i < errorElements.length; i++) {
			errorElements[i].innerHTML = '';
        }
        if (document.form.fname.value == """") {
            document.getElementsByClassName('error')[0].innerHTML = 'Enter Name';
            return false;
        }
	    if(document.form.uname.value == """"){
		    document.getElementsByClassName('error')[1].innerHTML = 'Enter User Name' ;
		    return false ;
	    }
	    if(document.form.email.value == """"){
		    document.getElementsByClassName(");
                WriteLiteral("\'error\')[2].innerHTML = \'Enter Email\' ;\r\n\t\t    return false ;\r\n\t    }\r\n\t    if(document.form.pass.value == \"\"){\r\n\t\t    document.getElementsByClassName(\'error\')[3].innerHTML = \'Enter Password\' ;\r\n\t\t    return false ;\r\n\t    }\r\n\r\n\t\r\n\r\n    }\r\n    </script>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1554a3f20faecd2f6c5f07741bef73dc8efb9155361", async() => {
                WriteLiteral(@"

    <nav class=""navbar navbar-expand-lg navbar-dark bg-dark text-white"">
        <div class=""collapse navbar-collapse"" id=""navbarNav"">
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link "" href=""/AdminCont/Index"">Home</a>
                </li>
                <li class=""nav-item "">
                    <a class=""nav-link active"" href=""/AdminDashBoard/AddUser"">Add User</a>
                </li>
                <li class=""nav-item "">
                    <a class=""nav-link"" href=""/CAccount/LogIn"">Log Out</a>
                </li>
            </ul>
        </div>
    </nav>
    <div class=""container"">
        <form name=""form"" enctype=""multipart/form-data"" onsubmit=""return validate()"" method=""post"" action=""/AdminDashBoard/AddUserForm"">
            <div class=""form-group"">
                <label class=""col-form-label-lg"">Full Name</label>
                <input type=""text"" name=""fname"" class=""form-control"">
                <span st");
                WriteLiteral(@"yle=""color: red"" class=""error""></span>
            </div>
            <div class=""form-group"">
                <label class=""col-form-label-lg"">User Name</label>
                <input type=""text"" name=""uname"" class=""form-control"">
                <span style=""color: red"" class=""error""></span>
            </div>
            <div class=""form-group"">
                <label class=""col-form-label-lg"">Email</label>
                <input type=""email"" name=""email"" class=""form-control"">
                <span style=""color: red"" class=""error""></span>
            </div>
            <div class=""form-group"">
                <label class=""col-form-label-lg"">Password</label>
                <input type=""password"" name=""pass"" class=""form-control"">
                <span style=""color: red"" class=""error""></span>
            </div>
            <div class=""form-group"">
                <label class=""col-form-label-lg"">Upload Your Profile Pic : </label>
                <input type=""file"" required name=""PIC"" valu");
                WriteLiteral("e=\"Browse\">\r\n            </div>\r\n            <br>\r\n            <div>\r\n                <input type=\"submit\" name=\"submit\" class=\"btn btn-success\">\r\n            </div>\r\n        </form>\r\n    </div>\r\n");
#nullable restore
#line 90 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\AdminDashBoard\AddUser.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            window.onload = function () {\r\n                alert(\"");
#nullable restore
#line 94 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\AdminDashBoard\AddUser.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            };\r\n        </script>\r\n");
#nullable restore
#line 97 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\AdminDashBoard\AddUser.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 99 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\AdminDashBoard\AddUser.cshtml"
     if (ViewBag.Message2 != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            window.onload = function () {\r\n                alert(\"");
#nullable restore
#line 103 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\AdminDashBoard\AddUser.cshtml"
                  Write(ViewBag.Message2);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            };\r\n        </script>\r\n");
#nullable restore
#line 106 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\AdminDashBoard\AddUser.cshtml"
    }

#line default
#line hidden
#nullable disable
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
