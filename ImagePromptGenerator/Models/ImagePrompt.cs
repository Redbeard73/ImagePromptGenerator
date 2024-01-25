namespace ImagePromptGenerator.Models;

public class ImagePrompt
{
    public Guid uuid = new Guid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    
    public ImagePrompt(Guid? p_uuid = null)
    {
        if (p_uuid != null)
        {
            uuid = (Guid) p_uuid;
            LoadPrompt(p_uuid);
        }
    }

    private void LoadPrompt(Guid? p_uuid)
    {
        throw new NotImplementedException();
    }

    public ImagePrompt(string name, string? description)
    {
        Name = name;
        Description = description;
    }
    
    
    public string? Subject { get; set; }
    public string? Medium { get; set; }
    public string? Style { get; set; }
    public string? Resolution { get; set; }
    public string? AdditionalDetails { get; set; }
    public string? Color { get; set; }
    public string? Lighting { get; set; }
    
    
}