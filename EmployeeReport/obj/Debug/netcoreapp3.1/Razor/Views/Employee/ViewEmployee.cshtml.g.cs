#pragma checksum "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7901c6570163a1cc2efe913442ab3c9c604c80e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ViewEmployee), @"mvc.1.0.view", @"/Views/Employee/ViewEmployee.cshtml")]
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
#line 1 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\_ViewImports.cshtml"
using EmployeeReport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\_ViewImports.cshtml"
using EmployeeReport.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7901c6570163a1cc2efe913442ab3c9c604c80e", @"/Views/Employee/ViewEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a654f1fdf4f8357082a51fca78cf327e35d71d48", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ViewEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeReport.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row justify-content-between my-2\">\r\n        <button onclick=\"history.go(-1)\" class=\"btn btn-outline-primary\">&larr; Back</button>\r\n        <div class=\"row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7901c6570163a1cc2efe913442ab3c9c604c80e6066", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7901c6570163a1cc2efe913442ab3c9c604c80e6340", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 9 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <button class=\"btn btn-light\">Edit info</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 476, "\"", 483, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Print</a>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7901c6570163a1cc2efe913442ab3c9c604c80e10017", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7901c6570163a1cc2efe913442ab3c9c604c80e10292", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 14 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <button class=\"btn btn-outline-danger\">Delete</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <div class=\"my-2 pt-2 px-2 pb-1 d-flex bg-light\">\r\n                <div class=\"col\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7901c6570163a1cc2efe913442ab3c9c604c80e13989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 953, "~/images/", 953, 9, true);
#nullable restore
#line 23 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
AddHtmlAttributeValue("", 962, Model.ProfilePicture, 962, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-8\">\r\n                    <div class=\"mb-2\">\r\n                        <h6>Name</h6>\r\n                        <p class=\"lead itemFontSize\">");
#nullable restore
#line 28 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"my-2\">\r\n                        <h6>Gender</h6>\r\n                        <p class=\"lead itemFontSize\">");
#nullable restore
#line 32 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"my-2 pt-2 px-2 bg-light\">\r\n                <h6>Email</h6>\r\n                <p class=\"lead itemFontSize\">");
#nullable restore
#line 39 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                        Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"my-2 pt-2 px-2 bg-light\">\r\n                <h6>Phone</h6>\r\n                <p class=\"lead itemFontSize\">");
#nullable restore
#line 43 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                        Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"my-2 pt-2 px-2 bg-light\">\r\n                <h6>Salary</h6>\r\n                <p class=\"lead itemFontSize\">");
#nullable restore
#line 47 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                        Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col\">\r\n            <div class=\"my-2 pt-2 px-2 bg-light\">\r\n                <h6>NID</h6>\r\n                <p class=\"lead itemFontSize\">");
#nullable restore
#line 54 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                        Write(Model.NID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"my-2 pt-2 px-2 bg-light\">\r\n                <h6>Country</h6>\r\n                <p class=\"lead itemFontSize\">");
#nullable restore
#line 58 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                        Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"my-2 pt-2 px-2 bg-light\">\r\n                <h6>Company</h6>\r\n                <p class=\"lead itemFontSize\">");
#nullable restore
#line 62 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                        Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"my-2 pt-2 px-2 bg-light\">\r\n                <h6>Joining Date</h6>\r\n                <p class=\"lead itemFontSize\">");
#nullable restore
#line 66 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                        Write(Model.JoiningDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"my-2 pt-2 px-2 bg-light\">\r\n                <h6>Mailing Address</h6>\r\n                <p class=\"lead itemFontSize\">");
#nullable restore
#line 70 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                        Write(Model.MailingAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
    <div class=""row"">
        <table class=""table table-striped table-bordered"">
            <thead>
                <tr>
                    <td>Education</td>
                    <td>Institute</td>
                    <td>Passing Year</td>
                    <td>Board / Faculty</td>
                    <td>Grade</td>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td style=""width: 10%"">
                        <p class=""lead itemFontSize"">SSC</p>
                    </td>
                    <td>
                        <p class=""lead itemFontSize"">");
#nullable restore
#line 91 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                Write(Model.SchoolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                    <td style=\"width: 12%\">\r\n                        <p class=\"lead itemFontSize\">");
#nullable restore
#line 94 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                Write(Model.SscPassingYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                    <td>\r\n                        <p class=\"lead itemFontSize\">");
#nullable restore
#line 97 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                Write(Model.SscBoard);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                    <td style=\"width: 12%\">\r\n                        <div class=\"row\">\r\n                            <p class=\"lead itemFontSize pl-2\">");
#nullable restore
#line 101 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                         Write(Model.SscGrade);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            &nbsp;
                            /
                            &nbsp;
                            <p class=""lead itemFontSize"">5.00</p>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td style=""width: 10%"">
                        <p class=""lead itemFontSize"">HSC</p>
                    </td>
                    <td>
                        <p class=""lead itemFontSize"">");
#nullable restore
#line 114 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                Write(Model.CollegeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                    <td style=\"width: 12%\">\r\n                        <p class=\"lead itemFontSize\">");
#nullable restore
#line 117 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                Write(Model.HscPassingYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                    <td>\r\n                        <p class=\"lead itemFontSize\">");
#nullable restore
#line 120 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                Write(Model.HscBoard);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                    <td style=\"width: 12%\">\r\n                        <div class=\"row\">\r\n                            <p class=\"lead itemFontSize pl-2\">");
#nullable restore
#line 124 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                         Write(Model.HscGrade);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            &nbsp;
                            /
                            &nbsp;
                            <p class=""lead itemFontSize"">5.00</p>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td style=""width: 10%"">
                        <p class=""lead itemFontSize"">BSC</p>
                    </td>
                    <td>
                        <p class=""lead itemFontSize"">");
#nullable restore
#line 137 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                Write(Model.UniversityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                    <td style=\"width: 12%\">\r\n                        <p class=\"lead itemFontSize\">");
#nullable restore
#line 140 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                Write(Model.GraduationYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                    <td>\r\n                        <p class=\"lead itemFontSize\">");
#nullable restore
#line 143 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                Write(Model.FacultyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                    <td style=\"width: 12%\">\r\n                        <div class=\"row\">\r\n                            <p class=\"lead itemFontSize pl-2\">");
#nullable restore
#line 147 "C:\Users\USER-PC\source\repos\EmployeeReport\EmployeeReport\Views\Employee\ViewEmployee.cshtml"
                                                         Write(Model.BechelorGrade);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            &nbsp;
                            /
                            &nbsp;
                            <p class=""lead itemFontSize"">4.00</p>
                        </div>
                    </td>
                </tr>

            </tbody>
        </table>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeReport.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
