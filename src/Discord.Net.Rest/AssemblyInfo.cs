using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Discord.Net.Rpc")]
[assembly: InternalsVisibleTo("Discord.Net.WebSocket")]
[assembly: InternalsVisibleTo("Discord.Net.Webhook")]
[assembly: InternalsVisibleTo("Discord.Net.Commands")]
[assembly: InternalsVisibleTo("Discord.Net.Tests")]
[assembly: InternalsVisibleTo("Discord.Net.Tests.Unit")]
[assembly: InternalsVisibleTo("Discord.Net.SlashCommands")]

[assembly: TypeForwardedTo(typeof(Discord.Embed))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedBuilder))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedBuilderExtensions))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedAuthor))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedAuthorBuilder))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedField))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedFieldBuilder))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedFooter))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedFooterBuilder))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedImage))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedProvider))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedThumbnail))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedType))]
[assembly: TypeForwardedTo(typeof(Discord.EmbedVideo))]
