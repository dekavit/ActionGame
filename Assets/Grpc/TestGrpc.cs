using UnityEngine;
using Grpc.Core;
using Actiongame;
public class TestGrpc : MonoBehaviour
{
    void Start()
    {
        var channel = new Channel("5600g.dyama.net:50051", ChannelCredentials.Insecure);
        var client = new Game.GameClient(channel);

        // リクエストを送信してレスポンスをもらう
        var response = client.Hello(new HelloReq() { Name = "TOM" });
        Debug.Log(response.Msg);
    }
}