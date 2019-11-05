// <autogenerated />
using System;
using System.Reflection;
using System.Resources;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
#if !PocketPC && Framework20

using System.Runtime.ConstrainedExecution;

#endif

/* These assembly attributes will be the same regardless of the product. */
[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]
[assembly: AssemblyTrademark("")]

/* These attributes will change for each assembly. */
[assembly: AssemblyProduct("DotSpatial.Positioning")]


#if PocketPC
   [assembly: AssemblyTitle("DotSpatial.Positioning.PocketPC")]
#else
   [assembly: AssemblyTitle("DotSpatial.Positioning")]
#endif

[assembly: AssemblyDescription("This assembly provides objects used to design geographic applications.")]

/* Compact Framework 1.0 requires that design-time assemblies contain a special assembly attribute to link them
 * up to the assemblies to use on the mobile device.
 */
#if DesignTime && !Framework20
    [assembly: System.CF.Design.RuntimeAssembly("DotSpatial.Positioning.PocketPC, Version=1.4.5000.7, Culture=neutral, PublicKeyToken=d77afaeb30e3236a")]
#endif

/* This assembly contains language-specific resources.  Help the CLR find them. */
#if Framework20 && !PocketPC
[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.MainAssembly)]
#endif

/* The assembly configuration just explains what target platform this assembly is for.  This
 * will be used instead of version numbers from now on to indicate the target platform.
 */
#if PocketPC
#if Framework30
        [assembly: AssemblyConfiguration("Public Release for .NET Compact Framework 3.5")]
#elif Framework20
        [assembly: AssemblyConfiguration("Public Release for .NET Compact Framework 2.0")]
#else
	    [assembly: AssemblyConfiguration("Public Release for .NET Compact Framework 1.0")]
#endif
#else
#if Framework40
[assembly: AssemblyConfiguration("Public Release for .NET Framework 4.0")]
#elif Framework30
        [assembly: AssemblyConfiguration("Public Release for .NET Framework 3.5")]
#elif Framework20
        [assembly: AssemblyConfiguration("Public Release for .NET Framework 2.0")]
#elif Framework10
        [assembly: AssemblyConfiguration("Public Release for .NET Framework 1.0")]
#else
        [assembly: AssemblyConfiguration("Public Release for .NET Framework 1.1")]
#endif
#endif

/* There are security and performance benefits of explicitly declaring permissions required
 * by this assembly.  They are requested now and asserted explicitly to remove the need for
 * time-consuming or redundant security checks.
 */
#if !PocketPC || DesignTime

// Allow partially-trusted callers to use this code (such as ASP.NET)
[assembly: AllowPartiallyTrustedCallers]

#endif