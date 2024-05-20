namespace Web.Services;

public class MEME
{
    public class LineService : ILineService
{
    private readonly MemeService _memeService;
 
    public LineService()
    {
        _memeService = new MemeService();
    }
 
    public async Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message)
    {
      
        if (message.Contains("梗圖"))
        {
            List<MemeModel> data = await _memeService.List();  //呼叫自己定義的服務
             int index=  (new Random()).Next(0, data.Count);  //取亂數
             
            return  new List<ISendMessage>
            {
               new ImageMessage(data[index].src,data[index].src,null),
            };
        }
 
 
        var result = null as List<ISendMessage>;
 
        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a text event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
 
    public async Task<List<ISendMessage>> ProcessStickerEventMessageAsync(string channelId, string userId,
        string packageId, string stickerId)
    {
        var result = null as List<ISendMessage>;
 
        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a sticker event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
 
    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId,
        string originalContentUrl,
        string previewImageUrl)
    {
        var result = null as List<ISendMessage>;
 
        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
 
    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId, Image image)
    {
        var result = null as List<ISendMessage>;
 
        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
 
    public async Task<List<ISendMessage>> ProcessVideoEventMessageAsync(string channelId, string userId,
        string originalContentUrl, string previewImageUrl)
    {
        var result = null as List<ISendMessage>;
 
        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a video event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
 
    public async Task<List<ISendMessage>> ProcessAudioEventMessageAsync(string channelId, string userId,
        string originalContentUrl, int duration)
    {
        var result = null as List<ISendMessage>;
 
        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a audio event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
 
    public async Task<List<ISendMessage>> ProcessLocationEventMessageAsync(string channelId, string userId,
        string title, string address, float latitude, float longitude)
    {
        var result = null as List<ISendMessage>;
 
        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a location event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
}
}