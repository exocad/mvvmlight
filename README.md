# MVVM Light Toolkit

> MVVM Light is not maintained anymore. Over the years, thousands of users have found this project useful with millions of downloads. We are truly overwhelmed by the kindness shown by a huge amount of members of this awesome community. Thanks so much for making this little project so popular and for making it all worthwhile.
> We strongly recommend [looking into the Microsoft MVVM Toolkit](https://docs.microsoft.com/windows/communitytoolkit/mvvm/introduction), an open source project from the Windows Community Toolkit, as the successor of MVVM Light.

The main purpose of the toolkit is to accelerate the creation and development of MVVM applications in Xamarin.Android, Xamarin.iOS, Xamarin.Forms, Windows 10 UWP, Windows Presentation Foundation (WPF), Silverlight, Windows Phone.

## Get started

More information about the MVVM Light Toolkit can be found on http://www.mvvmlight.net.

Documentation: See http://www.mvvmlight.net/doc

## License

Under [MIT License](http://www.galasoft.ch/license_MIT.txt).

## exocad specific

This is a fork of the original repository at https://github.com/lbugnion/mvvmlight which adds .NET Core
support to `GalaSoft.MvvmLight` and `GalaSoft.MvvmLight.Extras`. Support for older frameworks and 
platforms other than Windows has been removed.

The following changes were made:

- To avoid references to prebuilt assemblies, `System.Windows.Interactivity` has been replaced with
  [Microsoft.Xaml.Behaviors.Wpf](https://www.nuget.org/packages/Microsoft.Xaml.Behaviors.Wpf).
- Library code that was added via links has been moved to the `Exocad.GalaSoft.MvvmLight` and
  `Exocad.GalaSoft.MvvmLight.Extras` directories.
- A `Directory.Build.props` file has been introduced.
- NuGet related properties were added and NuGet packages are now generated during build.



