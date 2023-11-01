# Command

## 1. File name

The formatIs is `CMD_CommandName`.

## 2. File content

```cs
using UnityEngine;
using QFramework;

/// <summary>
/// Command Demo
/// </summary>
public class CMD_CommandDemo : AbstractCommand
{
    string param;

    public CMD_CommandDemo(string param)
    {
        this.param = param;
    }

    protected override void OnExecute()
    {
        Debug.Log(param);
    }
}
```
## 3. Usage

```cs
this.SendCommand(new CMD_CommandDemo("Hello World"));
```
