﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("единорогобразцы")>]
[<assembly: AssemblyProductAttribute("единорогобразцы")>]
[<assembly: AssemblyDescriptionAttribute("Образцы кода , что только может быть описано как " единорог " образцов ! ")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
