using UnityEngine;
using QFramework;

public class Controller : MonoBehaviour, IController
{
    public IArchitecture GetArchitecture()
    {
        return VRURPStarterApp.Interface;
    }
}
