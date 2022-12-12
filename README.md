# .Net Maui

## NugGet Packages 
- Put simply, a NuGet package is a single ZIP file with the .nupkg extension that contains compiled code (DLLs), other files related to that code, and a descriptive manifest that includes information like the package's version number.
- Developers with code to share create packages and publish them to a public or private host. Package consumers obtain those packages from suitable hosts, add them to their projects, and then call a package's functionality in their project code. NuGet itself then handles all of the intermediate details.

## Folders
- Maui initializes with a `Resources` folder that has everything from fontsto images

## Files
- `MauiProgram.cs` is the file that gets called and actuallty run the application
- it registers the <App>() which can eb found in the `App.xaml` file.
- `Xaml` is an `xml` based mark-up. The `App.xaml` is defining applicationr esources across the entire app.
- Behind every `xaml` page is a code file that is associated with that `xaml` page
- `AppShell` hosts the start-page content of the application. By default it is called the `MainPage`. Which is another default file `xaml` file

## Developer Mode
- to have access to to the powerful debugging tools, hot reload, preview tools of MAUI, your windows machines needs to be set to developer mode.
- Running the application from the debugger will fire a native application that runs in a debugger window. (very cool)

## Tools
- `XAML LIVE PREVIEW` one of the tabs when the the debugger is running. Allows you to see a nested preview of the application in VS, that you can see the properties of elemts by hovering over them.
  - When you tap on a element in the live preview, it will actually take you to that element's xaml code
- `Live Visual Tree` - (debugger running) Provided that Hot Reload is enabled, the Live Visual Tree window will display the hierarchy of your app's UI elements regardless of whether the app's UI is built using XAML or C#. However, you will have to disable Just My XAML to display the hierarchy of your app's UI elements for UIs built using C#.
- `Hot Reload` if you make changes to the C# code, you can save, and hit the `Hot Reload` button next to the debugger to reload with the new code
- In the `Xaml` files, if you add new elements, for example a Button. If you give it a clicked event, a handler and the subsequent C# code will be generated for you (very cool)
- MVVM - Model View View Model - an architecture pattern that allows data binding