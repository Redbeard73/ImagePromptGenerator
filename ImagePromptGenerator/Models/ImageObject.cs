namespace ImagePromptGenerator.Models;

public class ImageObject
{
    public Guid uuid = new Guid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    
    public ImageObject(Guid? p_uuid = null)
    {
        if ( p_uuid == null ) return;
        uuid = (Guid) p_uuid;
        LoadImageObject(p_uuid);
    }

    private void LoadImageObject(Guid? p_uuid)
    {
        throw new NotImplementedException();
    }
}