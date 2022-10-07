namespace Periodic.Client.Services.ElementService
{
    public interface IElementService
    {
        List<Element> Elements { get; set; }
        Task GetElements();
    }
}
