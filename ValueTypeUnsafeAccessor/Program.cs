using PrivateLib;
using System.Runtime.CompilerServices;

[UnsafeAccessor(UnsafeAccessorKind.Method, Name = "GetBar")]
[return: UnsafeAccessorType("PrivateLib.Bar, PrivateLib")]
extern static object GetBar(PublicClass item);

[UnsafeAccessor(UnsafeAccessorKind.Field, Name = "x")]
extern static int GetX(ref object bar);

PublicClass c = new();
object bar = GetBar(c);
int x = GetX(ref bar);
Console.WriteLine(x);