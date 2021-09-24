using LiveSplit.UI.Components;
using LiveSplit.SupAutoSplit;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComponentFactory(typeof(Factory))]

// アセンブリに関する一般情報は以下の属性セットをとおして制御されます。
// アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更してください。
[assembly: AssemblyTitle("supAutoSplit")]
[assembly: AssemblyDescription("An auto splitter for LiveSplit using OpenCV and template matching")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("supAutoSplit")]
[assembly: AssemblyCopyright("Copyright © 2021 sup39[サポミク]")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ComVisible を false に設定すると、このアセンブリ内の型は COM コンポーネントから
// 参照できなくなります。COM からこのアセンブリ内の型にアクセスする必要がある場合は、
// その型の ComVisible 属性を true に設定してください。
[assembly: ComVisible(false)]

// このプロジェクトが COM に公開される場合、次の GUID が typelib の ID になります
[assembly: Guid("c1b6a79e-088a-411c-b546-4d72447b4daa")]

// アセンブリのバージョン情報は次の 4 つの値で構成されています:
//
//      メジャー バージョン
//      マイナー バージョン
//      ビルド番号
//      Revision
//
// すべての値を指定するか、次を使用してビルド番号とリビジョン番号を既定に設定できます
// 以下のように '*' を使用します:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.1.0.0")]
// [assembly: AssemblyFileVersion("0.1.0.0")]
