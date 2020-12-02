# asp.net-mvc5-new-project-format
Sample MVC 5 application that uses new project format


Open and run using VS, navigate to http://localhost:5001

You can also create webdeploy package using publish.cmd (adjust paths).

-------------------

# Run|Debug in Rider

## Step 1. Run using launchSettings.json (Debug will not work)

You can run project simply by using configured `launchSettings.json`:

```JSON
{
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:5001",
      "sslPort": 0
    }
  },
  "profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true
    }
  }
}
```

## Step 2. ".Net Executable" debug configuration

Rider automatically creates `applicationhost.config` in the `.idea` folder on Step 1.

Now you can run debug with IIS Express against ".Net Executable" run configuration. 

- Create new `.NET Executable` configuration
- Set `Exe path` to `C:/Program Files (x86)/IIS Express/iisexpress.exe`
- Set program arguments to `/config:<absolute path>\.idea\config\applicationhost.config /site:Application.Web /apppool:Clr4IntegratedAppPool` 
