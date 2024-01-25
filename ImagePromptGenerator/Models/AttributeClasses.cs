using System.Globalization;

namespace ImagePromptGenerator.Models;

public class AttributeClasses
{
    public class Medium : Attribute
    {
        public Medium() : base()
        {
            AttributeTypes.Add(AttributeTypesLk.Medium.ToString());
        }
    }

    public class Style : Attribute
    {
        public Style() : base()
        {
            AttributeTypes.Add(AttributeTypesLk.Style.ToString());
        }
    }

    public class Artist : Attribute
    {
        public Artist() : base()
        {
            AttributeTypes.Add(AttributeTypesLk.Artist.ToString());
        }
    }

    public class Location : Attribute
    {
        public Location() : base()
        {
            AttributeTypes.Add(AttributeTypesLk.Location.ToString());
        }
    }

    public class Date : Attribute
    {
        public Date(DateTime p_dateTime) : base()
        {
            Value = p_dateTime.ToString(CultureInfo.InvariantCulture);
        }
    }

    public class Resolution : Attribute
    {
        public Resolution(ResolutionTypesLk p_typesLk = ResolutionTypesLk.Resolution_512x512) : base()
        {
            if(p_typesLk != ResolutionTypesLk.UnSet)
                Value = p_typesLk.ToString();
        }
    }

    public class Color : Attribute
    {
        public Color() : base()
        {
            AttributeTypes.Add(AttributeTypesLk.Color.ToString());
        }
    }

    public class Lighting : Attribute
    {
        public Lighting() : base()
        {
            AttributeTypes.Add(AttributeTypesLk.Lighting.ToString());
        }
    }

    public class Orientation : Attribute
    {
        public Orientation(OrientationTypesLk p_typeLk) : base()
        {
            if(p_typeLk != OrientationTypesLk.UnSet)
                Value = p_typeLk.ToString();
        }
    }

    public class Perspective : Attribute
    {
        public Perspective(PerspectiveTypesLk p_typeLk = PerspectiveTypesLk.UnSet) : base()
        {
            if(p_typeLk != PerspectiveTypesLk.UnSet)
                Value = p_typeLk.ToString();
        }
    }
}

public enum ResolutionTypesLk
{
    UnSet,
    Resolution_512x512,
    Resolution_1024x1024,
    Resolution_1920x1080,
    Resolution_2560x1440,
    Resolution_3840x2160
    // Add more resolutions as needed
}

public enum OrientationTypesLk
{
    UnSet,
    Landscape,
    Portrait,
    Square,
    Panoramic,
    Horizontal,
    Vertical,
    Diagonal,
}

public enum PerspectiveTypesLk
{
    UnSet,
    FirstPerson,
    POV,
    Downward,
    Upward,
    Birdseye,
    Wormseye,
    Aerial,
    GroundLevel,
    EyeLevel,
    HighAngle,
    LowAngle,
    Oblique,
    StraightOn,
    Slanted,
    Tilted,
    Horizontal,
    Vertical,
    Diagonal,
}

public enum AttributeTypesLk
{
    UnSet,
    Medium,
    Style,
    Artist,
    Location,
    Date,
    Resolution,
    Color,
    Lighting,
    Orientation,
    Perspective
}

public enum MediumTypes
{
    Unset,
    Painting,
    Sculpture,
    Drawing,
    Print,
    Photograph,
    Installation,
    Film,
    Video,
    Performance,
    Architecture,
    Design,
    Other
}