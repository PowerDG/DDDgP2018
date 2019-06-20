

An error occurred during the compilation of a resource required to process this request. Please review the following specific error details and modify your source code appropriately.
C:\foowwdg\ResearchHome\ResearchHome\Areas\Introduction\Views\ReadBooks\EditReadBook.cshtml

    'BookModel' does not contain a definition for 'Commentary' and no extension method 'Commentary' accepting a first argument of type 'BookModel' could be found (are you missing a using directive or an assembly reference?)

                        <textarea id="txtDescription" rows="8" asp-for="Commentary" maxlength="200" placeholder="请输入描述" class="layui-textarea"></textarea>





------

An error occurred during the compilation of a resource required to process this request. Please review the following specific error details and modify your source code appropriately.
Generated Code
One or more compilation references are missing. Ensure that your project is referencing 'Microsoft.NET.Sdk.Web' and the 'PreserveCompilationContext' property is not set to false.

    Type expected

        }

Type expected

        }

Type expected

        }

Type expected

        }

The type or namespace name 'BookModel' does not exist in the namespace 'ResearchHome.Areas.Introduction.Models' (are you missing an assembly reference?)

        public class Areas_Introduction_Views_ReadBooks_EditReadBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResearchHome.Areas.Introduction.Models.BookModel>

The type or namespace name 'BookModel' does not exist in the namespace 'ResearchHome.Areas.Introduction.Models' (are you missing an assembly reference?)

            public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResearchHome.Areas.Introduction.Models.BookModel> Html { get; private set; }

The type or namespace name 'BookModel' does not exist in the namespace 'ResearchHome.Areas.Introduction.Models' (are you missing an assembly reference?)

        }

The type or namespace name 'BookModel' does not exist in the namespace 'ResearchHome.Areas.Introduction.Models' (are you missing an assembly reference?)

        }

The type or namespace name 'BookModel' does not exist in the namespace 'ResearchHome.Areas.Introduction.Models' (are you missing an assembly reference?)

        }

The type or namespace name 'BookModel' does not exist in the namespace 'ResearchHome.Areas.Introduction.Models' (are you missing an assembly reference?)

            }






-----------------
An unhandled exception occurred while processing the request.
InvalidOperationException: The model item passed into the ViewDataDictionary is of type 'ResearchHome.Areas.Book.Models.BookModel', but this ViewDataDictionary instance requires a model item of type 'ResearchHome.Areas.Introduction.Models.ReadBooks'.

Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary.EnsureCompatible(object value)

    Stack Query Cookies Headers 

    InvalidOperationException: The model item passed into the ViewDataDictionary is of type 'ResearchHome.Areas.Book.Models.BookModel',
     but this ViewDataDictionary instance requires a model item of type 'ResearchHome.Areas.Introduction.Models.ReadBooks'.
        Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary.EnsureCompatible(object value)
        Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary..ctor(ViewDataDictionary source, object model, Type declaredModelType)
        lambda_method(Closure , ViewDataDictionary )
        Microsoft.AspNetCore.Mvc.Razor.Internal.RazorPagePropertyActivator.CreateViewDataDictionary(ViewContext context)
        Microsoft.AspNetCore.Mvc.Razor.Internal.RazorPagePropertyActivator.Activate(object page, ViewContext context)
        Microsoft.AspNetCore.Mvc.Razor.RazorPageActivator.Activate(IRazorPage page, ViewContext context)
        Microsoft.AspNetCore.Mvc.Razor.RazorView.RenderPageCoreAsync(IRazorPage page, ViewContext context)
        Microsoft.AspNetCore.Mvc.Razor.RazorView.RenderPageAsync(IRazorPage page, ViewContext context, bool invokeViewStarts)
        Microsoft.AspNetCore.Mvc.Razor.RazorView.RenderAsync(ViewContext context)
        Microsoft.AspNetCore.Mvc.ViewFeatures.ViewExecutor.ExecuteAsync(ViewContext viewContext, string contentType, Nullable<int> statusCode)
        Microsoft.AspNetCore.Mvc.ViewFeatures.ViewExecutor.ExecuteAsync(ActionContext actionContext, IView view, ViewDataDictionary viewData, ITempDataDictionary tempData, string contentType, Nullable<int> statusCode)
        Microsoft.AspNetCore.Mvc.ViewFeatures.ViewResultExecutor.ExecuteAsync(ActionContext context, ViewResult result)
        Microsoft.AspNetCore.Mvc.ViewResult.ExecuteResultAsync(ActionContext context)
        Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.InvokeResultAsync(IActionResult result)
        Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.InvokeNextResultFilterAsync<TFilter, TFilterAsync>()
        Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Rethrow(ResultExecutedContext context)
        Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.ResultNext<TFilter, TFilterAsync>(ref State next, ref Scope scope, ref object state, ref bool isCompleted)
        Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.InvokeResultFilters()
        Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.InvokeNextResourceFilter()
        Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Rethrow(ResourceExecutedContext context)
        Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Next(ref State next, ref Scope scope, ref object state, ref bool isCompleted)
        Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.InvokeFilterPipelineAsync()
        Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.InvokeAsync()
        Microsoft.AspNetCore.Builder.RouterMiddleware.Invoke(HttpContext httpContext)
        Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware.Invoke(HttpContext context)
        Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
        Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware.Invoke(HttpContext context)

