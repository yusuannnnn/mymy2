using System.Drawing;
using Line.Messaging;
using Line.Messaging.Webhooks;

public class LineService : ILineService
{
    public LineService()
    {
    }

    public async Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message)
    {
        var result = null as List<ISendMessage>;

        /*
        if (message.Contains("17"))
        {
            return  new List<ISendMessage>
            {
                new ImageMessage("https://megapx-assets.dcard.tw/images/3b3f8969-8fa8-421e-ad6a-349e0fd4f4b1/1280.jpeg"
                    ,"https://megapx-assets.dcard.tw/images/3b3f8969-8fa8-421e-ad6a-349e0fd4f4b1/1280.jpeg",null),
            };
        }*/
    
        
        result = new List<ISendMessage>
        Random rnd = new();
        int Index= rnd.Next(0, 3);//0 1 2
        string[] imgeUrl = new string[]
        {
            "https://megapx-assets.dcard.tw/images/3b3f8969-8fa8-421e-ad6a-349e0fd4f4b1/1280.jpeg"
            "https://megapx-assets.dcard.tw/images/3b3f8969-8fa8-421e-ad6a-349e0fd4f4b1/1280.jpeg"
            "https://megapx-assets.dcard.tw/images/3b3f8969-8fa8-421e-ad6a-349e0fd4f4b1/1280.jpeg"
        };
        
        return  new List<ISendMessage>
        {
            new ImageMessage(imgeUrl[index]imgeUrl[index]
                ,"https://megapx-assets.dcard.tw/images/3b3f8969-8fa8-421e-ad6a-349e0fd4f4b1/1280.jpeg",null),
        };
        
        
        
        {
            new ImageMessage("https://megapx-assets.dcard.tw/images/3b3f8969-8fa8-421e-ad6a-349e0fd4f4b1/1280.jpeg"
                ,"https://megapx-assets.dcard.tw/images/3b3f8969-8fa8-421e-ad6a-349e0fd4f4b1/1280.jpeg",null),
            new TextMessage($"Receive a text event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessStickerEventMessageAsync(string channelId, string userId,string packageId, string stickerId)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a sticker event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId,string originalContentUrl,
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

    public async Task<List<ISendMessage>> ProcessVideoEventMessageAsync(string channelId, string userId,string originalContentUrl, string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a video event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessAudioEventMessageAsync(string channelId, string userId,string originalContentUrl, int duration)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a audio event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessLocationEventMessageAsync(string channelId, string userId,string title, string address, float latitude, float longitude)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a location event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
}