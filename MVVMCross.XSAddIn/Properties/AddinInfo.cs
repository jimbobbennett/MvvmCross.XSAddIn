using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin (
    "MVVMCross.XSAddIn",
    Namespace = "MVVMCross.XSAddIn",
    Version = "1.0.1"
)]

[assembly: AddinName ("MvvmCross Template pack")]
[assembly: AddinCategory ("IDE extensions")]
[assembly: AddinDescription ("Adds a new project type for creating cross-plaform MvvmCross apps.  The project that is created is " +
                             "the same as what you would get if you installed the MvvmCross Start Pack nuget and followed the instructions.")]
[assembly: AddinAuthor ("Jim Bennett")]

