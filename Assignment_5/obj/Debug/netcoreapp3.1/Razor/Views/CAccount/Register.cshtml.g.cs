#pragma checksum "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\CAccount\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6d48d47d15eac9ab4ed6670f610ca991d6296ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CAccount_Register), @"mvc.1.0.view", @"/Views/CAccount/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6d48d47d15eac9ab4ed6670f610ca991d6296ab", @"/Views/CAccount/Register.cshtml")]
    public class Views_CAccount_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6d48d47d15eac9ab4ed6670f610ca991d6296ab2777", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">


    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1"" crossorigin=""anonymous"">

    <title>Register Page</title>

    <script type=""text/javascript"" language=""javascript"">
	function validate() {
		const errorElements = document.getElementsByClassName('error');
		for(var i = 0; i < errorElements.length; i++) {
			errorElements[i].innerHTML = '';
        }
        if (document.form.fname.value == """") {
            document.getElementsByClassName('error')[0].innerHTML = 'Enter User Name';
            return false;
        }
	    if(document.form.uname.value == """"){
		    document.getElementsByClassName('error')[1].innerHTML = 'Enter User Name' ;
		    return false ;
	    }
	    if(document.form.email.value == """"){
		    document.getElementsByClas");
                WriteLiteral("sName(\'error\')[2].innerHTML = \'Enter Email\' ;\r\n\t\t    return false ;\r\n\t    }\r\n");
                WriteLiteral(@"	    if(document.form.pass.value == """"){
		    document.getElementsByClassName('error')[3].innerHTML = 'Enter Password' ;
		    return false ;
	    }
	    if(document.form.cpass.value == """"){
		    document.getElementsByClassName('error')[4].innerHTML = 'Enter Confrim Password' ;
		    return false ;
	    }
	    if(document.form.pass.value !=  document.form.cpass.value){
		    document.getElementsByClassName('error')[4].innerHTML = 'Password and Confirm Password Not Same' ;
		    return false ;
	    }

            }

     



");
                WriteLiteral("    </script>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6d48d47d15eac9ab4ed6670f610ca991d6296ab5556", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-default bg-dark text-white"">
        <div class=""container-fluid"">
            <h1>Sign Up</h1>
            <a class=""btn btn-success float-right"" href=""/CAccount/LogIn"">Already Have An Account</a>
        </div>
    </nav>
    <div class=""container"">
        <form name=""form"" enctype=""multipart/form-data"" onsubmit=""return validate()"" method=""post"" action=""/CAccount/RegisterForm"">
            <div class=""form-group"">
                <label class=""col-form-label-lg"">Full Name</label>
                <input type=""text"" name=""fname"" class=""form-control"">
                <span style=""color: red"" class=""error""></span>
            </div>
            <div class=""form-group"">
                <label class=""col-form-label-lg"">User Name</label>
                <input type=""text"" name=""uname"" class=""form-control"">
                <span style=""color: red"" class=""error""></span>
            </div>
            <div class=""form-group"">
                <label class=""col-form-l");
                WriteLiteral(@"abel-lg"">Email</label>
                <input type=""email"" name=""email"" class=""form-control"">
                <span style=""color: red"" class=""error""></span>
            </div>
            <div class=""form-group"">
                <label class=""col-form-label-lg"">Password</label>
                <input type=""password"" name=""pass"" class=""form-control"">
                <span style=""color: red"" class=""error""></span>
            </div>
            <div class=""form-group"">
                <label class=""col-form-label-lg"">Confirm Password</label>
                <input type=""password"" name=""cpass"" class=""form-control"">
                <span style=""color: red"" class=""error""></span>
            </div>
            <div class=""form-group"">
                <label class=""col-form-label-lg"">Upload Your Profile Pic : </label>
                <input type=""file"" required name=""PIC"" value=""Browse"">
            </div>
            <br>
            <div>
                <input type=""submit"" name=""submit"" class=");
                WriteLiteral("\"btn btn-success\">\r\n            </div>\r\n        </form>\r\n    </div>\r\n\r\n");
#nullable restore
#line 116 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\CAccount\Register.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            window.onload = function () {\r\n                alert(\"");
#nullable restore
#line 120 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\CAccount\Register.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            };\r\n        </script>\r\n");
#nullable restore
#line 123 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\CAccount\Register.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 125 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\CAccount\Register.cshtml"
     if (ViewBag.Message2 != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            window.onload = function () {\r\n                alert(\"");
#nullable restore
#line 129 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\CAccount\Register.cshtml"
                  Write(ViewBag.Message2);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            };\r\n        </script>\r\n");
#nullable restore
#line 132 "C:\Users\AES\Desktop\MidExam_C#\Assignment_2_EAD\Assignment_5\Assignment_5\Views\CAccount\Register.cshtml"
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