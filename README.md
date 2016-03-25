# GlobalSight Web Services API - C# Starter Project

This is a simple bare bones example of using the [GlobalSight Web Services API](http://www.globalsight.com/wiki/index.php/GlobalSight_Web_Services_API) 
from C#. This shows how to connect to GlobalSight, and call one simple operation (getting the version of GlobalSight you are connected to), but should give you a template for 
wrapping other API functions.

Here are some related blog posts where I outlined how to do some simple operations using the API.

[Interacting with the GlobalSight Web Services API from C#](http://www.jimmycollins.org/blog/?p=707)
[GlobalSight Web Services API: Automate Translation Memory Upload](http://www.jimmycollins.org/blog/?p=724)
[GlobalSight Web Services API: Job Creation](http://www.jimmycollins.org/blog/?p=733)
[GlobalSight Web Services API: Manipulating Workflows Programmatically](http://www.jimmycollins.org/blog/?p=747)

### Notes

The solution contains two C# projects:

1. GlobalSightLib - a class library that talks to GlobalSight.

You need to modify the GlobalSight URL at the top of Main.cs to point to the GlobalSight server you want to connect to.

2. GlobalSightAPITesting - a console app that references GlobalSightLib, and shows a simple example of authenticating and calling a function.

You need to change the GlobalSight Username & Password in Program.cs

Ensure that the account you are using has the relevant access, and that your IP is whitelisted if you have that feature turned on in GlobalSight.
