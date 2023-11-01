# Event

## 1. Define

```cs
/// <summary>
/// Event Demo
/// </summary>
public struct Event_Demo
{
    public string _Param;
}
```

## 2. Send

```cs
this.SendEvent(new Event_Demo() { _Param = "Hello World" });
```

## 3. Register

```cs
this.RegisterEvent<Event_Demo>((args)=>{
    Debug.Log(args._Param);
});
```
