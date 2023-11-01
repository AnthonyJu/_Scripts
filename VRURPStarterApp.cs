using QFramework;

public class VRURPStarterApp : Architecture<VRURPStarterApp>
{
    protected override void Init()
    {
        // 注册Model
        RegisterModel<IRuntimeModel>(new RuntimeModel());

        // 注册System
        RegisterSystem<ISoundSystem>(new SoundSystem());
    }
}