// *************************************30*************************************
// <copyright file="AssemblyInfo.cs" company="GalaSoft Laurent Bugnion">
// Copyright © GalaSoft Laurent Bugnion 2009-2013
// </copyright>
// ****************************************************************************
// <author>Laurent Bugnion</author>
// <email>laurent@galasoft.ch</email>
// <date>3.11.2009</date>
// <project>GalaSoft.MvvmLight.Extras</project>
// <web>http://www.galasoft.ch</web>
// <license>
// See license.txt in this project or http://www.galasoft.ch/license_MIT.txt
// </license>
// <LastBaseLevel>BL0023</LastBaseLevel>
// ****************************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

#if !NETFX_CORE
#if !XAMARIN
using System.Windows.Markup;
#endif
#endif

[assembly: AssemblyTitle("GalaSoft.MvvmLight.Extras modified by exocad GmbH originally based on work of GalaSoft Laurent Bugnion")]
[assembly: AssemblyDescription("Extras components to implement Model-View-ViewModel applications in WPF, Silverlight and Windows Phone 7")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("exocad GmbH based on work of GalaSoft Laurent Bugnion @ http://www.galasoft.ch")]
[assembly: AssemblyProduct("GalaSoft.MvvmLight.Extras modified by exocad GmbH originally based on work of GalaSoft Laurent Bugnion")]
[assembly: AssemblyCopyright("Copyright © exocad GmbH 2020, GalaSoft Laurent Bugnion 2009-2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

#if !NETFX_CORE
#if !XAMARIN
[assembly: XmlnsDefinition("http://www.galasoft.ch/mvvmlight", "GalaSoft.MvvmLight.Command")]
#endif
#endif

[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly:NeutralResourcesLanguage("en-US")]

[assembly: AssemblyVersion("4.2.30.*")]
[assembly: AssemblyInformationalVersion("4.2.30-exo-v1")]
////[assembly: AssemblyFileVersion("4.2.30.0/BL0030")]