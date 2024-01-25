namespace ImagePromptGenerator.Models;

public class ImagePrompt
{
    public Guid uuid = new Guid();
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    
    public ImagePrompt(Guid? p_uuid = null)
    {
        if ( p_uuid == null ) return;
        uuid = (Guid) p_uuid;
        LoadPrompt(p_uuid);
    }

    public ImagePrompt(string name, string? description)
    {
        Name = name;
        Description = description;
    }
    

    private void LoadPrompt(Guid? p_uuid)
    {
        throw new NotImplementedException();
    }
    
    public Dictionary<float, ImageObject> Subject { get; set; }
    public Dictionary<float, AttributeClasses.Medium> MediumAttributes { get; set; }
    public Dictionary<float, AttributeClasses.Style> StyleAttributes { get; set; }
    public AttributeClasses.Resolution ResolutionAttribute { get; set; }
    public Dictionary<float, Attribute> AdditionalDetails { get; set; }
    public Dictionary<float, ImageObject> Background { get; set; }
    public Dictionary<float, AttributeClasses.Color> ColorAttributes { get; set; }
    public Dictionary<float, AttributeClasses.Lighting> LightingAttributes { get; set; }
    public Dictionary<float, AttributeClasses.Artist> ArtistAttributes { get; set; }
    public Dictionary<float, AttributeClasses.Location> Location { get; set; }
    public AttributeClasses.Date DateAttribute { get; set; }
    public AttributeClasses.Orientation OrientationAttribute { get; set; }
    public AttributeClasses.Perspective PerspectiveAttribute { get; set; }
    
    public void SetDate(DateTime p_dateTime)
    {
        DateAttribute = new AttributeClasses.Date(p_dateTime);
    }
    
    public void SetOrientation(AttributeClasses.Orientation p_orientation)
    {
        OrientationAttribute = p_orientation;
    }
    
    public void SetPerspective(AttributeClasses.Perspective p_perspective)
    {
        PerspectiveAttribute = p_perspective;
    }

    public void AddAttribute(Attribute p_attribute)
    {
        switch (p_attribute)
        {
            case AttributeClasses.Medium medium:
                MediumAttributes.Add(0, medium);
                break;

            case AttributeClasses.Style style:
                StyleAttributes.Add(0, style);
                break;

            case AttributeClasses.Artist artist:
                ArtistAttributes.Add(0, artist);
                break;

            case AttributeClasses.Location location:
                Location.Add(0, location);
                break;

            case AttributeClasses.Color color:
                ColorAttributes.Add(0, color);
                break;

            case AttributeClasses.Lighting lighting:
                LightingAttributes.Add(0, lighting);
                break;

            default:
                AdditionalDetails.Add(0, p_attribute);
                break;
        }
    }
    
    
    
}