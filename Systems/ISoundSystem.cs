using QFramework;
using UnityEngine.UI;
using HKTools;

interface ISoundSystem : ISystem
{
    /// <summary>
    /// UI 按钮默认音效
    /// </summary>
    void UIButtonDefaultAudio();
}

public class SoundSystem : AbstractSystem, ISoundSystem
{
    protected override void OnInit()
    {
        // UI按钮默认音效事件
        HK_Button.defaultAudio_Event += () => UIButtonDefaultAudio();
    }
    
    public void UIButtonDefaultAudio()
    {
        AudioKit.PlaySound("resources://Audio/DefaultButtonClick"); // 更换音效
    }
}
