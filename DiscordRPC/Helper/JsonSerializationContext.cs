using DiscordRPC.IO;
using DiscordRPC.Message;
using DiscordRPC.RPC.Commands;
using DiscordRPC.RPC.Payload;
using System.Text.Json.Serialization;

namespace DiscordRPC.Helper
{
    [
        JsonSerializable(typeof(CloseCommand)),
        JsonSerializable(typeof(PresenceCommand)),
        JsonSerializable(typeof(RespondCommand)),
        JsonSerializable(typeof(SubscribeCommand)),
        JsonSerializable(typeof(EventPayload)),
        JsonSerializable(typeof(ClosePayload)),
        JsonSerializable(typeof(IPayload)),
        JsonSerializable(typeof(ArgumentPayload<RespondCommand>)),
        JsonSerializable(typeof(ArgumentPayload<PresenceCommand>)),
        JsonSerializable(typeof(ArgumentPayload<CloseCommand>)),
        JsonSerializable(typeof(Handshake)),
        JsonSerializable(typeof(CloseMessage)),
        JsonSerializable(typeof(ConnectionEstablishedMessage)),
        JsonSerializable(typeof(ConnectionFailedMessage)),
        JsonSerializable(typeof(ErrorMessage)),
        JsonSerializable(typeof(IMessage)),
        JsonSerializable(typeof(JoinMessage)),
        JsonSerializable(typeof(JoinRequestMessage)),
        JsonSerializable(typeof(PresenceMessage)),
        JsonSerializable(typeof(ReadyMessage)),
        JsonSerializable(typeof(SpectateMessage)),
        JsonSerializable(typeof(SubscribeMessage)),
        JsonSerializable(typeof(UnsubscribeMessage)),
        JsonSerializable(typeof(RichPresenceResponse)),
    ]

    internal partial class JsonSerializationContext : JsonSerializerContext;
}
