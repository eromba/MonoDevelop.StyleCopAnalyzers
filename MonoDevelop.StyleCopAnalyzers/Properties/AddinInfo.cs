using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
    "StyleCopAnalyzers",
    Namespace = "MonoDevelop",
    Version = "1.0",
    Url = "https://github.com/eromba/MonoDevelop.StyleCopAnalyzers"
)]

[assembly: AddinName("StyleCopAnalyzers")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("Adds C# analyzers and code fixes from the StyleCopAnalyzers project")]
[assembly: AddinAuthor("Ethan Romba")]
