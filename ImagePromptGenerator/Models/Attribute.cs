namespace ImagePromptGenerator.Models;

public class Attribute
{
    public Guid uuid = new Guid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? Value { get; set; } = "";
    public float Weight { get; set; } = 0.0f;
    public List<string> AttributeTypes { get; set; } = [];
    
    public Attribute(string p_name, string? p_value, float p_weight = 1.0f)
    {
        Name = p_name;
        Value = p_value;
        Weight = Weight < 0.9f || Weight > 1.3f ? 1.0f : p_weight;
    }

    public Attribute(Guid? p_uuid = null)
    {
        if ( p_uuid == null ) return;
        uuid = (Guid) p_uuid;
        LoadAttribute(p_uuid);
    }

    private void LoadAttribute(Guid? p_uuid)
    {
        throw new NotImplementedException();
    }
}