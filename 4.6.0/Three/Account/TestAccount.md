测试账号用户名 

member1,member2,

admintest1,admintest2， 

sun用1 wang用2 ，

密码都是123456







```csharp
System.ArgumentNullException
  HResult=0x80004003
  Message=Value cannot be null.
Arg_ParamName_Name
  Source=System.Linq
  StackTrace:
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at ResearchHome.Areas.Book.Controllers.BooksController.GetSearchBooks(String search, Int32 page, Int32 limit, Int32& booksCount) in C:\foowwdg\ResearchHome\ResearchHome\Areas\Book\Controllers\BooksController.cs:line 217
   at ResearchHome.Areas.Book.Controllers.BooksController.GetBooks(Int32 page, Int32 limit, String queryType, String search) in C:\foowwdg\ResearchHome\ResearchHome\Areas\Book\Controllers\BooksController.cs:line 187
   at Microsoft.Extensions.Internal.ObjectMethodExecutor.Execute(Object target, Object[] parameters)
   at Microsoft.AspNetCore.Mvc.Internal.ActionMethodExecutor.SyncActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvoker.<InvokeActionMethodAsync>d__12.MoveNext()
```

