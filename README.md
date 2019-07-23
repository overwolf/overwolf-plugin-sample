Overwolf Plugin Sample
======================

If you want to leverage your existing C#/C/C++ code you can wrap it inside an Overwolf Plugin DLL file and communicate with it via your Overwolf WebApp.
The plugin is written in C# but you can use CLI or PInvoke to wrap your C/C++ code as well.

overwolf-plugin-sample
======================
Contains a sample plugin with functions, callbacks and event


sampleapp
======================
This is an unpacked Overwolf WebApp that utilizes the Overwolf Plugin Sample.

NOTE: the DLL file is placed inside of the WebApp's directory - so if you recompile it, you'll need to place the new DLL file inside the folder (overriding the existing dll file).

Please review the manifest.json file to view how to reference the Plugin file.

Please, don't hesitate to ask us questions in our developers forum: https://discuss.developers.overwolf.com/.

The Overwolf Team
