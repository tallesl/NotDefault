# NotDefault

[![][build-img]][build]
[![][nuget-img]][nuget]

Extension method that returns if the given object value isn't [default(T)].


[build]:      https://ci.appveyor.com/project/TallesL/net-notdefault
[build-img]:  https://ci.appveyor.com/api/projects/status/github/tallesl/net-notdefault?svg=true
[nuget]:      https://www.nuget.org/packages/NotDefault
[nuget-img]:  https://badge.fury.io/nu/NotDefault.svg
[default(T)]: https://msdn.microsoft.com/library/xwth0h0d.aspx

```cs
using NotDefaultLibrary;

1337.NotDefault(); // True
0.NotDefault();    // False
```
