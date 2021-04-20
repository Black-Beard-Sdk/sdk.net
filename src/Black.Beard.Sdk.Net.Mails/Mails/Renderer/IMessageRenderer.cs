using Bb.Sdk.Net.Mails.Models;

namespace Bb.Sdk.Net.Mails.Renderer
{

    /// <summary>
    /// 
    /// </summary>
    public interface IMessageRenderer
    {

        /// <summary>
        /// generate the render
        /// </summary>
        /// <param name="Model">The model.</param>
        /// <returns></returns>
        RendererResult Render(MessageModelBase Model);
    
    }
}
