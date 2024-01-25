using ImagePromptGenerator.Models;

namespace ImagePromptGenerator.Services;

public class ImagePromptService : IImagePromptService
{
    public ImagePromptService()
    {
        
    }
    public ImagePromptService(ImagePrompt p_prompt)
    {
        m_prompt = p_prompt;
    }

    private ImagePrompt m_prompt { get; set; }

    public void SetImagePrompt(Guid p_uuid)
    {
        m_prompt = new ImagePrompt(p_uuid);
    }
    public void SetImagePrompt(ImagePrompt p_prompt)
    {
        m_prompt = p_prompt;
    }
    public void LoadImagePrompt()
    {
        throw new NotImplementedException();
    }
    public void SaveImagePrompt()
    {
        throw new NotImplementedException();
    }
}