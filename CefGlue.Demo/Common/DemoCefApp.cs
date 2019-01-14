namespace Xilium.CefGlue.Demo
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;
    using System.IO;

    internal sealed class DemoCefApp : CefApp
    {
        private CefBrowserProcessHandler _browserProcessHandler = new DemoBrowserProcessHandler();
        private CefRenderProcessHandler _renderProcessHandler = new DemoRenderProcessHandler();

        protected override void OnRegisterCustomSchemes(CefSchemeRegistrar registrar)
        {
            //registrar.AddCustomScheme("local", true, true, false, false, true, false);
            //registrar.AddCustomScheme("http", true, true, false, false, true, false);
        }

        protected override void OnBeforeCommandLineProcessing(string processType, CefCommandLine commandLine)
        {
            Console.WriteLine("OnBeforeCommandLineProcessing: {0} {1}", processType, commandLine);

            //commandLine.AppendSwitch("disable-gpu", "1");
            //commandLine.AppendSwitch("off-screen-rendering-enabled", "1");
            //-------------------------------------------------------------------------------------
            commandLine.AppendSwitch("js-flags", "--harmony-proxies");
            
            //commandLine.AppendSwitch("renderer-process-limit", "1");
            //commandLine.AppendSwitch("renderer-startup-dialog", "1");
            //commandLine.AppendSwitch("enable-media-stream", "1"); //Enable WebRTC
            //commandLine.AppendSwitch("no-proxy-server", "1"); //Don't use a proxy server, always make direct connections. Overrides any other proxy server flags that are passed.
            //commandLine.AppendSwitch("debug-plugin-loading", "1"); //Dumps extra logging about plugin loading to the log file.
            //commandLine.AppendSwitch("disable-plugins-discovery", "1"); //Disable discovering third-party plugins. Effectively loading only ones shipped with the browser plus third-party ones as specified by --extra-plugin-dir and --load-plugin switches
            commandLine.AppendSwitch("enable-system-flash", "1"); //Automatically discovered and load a system-wide installation of Pepper Flash.
            commandLine.AppendSwitch("allow-running-insecure-content", "1"); //By default, an https page cannot run JavaScript, CSS or plugins from http URLs. This provides an override to get the old insecure behavior. Only available in 47 and above.

            //commandLine.AppendSwitch("enable-logging", "1"); //Enable Logging for the Renderer process (will open with a cmd prompt and output debug messages - use in conjunction with setting LogSeverity = LogSeverity.Verbose;)
            //settings.LogSeverity = LogSeverity.Verbose; // Needed for enable-logging to output messages

            //commandLine.AppendSwitch("disable-extensions", "1"); //Extension support can be disabled
            //commandLine.AppendSwitch("disable-pdf-extension", "1"); //The PDF extension specifically can be disabled

            //Load the pepper flash player that comes with Google Chrome - may be possible to load these values from the registry and query the dll for it's version info (Step 2 not strictly required it seems)
            //commandLine.AppendSwitch("ppapi-flash-path", @"C:\Program Files (x86)\Google\Chrome\Application\47.0.2526.106\PepperFlash\pepflashplayer.dll"); //Load a specific pepper flash version (Step 1 of 2)
            //commandLine.AppendSwitch("ppapi-flash-version", "20.0.0.228"); //Load a specific pepper flash version (Step 2 of 2)

            //NOTE: For OSR best performance you should run with GPU disabled:
            // `--disable-gpu --disable-gpu-compositing --enable-begin-frame-scheduling`
            // (you'll loose WebGL support but gain increased FPS and reduced CPU usage).
            // http://magpcss.org/ceforum/viewtopic.php?f=6&t=13271#p27075
            //https://bitbucket.org/chromiumembedded/cef/commits/e3c1d8632eb43c1c2793d71639f3f5695696a5e8

            //NOTE: The following function will set all three params
            //settings.SetOffScreenRenderingBestPerformanceArgs();
            commandLine.AppendSwitch("disable-gpu", "1");
            commandLine.AppendSwitch("disable-gpu-compositing", "1");
            commandLine.AppendSwitch("enable-begin-frame-scheduling", "1");

            //commandLine.AppendSwitch("disable-gpu-vsync", "1"); //Disable Vsync

            //Disables the DirectWrite font rendering system on windows.
            //Possibly useful when experiencing blury fonts.
            //commandLine.AppendSwitch("disable-direct-write", "1");
            //-------------------------------------------------------------------------------------
            // FLASH: If these were not manually specified then try to add pepflashplayer.dll
            //if (!commandLine.HasSwitch("ppapi-out-of-process") && !commandLine.HasSwitch("register-pepper-plugins"))
            //{
            //    string flashPluginPath = Path.Combine(CLRBrowserSourcePlugin.AssemblyDirectory, "CLRBrowserSourcePlugin", "pepflashplayer.dll");

            //    if (File.Exists(flashPluginPath))
            //    {
            //        commandLine.AppendSwitch("ppapi-out-of-process");
            //        string flashPluginValue = flashPluginPath + ";application/x-shockwave-flash";
            //        commandLine.AppendSwitch("register-pepper-plugins", flashPluginValue);
            //    }
            //}
            //-------------------------------------------------------------------------------------



            //-------------------------------------------------------------------------------------
            // TODO: currently on linux platform location of locales and pack files are determined
            // incorrectly (relative to main module instead of libcef.so module).
            // Once issue http://code.google.com/p/chromiumembedded/issues/detail?id=668 will be resolved
            // this code can be removed.
            if (CefRuntime.Platform == CefRuntimePlatform.Linux)
            {
                var path = new Uri(Assembly.GetEntryAssembly().CodeBase).LocalPath;
                path = Path.GetDirectoryName(path);

                commandLine.AppendSwitch("resources-dir-path", path);
                commandLine.AppendSwitch("locales-dir-path", Path.Combine(path, "locales"));
            }
        }

        protected override CefBrowserProcessHandler GetBrowserProcessHandler()
        {
            return _browserProcessHandler;
        }

        protected override CefRenderProcessHandler GetRenderProcessHandler()
        {
            return _renderProcessHandler;
        }
    }
}
