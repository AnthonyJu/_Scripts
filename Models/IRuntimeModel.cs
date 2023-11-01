using QFramework;

interface IRuntimeModel : IModel
{
    /// <summary>
    /// Model ʾ��
    /// </summary>
    string ModelStr { get; set; }
}

public class RuntimeModel : AbstractModel, IRuntimeModel
{
    public string ModelStr { get; set; }

    protected override void OnInit()
    {
        ModelStr = "Hello World!";
    }
}
