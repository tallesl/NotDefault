# Not default

[![][build-img]][build]
[![][nuget-img]][nuget]

[build]:     https://ci.appveyor.com/project/TallesL/NotDefault
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/NotDefault

[nuget]:     http://badge.fury.io/nu/NotDefault
[nuget-img]: https://badge.fury.io/nu/NotDefault.png

Extension method that returns if the given object value isn't [default(T)][default].

[default]: https://msdn.microsoft.com/library/xwth0h0d.aspx

```cs
using NotDefault;

1337.NotDefault(); // True
0.NotDefault();    // False
```
